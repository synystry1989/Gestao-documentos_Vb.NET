

--usar nvarchar para conversoes internacionais de caracteres
--retirar ID pois nao necessitamos de dois codigos unicos , sendo que iremos criar um codigo unico e personalizado substituimos o ID 

CREATE DATABASE DB_Ex1_Vimaponto

GO

USE  DB_Ex1_Vimaponto
IF NOT EXISTS (SELECT * FROM sys.tables WHERE NAME = 'Clientes')
BEGIN
CREATE TABLE Clientes (
	CodigoCl NVARCHAR(20)  NOT NULL CONSTRAINT Clientes_Codigo_PK PRIMARY KEY(CodigoCl),
    Nome NVARCHAR(200) NOT NULL,
	NIF INT NOT NULL,
    Email NVARCHAR(200) NULL,
    Telefone NVARCHAR(50) NULL,
    Morada NVARCHAR(250) NOT NULL,	
	Estado BIT NOT NULL	CONSTRAINT Clientes_Estado_PK DEFAULT(1),
	
);
END

GO

--ver a questao do codigo ou id
--com a alteração do codigo ou id ver a necessidade de manter, reducir ou aumentar campos

IF NOT EXISTS (SELECT * FROM sys.tables WHERE NAME = 'Produtos')
BEGIN
CREATE TABLE Produtos (
    CodigoPr NVARCHAR(20)  NOT NULL CONSTRAINT Produtos_Codigo_PK PRIMARY KEY(CodigoPr),
    NomeProduto NVARCHAR(100) NOT NULL,
    Observacao NVARCHAR(250) NULL,
	Unidade NVARCHAR(10) NOT NULL,
	--(comprimento total, nr casas decimais)
	PrecoUnt DECIMAL (18,9) NOT NULL,
	
);
END

GO

--ver a questao do codigo ou id
--com a alteração do codigo ou id ver a necessidade de manter, reducir ou aumentar campos

IF NOT EXISTS (SELECT * FROM sys.tables WHERE NAME = 'TipoDocumentos')
BEGIN
CREATE TABLE TipoDocumentos (
    CodigoDoc NVARCHAR(20)   NOT NULL CONSTRAINT TipoDocumentos_Codigo_PK PRIMARY KEY(CodigoDoc),
    Descricao NVARCHAR(100) NOT NULL,
	UltimoNrEmitido INT NOT NULL

	--dado que apenas teremos os tipos de documentos existentes nem mais nem menos (nao serao repetidos) podemos
	--utilizar o tipo de documento para chave primaria
);
 END

 GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE NAME = 'CabecLinhas')
BEGIN
CREATE TABLE CabecLinhas (

    ID UNIQUEIDENTIFIER NOT NULL CONSTRAINT CabecLinhas_ID_PK PRIMARY KEY (ID),
	TipoDocumento NVARCHAR(20) NOT NULL CONSTRAINT CabecLinhas_TipoDocumento_FK FOREIGN KEY (TipoDocumento) REFERENCES TipoDocumentos(CodigoDoc) ,
	NrDocumento INT NOT NULL,
	Cliente NVARCHAR(20) NOT NULL CONSTRAINT CabecLinhas_Cliente_FK FOREIGN KEY (Cliente) REFERENCES Clientes(CodigoCl),
	NIF INT NOT NULL,	
    Telefone NVARCHAR(50) NULL,
    Morada NVARCHAR(250) NOT NULL,
	DataModificacao DATETIME NULL,
	Estado BIT NOT NULL CONSTRAINT CabecLinhas_Estado_DF DEFAULT(1), 
	CONSTRAINT CabecLinhas_TipoDocumento_NrDocumento_UN UNIQUE (TipoDocumento, NrDocumento)

);
END

GO
 

--ver a questao do guid ou int IDENTITY
--de uma forma geral a unica vantagem da forma tradicional é alem do habito /conforto de nao alterar o que funciona, 
--o tamanho da memoria que ocupa , sensivelmente menor que o GUID
--melhor performance em indices cluster

--tendo em conta as vantagens do GUID

--Elimina problemas clássicos de chave primária IDENTITY, pois o limite de registros aumenta consideravelmente
--Torna imprevisível uma pesquisa por dados , melhorando a segurança
--Elimina quase todos os problemas de concorrência relacionados com inserção e atualização de registros. Os demais podem ser resolvidos com transações explícitas;
--Migrações e junções de dados ficam tremendamente mais simples, visto que não há o problema de reservar faixas de valores para a chave primária pois ela é aleatoria e nunca se repete
--de uma forma geral o GUID aumenta a seguranca de acesso aos dados e permite uma unificaçao limpa e indolor na eventualidade 
--da juncao de bases de dados de origens diferentes permitindo num futuro a inclusao em outros projetos sistemas ja existentes sem problemas de " conversâo

