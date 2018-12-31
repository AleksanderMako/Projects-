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
-- Temporary view structure for view `politicalscience_performance`
--

DROP TABLE IF EXISTS `politicalscience_performance`;
/*!50001 DROP VIEW IF EXISTS `politicalscience_performance`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `politicalscience_performance` AS SELECT 
 1 AS `major_name`,
 1 AS `enrollment_credits`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `economicsperformance`
--

DROP TABLE IF EXISTS `economicsperformance`;
/*!50001 DROP VIEW IF EXISTS `economicsperformance`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `economicsperformance` AS SELECT 
 1 AS `major_name`,
 1 AS `enrollment_credits`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `inf_performance`
--

DROP TABLE IF EXISTS `inf_performance`;
/*!50001 DROP VIEW IF EXISTS `inf_performance`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `inf_performance` AS SELECT 
 1 AS `major_name`,
 1 AS `enrollment_credits`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `computerscience_performance`
--

DROP TABLE IF EXISTS `computerscience_performance`;
/*!50001 DROP VIEW IF EXISTS `computerscience_performance`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `computerscience_performance` AS SELECT 
 1 AS `major_name`,
 1 AS `enrollment_credits`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `bussinessperformance`
--

DROP TABLE IF EXISTS `bussinessperformance`;
/*!50001 DROP VIEW IF EXISTS `bussinessperformance`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `bussinessperformance` AS SELECT 
 1 AS `major_name`,
 1 AS `enrollment_credits`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `politicalscience_performance`
--

/*!50001 DROP VIEW IF EXISTS `politicalscience_performance`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `politicalscience_performance` AS select `major`.`major_name` AS `major_name`,sum(`course`.`numberOfcredits`) AS `enrollment_credits` from (((((`students` join `enrolls` on((`students`.`student_id` = `enrolls`.`student_id`))) join `course_section` on(((`enrolls`.`course_id` = `course_section`.`course_id`) and (`enrolls`.`section_id` = `course_section`.`section_id`)))) join `course` on((`course_section`.`course_id` = `course`.`course_id`))) join `countsfor` on((`countsfor`.`course_id` = `course`.`course_id`))) join `major` on((`countsfor`.`major_name` = `major`.`major_name`))) where (`major`.`major_name` = 'Political Science') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `economicsperformance`
--

/*!50001 DROP VIEW IF EXISTS `economicsperformance`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `economicsperformance` AS select `major`.`major_name` AS `major_name`,sum(`course`.`numberOfcredits`) AS `enrollment_credits` from (((((`students` join `enrolls` on((`students`.`student_id` = `enrolls`.`student_id`))) join `course_section` on(((`enrolls`.`course_id` = `course_section`.`course_id`) and (`enrolls`.`section_id` = `course_section`.`section_id`)))) join `course` on((`course_section`.`course_id` = `course`.`course_id`))) join `countsfor` on((`countsfor`.`course_id` = `course`.`course_id`))) join `major` on((`countsfor`.`major_name` = `major`.`major_name`))) where (`major`.`major_name` = 'Economics') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `inf_performance`
--

/*!50001 DROP VIEW IF EXISTS `inf_performance`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `inf_performance` AS select `major`.`major_name` AS `major_name`,sum(`course`.`numberOfcredits`) AS `enrollment_credits` from (((((`students` join `enrolls` on((`students`.`student_id` = `enrolls`.`student_id`))) join `course_section` on(((`enrolls`.`course_id` = `course_section`.`course_id`) and (`enrolls`.`section_id` = `course_section`.`section_id`)))) join `course` on((`course_section`.`course_id` = `course`.`course_id`))) join `countsfor` on((`countsfor`.`course_id` = `course`.`course_id`))) join `major` on((`countsfor`.`major_name` = `major`.`major_name`))) where (`major`.`major_name` = 'Information systems') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `computerscience_performance`
--

/*!50001 DROP VIEW IF EXISTS `computerscience_performance`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `computerscience_performance` AS select `major`.`major_name` AS `major_name`,sum(`course`.`numberOfcredits`) AS `enrollment_credits` from (((((`students` join `enrolls` on((`students`.`student_id` = `enrolls`.`student_id`))) join `course_section` on(((`enrolls`.`course_id` = `course_section`.`course_id`) and (`enrolls`.`section_id` = `course_section`.`section_id`)))) join `course` on((`course_section`.`course_id` = `course`.`course_id`))) join `countsfor` on((`countsfor`.`course_id` = `course`.`course_id`))) join `major` on((`countsfor`.`major_name` = `major`.`major_name`))) where (`major`.`major_name` = 'Computer Science') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `bussinessperformance`
--

/*!50001 DROP VIEW IF EXISTS `bussinessperformance`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `bussinessperformance` AS select `major`.`major_name` AS `major_name`,sum(`course`.`numberOfcredits`) AS `enrollment_credits` from (((((`students` join `enrolls` on((`students`.`student_id` = `enrolls`.`student_id`))) join `course_section` on(((`enrolls`.`course_id` = `course_section`.`course_id`) and (`enrolls`.`section_id` = `course_section`.`section_id`)))) join `course` on((`course_section`.`course_id` = `course`.`course_id`))) join `countsfor` on((`countsfor`.`course_id` = `course`.`course_id`))) join `major` on((`countsfor`.`major_name` = `major`.`major_name`))) where (`major`.`major_name` = 'Bussines') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-03-01 19:40:54
