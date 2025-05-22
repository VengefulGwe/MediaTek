-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 22 mai 2025 à 09:35
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
(50, '2023-02-17 01:55:18', '2025-02-07 05:05:54', 3),
(49, '2022-07-06 12:41:31', '2024-10-16 05:18:42', 1),
(48, '2022-03-08 09:55:31', '2025-08-21 03:23:16', 1),
(47, '2022-05-30 01:19:25', '2024-09-19 08:55:49', 4),
(46, '2022-10-24 11:37:03', '2025-03-26 11:10:30', 3),
(45, '2022-12-18 03:09:57', '2023-05-26 07:40:38', 3),
(44, '2023-03-17 04:19:11', '2024-12-14 02:48:32', 3),
(43, '2022-12-24 07:23:26', '2025-01-08 12:36:00', 2),
(42, '2022-09-26 08:15:30', '2025-02-05 01:47:10', 1),
(41, '2022-05-30 03:57:18', '2024-08-17 12:50:59', 3),
(40, '2023-01-11 03:50:21', '2023-11-11 02:24:42', 1),
(39, '2023-02-19 07:45:44', '2023-08-18 10:56:44', 2),
(38, '2022-04-09 09:14:17', '2024-02-13 01:52:47', 3),
(37, '2023-03-29 08:59:37', '2025-03-11 08:19:01', 3),
(36, '2022-12-28 05:03:40', '2026-05-16 12:26:08', 4),
(35, '2022-06-23 12:12:09', '2024-09-10 08:35:35', 4),
(34, '2022-05-03 04:19:05', '2024-01-29 08:07:55', 4),
(33, '2023-02-27 02:30:16', '2025-11-24 01:49:46', 3),
(32, '2023-02-10 06:02:01', '2025-07-27 09:59:20', 1),
(31, '2023-02-10 08:09:21', '2024-05-15 03:15:18', 2),
(30, '2022-10-01 03:17:02', '2025-12-23 02:09:22', 2),
(29, '2022-06-24 03:17:48', '2025-02-03 03:07:30', 1),
(28, '2023-03-18 10:47:06', '2024-08-26 11:35:36', 2),
(27, '2022-02-09 04:27:12', '2026-02-05 08:34:11', 3),
(26, '2022-11-10 01:11:46', '2024-05-10 11:22:13', 3),
(25, '2022-09-20 12:18:33', '2025-08-29 04:04:30', 2),
(24, '2022-05-27 10:03:54', '2023-06-26 02:26:43', 2),
(23, '2022-12-04 02:14:56', '2023-09-01 12:51:27', 1),
(22, '2022-12-03 03:47:05', '2024-11-27 03:58:11', 2),
(21, '2023-03-30 09:27:40', '2024-06-14 01:22:51', 2),
(20, '2022-03-21 12:15:17', '2023-08-28 09:40:21', 3),
(19, '2022-09-15 02:53:48', '2026-04-11 02:03:43', 1),
(18, '2022-05-07 01:59:28', '2024-09-08 05:12:38', 3),
(17, '2022-08-17 08:26:30', '2025-01-04 12:26:14', 2),
(16, '2023-01-29 09:15:31', '2024-12-12 02:15:11', 3),
(15, '2022-10-21 12:45:23', '2025-09-08 09:35:20', 2),
(14, '2022-10-17 12:41:06', '2026-01-13 11:33:10', 3),
(13, '2022-04-06 02:44:14', '2026-01-31 02:09:30', 2),
(12, '2023-01-13 10:52:47', '2025-07-08 06:07:58', 4),
(11, '2022-10-03 08:46:40', '2024-01-26 05:35:50', 3),
(10, '2022-05-06 05:28:25', '2023-10-22 01:03:29', 4),
(9, '2022-11-14 12:57:08', '2024-05-07 06:52:57', 2),
(8, '2022-11-15 06:38:06', '2024-08-06 04:32:48', 3),
(7, '2022-11-19 04:57:15', '2024-12-29 01:22:33', 3),
(6, '2022-08-07 11:29:19', '2024-11-02 01:35:18', 4),
(5, '2022-03-26 04:41:39', '2024-01-28 06:05:18', 2),
(4, '2022-11-24 04:27:01', '2023-12-11 07:44:26', 3),
(3, '2022-02-22 01:49:18', '2026-01-07 01:31:45', 3),
(2, '2022-03-20 01:16:22', '2025-10-29 03:52:57', 4),
(1, '2022-11-17 03:31:14', '2025-12-22 01:08:48', 2);

-- --------------------------------------------------------

--
-- Structure de la table motif
--

DROP TABLE IF EXISTS motif;
CREATE TABLE motif (
  idmotif int NOT NULL,
  libelle varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL
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
  nom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  prenom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  tel varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  mail varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  idservice int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table personnel
--

INSERT INTO personnel (idpersonnel, nom, prenom, tel, mail, idservice) VALUES
(21, 'Barnett', 'Jada', '(241) 630-2009', 'non.arcu@icloud.couk', 3),
(20, 'Faulkner', 'Carolyn', '1-659-884-9928', 'posuere.enim@google.ca', 1),
(44, 'Kirby', 'Baxter', '(520) 495-4526', 'ipsum@aol.edu', 2),
(48, 'Wiggins', 'Duncan', '(674) 650-0684', 'et.magna.praesent@protonmail.org', 2),
(39, 'Savage', 'Cora', '(467) 318-8600', 'phasellus.dolor@hotmail.couk', 2),
(22, 'Kirk', 'Joelle', '(708) 645-0461', 'dictum.eu@outlook.com', 2),
(5, 'Johnston', 'Hyatt', '1-455-535-9750', 'penatibus.et@aol.org', 3),
(13, 'Wiggins', 'Uta', '(811) 711-2596', 'auctor.velit@hotmail.edu', 1),
(14, 'Mccullough', 'Skyler', '(267) 892-9487', 'nunc@aol.net', 1),
(34, 'Page', 'Keely', '1-209-666-1850', 'magna.lorem@hotmail.net', 3);

-- --------------------------------------------------------

--
-- Structure de la table responsable
--

DROP TABLE IF EXISTS responsable;
CREATE TABLE responsable (
  login varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  pwd varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL
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
  nom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL
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
  MODIFY idpersonnel int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;

--
-- AUTO_INCREMENT pour la table service
--
ALTER TABLE service
  MODIFY idservice int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
