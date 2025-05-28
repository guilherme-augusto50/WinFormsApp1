drop database if exists Compromissos;
create database if not exists Compromissos
character set utf8mb4
collate utf8mb4_unicode_ci;

use Compromissos;

drop table usuarios;
create table if not exists usuarios(
	id_Usuarios int primary key auto_increment,
    nome varchar(100) not null,
    email varchar(100) not null,
    senha varchar(100) not null
);
drop table compromissos;
create table if not exists compromissos(
	id_compromissos int primary key auto_increment,
    dia date not null,
    hora_compromiso varchar(100) not null,
    descricao varchar(100) not null, 
    id_U int,
	foreign key (id_U) references usuarios(id_Usuarios)
);
select * from usuarios;
select * from compromissos;