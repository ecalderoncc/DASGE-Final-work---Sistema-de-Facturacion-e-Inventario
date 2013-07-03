<?php
function principal()
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
						  <article class="is-post is-post-excerpt">
									<header>
										
										<h2><a href="#">Administrador de Omega Real</a></h2>
										<span class="byline">Web de seguimiento a sucursales de la empresa OmegaReal</span>
									</header>
								<div class="info">
									
										<span class="date"><span class="month">';$mostrar.= date("F", time()); $mostrar.='<span></span></span> <span class="day">';$mostrar.= date("j", time()); $mostrar.='</span><span class="year">,';$mostrar.=date("Y", time()); $mostrar.='</span></span>
						    <!--
											Note: You can change the number of list items in "stats" to whatever you want.
										--></div>
							  Haga Click en un elemento para empesar a ver sus reportes.
							  <p>&nbsp;</p>
									<p>&nbsp;</p>
									<p>&nbsp;</p>
									<p>&nbsp;</p>
									<p>&nbsp;</p>
									<p>&nbsp;</p>
									<p>&nbsp;</p>
									<p>&nbsp;</p>
									<p>&nbsp;</p>
									<p>&nbsp;</p>
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
									<li class="current_page_item"><a href="#">Inicio</a></li>
									<li><a href="AdmUsu.php">Administrar Usuarios</a></li>
									<li><a href="AdmProv.php">Administrar Provedores</a></li>
									<li><a href="VenFec.php">Ventas por Fecha</a></li>
									<li><a href="EstProd.php">Estado de Productos</a></li>
									<li><a href="KarDex.php">Kardex</a></li>
									<li><a href="IngAlm.php">Ingreso al Almacen</a></li>
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
</html>';
return $mostrar;
}
?>