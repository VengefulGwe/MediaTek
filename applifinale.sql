-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 28 mai 2025 à 09:45
-- Version du serveur : 9.1.0
-- Version de PHP : 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : applifinale
--
CREATE DATABASE IF NOT EXISTS applifinale DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
CREATE USER 'admintek'@'%' IDENTIFIED BY 'Gwevil_NEO1';
GRANT USAGE ON *.* TO 'admintek'@'%';
GRANT ALL PRIVILEGES ON `applifinale`.* TO 'admintek'@'%';
USE applifinale;

-- --------------------------------------------------------

--
-- Structure de la table absence
--

DROP TABLE IF EXISTS absence;
CREATE TABLE absence (
  idpersonnel int NOT NULL,
  datedebut datetime NOT NULL,
  datefin datetime DEFAULT NULL,
  idmotif int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table absence
--

INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES
(1, '2024-10-14 05:00:23', '2025-11-02 12:36:59', 4),
(1, '2024-10-22 04:54:50', '2025-08-24 01:25:15', 1),
(2, '2024-06-21 11:44:56', '2025-02-11 06:11:22', 3),
(2, '2024-07-04 01:11:19', '2026-04-01 02:29:31', 1),
(2, '2024-07-20 11:17:22', '2025-07-05 05:45:43', 3),
(2, '2024-08-21 01:42:17', '2025-09-26 02:07:31', 3),
(2, '2024-09-18 06:46:30', '2026-02-23 11:20:25', 2),
(3, '2024-06-21 08:40:28', '2026-02-21 08:20:42', 3),
(3, '2024-07-31 10:41:02', '2025-04-05 06:59:00', 2),
(3, '2024-08-06 10:38:09', '2025-05-09 06:51:20', 2),
(3, '2024-08-13 06:38:49', '2026-03-07 12:30:55', 1),
(3, '2024-09-02 02:22:49', '2026-01-20 04:51:02', 4),
(3, '2024-10-28 10:47:32', '2025-08-14 12:57:14', 1),
(4, '2024-06-02 11:41:24', '2025-08-11 04:20:14', 4),
(4, '2024-06-24 07:39:05', '2025-10-04 01:22:42', 3),
(4, '2024-06-25 10:48:20', '2025-10-22 02:53:05', 3),
(4, '2024-07-10 05:48:16', '2026-02-07 11:36:05', 4),
(4, '2024-07-26 10:50:39', '2025-02-20 02:32:04', 1),
(4, '2024-08-05 05:06:55', '2025-10-12 11:18:55', 3),
(4, '2024-08-07 04:30:07', '2026-03-08 09:00:39', 2),
(4, '2024-08-08 04:10:30', '2025-01-12 03:46:46', 3),
(4, '2024-11-11 01:43:12', '2025-04-02 08:21:32', 3),
(4, '2024-11-18 09:20:14', '2025-07-03 06:31:04', 4),
(4, '2024-12-26 05:44:41', '2026-02-19 07:47:47', 2),
(5, '2024-05-28 11:12:17', '2025-12-27 07:40:19', 2),
(5, '2024-05-30 02:31:29', '2025-11-22 08:16:41', 2),
(5, '2024-08-14 09:23:03', '2025-11-17 06:05:32', 2),
(5, '2024-12-21 01:23:09', '2025-08-17 10:27:06', 2),
(6, '2024-05-30 08:29:29', '2025-04-07 09:49:00', 4),
(6, '2024-09-04 07:50:54', '2026-01-10 03:26:33', 2),
(6, '2024-09-19 08:15:42', '2026-01-04 06:04:05', 1),
(6, '2024-11-04 10:46:22', '2025-07-03 09:38:26', 2),
(7, '2024-06-14 05:39:53', '2025-11-25 08:52:31', 2),
(7, '2024-07-13 01:53:09', '2025-12-29 11:03:49', 3),
(7, '2024-09-08 05:08:06', '2025-09-20 05:08:57', 2),
(7, '2024-10-26 05:36:49', '2026-02-08 03:28:00', 1),
(7, '2024-11-08 01:42:51', '2025-11-24 09:43:53', 2),
(7, '2024-11-13 05:22:42', '2025-12-16 08:49:24', 4),
(7, '2024-11-16 10:22:58', '2025-08-02 09:03:55', 4),
(7, '2024-11-30 04:30:36', '2025-12-17 12:20:32', 4),
(7, '2024-12-26 03:07:18', '2026-02-12 08:42:57', 3),
(7, '2024-12-27 10:34:16', '2025-05-21 08:33:26', 3),
(8, '2024-06-14 08:16:55', '2026-02-21 06:03:50', 1),
(8, '2024-06-22 09:29:32', '2025-08-10 07:42:11', 2),
(8, '2024-09-16 07:36:14', '2026-02-09 01:22:03', 1),
(9, '2024-06-22 10:32:00', '2025-12-05 04:25:21', 2),
(9, '2024-09-04 08:30:36', '2025-07-31 06:57:14', 2),
(9, '2024-11-19 12:48:15', '2026-04-02 07:47:14', 4),
(10, '2024-08-14 02:02:22', '2025-05-20 12:06:42', 3),
(10, '2024-12-11 07:05:17', '2025-05-20 09:13:22', 3);

-- --------------------------------------------------------

--
-- Structure de la table motif
--

DROP TABLE IF EXISTS motif;
CREATE TABLE motif (
  idmotif int NOT NULL,
  libelle varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table motif
--

INSERT INTO motif (idmotif, libelle) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table personnel
--

DROP TABLE IF EXISTS personnel;
CREATE TABLE personnel (
  idpersonnel int NOT NULL,
  nom varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  prenom varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  tel varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  mail varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  idservice int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table personnel
--

INSERT INTO personnel (idpersonnel, nom, prenom, tel, mail, idservice) VALUES
(1, 'Hashim', 'Spencer', '1-342-461-5846', 'et.netus@google.com', 3),
(2, 'Anthony', 'Durham', '1-885-561-9234', 'amet.metus.aliquam@aol.couk', 2),
(3, 'Damon', 'Mills', '(751) 786-7783', 'donec.vitae@hotmail.ca', 1),
(4, 'Dexter', 'Bradley', '1-878-487-4617', 'a@google.net', 2),
(5, 'Amanda', 'Molina', '1-198-827-4813', 'proin.sed@icloud.org', 1),
(6, 'Lucius', 'Raymond', '(785) 501-3344', 'dapibus@aol.edu', 3),
(7, 'Lacy', 'Cameron', '(831) 264-8421', 'mi.enim@icloud.couk', 2),
(8, 'Octavia', 'Barton', '1-123-594-2162', 'tortor@google.org', 1),
(9, 'Simone', 'Cash', '(879) 491-5695', 'tincidunt.nibh@outlook.com', 2),
(10, 'Marvin', 'Durham', '1-672-218-9928', 'amet@protonmail.net', 3);

-- --------------------------------------------------------

--
-- Structure de la table responsable
--

DROP TABLE IF EXISTS responsable;
CREATE TABLE responsable (
  login varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  pwd varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table responsable
--

INSERT INTO responsable (login, pwd) VALUES
('admingwen', '92ddb6063e2306ef860cbe5ed30ae5cade68803fd98bda57e6cb8fcaf79fc81b');

-- --------------------------------------------------------

--
-- Structure de la table service
--

DROP TABLE IF EXISTS service;
CREATE TABLE service (
  idservice int NOT NULL,
  nom varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table service
--

INSERT INTO service (idservice, nom) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table absence
--
ALTER TABLE absence
  ADD PRIMARY KEY (idpersonnel,datedebut),
  ADD KEY idmotif (idmotif);

--
-- Index pour la table motif
--
ALTER TABLE motif
  ADD PRIMARY KEY (idmotif);

--
-- Index pour la table personnel
--
ALTER TABLE personnel
  ADD PRIMARY KEY (idpersonnel),
  ADD KEY idservice (idservice);

--
-- Index pour la table service
--
ALTER TABLE service
  ADD PRIMARY KEY (idservice);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table motif
--
ALTER TABLE motif
  MODIFY idmotif int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table personnel
--
ALTER TABLE personnel
  MODIFY idpersonnel int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;

--
-- AUTO_INCREMENT pour la table service
--
ALTER TABLE service
  MODIFY idservice int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;