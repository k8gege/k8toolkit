<%		
dbpath = server.mappath("crack8.mdb")
connstr = "driver={microsoft access driver (*.mdb)};dbq=" & dbpath
set conn = server.createobject("adodb.connection")
conn.open connstr
%>