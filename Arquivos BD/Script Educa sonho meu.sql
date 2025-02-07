#drop database educa_sonho_meu;
create database educa_sonho_meu;
use educa_sonho_meu;

create table Endereco(
  id_end INT PRIMARY KEY AUTO_INCREMENT,
  uf_end VARCHAR(255) ,
  cidade_end VARCHAR(255) ,
  bairro_end VARCHAR(255) ,
  numero_end VARCHAR(255) ,
  cep_end VARCHAR(255) 
);
CREATE TABLE Responsavel (
  id_resp INT PRIMARY KEY AUTO_INCREMENT,
  nome_completo_resp VARCHAR(255) ,
  cpf_resp VARCHAR(255) ,
  rg_resp VARCHAR(255) ,
  orgao_expeditor_resp VARCHAR(255) ,
  telefone_resp varchar(255),
  telefone_alternativo_resp varchar(255),
  telefone_fixo_resp varchar(255),
  telefone_recado_resp varchar(255)
);
create table Escola(
  id_esc int primary key auto_increment,
  nome_esc varchar(255) ,
  endereco varchar(255)
);
create table Projeto(
  id_proj int primary key auto_increment,
  nome_proj varchar(255) ,
  coordenador_proj varchar(255) ,
  descricao_proj varchar(255) ,
  ano_inicio_proj year 
);
CREATE TABLE Aluno (
  id_alun INT PRIMARY KEY AUTO_INCREMENT,
  nome_alun VARCHAR(255) ,
  naturalidade_alun VARCHAR(255) ,
  nacionalidade_alun VARCHAR(255) ,
  data_nascimento_alun date ,
  cpf_alun VARCHAR(255) ,
  rg_alun VARCHAR(255) ,
  sexo_alu varchar(255),
  doenças_especialidades_alun VARCHAR(255) ,
  nis_alun VARCHAR(255) ,
  beneficio_alun VARCHAR(255) ,
  bolsa_familia_alun VARCHAR(255) ,
  endereco_alu VARCHAR(255),
  responsavel_alu VARCHAR(255),
  escola_alu VARCHAR(255),
  serie_alun varchar(255) ,
  parecer_social_alun varchar(255) ,
  nivel_prioridade_alun int
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
  nome_volu VARCHAR(255) ,
  cpf_volu VARCHAR(255) ,
  rg_volu VARCHAR(255) ,
  numero_telefone_volu VARCHAR(255) ,
  id_end_fk int,
  foreign key (id_end_fk) references Endereco (id_end)
);
CREATE TABLE Turma (
  id_turm INT PRIMARY KEY AUTO_INCREMENT,
  nome_turm VARCHAR(255) ,
  quantidade_turm VARCHAR(255) ,
  descricao_turm VARCHAR(255) ,
  ano_turm year 
);
CREATE TABLE Sala (
  id_sal INT PRIMARY KEY AUTO_INCREMENT,
  nome_sal VARCHAR(255) ,
  localizacao_sal VARCHAR(255) ,
  capacidade_sal VARCHAR(255) ,
  id_turm_fk int,
  foreign key (id_turm_fk) references Turma (id_turm)
);
CREATE TABLE Livro (
  id_liv INT PRIMARY KEY AUTO_INCREMENT,
  nome_liv VARCHAR(255) ,
  quantidade_liv VARCHAR(255) ,
  descricao_liv VARCHAR(255) ,
  valor_liv double ,
  num_paginas_liv int ,
  autor_liv VARCHAR(255) ,
  editora_liv VARCHAR(255) ,
  ano_aplicacao_liv year ,
  ano_impressao_liv year ,
  area_aplicacao_liv VARCHAR(255) 
);
CREATE TABLE Instrumento (
  id_inst INT PRIMARY KEY AUTO_INCREMENT,
  nome_inst VARCHAR(255) ,
  quantidade_inst int ,
  descricao_inst VARCHAR(255) ,
  valor_inst double 
);
CREATE TABLE Funcionario (
  id_func INT PRIMARY KEY AUTO_INCREMENT,
  nome_func VARCHAR(255) ,
  cpf_func VARCHAR(255) ,
  ctps_func VARCHAR(255) ,
  rg_func VARCHAR(255) ,
  funcao_func VARCHAR(255) ,
  sala_func VARCHAR(255),
  num_telefone_func VARCHAR(255) ,
  endereco_func VARCHAR(255)
);
CREATE TABLE Material (
  id_mate INT PRIMARY KEY AUTO_INCREMENT,
  nome_mate VARCHAR(255) ,
  quantidade_mate int ,
  descricao_mate VARCHAR(255) ,
  valor_mate double ,
  id_sal_fk int,
  foreign key (id_sal_fk) references Sala (id_sal)
);
CREATE TABLE Evento (
  id_even INT PRIMARY KEY AUTO_INCREMENT,
  nome_even VARCHAR(255) ,
  data_even date ,
  id_end_fk int,
  descricao_even VARCHAR(255) ,
  id_func_fk int,
  cor_destaque_even VARCHAR(255) ,
  foreign key (id_end_fk) references Endereco (id_end),
  foreign key (id_func_fk) references Funcionario (id_func)
);
CREATE TABLE Recurso (
  id_recu INT PRIMARY KEY AUTO_INCREMENT,
  doador_recu VARCHAR(255) ,
  valor_recu double ,
  destino_recu VARCHAR(255) ,
  data_recu date 
);
CREATE TABLE Despesa (
  id_desp INT PRIMARY KEY AUTO_INCREMENT,
  doador_desp VARCHAR(255) ,
  valor_desp double ,
  destino_desp VARCHAR(255) ,
  data_desp date 
);
create table Entrada_sonho(
  id_sonh INT PRIMARY KEY AUTO_INCREMENT,
  data_sonh date ,
  valor_sonh double ,
  descricao_sonh VARCHAR(255) ,
  id_alun_fk int,
  foreign key (id_alun_fk) references Aluno (id_alun),
  id_turm_fk int,
  foreign key (id_turm_fk) references Turma (id_turm)
);
