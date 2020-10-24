--Se possível, recomendamos conectar pelo servidor no Microsoft SQL Server Management Studio: (localdb)\MSSQLLocalDB
--If possible, we recommend connecting via the server in Microsoft SQL Server Management Studio: (localdb)\MSSQLLocalDB

--DROP DATABASE Clinica
CREATE DATABASE Clinica
GO

USE Clinica
GO
 
CREATE TABLE Adm(
	
	Cod int primary key identity (1, 1),
	Nome VARCHAR(50),
	Logi VARCHAR(50),
	Senha VARCHAR(6)
)
GO

select * from Adm
GO


CREATE TABLE Cliente(
	CodCli int primary key identity (1, 1),
	Nome VARCHAR(50),
	Logi VARCHAR(50),
	Senha VARCHAR(6),
	Foto VARBINARY(MAX),
	DataCad DATE
)
GO

select * from Cliente
GO

CREATE TABLE Medico(
	
	IdMed int primary key identity (1, 1),
	Nome VARCHAR(50),
	crm VARCHAR(10),
	Esp VARCHAR(60)
)
GO

CREATE TABLE Paciente(
	IdPac int primary key identity(1, 1),
	Nome VARCHAR (50),
	SobreN VARCHAR (50),
	DataNasc DATE,
	Email VARCHAR(70),
	Genero CHAR(1),
	Conv VARCHAR(50),
	Descricao VARCHAR(50),
	Endereco VARCHAR(50),
	CPF VARCHAR(12)
)
GO

CREATE TABLE Endereco(
	IdEnd int primary key identity(1, 1),
	CEP VARCHAR(12),
	Logra VARCHAR(15),
	Numero VARCHAR(4),
	Bairro VARCHAR(50),
	Cidade VARCHAR(40),
	Estado VARCHAR(40),
	Espec VARCHAR(40),
	DataConsulta DATE,
	Hora TIME,
	Preco DECIMAL
)
GO

CREATE TABLE Consulta(
	IdConsulta int primary key identity(1,1),
	Nome VARCHAR (50),
	DataNasc DATE,
	Genero CHAR(1),
	Conv VARCHAR(50),
	CPF VARCHAR(30),
	Espec VARCHAR(30),
	Medico VARCHAR(40),
	DataConsulta DATE,
	Hora VARCHAR(15),
	Preco VARCHAR(15)
)
GO

CREATE TABLE Medicos
(
	idMedicos int primary key identity (1,1),
	Medicos VARCHAR (30)
);
GO

INSERT INTO Medicos (Medicos) values ('Veneuza'),
									 ('Fernanda'),
							         ('Michael'),
							         ('Manuelle')

--DROP TABLE Esp
--GO

CREATE TABLE Esp(	
	IdEsp INT,
	Nome VARCHAR(60)
)
GO

--------------------------------
CREATE TABLE Veneuza
(
	IdVene int primary key identity(1,1),
	Consulta varchar(50),
	Paciente varchar(30),
	Sexo varchar (1)
);
GO

CREATE TABLE Fernanda
(
	IdFer int primary key identity(1,1),
	Consulta varchar(50),
	Paciente varchar(30),
	Sexo varchar (1)
);
GO

CREATE TABLE Michael
(
	IdMic int primary key identity(1,1),
	Consulta varchar(50),
	Paciente varchar(30),
	Sexo varchar (1)
);
GO

CREATE TABLE Manuelle
(
	IdManu int primary key identity(1,1),
	Consulta varchar(50),
	Paciente varchar(30),
	Sexo varchar (1)
);
GO

CREATE PROC VeneuzaLista
as
select count(v.Consulta) from Veneuza v


insert into Veneuza(Consulta,Paciente,Sexo) values ('Cirurgia','Maria','F'),
													 ('Exame','Luiza','F'),
													 ('Cirurgia','Diego','M'),
													 ('Exame','Luana','F')

insert into Fernanda (Consulta,Paciente,Sexo) values ('Cirurgia','Marina','F'),
													 ('Exame','Thiago','M'),
													 ('Cirurgia','João','M'),
													 ('Exame','Luiza','F'),
													 ('Cirurgia','Diego','M'),
													 ('Exame','Luiza','F'),
													 ('Cirurgia','Diego','M')

insert into Michael(Consulta,Paciente,Sexo) values ('Cirurgia','Pedro','M'),
													 ('Exame','Luana','F'),
													 ('Cirurgia','Vitor','M'),
													 ('Exame','Luiza','F'),
													 ('Cirurgia','Diego','M'),
													 ('Exame','Luiza','F'),
													 ('Cirurgia','Diego','M'),
													 ('Exame','Luiza','F'),
													 ('Cirurgia','Diego','M')

insert into Manuelle (Consulta,Paciente,Sexo) values ('Cirurgia','Mikaela','F'),
													 ('Exame','Bonne','F'),
													 ('Cirurgia','Lucas','M')

select count (Consulta) as ConsultasVeneuza from Veneuza
select count (Consulta) as ConsultasFernanda from Fernanda
select count (Consulta) as ConsultasMichael from Michael
select count (Consulta) as ConsultasManuelle from Manuelle

select count (Sexo) as Luiza from Veneuza where Sexo='F'
select count (Sexo) as Maria from Fernanda where Sexo='F'
select count (Sexo) as Luana from Michael where Sexo='F'


BULK INSERT Esp FROM 'D:\#Linguagens de Programação\Windows Form\HACKATON (Dias 9 ao 13 de Setembro)\Medifarma\HACKATHON.txt'
WITH(FIELDTERMINATOR = ';')
GO

--Insert User and Password - Administrador
INSERT INTO Adm(Nome, Logi, Senha) 
VALUES('admin','admin','12345')
GO

--INSERT INTO Cliente(Nome, Logi, Senha,DataCad)
--VALUES('Marcio','marciofi','1234','2019-09-15')
--GO

SELECT * FROM Esp
GO

select* from Paciente