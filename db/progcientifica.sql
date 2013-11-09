# MySQL-Front 4.2  (Build 2.77)

/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE */;
/*!40101 SET SQL_MODE='' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES */;
/*!40103 SET SQL_NOTES='ON' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS */;
/*!40014 SET FOREIGN_KEY_CHECKS=0 */;


# Host: 216.224.170.112    Database: hcrcurso_progcientifica
# ------------------------------------------------------
# Server version 5.1.70-cll

#
# Table structure for table caja_registro
#

CREATE TABLE `caja_registro` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `fecha_apertura` datetime NOT NULL DEFAULT '0000-00-00 00:00:00',
  `apertura_usuario_id` int(11) NOT NULL DEFAULT '0',
  `apertura_efectivo` float(10,4) NOT NULL DEFAULT '0.0000',
  `apertura_cheques` float(10,4) NOT NULL DEFAULT '0.0000',
  `cierre_usuario_id` int(11) NOT NULL DEFAULT '0',
  `cierre_fecha` datetime NOT NULL DEFAULT '0000-00-00 00:00:00',
  `cierre_efectivo` float(10,4) NOT NULL DEFAULT '0.0000',
  `cierre_cheques` float(10,4) NOT NULL DEFAULT '0.0000',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table caja_registro
#
LOCK TABLES `caja_registro` WRITE;
/*!40000 ALTER TABLE `caja_registro` DISABLE KEYS */;

/*!40000 ALTER TABLE `caja_registro` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table cheques
#

CREATE TABLE `cheques` (
  `Id_cheques` int(11) NOT NULL AUTO_INCREMENT,
  `cheque_nro` varchar(50) NOT NULL DEFAULT '',
  `banco` varchar(100) NOT NULL DEFAULT '',
  `fecha_labranza` datetime NOT NULL DEFAULT '0000-00-00 00:00:00',
  `fecha_cobro` datetime NOT NULL DEFAULT '0000-00-00 00:00:00',
  `labrador` varchar(50) NOT NULL DEFAULT '',
  `dador` varchar(50) NOT NULL DEFAULT '',
  `receptor` varchar(50) NOT NULL DEFAULT '',
  `importe` float(10,4) NOT NULL DEFAULT '0.0000',
  `activo` bit(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`Id_cheques`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table cheques
#
LOCK TABLES `cheques` WRITE;
/*!40000 ALTER TABLE `cheques` DISABLE KEYS */;

/*!40000 ALTER TABLE `cheques` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table clientes
#

CREATE TABLE `clientes` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL DEFAULT '',
  `apellido` varchar(100) NOT NULL DEFAULT '',
  `razon_social` varchar(25) NOT NULL DEFAULT '',
  `direccion` varchar(50) NOT NULL DEFAULT '',
  `localidad` varchar(50) NOT NULL DEFAULT '',
  `provincia` varchar(50) NOT NULL DEFAULT '',
  `pais_id` int(11) NOT NULL DEFAULT '0',
  `CUIT` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table clientes
#
LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;

/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table comprobantes
#

CREATE TABLE `comprobantes` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date NOT NULL DEFAULT '0000-00-00',
  `tipo_comprobante` char(1) NOT NULL DEFAULT '',
  `nro_comprobante` int(11) NOT NULL DEFAULT '0',
  `comprobante_externo` varchar(100) NOT NULL DEFAULT '',
  `comprobante_detalle` text NOT NULL,
  `importe` float(10,4) NOT NULL DEFAULT '0.0000',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table comprobantes
#
LOCK TABLES `comprobantes` WRITE;
/*!40000 ALTER TABLE `comprobantes` DISABLE KEYS */;

/*!40000 ALTER TABLE `comprobantes` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table consultas
#

CREATE TABLE `consultas` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table consultas
#
LOCK TABLES `consultas` WRITE;
/*!40000 ALTER TABLE `consultas` DISABLE KEYS */;

/*!40000 ALTER TABLE `consultas` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table detalles_consultas
#

CREATE TABLE `detalles_consultas` (
  `Id_detalle_consulta` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL DEFAULT '',
  `titulo` varchar(30) NOT NULL DEFAULT '',
  `longitud` int(15) NOT NULL DEFAULT '0',
  `alineacion` varchar(20) NOT NULL DEFAULT '',
  `campo` varchar(30) NOT NULL DEFAULT '',
  `orden` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id_detalle_consulta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table detalles_consultas
#
LOCK TABLES `detalles_consultas` WRITE;
/*!40000 ALTER TABLE `detalles_consultas` DISABLE KEYS */;

