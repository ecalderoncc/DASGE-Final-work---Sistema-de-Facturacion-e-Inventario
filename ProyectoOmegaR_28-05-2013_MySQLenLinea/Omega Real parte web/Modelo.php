<?php
	include('Sql.php');
	function progreso()
	{
		$cantidad=0;
		$registros = Seleccionar_Todas_Las_Donaciones();
		while ($reg=mysql_fetch_array($registros))
		{
			$cantidad =$cantidad+ $reg[7];
			//$moneda = $reg[9];
		}
		if($cantidad < 60000)
		{
			$porcentaje = (100 * $cantidad)/60000;
		}
		else
		{
			$porcentaje = 100;
		}
		return $porcentaje;
	}
	function Guardar_Users($Apelli,$dni,$email,$user,$local,$Nombre,$password,$rol,$telefono)
	{

		Guardar_Usuarios($Apelli,$dni,$email,$user,$local,$Nombre,$password,$rol,$telefono);

	}
	
	function logeo($usuario, $password)
	{
		$existe="no";
		$codigo=0;
		$rol=1;
		$registros = seleccionar_login($usuario);
		while ($reg=mysql_fetch_array($registros))
		{
			$existe = $reg[1];
			$codigo = $reg[0];
		}
		if($existe != "no" && $password == $existe)
		{
			//Obtener el Id del usuario en la BD
			$uid = $codigo;
			//Iniciar una sesion de PHP
			session_start();
			//Crear una variable para indicar que se ha autenticado
			$_SESSION['autenticado']    = 'SI';
			//Crear una variable para guardar el ID del usuario para tenerlo siempre disponible
			$_SESSION['uid']       		= $uid;	
			?>
			<form name="formulario" method="post" action="bienvenida.php">
				<input type="hidden" name="idUsr" value='<?php echo $uid ?>' />
			</form>
			<?php
		}
		else
		{
			?>
			<form name="formulario" method="post" action="index.php">
				<input type="hidden" name="msg_error" value="1">
			</form>
			<?php
		}
		?>
		<script type="text/javascript"> 
            //Redireccionar con el formulario creado
            document.formulario.submit();
        </script>
        <?php
	}
	function Todos_usuarios()
	{
		$registros = Seleccionar_Todos_Los_Usuarios();
		return $registros;
	}
	function Buscar_Todos_usuarios($Valor)
	{
		$registros = buscar_Usuarios($Valor);
		return $registros;
	}
	function Todos_los_productos($alamcen)
	{
		$registros = Todos_productos($alamcen);
		return $registros;
	}
	function Todos_los_almacenes()
	{
		$registros = Todos_almacenes();
		return $registros;
	}
	function modificar_usuarios($codigo,$nombre,$apellido,$telefono,$local)
	{
		Actualizar_usuarios($codigo,$nombre,$apellido,$telefono,$local);
	}
	function Eliminar_USR($codigo)
	{
		Eliminar_usuarios($codigo);
	}
	
	
	

?>