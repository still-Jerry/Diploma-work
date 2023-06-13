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
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-12 21:59:19
