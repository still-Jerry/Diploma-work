-- MySqlBackup.NET 2.3.6
-- Dump Time: 2023-06-13 22:48:31
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
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table category
-- 

/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category`(`idСategory`,`nameСategory`) VALUES(2,'Антибактериальные'),(1,'Гормоны'),(3,'Противовирусные'),(4,'Противоопухолевые'),(6,'Противопаразитарные');
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
INSERT INTO `product`(`idProduct`,`nameProduct`,`categoryProduct`,`priceProduct`,`storageRackProduct`,`descriptionProduct`,`manufacturerProduct`,`pictureProduct`,`isPrescriptionProduct`,`discountProduct`) VALUES(1,'Ингавирин',3,900.00,1,'Капсулы, Действующее вещество: Имидазолилэтанамид пентандиовой кислоты','Валента, Россия','638217721723636878Ингавирин.jpg',0,0.15),(2,'Гриппферон',3,290.00,1,'Капли назальные, Действующее вещество: Интерферон альфа-2b',' Фирн М, Россия','Гриппферон.jpeg',0,0.15),(3,'Прогестерон Форте 2 капсулы подряд на 4 ребра в день',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия','',1,0.35),(4,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия',NULL,1,0.35),(6,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия',NULL,1,0.35),(8,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия','Прогестерон.jpg',1,0.35),(9,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия','Прогестерон.jpg',1,0.35),(10,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия','Прогестерон.jpg',1,0.35),(11,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия',NULL,1,0.35),(12,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия','Прогестерон.jpg',1,0.35),(13,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия',NULL,1,0.35),(14,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия',NULL,1,0.35),(15,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия','Прогестерон.jpg',1,0.35),(16,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия',NULL,1,0.35),(17,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия',NULL,1,0.35),(18,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия','Прогестерон.jpg',1,0.35),(19,'Прогестерон',1,972.00,4,'Действующее вещество: прогестерон - 10,0 мг или 25,0 мг;','Россия',NULL,1,0.35),(20,'Анастрозол',4,992.00,5,'1 таблетка, покрытая пленочной оболочкой, содержит:\r\nактивное вещество: анастрозол 1,051* мг','Россия Фармасинтез-Норд АО ','638208987283151274Анастрозол.jpg',0,0.00),(21,'Лайфферон',4,845.00,5,'Препарат представляет собой бесцветный прозрачный или слабо опалесцирующий раствор.','Вектор-Медика АО - Россия','638209194787720230Лайфферон.jpg',1,0.00),(23,'ВИФЕРОН',4,330.00,5,'1 суппозиторий ВИФЕРОН® 150 000 МЕ содержит:\r\nактивное вещество: интерферон альфа-2b человеческий рекомбинантный 150 000 МЕ,','ФЕРОН ОО - Россия','638209192826785364ВИФЕРОН.jpg',0,0.01),(26,'Зитига',4,16900.75,5,'Действующее вещество: Абиратерон\r\nФорма выпуска: таб. вн. фл.','Патеон Инк. - Аптека','638209616840640330Зигита.jpg',1,0.00),(29,'Ярина',1,1280.00,5,'Действующее вещество: Дроспиренон, Этинилэстрадиол',' Байер Веймар ГмбХ и Ко. КГ - Германия','638209869566281702Ярина.jpg',1,0.35),(30,'Ярина',5,1280.00,5,'Действующее вещество: Дроспиренон, Этинилэстрадиол',' Байер Веймар ГмбХ и Ко. КГ - Германия','638209869566281702Ярина.jpg',1,0.35);
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
INSERT INTO `seriesproduct`(`idSeries`,`productIdSeries`,`expirationDateSeries`,`countProductSeries`) VALUES(1,3,'2023-05-31 00:00:00',5),(2,2,'2023-06-24 00:00:00',86),(3,23,'2023-12-30 00:00:00',279),(4,21,'2023-05-29 00:00:00',30),(5,1,'2023-05-29 00:00:00',40),(6,3,'2025-05-23 00:00:00',110),(7,4,'2023-06-04 00:00:00',6),(8,6,'2023-06-03 00:00:00',4),(9,6,'2023-07-30 00:00:00',15),(10,8,'2026-08-15 00:00:00',140),(11,10,'2023-12-30 00:00:00',10),(12,11,'2023-05-29 00:00:00',50),(13,12,'2023-09-10 00:00:00',90),(14,20,'2045-11-17 00:00:00',7996),(16,2,'2023-05-29 00:00:00',89),(20,29,'2025-07-18 00:00:00',39),(21,1,'2023-05-28 00:00:00',23),(23,2,'2023-06-02 00:00:00',0),(24,1,'2023-05-31 00:00:00',230),(27,21,'2023-07-09 00:00:00',100);
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
) ENGINE=InnoDB AUTO_INCREMENT=74 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table list
-- 

/*!40000 ALTER TABLE `list` DISABLE KEYS */;
INSERT INTO `list`(`id`,`idOrderList`,`quantityList`,`seriesProductList`,`prescriptionNumberList`) VALUES(72,61,10,3,0),(73,62,1,20,230);
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
INSERT INTO `user`(`idUser`,`surnameUser`,`nameUser`,`patronymicUser`,`loginUser`,`passwordUser`,`roleUser`,`saltUser`) VALUES(1,'Заведователь','Екатерина','Андреевна','some_login@mail.com','2c63bcd330168348ff8b8688e3a1a61b632c39a517c6ba7856df819ccf6cbba2',1,'QweSaLt'),(2,'Фрамацефтович','Владислав','Дмитриевич','qwe123@mail.com','7d19d34e950fe247c866f7a24c2ea5566ed818a6b1dd06ee8e89eccd40f1f326',2,'QweSaLt2'),(4,'Мартемьянов','Алексей','','123@123','1E4644D327779C4719F22352A25DC7CAD1440FAC1165140DD31197F89F41195E',2,'9vQk5?>'),(7,'Гришечкина','Альбина','','123№','6EA8409FB84115BBAE5B64C918BA500B196BCCC1A8C5BE14B74C1119C9C99A98',1,'SpzF');
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
) ENGINE=InnoDB AUTO_INCREMENT=63 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table order
-- 

/*!40000 ALTER TABLE `order` DISABLE KEYS */;
INSERT INTO `order`(`idOrder`,`userOrder`,`dateOrder`) VALUES(61,2,'2023-06-13 00:00:00'),(62,4,'2023-06-13 00:00:00');
/*!40000 ALTER TABLE `order` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2023-06-13 22:48:31
-- Total time: 0:0:0:0:283 (d:h:m:s:ms)
