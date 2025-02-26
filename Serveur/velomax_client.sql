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
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client` (
  `idClient` int NOT NULL AUTO_INCREMENT,
  `nomClient` varchar(50) DEFAULT NULL,
  `prenomClient` varchar(50) DEFAULT NULL,
  `adresseClient` varchar(200) DEFAULT NULL,
  `telClient` varchar(13) DEFAULT NULL,
  `mailClient` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idClient`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (1,'Bozo','Bozo','123 Rue des Lilas, 75001 Paris','0123456789','Bozo.Bozo@example.com'),(2,'Durand','Marie','456 Avenue des Roses, 69002 Lyon','0234567891','marie.durand@example.com'),(3,'Lefebvre','Pierre','789 Boulevard des Champs, 33000 Bordeaux','0345678912','pierre.lefebvre@example.com'),(4,'Leroy','Sophie','1010 Rue du Paradis, 54000 Nancy','0456789123','sophie.leroy@example.com'),(5,'Moreau','Luc','111 Rue de la Paix, 13001 Marseille','0567891234','luc.moreau@example.com'),(6,'Garcia','Céline','1212 Avenue Victor Hugo, 31000 Toulouse','0678912345','celine.garcia@example.com'),(7,'Martinez','Thomas','1313 Rue de la Liberté, 69003 Lyon','0789123456','Thomas.martinez@example.com'),(8,'Schneider','Julie','1414 Avenue du Soleil, 75002 Paris','0891234567','julie.schneider@example.com'),(9,'Bernard','Claire','1515 Boulevard Voltaire, 33001 Bordeaux','0902345678','claire.bernard@example.com'),(10,'Dupont','Marc','1616 Rue de la République, 13002 Marseille','0913456789','marc.Dupont@example.com'),(11,'Thomas','Valérie','1717 Avenue des Fleurs, 54001 Nancy','0924567890','valerie.Thomas@example.com'),(12,'Petit','Philippe','1818 Rue des Pommiers, 31001 Toulouse','0935678901','philippe.petit@example.com'),(13,'Robert','Anne','1919 Boulevard Pasteur, 75003 Paris','0946789012','anne.robert@example.com'),(14,'Richard','David','2020 Avenue de la Mer, 69004 Lyon','0957890123','david.richard@example.com'),(15,'Guerin','Laura','2121 Rue de l\'Espoir, 33002 Bordeaux','0968901234','laura.guerin@example.com'),(16,'Michel','Mathieu','2222 Boulevard des Anges, 13003 Marseille','0979012345','mathieu.michel@example.com'),(17,'Morin','Caroline','2323 Avenue Victor Hugo, 54002 Nancy','0980123456','caroline.morin@example.com'),(18,'André','Juliette','2424 Rue des Roses, 31002 Toulouse','0991234567','juliette.andre@example.com'),(19,'Lefèvre','Antoine','2525 Boulevard de la Liberté, 75004 Paris','0012345678','antoine.lefevre@example.com'),(20,'Lopez','Sophie','2626 Avenue du Bonheur, 69005 Lyon','0123456789','sophie.lopez@example.com'),(21,'Leclerc','Paul','2727 Rue de la Joie, 33003 Bordeaux','0234567891','paul.leclerc@example.com'),(22,'Marchand','Marie','2828 Boulevard des Amoureux, 13004 Marseille','0345678912','marie.marchand@example.com'),(23,'Noël','Lucas','2929 Avenue de la Chance, 54003 Nancy','0456789123','Lucas.noel@example.com'),(24,'Dufour','Emilie','3030 Rue du Sourire, 31003 Toulouse','0567891234','emilie.dufour@example.com'),(25,'Lemoine','Manon','3131 Boulevard de la Paix, 75005 Paris','0678912345','Manon.lemoine@example.com');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
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
