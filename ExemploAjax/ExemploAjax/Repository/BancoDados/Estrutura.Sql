 DROP TABLE IF EXISTS pessoas;

CREATE TABLE pessoas(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	cpf VARCHAR(14),
	registro_ativo BIT
);

INSERT INTO pessoas (nome, cpf, registro_ativo) VALUES 
('Lola', '656.656.656.67', 1), ('Leela', '589.645.289-99', 1);

