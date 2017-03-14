-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
-- Host: localhost    Database: puntoventa
-- Server version	5.7.12-log

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ventas` (
  `idVentas` int(11) NOT NULL AUTO_INCREMENT,
  `Hora` datetime NOT NULL,
  `Subtotal` float NOT NULL,
  `Iva` float NOT NULL,
  `Total` float NOT NULL,
  `Corte` int(11) NOT NULL,
  PRIMARY KEY (`idVentas`),
  KEY `Corte_idx` (`Corte`)
  
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;


--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
INSERT INTO `ventas` 
VALUES (0,'2008-10-05 00:00:00',0,0,0,0),
(13,'2016-05-06 13:21:18',42,6.8,48.8,1),
(14,'2016-05-06 13:21:39',42,6.8,48.8,1),
(15,'2016-05-06 13:22:49',10,2,12,2),
(16,'2016-05-06 13:23:02',12.5,2.5,15,2),
(17,'2016-05-06 13:24:54',20,4,24,3),
(18,'2016-05-06 15:38:04',100,20,120,4),
(19,'2016-05-06 15:39:08',20,4,24,5),
(20,'2016-05-06 17:27:50',22.5,4.5,27,6),
(21,'2016-05-06 17:28:22',31,4.65,35.65,7),
(22,'2016-05-07 17:39:47',47,9.4,56.4,10),
(23,'2016-05-07 17:40:46',27.75,4.7875,32.5375,10),
(24,'2016-05-07 17:41:58',49,8.2,57.2,10);

UNLOCK TABLES;

