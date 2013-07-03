<?php
	include("connexion.php");/*incluye la conexion para todos*/
	function Seleccionar_Todos_Premios_Mayores()
	{
		/*include("connexion.php");*/
   		$link=Conectarse(); /*contecta la bd*/
		$sql="SELECT TMPMCO AS 'Codigo',TMPMDS AS 'Descripcion',TMPMCN AS 'Premios disponibles',TMPMPU AS 'Premios usados',TMPMEP AS 'Empresa',TMPMAC AS 'Esta activo' ";
		$sql.="FROM TMPRMY";
		$registros=mysql_query($sql,$link) or die("Problemas al seleccionar los premios mayores:".mysql_error());/*lo pasa a tabla*/
		mysql_close($link);
		return($registros);
	}
	function seleccionar_donar()
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="SELECT TPDNCO ";
		$sql.="FROM TPDONA ;";
		$registros=mysql_query($sql,$link) or die("Problemas al seleccionar las donaciones:".mysql_error());
		mysql_close($link);
		return($registros);
	}
	
	function Seleccionar_Todos_Premios_Instantaneos()
	{
		/*include("connexion.php");*/
   		$link=Conectarse(); 
		$sql="SELECT TMPNCO AS 'Codigo',TMPNDS AS 'Descripcion',TMPNCN AS 'Premios disponibles',TMPNPU AS 'Premios usados',TMPNEP AS 'Empresa',TMPNAC AS 'Esta activo' ";
		$sql.="FROM TMPRMN";
		$registros=mysql_query($sql,$link) or die("Problemas al seleccionar los premios instantaneos:".mysql_error());
		mysql_close($link);
		return($registros);
	}
	function Seleccionar_1_Premios_Instantaneos($RUL)
	{
		/*include("connexion.php");*/
   		$link=Conectarse(); 
		$sql="SELECT TMUSDO.CADOCO AS 'Codigo de Usuario', TMUSDO.CADONO AS 'Nombre', TMUSDO.CADOAP AS 'Apellido Paterno', TMUSDO.CADOAM AS 	'Apellido Materno', TMUSDO.CADOCC AS 'Correo Electronico', TMUSDO.CADODI AS 'Documento de Identidad', 
TMPRMN.TMPNCO AS 'Codigo', TMPRMN.TMPNDS AS 'Descripcion', TMNOEP.TMEPCO AS 'Codigo de Empresa',TMNOEP.TMEPCC AS 'Correo de Empresa' ,TMNOEP.TMEPDD AS 'Direccion de Empresa' ,TMNOEP.TMEPDS AS 'Descripcion de Empresa' ,TMNOEP.TMEPSU AS 'Sucursal de Empresa' ,TMNOEP.TMEPTE AS 'Telefono de Empresa' , 
TPDONA.TPDNFE AS 'Fecha', TPDONA.TPDOMD AS 'Codigo de ladrillo' 
FROM TPDNPN 
INNER JOIN TMPRMN ON TPDNPN.TPPNCO = TMPRMN.TMPNCO 
INNER JOIN TPDONA ON TPDNPN.TPDNCO = TPDONA.TPDNCO 
INNER JOIN TMUSDO ON TPDONA.TMDOCO = TMUSDO.CADOCO 
INNER JOIN TMNOEP ON TMPRMN.TMPNEP = TMNOEP.TMEPCO 
WHERE TPDONA.TPDOMD = '".$RUL."' ;";
		$registros=mysql_query($sql,$link) or die("Problemas al seleccionar los premios instantaneos:".mysql_error());
		mysql_close($link);
		return($registros);
	}
	function Seleccionar_Premios_Instantaneos_Ganados()
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="SELECT TMUSDO.CADOCO AS 'Codigo de Usuario', TMUSDO.CADONO AS 'Nombre', TMUSDO.CADOAP AS 'Apellido Paterno', TMUSDO.CADOAM AS 	'Apellido Materno', TMUSDO.CADOCC AS 'Correo Electronico', TMUSDO.CADODI AS 'Documento de Identidad', ";
		$sql.="TMPRMN.TMPNCO AS 'Codigo', TMPRMN.TMPNDS AS 'Descripcion', TMPRMN.TMPNEP AS 'Empresa', ";
		$sql.="TPDONA.TPDNFE AS 'Fecha' ";
		$sql.="FROM TPDNPN ";
		$sql.="INNER JOIN TMPRMN ON TPDNPN.TPPNCO = TMPRMN.TMPNCO ";
		$sql.="INNER JOIN TPDONA ON TPDNPN.TPDNCO = TPDONA.TPDNCO ";
		$sql.="INNER JOIN TMUSDO ON TPDONA.TMDOCO = TMUSDO.CADOCO ";
		$registros=mysql_query($sql,$link) or die("Problemas al seleccionar los premios instantaneos que se ganó:".mysql_error());
		mysql_close($link);
		return($registros);
	}
	function Seleccionar_Premios_Mayores_Ganados()
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="SELECT TMUSDO.CADOCO AS 'Codigo de Usuario', TMUSDO.CADONO AS 'Nombre', TMUSDO.CADOAP AS 'Apellido Paterno', TMUSDO.CADOAM AS 'Apellido Materno', TMUSDO.CADOCC AS 'Correo Electronico', TMUSDO.CADODI AS 'Documento de Identidad', ";
		$sql.="	TMPRMY.TMPMCO AS 'Codigo', TMPRMY.TMPMDS AS 'Descripcion', TMPRMY.TMPMEP AS 'Empresa', ";
		$sql.="	TPDONA.TPDNFE AS 'Fecha' ";
		$sql.="FROM TPDNPM ";
		$sql.="	INNER JOIN TMPRMY ON TPDNPM.TMPMCO = TMPRMY.TMPMCO ";
		$sql.="	INNER JOIN TPDONA ON TPDNPM.TPDNCO = TPDONA.TPDNCO ";
		$sql.="	INNER JOIN TMUSDO ON TPDONA.TMDOCO = TMUSDO.CADOCO ";
		$registros=mysql_query($sql,$link) or die("Problemas al seleccionar los premios mayores que se ganó:".mysql_error());
		mysql_close($link);
		return($registros);
	}
	function Seleccionar_Todas_Las_Donaciones()
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="SELECT TMUSDO.CADOCO AS 'Codigo de Usuario', TMUSDO.CADONO AS 'Nombre', TMUSDO.CADOAP AS 'Apellido Paterno', TMUSDO.CADOAM AS 'Apellido Materno', TMUSDO.CADOCC AS 'Correo Electronico', TMUSDO.CADODI AS 'Documento de Identidad', ";
		$sql.="	TPDONA.TPDNCO AS 'Codigo', TPDONA.TPDOMO AS 'Monto', TPDONA.TPDOMD AS 'Moneda', TPDNFE AS 'Fecha' ";
		$sql.="FROM TPDONA ";
		$sql.="	INNER JOIN TMUSDO ON TPDONA.TMDOCO = TMUSDO.CADOCO ";
		$registros=mysql_query($sql,$link) or die("Problemas al seleccionar las donaciones:".mysql_error());
		mysql_close($link);
		return($registros);
	}
	function Seleccionar_Donaciones_Personal($usuario)
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="SELECT  TMUSDO.CADONO AS 'Nombre', TMUSDO.CADOAP AS 'Apellido Paterno', TMUSDO.CADOAM AS 'Apellido Materno', ";
		$sql.="	TPDONA.TPDOMO AS 'Monto', TPDONA.TPDOMD AS 'Moneda' ";
		$sql.="FROM TPDONA ";
		$sql.="	INNER JOIN TMUSDO ON TPDONA.TMDOCO = TMUSDO.CADOCO WHERE TMUSDO.CADOCO = ".$usuario." ;";
		$registros=mysql_query($sql,$link) or die("Problemas al seleccionar las donaciones:".mysql_error());
		mysql_close($link);
		return($registros);
	}
	function seleccionar_login($usuario)
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="SELECT CADOCO, CADOPW ";
		$sql.="FROM TMUSDO WHERE CADOUS='".$usuario."'; ";
		$registros=mysql_query($sql,$link) or die("Problemas al loguearse:".mysql_error());
		mysql_close($link);
		return($registros);
	}
	function Seleccionar_Todos_Los_Usuarios()
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="SELECT CADOCO AS 'Codigo',CADOUS AS 'Usuario', CADONO AS 'Nombres', CADOAP AS 'Apellido Paterno', CADOAM AS 'Apellido Materno', CADORS AS 'Razon Social', CADODI AS 'Documento de Identidad', CADOCC AS 'Correo Electronico', CADOPS AS 'Pais', CADOCI AS 'Ciudad',CADODD AS 'Direccion', CADOCP AS 'Codigo Postal', CADOTE AS 'Telefono' ";
		$sql.="FROM TMUSDO; ";
		$registros=mysql_query($sql,$link) or die("Problemas al seleccionar los usuarios:".mysql_error());
		mysql_close($link);
		return($registros);
	}
	function Seleccionar_El_Usuarios($usuario)
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="SELECT CADOCO AS 'Codigo', CADONO AS 'Nombres', CADOAP AS 'Apellido Paterno', CADOAM AS 'Apellido Materno', CADORS AS 'Razon Social',CADOTJ AS 'Tarjeta', CADODD AS 'Direccion' , CADOPS AS 'Pais', CADOCI AS 'Ciudad', CADOCP AS 'Codigo Postal' ";
		$sql.="FROM TMUSDO WHERE CADOCO = ".$usuario." ; ";
		$registros=mysql_query($sql,$link) or die("Problemas al seleccionar los usuarios:".mysql_error());
		mysql_close($link);
		return($registros);
	}
	function Guardar_Usuario($nombre,$apellidoP,$apellidoM,$DNI,$pais,$ciudad,$direccion,$email,$telefono,$tarjeta,$tipo_tarjeta,$razon_social,$codigo_postal,$usuario,$password)
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="INSERT INTO TMUSDO (CADONO, CADOAP, CADOAM, CADODI, CADOPS, CADOCI, CADODD, CADOCC, CADOTE, CADOTJ, CADOTP, CADORS, CADOCP, CADOUS, CADOPW) VALUES (";				
		$sql.="'".$nombre."',";
		$sql.="'".$apellidoP."',";
		$sql.="'".$apellidoM."',";
		$sql.="'".$DNI."',";
		$sql.="'".$pais."',";
		$sql.="'".$ciudad."',";
		$sql.="'".$direccion."',";
		$sql.="'".$email."',";
		$sql.="'".$telefono."',";
		$sql.="'".$tarjeta."',";
		$sql.="'".$tipo_tarjeta."',";
		$sql.="'".$razon_social."',";
		$sql.="'".$codigo_postal."',";
		$sql.="'".$usuario."',";
		$sql.="'".$password."');";
		$registros=mysql_query($sql,$link) or die("Problemas al guardar el usuario:".mysql_error());
		mysql_close($link);
	}
	function Guardar_Donacion($codigo_usuario,$monto,$moneda,$fecha)
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="INSERT INTO TPDONA (TMDOCO, TPDOMO, TPDOMD, TPDNFE) VALUES ( ";			
		$sql.="".$codigo_usuario.",";
		$sql.="'".$monto."',";
		$sql.="'".$moneda."',";
		$sql.="'".$fecha."');";
		$registros=mysql_query($sql,$link) or die("Problemas al guardar la donacion:".mysql_error());
		mysql_close($link);
	}
	function Guardar_Ganador_Premio_Instantaneo($codigo_donador,$codigo_premio)
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="INSERT INTO TPDNPN (TPPNCO, TPDNCO) VALUES (";
		$sql.=" ".$codigo_premio." , ";				
		$sql.=" ".$codigo_donador." )";
		$registros=mysql_query($sql,$link) or die(" ".$codigo_donador." ".$codigo_premio."Problemas al guardar el ganador del premio instantaneo:".mysql_error());
		mysql_close($link);
	}
	function Guardar_Ganador_Premio_Mayor($codigo_donador,$codigo_premio)
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="INSERT INTO TPDNPN (TPPMCO, TPDNCO) VALUES (";
		$sql.="".$codigo_premio.",";				
		$sql.="".$codigo_donador.");";
		$registros=mysql_query($sql,$link) or die("Problemas al guardar el usuario:".mysql_error());
		mysql_close($link);
	}
	function Guardar_Premio_Menor($codigo,$empresa,$descripcion,$cantidad,$usados,$activo)
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="INSERT INTO TMPRMN (TMPNCO, TMPNEP, TMPNDS, TMPNCN, TMPNPU, TMPNAC)VALUES (";
		$sql.="".$codigo.",";				
		$sql.="'".$empresa."',";
		$sql.="'".$descripcion."',";
		$sql.="".$cantidad.",";
		$sql.="".$usados.",";
		$sql.="'".$activo."');";
		$registros=mysql_query($sql,$link) or die("Problemas al guardar el usuario:".mysql_error());
		mysql_close($link);
	}
	function Guardar_Premio_Mayor($codigo,$empresa,$descripcion,$cantidad,$usados,$activo)
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="INSERT INTO TMPRMY (TMPMCO, TMPMEP, TMPMDS, TMPMCN, TMPMPU, TMPMAC)VALUES (";
		$sql.="".$codigo.",";				
		$sql.="'".$empresa."',";
		$sql.="'".$descripcion."',";
		$sql.="".$cantidad.",";
		$sql.="".$usados.",";
		$sql.="'".$activo."');";
		$registros=mysql_query($sql,$link) or die("Problemas al guardar el usuario:".mysql_error());
		mysql_close($link);
	}
	function Actualizar_Tarjeta($codigo,$tarjeta,$tipo)
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="UPDATE TMUSDO ";
		$sql.="SET ";				
		$sql.="CADOTJ = '".$tarjeta."', ";
		$sql.="CADOTP = '".$tipo."' ";
		$sql.="WHERE CADOCO = ".$codigo.";";
		$registros=mysql_query($sql,$link) or die("Problemas al cambiar de tarjeta:".mysql_error());
		mysql_close($link);
	}
	
	function Actualizar_Accesos($codigo,$usuario,$password)
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="UPDATE TMUSDO ";
		$sql.="SET ";				
		$sql.="CADOUS = '".$usuario."', ";
		$sql.="CADOPW = '".$password."' ";
		$sql.="WHERE CADOCO = ".$codigo.";";
		$registros=mysql_query($sql,$link) or die("Problemas al cambiar los accesos:".mysql_error());
		mysql_close($link);
	}
	function Actualizar_Premio_Menor_usados($codigo,$usados)
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="UPDATE TMPRMN  ";
		$sql.=" SET ";				
		$sql.=" TMPNPU = ".$usados." ";
		$sql.=" WHERE TMPNCO = ".$codigo." ;";
		$registros=mysql_query($sql,$link) or die("usados: ".$usados."codigo:".$codigo."Problemas al cambiar el uso de premios:".mysql_error());
		mysql_close($link);
	}
	function Actualizar_donacion($RUL)
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="UPDATE TPDONA  ";
		$sql.=" SET ";				
		$sql.=" TPDNPE = 0 ";
		$sql.=" WHERE TPDOMD = '".$RUL."' ;";
		$registros=mysql_query($sql,$link) or die("Problemas al cambiar el uso de premios:".mysql_error());
		mysql_close($link);
	}
	function Actualizar_Premio_Menor_activo($codigo,$activo)
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="UPDATE TMPRMN  ";
		$sql.="SET ";				
		$sql.="TMPNAC = ".$activo.", ";
		$sql.="WHERE TMPNCO = ".$codigo.";";
		$registros=mysql_query($sql,$link) or die("Problemas al cambiar el estado del premio:".mysql_error());
		mysql_close($link);
	}
	function Actualizar_Premio_Mayor_usados($codigo,$usados)
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="UPDATE TMPRMY ";
		$sql.="SET ";				
		$sql.="TMPMPU = ".$usados.", ";
		$sql.="WHERE TMPMCO = ".$codigo.";";
		$registros=mysql_query($sql,$link) or die("Problemas al cambiar los usos del premio:".mysql_error());
		mysql_close($link);
	}
	function Actualizar_Premio_Mayor_activo($codigo,$activo)
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="UPDATE TMPRMY ";
		$sql.="SET ";				
		$sql.="TMPMAC = ".$activo.", ";
		$sql.="WHERE TMPMCO = ".$codigo.";";
		$registros=mysql_query($sql,$link) or die("Problemas al cambiar el estado del premio:".mysql_error());
		mysql_close($link);
	}
	
	function canje($codigo,$RUL)
	{
		/*include("connexion.php");*/ 
   		$link=Conectarse(); 
		$sql="UPDATE TPDONA ";
		$sql.="SET ";				
		$sql.="TMDOCO = ".$codigo." ";
		$sql.="WHERE TPDOMD = '".$RUL."';";
		$registros=mysql_query($sql,$link) or die("No hemos podido canjear su cupón por favor intente de nuevo mas tarde");
		mysql_close($link);
	}
	function selecionar_donador($RUL)
	{
		$esta="";
		$link=Conectarse(); 
		$sql="SELECT TPDNCO ";
		$sql.="FROM TPDONA ";
		$sql.="	WHERE TPDOMD = '".$RUL."' ;";
		$registros=mysql_query($sql,$link) or die(mysql_error());
		mysql_close($link);
		while ($reg=mysql_fetch_array($registros))
		{
			$esta = $reg[0];
		}
		
		return $esta;
	}
	function estaActivo($RUL)
	{
		$esta=0;
		$regi=0;
		$link=Conectarse(); 
		$sql="SELECT TPDNPE";
		$sql.=" FROM TPDONA ";
		$sql.="	WHERE TPDOMD = '".$RUL."';";
		$registros=mysql_query($sql,$link) or die(mysql_error());
		mysql_close($link);
		while ($reg=mysql_fetch_array($registros))
		{
			$regi = $reg[0];
		}
		if($regi==1)
		{
			$esta = 1;
		}
		else
		{
			$esta = 0;
		}
		return $esta;
	}
?>