/*!40000 ALTER TABLE `detalles_consultas` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table localidades
#

CREATE TABLE `localidades` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `postal` varchar(6) NOT NULL DEFAULT '',
  `nombre` varchar(150) NOT NULL DEFAULT '',
  `provincia_id` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table localidades
#
LOCK TABLES `localidades` WRITE;
/*!40000 ALTER TABLE `localidades` DISABLE KEYS */;

/*!40000 ALTER TABLE `localidades` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table menues
#

CREATE TABLE `menues` (
  `Id_menu` int(11) NOT NULL AUTO_INCREMENT,
  `perfil` varchar(30) NOT NULL DEFAULT '',
  `nombre_menu` varchar(40) NOT NULL DEFAULT '',
  `nivel` int(11) NOT NULL DEFAULT '0',
  `formulario` varchar(30) NOT NULL DEFAULT '',
  `pertenece_a` varchar(30) DEFAULT '',
  `Orden` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id_menu`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table menues
#
LOCK TABLES `menues` WRITE;
/*!40000 ALTER TABLE `menues` DISABLE KEYS */;

/*!40000 ALTER TABLE `menues` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table movimientos_caja
#

CREATE TABLE `movimientos_caja` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `caja_id` int(11) NOT NULL DEFAULT '0',
  `tipo_movimiento_id` int(11) DEFAULT NULL,
  `fecha` datetime NOT NULL DEFAULT '0000-00-00 00:00:00',
  `comprobante_id` int(11) DEFAULT NULL,
  `cliente` varchar(100) NOT NULL DEFAULT '',
  `importe` float(10,4) DEFAULT NULL,
  `usuario_id` int(11) DEFAULT NULL,
  `cheque_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table movimientos_caja
#
LOCK TABLES `movimientos_caja` WRITE;
/*!40000 ALTER TABLE `movimientos_caja` DISABLE KEYS */;

/*!40000 ALTER TABLE `movimientos_caja` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table paises
#

CREATE TABLE `paises` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table paises
#
LOCK TABLES `paises` WRITE;
/*!40000 ALTER TABLE `paises` DISABLE KEYS */;

/*!40000 ALTER TABLE `paises` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table provedores
#

CREATE TABLE `provedores` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table provedores
#
LOCK TABLES `provedores` WRITE;
/*!40000 ALTER TABLE `provedores` DISABLE KEYS */;

/*!40000 ALTER TABLE `provedores` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table provincias
#

CREATE TABLE `provincias` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table provincias
#
LOCK TABLES `provincias` WRITE;
/*!40000 ALTER TABLE `provincias` DISABLE KEYS */;

/*!40000 ALTER TABLE `provincias` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table tipo_movimientos
#

CREATE TABLE `tipo_movimientos` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(50) NOT NULL DEFAULT '',
  `categoria` varchar(45) NOT NULL DEFAULT '',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table tipo_movimientos
#
LOCK TABLES `tipo_movimientos` WRITE;
/*!40000 ALTER TABLE `tipo_movimientos` DISABLE KEYS */;

/*!40000 ALTER TABLE `tipo_movimientos` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table tipos_usuarios
#

CREATE TABLE `tipos_usuarios` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

#
# Dumping data for table tipos_usuarios
#
LOCK TABLES `tipos_usuarios` WRITE;
/*!40000 ALTER TABLE `tipos_usuarios` DISABLE KEYS */;

INSERT INTO `tipos_usuarios` VALUES (1,'administrador');
INSERT INTO `tipos_usuarios` VALUES (2,'gerente');
INSERT INTO `tipos_usuarios` VALUES (3,'usuario');
/*!40000 ALTER TABLE `tipos_usuarios` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table structure for table usuarios
#

CREATE TABLE `usuarios` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) NOT NULL DEFAULT '',
  `password` varchar(50) NOT NULL DEFAULT '',
  `nombre` varchar(50) NOT NULL DEFAULT '',
  `tipo_usuario_id` int(11) NOT NULL DEFAULT '0',
  `activo` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

#
# Dumping data for table usuarios
#
LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;

INSERT INTO `usuarios` VALUES (1,'admin','admin','Administrador',1,1);
INSERT INTO `usuarios` VALUES (2,'gerardo','master','Gerardo',2,1);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
