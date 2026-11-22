<!--
//scroll,imgResize,vcode,cookie,style
//滚屏脚本
var currentpos,timer;
function initializeScroll() { timer=setInterval("scrollwindow()",80);} 
function scrollclear(){clearInterval(timer);}
function scrollwindow() {currentpos=document.documentElement.scrollTop;window.scroll(0,++currentpos);if (currentpos != document.documentElement.scrollTop) scrollclear();} 
document.onmousedown=scrollclear;
document.ondblclick=initializeScroll;

//***
//评论验证
function VCode(tt)
{
	var s = "";
	var v = 15;
	if (tt.length>10){
		tt = tt.substr(0, 10);
	}
	for(var i=0; i<tt.length; i++){
		if (i==v || i==tt.length-1 && v>=tt.length){
			s += v + tt.charCodeAt(i);
		}else{
			s += tt.charCodeAt(i);
		}
	}
	return s;
}

//***

function setCookie(name, value)		//cookies设置
{
	var argv = setCookie.arguments;
	var argc = setCookie.arguments.length;
	var expires = (argc > 2) ? argv[2] : null;
	if(expires!=null){
		var LargeExpDate = new Date ();
		LargeExpDate.setTime(LargeExpDate.getTime() + (expires*1000*3600*24));
	}
	document.cookie = name + "=" + escape (value) + "; path=/;" +((expires == null) ? "" : (" expires=" +LargeExpDate.toGMTString()));
}

function getCookie(Name)			//cookies读取
{
	var search = Name + "=";
	if(document.cookie.length > 0){
		offset = document.cookie.indexOf(search);
		if(offset != -1)	{
			offset += search.length;
			end = document.cookie.indexOf(";", offset);
			if(end == -1){
				end = document.cookie.length;
			}
			return unescape(document.cookie.substring(offset, end));
		}
	}
	return "";
}

//***

-->