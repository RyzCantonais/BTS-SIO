-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 19 oct. 2023 à 11:55
-- Version du serveur : 5.7.36
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `labogsb`
--

-- --------------------------------------------------------

--
-- Structure de la table `incident`
--

DROP TABLE IF EXISTS `incident`;
CREATE TABLE IF NOT EXISTS `incident` (
  `Id_Incident` int(11) NOT NULL AUTO_INCREMENT,
  `Probleme` varchar(50) DEFAULT '',
  `Travail_realise` varchar(50) DEFAULT '',
  `Date_declaration` date DEFAULT NULL,
  `Date_prise_en_charge` date DEFAULT NULL,
  `Date_de_fin` date DEFAULT NULL,
  `Matricule_Perso` varchar(50) NOT NULL,
  `Id_Materiel` int(11) NOT NULL,
  `Matricule_Tech` varchar(50) NOT NULL,
  `Etat` int(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id_Incident`),
  KEY `Matricule_1` (`Matricule_Tech`),
  KEY `Matricule` (`Matricule_Perso`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `incident`
--

INSERT INTO `incident` (`Id_Incident`, `Probleme`, `Travail_realise`, `Date_declaration`, `Date_prise_en_charge`, `Date_de_fin`, `Matricule_Perso`, `Id_Materiel`, `Matricule_Tech`, `Etat`) VALUES
(1, 'Blackscreen', 'Redémarrage', '2023-10-05', '2023-10-07', '2023-10-09', 'LETH072', 1, 'DUMA033', 0),
(2, 'Bluescreen', 'MAJ pilotes', '2023-10-01', '2023-10-02', '2023-10-03', 'MAP005', 2, 'DUMA033', 0),
(3, 'Connexion', 'Parametre ajustes', '2023-10-07', '2023-10-08', '2023-10-09', 'LEMI101', 3, 'BESO019', 0),
(4, 'zaezaeza', NULL, '2023-10-12', NULL, NULL, 'MAP005', 1, 'BESO019', 0),
(5, 'Test de ouf ', NULL, '2023-10-12', NULL, NULL, 'MAP005', 1, 'BESO019', 0),
(6, 'azezae', NULL, '2023-10-12', NULL, NULL, 'MAP005', 1, 'BESO019', 0),
(7, 'zaezaezae', '', '2023-10-12', NULL, NULL, 'LETH072', 1, 'BESO019', 0),
(8, 'zaezaezae', '', '2023-10-12', NULL, NULL, 'BESO019', 1, 'BESO019', 0),
(9, 'zaezaezae', NULL, '2023-10-19', NULL, NULL, 'LETH072', 1, 'BESO019', 0),
(10, 'zaezaezae', NULL, '2023-10-19', NULL, NULL, 'LEMI101', 1, 'BESO019', 0),
(11, 'zaezaezae', NULL, '2023-10-19', NULL, NULL, 'BESO019', 1, 'BESO019', 0),
(12, 'testeeaezaezaezae', NULL, '2023-10-19', NULL, NULL, 'MAP005', 1, 'BESO019', 0),
(13, 'test zaezaezaezaezaferg', NULL, '2023-10-19', NULL, NULL, 'BESO019', 1, 'BESO019', 1),
(14, 'test2', NULL, '2023-10-19', NULL, NULL, 'BESO019', 1, 'BESO019', 1);

-- --------------------------------------------------------

--
-- Structure de la table `materiel`
--

DROP TABLE IF EXISTS `materiel`;
CREATE TABLE IF NOT EXISTS `materiel` (
  `Id_Materiel` int(11) NOT NULL AUTO_INCREMENT,
  `Processeur` varchar(50) DEFAULT NULL,
  `Memoire` int(11) DEFAULT NULL,
  `Disque` varchar(50) DEFAULT NULL,
  `Logiciels_installes` varchar(50) DEFAULT NULL,
  `Date_d_achat` date DEFAULT NULL,
  `Garantie` varchar(50) DEFAULT NULL,
  `Fournisseur` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id_Materiel`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `materiel`
--

INSERT INTO `materiel` (`Id_Materiel`, `Processeur`, `Memoire`, `Disque`, `Logiciels_installes`, `Date_d_achat`, `Garantie`, `Fournisseur`) VALUES
(1, 'Intel', 12, 'SSD', 'WAMP, VSCode', '2023-10-18', 'NON', 'Pablo'),
(2, 'AMD', 32, 'SSD', 'Looping, Chrome', '2023-10-04', 'NON', 'Juan'),
(3, 'AMD', 12, 'HDD', 'Linux, Windows', '2022-10-17', 'OUI', 'Logitech'),
(4, 'AMD', 32, 'SSD', 'Wamp, ijfojfd', '2023-10-11', '1', 'Moi');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `Matricule` varchar(50) NOT NULL,
  `Mot_de_passe` varchar(50) DEFAULT NULL,
  `Date_d_embauche` date DEFAULT NULL,
  `Region_carriere` varchar(50) DEFAULT NULL,
  `Responsable` tinyint(1) NOT NULL,
  PRIMARY KEY (`Matricule`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`Matricule`, `Mot_de_passe`, `Date_d_embauche`, `Region_carriere`, `Responsable`) VALUES
('BESO019', 'SB@1907', '2021-02-08', 'Normandie', 0),
('DUMA033', 'MD@3303', '2020-11-12', 'Bretagne', 0),
('GAMA042', 'MG@4206', '2021-08-30', 'Occitanie', 0),
('LEMI101', 'ML@1011', '2021-07-25', 'Hauts-de-France', 0),
('LETH072', 'TL@7209', '2019-09-15', 'Pays de la Loire', 0),
('MAP005', 'PM@0512', '2022-03-10', 'Provence-Alpes-Côte d\'Azur', 0),
('SMA027', 'AS@2709', '2019-11-20', 'Auvergne-Rhône-Alpes', 1);

-- --------------------------------------------------------

--
-- Structure de la table `techniciens`
--

DROP TABLE IF EXISTS `techniciens`;
CREATE TABLE IF NOT EXISTS `techniciens` (
  `Matricule` varchar(50) NOT NULL,
  `Intervention` date DEFAULT NULL,
  `Formation` varchar(50) DEFAULT NULL,
  `Competences` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Matricule`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `techniciens`
--

INSERT INTO `techniciens` (`Matricule`, `Intervention`, `Formation`, `Competences`) VALUES
('BESO019', '2023-10-11', 'BTS SIO', 'Linux'),
('DUMA033', '2023-10-19', 'BTS SIO', 'Windows'),
('GAMA042', '2023-10-25', 'BTS SIO', 'MAC');

-- --------------------------------------------------------

--
-- Structure de la table `visiteurs`
--

DROP TABLE IF EXISTS `visiteurs`;
CREATE TABLE IF NOT EXISTS `visiteurs` (
  `Matricule` varchar(50) NOT NULL,
  `Objectif` int(11) DEFAULT NULL,
  `Prime` int(11) DEFAULT NULL,
  `Avantages` varchar(50) DEFAULT NULL,
  `Budget` int(11) DEFAULT NULL,
  `Responsable` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Matricule`),
  KEY `Responsable` (`Responsable`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `visiteurs`
--

INSERT INTO `visiteurs` (`Matricule`, `Objectif`, `Prime`, `Avantages`, `Budget`, `Responsable`) VALUES
('LEMI101', 1, 100, 'Fort', 1200, 'SMA027'),
('LETH072', 3, 300, 'Intelligent', 2100, 'SMA027'),
('MAP005', 2, 200, 'Rapide', 1800, 'SMA027');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `incident`
--
ALTER TABLE `incident`
  ADD CONSTRAINT `incident_ibfk_1` FOREIGN KEY (`Matricule_Tech`) REFERENCES `techniciens` (`Matricule`),
  ADD CONSTRAINT `incident_ibfk_2` FOREIGN KEY (`Matricule_Perso`) REFERENCES `personnel` (`Matricule`);

--
-- Contraintes pour la table `techniciens`
--
ALTER TABLE `techniciens`
  ADD CONSTRAINT `techniciens_ibfk_1` FOREIGN KEY (`Matricule`) REFERENCES `personnel` (`Matricule`);

--
-- Contraintes pour la table `visiteurs`
--
ALTER TABLE `visiteurs`
  ADD CONSTRAINT `visiteurs_ibfk_1` FOREIGN KEY (`Matricule`) REFERENCES `personnel` (`Matricule`),
  ADD CONSTRAINT `visiteurs_ibfk_2` FOREIGN KEY (`Responsable`) REFERENCES `personnel` (`Matricule`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
