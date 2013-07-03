<?php
function cabecera()
{
	$mostrar='
	<!DOCTYPE HTML>
<!--
	Striped 2.0 by HTML5 UP
	html5up.net | @n33co
	Free for personal and commercial use under the CCA 3.0 license (html5up.net/license)
-->
<html>
	<head>
		<title>Omega Real</title>
		<meta http-equiv="content-type" content="text/html; charset=utf-8" />
		<meta name="description" content="" />
		<meta name="keywords" content="" />
		<link href="http://fonts.googleapis.com/css?family=Source+Sans+Pro:400,400italic,700|Open+Sans+Condensed:300,700" rel="stylesheet" />
		<script src="js/jquery-1.9.1.min.js"></script>
		<script src="js/config.js"></script>
		<script src="js/skel.min.js"></script>
		<script src="js/skel-ui.min.js"></script>
    <script language='."'javascript'>".'
<!-- //
function setReadOnly(obj)
{
	var i;
	for(i=0;i<document.usuarios.update.length;i++){
		if(document.usuarios.update[i].checked)
		{
		document.usuarios.Apellidos[i].style.backgroundColor = "#ffffff";
		document.usuarios.Apellidos[i].readOnly = 0;
		document.usuarios.Nombres[i].style.backgroundColor = "#ffffff";
		document.usuarios.Nombres[i].readOnly = 0;
		document.usuarios.Local[i].style.backgroundColor = "#ffffff";
		document.usuarios.Local[i].readOnly = 0;
		document.usuarios.Telefono[i].style.backgroundColor = "#ffffff";
		document.usuarios.Telefono[i].readOnly = 0;
		} else {
		document.usuarios.Apellidos[i].style.backgroundColor = "#eeeeee";
		document.usuarios.Apellidos[i].readOnly = 1;
		document.usuarios.Nombres[i].style.backgroundColor = "#eeeeee";
		document.usuarios.Nombres[i].readOnly = 1;
		document.usuarios.Local[i].style.backgroundColor = "#eeeeee";
		document.usuarios.Local[i].readOnly = 1;
		document.usuarios.Telefono[i].style.backgroundColor = "#eeeeee";
		document.usuarios.Telefono[i].readOnly = 1;

		}
	}
}
function setsololect(obj)
{
	var i;
	for(i=0;i<document.buscar.busc.length;i++){
		if(document.buscar.busc[i].checked)
		{
		document.buscar.valores[i].style.backgroundColor = "#ffffff";
		document.buscar.valores[i].readOnly = 0;
		} else {
		document.buscar.valores[i].style.backgroundColor = "#eeeeee";
		document.buscar.valores[i].readOnly = 1;

		}
	}
}
function onbuscar(){
	var i;
	for(i=0;i<document.buscar.busc.length;i++){
		if(document.buscar.busc[i].checked)
		{
			document.getElementById("valor").value=document.buscar.valores[i].value;
		}
	}
       
    }
function onEnviar(){
	var i;
	for(i=0;i<document.usuarios.update.length;i++){
		if(document.usuarios.update[i].checked)
		{
			document.getElementById("cod").value=document.usuarios.update[i].value;
			document.getElementById("ape").value=document.usuarios.Apellidos[i].value;
			document.getElementById("nom").value=document.usuarios.Nombres[i].value;
			document.getElementById("telf").value=document.usuarios.Telefono[i].value;
			document.getElementById("loc").value=document.usuarios.Local[i].value;
		}
	}
       
    }
// -->
</script>
		<noscript>
			<link rel="stylesheet" href="css/skel-noscript.css" />
			<link rel="stylesheet" href="css/style.css" />
			<link rel="stylesheet" href="css/style-desktop.css" />
			<link rel="stylesheet" href="css/style-wide.css" />
		</noscript>
		<!--[if lte IE 9]><link rel="stylesheet" href="css/ie9.css" /><![endif]-->
		<!--[if lte IE 8]><script src="js/html5shiv.js"></script><link rel="stylesheet" href="css/ie8.css" /><![endif]-->
		<!--[if lte IE 7]><link rel="stylesheet" href="css/ie7.css" /><![endif]-->
    
	</head>

	<body class="left-sidebar">

		<!-- Wrapper -->
			<div id="wrapper">

				<!-- Content -->
					<div id="content">
						<div id="content-inner">
					
							<!-- Post -->
						  <article class="is-post is-post-excerpt" style="min-height:700px;">
									<header>
										
										<h2><a href="#">Administrador de Omega Real</a></h2>
										<span class="byline">Administracion de Usuarios - Edicion</span>
									</header>
								<div class="info">
									
										<span class="date"><span class="month">';$mostrar.= date("F", time()); $mostrar.='<span></span></span> <span class="day">';$mostrar.= date("j", time()); $mostrar.='</span><span class="year">,';$mostrar.=date("Y", time()); $mostrar.='</span></span>
						    <!--
											Note: You can change the number of list items in "stats" to whatever you want.
										--></div>
                         
                            

';
return $mostrar;
}
function formulaio()
{
	$mostrar='<form name="usuarios" id="usuarios" method="post" action="AdmUsu.php" onSubmit="return onEnviar();">
                            
							  <table width="100%" border="0">
							    <tr>
							      <th scope="col">Seleccionar</th>
							      <th scope="col">Apellidos</th>
							      <th scope="col">Nombres</th>
							      <th scope="col">Local</th>
							      <th scope="col">Telefono</th>
						        </tr>';
return $mostrar;
}
function buscar()
{
	$mostrar='<form name="buscar" id="buscar" method="post" action="AdmUsu.php" onSubmit="return onbuscar();">
                       <table width="100%" border="0" cellspacing="3">
                                <tr>
                                  <th width="10%" style="text-align:right" scope="row"><input type="radio" name="busc" id="busc" value="radio" onclick="setsololect(this)">
                                  <label for="radio"></label></th>
                                  <th width="12%" style="text-align:right" scope="row">Apellidos:&nbsp;&nbsp; </th>
                                  <td width="78%"><label for="nombre"></label>
                                  <input type="text" name="valores" id="valores" readonly style="background-color:#eeeeee"></td>
                                </tr>
                                <tr>
                                  <th scope="row" style="text-align:right"><input type="radio" name="busc" id="busc" value="radio" onclick="setsololect(this)"></th>
                                  <th scope="row" style="text-align:right">Nombres:&nbsp;&nbsp;</th>
                                  <td><label for="Apellidos"></label>
                                  <input type="text" name="valores" id="valores" readonly style="background-color:#eeeeee"></td>
                                </tr>
                                <tr>
                                  <th scope="row" style="text-align:right"><input type="radio" name="busc" id="busc" value="radio" onclick="setsololect(this)"></th>
                                  <th scope="row" style="text-align:right">Local:&nbsp;&nbsp; </th>
                                  <td><label for="DNI"></label>
                                  <input type="text" name="valores" id="valores" readonly style="background-color:#eeeeee"></td>
                                </tr>
                                <tr>
                                  <th scope="row" style="text-align:right"><input type="radio" name="busc" id="busc" value="radio" onclick="setsololect(this)"></th>
                                  <th scope="row" style="text-align:right">Telefono:&nbsp;&nbsp; </th>
                                  <td><label for="email"></label>
                                  <input type="text" name="valores" id="valores"  value="" readonly style="background-color:#eeeeee"></td>						
                                  <input id="valor" name="valor" type="hidden" />
                                </tr>
                                <tr>
                                  <th scope="row">&nbsp;</th>
                                  <th scope="row"><p>&nbsp;
                                    </p>
                                    <p>&nbsp;</p></th>
                                  <td><p>
                                    <input type="submit" name="Busco" id="Busco" value="Buscar">
                                  </p></td>
                                </tr>
                              </table>
                            </form>
							<p>&nbsp;</p>';
return $mostrar;
}

