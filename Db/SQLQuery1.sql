-- Criar o banco de dados
CREATE DATABASE escola2;
GO

-- Usar o banco de dados criado
USE escola2;
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
select * from usuario;

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
        u.id_codigo,
        u.nome,
        u.nome_usuario,
        t.tipo_id,
        t.tipo_nome 
    FROM usuario u
    JOIN Tipo t ON t.tipo_id = u.tipo_id
    WHERE u.nome LIKE '%' + @nome + '%'
END
GO

-- Procedimento de lista
create PROCEDURE sp_listar_usuario
AS
BEGIN
    SELECT 
        id_codigo,
        u.nome,
        nome_usuario,
        t.tipo_id,
        t.tipo_nome AS Tipo
    FROM 
        usuario u
    JOIN 
        Tipo t ON t.tipo_id = u.tipo_id
    ORDER BY 
        id_codigo;
END;
GO

CREATE PROCEDURE procedimento_usuario   
@id_codigo CHAR(5), 
@nome VARCHAR(50),          
@nome_usuario VARCHAR(20),
@senha VARCHAR(10),
@tipo_id VARCHAR(15),
@accao VARCHAR(50) OUTPUT
AS
BEGIN
    -- Verificar se os parâmetros obrigatórios não são nulos
    IF (@id_codigo IS NULL OR @nome_usuario IS NULL OR @senha IS NULL OR @tipo_id IS NULL)
    BEGIN
        SET @accao = 'Erro: Parâmetros obrigatórios não fornecidos.';
        RETURN;
    END
    
    IF (@accao = '1')
    BEGIN
        DECLARE @novo VARCHAR(5), @novoMax VARCHAR(5);
        SET @novoMax = (SELECT MAX(id_codigo) FROM usuario);
        SET @novoMax = ISNULL(@novoMax, '00000');
        SET @novoMax = RIGHT('00000' + CAST(CAST(SUBSTRING(@novoMax, 2, 4) AS INT) + 1 AS VARCHAR), 5);
        
        INSERT INTO usuario(id_codigo, nome, nome_usuario, senha, tipo_id) 
        VALUES (@novoMax, @nome, @nome_usuario, @senha, @tipo_id);
        
        SET @accao = 'usuario inserido ' + @novoMax; -- inserir
    END
    ELSE IF (@accao = '2')
    BEGIN 
        UPDATE usuario 
        SET 
            nome = @nome, 
            nome_usuario = @nome_usuario, 
            senha = @senha,
            tipo_id = @tipo_id
        WHERE id_codigo = @id_codigo;
        
        SET @accao = 'usuario atualizado ' + @id_codigo; -- atualizar
    END
    ELSE IF (@accao = '3')
    BEGIN 
        DELETE FROM usuario 
        WHERE id_codigo = @id_codigo;
        
        SET @accao = 'usuario deletado ' + @id_codigo; -- deletar
    END
END;
GO



