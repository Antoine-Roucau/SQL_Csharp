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
-- Table structure for table `employe`
--

DROP TABLE IF EXISTS `employe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employe` (
  `idEmploye` int NOT NULL AUTO_INCREMENT,
  `nomEmploye` varchar(50) DEFAULT NULL,
  `prenomEmploye` varchar(50) DEFAULT NULL,
  `fonction` varchar(50) DEFAULT NULL,
  `tempsTravail` int DEFAULT NULL,
  `pourcentageBonus` int DEFAULT NULL,
  `idMagasin` int DEFAULT NULL,
  PRIMARY KEY (`idEmploye`),
  KEY `idMagasin` (`idMagasin`),
  CONSTRAINT `employe_ibfk_1` FOREIGN KEY (`idMagasin`) REFERENCES `magasin` (`idMagasin`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employe`
--

LOCK TABLES `employe` WRITE;
/*!40000 ALTER TABLE `employe` DISABLE KEYS */;
INSERT INTO `employe` VALUES (1,'Gagnon','Jean','Manager',40,15,1),(2,'Tremblay','Sophie','Manager',40,15,2),(3,'Lefebvre','Pierre','Manager',40,15,3),(4,'Bergeron','Marie','Vendeur',35,10,1),(5,'Leblanc','Michel','Vendeur',35,10,1),(6,'Roy','Isabelle','Vendeur',35,10,2),(7,'Lavoie','Nicolas','Vendeur',35,10,2),(8,'Gauthier','Catherine','Vendeur',35,10,3),(9,'Morin','Sylvie','Vendeur',35,10,3),(10,'Fortin','Philippe','Réparateur',40,10,1),(11,'Lemieux','Émilie','Réparateur',40,10,1),(12,'Pelletier','Mathieu','Réparateur',40,10,2),(13,'Rousseau','Julie','Réparateur',40,10,2),(14,'Girard','David','Réparateur',40,10,3),(15,'Simard','Caroline','Réparateur',40,10,3),(16,'Caron','Patrick','Gestionnaire',40,15,1),(17,'Martel','Valérie','Gestionnaire',40,15,2),(18,'Bouchard','Luc','Gestionnaire',40,15,3);
/*!40000 ALTER TABLE `employe` ENABLE KEYS */;
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
