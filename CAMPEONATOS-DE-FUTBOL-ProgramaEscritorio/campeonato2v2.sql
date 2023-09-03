-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: movedb
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
-- Table structure for table `amarillas`
--

DROP TABLE IF EXISTS `amarillas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `amarillas` (
  `id_amarilla` int NOT NULL AUTO_INCREMENT,
  `id_jugador` int DEFAULT '0',
  `id_fecha` int DEFAULT '0',
  PRIMARY KEY (`id_amarilla`),
  KEY `id_fecha` (`id_fecha`),
  KEY `id_jugador` (`id_jugador`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `amarillas`
--

LOCK TABLES `amarillas` WRITE;
/*!40000 ALTER TABLE `amarillas` DISABLE KEYS */;
/*!40000 ALTER TABLE `amarillas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipos`
--

DROP TABLE IF EXISTS `equipos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `equipos` (
  `id_equipo` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `ruta_escudo` varchar(100) DEFAULT 'p',
  PRIMARY KEY (`id_equipo`)
) ENGINE=MyISAM AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipos`
--

LOCK TABLES `equipos` WRITE;
/*!40000 ALTER TABLE `equipos` DISABLE KEYS */;
INSERT INTO `equipos` VALUES (25,'BARCA','d:equipos12.png'),(24,'REAL MADRID','d:equipos17.png'),(26,'CAPITANES','D:\\equipos\\12.png'),(21,'BETIS','@d:equipos16.png'),(20,'BARCELONA','d:equipos14.png'),(19,'BARCELONA','d:equipos14.png'),(18,'REAL MADRID','d:equipos17.png'),(27,'REAL MADRID','D:\\equipos\\17.png');
/*!40000 ALTER TABLE `equipos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estados_partidos`
--

DROP TABLE IF EXISTS `estados_partidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estados_partidos` (
  `id_estado_partido` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`id_estado_partido`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estados_partidos`
--

