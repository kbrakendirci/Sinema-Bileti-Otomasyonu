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
-- Table structure for table `film_bilgileri`
--

DROP TABLE IF EXISTS `film_bilgileri`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `film_bilgileri` (
  `FilmId` int(11) NOT NULL,
  `FilmAdi` varchar(100) NOT NULL,
  `Yönetmen` varchar(100) NOT NULL,
  `FilmTürü` varchar(100) NOT NULL,
  `FilmSüresi` varchar(100) NOT NULL,
  `Tarih` varchar(100) NOT NULL,
  `YapimYili` varchar(100) NOT NULL,
  `Resim` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`FilmAdi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `film_bilgileri`
--

LOCK TABLES `film_bilgileri` WRITE;
/*!40000 ALTER TABLE `film_bilgileri` DISABLE KEYS */;
INSERT INTO `film_bilgileri` VALUES (1,'Avengers','Joss Whedon','Bilim Kurgu','2 Saat 20 dakila','23 Ekim 2012 Salı','25 Aralık 2020 Cuma','C:\\Users\\Derya Kendirci\\source\\repos\\SinemaBiletiUygulaması\\Resources\\avengers.jpg'),(2,'Esaretin Bedeli ','Frank Darabont','Dram','2 saat','28 Haziran 1994 Salı','6 Ocak 2021 Çarşamba','C:\\Users\\Derya Kendirci\\source\\repos\\SinemaBiletiUygulaması\\Resources\\Shawshank.jpg'),(3,'Şampiyon','Ahmet Katıksız','Dram-Spor','2 saat','7 Aralık 2018 Cuma','28 Aralık 2020 Pazartesi','C:\\Users\\Derya Kendirci\\source\\repos\\SinemaBiletiUygulaması\\Resources\\şampiyon.jpg'),(4,'The Green Mile',' Frank Darabont','Dram','3 Saat','20 Ocak 1999 Çarşamba','20 Ocak 2021 Çarşamba','C:\\Users\\Derya Kendirci\\source\\repos\\SinemaBiletiUygulaması\\Resources\\301px-TheGreenMileCover.jpg');
/*!40000 ALTER TABLE `film_bilgileri` ENABLE KEYS */;
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
