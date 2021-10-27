-- phpMyAdmin SQL Dump
-- version 3.4.9
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 27-10-2021 a las 06:10:35
-- Versión del servidor: 5.5.20
-- Versión de PHP: 5.3.9

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `administración de usuarios`
--
CREATE DATABASE `administración de usuarios` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `administración de usuarios`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `account`
--

CREATE TABLE IF NOT EXISTS `account` (
  `codUser` int(11) NOT NULL AUTO_INCREMENT,
  `firstname` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  `email` varchar(50) NOT NULL,
  `registerDate` date NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  PRIMARY KEY (`codUser`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4568 ;

--
-- Volcado de datos para la tabla `account`
--

INSERT INTO `account` (`codUser`, `firstname`, `lastname`, `email`, `registerDate`, `username`, `password`) VALUES
(1, 'admin', 'admin', 'admin@admin', '2021-10-26', 'admin', 'admin');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `userlog`
--

CREATE TABLE IF NOT EXISTS `userlog` (
  `codUser` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `timeLoggedIn` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

