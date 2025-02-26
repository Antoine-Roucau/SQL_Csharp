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
-- Table structure for table `assemblage`
--

DROP TABLE IF EXISTS `assemblage`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `assemblage` (
  `idAssemblage` int NOT NULL AUTO_INCREMENT,
  `grandeurAssemblage` varchar(50) DEFAULT NULL,
  `nomAssemblage` varchar(50) DEFAULT NULL,
  `cadre` int DEFAULT NULL,
  `guidon` int DEFAULT NULL,
  `freins` int DEFAULT NULL,
  `selle` int DEFAULT NULL,
  `derailleurAvant` int DEFAULT NULL,
  `derailleurArriere` int DEFAULT NULL,
  `roueAvant` int DEFAULT NULL,
  `roueArriere` int DEFAULT NULL,
  `reflecteurs` int DEFAULT NULL,
  `pedalier` int DEFAULT NULL,
  `ordinateur` int DEFAULT NULL,
  `panier` int DEFAULT NULL,
  PRIMARY KEY (`idAssemblage`),
  KEY `cadre` (`cadre`),
  KEY `guidon` (`guidon`),
  KEY `freins` (`freins`),
  KEY `selle` (`selle`),
  KEY `derailleurAvant` (`derailleurAvant`),
  KEY `derailleurArriere` (`derailleurArriere`),
  KEY `roueAvant` (`roueAvant`),
  KEY `roueArriere` (`roueArriere`),
  KEY `reflecteurs` (`reflecteurs`),
  KEY `pedalier` (`pedalier`),
  KEY `ordinateur` (`ordinateur`),
  KEY `panier` (`panier`),
  CONSTRAINT `assemblage_ibfk_1` FOREIGN KEY (`cadre`) REFERENCES `piece` (`idPiece`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `assemblage_ibfk_10` FOREIGN KEY (`pedalier`) REFERENCES `piece` (`idPiece`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `assemblage_ibfk_11` FOREIGN KEY (`ordinateur`) REFERENCES `piece` (`idPiece`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `assemblage_ibfk_12` FOREIGN KEY (`panier`) REFERENCES `piece` (`idPiece`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `assemblage_ibfk_2` FOREIGN KEY (`guidon`) REFERENCES `piece` (`idPiece`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `assemblage_ibfk_3` FOREIGN KEY (`freins`) REFERENCES `piece` (`idPiece`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `assemblage_ibfk_4` FOREIGN KEY (`selle`) REFERENCES `piece` (`idPiece`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `assemblage_ibfk_5` FOREIGN KEY (`derailleurAvant`) REFERENCES `piece` (`idPiece`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `assemblage_ibfk_6` FOREIGN KEY (`derailleurArriere`) REFERENCES `piece` (`idPiece`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `assemblage_ibfk_7` FOREIGN KEY (`roueAvant`) REFERENCES `piece` (`idPiece`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `assemblage_ibfk_8` FOREIGN KEY (`roueArriere`) REFERENCES `piece` (`idPiece`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `assemblage_ibfk_9` FOREIGN KEY (`reflecteurs`) REFERENCES `piece` (`idPiece`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assemblage`
--

LOCK TABLES `assemblage` WRITE;
/*!40000 ALTER TABLE `assemblage` DISABLE KEYS */;
INSERT INTO `assemblage` VALUES (1,'Adultes','Kilimandjaro',1,3,5,7,9,11,13,15,NULL,20,21,NULL),(2,'Adultes','NorthPole',2,4,6,8,10,12,14,16,NULL,19,NULL,NULL),(3,'Jeunes','MontBlanc',1,3,5,7,9,11,13,15,NULL,20,22,NULL),(4,'Jeunes','Hooligan',2,4,6,8,10,12,14,16,NULL,19,NULL,NULL),(5,'Hommes','Orléans',1,3,5,7,9,11,13,15,17,20,NULL,NULL),(6,'Dames','Orléans',2,4,6,8,10,12,14,16,17,19,NULL,NULL),(7,'Hommes','BlueJay',1,3,5,7,9,11,13,15,17,20,22,NULL),(8,'Dames','BlueJay',2,4,6,8,10,12,14,16,17,19,22,NULL),(9,'Filles','Trail Explorer',1,3,NULL,7,NULL,NULL,13,15,17,20,NULL,24),(10,'Garçons','Trail Explorer',2,NULL,6,NULL,NULL,12,14,16,17,19,NULL,24),(11,'Jeunes','Night Hawk',1,3,5,7,9,11,13,15,17,20,NULL,23),(12,'Hommes','Tierra Verde',2,4,6,8,10,12,14,16,17,19,NULL,23),(13,'Dames','Tierra Verde',1,3,5,7,9,11,13,15,17,20,NULL,23),(14,'Jeunes','Mud Zinger I',2,4,6,8,10,12,14,16,NULL,19,NULL,NULL),(15,'Adultes','Mud Zinger II',1,3,5,7,9,11,13,15,NULL,20,NULL,NULL);
/*!40000 ALTER TABLE `assemblage` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-02-26 18:28:12
