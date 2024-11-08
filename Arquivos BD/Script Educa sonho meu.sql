drop database educa_sonho_meu;
create database educa_sonho_meu;
use educa_sonho_meu;

create table Endereco(
  id_end INT PRIMARY KEY AUTO_INCREMENT,
  uf_end VARCHAR(255) NOT NULL,
  cidade_end VARCHAR(255) NOT NULL,
  bairro_end VARCHAR(255) NOT NULL,
  numero_end VARCHAR(255) NOT NULL,
  cep_end VARCHAR(255) NOT NULL
);
CREATE TABLE Responsavel (
  id_resp INT PRIMARY KEY AUTO_INCREMENT,
  nome_completo_resp VARCHAR(255) NOT NULL,
  cpf_resp VARCHAR(255) NOT NULL,
  rg_resp VARCHAR(255) NOT NULL,
  orgao_expeditor_resp VARCHAR(255) NOT NULL,
  telefone_resp varchar(255),
  telefone_alternativo_resp varchar(255),
  telefone_fixo_resp varchar(255),
  telefone_recado_resp varchar(255)
);
create table Escola(
  id_esc int primary key auto_increment,
  nome_esc varchar(255) not null,
  id_end_fk int,
  foreign key (id_end_fk) references Endereco (id_end)
);
create table Sexo(
  id_sex int primary key auto_increment,
  nome_sex varchar(255) not null
);
create table Projeto(
  id_proj int primary key auto_increment,
  nome_proj varchar(255) not null,
  coordenador_proj varchar(255) not null,
  descricao_proj varchar(255) not null,
  ano_inicio_proj year not null
);
CREATE TABLE Aluno (
  id_alun INT PRIMARY KEY AUTO_INCREMENT,
  nome_alun VARCHAR(255) NOT NULL,
  naturalidade_alun VARCHAR(255) NOT NULL,
  nacionalidade_alun VARCHAR(255) NOT NULL,
  data_nascimento_alun date NOT NULL,
  cpf_alun VARCHAR(255) NOT NULL,
  rg_alun VARCHAR(255) NOT NULL,
  id_sex_fk int,
  doenças_especialidades_alun VARCHAR(255) NOT NULL,
  nis_alun VARCHAR(255) NOT NULL,
  beneficio_alun VARCHAR(255) NOT NULL,
  bolsa_familia_alun VARCHAR(255) NOT NULL,
  id_end_fk int,
  id_resp_fk int,
  id_esc_fk int,
  serie_alun varchar(255) not null,
  parecer_social_alun varchar(255) not null,
  nivel_prioridade_alun int not null,
  foreign key (id_sex_fk) references Sexo (id_sex),
  foreign key (id_end_fk) references Endereco (id_end),
  foreign key (id_resp_fk) references Responsavel (id_resp),
  foreign key (id_esc_fk) references Escola (id_esc)
);
create table Projeto_Aluno(
  id_projalun int primary key auto_increment,
  hora_participa_projalun time,
  id_proj_fk int,
  id_alun_fk int,
  foreign key (id_proj_fk) references Projeto(id_proj),
  foreign key (id_alun_fk) references Aluno(id_alun)
);
CREATE TABLE Voluntario (
  id_volu INT PRIMARY KEY AUTO_INCREMENT,
  nome_volu VARCHAR(255) NOT NULL,
  cpf_volu VARCHAR(255) NOT NULL,
  rg_volu VARCHAR(255) NOT NULL,
  numero_telefone_volu VARCHAR(255) NOT NULL,
  id_end_fk int,
  foreign key (id_end_fk) references Endereco (id_end)
);
CREATE TABLE Turma (
  id_turm INT PRIMARY KEY AUTO_INCREMENT,
  nome_turm VARCHAR(255) NOT NULL,
  quantidade_turm VARCHAR(255) NOT NULL,
  descricao_turm VARCHAR(255) NOT NULL,
  ano_turm year NOT NULL
);
CREATE TABLE Sala (
  id_sal INT PRIMARY KEY AUTO_INCREMENT,
  nome_sal VARCHAR(255) NOT NULL,
  localizacao_sal VARCHAR(255) NOT NULL,
  capacidade_sal VARCHAR(255) NOT NULL,
  id_turm_fk int,
  foreign key (id_turm_fk) references Turma (id_turm)
);
CREATE TABLE Livro (
  id_liv INT PRIMARY KEY AUTO_INCREMENT,
  nome_liv VARCHAR(255) NOT NULL,
  quantidade_liv VARCHAR(255) NOT NULL,
  descricao_liv VARCHAR(255) NOT NULL,
  valor_liv double NOT NULL,
  num_paginas_liv int NOT NULL,
  autor_liv VARCHAR(255) NOT NULL,
  editora_liv VARCHAR(255) NOT NULL,
  ano_aplicacao_liv year NOT NULL,
  ano_impressao_liv year NOT NULL,
  area_aplicacao_liv VARCHAR(255) NOT NULL
);
CREATE TABLE Instrumento (
  id_inst INT PRIMARY KEY AUTO_INCREMENT,
  nome_inst VARCHAR(255) NOT NULL,
  quantidade_inst int NOT NULL,
  descricao_inst VARCHAR(255) NOT NULL,
  valor_inst double NOT NULL
);
CREATE TABLE Funcionario (
  id_func INT PRIMARY KEY AUTO_INCREMENT,
  nome_func VARCHAR(255) NOT NULL,
  cpf_func VARCHAR(255) NOT NULL,
  ctps_func VARCHAR(255) NOT NULL,
  rg_func VARCHAR(255) NOT NULL,
  funcao_func VARCHAR(255) NOT NULL,
  id_sal_fk int,
  num_telefone_func VARCHAR(255) NOT NULL,
  id_end_fk int,
  foreign key (id_end_fk) references Endereco (id_end),
  foreign key (id_sal_fk) references Sala (id_sal)
);
CREATE TABLE Material (
  id_mate INT PRIMARY KEY AUTO_INCREMENT,
  nome_mate VARCHAR(255) NOT NULL,
  quantidade_mate int NOT NULL,
  descricao_mate VARCHAR(255) NOT NULL,
  valor_mate double NOT NULL,
  id_sal_fk int,
  foreign key (id_sal_fk) references Sala (id_sal)
);
CREATE TABLE Evento (
  id_even INT PRIMARY KEY AUTO_INCREMENT,
  nome_even VARCHAR(255) NOT NULL,
  data_even date NOT NULL,
  id_end_fk int,
  descricao_even VARCHAR(255) NOT NULL,
  id_func_fk int,
  cor_destaque_even VARCHAR(255) NOT NULL,
  foreign key (id_end_fk) references Endereco (id_end),
  foreign key (id_func_fk) references Funcionario (id_func)
);
CREATE TABLE Recurso (
  Id INT PRIMARY KEY AUTO_INCREMENT,
  Doador VARCHAR(255) NOT NULL,
  Valor double NOT NULL,
  Destino VARCHAR(255) NOT NULL,
  data_recu date NOT NULL
);
CREATE TABLE Despesa (
  id_desp INT PRIMARY KEY AUTO_INCREMENT,
  doador_desp VARCHAR(255) NOT NULL,
  valor_desp double NOT NULL,
  destino_desp VARCHAR(255) NOT NULL,
  data_desp date NOT NULL
);
create table Entrada_sonho(
	id_sonh INT PRIMARY KEY AUTO_INCREMENT,
    data_sonh date not null,
    valor_sonh double not null,
    descricao_sonh VARCHAR(255) NOT NULL,
    id_alun_fk int,
    foreign key (id_alun_fk) references Aluno (id_alun),
    id_turm_fk int,
    foreign key (id_turm_fk) references Turma (id_turm)
);