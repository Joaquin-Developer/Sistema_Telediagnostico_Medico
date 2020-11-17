-- MySQL dump 10.14  Distrib 5.5.65-MariaDB, for Linux (x86_64)
--
-- Host: localhost    Database: prueba50
-- ------------------------------------------------------
-- Server version	5.5.65-MariaDB

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
-- Current Database: `prueba50`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `proyecto_tech_vibe` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `proyecto_tech_vibe`;

--
-- Table structure for table `Administrador`
--

DROP TABLE IF EXISTS `Administrador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Administrador` (
  `nombreAdmin` varchar(100) NOT NULL,
  `id` int(9) NOT NULL,
  PRIMARY KEY (`nombreAdmin`),
  CONSTRAINT `Administrador_ibfk_1` FOREIGN KEY (`nombreAdmin`) REFERENCES `Usuario` (`nombreUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Administrador`
--

LOCK TABLES `Administrador` WRITE;
/*!40000 ALTER TABLE `Administrador` DISABLE KEYS */;
INSERT INTO `Administrador` VALUES ('enzoanto11',314779364),('faqmart40',145424541),('maxilois2002',573456875),('parrilla10',283446479);
/*!40000 ALTER TABLE `Administrador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Auto_Diagnostico`
--

DROP TABLE IF EXISTS `Auto_Diagnostico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Auto_Diagnostico` (
  `idAutodiagnostico` int(10) NOT NULL AUTO_INCREMENT,
  `esUrgente` tinyint(1) NOT NULL,
  `Fecha` date NOT NULL,
  `nombrePatologia` varchar(100) NOT NULL,
  `nombrePaciente` varchar(100) NOT NULL,
  `nombresSintoma` varchar(100) NOT NULL,
  `Gravedad` int(4) DEFAULT NULL,
  PRIMARY KEY (`idAutodiagnostico`),
  KEY `nombrePatologia` (`nombrePatologia`),
  KEY `nombrePaciente` (`nombrePaciente`),
  KEY `nombresSintoma` (`nombresSintoma`),
  CONSTRAINT `Auto_Diagnostico_ibfk_1` FOREIGN KEY (`nombrePatologia`) REFERENCES `Patologia` (`nombrePatologia`),
  CONSTRAINT `Auto_Diagnostico_ibfk_2` FOREIGN KEY (`nombrePaciente`) REFERENCES `Usuario` (`nombreUsuario`),
  CONSTRAINT `Auto_Diagnostico_ibfk_3` FOREIGN KEY (`nombresSintoma`) REFERENCES `Sintoma` (`nombresSintoma`)
) ENGINE=InnoDB AUTO_INCREMENT=74 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Auto_Diagnostico`
--

LOCK TABLES `Auto_Diagnostico` WRITE;
/*!40000 ALTER TABLE `Auto_Diagnostico` DISABLE KEYS */;
INSERT INTO `Auto_Diagnostico` VALUES (1,1,'2020-10-20','Acidez de estomago','ferpais','Plenitud gastrica',NULL),(2,0,'2020-01-30','Acne','ferserranodiaz','Quistes',NULL),(3,1,'2019-10-10','Bartolinitis','manuelena','Fiebre',NULL),(4,1,'2020-02-06','Bronquitis','franjose','Tos',NULL),(5,0,'2020-01-30','Cancer de piel','franlopez','Marcas en la piel',NULL),(6,0,'2020-02-07','Demencia','galocolon','Dificultad de memorizar',NULL),(7,0,'2020-10-04','Dengue','giulicorr','Fiebre',NULL),(8,0,'2020-07-29','Eccema','irenepaula','Placas rojizas',NULL),(9,0,'2020-08-12','Edema pulmonar','ismamor','Piel palida',NULL),(10,0,'2020-11-11','Encefalitis','ivancorcoles','Dolor de cabeza',NULL),(11,0,'2020-12-12','Endocarditis','javiruiz','Perdida de peso',NULL),(12,0,'2019-05-12','Faringitis','jenialo','Fiebre',NULL),(13,0,'2019-12-12','Fibrosis pulmonar idopatica','jesusmoreno','Fiebre',NULL),(14,0,'2020-12-05','Gases y flatulencia','jorgenuñez','Hinchazon del abdomen',NULL),(15,0,'2020-02-12','Golpe de calor','joseantonio','Dolor de cabeza',NULL),(16,0,'2020-02-10','Gonorrea','josemiguel','Dolor abdominal',NULL),(17,0,'2020-05-01','Hemofilia','juancarlos','Sangrado incesante',NULL),(18,0,'2020-08-01','Hemorroides','juanjose','Dolor',NULL),(19,0,'2020-01-06','Depresion','gonza10','Tristeza',NULL),(20,0,'2019-08-19','Hepatitis A','kevinxd7722','Fiebre',NULL),(21,0,'2019-09-22','Hepatitis B','laurisantini10','Fatiga extrema',NULL),(22,0,'2019-10-22','Hepatitis C','leonle','Cansancio',NULL),(23,0,'2019-12-10','Hernia discal','lionuñez','Dolor de brazos',NULL),(24,0,'2020-04-10','Ictus','luisfigo','Dolor de cabeza',NULL),(25,0,'2020-03-03','Insomio','franbica','Cansancio',NULL),(26,0,'2020-08-10','Covid-19','mariagon','Tos',NULL),(27,0,'2020-08-08','Insuficiencia cardiaca','mariallanos','Disnea',NULL),(28,0,'2020-06-12','Juanetes','mariarosario','Dolor',NULL),(29,0,'2019-09-30','Lepra','marmat','Adormecimiento de la piel',NULL),(30,0,'2019-01-30','Leucemia','mayzafer30','Cansancio',NULL),(31,0,'2020-02-16','Linfoma','mercedesvalero','Bultos sensibles',NULL),(32,0,'2019-10-22','Listeriosis','nachitopi','Vomitos',NULL),(33,0,'2020-02-10','Malaria','pablopeñeirua','Fiebre',NULL),(34,0,'2020-02-10','Melasma','pascualtebar','Manchas marrones',NULL),(35,0,'2020-01-30','Meningitis','pilarmaria','Fiebre',NULL),(36,0,'2020-01-30','Migrañas','rafaaf','Depresion',NULL),(37,0,'2020-02-28','Narcolepsia','rocioalicia','Crisis',NULL),(38,0,'2019-12-31','Neumonia','rociopardo','Tos',NULL),(39,0,'2020-05-07','Obesidad','rodriribero','Fatiga',NULL),(40,0,'2020-01-30','Ojo seco','rosamaria','Vision borrosa',NULL),(41,0,'2020-07-05','Ortorexia','rubencollado','Preocupacion excesiva',NULL),(42,0,'2019-10-22','Pancreatitis','santana_s','Dolor en el abdomen',NULL),(43,0,'2020-01-30','Parkinson','santijv','Temblor',NULL),(44,0,'2019-01-30','Pie de atleta','selepintos','Piel seca en escamas',NULL),(45,0,'2020-02-10','Pies planos','veraort','Tejido adiposo en el pie',NULL),(46,0,'2020-07-10','Rinitis','viarmartin','Picor',NULL),(47,0,'2020-01-12','Acidez de estomago','ferpais','Regurgitacion',NULL),(48,0,'2020-01-30','Acne','ferserranodiaz','Cicatrices en la piel',NULL),(49,0,'2020-02-05','Bartolitis','manuelena','Fiebre',NULL),(50,0,'2020-01-30','Bronquitis','franjose','Dificultad respiratorio',NULL),(51,1,'2020-10-10','Covid-19','Gonza10','Tos',NULL),(52,1,'2020-10-22','Covid-19','juanjose','Fiebre',NULL),(53,1,'2020-10-22','Covid-19','juanjose','Tos',NULL),(54,1,'2020-10-22','Covid-19','franbica','Dolor de garganta',NULL),(55,1,'2020-10-22','Covid-19','jenialo','Disnea',NULL),(56,1,'2020-10-22','Covid-19','mariallanos','Disnea',NULL),(57,1,'2020-10-11','Covid-19','lionuñez','Disnea',NULL),(58,1,'2020-10-11','Covid-19','luisfigo','Dolor de cabeza',NULL),(59,1,'2020-11-11','Covid-19','mariagon','Dolor de cabeza',NULL),(60,1,'2020-08-09','Covid-19','mercedesvalero','Fiebre',NULL),(61,1,'2020-08-09','Covid-19','ferserranodiaz','Fiebre',NULL),(62,1,'2020-08-09','Covid-19','ferserranodiaz','Tos',NULL),(63,1,'2020-05-10','Covid-19','galocolon','Tos',NULL),(64,1,'2020-05-10','Covid-19','jesusmoreno','Fiebre',NULL),(65,1,'2020-01-20','Covid-19','jorgenuñez','Dolor de cabeza',NULL),(66,1,'2020-01-20','Covid-19','manuelena','Fiebre',NULL),(67,1,'2020-12-31','Covid-19','mariarosario','Dolor de garganta',NULL),(68,1,'2020-12-31','Covid-19','rosamaria','Fiebre',NULL),(69,1,'2020-12-10','Covid-19','santana_s','Dolor de cabeza',NULL),(70,1,'2020-12-30','Covid-19','javiruiz','Dolor de garganta',NULL),(71,1,'2020-12-01','Covid-19','joseantonio','Tos',NULL),(72,1,'2020-12-01','Covid-19','joseantonio','Dolor de cabeza',NULL),(73,1,'2020-12-30','Covid-19','laurisantini10','Tos',NULL);
/*!40000 ALTER TABLE `Auto_Diagnostico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Ciudad`
--

DROP TABLE IF EXISTS `Ciudad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Ciudad` (
  `idCiudad` int(10) NOT NULL,
  `idDpto` int(10) NOT NULL,
  `nombreCiudad` varchar(100) NOT NULL,
  PRIMARY KEY (`idCiudad`),
  KEY `idDpto` (`idDpto`),
  CONSTRAINT `Ciudad_ibfk_1` FOREIGN KEY (`idDpto`) REFERENCES `Departamento` (`idDpto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Ciudad`
--

LOCK TABLES `Ciudad` WRITE;
/*!40000 ALTER TABLE `Ciudad` DISABLE KEYS */;
INSERT INTO `Ciudad` VALUES (1,1,'Tres Cruces'),(2,1,'Buceo'),(3,1,'Cordon'),(4,1,'Piedras Blancas'),(5,2,'Pando'),(6,2,'Las piedras'),(7,2,'La paz'),(8,2,'Atlantida'),(9,3,'Punta del este'),(10,3,'San carlos'),(11,3,'Piriapolis'),(12,4,'Curtina'),(13,4,'Achar'),(14,4,'Las toscas'),(15,4,'Valle Eden'),(16,5,'Minas'),(17,5,'Villa Serrana'),(18,5,'Mariscala'),(19,6,'Rafael Perazza'),(20,6,'Libertad'),(21,6,'Ciudad del plata'),(22,6,'Kiyu'),(23,7,'Melo'),(24,7,'Arbolito'),(25,7,'Fraile Muerto'),(26,7,'Aguirre'),(27,7,'Placido Rosas'),(28,8,'Vergara'),(29,8,'Gral Enrique Martinez'),(30,9,'Las Flores'),(31,9,'Minas de corrales'),(32,9,'La puente'),(33,9,'Paso Hospital'),(34,9,'Vichadero'),(35,10,'Javier de Viana'),(36,10,'Cuaro'),(37,10,'La Bolsa'),(38,11,'Quebracho'),(39,11,'El Eucaliptus'),(40,11,'Guichon'),(41,11,'Arbolito'),(42,12,'Biassini'),(43,12,'Pueblo Lavalleja'),(44,12,'Sarandi Arapey'),(45,12,'Termas del Dayman'),(46,13,'Young'),(47,13,'Grecco'),(48,14,'Mercedes'),(49,14,'Egaña'),(50,14,'Castillos'),(51,14,'Cañada Nieto'),(52,15,'Carmelo'),(53,15,'Colonia del Sacramento'),(54,15,'Semillero'),(55,16,'Sarandi Grande'),(56,16,'La cruz'),(57,16,'Pintado'),(58,17,'Trinidad'),(59,17,'Andresito'),(60,17,'Cerro colorado'),(61,18,'Sarandi del Yi'),(62,18,'La paloma'),(63,19,'Punta del diablo'),(64,19,'La paloma'),(65,19,'La Pedrera');
/*!40000 ALTER TABLE `Ciudad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Contiene`
--

DROP TABLE IF EXISTS `Contiene`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Contiene` (
  `nombrePatologia` varchar(100) NOT NULL,
  `nombresSintoma` varchar(100) NOT NULL,
  KEY `nombrePatologia` (`nombrePatologia`),
  KEY `nombresSintoma` (`nombresSintoma`),
  CONSTRAINT `Contiene_ibfk_1` FOREIGN KEY (`nombrePatologia`) REFERENCES `Patologia` (`nombrePatologia`),
  CONSTRAINT `Contiene_ibfk_2` FOREIGN KEY (`nombresSintoma`) REFERENCES `Sintoma` (`nombresSintoma`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Contiene`
--

LOCK TABLES `Contiene` WRITE;
/*!40000 ALTER TABLE `Contiene` DISABLE KEYS */;
INSERT INTO `Contiene` VALUES ('Acidez de estomago','Plenitud gastrica'),('Acidez de estomago','Regurgitacion'),('Acidez de estomago','Ardor esofagico'),('Acne','Quistes'),('Acne','Cicatrices en la piel'),('Acne','Espinillas'),('Bartolinitis','Fiebre'),('Bartolinitis','Dolor durante relaciones sexuales'),('Bartolinitis','Bultos sensibles'),('Bronquitis','Tos'),('Bronquitis','Dificultad respiratorio'),('Bronquitis','Fiebre'),('Cancer de piel','Marcas en la piel'),('Cancer de piel','Ulcera'),('Demencia','Dificultad de memorizar'),('Demencia','Perdida de capacidad de juicio'),('Demencia','Cambios del patron del sueño'),('Dengue','Fiebre'),('Dengue','Nauseas'),('Dengue','Vomitos'),('Dengue','Tos'),('Dengue','Dolor de garganta'),('Depresion','Tristeza'),('Depresion','Perdida de concentracion'),('Depresion','Agitacion'),('Eccema','Placas rojizas'),('Eccema','Picor'),('Edema Pulmonar','Piel palida'),('Edema Pulmonar','Aumento de frecuencia cardiaca'),('Edema Pulmonar','Falta de aire'),('Encefalitis','Dolor de cabeza'),('Encefalitis','Confusion'),('Encefalitis','Vomitos'),('Encefalitis','Movimientos descoordinados'),('Endocarditis','Perdida de peso'),('Endocarditis','Sudoracion excesiva'),('Endocarditis','Fiebre'),('Faringitis','Fiebre'),('Faringitis','Dolor de cabeza'),('Faringitis','Voz ronca'),('Faringitis','Sequedad en la garganta'),('Fibrosis pulmonar idopatica','Fiebre'),('Fibrosis pulmonar idopatica','Acropaquia'),('Fibrosis pulmonar idopatica','Falta de aire'),('Gases y flatulencia','Hinchazon del abdomen'),('Gases y flatulencia','Sensacion de plenitud'),('Gases y flatulencia','Dolor abdominal'),('Golpe de calor','Dolor de cabeza'),('Golpe de calor','Orinar poco'),('Golpe de calor','Hiperventilacion'),('Gonorrea','Dolor abdominal'),('Gonorrea','Fiebre'),('Gonorrea','Vomitos'),('Gonorrea','Irregularidades en la menstruacion'),('Gonorrea','Dolor al orinar'),('Gonorrea','Necesidad de orinar mas frecuente'),('Hemofilia','Sangrado incesante'),('Hemofilia','Hemorragias internas'),('Hemorroides','Dolor'),('Hemorroides','Picor'),('Hemorroides','Sangrado a traves del ano'),('Hepatitis A','Fiebre'),('Hepatitis A','Nauseas'),('Hepatitis A','Diarrea'),('Hepatitis B','Fatiga extrema'),('Hepatitis B','Diarrea'),('Hepatitis B','Vomitos'),('Hepatitis B','Orina oscura'),('Hepatitis C','Cansancio'),('Hepatitis C','Fiebre'),('Hepatitis C','Nauseas'),('Hepatitis C','Perdida del apetito'),('Hernia discal','Dolor de brazos'),('Hernia discal','Dolor de cuello'),('Hernia discal','Debilidad de la pierna'),('Hernia discal','Debilidad de brazo'),('Ictus','Dolor de cabeza'),('Ictus','Dificultad para andar'),('Ictus','Problemas para ver en uno o dos de los ojos'),('Insomio','Cansancio'),('Insomio','Debilidad'),('Insomio','Lentitud a la hora de procesar informacion'),('Insomio','Irritabilidad'),('Covid-19','Tos'),('Covid-19','Dolor de garganta'),('Covid-19','Fiebre'),('Covid-19','Disnea'),('Covid-19','Dolor de cabeza'),('Insuficiencia cardiaca','Disnea'),('Insuficiencia cardiaca','Ortopnea'),('Insuficiencia cardiaca','Fatiga'),('Juanetes','Dolor'),('Juanetes','Piel con aspecto calloso y enrojecido'),('Juanetes','Dedo gordo rota en direccion hacia los otros dedos'),('Lepra','Adormecimiento de la piel'),('Lepra','Debilidad muscular'),('Lepra','Lesiones en la piel'),('Leucemia','Cansancio'),('Leucemia','Sudores nocturnos'),('Leucemia','Fiebre'),('Leucemia','Perdida de peso'),('Leucemia','Perdida de apetito'),('Leucemia','Debilidad'),('Linfoma','Bultos sensibles'),('Linfoma','Fiebre'),('Listeriosis','Vomitos'),('Listeriosis','Sarpullido'),('Listeriosis','Dificultad respiratorio'),('Listeriosis','Cansancio'),('Malaria','Fiebre'),('Malaria','Dolor de cabeza'),('Malaria','Dolor muscular'),('Malaria','Escalofrios'),('Malaria','Vomitos'),('Melasma','Manchas marrones'),('Melasma','Manchas sin costras'),('Meningitis','Fiebre'),('Meningitis','Dolor de cabeza'),('Meningitis','Somnolencia'),('Meningitis','Vomitos'),('Migrañas','Depresion'),('Migrañas','Irritabilidad'),('Migrañas','Inquietud'),('Migrañas','Nauseas'),('Migrañas','Perdida del apetito'),('Narcolepsia','Crisis'),('Narcolepsia','Debilidad'),('Neumonia','Tos'),('Neumonia','Fiebre'),('Neumonia','Escalofrios'),('Neumonia','Dolor de cabeza'),('Obesidad','Fatiga'),('Obesidad','Ahogo'),('Obesidad','Dolor'),('Obesidad','Tumefaccion'),('Ojo seco','Vision borrosa'),('Ojo seco','Hipersensibilidad a la luz'),('Ojo seco','Picor'),('Ortorexia','Preocupacion excesiva'),('Ortorexia','Aislamiento social'),('Ortorexia','Castigo propio'),('Pancreatitis','Dolor en el abdomen'),('Pancreatitis','Hipo'),('Pancreatitis','Indigestion'),('Parkinson','Temblor'),('Parkinson','Rigidez'),('Parkinson','Inestabilidad'),('Pie de atleta','Piel seca en escamas'),('Pie de atleta','Picor'),('Pie de atleta','Mal olor'),('Pie de atleta','Inflamacion'),('Pies planos','Tejido adiposo en el pie'),('Rinitis','Picor'),('Rinitis','Ojos llorosos'),('Rinitis','Estornudos'),('Rinitis','Dolor de cabeza'),('Rinitis','Tos'),('Rotavirus','Diarrea'),('Rotavirus','Fiebre'),('Rotavirus','Vomitos'),('Rubeola','Malestar general'),('Rubeola','Fiebre'),('Rubeola','Enrojecimiento de los ojos'),('Rubeola','Dolor de garganta'),('Rubeola','Inflamacion'),('Rubeola','Erupciones'),('Sifilis','Llagas'),('Sifilis','Dolor de garganta'),('Sifilis','Perdida de pelo'),('Sifilis','Dolor de cabeza'),('Sifilis','Paralisis'),('Sifilis','Ceguera'),('Sifilis','Demencia'),('Silicosis','Dificultad respiratorio'),('Silicosis','Fiebre'),('Silicosis','Debilidad'),('Silicosis','Dolor'),('Silicosis','Perdida de peso'),('Tendinitis','Dolor'),('Tendinitis','Sensibilidad en el tendon'),('Tendinitis','Incremento del malestar al moverse'),('Tetanos','Babeo'),('Tetanos','Fiebre'),('Tetanos','Irritabilidad'),('Tetanos','Diarrea'),('Tetanos','Dificultad para deglutir');
/*!40000 ALTER TABLE `Contiene` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Departamento`
--

DROP TABLE IF EXISTS `Departamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Departamento` (
  `idDpto` int(10) NOT NULL,
  `nombreDpto` varchar(100) NOT NULL,
  PRIMARY KEY (`idDpto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Departamento`
--

LOCK TABLES `Departamento` WRITE;
/*!40000 ALTER TABLE `Departamento` DISABLE KEYS */;
INSERT INTO `Departamento` VALUES (1,'Montevideo'),(2,'Canelones'),(3,'Maldonado'),(4,'Tacuarembo'),(5,'Lavalleja'),(6,'San Jose'),(7,'Cerro largo'),(8,'Treinta y tres'),(9,'Rivera'),(10,'Artigas'),(11,'Paysandu'),(12,'Salto'),(13,'Rio Negro'),(14,'Soriano'),(15,'Colonia'),(16,'Florida'),(17,'Flores'),(18,'Durazno'),(19,'Rocha');
/*!40000 ALTER TABLE `Departamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Entra`
--

DROP TABLE IF EXISTS `Entra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Entra` (
  `idSala` int(10) NOT NULL,
  `nombreUsuario` varchar(100) NOT NULL,
  KEY `idSala` (`idSala`),
  KEY `nombreUsuario` (`nombreUsuario`),
  CONSTRAINT `Entra_ibfk_1` FOREIGN KEY (`idSala`) REFERENCES `Sala_Chat` (`idSala`),
  CONSTRAINT `Entra_ibfk_2` FOREIGN KEY (`nombreUsuario`) REFERENCES `Usuario` (`nombreUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Entra`
--

LOCK TABLES `Entra` WRITE;
/*!40000 ALTER TABLE `Entra` DISABLE KEYS */;
INSERT INTO `Entra` VALUES (1,'ferpais'),(2,'manuelena'),(2,'chrislois'),(3,'franjose'),(3,'faqgarcia'),(4,'franlopez'),(4,'alfogil'),(5,'galocolon'),(5,'alegarrido'),(6,'gonza10'),(6,'diegocalero');
/*!40000 ALTER TABLE `Entra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Ingresa`
--

DROP TABLE IF EXISTS `Ingresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Ingresa` (
  `nombrePaciente` varchar(100) NOT NULL,
  `nombresSintoma` varchar(100) NOT NULL,
  KEY `nombrePaciente` (`nombrePaciente`),
  KEY `nombresSintoma` (`nombresSintoma`),
  CONSTRAINT `Ingresa_ibfk_1` FOREIGN KEY (`nombrePaciente`) REFERENCES `Usuario` (`nombreUsuario`),
  CONSTRAINT `Ingresa_ibfk_2` FOREIGN KEY (`nombresSintoma`) REFERENCES `Sintoma` (`nombresSintoma`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Ingresa`
--

LOCK TABLES `Ingresa` WRITE;
/*!40000 ALTER TABLE `Ingresa` DISABLE KEYS */;
INSERT INTO `Ingresa` VALUES ('ferpais','Plenitud gastrica'),('ferserranodiaz','Quistes'),('manuelena','Fiebre'),('franjose','Tos'),('franlopez','Marcas en la piel'),('galocolon','Dificultad de memorizar'),('giulicorr','Fiebre'),('gonza10','Tristeza'),('irenepaula','Placas rojizas'),('ismamor','Piel palida'),('ivancorcoles','Dolor de cabeza'),('javiruiz','Perdida de peso'),('jenialo','Fiebre'),('jesusmoreno','Fiebre'),('jorgenuñez','Hinchazon del abdomen'),('joseantonio','Dolor de cabeza'),('josemiguel','Dolor abdominal'),('juancarlos','Sangrado incesante'),('juanjose','Dolor'),('kevinxd7722','Fiebre'),('laurisantini10','Fatiga extrema'),('leonle','Cansancio'),('lionuñez','Dolor de brazos'),('luisfigo','Dolor de cabeza'),('franbica','Cansancio'),('mariagon','Tos'),('mariallanos','Disnea'),('mariarosario','Dolor'),('marmat','Adormecimiento de la piel'),('mayzafer30','Cansancio'),('mercedesvalero','Bultos sensibles'),('nachitopi','Vomitos'),('pablopeñeirua','Fiebre'),('pascualtebar','Manchas marrones'),('pilarmaria','Fiebre'),('rafaaf','Depresion'),('rocioalicia','Crisis'),('rociopardo','Tos'),('rodriribero','Fatiga'),('rosamaria','Vision borrosa'),('rubencollado','Preocupacion excesiva'),('santana_s','Dolor en el abdomen'),('santijv','Temblor'),('selepintos','Piel seca en escamas'),('veraort','Tejido adiposo en el pie'),('viarmartin','Picor'),('ferpais','Regurgitacion'),('ferserranodiaz','Cicatrices en la piel'),('franbica','Dolor durante relaciones sexuales'),('franjose','Dificultad respiratorio');
/*!40000 ALTER TABLE `Ingresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Medico`
--

DROP TABLE IF EXISTS `Medico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Medico` (
  `nombreMedico` varchar(100) NOT NULL,
  `Especialidad` varchar(100) NOT NULL,
  `Contraseña` varchar(100) NOT NULL,
  PRIMARY KEY (`nombreMedico`),
  CONSTRAINT `Medico_ibfk_1` FOREIGN KEY (`nombreMedico`) REFERENCES `Usuario` (`nombreUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Medico`
--

LOCK TABLES `Medico` WRITE;
/*!40000 ALTER TABLE `Medico` DISABLE KEYS */;
INSERT INTO `Medico` VALUES ('abiaraujo','Anestesiologa','abianes'),('agusblanco','Cardiologa','aguscardio'),('alegarrido','Fisioterapeuta','alegafisio'),('aleperez','Cirujano','aleperezderma'),('alfogil','Traumatologo','alfoeltrauma'),('anabelen','Pedriatra','anapedi'),('andresantonio','Pedriatra','andrespedi'),('beatrizcebrian','Urologa','beatrizuro'),('brzsuarez','Psiquitra','brzpsqui'),('chrislois','Cirujano','chrisciruja'),('ciro210','Urologo','cirouro'),('davidloz','Medico del deporte','davidmedi'),('diegocalero','Infectologo','diegoinfect'),('emaoca','Pedriatra','emapedi'),('enridi10','Psiquitra','enripsqui'),('faqgarcia','Radiologo','faqradi');
/*!40000 ALTER TABLE `Medico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Mensaje`
--

DROP TABLE IF EXISTS `Mensaje`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Mensaje` (
  `idMensaje` int(10) NOT NULL,
  `idSala` int(10) NOT NULL,
  `nombreUsuario` varchar(100) NOT NULL,
  `Texto` varchar(254) NOT NULL,
  `Fecha` date NOT NULL,
  `Hora` time NOT NULL,
  PRIMARY KEY (`idMensaje`),
  KEY `idSala` (`idSala`),
  KEY `nombreUsuario` (`nombreUsuario`),
  CONSTRAINT `Mensaje_ibfk_1` FOREIGN KEY (`idSala`) REFERENCES `Sala_Chat` (`idSala`),
  CONSTRAINT `Mensaje_ibfk_2` FOREIGN KEY (`nombreUsuario`) REFERENCES `Usuario` (`nombreUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Mensaje`
--

LOCK TABLES `Mensaje` WRITE;
/*!40000 ALTER TABLE `Mensaje` DISABLE KEYS */;
INSERT INTO `Mensaje` VALUES (7,2,'manuelena','¡Doctor! ¡¡¿Que es la bartolinitis?!! ¡¡¿Es peligroso?!!','2020-08-06','12:35:00'),(8,2,'chrislois','Antes que nada, tranquilicese señorita, la bartolinitis no es mortal. Solo debemos tratarla a tiempo y estará bien, se lo aseguro.','2020-08-06','12:37:00'),(9,2,'manuelena','Bueno doctor, y ¿Cuales procedimientos me indicaría usted para tratar mi enfermedad adecuadamente?','2020-08-06','12:37:00'),(10,2,'chrislois','Para empezar, si la glándula no está infectada y el quiste es pequeño y no produce molestias, a menudo no se requiere un tratamiento específico para la bartolinitis. En estos casos puede ser suficiente con una serie de medidas básicas como los baños de a','2020-08-06','12:38:00'),(11,2,'chrislois','Si hay algo de dolor se puede tomar paracetamol o un antiinflamatorio como el ibuprofeno. Las compresas calientes aplicadas en la zona varias veces al día también pueden ayudar a acelerar la resolución del cuadro.','2020-08-06','12:39:00'),(12,2,'chrislois','Si la glándula de Bartolino está infectada y el absceso es pequeño, las medidas comentadas pueden hacer que se abra y que se drene solo, aunque es frecuente que reaparezca.','2020-08-06','12:39:00'),(13,2,'chrislois','Por ello, en estos casos, y desde el inicio del cuadro cuando el absceso es grande, doloroso o se acompaña de fiebre, se realiza un tratamiento específico con un drenaje quirúrgico.','2020-08-06','12:40:00'),(14,2,'manuelena','Bueno doctor, en ese caso me gustaría pedir una cita con mi ginecologo para poder estar más tranquila. Muchas gracias por su atención.','2020-08-06','12:41:00'),(15,3,'franjose','Buenos dias doctor. Ultimamente tengo muchisima tos y dificultades para respirar y acudi aqui ya que estaba preocupado de que fuera el coronavirus','2020-06-19','11:52:00'),(16,3,'faqgarcia','No se preocupe hombre, seguramente lo que usted padezca sea bronquitis. No se preocupe, la mayoria de estos casos se recuperar a los días y no son muy dificiles de tratar','2020-06-19','11:53:00'),(17,3,'faqgarcia','Mire, yo le recomiendo descansar y tomar muchos liquidos, por otra parte debera tomar alguna aspirina o acetaminofen para bajar la feibre.','2020-06-19','11:54:00'),(18,3,'franjose','Muchas gracias doctor! Seguire sus indicaciones al pie de la letra.','2020-06-19','11:54:00'),(19,4,'franlopez','Mire doctor, yo no puedo creer que su programita insinue que yo padezco cancer. YO, una persona sana, trabajadora, esto no me lo merezco.','2020-09-12','08:59:00'),(20,4,'franlopez','Yo no puedo aceptar esto. Que le voy a decir a mi familia, como voy a afrontar esta situacion? COMO DOCTOR?!!! Estoy seguro de que su programa no sirve','2020-09-12','09:00:00'),(21,4,'franlopez','Los voy a demandar por tratar de engañar a sus pacientes para obtener ganacias de ellos.','2020-09-12','09:01:00'),(22,4,'alfogil','Señor tranquilisece, estoy seguro que podemos buscar una solución para su enfermedad y así usted puede superarla y volver a ser un hombre muy sano.','2020-09-12','09:01:00'),(23,4,'alfogil','Antes de indicarle que debería hacer para tratar su enferdad, me gustaría aclararle que nuestro programa no es 100% efectivo, ya que con la actual tecnología esto es muy complicado de lograr.','2020-09-12','09:02:00'),(24,4,'alfogil','Para tratar el cancer a la piel existen varios tratamientos, uno de ellos es la terapia fotodinamica, este tratamiento utiliza un tipo especifico de liz para destruir las celulas cancerosas.','2020-09-12','09:03:00'),(25,4,'franlopez','No necesito ningun tratamiento porque yo no estoy enfermo de nada, ya le dije que soy un hombre sano, yo no puedo tener ese cancer que dice este cacharro que usan.','2020-09-12','09:05:00'),(26,4,'alfogil','Señor, si usted busca una opinion de un profesional, puede pedir fecha para una cita y confirmar, o desmentir, lo que dice nuestro sistema. Si solo busca que yo pierda mi tiempo','2020-09-12','09:06:00'),(27,4,'alfogil','Le invito a que se retire, y permita que el resto de pacientes puede acceder al mismo. Ya que, aunque a usted no le parezca util, a otros si, y de verdad les ayuda.','2020-09-12','09:07:00'),(28,4,'alfogil','Desde este punto ya no responderé a sus mensajes, así que no siga intentando','2020-09-12','09:08:00'),(29,4,'franlopez','Yo no puedo creer que este hospital permita trabajar a esta manga de irrespetuosos, ya mismo voy a quejarme a la administración.','2020-09-12','09:10:00'),(30,5,'galocolon','Buenas doctor, me gustaria pregutarle cual seria mi situacion al padecer Demencia y cuales serian los tratamientos.','2020-05-15','18:37:00'),(31,5,'alegarrido','Mire señor, para tratar la demecia y mejorarla temporalmente. se utilizan Inhibidores de la colinesterasa.','2020-05-15','18:38:00'),(32,5,'alegarrido','Estos medicamentos, como el donepezilo, la rivastigmina y la galantamina, actúan aumentando los niveles de un mensajero químico involucrado en la memoria y el razonamiento.','2020-05-15','18:38:00'),(33,5,'alegarrido','Aunque se usan principalmente para tratar la enfermedad de Alzheimer, estos medicamentos también podrían recetarse para tratar otras demencias,','2020-05-15','18:39:00'),(34,5,'alegarrido','como la demencia vascular, la demencia por la enfermedad de Parkinson y la demencia con cuerpos de Lewy.','2020-05-15','18:39:00'),(35,5,'alegarrido','Por otro lado podemos utilizar la memantina actúa regulando la actividad del glutamato, otro mensajero químico involucrado en las funciones cerebrales, como el aprendizaje y la memoria.','2020-05-15','18:39:00'),(36,5,'alegarrido','En algunos casos, la memantina se receta con un inhibidor de la colinesterasa.','2020-05-15','18:40:00'),(37,5,'galocolon','Bueno muchas gracias, me gustaria sacar una cita para tratar bien dicha Patologia, poder saber que tipo Demencia cargo. Desde ya, muchas gracias.','2020-05-15','18:41:00'),(38,5,'alegarrido','Para pedir por una cita debe dirigirse a la caja y consultar, ellos le ayudarán.','2020-05-15','18:41:00'),(39,5,'alegarrido','Que tenga bonita noche.','2020-05-15','18:41:00'),(40,5,'galocolon','Muchas gracias, igualmente.','2020-05-15','18:42:00'),(41,5,'galocolon','Buena jornada.','2020-05-15','18:43:00'),(42,6,'gonza10','Hola doctor, ultimamente me siento muy bajoneado, no me estan saliendo las cosas, perdi el trabajo, estoy perdiendo los ultimos examenes de mi universidad y demas.','2020-10-13','20:45:00'),(43,6,'gonza10','Me siento que no tengo ganas de hacer nada porque haga lo que haga me va a salir mal.','2020-10-13','20:45:00'),(44,6,'gonza10','Quiero dejar de sentir eso, sentir que me siento bajoneado, triste. Sin querer hacer nada.','2020-10-13','20:46:00'),(45,6,'diegocalero','No estás solo en esto. Quizá no comprendo con exactitud cómo te sientes, pero me preocupo por ti y quiero ayudarte.','2020-10-13','20:47:00'),(46,6,'diegocalero','Pedir ayuda no es un signo de debilidad, sino de fortaleza.','2020-10-13','20:47:00'),(47,6,'diegocalero','La depresión es un problema de salud real y tratable. Así que como doctor, voy a ayudarte.','2020-10-13','20:47:00'),(48,6,'gonza10','La verdad doctor, le agradezco mucho su ayuda, me podria ayudar con los tratamientos para poder intentar curarme, porque enserio, necesito curarme rapido, sino mi vida se derrumba.','2020-10-13','20:48:00'),(49,6,'diegocalero','Le recomiendo la Psicoterapia, es un tratamiento para la depresión mediante la conversación con un profesional de salud mental, el cual lo escuchara y guiara para que usted se recupere con el pasar del tiempo.','2020-10-13','20:48:00'),(50,6,'gonza10','La verdad le agradezco un monton, vere como es el tema de Psicoterapeuta.','2020-10-13','20:49:00'),(51,6,'gonza10','Muchas gracias y que tenga una linda jornada.','2020-10-13','20:50:00'),(52,6,'diegocalero','Que tenga una buena noche, y ojala se recupere.','2020-10-13','20:50:00');
/*!40000 ALTER TABLE `Mensaje` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Muerte`
--

DROP TABLE IF EXISTS `Muerte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Muerte` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `Fecha` date NOT NULL,
  `idAutodiagnostico` int(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idAutodiagnostico` (`idAutodiagnostico`),
  CONSTRAINT `Muerte_ibfk_1` FOREIGN KEY (`idAutodiagnostico`) REFERENCES `Auto_Diagnostico` (`idAutodiagnostico`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Muerte`
--

LOCK TABLES `Muerte` WRITE;
/*!40000 ALTER TABLE `Muerte` DISABLE KEYS */;
INSERT INTO `Muerte` VALUES (1,'2020-10-22',60);
/*!40000 ALTER TABLE `Muerte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Paciente`
--

DROP TABLE IF EXISTS `Paciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Paciente` (
  `nombrePaciente` varchar(100) NOT NULL,
  `Peso` float NOT NULL,
  `Sexo` enum('M','F') NOT NULL,
  `Altura` float NOT NULL,
  `Pin` int(10) NOT NULL,
  PRIMARY KEY (`nombrePaciente`),
  CONSTRAINT `Paciente_ibfk_1` FOREIGN KEY (`nombrePaciente`) REFERENCES `Usuario` (`nombreUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Paciente`
--

LOCK TABLES `Paciente` WRITE;
/*!40000 ALTER TABLE `Paciente` DISABLE KEYS */;
INSERT INTO `Paciente` VALUES ('ferpais',80.3,'M',1.72,4567),('ferserranodiaz',75.1,'M',1.61,4566),('franbica',70.4,'M',1.7,5645),('franjose',98.8,'M',1.6,5461),('franlopez',60.8,'M',1.5,3451),('galocolon',90.1,'M',1.9,5645),('giulicorr',50.5,'F',1.52,5235),('gonza10',78.7,'M',1.8,6455),('irenepaula',41.1,'F',1.49,4312),('ismamor',70.7,'M',1.81,5456),('ivancorcoles',80.8,'M',1.5,4572),('javiruiz',60.1,'M',1.7,7678),('jenialo',40.4,'F',1.45,1111),('jesusmoreno',69.9,'M',1.64,2222),('jorgenuñez',79.9,'M',2,1324),('joseantonio',100.2,'M',1.92,6743),('josemiguel',64.1,'M',1.5,6565),('juancarlos',100.1,'M',1.65,7688),('juanjose',90.1,'M',1.8,5442),('kevinxd7722',75.5,'M',1.72,3333),('laurisantini10',60.2,'M',1.68,4444),('leonle',80.8,'M',1.69,5555),('lionuñez',50.5,'M',1.5,6666),('luisfigo',90.8,'M',1.8,7777),('manuelena',50.5,'F',1.6,1010),('mariagon',80.8,'F',1.5,5050),('mariallanos',80.1,'F',1.82,8888),('mariarosario',69.1,'F',1.58,9999),('marmat',75.1,'M',1.74,5656),('mayzafer30',54.1,'F',1.6,8788),('mercedesvalero',90.1,'F',2.02,8768),('nachitopi',71.4,'M',1.79,6574),('pablopeñeirua',50.6,'M',1.65,7677),('pascualtebar',70.6,'M',1.8,8776),('pilarmaria',70.4,'F',1.56,5667),('rafaaf',124.8,'M',1.69,7678),('rocioalicia',100.2,'F',1.92,5656),('rociopardo',68.4,'F',1.63,6657),('rodriribero',80.8,'M',1.73,6786),('rosamaria',60.1,'F',1.68,5456),('rubencollado',62.6,'M',1.7,5357),('santana_s',60.1,'F',1.6,3535),('santijv',72.1,'M',1.94,5467),('selepintos',67.4,'F',1.62,5435),('veraort',41.1,'F',1.52,5467),('viarmartin',76.6,'M',1.64,5667);
/*!40000 ALTER TABLE `Paciente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Patologia`
--

DROP TABLE IF EXISTS `Patologia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Patologia` (
  `nombrePatologia` varchar(100) NOT NULL,
  `DescripcionP` varchar(200) NOT NULL,
  `Recomendacion` varchar(200) NOT NULL,
  `Mortal` tinyint(1) NOT NULL,
  `Tipo` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`nombrePatologia`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Patologia`
--

LOCK TABLES `Patologia` WRITE;
/*!40000 ALTER TABLE `Patologia` DISABLE KEYS */;
INSERT INTO `Patologia` VALUES ('Acidez de estomago','Es una quemazon o ardor que sube hasta la laringe','Medidas farmacologicas de primera eleccion, se aconseja las combinaciones de manganesio y aluminio',0,NULL),('Acne','Aparicion de lesiones en la piel como consecuencia de una foliculitis, una inflamacion y posterior infeccion del poro folicular','Los tratamientos de esta enfermedad se tendra que ver la gravedad de dicha enfermedad',0,NULL),('Bartolinitis','Infeccion de las glandulas de Bartolio','Dependera de la paciente, su edad y su evolucion y patologias asociadas, puede ser util, baños de asiento o aplicar calor en la zona afectada',0,NULL),('Bronquitis','Inflamacion de los conductos que transportan el aire al interior de los pulmones','Hidrataciom, Antitermicos, Antibioticos y Inhaladores',1,NULL),('Cancer de piel','Este cancer es no melanoma, este grupo de tumores comprende todos los tipos de cancer de piel, son manchas que aparencen en la piel','Se trata con la cirugia de Mohs',1,NULL),('Covid-19','Enfermedad infecciosa causada por el corona virus','Hopitalizacion en casos graves, si no te dan antivirales y dosis altas de esteroides para reducir la inflamacion',1,NULL),('Demencia','Es el deterioro de la funcion cognitiva mas alla de lo que podria considerase normal','La mayoria de demencias son irreversibles, pero hay tratamientos que permiten controlar los sintomas y mejorar la calidad de vida del paciente',1,NULL),('Dengue','Es una enfermedad que producida por un virus de la familia llamda flavivirus','No hay un tratamiento especifico, pero se puede curar con antiflamatorios, antipirecticos y reposo',1,NULL),('Depresion','Conjunto de sintomas de predominio afectivo,','Se puede curar con compresion y el cariño de los famileares y allegados',1,NULL),('Eccema','Proceso descamativo y asociado al picor que afecta a la piel','Evitar las sustancias a la que el paciente es alergico',0,NULL),('Edema Pulmonar','Acumulacion anormal de liquido en los pulmones','Tiene tres objetivos: Disminuir la presion venocapilar, Mejorar la ventilacion pulmonar, Tratar la enfermedad que ha causado el edema.',1,NULL),('Encefalitis','Es una inflamacion del cerebro cuya causa mas frecuente es la infeccion viral','Aciclvir IV, Gnciclorvir y foscarnet IV y paracetamol para la fiebre, puede ser moral si no se trata',1,NULL),('Endocarditis','Inflamacion del revestimiento interior de las valvulas y camaras cardiacas','Antibioticos intravenosos hay cirugia si hay que sustituir la valvula afectada por una protesis',1,NULL),('Faringitis','Inflamacion de la faringe causada por una infeccion bacteriana o virica','Con antibioticos, mas comunmente la penicilina',0,NULL),('Fibrosis pulmonar idopatica','Es una fribrosis o un engrosamiento de los pulmones sin ninguna causa conocida','No tiene cura, pero con tratamientos farmacos, oxigeno o la rehabilitacion pulmonar puede ayudar al paciente con sus dificultades de respirar',1,NULL),('Gases y flatulencia','Es un proceso habitual durante la digestion pero este se puede acumular y causarle molestias a algunas peronas','En mayoria de casos no se recomienda tratamientos porque aparece y desaparece sola',0,NULL),('Golpe de calor','Sobrecalentamiento que sufre el cuero debido a las altas temperaturas o exceso de ejercicio fisico','Mientras llegan los profesionales se recomienda mantenerla en una habitacion oscura y tratar de enfriar el cuerpo con paños humedos',1,NULL),('Gonorrea','La gonorrea es un ITS causa por una bacteria, que afecta el tracto genital, la boca y el ano','Recetar mas de un antibiotico',1,NULL),('Hemofilia','Trastorno hemorragico donde la coagulacion de la sangre esta alterada','Terapia intravenosa',1,NULL),('Hemorroides','Es cuando las almorranas se congestionan, infalamn y se desplazan o prolapsan hacia el exterior del canal anal','Pueden aparecer sin sintomas, en esos casos no es necesario seguir ningun tratamiento',0,NULL),('Hepatitis A','Es una enfermedad hepatica causada por el virus de la Hepatitis A','En la mayoria de personas se les va sola en pocas semanas, pero uno de los tratamientos es la vacuna',0,NULL),('Hepatitis B','Infeccion hepatica que esta causada por el virus de la hepatitis B','En la fase aguda no tiene tratamiento especifico, en fase cronico necesita terapia famacologica',1,NULL),('Hepatitis C','Infeccion en el higado provocado por el VHC','Antivirales de accion directa',1,NULL),('Hernia Discal','Disco intervertebral se degenera y deteriora','Reposo breve y analgesicos, otros casos son inyecciones de espalda o antiinflamatiorios no esteroides',1,NULL),('Ictus','Enfermedad cebrovascular afectando los vasos sanguinios que suministran la sangre al cerebro','Reconocer rapidamente los signos y sintomas, activar con rapidez servicios de emergencia y trasporte rapido de emergencia',1,NULL),('Insomio','Incapacidad para conciliar el sueño o para mantenerlo','Terapia cognitivo-conductal',0,NULL),('Insuficiencia cardiaca','Musculo cardiaco no capaz de bombear suficiente sangre','Reducir factores de riesgo como la Obesidad, tratar la causa que desencadena la enfermedad, ingerir productos diurecticos, etc',1,NULL),('Juanetes','Deformidad del dedo gordo, produce una protuberancia en el borde externo del mismo','Si no son dolorosos en el calzado no se recomienda operarlos, pero si son, se operan',0,NULL),('Lepra','Infeccion cronica producida por una bacteria que afecta al sistema nervioso periferico','Combinacion de rifampicina y dapsona durante seis meses y una de rifampcina, dapsona y clofazimina durante 12',0,NULL),('Leucemia','La medula osea produce globulos blancos anomalos','Depende de que tipo de leucema padaezca el paciente',1,NULL),('Linfoma','Proliferacion maligna de linfocitos','Poliquimitoterapia, Radio-quimioterapia y Transplante de progenitores hematopoyeticos',1,NULL),('Listeriosis','Contamido por ingerir alimentos que tiene la bacteria','Prescripcion de antibioticos, es de suma importancia tomar medidas de forma precoz',1,NULL),('Malaria','Enfermedad provocada por el parasito Plasmodium, se transmite a traves de picaduras de mosquitos','Hospitalizacion, combinaciones de derivados de artemisinina, atovacuona-proguanil, etc',1,NULL),('Melasma','Produce manchas simetricas principalmente en la cara','Cremas despigmentales junto con peelings quimicos y laser, solo se usan bajo indicaciones medicas',0,NULL),('Meningitis','Infeccion provocada por virus o bacterias, infecta unas membranas que rodea el cerebro y la medula espinal','Cuidadoes especificos en el hospital y terapia intensa de antibioticos',1,NULL),('Migrañas','Dolor de cabeza recifivante, pulsatil o intenso','Terapias farmacologicas y no farmacologicas, medicamentos de rescante si los intensos antibioticos fallan',1,NULL),('Narcolepsia','Tendencias del sueño anormales incluye excesiva somnolencia durante el dia y la alteracion del sueño nocturno','Antidepresivos y estimulantes',0,NULL),('Neumonia','Infeccion en uno o en los dos pulmones','Tratamientos de antibioticos',1,NULL),('Obesidad','Exceso de tejido adiposo(grasa) en el cuerpo','Alimentacion buena, ejercicio fisico, apoyo psicologico y tratamiento farmacologico',1,NULL),('Ojo seco','El globo ocular adolece de la pelicula lagrimal necesaria','Para el principio ponen lagrimas artificiales, mas avanzado implante de tampones lagrimales, mas riesgoso seria el implante de tejido de placenta',0,NULL),('Ortorexia','Obsesion por la comida sana','Terapia psquiatrica con la farmacologica a traves de medicamentos que puedan recuperar los nutrientes faltantes',0,NULL),('Pancreatitis','Inflamacion del pancreas','Es hospitalizacion directa y se trata con distintos tratamientos y analgesicos',1,NULL),('Parkinson','Desorden cronico y degenerativo de una de las partes del cerebro que controla el sistema motor','No tiene cura, pero se puede tratar con tratamiento Farmacologicos, quirurgico, subtalamotomia y rehabilitacion fisica',1,NULL),('Pie de atleta','Infeccion causada por hongos que aparecen en los dedos de los pies','Con cremas antifungicos se deberia ir, pero sino ir al medico para que instaure el tratamiento recomendable',0,NULL),('Pies planos','Falta de arco longitudinal o de boveda plantar','Si no presenta dolor no necesita tratamiento, si presenta se empieza un tratamiento con ortopedicos',0,NULL),('Rinitis','Trastorno que afecta a la mucosa nasal, produce estornudos, picos, secreciones nasales y falta de olfato','Evite alergeno, un ejemplo de este son los acaros del polvo domestico',0,NULL),('Rotavirus','enfermedad infecciosa que causa en los afectados gastroenteritis o infeccion intestinal','Para poder prevenirla se puede inyectar una vacuna, pero si la tiene no hay medicamentos especificos para tratarla, sino hidratarse de forma continua',1,NULL),('Rubeola','Infeccion virica CONTAGIOSA','No hay tratamiento especifico, lo que hacen es controlar los sintomas directamente mirigar la fiebre y el malestar en general',1,NULL),('Sarampion','Enfermedad altamente contagiosa causada por la infeccion del virus sarampion','En caso de infeccion, se una antitermicos para la fiebre y antitusigneos para la tos, mientras este enfermo guarde reposo y mantenga una buena hidratacion',0,NULL),('Sifilis','Es un ITS causada por una bacteria donde infecta la zona genital, los labios, la boca o el ano, etc. Se produce tanto en hombre como en mujeres','Se trata con antibioticos, recetada por el profesional',1,NULL),('Silicosis','Afecta al sistema respiratorio por inhalar polvo silice','No hay tratamiento especifico porque no tiene cura, pero lo mejor es alejarse del polvo silice para que esta no empeore y tratar de mejorar la calidad de vida con antitusivos',1,NULL),('Tendinitis','Inflamacion del tendon','Reposo para alejar el tendon afectado y ayudarle al recuperarse',0,NULL),('Tetanos','Enfermedad grave provocada por una bacteria, esta toxina actua como veneno para el sistema nervioso central','Reposo, medicamentos para neutralizar el toxico, relajantes musculares, antibioticos y puede hacerse una pequeña cirugia para limpiar la herida y sacar la fuente del toxico',1,NULL);
/*!40000 ALTER TABLE `Patologia` ENABLE KEYS */;
UNLOCK TABLES;



--
-- Table structure for table `Sala_Chat`
--

DROP TABLE IF EXISTS `Sala_Chat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Sala_Chat` (
  `idSala` int(10) NOT NULL AUTO_INCREMENT,
  `Prioridad` varchar(100) NOT NULL,
  PRIMARY KEY (`idSala`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Sala_Chat`
--

LOCK TABLES `Sala_Chat` WRITE;
/*!40000 ALTER TABLE `Sala_Chat` DISABLE KEYS */;
INSERT INTO `Sala_Chat` VALUES (1,'Urgente'),(2,'Urgente'),(3,'Urgente'),(4,'Urgente'),(5,'Urgente'),(6,'Urgente'),(7,'No Urgente'),(8,'Urgente'),(9,'No Urgente'),(10,'Urgente'),(11,'No Urgente'),(12,'No Urgente'),(13,'Urgente'),(14,'No Urgente'),(15,'Urgente'),(16,'No Urgente'),(17,'Urgente'),(18,'No Urgente'),(19,'Urgente'),(20,'Urgente'),(21,'Urgente'),(22,'No Urgente'),(23,'Urgente'),(24,'Urgente'),(25,'Urgente'),(26,'Urgente'),(27,'Urgente'),(28,'No Urgente'),(29,'Urgente'),(30,'Urgente'),(31,'Urgente'),(32,'Urgente'),(33,'No Urgente'),(34,'Urgente'),(35,'Urgente'),(36,'Urgente'),(37,'Urgente'),(38,'Urgente'),(39,'No Urgente'),(40,'No Urgente'),(41,'No Urgente'),(42,'Urgente'),(43,'Urgente'),(44,'Urgente'),(45,'Urgente'),(46,'No Urgente'),(47,'Urgente'),(48,'Urgente'),(49,'No Urgente'),(50,'No Urgente');
/*!40000 ALTER TABLE `Sala_Chat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Sintoma`
--

DROP TABLE IF EXISTS `Sintoma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Sintoma` (
  `nombresSintoma` varchar(100) NOT NULL,
  `DescripcionS` varchar(100) NOT NULL,
  PRIMARY KEY (`nombresSintoma`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Sintoma`
--

LOCK TABLES `Sintoma` WRITE;
/*!40000 ALTER TABLE `Sintoma` DISABLE KEYS */;
INSERT INTO `Sintoma` VALUES ('Acropaquia','Deformacion de las uñas de las manos'),('Adormecimiento de la piel','Piel dormida'),('Agitacion','Signos que se derivan en la tension mental o la ansiedad'),('Ahogo','...'),('Aislamiento social','...'),('Aparicion de bultos sensibles a los lados de la abertura vaginal','...'),('Ardor esofagico','Quemazon detras del esternon'),('Aumento de frecuencia cardiaca','...'),('Babeo','...'),('Bultos sensibles','Son bultos pequeños que aparecen en la ingle'),('Cambios del patron del sueño','Cambias tus horarios de sueño'),('Cansancio','...'),('Castigo propio','...'),('Ceguera','...'),('Cicatrices en la piel','Parche de piel que crece sobre una herida'),('Confusion','...'),('Crisis','...'),('Debilidad','...'),('Debilidad de brazo','Exceso de esfuerzo para moverlo'),('Debilidad de la pierna','Exceso de esfuerzo para moverlo'),('Debilidad muscular','...'),('Dedo gordo rota en direccion hacia los otros dedos','...'),('Demencia','...'),('Depresion','...'),('Diarrea','...'),('Dificultad de memorizar','No se acuerda de cosas'),('Dificultad para andar','...'),('Dificultad para deglutir','Dificultad al tragar'),('Dificultad respiratorio','Problemas al respirar'),('Disnea','Sensacion de falta de aire al respirar'),('Dolor','...'),('Dolor abdominal','...'),('Dolor al orinar','...'),('Dolor de brazos','...'),('Dolor de cabeza','...'),('Dolor de cuello','...'),('Dolor de garganta','...'),('Dolor durante relaciones sexuales','Experiencia sensorial y emocional desagradable durante el recibir placer sexual'),('Dolor en el abdomen','...'),('Dolor muscular','...'),('Enrojecimiento de los ojos','...'),('Erupciones','...'),('Escalofrios','...'),('Espinillas','...'),('Estornudos','...'),('Falta de aire','...'),('Fatiga','Cansancio muscular'),('Fatiga extrema','...'),('Fiebre','Aumento temporal de la temperatura del tiempo'),('Hemorragias internas','Perdida de sangre en una cavidad o espacio corporal'),('Hinchazon del abdomen','...'),('Hipersensibilidad a la luz','Sos muy sensible hacia la luz'),('Hiperventilacion','Respiracion excesiva'),('Hipo','...'),('Incremento del malestar al moverse','...'),('Indigestion','Sensacion vaga de malestar en la parte superior del abdomen'),('Inestabilidad','Es cuando se inclinan para atras y para adelante y se caigan con facilidad'),('Inflamacion','...'),('Inquietud','...'),('Irregularidades en la menstruacion','Es cuando sale algo mal en el ciclo menstrual'),('Irritabilidad','...'),('Lentitud a la hora de procesar informacion','...'),('Lesiones en la piel','...'),('Llagas','...'),('Mal olor','...'),('Malestar general','...'),('Manchas marrones','...'),('Manchas sin costras','...'),('Marcas en la piel','...'),('Movimientos descoordinados','...'),('Nauseas','...'),('Necesidad de orinar mas frecuente','...'),('Ojos llorosos','...'),('Orina oscura','...'),('Orinar poco','...'),('Ortopnea','Dificultad al respirar cuando estas acostado'),('Paralisis','...'),('Perdida de apetito','...'),('Perdida de capacidad de juicio','Saber lo que haces, lo que es real y lo que no'),('Perdida de concentracion','Dificultad para concentrarte'),('Perdida de pelo','...'),('Perdida de peso','...'),('Perdida del apetito','...'),('Picor','...'),('Piel con aspecto calloso y enrojecido','...'),('Piel palida','..'),('Piel seca en escamas','...'),('Placas rojizas','Textura rara en la piel roja'),('Plenitud gastrica','Sensacion de estar muy lleno'),('Preocupacion excesiva','...'),('Problemas para ver en uno o dos de los ojos','...'),('Quistes','Pequeñas bolitas de grasa'),('Regurgitacion','La comida sube a la boca'),('Rigidez','Falta de flexibilidad muscular'),('Sangrado a traves del ano','...'),('Sangrado incesante','No se detiene el sangrado en una herida'),('Sarpullido','Piel irritada'),('Sensacion de Plenitud','Sentirse lleno'),('Sensibilidad en el tendon','Tendon sensible'),('Sequedad en la garganta','Sentir la garganta seca'),('Somnolencia','Esta intermedio entre el sueño y al vigilia en el que todavia no se perdio la consiencia'),('Sudoracion excesiva','...'),('Sudores nocturnos','...'),('Tejido adiposo en el pie','Tejido de grasa en el pie'),('Temblor','...'),('Tos','...'),('Tristeza','...'),('Tumefaccion','Hinchazon que se forma en una parte del cuerpo'),('Ulcera','Ulcera o llaga es una lesion con epitelial(Relacionado) con perdida de sustancia.'),('Vision borrosa','...'),('Vomitos','...'),('Voz ronca','...');
/*!40000 ALTER TABLE `Sintoma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Tels_Usuario`
--

DROP TABLE IF EXISTS `Tels_Usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Tels_Usuario` (
  `nombreUsuario` varchar(100) NOT NULL,
  `Telefono` char(12) NOT NULL,
  PRIMARY KEY (`Telefono`),
  KEY `nombreUsuario` (`nombreUsuario`),
  CONSTRAINT `Tels_Usuario_ibfk_1` FOREIGN KEY (`nombreUsuario`) REFERENCES `Usuario` (`nombreUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Tels_Usuario`
--

LOCK TABLES `Tels_Usuario` WRITE;
/*!40000 ALTER TABLE `Tels_Usuario` DISABLE KEYS */;
INSERT INTO `Tels_Usuario` VALUES ('abiaraujo','+59894340277'),('agusblanco','+59893993064'),('alegarrido','+59898801417'),('aleperez','+59891798608'),('alfogil','+59897844978'),('anabelen','+59891662951'),('andresantonio','+59897823977'),('beatrizcebrian','+59894474907'),('brzsuarez','+59897194531'),('chrislois','+59896395502'),('ciro210','+59898803397'),('davidloz','+59891941609'),('diegocalero','+59897335123'),('emaoca','+59895618029'),('enridi10','+59896116184'),('enzoanto11','+59897464452'),('faqgarcia','+59895789677'),('faqmart40','+59894439491'),('ferpais','+59896943317'),('ferserranodiaz','+59897965437'),('franbica','+59897582523'),('franjose','+59898573306'),('franlopez','+59895916942'),('galocolon','+59894213746'),('giulicorr','+59899951843'),('gonza10','+59895326662'),('irenepaula','+59896257376'),('ismamor','+59895213930'),('ivancorcoles','+59891154609'),('javiruiz','+59898116923'),('jenialo','+59897610672'),('jesusmoreno','+59898629052'),('jorgenuñez','+59897575301'),('joseantonio','+59899246357'),('josemiguel','+59893171486'),('juancarlos','+59896631923'),('juanjose','+59895601522'),('kevinxd7722','+59895401349'),('laurisantini10','+59895784170'),('leonle','+59899254045'),('lionuñez','+59898885222'),('luisfigo','+59898729619'),('manuelena','+59896171847'),('mariagon','+59891833257'),('mariallanos','+59897894900'),('mariarosario','+59894699521'),('marmat','+59894334907'),('maxilois2002','+59895401340'),('mayzafer30','+59897444745'),('mercedesvalero','+59895945924'),('nachitopi','+59896746413'),('pablopeñeirua','+59897714217'),('pascualtebar','+59896841362'),('pilarmaria','+59899383872'),('rafaaf','+59894635099'),('rocioalicia','+59896456629'),('rociopardo','+59898863805'),('rodriribero','+59893361996'),('rosamaria','+59894503033'),('rubencollado','+59899804275'),('santana_s','+59895846135'),('santijv','+59891846739'),('selepintos','+59899692173'),('veraort','+59897866728'),('viarmartin','+59893722996');
/*!40000 ALTER TABLE `Tels_Usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Usuario`
--

DROP TABLE IF EXISTS `Usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Usuario` (
  `nombreUsuario` varchar(100) NOT NULL,
  `Cedula` char(8) NOT NULL,
  `Nombre1` varchar(100) NOT NULL,
  `Nombre2` varchar(100) DEFAULT NULL,
  `Apellido1` varchar(100) NOT NULL,
  `Apellido2` varchar(100) DEFAULT NULL,
  `Correo` varchar(100) NOT NULL,
  `fNacimiento` date NOT NULL,
  `Calle` varchar(100) NOT NULL,
  `Numero` int(10) NOT NULL,
  `idCiudad` int(10) NOT NULL,
  PRIMARY KEY (`nombreUsuario`),
  UNIQUE KEY `Cedula` (`Cedula`),
  UNIQUE KEY `Numero` (`Numero`),
  KEY `idCiudad` (`idCiudad`),
  CONSTRAINT `Usuario_ibfk_1` FOREIGN KEY (`idCiudad`) REFERENCES `Ciudad` (`idCiudad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Usuario`
--

LOCK TABLES `Usuario` WRITE;
/*!40000 ALTER TABLE `Usuario` DISABLE KEYS */;
INSERT INTO `Usuario` VALUES ('abiaraujo','18543984','Abigail','Macarena','Araujo','Ibañez','abigailaraujo@gmail.com','2003-10-04','Av. España',1823,42),('agusblanco','51234215','Agustina',' ','Buzon','Blanco','agusblanco4950@gmail.com','1979-06-30','Eduardo Acevedo',2131,5),('alegarrido','65453442','Alejandro',' ','Garrido',' ','alegarrido@hotmail.com','1995-01-05','Ana monterroso',4562,3),('aleperez','58410393','Alejando',' ','Perez',' ','aleperezsi1010@gmail.com','1995-10-10','Calle3',2348,4),('alfogil','51541424','Alfonos',' ','Gil','Suarez','alfonsogilsuarez@gmail.com','1990-07-08','Daniel Muñoz',5814,1),('anabelen','51247111','Ana','Belen','Blazquez','Alarcon','anabelenblazquez@gmail.com','1980-12-12','Artigas',6345,56),('andresantonio','25235433','Andres','Antonio','Castillo','Cano','andresantioniocano@gmail.com','2000-06-16','Av.Rivera',5552,2),('beatrizcebrian','51312315','Beatriz','Julia','Cebrian','Rodenas','beatrizjuliacebrian@gmail.com','1992-12-01','Diosa nieva',1451,48),('brzsuarez','11111111','Bruno',' ','Suarez',' ','brunosuarez@gmail.com','2003-01-10','Gral. Flores',2222,50),('chrislois','22221111','Christian','Javier','Lois','Priore','christianjavierlois@gmail.com','1991-11-02','Acevedo Diaz',6677,1),('ciro210','57982341','Ciro',' ','Vitnizcki',' ','ciro210@gmail.com','1960-02-22','San Miguel',1980,36),('davidloz','52419412','David',' ','Lozano','Muñoz','davidlozanomuñoz@gmail.com','1997-01-28','Calle2',2349,4),('diegocalero','51284138','Diego',' ','Calero','Vaz','diegocalero@gmail.com','1991-11-11','Maria serena',1313,47),('emaoca','88888888','Emanuel','Rodrigo','Montes','De oca','emadeoca@gmail.com','1988-10-30','Acevedo Diaz',5577,1),('enridi10','56980309','Enrique','Emannuel','Diaz','Dominguez','enriquedominguez@gmail.com','1971-03-03','Maria del Rosario',8341,34),('enzoanto11','52137657','Enzo',' ','Antonini','Carballo','enzoantonini11@gmail.com','2000-12-19','San patricio',8765,3),('faqgarcia','17891001','Facundo','Antonio','Garcia',' ','facugarcia@gmail.com','2001-08-10','Av. Rivadalvia',4040,7),('faqmart40','52888826','Facundo','Enrique','Martinez','Ibañez','faqmartinez20@gmail.com','2002-11-23','Camino domingo arena',2537,4),('ferpais','47891011','Fernando',' ','Pais',' ','fernandopais@gmail.com','2002-07-16','Av 8 de Octubre',1010,3),('ferserranodiaz','54534423','Fernando',' ','Serrano','Diaz','fernandoserranodiaz@gmail.com','2002-11-11','Ana monterroso',4563,3),('franbica','99999999','Franco',' ','Bica',' ','francobica@gmail.com','2002-08-01','18 de julio',1889,3),('franjose','51248121','Francisco','Jose','Ortiz','Valero','franjoseortiz@gmail.com','1999-12-12','Maria vecerra',1731,44),('franlopez','51341032','Francisco','Angel','Lopez',' ','franlopez50@gmail.com','1960-01-01','Lavalleja',4123,53),('galocolon','42145324','Galo','Colon','Rodriguez',' ','galitocolon@gmail.com','1990-02-02','Ana monterroso',4555,3),('giulicorr','44444444','Giuliana','Noelia','Corrales',' ','giulianacorrales@gmail.com','2003-02-26','Km29 interlbarnearia',6666,8),('gonza10','59865944','Gonzalo',' ','Ramirez','Dos dias','gonzaarami@gmail.com','1999-10-17','Ferrer serra',1554,1),('irenepaula','12841231','Irene','Paula','Rodenas','Alarcon','irenepaularodenas@gmail.com','1992-01-02','Lisboa',5241,5),('ismamor','66666666','Ismael','Javier','Morales','Suarez','ismaelmorales@gmail.com','1978-02-16','Av. Soca',8888,27),('ivancorcoles','34346332','Ivan',' ','Corcoles','Rodriguez','ivancrcolesrodriguez@gmail.com','2002-09-22','Reona',6835,20),('javiruiz','58413203','Javier','Manuel','Ruiz','Hernandez','javihernandez@gmail.com','1996-10-10','Juan Paullier',8723,4),('jenialo','12382172','Jennifer','Antonella','Alfonso','Rodriguez','jenialonso@gmail.com','2002-10-22','Av.Rivera',5485,3),('jesusmoreno','41847512','Jesus','Mauricio','Moreno','Gomez','jesusmoreno@gmail.com','2002-10-15','Libertador',1312,3),('jorgenuñez','51341234','Jorge',' ','Nuñez',' ','jorgitonuñez@gmail.com','1995-02-10','18 de Julio',1283,3),('joseantonio','48131282','Jose','Antonio','Navarro','Serrano','joseantonionavarro@gmail.com','2004-02-28','Malvin',1571,4),('josemiguel','51347123','Jose','Miguel','Bellasteros',' ','josemiguelbellasteros@gmail.com','1999-12-28','Requena',5352,5),('juancarlos','52543321','Juan','Carlos','Seaz','Hernandez','juancarloshernandez@gmail.com','1995-01-05','Gral. Flores',5345,50),('juanjose','59129348','Juan','Jose','Martinez','Antonini','juanjose@gmail.com','1998-05-28','Bv. Artigas',2000,1),('kevinxd7722','54120982','Kevin','Mathew','Anadon',' ','kevin7722@gmail.com','1966-07-07','Av.Bolivia',4356,30),('laurisantini10','10101010','Laureano',' ','Santini','Osvaldo','laurisantini1010@gmail.com','1966-02-26','Gral. Flores',1111,50),('leonle','11112222','Leon','Gabriel','Levrero',' ','leonlevrero@gmail.com','1966-05-10','San Miguel',1122,36),('lionuñez','53243265','Lionel',' ','Nuñez','Requena','lionelnueñez@gmail.com','1990-01-07','Goes',5234,1),('luisfigo','58714102','Luis',' ','Figo',' ','luisfigo10@gmail.com','2002-01-20','Acevedo diaz',1414,1),('manuelena','35435352','Manuela','Elena','Morcillo','Suarez','manuelenamorcillo@gmail.com','1981-05-29','Miguelete',3452,3),('mariagon','58341942','Maria','Dolores','Gonzales','Martinez','mariadoloresgonzales@gmail.com','2006-02-01','Colonia',2421,1),('mariallanos','44354342','Maria','Llanos','Picazo',' ','mariallanos@gmail.com','1999-01-01','Av. Rivera',5454,2),('mariarosario','51247141','Maria','Rosario','Collado',' ','mariadelrosariocollado@gmail.com','1950-12-30','Maria doña',5623,3),('marmat','22223333','Martin','Matias','Suarez',' ','marmat@gmail.com','1988-04-24','Gral. Flores',2211,50),('maxilois2002','52541757','Maximiliano','Andree','Lois','Priore','maxilois2002@gmail.com','1998-10-22','Acevedo Diaz',1665,1),('mayzafer30','57891234','Mayza','Daniela','Ferreira',' ','danielahcp@gmail.com','1998-03-01','Gral. Roberto',9876,10),('mercedesvalero','21423454','Mercedes',' ','Valero',' ','mercedesvalero1010@gmail.com','1995-10-10','Anima',5382,1),('nachitopi','22222222','Juan','Ignacio','Pirez','Mohas','juanmohas@gmail.com','2000-09-22','Gral. Flores',3333,50),('pablopeñeirua','58123812','Pablo','Andres','Peñeirua','Diaz','pablitopeñe@gmail.com','1999-05-22','Libreria',4441,13),('pascualtebar','51234125','Pascual',' ','Tebar','Moya','pascualtebarmoya@gmail.com','1992-10-22','Arenas',4041,5),('pilarmaria','58134013','Maria','Pilar','Da costa','De los santos','pilardelossantos@gmail.com','1995-03-06','La paz',9100,6),('rafaaf','41312131','Rafael',' ','Anadon','Ferreira','rafaelaf@gmail.com','2006-01-29','Av. Bolivia',4141,30),('rocioalicia','12423744','Rocio','Alicia','Moya','Ortega','rocrioalicia@gmail.com','1981-05-30','San bernardo',5551,6),('rociopardo','12523527','Rocio',' ','Pardo',' ','rociopardo@gmail.com','2002-08-25','Arenas',4042,5),('rodriribero','55555555','Rodrigo',' ','Ribero','Rodriguez','rodrigoribero@gmail.com','1999-12-31','Maria Teresa',7777,60),('rosamaria','54343534','Rosa','Maria','Marin','Torres','rosamaria@gmail.com','1988-01-31','Nueva Palmira',3451,3),('rubencollado','51234152','Ruben',' ','Collado',' ','ruben10collado@gmail.com','1995-02-10','Maria Teresa',7779,60),('santana_s','54560100','Silvina','Valeria','Santana','Vaz','valeriavaz@gmail.com','2002-10-06','18 de Julio',1776,3),('santijv','77777777','Santiago','Manuel','Larzabal','Gonzales','santijv@gmail.com','2002-11-11','Jose pedro varela',9999,60),('selepintos','63423482','Selena',' ','Pintos','Ramirez','selepintos1012@gmail.com','1998-09-10','Av. San carlos',8232,9),('veraort','33333333','Vera',' ','Ortega',' ','veraortega@gmail.com','2002-02-02','San bernardo',5555,6),('viarmartin','42450126','Martin',' ','Viar',' ','martinviar@gmail.com','1990-10-10','Av. Bolivia',8456,26), ('parrilla10','51243526','Joaquin',' ','Parrilla',' ','joacoparrilla@gmail.com','2002-12-11','Av.Uruguay',5657,1);
/*!40000 ALTER TABLE `Usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Valida`
--

DROP TABLE IF EXISTS `Valida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Valida` (
  `nombreMedico` varchar(100) NOT NULL,
  `idAutodiagnostico` int(10) NOT NULL,
  KEY `idAutodiagnostico` (`idAutodiagnostico`),
  KEY `nombreMedico` (`nombreMedico`),
  CONSTRAINT `Valida_ibfk_1` FOREIGN KEY (`idAutodiagnostico`) REFERENCES `Auto_Diagnostico` (`idAutodiagnostico`),
  CONSTRAINT `Valida_ibfk_2` FOREIGN KEY (`nombreMedico`) REFERENCES `Usuario` (`nombreUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Valida`
--

LOCK TABLES `Valida` WRITE;
/*!40000 ALTER TABLE `Valida` DISABLE KEYS */;
INSERT INTO `Valida` VALUES ('abiaraujo',1),('agusblanco',2),('alegarrido',3),('aleperez',4),('alfogil',5),('anabelen',6),('andresantonio',7),('beatrizcebrian',8),('brzsuarez',9),('chrislois',10),('ciro210',11),('davidloz',12),('diegocalero',13),('emaoca',14),('enridi10',15),('faqgarcia',16),('abiaraujo',17),('agusblanco',18),('alegarrido',19),('aleperez',20),('alfogil',21),('alfogil',22),('anabelen',23),('andresantonio',24),('beatrizcebrian',25),('brzsuarez',26),('chrislois',27),('ciro210',28),('davidloz',29),('diegocalero',30),('emaoca',31),('enridi10',32),('faqgarcia',33),('abiaraujo',34),('agusblanco',35),('alegarrido',36),('aleperez',37),('alfogil',38),('anabelen',39),('andresantonio',40),('beatrizcebrian',41),('brzsuarez',42),('chrislois',43),('ciro210',44),('davidloz',45),('diegocalero',46),('emaoca',47),('enridi10',48),('faqgarcia',49),('abiaraujo',50);
/*!40000 ALTER TABLE `Valida` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-11-04  6:39:23
