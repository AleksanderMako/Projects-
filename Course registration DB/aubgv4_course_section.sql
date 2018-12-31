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
-- Table structure for table `course_section`
--

DROP TABLE IF EXISTS `course_section`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `course_section` (
  `section_id` varchar(255) NOT NULL,
  `section_name` varchar(255) NOT NULL,
  `course_id` varchar(255) NOT NULL,
  `class_number` int(11) DEFAULT NULL,
  `instructor_id` int(11) NOT NULL,
  PRIMARY KEY (`course_id`,`section_id`),
  KEY `instructor_id` (`instructor_id`),
  KEY `class_number` (`class_number`),
  CONSTRAINT `course_section_ibfk_1` FOREIGN KEY (`course_id`) REFERENCES `course` (`course_id`),
  CONSTRAINT `course_section_ibfk_2` FOREIGN KEY (`instructor_id`) REFERENCES `instructor` (`instructor_id`),
  CONSTRAINT `course_section_ibfk_3` FOREIGN KEY (`class_number`) REFERENCES `classroom` (`class_number`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `course_section`
--

LOCK TABLES `course_section` WRITE;
/*!40000 ALTER TABLE `course_section` DISABLE KEYS */;
INSERT INTO `course_section` VALUES ('bus 100a','Managment Information Systemsb','BUS 100',302,102),('bus 200a','Financial Accountinga','BUS 200',113,103),('bus 200b','Financial Accountingb','BUS 200',111,103),('bus 220c','Financial Accounting section c','BUS 220',104,109),('cos 120b','software development with c++','COS 120',204,100),('cos 150a','Discrete data','COS 150',120,116),(' cos 220b','concepts of programing languages section b','COS 220',201,107),('cos 300c','software engineering section a','COS 300',115,110),('cos 460a','Algorithms section a','COS 460',204,110),('eco 101a','Micro Economics section a','ECO 101',117,108),('eco 300','quant','ECO 300',301,108),('eng 100','Exposition section a ','ENG 100',204,108),('eng 300','eng 300 section a','ENG 300',206,107),('inf 150','personal productivity with IT','INF 150',206,107),('inf 280 a ','DBMS','INF 280',208,110),('inf 480','Big data Analytics','INF 480',304,110),('pos 101a','introduction to politics','POS 101',104,102),('pos 102a ','Global Politics section a ','POS 102',209,114);
/*!40000 ALTER TABLE `course_section` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-03-01 19:40:52
