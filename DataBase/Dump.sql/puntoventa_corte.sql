-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: puntoventa
-- ------------------------------------------------------
-- Server version	5.7.12-log


--
-- Table structure for table `corte`
--

DROP TABLE IF EXISTS `corte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `corte` (
  `idCorte` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha` date NOT NULL,
  `Cajero` varchar(50) NOT NULL,
  `Turno` varchar(15) NOT NULL,
  `Total` float NOT NULL,
  PRIMARY KEY (`idCorte`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `corte`
--

LOCK TABLES `corte` WRITE;
/*!40000 ALTER TABLE `corte` DISABLE KEYS */;
INSERT INTO `corte` VALUES (0,'2016-05-06','ninguno','ninguno',100),(1,'2016-05-06','Carmen Montaño','TERCERO',48.8),(2,'2016-05-06','Carlos Cardenas','PRIMERO',15),(3,'2016-05-06','Carlos Cardenas','PRIMERO',24),(4,'2016-05-06','admon','SEGUNDO',120),(5,'2016-05-06','admon','TERCERO',24),(6,'2016-05-06','Carmen Montaño','SEGUNDO',27),(7,'2016-05-06','Carmen Montaño','PRIMERO',35.65),(8,'2016-05-06','Carlos Cardenas','PRIMERO',0),(9,'2016-05-06','Carlos Cardenas','PRIMERO',0),(10,'2016-05-07','Carlos Cardenas','SEGUNDO',57.2);
/*!40000 ALTER TABLE `corte` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

-- Dump completed on 2016-05-07 18:37:23
