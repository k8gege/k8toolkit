<!--#include file="conn.asp"--> 
<b><a href="say.asp">发表帖子</a></b><br><br> 
<div align="center"> 
<center> 
<table border="0" cellpadding="0" cellspacing="0" style="border-collapse: collapse; " bordercolor="#000000" width="100%" height="26"> 
<tr> 
<td width="17%"><b>作者</b></td> 
<td width="83%"><b>主题</b></td> 
</tr> 
</table> 
</center> 
</div><hr size="1"> 
<%i=1 
set showbbs=conn.execute("select*from bbs order by id desc") 
do while not showbbs.eof 
%> 
<div align="center"> 
<center> 
<table border="0" cellpadding="0" cellspacing="0" style="border-collapse: collapse; " bordercolor="#000000" width="100%" height="20"> 
<tr> 
<td width="17%"><%=showbbs("name")%>　</td> 
<td width="83%"> 
<a href="show.asp?id=<%=showbbs("id")%>"><%=showbbs("title")%></a></td> 
</tr> 
</table> 
</center> 
</div><hr size="1"> 
<%i=i+1 
if i>50 then exit do 
showbbs.movenext 
Loop 
showbbs.Close 
set showbbs=nothing 
%> 
