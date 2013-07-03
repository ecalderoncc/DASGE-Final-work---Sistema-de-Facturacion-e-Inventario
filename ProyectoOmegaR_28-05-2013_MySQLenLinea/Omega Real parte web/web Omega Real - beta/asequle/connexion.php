<?php 
function Conectarse() 
{ 
   if (!($link=mysql_connect("localhost","axesoval","Report$51"))) 
   { 
      echo "Error conectando a la base de datos."; 
      exit(); 
   } 
   if (!mysql_select_db("axesoval_BD_RUL",$link)) 
   { 
      echo "Error seleccionando la base de datos."; 
      exit(); 
   } 
   return $link; 
} 
?>