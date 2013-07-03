<?php 
function Conectarse() 
{ 
   if (!($link=mysql_connect("OmegaR.db.10635821.hostedresource.com","OmegaR","Honguito!1"))) 
   { 
      echo "Error conectando a la base de datos."; 
      exit(); 
   } 
   if (!mysql_select_db("OmegaR",$link)) 
   { 
      echo "Error seleccionando la base de datos."; 
      exit(); 
   } 
   return $link; 
} 
?>