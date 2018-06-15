/*
SQLyog Ultimate v9.02 
MySQL - 5.5.5-10.1.29-MariaDB : Database - test
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
/*Table structure for table `person` */

CREATE TABLE `person` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Apellidos` varchar(50) DEFAULT NULL,
  `Nombres` varchar(50) DEFAULT NULL,
  `StarDate` datetime DEFAULT NULL,
  `EndDate` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

/*Data for the table `person` */

insert  into `person`(`ID`,`Apellidos`,`Nombres`,`StarDate`,`EndDate`) values (1,'Jimenez','Victor','2000-05-05 00:00:00','2010-05-05 00:00:00'),(2,'Jimenez','Carlos','2001-06-01 00:00:00','2010-05-05 00:00:00'),(3,'Jimenez','Carlos','2001-06-01 00:00:00','2010-05-05 00:00:00'),(4,'Jimenez','Carlos','2001-06-01 00:00:00','2010-05-05 00:00:00'),(5,'Jimenez','kike','2001-06-01 00:00:00','2010-05-05 00:00:00'),(6,'Jimenez','kike','2001-06-01 00:00:00','2010-05-05 00:00:00'),(7,'Jimenez','kike','2001-06-01 00:00:00','2010-05-05 00:00:00');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