function pie()
{
	$mostrar='
	 <input id="cod" name="cod" type="hidden" />
                                <input id="nom" name="nom" type="hidden" />
                                <input id="ape" name="ape" type="hidden" />
                                <input id="telf" name="telf" type="hidden" />
                                <input id="loc" name="loc" type="hidden" />
						      </table>
							  <table width="100%" border="0">
							    <tr>
							      <th scope="col"><input type="button" name="button" id="button" value="Nuevo" onclick="location.href='."'AdmUsuNuev.php'".'"></th>
							      <th scope="col"><input type="submit" name="enviar" id="enviar" value="Grabar" ></th>
							      <th scope="col"><input type="submit" name="Buscar" id="Buscar" value="Buscar"></th>
							      <th scope="col"><input type="submit" name="eliminar" id="eliminar" value="Eliminar"></th>
						        </tr>
						      </table>
							   
							</form>

                          </article>
						
							<!-- Post -->
								<article class="is-post is-post-excerpt">
									<header></header>
</article>
						
							<!-- Pager -->
								<div class="pager">
									<!--<a href="#" class="button previous">Previous Page</a>-->
									<div class="pages"></div>
								</div>

						</div>
					</div>

				<!-- Sidebar -->
					<div id="sidebar">
					
						<!-- Logo -->
							<div id="logo">
								<h1>OmegaReal</h1>
							</div>
					
						<!-- Nav -->
					  <nav id="nav">
								<ul>
									<li ><a href="bienvenida.php">Inicio</a></li>
									<li class="current_page_item"><a href="AdmUsu.php">Administrar Usuarios</a></li>
									<li><a href="AdmProv.php">Administrar Provedores</a></li>
									<li><a href="EstProd.php">Estado de Productos</a></li>
                                    <li><a href="Config.php">Configuraciones</a></li>
                                    <li><a href="cerrarSesion.php">Cerrar Sesión</a></li>
								</ul>
							</nav>

						<!-- Search -->
						<!-- Text -->
						<!-- Recent Posts -->
						<!-- Recent Comments --><!-- Calendar -->
						<section class="is-calendar">
								<div class="inner">
									<table>
										<caption>';$mostrar.= date("F", time());    $mostrar.= date("Y", time()); $mostrar.='</caption>
										<thead>
											<tr>
												<th scope="col" title="Monday">M</th>
												<th scope="col" title="Tuesday">T</th>
												<th scope="col" title="Wednesday">W</th>
												<th scope="col" title="Thursday">T</th>
												<th scope="col" title="Friday">F</th>
												<th scope="col" title="Saturday">S</th>
												<th scope="col" title="Sunday">S</th>
											</tr>
										</thead>'; 
                                       $mes = mktime( $m ); $dia= date("j", time()); 
									   $ultimodia = date("t",$mes);
									   $primerdia=(strftime("%w",mktime(0,0,0,date("n", time()),01,date("Y", time()))))-1; 
									$mostrar.='<tbody>'; 
													$bandera=0;
													$i=0;
													$cont=0;
													$vez=0;
													$o=8;
													while($cont < $ultimodia)
													{
														$mostrar.= '<tr>';
														if($vez == 0)
														{
															$mostrar.= '<td colspan='.'"'.$primerdia.'"'.'class="pad"><span>&nbsp;</span></td>';
															$vez=1;
														}
														for($i=1;$i<$o;$i++)
														{
															if($cont != $ultimodia)
															{	
																if($cont == $dia - 1)
																{
																	$mostrar.= '<td class="today"><a href="#">';
																}
																else
																{
																	$mostrar.= '<td>';
																}
																$cont=$cont+1;
															
																if($cont < 8-$primerdia && $vez==1)
																{
																	$o=6;
																	$mostrar.= '<span>'.$cont.'</span>';
																	if($cont == $dia)
																	{
																		$mostrar.= '</a></td>';
																	}
																	else
																	{
																		$mostrar.= '</td>';
																	}
																}
																else
																{
																	if($vez!=1)
																	{
																		$o=8;
																		$mostrar.= '<span>'.$cont.'</span>';
																		if($cont == $dia)
																		{
																				$mostrar.= '</a></td>';
																		}
																		else
																		{
																			$mostrar.= '</td>';
																		}
																	}
																}
															}
														
														}
														$vez=2;
														$mostrar.= '</tr>';
														
													}
												
												
											
												
										$mostrar.='</tbody>
									</table>
								</div>
					  </section>

						<!-- Copyright -->
							<div id="copyright">
								<p>
									&copy; 2013 Omega Real.<br />
									Images: <a href="#">Omega Real</a>, <a href="#">Sistemas y Soluciones PEMA</a>, <a href="http://iconify.it">Iconify.it</a>
									Design: <a href="#">Sistemas y Soluciones PEMA</a>
								</p>
							</div>

					</div>

			</div>

	</body>
</html>
	';
return $mostrar;
}
?>