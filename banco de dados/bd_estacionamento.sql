-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 13-Abr-2023 às 21:03
-- Versão do servidor: 10.4.13-MariaDB
-- versão do PHP: 7.3.20

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bd_estacionamento`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `administradores`
--

CREATE TABLE `administradores` (
  `cod_administradores` int(11) NOT NULL,
  `usuario_administrador` varchar(45) NOT NULL,
  `nome_administrador` varchar(100) NOT NULL,
  `senha_administrador` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `administradores`
--

INSERT INTO `administradores` (`cod_administradores`, `usuario_administrador`, `nome_administrador`, `senha_administrador`) VALUES
(0, 'admin', 'Administrador', '1234');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cidades`
--

CREATE TABLE `cidades` (
  `cod_cidade` int(5) NOT NULL,
  `id_estado` int(5) NOT NULL,
  `descricao_cidade` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cidades`
--

INSERT INTO `cidades` (`cod_cidade`, `id_estado`, `descricao_cidade`) VALUES
(0, 0, 'Petropolís'),
(1, 1, 'Juiz de Fora'),
(2, 0, 'Cabo Frio');

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE `clientes` (
  `cod_clientes` int(5) NOT NULL,
  `email_clientes` varchar(80) DEFAULT NULL,
  `cpf_clientes` varchar(16) NOT NULL,
  `tempo_geral_clientes` int(11) NOT NULL,
  `usuario_clientes` varchar(45) NOT NULL,
  `senha_clientes` varchar(45) NOT NULL,
  `nome_clientes` varchar(120) NOT NULL,
  `telefone_clientes` varchar(15) NOT NULL,
  `imagem_perfil` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`cod_clientes`, `email_clientes`, `cpf_clientes`, `tempo_geral_clientes`, `usuario_clientes`, `senha_clientes`, `nome_clientes`, `telefone_clientes`, `imagem_perfil`) VALUES
(0, 'rafa@gmail.com', '156.165.151-16', 30, 'RaffaPS', '202cb962ac59075b964b07152d234b70', 'Rafael Pereira', '(32)9151-153', 'perfilCicloMov0.png'),
(1, 'cesar@gmail.com', '123.123.123-12', 0, 'cesar@gmail.com', '202cb962ac59075b964b07152d234b70', 'Cesar', '(32)98789-8743', 'imagem_padrao.png');

-- --------------------------------------------------------

--
-- Estrutura da tabela `estados`
--

CREATE TABLE `estados` (
  `cod_estado` int(5) NOT NULL,
  `descricao_estado` varchar(80) NOT NULL,
  `sigla` varchar(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `estados`
--

INSERT INTO `estados` (`cod_estado`, `descricao_estado`, `sigla`) VALUES
(0, 'Rio de Janeiro', 'RJ'),
(1, 'Minas Gerais', 'MG'),
(2, 'Santa Catarina', 'SC');

-- --------------------------------------------------------

--
-- Estrutura da tabela `mensagens`
--

CREATE TABLE `mensagens` (
  `id` int(11) NOT NULL,
  `texto` text NOT NULL,
  `mandante` int(11) NOT NULL,
  `id_solicitacao` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `pontos`
--

CREATE TABLE `pontos` (
  `cod_ponto` int(5) NOT NULL,
  `id_estado` int(5) NOT NULL,
  `id_cidade` int(5) NOT NULL,
  `vagas_livres_ponto` int(11) NOT NULL,
  `vagas_totais_ponto` int(11) NOT NULL,
  `descricao` varchar(500) NOT NULL,
  `mapa` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `pontos`
--

INSERT INTO `pontos` (`cod_ponto`, `id_estado`, `id_cidade`, `vagas_livres_ponto`, `vagas_totais_ponto`, `descricao`, `mapa`) VALUES
(0, 1, 1, 12, 12, 'Ponto - Jardim Norte', 'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3706.0249270363433!2d-43.37287808546745!3d-21.740559302760325!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x989c611b5febfd%3A0xd900ac6cb3d317bd!2sShopping%20Jardim%20Norte!5e0!3m2!1spt-BR!2sbr!4v1679366646226!5m2!1spt-BR!2sbr'),
(1, 0, 0, 12, 12, 'Ponto - Tijuca', 'https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d14699.06751894518!2d-43.2352235!3d-22.9219678!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x997e6bae2c0001%3A0x203e1a0e878d3b5!2sShopping%20Tijuca!5e0!3m2!1spt-BR!2sbr!4v1679366574430!5m2!1spt-BR!2sbr');

-- --------------------------------------------------------

--
-- Estrutura da tabela `servicos`
--

CREATE TABLE `servicos` (
  `cod_servico` int(5) NOT NULL,
  `id_clientes` int(5) NOT NULL,
  `id_ponto` int(5) NOT NULL,
  `tipo` varchar(150) NOT NULL,
  `tempo_permanencia` datetime NOT NULL,
  `valorTempo` int(11) NOT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `servicos`
--

INSERT INTO `servicos` (`cod_servico`, `id_clientes`, `id_ponto`, `tipo`, `tempo_permanencia`, `valorTempo`, `status`) VALUES
(0, 0, 0, 'Estacionamento', '2023-02-23 17:34:58', 30, 0),
(1, 0, 0, 'Manutenção e Limpeza', '2023-02-23 16:05:20', 20, 0),
(2, 0, 0, 'Limpeza', '2023-02-26 01:45:00', 30, 0),
(3, 0, 0, 'Aluguel', '2023-02-27 02:21:00', 30, 0),
(4, 0, 0, 'Aluguel', '2023-03-03 10:42:10', 15, 0),
(5, 0, 0, 'Aluguel', '2023-03-03 10:44:09', 15, 0),
(6, 0, 0, 'Manutencao', '2023-03-03 10:48:17', 15, 0),
(7, 0, 0, 'Aluguel', '2023-03-21 01:52:39', 30, 0),
(8, 0, 0, 'Aluguel', '2023-03-21 02:23:19', 30, 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `solicitacoes`
--

CREATE TABLE `solicitacoes` (
  `id` int(11) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_administrador` int(11) NOT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `administradores`
--
ALTER TABLE `administradores`
  ADD PRIMARY KEY (`cod_administradores`);

--
-- Índices para tabela `cidades`
--
ALTER TABLE `cidades`
  ADD PRIMARY KEY (`cod_cidade`);

--
-- Índices para tabela `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`cod_clientes`);

--
-- Índices para tabela `estados`
--
ALTER TABLE `estados`
  ADD PRIMARY KEY (`cod_estado`);

--
-- Índices para tabela `mensagens`
--
ALTER TABLE `mensagens`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `pontos`
--
ALTER TABLE `pontos`
  ADD PRIMARY KEY (`cod_ponto`),
  ADD KEY `id_uf` (`id_cidade`),
  ADD KEY `id_estado` (`id_estado`);

--
-- Índices para tabela `servicos`
--
ALTER TABLE `servicos`
  ADD PRIMARY KEY (`cod_servico`),
  ADD KEY `id_clientes` (`id_clientes`),
  ADD KEY `id_ponto` (`id_ponto`);

--
-- Índices para tabela `solicitacoes`
--
ALTER TABLE `solicitacoes`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `administradores`
--
ALTER TABLE `administradores`
  MODIFY `cod_administradores` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `cidades`
--
ALTER TABLE `cidades`
  MODIFY `cod_cidade` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `clientes`
--
ALTER TABLE `clientes`
  MODIFY `cod_clientes` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `estados`
--
ALTER TABLE `estados`
  MODIFY `cod_estado` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `mensagens`
--
ALTER TABLE `mensagens`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `pontos`
--
ALTER TABLE `pontos`
  MODIFY `cod_ponto` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `servicos`
--
ALTER TABLE `servicos`
  MODIFY `cod_servico` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de tabela `solicitacoes`
--
ALTER TABLE `solicitacoes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
