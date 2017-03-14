-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: puntoventa
-- ------------------------------------------------------
-- Server version	5.7.12-log

--
-- Table structure for table `detalleventa`
--

DROP TABLE IF EXISTS `detalleventa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalleventa` (
  `idDetalleVenta` int(11) NOT NULL AUTO_INCREMENT,
  `CodigoProducto` varchar(20) NOT NULL,
  `Descripcion` varchar(45) NOT NULL,
  `Cantidad` float NOT NULL,
  `SubTotal` float NOT NULL,
  `Iva` float NOT NULL,
  `Total` float NOT NULL,
  PRIMARY KEY (`idDetalleVenta`)
) ENGINE=InnoDB AUTO_INCREMENT=50 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Dumping data for table `detalleventa`
--

LOCK TABLES `detalleventa` WRITE;

INSERT INTO `detalleventa` VALUES (0,'-------','--------',0,0,0,0),(23,'FRIJOLB','Frijol Bolsa de 1 K',1,0,0,19.55),(24,'AZUCARB','Azucar Bolsa de 1 K',1,0,0,17.25),(25,'COCA6','Refresco Coca Cola de 600 ml',1,0,0,12),(26,'FRIJOLB','Frijol Bolsa de 1 K',1,0,0,19.55),(27,'AZUCARB','Azucar Bolsa de 1 K',1,0,0,17.25),(28,'COCA6','Refresco Coca Cola de 600 ml',1,0,0,12),(29,'COCA6','Refresco Coca Cola de 600 ml',1,0,0,12),(30,'COCAL','Refresco Coca Cola 1 lt',1,0,0,15),(31,'COCA6','Refresco Coca Cola de 600 ml',1,0,0,12),(32,'FRESA6','Refresco Fanta de Fresa de 600 ml',1,0,0,12),(33,'COCA6','Refresco Coca Cola de 600 ml',10,0,0,120),(34,'COCA6','Refresco Coca Cola de 600 ml',2,0,0,24),(35,'COCA6','Refresco Coca Cola de 600 ml',1,0,0,12),(36,'COCAL','Refresco Coca Cola 1 lt',1,0,0,15),(37,'FRIJOLB','Frijol Bolsa de 1 K',1,0,0,19.55),(38,'AZUCARK','Azucar Agranel',1,0,0,16.1),(39,'COCA6','Refresco Coca Cola de 600 ml',1,0,0,12),(40,'TOSTG','Tostitos 110 gr',1,0,0,24),(41,'FRESA6','Refresco Fanta de Fresa de 600 ml',1,0,0,12),(42,'RUFLCH','Rufles 45 gr',1,0,0,8.4),(43,'FRIJOLK','Frijol Agranel',0.5,0,0,9.4875),(44,'AZUCARK','Azucar Agranel',0.5,0,0,8.05),(45,'COCAL','Refresco Coca Cola 1 lt',1,0,0,15),(46,'FRIJOLB','Frijol Bolsa de 1 K',1,0,0,19.55),(47,'AZUCARB','Azucar Bolsa de 1 K',1,0,0,17.25),(48,'SABRCH','Sabritas 45 gr',1,0,0,8.4),(49,'COCA6','Refresco Coca Cola de 600 ml',1,0,0,12);

UNLOCK TABLES;


-- Dump completed on 2016-05-07 18:37:22
