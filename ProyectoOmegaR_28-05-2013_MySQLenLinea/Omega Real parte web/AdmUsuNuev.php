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
	include('AdmUsuNuev-Vista.php');
	function validateUsername($name){
		//NO cumple longitud minima
		if(strlen($name) < 4)
			return false;
		//SI longitud pero NO solo caracteres A-z
		else if(!preg_match("/^[a-zA-Z]+$/", $name))
			return false;
		// SI longitud, SI caracteres A-z
		else
			return true;
	}
	function validatePassword1($Password){
		//NO tiene minimo de 5 caracteres o mas de 12 caracteres
		if(strlen($Password) < 5 || strlen($Password) > 12)
			return false;
		// SI longitud, NO VALIDO numeros y letras
		else if(!preg_match("/^[0-9a-zA-Z]+$/", $Password))
			return false;
		// SI rellenado, SI email valido
		else
			return true;
	}
	function validatePassword2($Password, $Verifica){
		//NO coinciden
		if($Password != $Verifica)
			return false;
		else
			return true;
	}
	
	function validateEmail($email){
		//NO hay nada escrito
		if(strlen($email) == 0)
			return false;
		// SI escrito, NO VALIDO email
		else if(!filter_var($_POST['email'], FILTER_SANITIZE_EMAIL))
			return false;
		// SI rellenado, SI email valido
		else
			return true;
	}

	$Usuario = "";
	$UsuarioValue = "";
	$Password = "";
	$PasswordValue="";
	$Verifica = "";
	$email = "";
	$emailValue = "";
	$Nombre="";
	$Apellido="";
	$DNI ="";
	$Telefono="";
	$Localidad="";
	//$content="";
	$rol="";
	if ($_POST['Guardar']) 
	{
		if(!validateUsername($_POST['Usuario']))
			$Usuario = "error";
		if(!validatePassword1($_POST['Password']))
			$Password = "error";
		if(!validatePassword2($_POST['Password'], $_POST['Verifica']))
			$Verifica = "error";
		if(!validateEmail($_POST['email']))
			$email = "error";
		$UsuarioValue = $_POST['Usuario'];
		$PasswordValue = $_POST['Password'];
		$emailValue = $_POST['email'];
		$Nombre = $_POST['nombre'];
		$Apellido = $_POST['Apellidos'];
		$DNI = $_POST['DNI'];
		$Localidad = $_POST['Localidad'];
		$Telefono = $_POST['Telefono'];
		$rol = $_POST['Rol'];
		if($Usuario != "error" && $Password != "error" && $Verifica != "error" && $email != "error" && $Telefono != "error")
		{
			Guardar_Users($Apellido,$DNI,$emailValue,$UsuarioValue,$Localidad,$Nombre,$PasswordValue,$rol,$Telefono);
			//$content="guardado correctamente";
		}
			else{
			//	$content="no coincide algo";
			}
	}
	
	echo cabecera();
	//echo $content;
	echo pie();

?>
    
	