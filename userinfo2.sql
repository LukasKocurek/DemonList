CREATE DATABASE userinfo2 CHARACTER SET utf8 COLLATE utf8_general_ci;
USE userinfo2;

CREATE TABLE `register` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(49) NOT NULL,
  `password` varchar(49) NOT NULL,
  `level_completed` BOOLEAN NOT NULL DEFAULT FALSE,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE `leaderboard` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(49) NOT NULL,
  `level` varchar(50) NOT NULL,
  `score` float NOT NULL,
  `completion_time` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `register` (`username`, `password`) VALUES
('admin', 'pass');
