CREATE DATABASE  IF NOT EXISTS `diploma` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `diploma`;
-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: diploma
-- ------------------------------------------------------
-- Server version	8.0.30

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
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `category` (
  `idСategory` int NOT NULL AUTO_INCREMENT,
  `nameСategory` varchar(70) NOT NULL,
  PRIMARY KEY (`idСategory`),
  UNIQUE KEY `nameСategory_UNIQUE` (`nameСategory`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category`
--

LOCK TABLES `category` WRITE;
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` VALUES (2,'Антибактериальные'),(1,'Гормоны'),(3,'Противовирусные'),(4,'Противоопухолевые');
/*!40000 ALTER TABLE `category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `list`
--

DROP TABLE IF EXISTS `list`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `list` (
  `id` int NOT NULL AUTO_INCREMENT,
  `idOrderList` int NOT NULL,
  `quantityList` int NOT NULL,
  `seriesProductList` int NOT NULL,
  `prescriptionNumberList` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idOrderList_idx` (`idOrderList`),
  KEY `seriesProductList_idx` (`seriesProductList`),
  CONSTRAINT `idOrderList` FOREIGN KEY (`idOrderList`) REFERENCES `order` (`idOrder`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `seriesProductList` FOREIGN KEY (`seriesProductList`) REFERENCES `seriesproduct` (`idSeries`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `list`
--

LOCK TABLES `list` WRITE;
/*!40000 ALTER TABLE `list` DISABLE KEYS */;
INSERT INTO `list` VALUES (2,9,1,3,0),(3,9,1,20,2340),(4,9,1,14,0);
/*!40000 ALTER TABLE `list` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order`
--

DROP TABLE IF EXISTS `order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order` (
  `idOrder` int NOT NULL AUTO_INCREMENT,
  `userOrder` int NOT NULL,
  `dateOrder` datetime NOT NULL,
  PRIMARY KEY (`idOrder`),
  KEY `userOrder_idx` (`userOrder`),
  CONSTRAINT `userOrder` FOREIGN KEY (`userOrder`) REFERENCES `user` (`idUser`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order`
--

LOCK TABLES `order` WRITE;
/*!40000 ALTER TABLE `order` DISABLE KEYS */;
INSERT INTO `order` VALUES (9,1,'2023-05-31 00:00:00');
/*!40000 ALTER TABLE `order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `idProduct` int NOT NULL AUTO_INCREMENT,
  `nameProduct` varchar(70) NOT NULL,
  `categoryProduct` int NOT NULL,
  `priceProduct` decimal(19,2) NOT NULL,
  `storageRackProduct` int NOT NULL,
  `descriptionProduct` text,
  `manufacturerProduct` varchar(70) DEFAULT NULL,
  `pictureProduct` text,
  `isPrescriptionProduct` tinyint NOT NULL,
  `discountProduct` decimal(2,2) NOT NULL,
  PRIMARY KEY (`idProduct`),
  KEY `categoryProduct_idx` (`categoryProduct`),
  CONSTRAINT `categoryProduct` FOREIGN KEY (`categoryProduct`) REFERENCES `category` (`idСategory`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (1,'Ингавирин',3,900.00,1,'Капсулы, Действующее вещество: Имидазолилэтанамид пентандиовой кислоты','Валента, Россия','',0,0.10),(2,'Гриппферон',3,290.00,1,'Капли назальные, Действующее вещество: Интерферон альфа-2b',' Фирн М, Россия','Гриппферон.jpeg',0,0.10),(3,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия',NULL,1,0.25),(4,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия',NULL,1,0.25),(6,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия',NULL,1,0.25),(8,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия','Прогестерон.jpg',1,0.25),(9,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия','Прогестерон.jpg',1,0.25),(10,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия','Прогестерон.jpg',1,0.25),(11,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия',NULL,1,0.25),(12,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия','Прогестерон.jpg',1,0.25),(13,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия',NULL,1,0.25),(14,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия',NULL,1,0.25),(15,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия','Прогестерон.jpg',1,0.25),(16,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия',NULL,1,0.25),(17,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия',NULL,1,0.25),(18,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия','Прогестерон.jpg',1,0.25),(19,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия',NULL,1,0.25),(20,'Анастрозол',4,992.00,5,'1 таблетка, покрытая пленочной оболочкой, содержит:\r\nактивное вещество: анастрозол 1,051* мг','Россия Фармасинтез-Норд АО ','638208987283151274Анастрозол.jpg',0,0.00),(21,'Лайфферон',4,845.00,5,'Препарат представляет собой бесцветный прозрачный или слабо опалесцирующий раствор.','Вектор-Медика АО - Россия','638209194787720230Лайфферон.jpg',1,0.05),(23,'ВИФЕРОН',4,330.00,5,'1 суппозиторий ВИФЕРОН® 150 000 МЕ содержит:\r\nактивное вещество: интерферон альфа-2b человеческий рекомбинантный 150 000 МЕ,','ФЕРОН ОО - Россия','638209192826785364ВИФЕРОН.jpg',0,0.05),(26,'Зитига',4,16900.75,5,'Действующее вещество: Абиратерон\r\nФорма выпуска: таб. вн. фл.','Патеон Инк. - Аптека','638209616840640330Зигита.jpg',1,0.90),(29,'Ярина',1,1280.00,5,'Действующее вещество: Дроспиренон, Этинилэстрадиол',' Байер Веймар ГмбХ и Ко. КГ - Германия','638209869566281702Ярина.jpg',1,0.50);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role` (
  `idRole` int NOT NULL AUTO_INCREMENT,
  `nameRole` varchar(30) NOT NULL,
  PRIMARY KEY (`idRole`),
  UNIQUE KEY `nameRole_UNIQUE` (`nameRole`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES (1,'Заведующий'),(2,'Фармацевт');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `seriesproduct`
--

DROP TABLE IF EXISTS `seriesproduct`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `seriesproduct` (
  `idSeries` int NOT NULL AUTO_INCREMENT,
  `productIdSeries` int NOT NULL,
  `expirationDateSeries` date NOT NULL,
  `countProductSeries` int NOT NULL,
  PRIMARY KEY (`idSeries`),
  KEY `productIdSeries_idx` (`productIdSeries`),
  CONSTRAINT `productIdSeries` FOREIGN KEY (`productIdSeries`) REFERENCES `product` (`idProduct`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seriesproduct`
--

LOCK TABLES `seriesproduct` WRITE;
/*!40000 ALTER TABLE `seriesproduct` DISABLE KEYS */;
INSERT INTO `seriesproduct` VALUES (1,3,'2023-05-31',5),(2,2,'2023-06-24',100),(3,23,'2023-12-30',80),(4,21,'2023-05-29',30),(5,1,'2023-05-29',40),(6,3,'2025-05-23',110),(7,4,'2023-06-04',6),(8,6,'2023-06-03',4),(9,6,'2023-07-30',15),(10,8,'2026-08-15',140),(11,10,'2023-12-30',10),(12,11,'2023-05-29',50),(13,12,'2023-09-10',90),(14,20,'2045-11-17',8000),(16,2,'2023-05-29',89),(20,29,'2025-07-18',70),(21,1,'2023-05-28',23),(23,2,'2023-06-02',1),(24,1,'2023-05-31',230);
/*!40000 ALTER TABLE `seriesproduct` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `idUser` int NOT NULL AUTO_INCREMENT,
  `surnameUser` varchar(70) NOT NULL,
  `nameUser` varchar(35) NOT NULL,
  `patronymicUser` varchar(70) DEFAULT NULL,
  `loginUser` varchar(45) NOT NULL,
  `passwordUser` text NOT NULL,
  `roleUser` int NOT NULL,
  `saltUser` varchar(30) NOT NULL,
  PRIMARY KEY (`idUser`),
  UNIQUE KEY `loginUser_UNIQUE` (`loginUser`),
  KEY `roleUser_idx` (`roleUser`),
  CONSTRAINT `roleUser` FOREIGN KEY (`roleUser`) REFERENCES `role` (`idRole`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Заведователь','Екатерина','Андреевна','some_login@mail.com','2c63bcd330168348ff8b8688e3a1a61b632c39a517c6ba7856df819ccf6cbba2',1,'QweSaLt'),(2,'Фрамацефтович','Владислав','Дмитриевич','qwe123@mail.com','7d19d34e950fe247c866f7a24c2ea5566ed818a6b1dd06ee8e89eccd40f1f326',2,'QweSaLt2');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-31 19:23:06
