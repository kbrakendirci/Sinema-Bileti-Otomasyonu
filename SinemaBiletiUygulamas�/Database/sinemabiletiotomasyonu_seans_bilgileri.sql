-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: sinemabiletiotomasyonu
-- ------------------------------------------------------
-- Server version	8.0.17

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
-- Table structure for table `seans_bilgileri`
--

DROP TABLE IF EXISTS `seans_bilgileri`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `seans_bilgileri` (
  `SeansId` int(11) NOT NULL,
  `FilmAdi` varchar(50) NOT NULL,
  `SalonAdi` varchar(50) NOT NULL,
  `Tarih` varchar(50) NOT NULL,
  `Seans` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seans_bilgileri`
--

LOCK TABLES `seans_bilgileri` WRITE;
/*!40000 ALTER TABLE `seans_bilgileri` DISABLE KEYS */;
INSERT INTO `seans_bilgileri` VALUES (90,'Avengers','Salon-1','30 Aralık 2020 Çarşamba','18:00:00'),(60,'Esaretin Bedeli ','Salon-2','30 Aralık 2020 Çarşamba','17:00:00'),(29,'Şampiyon','Salon-3','30 Aralık 2020 Çarşamba','20:00:00'),(28,'The Green Mile','Salon-1','30 Aralık 2020 Çarşamba','19:00:00'),(3,'Avengers','Salon-1','31 Aralık 2020 Perşembe','21:00:00'),(72,'Esaretin Bedeli ','Salon-2','31 Aralık 2020 Perşembe','10:00:00'),(72,'The Green Mile','Salon-3','31 Aralık 2020 Perşembe','11:00:00'),(47,'Şampiyon','Salon-1','31 Aralık 2020 Perşembe','12:00:00'),(78,'Avengers','Salon-2','31 Aralık 2020 Perşembe','13:00:00'),(54,'The Green Mile','Salon-2','31 Aralık 2020 Perşembe','17:00:00'),(21,'Şampiyon','Salon-3','31 Aralık 2020 Perşembe','12:00:00'),(20,'The Green Mile','Salon-3','31 Aralık 2020 Perşembe','13:00:00');
/*!40000 ALTER TABLE `seans_bilgileri` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-12-30 19:15:09
