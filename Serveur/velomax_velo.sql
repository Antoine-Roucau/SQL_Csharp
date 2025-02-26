-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: velomax
-- ------------------------------------------------------
-- Server version	8.0.36

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `velo`
--

DROP TABLE IF EXISTS `velo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `velo` (
  `idVelo` int NOT NULL AUTO_INCREMENT,
  `nomVelo` varchar(50) DEFAULT NULL,
  `grandeurVelo` varchar(50) DEFAULT NULL,
  `prixVelo` int DEFAULT NULL,
  `DateIntroVelo` date DEFAULT NULL,
  `DateStopVelo` date DEFAULT NULL,
  `ligneDeProduit` varchar(50) DEFAULT NULL,
  `quantiteVelo` int DEFAULT NULL,
  `idAssemblage` int DEFAULT NULL,
  PRIMARY KEY (`idVelo`),
  KEY `idAssemblage` (`idAssemblage`),
  CONSTRAINT `velo_ibfk_1` FOREIGN KEY (`idAssemblage`) REFERENCES `assemblage` (`idAssemblage`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `velo`
--

LOCK TABLES `velo` WRITE;
/*!40000 ALTER TABLE `velo` DISABLE KEYS */;
INSERT INTO `velo` VALUES (1,'Kilimandjaro','Adultes',569,'2024-01-01',NULL,'VTT',30,1),(2,'NorthPole','Adultes',329,'2024-01-15',NULL,'VTT',35,2),(3,'MontBlanc','Jeunes',399,'2024-02-01',NULL,'VTT',40,3),(4,'Hooligan','Jeunes',199,'2024-02-15',NULL,'VTT',45,4),(5,'Orléans','Hommes',229,'2024-03-01',NULL,'Vélo de course',50,5),(6,'Orléans','Dames',229,'2024-03-15',NULL,'Vélo de course',55,6),(7,'BlueJay','Hommes',349,'2024-04-01',NULL,'Vélo de course',60,7),(8,'BlueJay','Dames',349,'2024-04-15',NULL,'Vélo de course',65,8),(9,'Trail Explorer','Filles',129,'2024-05-01',NULL,'Classique',70,9),(10,'Trail Explorer','Garçons',129,'2024-05-15',NULL,'Classique',75,10),(11,'Night Hawk','Jeunes',189,'2024-06-01',NULL,'Classique',80,11),(12,'Tierra Verde','Hommes',199,'2024-06-15',NULL,'Classique',85,12),(13,'Tierra Verde','Dames',199,'2024-07-01',NULL,'Classique',90,13),(14,'Mud Zinger I','Jeunes',279,'2024-07-15',NULL,'BMX',95,14),(15,'Mud Zinger II','Adultes',359,'2024-08-01',NULL,'BMX',100,15);
/*!40000 ALTER TABLE `velo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-02-26 18:28:11
