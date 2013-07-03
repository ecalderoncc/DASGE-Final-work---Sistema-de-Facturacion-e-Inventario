<?php
	include("connexion.php");/*incluye la conexion para todos*/
	
	function seleccionar_login($usuario)
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="SELECT UsuCod, UsuPass ";
		$sql.="FROM Usuarios WHERE UsuId='".$usuario."' and UsuRol ='3'; ";
		$registros=mysql_query($sql,$link) or die("Problemas al loguearse:".mysql_error());
		mysql_close($link);
		return($registros);
	}
	function Seleccionar_Todos_Los_Usuarios()
	{
		
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="SELECT UsuCod as 'Codigo', UsuNom as 'Nombre', UsuApe as 'Apellido',UsuTelef as 'Telefono',almacen.AlmNombre as 'Local' ";
		$sql.="FROM Usuarios,almacen WHERE UsuLocal = almacen.AlmCod;";
		$registros=mysql_query($sql,$link) or die("Problemas al seleccionar los usuarios:".mysql_error());
		mysql_close($link);
		return($registros);
	}
	function buscar_Usuarios($Valor)
	{
		
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="SELECT UsuCod as 'Codigo', UsuNom as 'Nombre', UsuApe as 'Apellido',UsuTelef as 'Telefono',almacen.AlmNombre  as 'Local' ";
		$sql.="FROM Usuarios,almacen WHERE UsuLocal = almacen.AlmCod AND (UsuNOM LIKE '%".$Valor."%' OR UsuApe LIKE '%".$Valor."%' OR UsuTelef LIKE '%".$Valor."%' OR almacen.AlmNombre LIKE '%".$Valor."%');";
		$registros=mysql_query($sql,$link) or die("Problemas al seleccionar los usuarios:".mysql_error());
		mysql_close($link);
		return($registros);
	}
	function Todos_productos($almacen)
	{
		
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="Select productos.ProCod,productos.ProdNom , productos.ProdUnidad ,alm_prod_stock.ProCant , productos.ProdCosto,productos.ProdIGV,productos.ProdPrecio, almacen.AlmNombre,almacen.AlmDesc
 FROM alm_prod_stock 
INNER JOIN almacen ON alm_prod_stock.AlmCod = almacen.AlmCod
INNER JOIN productos ON alm_prod_stock.ProCod = productos.ProCod
WHERE alm_prod_stock. AlmCod = '";
		$sql.=$almacen."';";
		$registros=mysql_query($sql,$link) or die("Problemas al seleccionar los productos:".mysql_error());
		mysql_close($link);
		return($registros);
	}
	function Todos_almacenes()
	{
		
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="Select * FROM almacen;";
		$registros=mysql_query($sql,$link) or die("Problemas al seleccionar los productos:".mysql_error());
		mysql_close($link);
		return($registros);
	}

	function Guardar_Usuarios($Apelli,$dni,$email,$user,$local,$Nombre,$password,$rol,$telefono)
	{
		/*include("connexion.php");*/ 
		try{
		$link=Conectarse(); 
		$loc="";
		$sql="SELECT almacen.AlmCod ";
		$sql.="FROM almacen WHERE AlmNombre = '".$local."';";
		$registros=mysql_query($sql,$link) or die("Problemas al seleccionar los productos:".mysql_error());
		while ($reg=mysql_fetch_array($registros))
		{
			$loc=$reg[0];
		}
   		$link=Conectarse(); 
		$sql="INSERT INTO Usuarios(UsuApe,USUDNI,UsuEmail,UsuId,UsuLocal,UsuNom,UsuPass,UsuRol,UsuTelef) VALUES(";
		$sql.="'".$Apelli."',";
		$sql.="'".$dni."',";
		$sql.="'".$email."',";
		$sql.="'".$user."',";
		$sql.="'".$loc."',";
		$sql.="'".$Nombre."',";
		$sql.="'".$password."',";
		$sql.="'".$rol."',";				
		$sql.="'".$telefono."');";
		$registros=mysql_query($sql,$link) or die("Problemas al guardar el usuario:".mysql_error());
		mysql_close($link);
		}
		catch(Exception $e)
		{
		}
	}
		function Eliminar_usuarios($codigo)
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="DELETE FROM Usuarios ";
		$sql.="WHERE UsuCod = ".$codigo.";";
		$registros=mysql_query($sql,$link) or die("Problemas al eliminar:".mysql_error());
		mysql_close($link);
	}

	function Actualizar_usuarios($codigo,$nombre,$apellido,$telefono,$local)
	{
		/*include("connexion.php");*/ 
		try{
		$link=Conectarse(); 
		$loc="";
		$sql="SELECT almacen.AlmCod ";
		$sql.="FROM almacen WHERE AlmNombre = '".$local."';";
		$registros=mysql_query($sql,$link) or die("Problemas al seleccionar los productos:".mysql_error());
		while ($reg=mysql_fetch_array($registros))
		{
			$loc=$reg[0];
		}
		mysql_close($link);
   		$link=Conectarse(); 
		$sql="UPDATE Usuarios ";
		$sql.="SET ";				
		$sql.="UsuNom ='".$nombre."', UsuApe ='".$apellido."', UsuTelef ='".$telefono."', UsuLocal ='".$loc."' ";
		$sql.="WHERE UsuCod = ".$codigo.";";
		$registros=mysql_query($sql,$link) or die("Problemas al cambiar el uso de premios:".mysql_error());
		mysql_close($link);
		}
		catch(Exception $e)
		{
		}
	}
	
?>
