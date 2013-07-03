<?php
session_start();

if ( ! ($_SESSION['autenticado'] == 'SI' && isset($_SESSION['uid'])) )
{
?>
		<form name="formulario" method="post" action="../../index.php">
			<input type="hidden" name="msg_error" value="2">
		</form>
		<script type="text/javascript"> 
			document.formulario.submit();
		</script>

<?php
}
	include('Modelo.php');
	include('bienvenida-vista.php');

	
	echo principal();

?>
    
	
	
