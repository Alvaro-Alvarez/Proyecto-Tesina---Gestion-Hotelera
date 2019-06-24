-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 02-11-2016 a las 10:21:06
-- Versión del servidor: 10.1.16-MariaDB
-- Versión de PHP: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `hoteltesina`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `id` int(11) NOT NULL,
  `nombre` varchar(25) NOT NULL,
  `apellido` varchar(25) NOT NULL,
  `dni` int(14) NOT NULL,
  `domicilio` varchar(25) NOT NULL,
  `sexo` varchar(10) NOT NULL,
  `telefono` int(15) NOT NULL,
  `mail` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`id`, `nombre`, `apellido`, `dni`, `domicilio`, `sexo`, `telefono`, `mail`) VALUES
(1, 'Carlos', 'Ruetallo', 27890234, 'Av. Las Heras 2334', 'masculino', 45332211, 'Carlos.Ruetallo@hotmail.com'),
(2, 'Oscar', 'Patricios', 33256932, 'Los Patos 401', 'masculino', 49075621, 'oscar.patricio.21@gmail.com'),
(3, 'Daniel', 'Mendez', 31649240, 'Zavaleta 204', 'masculino', 43229421, 'dani.pinturas.92@gmail.com'),
(4, 'Nicolas', 'Gimenez', 29112938, 'Av.Caseros 2302', 'masculino', 34921184, 'nicolas.gimenez@yahoo.com.ar'),
(5, 'Tamara', 'Martinez', 37638262, 'Piedras 2300', 'femenino', 49126342, 'tami.martinez.91@hotmail.com');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `consumiciones`
--

CREATE TABLE `consumiciones` (
  `id` int(11) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `precio` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `consumiciones`
--

INSERT INTO `consumiciones` (`id`, `nombre`, `precio`) VALUES
(1, 'Coca Cola 2 Litros', '40'),
(2, 'Pizza Muzarella', '100'),
(3, 'Hamburguesa Completa', '38'),
(4, 'Jugo Naranja Cepita', '25');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `consumiciones_has_habitaciones`
--

CREATE TABLE `consumiciones_has_habitaciones` (
  `id` int(11) NOT NULL,
  `Consumiciones_id` int(11) NOT NULL,
  `Habitaciones_id` int(11) NOT NULL,
  `fecha` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `consumiciones_has_habitaciones`
--

INSERT INTO `consumiciones_has_habitaciones` (`id`, `Consumiciones_id`, `Habitaciones_id`, `fecha`) VALUES
(1, 1, 1, '2016-11-02'),
(2, 2, 1, '2016-11-02'),
(3, 3, 1, '2016-11-02'),
(4, 1, 1, '2016-11-02'),
(5, 1, 1, '2016-11-02'),
(6, 2, 1, '2016-11-02'),
(7, 2, 1, '2016-11-02'),
(8, 3, 1, '2016-11-02'),
(9, 4, 1, '2016-11-02');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `forma_de_pago`
--

CREATE TABLE `forma_de_pago` (
  `id` int(11) NOT NULL,
  `tipo_de_pago` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `forma_de_pago`
--

INSERT INTO `forma_de_pago` (`id`, `tipo_de_pago`) VALUES
(1, 'efectivo'),
(2, 'tarjeta de credito');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `habitaciones`
--

CREATE TABLE `habitaciones` (
  `id` int(11) NOT NULL,
  `num_habitacion` int(11) NOT NULL,
  `estado` varchar(25) NOT NULL,
  `precio` int(25) NOT NULL,
  `tipo_de_habitacion_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `habitaciones`
--

INSERT INTO `habitaciones` (`id`, `num_habitacion`, `estado`, `precio`, `tipo_de_habitacion_id`) VALUES
(1, 1, 'Disponible', 400, 1),
(2, 2, 'Disponible', 200, 2),
(3, 3, 'Disponible', 300, 3),
(4, 4, 'Disponible', 500, 5),
(5, 5, 'Disponible', 100, 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reservas`
--

CREATE TABLE `reservas` (
  `id` int(11) NOT NULL,
  `fecha_reserva` date NOT NULL,
  `fecha_ingreso` date NOT NULL,
  `fecha_salida` date NOT NULL,
  `Clientes_id` int(11) NOT NULL,
  `Habitaciones_id` int(11) NOT NULL,
  `forma_de_pago_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `reservas`
--

INSERT INTO `reservas` (`id`, `fecha_reserva`, `fecha_ingreso`, `fecha_salida`, `Clientes_id`, `Habitaciones_id`, `forma_de_pago_id`) VALUES
(1, '2016-10-31', '2016-11-02', '2016-11-12', 1, 3, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_de_habitaciones`
--

CREATE TABLE `tipo_de_habitaciones` (
  `id` int(11) NOT NULL,
  `tipo` varchar(25) NOT NULL,
  `num_ambientes` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipo_de_habitaciones`
--

INSERT INTO `tipo_de_habitaciones` (`id`, `tipo`, `num_ambientes`) VALUES
(1, 'junior', 4),
(2, 'habitacion doble', 2),
(3, 'habitacion triple', 3),
(4, 'individual', 1),
(5, 'suite', 5);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `consumiciones`
--
ALTER TABLE `consumiciones`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `consumiciones_has_habitaciones`
--
ALTER TABLE `consumiciones_has_habitaciones`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `forma_de_pago`
--
ALTER TABLE `forma_de_pago`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `habitaciones`
--
ALTER TABLE `habitaciones`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `reservas`
--
ALTER TABLE `reservas`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `tipo_de_habitaciones`
--
ALTER TABLE `tipo_de_habitaciones`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `consumiciones`
--
ALTER TABLE `consumiciones`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `consumiciones_has_habitaciones`
--
ALTER TABLE `consumiciones_has_habitaciones`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT de la tabla `forma_de_pago`
--
ALTER TABLE `forma_de_pago`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `habitaciones`
--
ALTER TABLE `habitaciones`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `reservas`
--
ALTER TABLE `reservas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `tipo_de_habitaciones`
--
ALTER TABLE `tipo_de_habitaciones`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
