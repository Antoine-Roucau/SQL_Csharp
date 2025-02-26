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
-- Table structure for table `entreprises`
--

DROP TABLE IF EXISTS `entreprises`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `entreprises` (
  `idEntreprises` int NOT NULL AUTO_INCREMENT,
  `nomEntreprises` varchar(50) DEFAULT NULL,
  `nomContact` varchar(50) DEFAULT NULL,
  `adresseEntreprises` varchar(200) DEFAULT NULL,
  `telEntreprises` varchar(13) DEFAULT NULL,
  `mailEntreprises` varchar(100) DEFAULT NULL,
  `reduction` int DEFAULT NULL,
  PRIMARY KEY (`idEntreprises`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entreprises`
--

LOCK TABLES `entreprises` WRITE;
/*!40000 ALTER TABLE `entreprises` DISABLE KEYS */;
INSERT INTO `entreprises` VALUES (1,'SportVelo Lyon','Jean Dupont','1 Rue des Cyclistes, 69001 Lyon','0123456789','Lyon@sportvelo.com',10),(2,'VeloPassion Paris','Marie Durand','2 Avenue des Vélos, 75002 Paris','0234567891','Paris@velopassion.com',15),(3,'RoueLibre Marseille','Pierre Lefebvre','3 Boulevard des Roues, 13003 Marseille','0345678912','Marseille@rouelibre.com',20),(4,'CycleShop Bordeaux','Sophie Leroy','4 Rue des Bikers, 33004 Bordeaux','0456789123','Brdeaux@cycleshop.com',10),(5,'VeloMania Toulouse','Luc Moreau','5 Avenue des Cyclistes, 31005 Toulouse','0567891234','Toulouse@velomania.com',5);
/*!40000 ALTER TABLE `entreprises` ENABLE KEYS */;
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
