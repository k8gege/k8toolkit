;Author:Cryin
;copy the NASM assembler, and use the command
;nasm.exe -f bin boot.asm
;Date:2010年05月14日
;连接：http://hi.baidu.com/justear
;安装方法：
;我用的是VC，写一个简单的安装程序；主要工作如下
;将原始MBR拷贝到第二扇区，并将本程序编译生成的二进制代码拷贝到第一扇区，另外请确认第一扇区的分区表信息
;与原始MBR的分区表信息完全相同，不同机器分区表都不尽相同
;密码为：kevin
;注：一扇区512个字节，空间比较小暂时没有添加修改密码功能，一时兴起之作，只为误乐。
;希望能认识高手，能学到真正的技术。


;=================================================================
CPU 486
BITS 16

        xor ebx,ebx
        mov ds,bx
      mov ax,[0x413]           ;40:13,BIOS数据区保存常规的内存大小,单位:KBs.
      and al,0xfc        ;要求分配的物理内存地址,以页作为基地址
        sub ax,4
        mov [0x413],ax           ;开辟一段内存，实现程序的驻留
        shl ax,0x6               ;bx *= 1024 / 16 (KBs->线性地址=KBs*1024,段:除以16)
        mov es,ax                ;存储段地址

        mov si,0x7c00            ;拷贝代码到驻留内存中执行
        xor di,di                ;偏移地址为0
      mov cx,0x100             ;拷贝512
        rep movsw

      mov ax,0x201
        mov cl,0x2
        cdq                       ;Convert Double to Quad (386+)把edx扩展为eax的高位，也就是说变为64位。

        push es
      push word password          
        retf                     
;=====================================================================   
password:                        ;校验密码
        MOV SI,ShowAuthorMessage
     CALL SHOWMESSAGE
     mov si,ShowEnterMessage
     CALL SHOWMESSAGE
     CALL GETKEY
     cmp cx,PassWordLength
     je bootloader
again:                       ;第二次校验密码
     mov si,ShowError
     call SHOWMESSAGE
     mov si,ShowEnterMessage
     CALL SHOWMESSAGE
     CALL GETKEY
     cmp cx,PassWordLength
     je bootloader
lasttime:                     ;最后一次校验密码
     mov si,ShowLastError
     call SHOWMESSAGE
     mov si,ShowEnterMessage
     CALL SHOWMESSAGE
     CALL GETKEY
     cmp cx,PassWordLength
     je bootloader
wrong:                       ;登陆失败
     mov si,ShowByeBye
     CALL SHOWMESSAGE
     jmp $

bootloader:                      ;校验密码成功，开始登陆

     mov si,ShowWelcome
     call SHOWMESSAGE
     CALL GETENTER
    
        mov es,dx
        mov eax,0x201
        mov ecx,02h              ;读第二扇区的原始MBR引导开机
        mov edx,0x80
        mov ebx,0x7c00          
        int 0x13

        popad
        pop ds
        pop sp
        
     jmp 0x0:0x7c00    ;jmp to original mbr from hard drive
;======================================================================
SHOWMESSAGE:
    mov bx,0007h                                    ; Page Number = 0, Attribute = 07h
     mov ah,0Eh                                      ; Function 0Eh: Teletype Output
     cs lodsb                                                  ; load the first character
Next_Char:
     int 10h
     cs lodsb                                        ; al = next character
     or al,al                                        ; last letter?
     jnz Next_Char                                   ; if not print next letter
RETURNBACK:
     ret
;===========================================================
GETKEY:
     XOR CX,CX
LOOP:
     MOV AH,0
     INT 16H
     mov bl,al
     AND BX,0xFF
     CMP AL,0DH                                  ;判断是否Enter键
     JZ RETURNBACK
     ADD CX,bx                                   ;存入CX中
     MOV AL,2AH
     MOV BX,07H                         
     MOV AH,0EH
     INT 10H                                      ;显示*号，继续等待输入
     JMP LOOP
;======================================================
GETENTER:                                           ;判断是否Enter键，如果是则返回，若不是继续等待输入
     MOV AH,0
     INT 16H
     AND AX,0xFF
     CMP AL,0DH
     JNZ GETENTER
     RET
;=======================================================
ShowAuthorMessage db   10, 13, "Author:sbha0909@yahoo.com.cn", 0
ShowEnterMessage db   10, 13, "Enter PassWord:", 0
ShowError         db   10, 13, "wrong password!...Try again", 0
ShowLastError     db   10, 13, "wrong password!...Try Last Time", 0
PassWordLength    EQU   021DH   ;"lenght of 'kevin'"
ShowByeBye        db   10, 13, "Sorry...Please Don't Use My PC!", 0
ShowWelcome     db   10, 13, "Welcome kevin...!Press Enter to load Windows", 0
;=================================================================
            
CodeEnd EQU $ 

times 510-($-$$) db 0                    ;填充00h
Boot_Signature            dw 0AA55h
;===============================================================
;程序结束，使用nasm.exe -f bin boot.asm编译生成bin文件就可以在安装程序中使用
;相关文章：http://bbs.pediy.com/showthread.php?t=121414 