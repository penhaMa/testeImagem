create database cadastro;

use cadastro;

drop table pessoa;

create table pessoa(
    codigo int primary key auto_increment not null,
    nome varchar(150) not null,
    unidade varchar(150) not null,
    CPF bigint(20) not null,
    cidade varchar(150) not null,
    estado varchar(150) not null,
    celular int not null,
    foto longblob not null
)engine=innodb; 

select * from pessoa;