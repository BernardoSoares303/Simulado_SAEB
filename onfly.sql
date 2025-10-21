create database onfly;

use onfly;

create table usuarios(
	id_usuario int not null primary key auto_increment,
    nome_usuario varchar(100) unique not null,
    senha_usuario varchar(100) not null
);

create table Passagem(
	id INT AUTO_INCREMENT PRIMARY KEY,
    companhia_aerea VARCHAR(100) NOT NULL,
    origem VARCHAR(100) NOT NULL,
    destino VARCHAR(100) NOT NULL,
    data_partida DATE NOT NULL,
    hora_partida TIME NOT NULL,
    preco DECIMAL(10,2) NOT NULL
);

select * from usuarios;