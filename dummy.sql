-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.4.18-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for spk_takoyaki
CREATE DATABASE IF NOT EXISTS `spk_takoyaki` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `spk_takoyaki`;

-- Dumping structure for table spk_takoyaki.isi
CREATE TABLE IF NOT EXISTS `isi` (
  `Kode` varchar(50) NOT NULL,
  `Alternatif` varchar(50) NOT NULL,
  `C1` double NOT NULL DEFAULT 0,
  `C2` double NOT NULL DEFAULT 0,
  `C3` double NOT NULL DEFAULT 0,
  `C4` double NOT NULL DEFAULT 0,
  `C5` double NOT NULL DEFAULT 0,
  PRIMARY KEY (`Kode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table spk_takoyaki.isi: ~4 rows (approximately)
/*!40000 ALTER TABLE `isi` DISABLE KEYS */;
INSERT INTO `isi` (`Kode`, `Alternatif`, `C1`, `C2`, `C3`, `C4`, `C5`) VALUES
	('A1', 'Menyewa Warehouse Baru', 150, 50, 2, 2, 3),
	('A2', 'Membeli Mobil', 600, 200, 3, 3, 1),
	('A3', 'Modernisasi Peralatan', 250, 15, 2, 1, 3),
	('A4', 'Membangun Gerai Baru', 350, 100, 2, 1, 2);
/*!40000 ALTER TABLE `isi` ENABLE KEYS */;

-- Dumping structure for table spk_takoyaki.login
CREATE TABLE IF NOT EXISTS `login` (
  `user` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `MenuAkses` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table spk_takoyaki.login: ~1 rows (approximately)
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` (`user`, `password`, `MenuAkses`) VALUES
	('rinaldy143', '123', '111111111'),
	('tes', '123', '111111111');
/*!40000 ALTER TABLE `login` ENABLE KEYS */;

-- Dumping structure for table spk_takoyaki.normalisasi
CREATE TABLE IF NOT EXISTS `normalisasi` (
  `NC1` double NOT NULL,
  `NC2` double NOT NULL,
  `NC3` double NOT NULL,
  `NC4` double NOT NULL,
  `NC5` double NOT NULL,
  `Preferensi` double DEFAULT NULL,
  `rank` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table spk_takoyaki.normalisasi: ~0 rows (approximately)
/*!40000 ALTER TABLE `normalisasi` DISABLE KEYS */;
/*!40000 ALTER TABLE `normalisasi` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