LOCK TABLES `estados_partidos` WRITE;
/*!40000 ALTER TABLE `estados_partidos` DISABLE KEYS */;
INSERT INTO `estados_partidos` VALUES (1,'activo'),(2,'finalizado'),(3,'suspendido definitivo'),(4,'suspendido por terminar'),(5,'por jugarse');
/*!40000 ALTER TABLE `estados_partidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fechas`
--

DROP TABLE IF EXISTS `fechas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fechas` (
  `id_fecha` int NOT NULL AUTO_INCREMENT,
  `nro_fecha` varchar(30) DEFAULT NULL,
  `dia` datetime DEFAULT NULL,
  PRIMARY KEY (`id_fecha`)
) ENGINE=MyISAM AUTO_INCREMENT=112 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fechas`
--

LOCK TABLES `fechas` WRITE;
/*!40000 ALTER TABLE `fechas` DISABLE KEYS */;
INSERT INTO `fechas` VALUES (105,'FECHA N° 1','2023-08-19 00:00:00'),(106,'FECHA N° 2','2023-08-26 00:00:00'),(107,'FECHA N° 3','2023-09-02 00:00:00'),(108,'FECHA N° 4','2023-09-09 00:00:00'),(109,'FECHA N° 5','2023-09-16 00:00:00'),(110,'FECHA N° 6','2023-09-23 00:00:00'),(111,'FECHA N° 7','2023-09-30 00:00:00');
/*!40000 ALTER TABLE `fechas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `goles`
--

DROP TABLE IF EXISTS `goles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `goles` (
  `id_gol` int NOT NULL AUTO_INCREMENT,
  `id_jugador` int DEFAULT '0',
  `id_fecha` int DEFAULT '0',
  `cantidad` int DEFAULT '0',
  PRIMARY KEY (`id_gol`),
  KEY `id_fecha` (`id_fecha`),
  KEY `id_jugador` (`id_jugador`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `goles`
--

LOCK TABLES `goles` WRITE;
/*!40000 ALTER TABLE `goles` DISABLE KEYS */;
/*!40000 ALTER TABLE `goles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jugadores`
--

DROP TABLE IF EXISTS `jugadores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `jugadores` (
  `id_jugador` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `apellido` varchar(30) DEFAULT NULL,
  `fecha_nac` datetime DEFAULT NULL,
  `dni` int DEFAULT NULL,
  `edad` int DEFAULT '0',
  `id_equipo` int DEFAULT NULL,
  PRIMARY KEY (`id_jugador`),
  KEY `id_equipo` (`id_equipo`)
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jugadores`
--

LOCK TABLES `jugadores` WRITE;
/*!40000 ALTER TABLE `jugadores` DISABLE KEYS */;
INSERT INTO `jugadores` VALUES (12,'JULIO','GRANDIOSO','1970-08-13 00:00:00',21345876,52,5),(1,'TENIENTE','TENIENTE','1977-09-15 00:00:00',26151411,45,3),(2,'DANIEL','PEDROCCA','1992-01-28 00:00:00',33453678,31,3),(3,'PABLO','FOGLIARESI','1973-10-22 00:00:00',20970921,49,3),(4,'ENZO','PONCE','1988-07-31 00:00:00',38567230,35,1),(5,'MAXIMILIANO','STOCCO','1982-01-08 00:00:00',28456780,41,4),(6,'FABRICIO','TENIENTE','1996-12-06 00:00:00',34556789,26,4),(7,'JULIO','FLORES','1972-06-13 00:00:00',21345786,51,4),(8,'NICOLAS','CAMPOS','1983-08-15 00:00:00',33456789,39,1),(9,'FABRICIO','TENIENTE','1996-12-06 00:00:00',41908756,26,5),(10,'GONZALO','LUDUEÑA','1987-06-23 00:00:00',35678456,36,5),(11,'JAVIER','PERALTA','1974-01-24 00:00:00',21345679,49,5),(13,'CLAUDIO','TENIENTE','1977-09-15 00:00:00',26151411,45,26);
/*!40000 ALTER TABLE `jugadores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `motivos`
--

DROP TABLE IF EXISTS `motivos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `motivos` (
  `id_motivo` int NOT NULL AUTO_INCREMENT,
  `razon` varchar(30) DEFAULT NULL,
  `fecha_susp` int DEFAULT '0',
  PRIMARY KEY (`id_motivo`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `motivos`
--

LOCK TABLES `motivos` WRITE;
/*!40000 ALTER TABLE `motivos` DISABLE KEYS */;
INSERT INTO `motivos` VALUES (1,'doble amarilla',1),(2,'expulsion directa',2);
/*!40000 ALTER TABLE `motivos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `partidos`
--

DROP TABLE IF EXISTS `partidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `partidos` (
  `id_partido` int NOT NULL AUTO_INCREMENT,
  `id_fecha` int DEFAULT '0',
  `id_equipo1` int DEFAULT '0',
  `id_equipo2` int DEFAULT '0',
  `nro_cancha` int DEFAULT '0',
  `id_estado` int DEFAULT '5',
  `goles_equipo1` int DEFAULT '0',
  `goles_equipo2` int DEFAULT '0',
  PRIMARY KEY (`id_partido`),
  KEY `id_equipo1` (`id_equipo1`),
  KEY `id_equipo2` (`id_equipo2`),
  KEY `id_estado` (`id_estado`),
  KEY `id_fecha` (`id_fecha`)
) ENGINE=MyISAM AUTO_INCREMENT=113 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partidos`
--

LOCK TABLES `partidos` WRITE;
/*!40000 ALTER TABLE `partidos` DISABLE KEYS */;
INSERT INTO `partidos` VALUES (85,105,1,4,1,5,0,0),(86,105,9,6,2,5,0,0),(87,105,3,7,3,5,0,0),(88,105,8,5,4,5,0,0),(89,106,4,6,1,5,0,0),(90,106,1,9,2,5,0,0),(91,106,7,5,3,5,0,0),(92,106,3,8,4,5,0,0),(93,107,8,7,1,5,0,0),(94,107,3,5,2,5,0,0),(95,107,1,6,3,5,0,0),(96,107,4,9,4,5,0,0),(97,108,6,5,1,5,0,0),(98,108,4,8,2,5,0,0),(99,108,9,7,3,5,0,0),(100,108,1,3,4,5,0,0),(101,109,4,3,1,5,0,0),(102,109,9,5,2,5,0,0),(103,109,1,7,3,5,0,0),(104,109,6,8,4,5,0,0),(105,110,9,3,1,5,0,0),(106,110,1,8,2,5,0,0),(107,110,4,5,3,5,0,0),(108,110,6,7,4,5,0,0),(109,111,1,5,1,5,0,0),(110,111,6,3,2,5,0,0),(111,111,4,7,3,5,0,0),(112,111,9,8,4,5,0,0);
/*!40000 ALTER TABLE `partidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `posiciones`
--

DROP TABLE IF EXISTS `posiciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `posiciones` (
  `id_posicion` int NOT NULL AUTO_INCREMENT,
  `id_equipo` int DEFAULT '0',
  `P_jug` int DEFAULT '0',
  `P_gan` int DEFAULT '0',
  `P_emp` int DEFAULT '0',
  `P_per` int DEFAULT '0',
  `G_fav` int DEFAULT '0',
  `G_con` int DEFAULT '0',
  `Dif_G` int DEFAULT '0',
  `Puntaje` int DEFAULT '0',
  PRIMARY KEY (`id_posicion`),
  KEY `id_equipo` (`id_equipo`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `posiciones`
--

LOCK TABLES `posiciones` WRITE;
/*!40000 ALTER TABLE `posiciones` DISABLE KEYS */;
INSERT INTO `posiciones` VALUES (2,1,0,0,0,0,0,0,0,0),(3,4,0,0,0,0,0,0,0,0),(4,9,0,0,0,0,0,0,0,0),(5,6,0,0,0,0,0,0,0,0),(6,3,0,0,0,0,0,0,0,0),(7,7,0,0,0,0,0,0,0,0),(8,8,0,0,0,0,0,0,0,0),(9,5,0,0,0,0,0,0,0,0);
/*!40000 ALTER TABLE `posiciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rojas`
--

DROP TABLE IF EXISTS `rojas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rojas` (
  `id_roja` int NOT NULL AUTO_INCREMENT,
  `id_jugador` int DEFAULT '0',
  `id_fecha` int DEFAULT '0',
  `id_motivo` int DEFAULT '0',
  PRIMARY KEY (`id_roja`),
  KEY `id_fecha` (`id_fecha`),
  KEY `id_jugador` (`id_jugador`),
  KEY `id_motivo` (`id_motivo`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rojas`
--

LOCK TABLES `rojas` WRITE;
/*!40000 ALTER TABLE `rojas` DISABLE KEYS */;
/*!40000 ALTER TABLE `rojas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-08-22 20:25:46
