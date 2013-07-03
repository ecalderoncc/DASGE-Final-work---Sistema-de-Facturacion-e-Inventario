<?php
	include('Modelo.php');
	include('Principal.php');
	if (isset($_POST["password"])) { 
	$us = $_POST["usuario"];
	$ps = $_POST["password"];
	
	logeo($us,$ps);
	}
	
	echo principal();

?>
    
	
	
