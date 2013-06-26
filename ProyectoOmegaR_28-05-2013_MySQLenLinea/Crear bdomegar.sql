delimiter $$

CREATE TABLE `boleta` (
  `BolCod` varchar(255) DEFAULT NULL,
  `BolClieCod` varchar(255) DEFAULT NULL,
  `BolPV` varchar(255) DEFAULT NULL,
  `BolFecha` varchar(255) DEFAULT NULL,
  `BolNum` varchar(255) DEFAULT NULL,
  `BolLocal` varchar(255) DEFAULT NULL,
  `BolCodUsu` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1$$

delimiter $$

CREATE TABLE `clientes` (
  `CliCod` varchar(4) DEFAULT NULL,
  `CliNom` varchar(30) DEFAULT NULL,
  `CliDir` varchar(75) DEFAULT NULL,
  `CliTelef` varchar(10) DEFAULT NULL,
  `ACTIVI` varchar(1) DEFAULT NULL,
  `CliDepa` varchar(2) DEFAULT NULL,
  `CliRUC` varchar(11) DEFAULT NULL,
  `CliEmail` varchar(255) DEFAULT NULL,
  `CliContac` varchar(255) DEFAULT NULL,
  `CliPais` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1$$

delimiter $$

CREATE TABLE `departamento` (
  `DepaCod` varchar(2) DEFAULT NULL,
  `DepaDesc` varchar(20) DEFAULT NULL,
  `PaisCod` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1$$

delimiter $$

CREATE TABLE `det_bol` (
  `DetBolCod` varchar(255) DEFAULT NULL,
  `ProdCod` varchar(255) DEFAULT NULL,
  `DetBolCant` int(11) DEFAULT NULL,
  `DetBolDcto` varchar(255) DEFAULT NULL,
  `BolCod` varchar(255) DEFAULT NULL,
  `DetBolPUni` varchar(255) DEFAULT NULL,
  `DetBolPTot` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1$$

delimiter $$

CREATE TABLE `det_fact` (
  `DetFactCod` int(11) DEFAULT NULL,
  `ProdCod` varchar(255) DEFAULT NULL,
  `DetFactCant` varchar(255) DEFAULT NULL,
  `DetFactDcto` varchar(255) DEFAULT NULL,
  `FactCod` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1$$

delimiter $$

CREATE TABLE `egresos` (
  `EgreCod` int(11) DEFAULT NULL,
  `EgreDesc` varchar(255) DEFAULT NULL,
  `EgreTotal` varchar(255) DEFAULT NULL,
  `EgreUsu` varchar(255) DEFAULT NULL,
  `EgreMoneda` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1$$

delimiter $$

CREATE TABLE `factura` (
  `FactCod` varchar(255) DEFAULT NULL,
  `FactCliCod` varchar(255) DEFAULT NULL,
  `FactValV` varchar(255) DEFAULT NULL,
  `FactIGV` varchar(255) DEFAULT NULL,
  `FactDate` varchar(255) DEFAULT NULL,
  `FactNum` varchar(255) DEFAULT NULL,
  `FactGuia` varchar(255) DEFAULT NULL,
  `FactLocal` varchar(255) DEFAULT NULL,
  `FactCodUsu` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1$$

delimiter $$

CREATE TABLE `guia_rem` (
  `GuiaCod` int(11) DEFAULT NULL,
  `GuiaNum` varchar(255) DEFAULT NULL,
  `GuiaTranspCod` varchar(255) DEFAULT NULL,
  `GuiaNomChof` varchar(255) DEFAULT NULL,
  `GuiaLicChof` varchar(255) DEFAULT NULL,
  `GuiaPlacaV` varchar(255) DEFAULT NULL,
  `GuiaDestino` varchar(255) DEFAULT NULL,
  `GuiaOrigen` varchar(255) DEFAULT NULL,
  `GuiaMarcaV` varchar(255) DEFAULT NULL,
  `GuiaFechaEmis` varchar(255) DEFAULT NULL,
  `GuiaFechaTrans` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1$$

delimiter $$

CREATE TABLE `pais` (
  `PaisCod` varchar(2) DEFAULT NULL,
  `PaisDesc` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1$$

delimiter $$

CREATE TABLE `productos` (
  `ProCod` varchar(255) DEFAULT NULL,
  `ProdNom` varchar(255) DEFAULT NULL,
  `ProdUnidad` varchar(255) DEFAULT NULL,
  `ProdCosto` double DEFAULT NULL,
  `ProdPrecio` double DEFAULT NULL,
  `ProdIGV` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1$$

delimiter $$

CREATE TABLE `transportista` (
  `TranspCod` int(11) DEFAULT NULL,
  `TranspNombre` varchar(255) DEFAULT NULL,
  `TranspRUC` varchar(255) DEFAULT NULL,
  `TransDir` varchar(255) DEFAULT NULL,
  `TranspTelef` varchar(255) DEFAULT NULL,
  `TranspCiudad` varchar(255) DEFAULT NULL,
  `TranspPais` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1$$

delimiter $$

CREATE TABLE `usuarios` (
  `UsuCod` varchar(2) DEFAULT NULL,
  `UsuId` varchar(10) DEFAULT NULL,
  `UsuPass` varchar(10) DEFAULT NULL,
  `UsuDNI` varchar(30) DEFAULT NULL,
  `UsuNom` varchar(255) DEFAULT NULL,
  `UsuApe` varchar(255) DEFAULT NULL,
  `UsuEmail` varchar(255) DEFAULT NULL,
  `UsuTelef` varchar(255) DEFAULT NULL,
  `UsuLocal` varchar(255) DEFAULT NULL,
  `UsuRol` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1$$

delimiter $$

CREATE TABLE `almacen` (
  `AlmCod` varchar(255) DEFAULT NULL,
  `AlmNombre` varchar(255) DEFAULT NULL,
  `AlmDesc` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1$$

delimiter $$

CREATE TABLE `alm_prod_stock` (
  `APSCod` varchar(255) DEFAULT NULL,
  `AlmCod` varchar(255) DEFAULT NULL,
  `ProCod` varchar(255) DEFAULT NULL,
  `ProCant` int(11) DEFAULT NULL,
  `UsuCod` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1$$

