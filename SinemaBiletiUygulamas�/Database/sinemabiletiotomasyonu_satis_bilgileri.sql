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
-- Table structure for table `satis_bilgileri`
--

DROP TABLE IF EXISTS `satis_bilgileri`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `satis_bilgileri` (
  `SatisId` int(11) NOT NULL,
  `KoltukNo` varchar(50) NOT NULL,
  `SalonAdi` varchar(50) NOT NULL,
  `FilmAdi` varchar(50) NOT NULL,
  `Tarih` varchar(50) NOT NULL,
  `Saat` varchar(50) NOT NULL,
  `Ad` varchar(50) NOT NULL,
  `Soyad` varchar(50) NOT NULL,
  `Ucret` varchar(50) NOT NULL,
  `Tarih2` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `satis_bilgileri`
--

LOCK TABLES `satis_bilgileri` WRITE;
/*!40000 ALTER TABLE `satis_bilgileri` DISABLE KEYS */;
INSERT INTO `satis_bilgileri` VALUES (55,'11','Salon-1','Avengers','Bilim Kurgu','7 Ocak 2021 Perşembe','Deniz','Canlar','5','29.12.2020 03:09:11'),(38,'2','Salon-1','Avengers','Bilim Kurgu','7 Ocak 2021 Perşembe','Derya','Kahraman','5','29.12.2020 03:10:08'),(82,'4','Salon-1','Avengers','Bilim Kurgu','7 Ocak 2021 Perşembe','Özlem','Kahraman','5','29.12.2020 03:15:33'),(89,'9','Salon-1','Şampiyon','Dram-Spor','7 Ocak 2021 Perşembe',' Şerife','Sayal','5','29.12.2020 03:16:07'),(2,'10','Salon-2','Şampiyon','Dram-Spor','7 Ocak 2021 Perşembe',' Esen','Tezel','5','29.12.2020 03:16:50'),(4,'25','Salon-2','Şampiyon','Dram-Spor','7 Ocak 2021 Perşembe','Ayşe Nur','Turan','5','29.12.2020 09:23:04'),(34,'10','Salon-2','Esaretin Bedeli ','Dram','3 Ocak 2021 Pazar','Kübra','Kendirci','5','29.12.2020 17:35:44'),(55,'9','Salon-2','Esaretin Bedeli ','Dram','8 Ocak 2021 Cuma','Elif','Deniz','5','30.12.2020 03:48:04'),(1,'1','Salon-1','Avengers','Bilim Kurgu','30 Aralık 2020 Çarşamba','Şerife','Tezel','5','30.12.2020 15:46:12'),(33,'10','Salon-3','The Green Mile','Dram','30 Aralık 2020 Çarşamba','Kübra','Kendirci','5','30.12.2020 15:57:12');
/*!40000 ALTER TABLE `satis_bilgileri` ENABLE KEYS */;
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
