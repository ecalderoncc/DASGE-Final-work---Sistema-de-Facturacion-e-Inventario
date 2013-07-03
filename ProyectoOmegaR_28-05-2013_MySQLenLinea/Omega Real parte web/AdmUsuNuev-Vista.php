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
        <script src="js/main.js"></script>
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
    <style type="text/css">
		.requisites.error{
			text-decoration: underline;
			background: #fff8cc;
			color: #FFF;
		}
		input.error{
			background: #432323;
			border-color: #171717;
			color: #FFF;
		}
		input.text.active{
	background: #FFF;
	border-color: #000;
	color: #000;
}
</style>
	<body class="left-sidebar">

		<!-- Wrapper -->
			<div id="wrapper">

				<!-- Content -->
					<div id="content">
						<div id="content-inner">
					
							<!-- Post -->
						  <article class="is-post is-post-excerpt">
									<header>
										
										<h2><a href="#">Administrador de Omega Real</a></h2>
										<span class="byline">Administracion de Usuarios - Nuevo Usuario</span>
									</header>
								<div class="info">
									
										<span class="date"><span class="month">';$mostrar.= date("F", time()); $mostrar.='<span></span></span> <span class="day">';$mostrar.= date("j", time()); $mostrar.='</span><span class="year">,';$mostrar.=date("Y", time()); $mostrar.='</span></span>
						    <!--
											Note: You can change the number of list items in "stats" to whatever you want.
										--></div>
                         
                           <form name="usuarios" id="usuarios" method="post" action="AdmUsuNuev.php">
                              <table width="100%" border="0" cellspacing="3">
                                <tr>
                                  <th width="23%" scope="col" style="text-align:right"><p><a href="AdmUsu.php">Volver</a>&nbsp;&nbsp;<br>
                                   </p></th>
                                  <th width="77%" scope="col">&nbsp;</th>
                                </tr>
                                <tr>
                                  <th scope="row" style="text-align:right">Nombres:&nbsp;&nbsp; </th>
                                  <td><label for="nombre"></label>
                                  <input type="text" name="nombre" id="nombre"></td>
                                </tr>
                                <tr>
                                  <th scope="row" style="text-align:right">Apellidos:&nbsp;&nbsp;</th>
                                  <td><label for="Apellidos"></label>
                                  <input type="text" name="Apellidos" id="Apellidos"></td>
                                </tr>
                                <tr>
                                  <th scope="row" style="text-align:right">Documento de Identidad:&nbsp;&nbsp; </th>
                                  <td><label for="DNI"></label>
                                  <input type="text" name="DNI" id="DNI"></td>
                                </tr>
                                <tr>
                                  <th scope="row" style="text-align:right">E-mail:&nbsp;&nbsp; </th>
                                  <td><label for="email"></label>
                                  <input type="text" name="email" id="email"  class="text ';$mostrar.= $email; $mostrar.='" value="'; $mostrar.= $emailValue; $mostrar.='"></td>
                                </tr>
                                <tr>
                                  <th scope="row" style="text-align:right">Localidad:&nbsp;&nbsp; </th>
                                  <td><label for="Localidad"></label>
                                  <input type="text" name="Localidad" id="Localidad"></td>
                                </tr>
                                <tr>
                                  <th scope="row" style="text-align:right">Telefono:&nbsp;&nbsp; </th>
                                  <td><label for="Telefono"></label>
                                  <input type="text" name="Telefono" id="Telefono"></td>
                                </tr>
                                <tr>
                                  <th scope="row" style="text-align:right">Nivel de Privilegios:&nbsp;&nbsp; </th>
                                  <td><label for="Rol"></label>
                                    <select name="Rol" id="Rol">
                                      <option value="1">Vendedor</option>
                                      <option value="2">Supervisor</option>
                                  </select></td>
                                </tr>
                                <tr>
                                  <th scope="row" style="text-align:right">Usuario:&nbsp;&nbsp; </th>
                                  <td><label for="Usuario"></label>
                                  <input type="text" name="Usuario" id="Usuario" class="text';$mostrar.=$Usuario;$mostrar.='" value="';$mostrar.= $UsuarioValue;$mostrar.='"></td>
                                </tr>
                                <tr>
                                  <th scope="row" style="text-align:right">Password:&nbsp;&nbsp; </th>
                                  <td><label for="Password"></label>
                                  <input type="password" name="Password" id="Password" class="text ';$mostrar.= $Password;$mostrar.='"></td>
                                </tr>
                                <tr>
                                  <th scope="row" style="text-align:right">Repita Password:&nbsp;&nbsp;</th>
                                  <td><label for="Verifica"></label>
                                  <input type="password" name="Verifica" id="Verifica" class="text ';$mostrar.= $Verifica; $mostrar.='"></td>
                                </tr>
                                <tr>
                                  <th scope="row"><p>&nbsp;
                                    </p>
                                    <p>&nbsp;</p></th>
                                  <td><p>&nbsp;
                                    </p>
                                    <p>&nbsp;                                    </p>
                                    <table width="100%" border="0" cellspacing="3">
                                      <tr>
                                        <th scope="col"><input type="submit" name="Guardar" id="Guardar" value="Guardar"></th>
                                        <th scope="col"><input type="submit" name="Cancelar" id="Cancelar" value="Cancelar"></th>
                                      </tr>
                                    </table></td>
                                </tr>
                              </table>
                            </form>
							<p>&nbsp;</p>
							<p>&nbsp;</p>
									<p>&nbsp;</p>
									<p>&nbsp;</p>
                          </article>
						
						<!-- Post --><!-- Pager --></div>
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


';
return $mostrar;
}
function pie()
{
	$mostrar='
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