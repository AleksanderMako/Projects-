-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: aubgv4
-- ------------------------------------------------------
-- Server version	5.7.19-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `isavailable`
--

DROP TABLE IF EXISTS `isavailable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `isavailable` (
  `class_number` int(11) NOT NULL,
  `location_name` varchar(255) NOT NULL,
  `timeslot_id` int(11) NOT NULL,
  PRIMARY KEY (`class_number`,`location_name`,`timeslot_id`),
  KEY `timeslot_id` (`timeslot_id`),
  CONSTRAINT `isavailable_ibfk_1` FOREIGN KEY (`class_number`, `location_name`) REFERENCES `classroom` (`class_number`, `location_name`),
  CONSTRAINT `isavailable_ibfk_2` FOREIGN KEY (`timeslot_id`) REFERENCES `timeslots` (`timeslot_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `isavailable`
--

LOCK TABLES `isavailable` WRITE;
/*!40000 ALTER TABLE `isavailable` DISABLE KEYS */;
INSERT INTO `isavailable` VALUES (302,'Balkanski',1),(111,'Main Bulding',2),(113,'Main Bulding',3),(120,'Main Bulding',4),(115,'Main Bulding',5),(117,'Main Bulding',6),(206,'Balkanski',7),(206,'Balkanski',8),(208,'Balkanski',8),(209,'Balkanski',9),(301,'Balkanski',10);
/*!40000 ALTER TABLE `isavailable` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-03-01 19:40:53
