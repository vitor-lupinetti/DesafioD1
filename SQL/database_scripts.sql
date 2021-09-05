
create database DesafioD1
GO
use DesafioD1


CREATE TABLE Clientes
( Id UNIQUEIDENTIFIER NOT NULL,
  Nome varchar(200) NOT NULL,
  DataNascimento datetime NOT NULL,
  CPF varchar(30) NOT NULL,
  RG varchar(30) NOT NULL,
  Facebook varchar(max),
  Linkedin varchar(max),
  Twitter varchar(max),
  Instagram varchar(max),
  CONSTRAINT clientes_pk PRIMARY KEY (Id)
);

CREATE TABLE Enderecos
( Id UNIQUEIDENTIFIER NOT NULL,
  Rua varchar(200) NOT NULL,
  Bairro varchar(200) NOT NULL,
  Cep varchar(30) NOT NULL,
  Numero int NOT NULL,
  CONSTRAINT enderecos_pk PRIMARY KEY (Id)
);

CREATE TABLE Clientes_Enderecos
( Id UNIQUEIDENTIFIER NOT NULL,
  IdCliente UNIQUEIDENTIFIER NOT NULL,
  IdEndereco UNIQUEIDENTIFIER NOT NULL,
  CONSTRAINT clientes_enderecos_pk PRIMARY KEY (Id),
  CONSTRAINT clientes_enderecos_fk FOREIGN KEY (IdCliente) REFERENCES Clientes (Id),
  CONSTRAINT enderecos_clientes_fk FOREIGN KEY (IdEndereco) REFERENCES Enderecos (Id)
);

CREATE TABLE Telefones
( Id UNIQUEIDENTIFIER NOT NULL,
  Numero varchar(200) NOT NULL,
  Identificacao varchar(200) NOT NULL,
  CONSTRAINT telefones_pk PRIMARY KEY (Id)
);

CREATE TABLE Clientes_Telefones
( Id UNIQUEIDENTIFIER NOT NULL,
  IdCliente UNIQUEIDENTIFIER NOT NULL,
  IdTelefone UNIQUEIDENTIFIER NOT NULL,
  CONSTRAINT clientes_telefones_pk PRIMARY KEY (Id),
  CONSTRAINT cliente_telefones_fk FOREIGN KEY (IdCliente) REFERENCES Clientes (Id),
  CONSTRAINT telefone_clientes_fk FOREIGN KEY (IdTelefone) REFERENCES Telefones (Id)
);
