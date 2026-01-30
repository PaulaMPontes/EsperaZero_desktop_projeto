-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.4.32-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para espzero
DROP DATABASE IF EXISTS `espzero`;
CREATE DATABASE IF NOT EXISTS `espzero` /*!40100 DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci */;
USE `espzero`;

-- Copiando estrutura para tabela espzero.cadastrar_pacientes
DROP TABLE IF EXISTS `cadastrar_pacientes`;
CREATE TABLE IF NOT EXISTS `cadastrar_pacientes` (
  `id_paciente` int(11) NOT NULL AUTO_INCREMENT,
  `nomecomp_paciente` varchar(100) NOT NULL DEFAULT '0',
  `nomeusu_paciente` varchar(100) NOT NULL DEFAULT '0',
  `endereco_paciente` varchar(200) NOT NULL DEFAULT '0',
  `cep_paciente` varchar(20) NOT NULL DEFAULT '0',
  `cidade_paciente` varchar(200) NOT NULL DEFAULT '0',
  `estado_paciente` varchar(100) NOT NULL DEFAULT '0',
  `cpf_paciente` varchar(20) NOT NULL,
  `cartao_paciente` varchar(20) NOT NULL,
  `telefone_paciente` varchar(20) NOT NULL DEFAULT '0',
  `email_paciente` varchar(200) NOT NULL DEFAULT '0',
  `senha_paciente` varchar(10) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_paciente`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Copiando dados para a tabela espzero.cadastrar_pacientes: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `cadastrar_pacientes` DISABLE KEYS */;
INSERT INTO `cadastrar_pacientes` (`id_paciente`, `nomecomp_paciente`, `nomeusu_paciente`, `endereco_paciente`, `cep_paciente`, `cidade_paciente`, `estado_paciente`, `cpf_paciente`, `cartao_paciente`, `telefone_paciente`, `email_paciente`, `senha_paciente`) VALUES
	(11, 'Joao Gomes', 'Joao Go', 'Rua Turquia', '11900000', 'Registro', 'DF	', '45676767777', '102 4959 4534 5253', '(12) 545555555', 'joaogomes@email.com', '123'),
	(13, '0', '0', '0', '0', '0', '0', '33333333333', '', '0', '1', '4');
/*!40000 ALTER TABLE `cadastrar_pacientes` ENABLE KEYS */;

-- Copiando estrutura para tabela espzero.cadastrar_usuarios
DROP TABLE IF EXISTS `cadastrar_usuarios`;
CREATE TABLE IF NOT EXISTS `cadastrar_usuarios` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `nomecomp_usuario` varchar(100) NOT NULL DEFAULT '0',
  `telefone_usuario` varchar(20) NOT NULL DEFAULT '0',
  `email_usuario` varchar(200) NOT NULL DEFAULT '0',
  `senha_usuario` varchar(10) NOT NULL DEFAULT '0',
  `tipo_usuario` varchar(10) NOT NULL DEFAULT '0',
  `email_com` varchar(200) NOT NULL DEFAULT '0',
  `senha_com` varchar(10) NOT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Copiando dados para a tabela espzero.cadastrar_usuarios: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `cadastrar_usuarios` DISABLE KEYS */;
INSERT INTO `cadastrar_usuarios` (`id_usuario`, `nomecomp_usuario`, `telefone_usuario`, `email_usuario`, `senha_usuario`, `tipo_usuario`, `email_com`, `senha_com`) VALUES
	(7, '1', '(1 ) ', '1', '4', 'Médico', '0', ''),
	(8, 'Maria Lucia', '(55) 666676666', 'marialucia@email.com', '123', 'Administra', '0', ''),
	(9, 'Luiz Cirilo', '(77) 888888888', 'luizcirilo@email.com', '123', 'Médico', '0', '');
/*!40000 ALTER TABLE `cadastrar_usuarios` ENABLE KEYS */;

-- Copiando estrutura para tabela espzero.fila
DROP TABLE IF EXISTS `fila`;
CREATE TABLE IF NOT EXISTS `fila` (
  `id_fila` int(11) NOT NULL AUTO_INCREMENT,
  `num_fila` int(100) NOT NULL DEFAULT 0,
  `cpf_pac_fila` varchar(200) NOT NULL DEFAULT '0',
  `nome_pac_fila` varchar(200) NOT NULL DEFAULT '0',
  `categoria_fila` varchar(200) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_fila`)
) ENGINE=InnoDB AUTO_INCREMENT=72 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Copiando dados para a tabela espzero.fila: ~30 rows (aproximadamente)
/*!40000 ALTER TABLE `fila` DISABLE KEYS */;
INSERT INTO `fila` (`id_fila`, `num_fila`, `cpf_pac_fila`, `nome_pac_fila`, `categoria_fila`) VALUES
	(1, 1, '04162324000', 'Davi Ferreira', 'triagem'),
	(2, 2, '48478295062', 'Joao Gabriel', 'triagem'),
	(3, 3, '84296730088', 'Arthur Salvador', 'medicamento'),
	(4, 4, '72461389004', 'Guilherme Pereira', 'consulta'),
	(5, 5, '92959226038', 'Artur Meanda', 'medicamento'),
	(6, 6, '92959226038', 'Richard Moura', 'consulta'),
	(7, 7, '10245679073', 'Carlos Kleyton', 'consulta'),
	(8, 8, '9854327543', 'Matheus Shimada', 'triagem'),
	(9, 9, '11194528058', 'Laura Escobar', 'triagem'),
	(10, 10, '39291946001', 'Fernando Barbosa', 'medicamento'),
	(11, 11, '70086530003', 'Camila Rodrigues', 'medicamento'),
	(12, 12, '56095988004', 'Celina Neves', 'medicamento'),
	(13, 13, '42180201087', 'Ramon Trigo', 'triagem'),
	(14, 14, '24734186081', 'Yuri Moreira', 'consulta'),
	(15, 15, '97791621002', 'Simone Mendes', 'triagem'),
	(16, 16, '56435016003', 'Jorge Mateus', 'consulta'),
	(17, 17, '33544304007', 'Eduardo Matheus', 'triagem'),
	(18, 18, '27538718095', 'Marcos Silva', 'triagem'),
	(19, 19, '98685815088', 'Giovanna Takayma', 'triagem'),
	(20, 20, '35635870007', 'Jonathan Barreto', 'medicamento'),
	(21, 21, '41050050061', 'Diego Max', 'consulta'),
	(22, 22, '26662403040', 'Wanderson Barbosa', 'consulta'),
	(23, 23, '95827903000', 'Asael Santana', 'consulta'),
	(24, 24, '56747027051', 'Luan Santana', 'triagem'),
	(25, 25, '89850358009', 'Gustavo Lima', 'medicamento'),
	(26, 26, '45676767777', 'Joao Gomes', 'consulta'),
	(27, 27, '80346512069', 'Luiz Claudio', 'triagem'),
	(28, 28, '30380372061', 'Marilia Mendonça', 'consulta'),
	(29, 29, '84608072072', 'Leticia Weller', 'medicamento'),
	(67, 30, '76522307057', 'Kaye Preenzier', 'triagem');
