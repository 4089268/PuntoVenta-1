-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: puntoventa
-- ------------------------------------------------------
-- Server version	5.7.12-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `productos` (
  `Codigo` int(11) NOT NULL AUTO_INCREMENT,
  `CodigoExterno` varchar(20) NOT NULL,
  `Descripcion` varchar(40) NOT NULL,
  `Venta` varchar(20) NOT NULL,
  `Precio` float NOT NULL,
  `Iva` int(11) NOT NULL,
  `Stock` float NOT NULL,
  PRIMARY KEY (`Codigo`),
  UNIQUE KEY `CodigoExterno` (`CodigoExterno`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,'COCA6','Refresco Coca Cola de 600 ml','unidad',10,20,38),(2,'COCAL','Refresco Coca Cola 1 lt','unidad',12.5,20,29),(3,'FRESA6','Refresco Fanta de Fresa de 600 ml','unidad',10,20,29),(4,'FANTA6','Refresco Fanta de Naranja de 600 ml','unidad',10,20,30),(5,'AZUCARK','Azucar Agranel','agranel',14,15,29.5),(6,'AZUCARB','Azucar Bolsa de 1 K','unidad',15,15,29),(7,'FRIJOLK','Frijol Agranel','agranel',16.5,15,29.5),(8,'FRIJOLB','Frijol Bolsa de 1 K','unidad',17,15,29),(11,'SABRCH','Sabritas 45 gr','unidad',7,20,29),(12,'RUFLCH','Rufles 45 gr','unidad',7,20,29),(13,'TOSTCH','Tostitos 45 gr','unidad',7,20,30),(14,'SABRG','Sabritas 110 gr','unidad',20,20,30),(15,'RUFLG','Rufles 110 gr','unidad',20,20,30),(16,'TOSTG','Tostitos 110 gr','unidad',20,20,29);
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-05-07 18:37:22
