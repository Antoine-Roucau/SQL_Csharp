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
-- Table structure for table `appartientcommande`
--

DROP TABLE IF EXISTS `appartientcommande`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appartientcommande` (
  `idAppartientCommande` int NOT NULL AUTO_INCREMENT,
  `idCommande` int DEFAULT NULL,
  `idVelo` int DEFAULT NULL,
  `idPiece` int DEFAULT NULL,
  `quantiteAppartientComande` int DEFAULT NULL,
  PRIMARY KEY (`idAppartientCommande`),
  KEY `idCommande` (`idCommande`),
  KEY `idVelo` (`idVelo`),
  KEY `idPiece` (`idPiece`),
  CONSTRAINT `appartientcommande_ibfk_1` FOREIGN KEY (`idCommande`) REFERENCES `commande` (`idCommande`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `appartientcommande_ibfk_2` FOREIGN KEY (`idVelo`) REFERENCES `velo` (`idVelo`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `appartientcommande_ibfk_3` FOREIGN KEY (`idPiece`) REFERENCES `piece` (`idPiece`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appartientcommande`
--

LOCK TABLES `appartientcommande` WRITE;
/*!40000 ALTER TABLE `appartientcommande` DISABLE KEYS */;
INSERT INTO `appartientcommande` VALUES (1,1,NULL,1,2),(2,1,1,NULL,1),(3,2,NULL,2,1),(4,2,2,NULL,1),(5,3,NULL,3,1),(6,3,NULL,4,2),(7,3,3,NULL,1),(8,4,NULL,5,1),(9,4,NULL,6,2),(10,4,4,NULL,1),(11,5,NULL,7,3),(12,5,5,NULL,1),(13,6,NULL,8,1),(14,6,NULL,9,1),(15,6,6,NULL,1),(16,7,NULL,10,2),(17,7,7,NULL,1),(18,8,NULL,11,1),(19,8,8,NULL,1),(20,9,NULL,12,2),(21,9,9,NULL,1),(22,10,NULL,13,1),(23,10,9,NULL,2),(24,11,NULL,14,1),(25,12,NULL,15,2),(26,13,NULL,16,1),(27,14,NULL,17,2),(28,15,NULL,18,1),(29,16,NULL,19,2),(30,17,NULL,20,1),(31,18,NULL,21,2),(32,19,NULL,22,1),(33,20,NULL,23,2),(34,21,NULL,24,1),(35,22,NULL,24,2),(36,23,NULL,1,1),(37,24,NULL,2,2),(38,25,NULL,3,1);
/*!40000 ALTER TABLE `appartientcommande` ENABLE KEYS */;
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
