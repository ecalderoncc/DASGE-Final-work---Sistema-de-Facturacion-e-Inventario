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
	include('AdmUsu-Vista.php');
	$codigo ="";
	$busca="";
	$registros;
	$abuscar="";
	if ($_POST['enviar']) 
	{
		if($_POST['cod']!="" && $_POST['nom']!="")
		{
			modificar_usuarios($_POST['cod'],$_POST['nom'],$_POST['ape'],$_POST['telf'],$_POST['loc']);
		}
	}
	else
	{
		if ($_POST['eliminar']) 
		{
			if($_POST['cod']!="")
			{
				Eliminar_USR($_POST['cod']);
			}
		}
		else
		{
			if ($_POST['Buscar']) 
			{
				$registros = Todos_usuarios();
				$busca =  buscar();
			}
			else
			{
				if ($_POST['Busco'])
				{
					$abuscar = $_POST['valor'];
					$busca =  buscar();
					$registros = Buscar_Todos_usuarios($abuscar);
				}
			}
		}
			
	}
	
	echo cabecera();
	echo $busca;
	echo formulaio();
	$registros = Todos_usuarios();
		if ($_POST['Busco'])
				{
					$registros = Buscar_Todos_usuarios($abuscar);
				}
	while ($reg=mysql_fetch_array($registros))
	{
		echo '<tr> <th scope="col">';
		echo '<input type="radio" name="update" value="'.$reg[0].'"  onclick="setReadOnly(this)">';
		echo '</th> <th scope="col"> <input type="text" name="Apellidos" readonly style="background-color:#eeeeee" id="Apellidos" value="'.$reg[2].'" ></th>';
		echo '<th scope="col"> <input type="text" name="Nombres" readonly style="background-color:#eeeeee" id="Nombres" value="'.$reg[1].'" ></th>';
		echo '<th scope="col"> <input type="text" name="Local" readonly style="background-color:#eeeeee" id="Local" value="'.$reg[4].'" ></th>';
		echo '<th scope="col"> <input type="text" name="Telefono" readonly style="background-color:#eeeeee" id="Telefono" value="'.$reg[3].'" ></th>  </tr>';
	}
	echo pie();

?>
    
	
	
