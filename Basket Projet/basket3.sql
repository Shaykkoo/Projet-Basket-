-- phpMyAdmin SQL Dump
-- version 3.3.9.2
-- http://www.phpmyadmin.net
--
-- Serveur: 127.0.0.1
-- Généré le : Mer 11 Octobre 2023 à 04:33
-- Version du serveur: 5.5.10
-- Version de PHP: 5.3.6

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données: `basket3`
--

-- --------------------------------------------------------

--
-- Structure de la table `equipe`
--

CREATE TABLE IF NOT EXISTS `equipe` (
  `idEquipe` int(11) NOT NULL AUTO_INCREMENT,
  `nomEquipe` varchar(80) NOT NULL,
  PRIMARY KEY (`idEquipe`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Contenu de la table `equipe`
--


-- --------------------------------------------------------

--
-- Structure de la table `joue`
--

CREATE TABLE IF NOT EXISTS `joue` (
  `idEquipe` int(11) NOT NULL,
  `idUser` int(11) NOT NULL,
  PRIMARY KEY (`idEquipe`,`idUser`),
  KEY `joue_User0_FK` (`idUser`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `joue`
--


-- --------------------------------------------------------

--
-- Structure de la table `participe`
--

CREATE TABLE IF NOT EXISTS `participe` (
  `idSeance` int(11) NOT NULL,
  `idUser` int(11) NOT NULL,
  PRIMARY KEY (`idSeance`,`idUser`),
  KEY `participe_User0_FK` (`idUser`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `participe`
--

INSERT INTO `participe` (`idSeance`, `idUser`) VALUES
(1, 1),
(4, 1),
(6, 1),
(4, 6),
(5, 6),
(6, 6);

-- --------------------------------------------------------

--
-- Structure de la table `poste`
--

CREATE TABLE IF NOT EXISTS `poste` (
  `idPoste` int(11) NOT NULL AUTO_INCREMENT,
  `nomPoste` varchar(80) NOT NULL,
  PRIMARY KEY (`idPoste`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Contenu de la table `poste`
--

INSERT INTO `poste` (`idPoste`, `nomPoste`) VALUES
(1, 'Meneur'),
(2, 'Pivot'),
(3, 'Ailier'),
(4, 'Ailier Fort'),
(5, 'Arrière'),
(6, 'Autre');

-- --------------------------------------------------------

--
-- Structure de la table `seance`
--

CREATE TABLE IF NOT EXISTS `seance` (
  `idSeance` int(11) NOT NULL AUTO_INCREMENT,
  `dateSeance` date NOT NULL,
  PRIMARY KEY (`idSeance`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Contenu de la table `seance`
--

INSERT INTO `seance` (`idSeance`, `dateSeance`) VALUES
(1, '2023-04-19'),
(3, '2023-04-24'),
(4, '2023-05-01'),
(5, '2023-05-08'),
(6, '2023-05-15'),
(7, '2023-05-22');

-- --------------------------------------------------------

--
-- Structure de la table `statutuser`
--

CREATE TABLE IF NOT EXISTS `statutuser` (
  `idStatut` int(11) NOT NULL AUTO_INCREMENT,
  `nomStatut` varchar(80) NOT NULL,
  PRIMARY KEY (`idStatut`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Contenu de la table `statutuser`
--

INSERT INTO `statutuser` (`idStatut`, `nomStatut`) VALUES
(1, 'admin'),
(2, 'coach'),
(3, 'joueur');

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `idUser` int(11) NOT NULL AUTO_INCREMENT,
  `nomUser` varchar(15) NOT NULL,
  `prenomUser` varchar(15) NOT NULL,
  `telUser` int(11) NOT NULL,
  `mailUser` varchar(20) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(15) NOT NULL,
  `idStatut` int(11) NOT NULL,
  `idPoste` int(11) NOT NULL,
  PRIMARY KEY (`idUser`),
  KEY `User_StatutUser_FK` (`idStatut`),
  KEY `User_Poste0_FK` (`idPoste`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Contenu de la table `user`
--

INSERT INTO `user` (`idUser`, `nomUser`, `prenomUser`, `telUser`, `mailUser`, `username`, `password`, `idStatut`, `idPoste`) VALUES
(1, 'Rousseau', 'Liyam', 0, 'lr@gmail.com', 'Liyam', '123', 3, 1),
(5, 'admin', 'admin', 0, '', 'admin', 'admin', 1, 6),
(6, 'coach', 'coach', 0, 'coach@gmail.com', 'coach', '123', 2, 6),
(14, 'Eden', 'Paul', 0, 'EP@gmail.com', 'Paul', '123', 3, 5);

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `joue`
--
ALTER TABLE `joue`
  ADD CONSTRAINT `joue_equipe_FK` FOREIGN KEY (`idEquipe`) REFERENCES `equipe` (`idEquipe`),
  ADD CONSTRAINT `joue_User0_FK` FOREIGN KEY (`idUser`) REFERENCES `user` (`idUser`);

--
-- Contraintes pour la table `participe`
--
ALTER TABLE `participe`
  ADD CONSTRAINT `participe_Seance_FK` FOREIGN KEY (`idSeance`) REFERENCES `seance` (`idSeance`),
  ADD CONSTRAINT `participe_User0_FK` FOREIGN KEY (`idUser`) REFERENCES `user` (`idUser`);

--
-- Contraintes pour la table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `User_Poste0_FK` FOREIGN KEY (`idPoste`) REFERENCES `poste` (`idPoste`),
  ADD CONSTRAINT `User_StatutUser_FK` FOREIGN KEY (`idStatut`) REFERENCES `statutuser` (`idStatut`);
