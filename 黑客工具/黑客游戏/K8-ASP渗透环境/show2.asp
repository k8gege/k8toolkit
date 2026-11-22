<!--#include file="conn.asp"--> 
<%id=request.querystring("id")%> 
<%set show=conn.execute("select * from bbs where name='"&id&"'")%> 
<a href="index.asp"> 
<b>回到首页</b></a><br><b><a href="say.asp">发表帖子</a></b><br><hr size="1"> 
<table border="1" cellpadding="0" cellspacing="0" style="border-collapse: collapse" bordercolor="#111111" width="100%" height="180"> 
<tr> 
<td width="21%" height="22"><b>作者：</b><%=show("name")%></td> 
<td width="79%" height="22"><b>主题：</b><%=show("title")%></td> 
</tr> 
<tr> 
<td width="100%" colspan="2" height="158" valign="top"><b><br>内容：</b><%=show("body")%></td> 
</tr> 
</table><%set show=nothing%> 
