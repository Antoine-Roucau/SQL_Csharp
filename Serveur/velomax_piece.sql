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
-- Table structure for table `piece`
--

DROP TABLE IF EXISTS `piece`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `piece` (
  `idPiece` int NOT NULL AUTO_INCREMENT,
  `descriptionPiece` varchar(200) DEFAULT NULL,
  `nomPiece` varchar(50) DEFAULT NULL,
  `prixPiece` int DEFAULT NULL,
  `DateIntroPiece` date DEFAULT NULL,
  `DateStopPiece` date DEFAULT NULL,
  `quantitePiece` int DEFAULT NULL,
  `idFournisseurCommande` int DEFAULT NULL,
  PRIMARY KEY (`idPiece`),
  KEY `idFournisseurCommande` (`idFournisseurCommande`),
  CONSTRAINT `piece_ibfk_1` FOREIGN KEY (`idFournisseurCommande`) REFERENCES `fournisseurcommande` (`idFournisseurCommande`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `piece`
--

LOCK TABLES `piece` WRITE;
/*!40000 ALTER TABLE `piece` DISABLE KEYS */;
INSERT INTO `piece` VALUES (1,'Cadre de vélo en titane','Cadre',200,'2024-01-01',NULL,30,1),(2,'Cadre de vélo en carbone','Cadre',250,'2024-01-01',NULL,25,2),(3,'Guidon de vélo en aluminium','Guidon',40,'2024-01-01',NULL,60,3),(4,'Guidon de vélo en titane','Guidon',60,'2024-01-01',NULL,45,4),(5,'Freins à disque hydrauliques','Freins',120,'2024-01-01',NULL,45,5),(6,'Freins à tambour','Freins',80,'2024-01-01',NULL,60,6),(7,'Selle en cuir','Selle',60,'2024-01-01',NULL,70,7),(8,'Selle gel','Selle',50,'2024-01-01',NULL,80,8),(9,'Dérailleur avant Shimano XTR','Dérailleur avant',180,'2024-01-01',NULL,30,9),(10,'Dérailleur avant Campagnolo Record','Dérailleur avant',200,'2024-01-01',NULL,25,10),(11,'Dérailleur arrière Shimano XTR','Dérailleur arrière',180,'2024-01-01',NULL,30,11),(12,'Dérailleur arrière Campagnolo Record','Dérailleur arrière',200,'2024-01-01',NULL,25,12),(13,'Roue avant en carbone','Roue avant',300,'2024-01-01',NULL,20,13),(14,'Roue avant en aluminium','Roue avant',150,'2024-01-01',NULL,30,14),(15,'Roue arrière en carbone','Roue arrière',300,'2024-01-01',NULL,20,15),(16,'Roue arrière en aluminium','Roue arrière',150,'2024-01-01',NULL,30,16),(17,'Réflecteurs jaunes','Réflecteurs',7,'2024-01-01',NULL,100,17),(18,'Réflecteurs rouges','Réflecteurs',7,'2024-01-01',NULL,100,18),(19,'Pédalier en aluminium','Pédalier',50,'2024-01-01',NULL,40,19),(20,'Pédalier en titane','Pédalier',80,'2024-01-01',NULL,30,20),(21,'Ordinateur de bord GPS','Ordinateur',60,'2024-01-01',NULL,40,21),(22,'Ordinateur de bord Bluetooth','Ordinateur',50,'2024-01-01',NULL,50,22),(23,'Panier en plastique','Panier',20,'2024-01-01',NULL,60,23),(24,'Panier en osier','Panier',30,'2024-01-01',NULL,50,24);
/*!40000 ALTER TABLE `piece` ENABLE KEYS */;
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
