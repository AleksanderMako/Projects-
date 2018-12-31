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
-- Table structure for table `enrolls`
--

DROP TABLE IF EXISTS `enrolls`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enrolls` (
  `student_id` int(11) NOT NULL,
  `course_id` varchar(255) NOT NULL,
  `section_id` varchar(255) NOT NULL,
  `instructor_id` int(11) NOT NULL,
  PRIMARY KEY (`student_id`,`course_id`,`section_id`,`instructor_id`),
  KEY `course_id` (`course_id`,`section_id`),
  KEY `instructor_id` (`instructor_id`),
  CONSTRAINT `enrolls_ibfk_1` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`),
  CONSTRAINT `enrolls_ibfk_2` FOREIGN KEY (`course_id`, `section_id`) REFERENCES `course_section` (`course_id`, `section_id`),
  CONSTRAINT `enrolls_ibfk_3` FOREIGN KEY (`instructor_id`) REFERENCES `instructor` (`instructor_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enrolls`
--

LOCK TABLES `enrolls` WRITE;
/*!40000 ALTER TABLE `enrolls` DISABLE KEYS */;
INSERT INTO `enrolls` VALUES (1000,'COS 120','cos 120b',100),(1000,'COS 220',' cos 220b',100),(1001,'COS 120','cos 120b',100),(1003,'COS 120','cos 120b',100),(1005,'COS 120','cos 120b',100),(1000,'POS 101','pos 101a',102),(1002,'POS 101','pos 101a',102),(1004,'BUS 200','bus 200a',103),(1006,'BUS 200','bus 200a',103),(1007,'BUS 200','bus 200a',103),(1008,'BUS 200','bus 200a',103),(1009,'BUS 200','bus 200a',103),(1000,'COS 460','cos 460a',106),(1004,'ECO 300','eco 300',108),(1000,'BUS 220','bus 220c',109),(1001,'INF 480','inf 480',110),(1010,'INF 280','inf 280 a',110);
/*!40000 ALTER TABLE `enrolls` ENABLE KEYS */;
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
