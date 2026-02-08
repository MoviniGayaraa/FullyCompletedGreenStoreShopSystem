CREATE DATABASE  IF NOT EXISTS `shopgreen` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `shopgreen`;
-- MySQL dump 10.13  Distrib 8.0.43, for Win64 (x86_64)
--
-- Host: localhost    Database: shopgreen
-- ------------------------------------------------------
-- Server version	8.0.43

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
-- Table structure for table `cart`
--

DROP TABLE IF EXISTS `cart`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cart` (
  `cart_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `product_id` int NOT NULL,
  `quantity` int NOT NULL,
  PRIMARY KEY (`cart_id`),
  KEY `user_id` (`user_id`),
  KEY `product_id` (`product_id`),
  CONSTRAINT `cart_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`),
  CONSTRAINT `cart_ibfk_2` FOREIGN KEY (`product_id`) REFERENCES `products` (`product_id`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cart`
--

LOCK TABLES `cart` WRITE;
/*!40000 ALTER TABLE `cart` DISABLE KEYS */;
INSERT INTO `cart` VALUES (1,2,1,2),(2,2,3,1),(3,2,6,1),(4,3,2,3),(5,3,5,2),(6,4,7,1),(7,4,8,1),(8,5,9,2),(9,6,4,1),(10,6,10,1),(37,15,5,2),(38,15,7,1),(39,15,10,1),(40,15,1,2),(41,15,13,1);
/*!40000 ALTER TABLE `cart` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order_items`
--

DROP TABLE IF EXISTS `order_items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order_items` (
  `order_item_id` int NOT NULL AUTO_INCREMENT,
  `order_id` int NOT NULL,
  `product_id` int NOT NULL,
  `quantity` int NOT NULL,
  `price` decimal(10,2) NOT NULL,
  PRIMARY KEY (`order_item_id`),
  KEY `order_id` (`order_id`),
  KEY `product_id` (`product_id`),
  CONSTRAINT `order_items_ibfk_1` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`),
  CONSTRAINT `order_items_ibfk_2` FOREIGN KEY (`product_id`) REFERENCES `products` (`product_id`)
) ENGINE=InnoDB AUTO_INCREMENT=76 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_items`
--

LOCK TABLES `order_items` WRITE;
/*!40000 ALTER TABLE `order_items` DISABLE KEYS */;
INSERT INTO `order_items` VALUES (1,1,1,2,320.00),(2,1,3,1,420.00),(3,2,2,3,180.00),(4,2,5,2,350.00),(5,3,7,1,450.00),(6,3,8,1,1250.00),(7,3,10,1,780.00),(8,4,6,1,650.00),(9,5,9,2,950.00),(10,6,4,2,280.00),(11,6,1,1,320.00),(12,7,8,1,1250.00),(13,8,2,2,180.00),(14,8,3,1,420.00),(15,9,4,1,280.00),(16,9,10,1,780.00),(17,9,5,1,350.00),(18,10,6,1,650.00),(19,10,7,1,450.00),(20,11,4,2,280.00),(21,12,9,2,950.00),(22,13,9,4,855.00),(23,14,2,2,180.00),(24,14,7,5,450.00),(25,15,11,1,180.00),(26,16,5,1,350.00),(27,17,10,1,780.00),(28,18,5,1,350.00),(29,18,10,5,780.00),(30,19,10,1,780.00),(31,19,3,1,420.00),(32,20,3,1,378.00),(33,21,2,1,180.00),(34,22,1,1,320.00),(35,23,11,1,180.00),(36,24,12,1,450.00),(37,24,3,1,420.00),(38,25,3,1,378.00),(39,26,9,1,855.00),(40,27,6,1,585.00),(41,28,9,1,950.00),(42,28,10,8,780.00),(43,29,3,4,420.00),(44,30,3,1,420.00),(45,31,4,1,280.00),(46,32,14,1,360.00),(47,33,5,1,315.00),(48,34,10,2,780.00),(49,35,1,1,320.00),(50,36,1,1,320.00),(51,37,4,1,280.00),(52,38,2,1,180.00),(53,39,10,1,780.00),(54,40,9,1,855.00),(55,41,10,1,780.00),(56,42,13,1,180.00),(57,43,13,1,180.00),(58,44,11,1,180.00),(59,45,4,1,280.00),(60,46,9,1,855.00),(61,47,10,1,780.00),(62,47,6,1,650.00),(63,47,4,1,280.00),(64,47,11,1,200.00),(65,47,13,4,200.00),(66,47,9,2,950.00),(67,47,14,1,400.00),(68,47,1,3,320.00),(69,48,7,1,450.00),(70,49,10,1,780.00),(71,50,14,1,360.00),(72,51,3,1,378.00),(73,52,11,1,180.00),(74,53,10,1,780.00),(75,54,4,1,280.00);
/*!40000 ALTER TABLE `order_items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `order_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `order_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `total_amount` decimal(10,2) NOT NULL,
  `status` enum('PENDING','SHIPPED','DELIVERED') DEFAULT 'PENDING',
  PRIMARY KEY (`order_id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=55 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,2,'2026-02-01 02:30:09',980.00,'DELIVERED'),(2,3,'2026-02-01 02:30:09',1240.00,'DELIVERED'),(3,4,'2026-02-01 02:30:09',1950.00,'DELIVERED'),(4,2,'2026-02-01 02:30:09',650.00,'PENDING'),(5,5,'2026-02-01 02:30:09',1730.00,'PENDING'),(6,3,'2026-02-01 02:30:09',850.00,'SHIPPED'),(7,4,'2026-02-01 02:30:09',1250.00,'SHIPPED'),(8,5,'2026-02-01 02:30:09',560.00,'DELIVERED'),(9,6,'2026-02-01 02:30:09',1280.00,'PENDING'),(10,6,'2026-02-01 02:30:09',780.00,'SHIPPED'),(11,15,'2026-02-01 04:42:56',560.00,'SHIPPED'),(12,15,'2026-02-01 04:43:30',1900.00,'PENDING'),(13,15,'2026-02-01 04:50:10',3420.00,'PENDING'),(14,15,'2026-02-01 04:51:29',2610.00,'PENDING'),(15,15,'2026-02-01 09:25:09',180.00,'DELIVERED'),(16,15,'2026-02-01 09:25:33',350.00,'PENDING'),(17,15,'2026-02-01 09:28:38',780.00,'PENDING'),(18,15,'2026-02-01 09:29:23',4250.00,'PENDING'),(19,15,'2026-02-01 09:33:52',1200.00,'PENDING'),(20,15,'2026-02-01 14:18:50',378.00,'PENDING'),(21,15,'2026-02-01 14:19:16',180.00,'PENDING'),(22,15,'2026-02-01 14:34:40',320.00,'PENDING'),(23,15,'2026-02-01 18:24:16',180.00,'PENDING'),(24,15,'2026-02-02 06:07:56',870.00,'PENDING'),(25,15,'2026-02-02 06:11:53',378.00,'SHIPPED'),(26,15,'2026-02-04 09:58:40',855.00,'DELIVERED'),(27,15,'2026-02-04 09:59:46',585.00,'DELIVERED'),(28,15,'2026-02-04 10:01:13',7190.00,'DELIVERED'),(29,15,'2026-02-04 10:43:16',1680.00,'DELIVERED'),(30,15,'2026-02-04 14:28:46',420.00,'SHIPPED'),(31,15,'2026-02-06 08:36:02',280.00,'DELIVERED'),(32,15,'2026-02-06 12:13:55',360.00,'PENDING'),(33,15,'2026-02-06 12:14:15',315.00,'PENDING'),(34,15,'2026-02-06 12:14:30',1560.00,'PENDING'),(35,15,'2026-02-06 15:29:20',320.00,'PENDING'),(36,15,'2026-02-06 15:31:24',320.00,'PENDING'),(37,15,'2026-02-06 16:39:57',280.00,'PENDING'),(38,15,'2026-02-06 16:45:16',180.00,'PENDING'),(39,15,'2026-02-06 17:07:35',780.00,'PENDING'),(40,15,'2026-02-06 17:09:51',855.00,'PENDING'),(41,15,'2026-02-06 18:37:34',780.00,'PENDING'),(42,15,'2026-02-07 00:26:34',180.00,'PENDING'),(43,15,'2026-02-07 00:41:39',180.00,'PENDING'),(44,15,'2026-02-07 00:49:10',180.00,'PENDING'),(45,15,'2026-02-07 16:46:50',280.00,'PENDING'),(46,15,'2026-02-07 16:50:49',855.00,'PENDING'),(47,15,'2026-02-07 16:52:40',5970.00,'PENDING'),(48,15,'2026-02-07 16:56:11',450.00,'PENDING'),(49,15,'2026-02-07 18:00:06',780.00,'PENDING'),(50,15,'2026-02-07 18:10:39',360.00,'PENDING'),(51,15,'2026-02-08 03:35:31',378.00,'PENDING'),(52,15,'2026-02-08 05:32:13',180.00,'PENDING'),(53,15,'2026-02-08 05:35:41',780.00,'PENDING'),(54,15,'2026-02-08 05:37:09',280.00,'PENDING');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `product_id` int NOT NULL AUTO_INCREMENT,
  `product_name` varchar(100) NOT NULL,
  `category` enum('ORGANIC_GROCERY','ECO_PRODUCT') NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `stock` int NOT NULL,
  `status` enum('AVAILABLE','OUT_OF_STOCK') NOT NULL,
  `supplier` varchar(100) DEFAULT NULL,
  `discount` tinyint(1) DEFAULT '0',
  `image_path` varchar(255) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`product_id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'Organic Carrots (1kg)','ORGANIC_GROCERY',320.00,42,'AVAILABLE','Green Fields Organics',0,'C:\\Users\\User\\Pictures\\1kg-organic-carrot.png','2026-02-01 02:30:09'),(2,'Fresh Spinach (500g)','ORGANIC_GROCERY',180.00,36,'AVAILABLE','Nature Fresh Farms',0,'C:\\Users\\User\\Pictures\\images.jpg','2026-02-01 02:30:09'),(3,'Organic Potatoes (2kg)','ORGANIC_GROCERY',420.00,50,'AVAILABLE','Earth Harvest',1,'C:\\Users\\User\\Pictures\\images (1).jpg','2026-02-01 02:30:09'),(4,'Broccoli Florets (400g)','ORGANIC_GROCERY',280.00,23,'AVAILABLE','Veggie Delight',0,'C:\\Users\\User\\Pictures\\images (2).jpg','2026-02-01 02:30:09'),(5,'Organic Tomatoes (1kg)','ORGANIC_GROCERY',350.00,7,'AVAILABLE','Sunshine Farms',1,'C:\\Users\\User\\Pictures\\tomato Organic.jpg','2026-02-01 02:30:09'),(6,'Bamboo Toothbrush (4-pack)','ECO_PRODUCT',650.00,98,'AVAILABLE','Eco Essentials',1,'C:\\Users\\User\\Pictures\\ToothBrush.jpg','2026-02-01 02:30:09'),(7,'Reusable Shopping Bag','ECO_PRODUCT',450.00,6,'AVAILABLE','Green Living Co.',0,'C:\\Users\\User\\Pictures\\grocery-bag-png-png-download.png','2026-02-01 02:30:09'),(8,'Stainless Steel Water Bottle','ECO_PRODUCT',1250.00,60,'OUT_OF_STOCK','Sustainable Solutions',0,'C:\\Users\\User\\Pictures\\Bootle.png','2026-02-01 02:30:09'),(9,'Beeswax Food Wraps (3-pack)','ECO_PRODUCT',950.00,0,'AVAILABLE','Nature Wrap',1,'C:\\Users\\User\\Pictures\\FoodWraper.jpg','2026-02-01 02:30:09'),(10,'Bamboo Cutlery Set','ECO_PRODUCT',780.00,36,'AVAILABLE','Eco Kitchen',0,'C:\\Users\\User\\Pictures\\bamboo-cutlery-set.jpg','2026-02-01 02:30:09'),(11,'Bamboo Plate','ECO_PRODUCT',200.00,0,'AVAILABLE','Green Living Farm',1,'C:\\Users\\User\\Pictures\\BambooPlate.jpg','2026-02-01 05:10:57'),(12,'StringHoperMaker','ECO_PRODUCT',450.00,6,'AVAILABLE','Eco Essentials',1,'C:\\Users\\User\\Pictures\\StringHoperMaker.jpg','2026-02-01 10:25:06'),(13,'bananas-in-basket','ORGANIC_GROCERY',200.00,33,'AVAILABLE','Eco Farm',1,'C:\\Users\\User\\Pictures\\bananas-in-basket.jpg','2026-02-01 10:27:38'),(14,'StringHoperTray','ECO_PRODUCT',400.00,97,'AVAILABLE','Eco Farm',1,'C:\\Users\\User\\Pictures\\StringHoperTray.jpg','2026-02-01 10:29:17');
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reviews`
--

DROP TABLE IF EXISTS `reviews`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reviews` (
  `review_id` int NOT NULL AUTO_INCREMENT,
  `product_id` int NOT NULL,
  `user_id` int NOT NULL,
  `rating` int DEFAULT NULL,
  `review_text` varchar(255) DEFAULT NULL,
  `review_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`review_id`),
  KEY `product_id` (`product_id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `reviews_ibfk_1` FOREIGN KEY (`product_id`) REFERENCES `products` (`product_id`),
  CONSTRAINT `reviews_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`),
  CONSTRAINT `reviews_chk_1` CHECK ((`rating` between 1 and 5))
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reviews`
--

LOCK TABLES `reviews` WRITE;
/*!40000 ALTER TABLE `reviews` DISABLE KEYS */;
INSERT INTO `reviews` VALUES (1,1,2,5,'Fresh and delicious carrots! Will buy again.','2026-02-01 02:30:09'),(2,1,3,4,'Good quality, but a bit pricey.','2026-02-01 02:30:09'),(3,2,4,5,'Perfect spinach for salads and smoothies.','2026-02-01 02:30:09'),(4,3,5,5,'Best organic potatoes I have ever bought!','2026-02-01 02:30:09'),(5,4,2,3,'Broccoli was good but some pieces were small.','2026-02-01 02:30:09'),(6,5,3,4,'Juicy tomatoes, great for salads.','2026-02-01 02:30:09'),(7,6,4,5,'Love these bamboo toothbrushes! Eco-friendly and effective.','2026-02-01 02:30:09'),(8,7,5,5,'Strong and durable shopping bag. Highly recommend.','2026-02-01 02:30:09'),(9,8,2,4,'Good water bottle, keeps water cold for hours.','2026-02-01 02:30:09'),(10,9,3,5,'Beeswax wraps are amazing! Perfect for food storage.','2026-02-01 02:30:09'),(11,1,15,5,'Good Product','2026-02-06 15:27:11'),(12,12,15,3,'good product','2026-02-06 15:30:03'),(13,4,15,5,'good product','2026-02-06 15:32:38'),(14,11,15,5,'good product','2026-02-06 16:38:25'),(15,10,15,5,'good','2026-02-06 17:08:51'),(16,14,15,5,'','2026-02-06 17:55:42'),(17,13,15,5,'good','2026-02-06 18:29:48'),(18,3,15,5,'best','2026-02-06 18:35:27'),(19,9,15,5,'best product','2026-02-07 16:51:20');
/*!40000 ALTER TABLE `reviews` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `contact` varchar(15) DEFAULT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` enum('ADMIN','CUSTOMER') NOT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `email` (`email`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'System Admin','admin@shop.com','0770000000','admin','admin123','ADMIN','2026-01-30 05:05:24'),(2,'Mogana','mogana@gmail.com','0912234562','mogana','mogana1234','CUSTOMER','2026-02-01 01:27:51'),(3,'Amalsa','amal@gmail.com','0912234568','amal','ZU7T90Q5','CUSTOMER','2026-02-01 01:29:36'),(4,'John Smith','john.smith@email.com','0772222222','johnsmith','password123','CUSTOMER','2026-02-01 02:30:08'),(5,'Sarah Johnson','sarah.j@email.com','0773333333','sarahj','password123','CUSTOMER','2026-02-01 02:30:08'),(6,'Michael Brown','michael.b@email.com','0774444442','michaelb','password123','CUSTOMER','2026-02-01 02:30:08'),(7,'Emily Davis','emily.d@email.com','0775555556','emilyd','password123','CUSTOMER','2026-02-01 02:30:08'),(8,'David Wilson','david.w@email.com','0776666666','davidw','password123','CUSTOMER','2026-02-01 02:30:08'),(9,'Manager Admin','manager@shop.com','0771111112','manager','admin123','ADMIN','2026-02-01 02:30:08'),(10,'Supervisor Admin','supervisor@shop.com','0771111113','supervisor','admin123','ADMIN','2026-02-01 02:30:08'),(11,'Store Admin','store@shop.com','0771111114','storeadmin','admin123','ADMIN','2026-02-01 02:30:08'),(12,'Inventory Admin','inventory@shop.com','0771111115','inventory','admin123','ADMIN','2026-02-01 02:30:08'),(13,'Support Admin','support@shop.com','0771111116','support','admin123','ADMIN','2026-02-01 02:30:08'),(15,'Sara','sara@gmail.com','0772234348','sara','sara1234','CUSTOMER','2026-02-01 03:01:31'),(16,'Shasa','shasa@gmail.com','0912234562','shasa','shasa123','CUSTOMER','2026-02-01 03:09:14'),(17,'Nama','nama@gmail.com','0912223452','nama','XPXX5UU7','CUSTOMER','2026-02-01 03:21:07'),(19,'Ganaha','gana@gmail.com','0912234564','gana','gana123','CUSTOMER','2026-02-01 03:37:21'),(20,'kamal','kaml@gmail.com','0912234672','kamai','kaml123','ADMIN','2026-02-01 14:26:37'),(22,'samaraka','samara@gmail.com','0912234562','samara','KCXQXTEG','CUSTOMER','2026-02-08 05:57:42');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-02-08 13:51:31