/*!40000 ALTER TABLE `fila` ENABLE KEYS */;

-- Copiando estrutura para tabela espzero.login
DROP TABLE IF EXISTS `login`;
CREATE TABLE IF NOT EXISTS `login` (
  `tipo_login` varchar(10) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Copiando dados para a tabela espzero.login: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
/*!40000 ALTER TABLE `login` ENABLE KEYS */;

-- Copiando estrutura para tabela espzero.medicamentos
DROP TABLE IF EXISTS `medicamentos`;
CREATE TABLE IF NOT EXISTS `medicamentos` (
  `id_medicamento` int(11) NOT NULL AUTO_INCREMENT,
  `codprod_medicamento` varchar(200) NOT NULL DEFAULT '0',
  `desc_medicamento` varchar(200) NOT NULL DEFAULT '0',
  `conc_medicamento` varchar(200) NOT NULL DEFAULT '0',
  `apr_medicamento` varchar(200) NOT NULL DEFAULT '0',
  `codfam_medicamento` varchar(200) NOT NULL DEFAULT '0',
  `codgp_medicamento` varchar(200) NOT NULL DEFAULT '0',
  `ativo_medicamento` varchar(200) NOT NULL DEFAULT '0',
  `cpf_medicamento` varchar(200) NOT NULL DEFAULT '0',
  `nome_medicamento` varchar(200) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_medicamento`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Copiando dados para a tabela espzero.medicamentos: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `medicamentos` DISABLE KEYS */;
/*!40000 ALTER TABLE `medicamentos` ENABLE KEYS */;

-- Copiando estrutura para tabela espzero.prontuario
DROP TABLE IF EXISTS `prontuario`;
CREATE TABLE IF NOT EXISTS `prontuario` (
  `id_pac_med` int(11) NOT NULL AUTO_INCREMENT,
  `nomecomp_pac_med` varchar(100) NOT NULL DEFAULT '0',
  `cpf_pac_med` varchar(20) NOT NULL DEFAULT '0',
  `altura_pac_med` varchar(100) NOT NULL DEFAULT '0',
  `cartao_pac_med` varchar(20) NOT NULL,
  `peso_pac_med` varchar(100) NOT NULL DEFAULT '0',
  `oxigenio_pac_med` varchar(100) NOT NULL DEFAULT '0',
  `pressao_pac_med` varchar(100) NOT NULL DEFAULT '0',
  `receita_pac_med` varchar(100) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_pac_med`)
) ENGINE=InnoDB AUTO_INCREMENT=144 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Copiando dados para a tabela espzero.prontuario: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `prontuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `prontuario` ENABLE KEYS */;

-- Copiando estrutura para tabela espzero.triagem
DROP TABLE IF EXISTS `triagem`;
CREATE TABLE IF NOT EXISTS `triagem` (
  `id_dopaciente` int(11) NOT NULL AUTO_INCREMENT,
  `nomecomp_paciente` varchar(100) NOT NULL DEFAULT '0',
  `cpf_paciente` varchar(20) NOT NULL DEFAULT '0',
  `idade_paciente` varchar(100) NOT NULL DEFAULT '0',
  `altura_paciente` varchar(100) NOT NULL DEFAULT '0',
  `peso_paciente` varchar(100) NOT NULL DEFAULT '0',
  `oxigenio_paciente` varchar(100) NOT NULL DEFAULT '0',
  `pressao_paciente` varchar(100) NOT NULL DEFAULT '0',
  `sexo_paciente` varchar(100) NOT NULL DEFAULT '0',
  `tipos_paciente` varchar(100) NOT NULL DEFAULT '0',
  `medicamento_paciente` varchar(100) NOT NULL DEFAULT '0',
  `alergia_paciente` varchar(100) NOT NULL DEFAULT '0',
  `exerc_paciente` varchar(100) NOT NULL DEFAULT '0',
  `droga_paciente` varchar(100) NOT NULL DEFAULT '0',
  `observacao_paciente` varchar(100) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_dopaciente`)
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Copiando dados para a tabela espzero.triagem: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `triagem` DISABLE KEYS */;
/*!40000 ALTER TABLE `triagem` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