--pode por outro lado levar a alguma perda de performance na pesquisa de indices clusterizados
--overhead de desempenho (10%)
-- maior volume de memoria ocupado (É preciso uma ressalva aqui: a diferença não é tão gritante quanto se imagina, sobretudo considerando os volumes de dados suportados pelos serviços de hospedagem atuais.

--ALTER TABLE CLIENTES ADD CONSTRAINT CLIENTES_TESTE_DF DEFAULT(0) FOR TESTE;
--ADD CONSTRAINT CLIENTES_CODIGO_PK FOR CODIGO;



IF NOT EXISTS (SELECT * FROM sys.tables WHERE NAME = 'LinhasProdutos')
BEGIN
CREATE TABLE LinhasProdutos (

    ID UNIQUEIDENTIFIER NOT NULL CONSTRAINT ListaProdutos_ID_PK PRIMARY KEY(ID),
	CabProdutoID UNIQUEIDENTIFIER NOT NULL 	CONSTRAINT LinhasProdutos_CabecLinhas_FK FOREIGN KEY (CabProdutoID) REFERENCES CabecLinhas(ID),
	NumLinha INT ,
	Produto NVARCHAR(20) NOT NULL  CONSTRAINT LinhasProdutos_Produtos_FK FOREIGN KEY (Produto) REFERENCES Produtos(CodigoPr),
	Descricao NVARCHAR(100) NOT NULL,
	PrecoUnt DECIMAL (18,9) NOT NULL,
	Quantidade DECIMAL NOT NULL,
	DataEntrega DATETIME NOT NULL,
  	
);
END

GO

-- Popular a tabela Clientes
INSERT INTO Clientes (CodigoCl, Nome, NIF, Telefone, Morada, Estado)
VALUES ('CL001', 'João Silva', 123456789, '912345678', 'Rua dos Pinheiros, 123', 1),
       ('CL002', 'Maria Rodrigues', 987654321, '963852741', 'Avenida dos Açores, 456', 1),
	   ('CL003', 'bruno fernandes', 3434322, '4567773', 'Rua dos patos, 123', 1),
       ('CL004', 'Mario castro', 9654321, '9652741', 'Avenida dos Açores, 456', 1);
GO

-- Popular a tabela Produtos
INSERT INTO Produtos (CodigoPr, NomeProduto, Observacao, Unidade, PrecoUnt)
VALUES 
('PR001', 'Produto 1', 'Descrição do produto 1','KG',  10.99),
('PR002', 'Produto 2', 'Descrição do produto 2','Mm', 100),
('PR003', 'Produto 3', 'Descrição do produto 3','Lts ',30),
('PR004', 'Produto 4', 'Descrição do produto 4', '€', 40.99);

GO


-- Popular a tabela TipoDocumentos
INSERT INTO TipoDocumentos (CodigoDoc, Descricao,UltimoNrEmitido)
VALUES 
('EDC', 'Encomenda de cliente',0),
('NDC', 'Nota de Credito',0),
('FC', 'Fatura de Cliente',0),
('ORC', 'Orçamento de Cliente',0);

GO
--Popular a tabela CabProdutos

INSERT INTO CabecDocumento(ID, TipoDocumento, NrDocumento, Cliente, NIF, Telefone, Morada, DataModificacao, Estado)
VALUES (NEWID(), 'EDC', 1, 'CL001', 123456789, '912345678', 'Rua dos Pinheiros, 123', GETDATE(),  1),
       (NEWID(), 'FC', 1, 'CL002', 987654321, '963852741', 'Avenida dos Açores, 456', GETDATE(), 1);

GO

-- Popular a tabela ListaProdutos
INSERT INTO LinhasProdutos (ID, CabProdutoID,NumLinha, Produto, Descricao, PrecoUnt, Quantidade, DataEntrega)
VALUES 
(NEWID(),(SELECT ID FROM CabecDocumento WHERE NrDocumento = 1 and TipoDocumento = 'FC'),1, 'PR001',(SELECT NomeProduto FROM Produtos WHERE CodigoPr = 'PR001'),(SELECT PrecoUnt FROM Produtos WHERE CodigoPr = 'PR001'), 2,  GETDATE()),
(NEWID(),(SELECT ID FROM CabecDocumento WHERE NrDocumento = 1 and TipoDocumento = 'EDC'),1, 'PR002', (SELECT NomeProduto FROM Produtos WHERE CodigoPr = 'PR002'), (SELECT PrecoUnt FROM Produtos WHERE CodigoPr = 'PR002'), 3,  GETDATE());
GO



