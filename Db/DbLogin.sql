create database escola
go
use escola
go

create table usuario
(
id_usuario varchar(5) not null,
nome_usuario varchar(20) not null,
senha varchar(10) not null,
id_tipo varchar(15) not null
)
insert into usuario values('00002', 'admi', 'admin', 'Administrador')
insert into usuario values('11111', 'Joao', 'Joao', 'Aluno') 

create table Tipo
(
id_tipo varchar(5) not null,
nome_tipo varchar(20) not null,
)
insert into Tipo values('T0001','Administrador')
insert into Tipo values('T0002','Administrador')
insert into Tipo values('00054','Aluno')

CREATE PROCEDURE sp_logar
    @usuario VARCHAR(20),
    @senha VARCHAR(10)
AS
BEGIN
    SELECT 
        nome_usuario,
        senha,
        id_tipo,
        id_usuario
    FROM 
        usuario
    WHERE 
        nome_usuario = @usuario AND senha = @senha;
END;
GO