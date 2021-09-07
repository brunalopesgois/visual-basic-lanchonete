use lanchonete;

CREATE TABLE tbPedido (
idPedido int not null primary key,
dataCompra DATETIME,
formaPagamento VARCHAR(40),
valorTotal REAL,
usuario varchar(60),
mesAno varchar(10),
)

CREATE TABLE tbDetalhePedido (
idDetalhePedido INTEGER not null PRIMARY KEY,
idPedido INTEGER not null,
descricao VARCHAR(60 ),
valor REAL,
observacao VARCHAR(100 ),
FOREIGN KEY(idPedido) REFERENCES tbPedido (idPedido)
)

CREATE TABLE tbEntrada (
idEntrada INTEGER not null PRIMARY KEY,
descricao VARCHAR(60 ),
valor real,
data DATETIME,
classificacao VARCHAR( 40),
mesAno varchar(10)
)

CREATE TABLE tbSaida (
idSaida INTEGER PRIMARY KEY,
descricao VARCHAR( 60),
valor real,
data DATETIME,
classificacao VARCHAR(40 ),
mesAno varchar(10)
)

CREATE TABLE tbLogin (
idLogin INTEGER NOT NULL PRIMARY KEY,
usuario VARCHAR(60),
email VARCHAR(255),
senha VARCHAR(20)
)

CREATE TABLE tbProduto (
idProduto INTEGER NOT NULL PRIMARY KEY,
descricao VARCHAR(255),
quantidade NUMERIC,
preco NUMERIC,
categoria VARCHAR(255),
tipoUnitario VARCHAR(2)
)