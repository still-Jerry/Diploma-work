-- MySqlBackup.NET 2.3.6
-- Dump Time: 2023-06-14 03:19:28
-- --------------------------------------
-- Server version 8.0.30 MySQL Community Server - GPL


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of category
-- 

DROP TABLE IF EXISTS `category`;
CREATE TABLE IF NOT EXISTS `category` (
  `idСategory` int NOT NULL AUTO_INCREMENT,
  `nameСategory` varchar(70) NOT NULL,
  PRIMARY KEY (`idСategory`),
  UNIQUE KEY `nameСategory_UNIQUE` (`nameСategory`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table category
-- 

/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category`(`idСategory`,`nameСategory`) VALUES(1,'Антибиотики'),(2,'Иммунная система'),(3,'Противовирусные'),(4,'Противогрибковые'),(5,'Сердечно-сосудистые'),(6,'Эндокринология');
/*!40000 ALTER TABLE `category` ENABLE KEYS */;

-- 
-- Definition of product
-- 

DROP TABLE IF EXISTS `product`;
CREATE TABLE IF NOT EXISTS `product` (
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

-- 
-- Dumping data for table product
-- 

/*!40000 ALTER TABLE `product` DISABLE KEYS */;

/*!40000 ALTER TABLE `product` ENABLE KEYS */;

-- 
-- Definition of role
-- 

DROP TABLE IF EXISTS `role`;
CREATE TABLE IF NOT EXISTS `role` (
  `idRole` int NOT NULL AUTO_INCREMENT,
  `nameRole` varchar(30) NOT NULL,
  PRIMARY KEY (`idRole`),
  UNIQUE KEY `nameRole_UNIQUE` (`nameRole`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table role
-- 

/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role`(`idRole`,`nameRole`) VALUES(1,'Заведующий'),(2,'Фармацевт');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;

-- 
-- Definition of seriesproduct
-- 

DROP TABLE IF EXISTS `seriesproduct`;
CREATE TABLE IF NOT EXISTS `seriesproduct` (
  `idSeries` int NOT NULL AUTO_INCREMENT,
  `productIdSeries` int NOT NULL,
  `expirationDateSeries` date NOT NULL,
  `countProductSeries` int NOT NULL,
  PRIMARY KEY (`idSeries`),
  KEY `productIdSeries_idx` (`productIdSeries`),
  CONSTRAINT `productIdSeries` FOREIGN KEY (`productIdSeries`) REFERENCES `product` (`idProduct`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table seriesproduct
-- 

/*!40000 ALTER TABLE `seriesproduct` DISABLE KEYS */;

/*!40000 ALTER TABLE `seriesproduct` ENABLE KEYS */;

-- 
-- Definition of list
-- 

DROP TABLE IF EXISTS `list`;
CREATE TABLE IF NOT EXISTS `list` (
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

-- 
-- Dumping data for table list
-- 

/*!40000 ALTER TABLE `list` DISABLE KEYS */;

/*!40000 ALTER TABLE `list` ENABLE KEYS */;

-- 
-- Definition of user
-- 

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
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

-- 
-- Dumping data for table user
-- 

/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user`(`idUser`,`surnameUser`,`nameUser`,`patronymicUser`,`loginUser`,`passwordUser`,`roleUser`,`saltUser`) VALUES(1,'Заведователь','Екатерина','Андреевна','some_login@mail.com','2c63bcd330168348ff8b8688e3a1a61b632c39a517c6ba7856df819ccf6cbba2',1,'QweSaLt'),(2,'Фрамацефтович','Владислав','Дмитриевич','qwe123@mail.com','7d19d34e950fe247c866f7a24c2ea5566ed818a6b1dd06ee8e89eccd40f1f326',2,'QweSaLt2');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;

-- 
-- Definition of order
-- 

DROP TABLE IF EXISTS `order`;
CREATE TABLE IF NOT EXISTS `order` (
  `idOrder` int NOT NULL AUTO_INCREMENT,
  `userOrder` int NOT NULL,
  `dateOrder` datetime NOT NULL,
  PRIMARY KEY (`idOrder`),
  KEY `userOrder_idx` (`userOrder`),
  CONSTRAINT `userOrder` FOREIGN KEY (`userOrder`) REFERENCES `user` (`idUser`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table order
-- 

/*!40000 ALTER TABLE `order` DISABLE KEYS */;

/*!40000 ALTER TABLE `order` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2023-06-14 03:19:29
-- Total time: 0:0:0:0:781 (d:h:m:s:ms)
