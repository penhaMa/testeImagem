create database cadastro;

use cadastro;

create table pessoa(
    codigo int primary key auto_increment not null,
    nome varchar(150) not null,
    foto longblob not null
)engine=innodb; 




