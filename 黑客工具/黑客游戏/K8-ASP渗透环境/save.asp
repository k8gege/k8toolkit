<!--#include file="conn.asp"--> 
<%name=Replace(Request.Form("name"),"'","''") 
title=Replace(Request.Form("title"),"'","''") 
body=Replace(Request.Form("body"),"'","''") 
%> 
<%if name="" or title="" or body="" then%> 
请<a href="****:history.go(-1)">后退</a>填写完整资料，你才能发表帖子！ 
<%else%> 
<%set savebbs=conn.execute("insert into bbs(name,title,body)values('"&name&"','"&title&"','"&body&"')")%> 
发表成功！<a href="index.asp">查看帖子</a> 
<%end if 
set savebbs=nothing 
%> 