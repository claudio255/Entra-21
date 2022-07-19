INSERT INTO editoras(nome, apelido, data_criacao, faturamento) VALUES
('DC', 'DC Comics', '1939-01-20', 2727000000.00),
('Marvel', 'Marvel Comics', '1939-01-01', 3200000000.00),
('The boys', 'The Boys Comics', '2006-01-01', 1000000000.00);

SELECT * FROM editoras;

SELECT * FROM personagens;

CREATE TABLE unidades_federativas(
	id INTEGER PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR(50),
	sigla VARCHAR(4)
	);

CREATE TABLE cidades(
	id INTEGER PRIMARY KEY IDENTITY (1,1),
	id_unidade_federativa INTEGER,
	nome VARCHAR(50),
	quantidade_habitantes INTEGER,
	data_hora_fundacao DATETIME2,
	pib DECIMAL(15,2)
	);