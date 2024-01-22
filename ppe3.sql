-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 22 jan. 2024 à 21:12
-- Version du serveur : 8.2.0
-- Version de PHP : 8.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `ppe3`
--

-- --------------------------------------------------------

--
-- Structure de la table `admin`
--

DROP TABLE IF EXISTS `admin`;
CREATE TABLE IF NOT EXISTS `admin` (
  `id_adm` int NOT NULL AUTO_INCREMENT,
  `login_adm` varchar(50) NOT NULL,
  `password_adm` varchar(250) NOT NULL,
  `first_connection_adm` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id_adm`),
  UNIQUE KEY `login_adm` (`login_adm`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `admin`
--

INSERT INTO `admin` (`id_adm`, `login_adm`, `password_adm`, `first_connection_adm`) VALUES
(1, 'serv_davadm', '$2a$13$CMUgLD7q10tNgg/sjjcFpusUbowtR5.waVp717jhYvq8BB42oieza', 0);

-- --------------------------------------------------------

--
-- Structure de la table `allergie`
--

DROP TABLE IF EXISTS `allergie`;
CREATE TABLE IF NOT EXISTS `allergie` (
  `id_all` int NOT NULL AUTO_INCREMENT,
  `libelle_all` varchar(50) NOT NULL,
  PRIMARY KEY (`id_all`),
  UNIQUE KEY `libelle_all` (`libelle_all`)
) ENGINE=InnoDB AUTO_INCREMENT=88 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `allergie`
--

INSERT INTO `allergie` (`id_all`, `libelle_all`) VALUES
(62, 'Abricots'),
(22, 'Acariens'),
(26, 'Ail'),
(37, 'Amandes'),
(30, 'Ananas'),
(67, 'Anchois'),
(3, 'Arachides'),
(24, 'Araignée'),
(49, 'Artichaut'),
(2, 'Aspirine'),
(53, 'Avocat'),
(83, 'Baies de goji'),
(15, 'Blé'),
(60, 'Bleuets'),
(65, 'Brocoli'),
(36, 'Cacahuètes'),
(46, 'Café'),
(77, 'Cannelle'),
(43, 'Carotte'),
(27, 'Céleri'),
(71, 'Céréales complètes'),
(55, 'Champignons'),
(86, 'Chat'),
(87, 'Chien'),
(25, 'Chocolat'),
(74, 'Chocolat noir'),
(58, 'Chou-fleur'),
(39, 'Ciboulette'),
(41, 'Citron'),
(31, 'Coquillages'),
(57, 'Courge'),
(78, 'Cranberries'),
(80, 'Crevettes'),
(44, 'Cumin'),
(72, 'Échalotes'),
(66, 'Épinards'),
(20, 'Fraise'),
(52, 'Gingembre'),
(79, 'Graines de tournesol'),
(73, 'Haricots verts'),
(68, 'Huîtres'),
(17, 'Kiwi'),
(9, 'Lactose'),
(35, 'Lait'),
(70, 'Lait de chèvre'),
(8, 'Latex'),
(64, 'Lentilles'),
(29, 'Maïs'),
(75, 'Mangue'),
(32, 'Melon'),
(45, 'Menthe'),
(81, 'Miel'),
(12, 'Morphine'),
(23, 'Moule'),
(69, 'Moutarde'),
(16, 'Noix'),
(18, 'Oeufs'),
(50, 'Orge'),
(76, 'Pamplemousse'),
(56, 'Papaye'),
(61, 'Pêches'),
(10, 'Penicillamine'),
(1, 'Penicilline'),
(47, 'Piment'),
(84, 'Pistaches'),
(28, 'Poisson'),
(38, 'Poivre'),
(14, 'Pollen'),
(33, 'Pomme'),
(42, 'Pomme de terre'),
(34, 'Poussière'),
(63, 'Prunes'),
(59, 'Radis'),
(48, 'Raisin'),
(51, 'Riz'),
(54, 'Sésame'),
(19, 'Soja'),
(6, 'Sulfamides'),
(82, 'Sulfites'),
(40, 'Thon'),
(21, 'Tomate'),
(85, 'Vinaigre balsamique');

-- --------------------------------------------------------

--
-- Structure de la table `antecedent`
--

DROP TABLE IF EXISTS `antecedent`;
CREATE TABLE IF NOT EXISTS `antecedent` (
  `id_ant` int NOT NULL AUTO_INCREMENT,
  `libelle_ant` varchar(50) NOT NULL,
  `id_pat` int NOT NULL,
  PRIMARY KEY (`id_ant`),
  KEY `Antecedent_Patient_FK` (`id_pat`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `antecedent`
--

INSERT INTO `antecedent` (`id_ant`, `libelle_ant`, `id_pat`) VALUES
(1, 'Hypertension', 1),
(2, 'Diabète', 2),
(3, 'Asthme', 3),
(14, 'Hypoglycemie', 11);

-- --------------------------------------------------------

--
-- Structure de la table `etre`
--

DROP TABLE IF EXISTS `etre`;
CREATE TABLE IF NOT EXISTS `etre` (
  `id_all` int NOT NULL,
  `id_pat` int NOT NULL,
  KEY `etre_Patient0_FK` (`id_pat`),
  KEY `id_all` (`id_all`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `etre`
--

INSERT INTO `etre` (`id_all`, `id_pat`) VALUES
(1, 1),
(2, 2),
(3, 3),
(8, 10),
(87, 11);

-- --------------------------------------------------------

--
-- Structure de la table `incompatible`
--

DROP TABLE IF EXISTS `incompatible`;
CREATE TABLE IF NOT EXISTS `incompatible` (
  `id_medic` int NOT NULL,
  `id_medic_Medicament` int DEFAULT NULL,
  `id_all` int DEFAULT NULL,
  `id_ant` int DEFAULT NULL,
  KEY `incompatible_Medicament0_FK` (`id_medic_Medicament`),
  KEY `incompatible_Allergie1_FK` (`id_all`),
  KEY `incompatible_Antecedent2_FK` (`id_ant`),
  KEY `id_medic` (`id_medic`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `incompatible`
--

INSERT INTO `incompatible` (`id_medic`, `id_medic_Medicament`, `id_all`, `id_ant`) VALUES
(1, NULL, 2, 1),
(2, NULL, 1, NULL),
(3, NULL, NULL, NULL),
(3, 1, NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `medecin`
--

DROP TABLE IF EXISTS `medecin`;
CREATE TABLE IF NOT EXISTS `medecin` (
  `id_med` int NOT NULL AUTO_INCREMENT,
  `nom_med` varchar(50) NOT NULL,
  `prenom_med` varchar(50) NOT NULL,
  `naissance_med` date NOT NULL,
  `login_med` varchar(50) NOT NULL,
  `password_med` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `first_connection_med` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id_med`),
  UNIQUE KEY `login_med` (`login_med`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `medecin`
--

INSERT INTO `medecin` (`id_med`, `nom_med`, `prenom_med`, `naissance_med`, `login_med`, `password_med`, `first_connection_med`) VALUES
(1, 'Dupont', 'Jean', '1980-01-15', 'jean.dupont', '$2a$13$vDAaulo.rZ8BXmdKYAmHo.fsBVSDm4MsRQUAEvj3wrFB93gcY1Sg6', 1),
(2, 'Martin', 'Alice', '1975-05-22', 'alice.martin', '$2a$13$.62MFyMyx/r7lsXxWuTIv.K9T/WrrRFujZQ90ySpuozKTUcadgYXe', 1),
(3, 'Lefevre', 'Pierre', '1990-08-10', 'pierre.lefevre', 'mdp789', 1),
(4, 'Girard', 'Sophie', '1983-07-20', 'sophie.girard', 'mdp123', 1),
(5, 'Lemoine', 'Thomas', '1970-12-05', 'thomas.lemoine', 'pass456', 1),
(6, 'Robert', 'Isabelle', '1988-03-15', 'isabelle.robert', 'secret789', 1);

-- --------------------------------------------------------

--
-- Structure de la table `medicament`
--

DROP TABLE IF EXISTS `medicament`;
CREATE TABLE IF NOT EXISTS `medicament` (
  `id_medic` int NOT NULL AUTO_INCREMENT,
  `libelle_medic` varchar(50) NOT NULL,
  `contre_indication_medic` varchar(100) DEFAULT NULL,
  `qte_medic` int NOT NULL,
  PRIMARY KEY (`id_medic`),
  UNIQUE KEY `libelle_medic` (`libelle_medic`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `medicament`
--

INSERT INTO `medicament` (`id_medic`, `libelle_medic`, `contre_indication_medic`, `qte_medic`) VALUES
(1, 'Paracétamol', 'Allergie à l\'aspirine', 100),
(2, 'Amoxicilline', 'Hypersensibilité à la pénicilline', 50),
(3, 'Ventoline', 'Aucune', 30),
(4, 'Ibuprofène', 'Aucune', 80),
(5, 'Doliprane', 'Aucune', 120),
(6, 'Omeprazole', 'Grossesse', 50),
(7, 'Sertraline', 'Allergie à la sertraline', 30),
(8, 'Atorvastatine', 'Maladie du foie', 40),
(9, 'Insuline', 'Hypoglycémie', 20);

-- --------------------------------------------------------

--
-- Structure de la table `ordonnance`
--

DROP TABLE IF EXISTS `ordonnance`;
CREATE TABLE IF NOT EXISTS `ordonnance` (
  `id_ord` int NOT NULL AUTO_INCREMENT,
  `posologie_ord` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `date_creation_ord` datetime NOT NULL,
  `duree_ord` int NOT NULL,
  `instruction_ord` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `id_med` int NOT NULL,
  `id_pat` int NOT NULL,
  `id_medic` int NOT NULL,
  PRIMARY KEY (`id_ord`),
  KEY `Ordonnance_Medecin_FK` (`id_med`),
  KEY `Ordonnance_Patient0_FK` (`id_pat`),
  KEY `Ordonnance_Medicament1_FK` (`id_medic`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `ordonnance`
--

INSERT INTO `ordonnance` (`id_ord`, `posologie_ord`, `date_creation_ord`, `duree_ord`, `instruction_ord`, `id_med`, `id_pat`, `id_medic`) VALUES
(5, 'test', '2024-01-16 15:02:42', 14, 'test', 1, 9, 3);

-- --------------------------------------------------------

--
-- Structure de la table `patient`
--

DROP TABLE IF EXISTS `patient`;
CREATE TABLE IF NOT EXISTS `patient` (
  `id_pat` int NOT NULL AUTO_INCREMENT,
  `nom_pat` varchar(50) NOT NULL,
  `prenom_pat` varchar(50) NOT NULL,
  `sexe_pat` varchar(1) NOT NULL,
  `naissance_pat` date NOT NULL,
  `no_secu_pat` bigint NOT NULL,
  PRIMARY KEY (`id_pat`),
  UNIQUE KEY `no_secu_pat` (`no_secu_pat`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `patient`
--

INSERT INTO `patient` (`id_pat`, `nom_pat`, `prenom_pat`, `sexe_pat`, `naissance_pat`, `no_secu_pat`) VALUES
(1, 'Dubois', 'Sophie', 'F', '1985-03-28', 233456789012),
(2, 'Moreau', 'Marc', 'M', '1972-11-14', 187654321098),
(3, 'Roux', 'Catherine', 'F', '1995-06-05', 256789012345),
(9, 'Bertrand', 'Marie', 'F', '1982-09-10', 245678901234),
(10, 'Gauthier', 'Luc', 'M', '1978-04-15', 167890123456),
(11, 'Martin', 'Camille', 'F', '1993-12-20', 289012345678),
(12, 'Leclercq', 'Antoine', 'M', '1989-06-25', 101234567890),
(13, 'Fournier', 'Julie', 'F', '1975-02-05', 223456789012);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `antecedent`
--
ALTER TABLE `antecedent`
  ADD CONSTRAINT `Antecedent_Patient_FK` FOREIGN KEY (`id_pat`) REFERENCES `patient` (`id_pat`);

--
-- Contraintes pour la table `etre`
--
ALTER TABLE `etre`
  ADD CONSTRAINT `etre_Allergie_FK` FOREIGN KEY (`id_all`) REFERENCES `allergie` (`id_all`),
  ADD CONSTRAINT `etre_Patient0_FK` FOREIGN KEY (`id_pat`) REFERENCES `patient` (`id_pat`);

--
-- Contraintes pour la table `incompatible`
--
ALTER TABLE `incompatible`
  ADD CONSTRAINT `incompatible_Allergie1_FK` FOREIGN KEY (`id_all`) REFERENCES `allergie` (`id_all`),
  ADD CONSTRAINT `incompatible_Antecedent2_FK` FOREIGN KEY (`id_ant`) REFERENCES `antecedent` (`id_ant`),
  ADD CONSTRAINT `incompatible_Medicament0_FK` FOREIGN KEY (`id_medic_Medicament`) REFERENCES `medicament` (`id_medic`),
  ADD CONSTRAINT `incompatible_Medicament_FK` FOREIGN KEY (`id_medic`) REFERENCES `medicament` (`id_medic`);

--
-- Contraintes pour la table `ordonnance`
--
ALTER TABLE `ordonnance`
  ADD CONSTRAINT `Ordonnance_Medecin_FK` FOREIGN KEY (`id_med`) REFERENCES `medecin` (`id_med`),
  ADD CONSTRAINT `Ordonnance_Medicament1_FK` FOREIGN KEY (`id_medic`) REFERENCES `medicament` (`id_medic`),
  ADD CONSTRAINT `Ordonnance_Patient0_FK` FOREIGN KEY (`id_pat`) REFERENCES `patient` (`id_pat`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
