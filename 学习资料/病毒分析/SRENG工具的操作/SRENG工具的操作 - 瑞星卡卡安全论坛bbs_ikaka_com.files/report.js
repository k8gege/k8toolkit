var report_button_index = 0;
var enableinfo = '举报';

function show_report_button(disableinfo)
{
	if (typeof(disableinfo) == "undefined")
	{
		disableinfo = '已举报';
	}
    var html = '<a name="#r_' + report_button_index + '"></a>';
    html += '<em id="report_' + report_button_index + '_container">';
	//html += '	<a id="report_' + report_button_index + '" href="javascript:void(0);" onclick="send_report(' + report_button_index + ',\'' + disableinfo + '\');">' + enableinfo + '</a>';
    html += '	<a id="report_' + report_button_index + '" href="javascript:void(0);" onclick="createreportdiv(this.id,'+report_button_index+', \''+disableinfo+'\')">' + enableinfo + '</a>';	
	html += '</em>';
    report_button_index++;
	output_html(html);
}

function send_report(id,index, disableinfo)
{
    //sendReportRequest('tools/ajax.aspx?t=report', index, disableinfo);    
    //var message=$('reportmessage'+index).value;
    sendReportRequest('tools/ajax.aspx?t=report', index, disableinfo,id);
}

function output_html(html)
{
    document.write(html);
}

function sendReportRequest(action, button_index, disableinfo,id) {
	if (action && action != '')
	{	
		var oXmlHttp = createXMLHttp();
		oXmlHttp.open("post", action, true);
		oXmlHttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
		oXmlHttp.onreadystatechange = function () {
			if (oXmlHttp.readyState == 4) {
				if (oXmlHttp.status == 200) {
					//report over, disable report link.
					//$("report_" + button_index + "_container").innerHTML = disableinfo;					
					RetrunResult(oXmlHttp.responseXML,button_index,disableinfo,id);
				} else {
					alert("An error occurred: " + oXmlHttp.statusText);
				}
			}
		};
		var queryParm = 'report_url=' + encodeURIComponent(document.location + '#r_' + button_index);
		oXmlHttp.send(queryParm);
	}
}

function RetrunResult(doc,button_index,disableinfo,id)
{
	   var err = doc.getElementsByTagName('error');
		if (err[0] != null && err[0] != undefined)
		{
			if (err[0].childNodes.length > 1) {
				alert(err[0].childNodes[1].nodeValue);
			} else {
				alert(err[0].firstChild.nodeValue);    		
			}
			return;
		}
		else
		{		
		$(id + "_menu").style.display='none';
		$("report_" + button_index + "_container").innerHTML = disableinfo;				
		return;
			}
	
	
	}

function createreportdiv(id,index, disableinfo)
{
	if(!$(id + "_menu"))
	{
	var div = document.createElement("DIV");
	var reportid='reportmessage'+index;
	div.id = id + "_menu";
	div.style.display = "none";
	div.style.width='100px';
	div.className='popupmenu_popup';
	var html ='<table border="0" cellpadding="0" cellspacing="0" width="100%">';
	html +='<tr>';
	html +='<td style="height:30px; text-align:center;"><a href="javascript:void(0);" onclick="send_report(\''+id+'\','+index+',\''+disableinfo+'\')">确认举报</a></td>';
	html +=' </tr>';
	html +='</table>';
  div.innerHTML =html;
  document.body.appendChild (div);
	}
	showMenu(id);
	}