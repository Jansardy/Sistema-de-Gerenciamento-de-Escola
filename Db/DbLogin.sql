-- Criar o banco de dados
CREATE DATABASE escola;
GO

-- Usar o banco de dados criado
USE escola;
GO

-- Criar a tabela 'usuario' com as modificações
CREATE TABLE usuario
(
    id_codigo CHAR(5) NOT NULL, -- Alterado de 'id_usuario' para 'id_codigo'
    nome VARCHAR(50),          -- Adicionada a coluna 'nome'
    nome_usuario VARCHAR(20) NOT NULL,
    senha VARCHAR(10) NOT NULL,
    tipo_id VARCHAR(15) NOT NULL -- Alterado de 'id_tipo' para 'tipo_id'
);

-- Inserir os dados na tabela 'usuario'
INSERT INTO usuario (id_codigo, nome, nome_usuario, senha, tipo_id) 
VALUES 
    ('00002', 'Administração', 'admi', 'admin', 'T0001'),
    ('11111', 'João Silva', 'Joao', 'Joao', '00054'); 

-- Criar a tabela 'Tipo' com as modificações
CREATE TABLE Tipo
(
    tipo_id VARCHAR(5) NOT NULL,   -- Alterado de 'id_tipo' para 'tipo_id'
    tipo_nome VARCHAR(20) NOT NULL -- Alterado de 'nome_tipo' para 'tipo_nome'
);

-- Inserir os dados na tabela 'Tipo'
INSERT INTO Tipo (tipo_id, tipo_nome) 
VALUES 
    ('T0001', 'Administrador'),
    ('T0002', 'Administrador'),
    ('00054', 'Aluno');

-- Selecionar todos os dados da tabela 'Tipo'
SELECT * FROM Tipo;

-- Procedimento armazenado para login
CREATE PROCEDURE sp_logar
    @usuario VARCHAR(20),
    @senha VARCHAR(10)
AS
BEGIN
    SELECT 
        nome,
        nome_usuario,
        senha,
        tipo_id,
        id_codigo
    FROM 
        usuario
    WHERE 
        nome_usuario = @usuario AND senha = @senha;
END;
GO

-- Procedimento armazenado para buscar usuário
CREATE PROCEDURE sp_buscar_usuario
    @nome VARCHAR(50)
AS
BEGIN
    SELECT 
        u.id_codigo, -- Atualizado para 'id_codigo'
        u.nome,      -- Incluído a coluna 'nome'
        u.nome_usuario,
        t.tipo_id,   -- Alterado de 'id_tipo' para 'tipo_id'
        t.tipo_nome AS Tipo -- Alterado de 'nome_tipo' para 'tipo_nome'
    FROM 
        usuario u
    INNER JOIN 
        Tipo t ON t.tipo_id = u.tipo_id -- Alterado de 'id_tipo' para 'tipo_id'
    WHERE 
        u.nome_usuario LIKE @nome;
END;
GO
