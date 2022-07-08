CREATE TABLE pessoas(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	cpf VARCHAR(14),
	rg VARCHAR (12),
	data_de_nascimento DATETIME2,
	idade INTEGER
	);

	INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
		VALUES ('Erick Bryan Enrico Vieira',
		'699.734.958-70',
		'90.745.276-0',
		'1989-05-28',
		'29');

	SELECT id, nome, cpf, rg, data_de_nascimento, idade FROM pessoas;

	INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
		VALUES ('Samuel Ruan Dias',
		'802.790.194-40',
		'55.318.691-7',
		'1988-02-08',
		'30');

	INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
		VALUES ('Fábio Benjamin Souza',
		'522.445.349-60',
		'54.715.232-2',
		'1970-03-22',
		'48');

	INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
		VALUES ('Elias Miguel Aparicio',
		'293.928.821-65',
		'12.680.444-8',
		'1986-06-07',
		'32');

	INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
		VALUES ('Alexandre Gustavo Cardoso',
		'617.408.878-24',
		'8.888.574-4',
		'2003-04-15',
		'15');

	INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
		VALUES ('Kauê Lucca Duarte',
		'943.163.990-47',
		'46.977.509-9',
		'1965-06-15',
		'53');

	INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
		VALUES ('Marcos Bryan Guilherme Mendes',
		'955.129.235-95',
		'84.050.077-4',
		'2015-02-06',
		'3');

	INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
		VALUES ('Benedito Pedro Carlos da Mota',
		'510.505.472-50',
		'43.588.124-3',
		'1981-04-19',
		'37');

	INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
		VALUES ('Luís Igor Barbosa',
		'370.570.311-06',
		'40.651.407-0',
		'2013-05-06',
		'5');

	INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
		VALUES ('José Heitor Ramos',
		'675.624.925-81',
		'83.962.258-2',
		'1965-04-11',
		'53');

	INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
		VALUES ('Lucca Tiago Galvão',
		'788.124.508-57',
		'3.293.335-6',
		'1977-06-17',
		'41');

	INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
		VALUES ('Tiago Edson Oliveira',
		'389.969.352-39',
		'8.198.446-9',
		'1977-06-09',
		'41');

	INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
		VALUES ('Enrico Julio Fábio Martins',
		'529.078.166-83',
		'99.886.242-3',
		'2017-03-11',
		'1');

	INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
		VALUES ('Oliver Victor Benjamin da Mota',
		'798.556.805-02',
		'5.103.578-9',
		'1985-03-27',
		'33');

	INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
		VALUES ('Bryan Caio Lopes',
		'213.217.201-30',
		'12.949.454-9',
		'1970-06-18',
		'48');

	SELECT id, nome, cpf, rg, data_de_nascimento, idade FROM pessoas;

	SELECT id,nome,
		CONCAT(
			DAY(data_de_nascimento), '/',
			MONTH(data_de_nascimento), '/',
			YEAR(data_de_nascimento))
		FROM pessoas;

	SELECT id, nome, FORMAT(data_de_nascimento, 'dd/MM/yyyy')
		AS 'Data de nascimento'
		FROM pessoas;

	SELECT id, nome, cpf, rg, data_de_nascimento, idade
			FROM pessoas;

	SELECT id, nome, data_de_nascimento FROM pessoas
		WHERE 
		YEAR(data_de_nascimento) >= 1990 AND
		YEAR(data_de_nascimento) < 2005;

	SELECT id, nome, 
		FORMAT(data_de_nascimento, 'dd/MM/yyyy')
		AS 'Data de Nascimento'
		FROM pessoas
		WHERE
		YEAR(data_de_nascimento) < 1980;

	SELECT id, nome, idade FROM pessoas
		ORDER BY idade ASC;

	SELECT nome, idade FROM pessoas
		ORDER BY idade DESC;
		
	SELECT AVG (idade) 
		AS 'Media de idade'
		FROM pessoas;
		
	SELECT SUM (idade)
		AS 'Somatoria de idades'
		FROM pessoas;







	CREATE TABLE enderecos(
		id INTEGER PRIMARY KEY IDENTITY(1,1),
		estado VARCHAR(2),
		cidade VARCHAR(140),
		bairro VARCHAR(120),
		cep VARCHAR(10),
		logradouro VARCHAR(250),
		numero INTEGER,
		complemento TEXT
		);

	INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
		VALUES('AC',
		'Rio Branco',
		'Ayrton Senna',
		'69.911-866',
		'Estrada Deputado José Rui da Silveira Lino',
		'282',
		'casa');

	SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento
		FROM enderecos;

	INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
		VALUES('SC',
		'Biguaçu',
		'Fundos',
		'88.161-400',
		'',
		'995',
		'');

	INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
		VALUES('BA',
		'',
		'São Tomé de Paripe',
		'40.800-361',
		'Travessa Luís Hage',
		'685',
		'');

	INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
		VALUES('MG',
		'Ipatinga',
		'Vila Celeste',
		'',
		'Rua Antônio Boaventura Batista',
		'645',
		'');

	INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
		VALUES('RS',
		'Passo Fundo',
		'Nenê Graeff',
		'99.030-250',
		'',
		'154',
		'');

	INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
		VALUES('AM',
		'Manaus',
		'Petrópolis',
		'69.079-300',
		'Rua Coronel Ferreira Sobrinho',
		'264',
		'Fundos');

	INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
		VALUES('TO',
		'Gurupi',
		'Muniz Santana',
		'77.402-130',
		'Rua Adelmo Aires Negri',
		'794',
		'');

	INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
		VALUES('AC',
		'',
		'Preventório',
		'',
		'Beco da Ligação II',
		'212',
		'Bloco B');

	INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
		VALUES('AP',
		'Santana',
		'Comercial',
		'68.925-073',
		'Rua Calçoene',
		'648',
		'');

	INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
		VALUES('PB',
		'Cabedelo',
		'Camalaú',
		'58.103-052',
		'Rua Siqueira Campos',
		'249',
		'');

	SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento
		FROM enderecos;

	INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
		VALUES('MG',
		'Santa Luzia',
		'Padre Miguel',
		'33.082-050',
		'Rua Buenos Aires',
		'371',
		'Apartamento');

	SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento
		FROM enderecos;

	SELECT id, estado, cidade, bairro, cep, CONCAT(SUBSTRING(logradouro, 0, 10), '...')
		AS 'Logradouro' , numero, complemento
		FROM enderecos;

	SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento
		FROM enderecos
		WHERE
		(cidade) = '' INSERT enderecos (cidade) VALUES ('NULL');

	SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento
		FROM enderecos;

	DELETE FROM enderecos WHERE id = 12;

	SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento
		FROM enderecos;

	UPDATE enderecos SET logradouro = 'Rua Julio Teodoro Martins'
		WHERE id = 2;

	SELECT logradouro FROM enderecos;

	UPDATE enderecos SET cidade = 'Salvador'
		WHERE id = 3;

	UPDATE enderecos SET logradouro = 'Rua Itu'
		WHERE id = 5;

	UPDATE enderecos SET cep = '35162-484'
		WHERE id = 4;

	UPDATE enderecos SET cep = '69900162'
		WHERE id = 8;

	UPDATE enderecos SET cidade = 'Rio Branco'
		WHERE id = 8;

	UPDATE enderecos SET complemento = 'Casa'
		WHERE id = 2
	
	UPDATE enderecos SET complemento = 'Bloco C'
		WHERE id = 3;

	UPDATE enderecos SET complemento = 'Apartamento'
		WHERE id = 4;

	UPDATE enderecos SET complemento = 'KitNet 3'
		WHERE id = 5;

	UPDATE enderecos SET complemento = 'Apartamento'
		WHERE id = 7;

	UPDATE enderecos SET complemento = 'Casa'
		WHERE id = 9;

	UPDATE enderecos SET complemento = 'Fundos'
		WHERE id = 10;

	SELECT complemento FROM enderecos;

	UPDATE enderecos SET complemento = 'Fundos'
		WHERE id = 6;

	UPDATE enderecos SET complemento = 'Bloco B'
		WHERE id = 8;

	UPDATE  enderecos SET complemento = 'Casa'
		WHERE id = 11;

	UPDATE enderecos SET complemento = 'Apartamento'
		WHERE id = 12;

	SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento
		FROM enderecos;

	UPDATE enderecos SET complemento = 'Apartamento'
		WHERE id = 11;

	DELETE FROM enderecos WHERE id = 12;
	DELETE FROM enderecos WHERE id = 13;

	UPDATE enderecos SET complemento = 'Embaixo da Ponte'
		WHERE id = 2;

	SELECT complemento FROM enderecos;

	SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento
		FROM enderecos;

	SELECT id, estado, cep
		FROM enderecos
		WHERE estado = 'MG';

	SELECT id, estado, cep
		FROM enderecos
		WHERE estado = 'AC';

	SELECT id,
		estado,
		logradouro,
		LEN(logradouro) AS 'Menor quantidade de caracteres'
		FROM enderecos
		WHERE LEN(logradouro) = (SELECT MIN(LEN(l.logradouro)) FROM enderecos l);

	SELECT id,
		estado,
		logradouro,
		LEN(logradouro) AS 'Maior quantidade de caracteres'
		FROM enderecos
		WHERE LEN(logradouro) = (SELECT MAX(LEN(l.logradouro)) FROM enderecos l);









	CREATE TABLE champions(
		id INTEGER PRIMARY KEY IDENTITY(1,1),
		nome VARCHAR(30),
		descricao VARCHAR(100),
		habilidade_1 VARCHAR (50),
		habilidade_2 VARCHAR (50),
		habilidade_3 VARCHAR (50),
		habilidade_4 VARCHAR (50),
		habilidade_5 VARCHAR (50)
		);

		INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2,
			habilidade_3, habilidade_4, habilidade_5)
			VALUES('Katarina',
			'a Lâmina Sinistra',
			'Voracidade',
			'Lâmina Saltitante',
			'Preparação',
			'Shunpo',
			'Lótus da Morte');

		INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2,
			habilidade_3, habilidade_4, habilidade_5)
			VALUES('Yasuo',
			'',
			'Estilo do Errante',
			'Tempestade de Aço',
			'Parede de Vento',
			'Espada Ágil',
			'Último Suspiro');

		INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2,
			habilidade_3, habilidade_4, habilidade_5)
			VALUES('Master Yi',
			'o Espadachim Wuju',
			'Ataque Duplo',
			'',
			'',
			'',
			'');

		INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2,
			habilidade_3, habilidade_4, habilidade_5)
			VALUES('Vayne',
			'a Caçadora Noturna',
			'Caçadora Noturna',
			'Rolamento',
			'Dardos de Prata',
			'Condenar',
			'Hora Final');

		INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2,
			habilidade_3, habilidade_4, habilidade_5)
			VALUES('Lee Sin',
			'o Monge Cego',
			'Agitação',
			'Onda Sônica /
			Ataque Ressonante',
			'Proteger /
			Vontade de Ferro',
			'Tempestade /
			Mutilar',
			'');

		INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2,
			habilidade_3, habilidade_4, habilidade_5)
			VALUES('Vi',
			'a Defensora de Piltover',
			'Blindagem',
			'',
			'Pancada Certeira',
			'Força Excessiva',
			'Saque e Enterrada');

		INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2,
			habilidade_3, habilidade_4, habilidade_5)
			VALUES('Diana',
			'o Escárnio da Lua',
			'Espada de Prata Lunar',
			'Golpe Crescente',
			'Cascata Lívida',
			'Colapso Minguante',
			'Zênite Lunar');

		INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2,
			habilidade_3, habilidade_4, habilidade_5)
			VALUES('Annie',
			'a Criança Sombria',
			'Piromania',
			'Desintegrar',
			'Incinerar',
			'Escudo Fundido',
			'Invocar: 
			Tibbers');

		INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2,
			habilidade_3, habilidade_4, habilidade_5)
			VALUES('Aatrox',
			'',
			'Poço de Sangue',
			'Voo Sombrio',
			'Sede de Sangue /
			Preço em Sangue',
			'Lâminas da Aflição',
			'Massacre');

		SELECT id, nome, descricao, habilidade_1, habilidade_2, habilidade_3,
			habilidade_4, habilidade_5
			FROM champions;

		ALTER TABLE champions ADD sem_habilidade BIT;

		UPDATE champions SET sem_habilidade = 1 WHERE sem_habilidade != '';
		UPDATE champions SET sem_habilidade = 0 WHERE sem_habilidade = '';

		SELECT id, nome, descricao, habilidade_1, habilidade_2, habilidade_3,
			habilidade_4, habilidade_5
			FROM champions;

		SELECT id, nome, descricao, habilidade_1, habilidade_2, habilidade_3,
			habilidade_4, habilidade_5, sem_habilidade 
			FROM champions;

		SELECT id, nome, 
			 CONCAT(SUBSTRING(descricao, 0, 0), 'NULL')
			 AS 'Descrição'
			 FROM champions;

		SELECT id, nome, descricao, habilidade_1, habilidade_2, habilidade_3,
			habilidade_4, habilidade_5
			FROM champions;

		UPDATE champions SET descricao = 'Sem descrição'
			WHERE
			LEN(descricao) = 0;

		SELECT id, nome, descricao, habilidade_1, habilidade_2, habilidade_3,
			habilidade_4, habilidade_5, sem_habilidade 
			FROM champions;

		UPDATE champions SET habilidade_1 = 'Não possui habilidade'
			WHERE
			LEN(habilidade_1) = 0;

		UPDATE champions SET habilidade_2 = 'Não possui habilidade'
			WHERE
			LEN(habilidade_2) = 0;

		UPDATE champions SET habilidade_3 = 'Não possui habilidade'
			WHERE
			LEN(habilidade_3) = 0;

		UPDATE champions SET habilidade_4 = 'Não possui habilidade'
			WHERE
			LEN(habilidade_4) = 0;

		UPDATE champions SET habilidade_5 = 'Não possui habilidade'
			WHERE
			LEN(habilidade_5) = 0;

		SELECT id, nome, descricao, habilidade_1, habilidade_2, habilidade_3,
			habilidade_4, habilidade_5, sem_habilidade 
			FROM champions;

		ALTER TABLE champions DROP COLUMN sem_habilidade;

		SELECT id, nome, descricao, habilidade_1, habilidade_2, habilidade_3,
			habilidade_4, habilidade_5
			FROM champions;

		UPDATE champions SET descricao = 'Honesto / Pacifico'
			WHERE id = 2;

		UPDATE champions SET descricao = 'Forma demoniaca'
			WHERE id = 9;

		UPDATE champions SET habilidade_2 = 'Ataque Alpha',
			habilidade_3 = 'Meditar',
			habilidade_4 = 'Estilo Wuju',
			habilidade_5 = 'Highlander'
			WHERE id = 3;

		UPDATE champions SET habilidade_5 = 'Furia do Dragão'
			WHERE id = 5;

		UPDATE champions SET habilidade_2 = 'Quebra-Cofres'
			WHERE id = 6;

		SELECT id, nome, descricao, habilidade_1, habilidade_2, habilidade_3,
			habilidade_4, habilidade_5
			FROM champions;

		SELECT nome FROM champions;

		SELECT descricao FROM champions;

		SELECT habilidade_1 FROM champions;

		SELECT habilidade_2 FROM champions;

		SELECT habilidade_3 FROM champions;

		SELECT habilidade_4 FROM champions;

		SELECT habilidade_5 FROM champions;

		SELECT id, nome, descricao
			FROM champions
			ORDER BY id
			OFFSET 0 ROWS FETCH NEXT 3 ROWS ONLY;

		SELECT id, nome, descricao
			FROM champions
			ORDER BY id
			OFFSET 3 ROWS FETCH NEXT 3 ROWS ONLY;

		SELECT id, nome, descricao
			FROM champions
			ORDER BY id
			OFFSET 6 ROWS FETCH NEXT 3 ROWS ONLY;

		SELECT habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5
			FROM champions 
			ORDER BY id
			OFFSET 0 ROWS FETCH NEXT 3 ROWS ONLY;

		SELECT habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5
			FROM champions
			ORDER BY id
			OFFSET 3 ROWS FETCH NEXT 3 ROWS ONLY;

		SELECT habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5
			FROM champions
			ORDER BY id
			OFFSET 6 ROWS FETCH NEXT 3 ROWS ONLY;


		SELECT id, nome, descricao, CONCAT(habilidade_1, '-',
			habilidade_2, '-',
			habilidade_3, '-',
			habilidade_4, '-',
			habilidade_5, '-') AS 'Habilidades Concatenadas'
			FROM champions
			WHERE id = 1;