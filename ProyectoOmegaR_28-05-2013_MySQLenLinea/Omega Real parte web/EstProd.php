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
?>
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
			color: #171717;
		}
		input.error{
			background: #432323;
			border-color: #171717;
		}
		input.text.active{
	background: #FFF;
	border-color: #000;
	color: #000;
}
</style>
<script type="text/javascript">
function onbuscar(){
	var i;
	for(i=0;i<document.buscar.busc.length;i++){
		if(document.buscar.busc[i].checked)
		{
			document.getElementById("valor").value=document.buscar.busc[i].value;
		}
	}
       
    }
</script>
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
										<span class="byline">Administracion de Usuarios - Seleccionar Almacen</span>
									</header>
							<div class="info">
									
										<span class="date"><span class="month"><?php echo date("F", time()); ?><span></span></span> <span class="day"><?php echo date("j", time()); ?></span><span class="year">, <?php echo date("Y", time()); ?></span></span>
						    <!--
											Note: You can change the number of list items in "stats" to whatever you want.
										--></div>
							<form name="buscar" id="buscar" method="post" action="EstProd-alm.php" onSubmit="return onbuscar();" style="min-height:400px;">
							  <table width="100%" border="0" cellspacing="3" >
							    <tr>
							      <th scope="col">Seleccionar</th>
							      <th scope="col">Almacen</th>
							      <th scope="col">Descripcion</th>
						        </tr>
                                <?php 
								$registros = Todos_los_almacenes();
								while ($reg=mysql_fetch_array($registros))
								{
									echo '<tr>';
									echo '<th scope="col"><input type="radio" name="busc" value="'.$reg[0].'"></th>';
									echo '<th scope="col">'.$reg[1].'</th>';
									echo '<th scope="col">'.$reg[2].'</th>';
									echo '</tr>';
								}
								?>
                                <tr>
							      <th scope="col"><input type="submit" name="seleccionar" id="seleccionar" value="Enviar"></th>
							      <th scope="col"><input id="valor" name="valor" type="hidden" /></th>
							      <th scope="col"></th>
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
									<li ><a href="AdmUsu.php">Administrar Usuarios</a></li>
									<li><a href="AdmProv.php">Administrar Provedores</a></li>
									<li class="current_page_item"><a href="EstProd.php">Estado de Productos</a></li>
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
										<caption><?php echo date("F", time()); ?>   <?php echo date("Y", time()); ?></caption>
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
										</thead>
                                       <?php $mes = mktime( $m ); $dia= date("j", time()); 
									   $ultimodia = date("t",$mes);
									   $primerdia=(strftime("%w",mktime(0,0,0,date("n", time()),01,date("Y", time()))))-1; ?>
										<tbody>
											
                                                <?php 
													$bandera=0;
													$i=0;
													$cont=0;
													$vez=0;
													$o=8;
													while($cont < $ultimodia)
													{
														echo '<tr>';
														if($vez == 0)
														{
															echo '<td colspan='.'"'.$primerdia.'"'.'class="pad"><span>&nbsp;</span></td>';
															$vez=1;
														}
														for($i=1;$i<$o;$i++)
														{
															if($cont == $ultimodia)
																return;
															if($cont == $dia - 1)
															{
																echo '<td class="today"><a href="#">';
															}
															else
															{
																echo '<td>';
															}
															$cont=$cont+1;
															
															if($cont < 8-$primerdia && $vez==1)
															{
																$o=6;
																echo '<span>'.$cont.'</span>';
																if($cont == $dia)
																{
																	echo '</a></td>';
																}
																else
																{
																	echo '</td>';
																}
															}
															else
															{
																if($vez!=1)
																{
																	$o=8;
																	echo '<span>'.$cont.'</span>';
																	if($cont == $dia)
																{
																	echo '</a></td>';
																}
																else
																{
																	echo '</td>';
																}
																}
															}
														
														}
														$vez=2;
														echo '</tr>';
													}
												
												?>
											
												
										</tbody>
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
    
	
	
