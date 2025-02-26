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
-- Table structure for table `commande`
--

DROP TABLE IF EXISTS `commande`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `commande` (
  `idCommande` int NOT NULL AUTO_INCREMENT,
  `dateCommande` datetime DEFAULT NULL,
  `dateLivraison` datetime DEFAULT NULL,
  `adresseLivraison` varchar(200) DEFAULT NULL,
  `idEmploye` int DEFAULT NULL,
  `idMagasin` int DEFAULT NULL,
  `idClient` int DEFAULT NULL,
  `idEntreprises` int DEFAULT NULL,
  PRIMARY KEY (`idCommande`),
  KEY `idEmploye` (`idEmploye`),
  KEY `idMagasin` (`idMagasin`),
  KEY `idClient` (`idClient`),
  KEY `idEntreprises` (`idEntreprises`),
  CONSTRAINT `commande_ibfk_1` FOREIGN KEY (`idEmploye`) REFERENCES `employe` (`idEmploye`) ON UPDATE CASCADE,
  CONSTRAINT `commande_ibfk_2` FOREIGN KEY (`idMagasin`) REFERENCES `magasin` (`idMagasin`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `commande_ibfk_3` FOREIGN KEY (`idClient`) REFERENCES `client` (`idClient`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `commande_ibfk_4` FOREIGN KEY (`idEntreprises`) REFERENCES `entreprises` (`idEntreprises`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `commande`
--

LOCK TABLES `commande` WRITE;
/*!40000 ALTER TABLE `commande` DISABLE KEYS */;
INSERT INTO `commande` VALUES (1,'2024-01-01 10:00:00','2024-01-10 10:00:00','123 Rue des Lilas, 75001 Paris',1,1,1,NULL),(2,'2024-01-02 11:00:00','2024-01-11 11:00:00','456 Avenue des Roses, 69002 Lyon',2,2,1,NULL),(3,'2024-01-03 12:00:00','2024-01-12 12:00:00','789 Boulevard des Champs, 33000 Bordeaux',3,3,3,NULL),(4,'2024-01-04 13:00:00','2024-01-13 13:00:00','1010 Rue du Paradis, 54000 Nancy',4,1,4,NULL),(5,'2024-01-05 14:00:00','2024-01-14 14:00:00','111 Rue de la Paix, 13001 Marseille',5,2,5,NULL),(6,'2024-01-06 15:00:00','2024-01-15 15:00:00','1212 Avenue Victor Hugo, 31000 Toulouse',6,3,6,NULL),(7,'2024-01-07 16:00:00','2024-01-16 16:00:00','1313 Rue de la Liberté, 69003 Lyon',1,1,7,NULL),(8,'2024-01-08 17:00:00','2024-01-17 17:00:00','1414 Avenue du Soleil, 75002 Paris',2,2,8,NULL),(9,'2024-01-09 18:00:00','2024-01-18 18:00:00','1515 Boulevard Voltaire, 33001 Bordeaux',3,3,9,NULL),(10,'2024-01-10 19:00:00','2024-01-19 19:00:00','1 Rue des Cyclistes, 69001 Lyon',4,1,NULL,1),(11,'2024-01-11 20:00:00','2024-01-20 20:00:00','2 Avenue des Vélos, 75002 Paris',5,2,NULL,2),(12,'2024-01-12 21:00:00','2024-01-21 21:00:00','3 Boulevard des Roues, 13003 Marseille',6,3,NULL,3),(13,'2024-01-13 22:00:00','2024-01-22 22:00:00','4 Rue des Bikers, 33004 Bordeaux',1,1,NULL,4),(14,'2024-01-14 23:00:00','2024-01-23 23:00:00','5 Avenue des Cyclistes, 31005 Toulouse',2,2,NULL,5),(15,'2024-01-15 00:00:00','2024-01-24 00:00:00','1515 Boulevard Voltaire, 33001 Bordeaux',3,3,10,NULL),(16,'2024-01-16 01:00:00','2024-01-25 01:00:00','1 Rue des Cyclistes, 69001 Lyon',4,1,NULL,1),(17,'2024-01-17 02:00:00','2024-01-26 02:00:00','1414 Avenue du Soleil, 75002 Paris',5,2,11,NULL),(18,'2024-01-18 03:00:00','2024-01-27 03:00:00','2 Avenue des Vélos, 75002 Paris',6,3,NULL,2),(19,'2024-01-19 04:00:00','2024-01-28 04:00:00','1313 Rue de la Liberté, 69003 Lyon',1,1,12,NULL),(20,'2024-01-20 05:00:00','2024-01-29 05:00:00','123 Rue des Lillas, 75001 Paris',2,2,13,NULL),(21,'2024-01-21 06:00:00','2024-01-30 06:00:00','3 Boulevard des Roues, 13003 Marseille',3,3,NULL,3),(22,'2024-01-22 07:00:00','2024-01-31 07:00:00','4 Rue des Bikers, 33004 Bordeaux',4,1,NULL,4),(23,'2024-01-23 08:00:00','2024-02-01 08:00:00','5 Avenue des Cyclistes, 31005 Toulouse',5,2,14,NULL),(24,'2024-01-24 09:00:00','2024-02-02 09:00:00','1 Rue des Cyclistes, 69001 Lyon',6,3,NULL,1),(25,'2024-01-25 10:00:00','2024-02-03 10:00:00','1414 Avenue du Soleil, 75002 Paris',1,1,15,NULL);
/*!40000 ALTER TABLE `commande` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-02-26 18:28:10
