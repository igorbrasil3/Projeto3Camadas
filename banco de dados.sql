create database Projeto3camadas;
use Projeto3camadas;

create table cliente (
id_cliente int auto_increment primary key,
nome varchar (50) not null,
email varchar(50) not null,
telefone varchar(50) not null,
endereco varchar(50) not null,
forma_pagamento varchar(50) not null
);

DELIMITER $$
create procedure inserir_cliente(
	in Pnome varchar(50),
    in pemail varchar(50),
    in Ptelefone varchar(50), 
    in Pendereco varchar(50),
    in Pforma_pagamento varchar(50))
begin
	insert into cliente(nome, email, telefone, endereco, forma_pagamento)
	values(Pnome,Pemail, Ptelefone, Pendereco, Pforma_pagamento);
end $$
DELIMITER ;

DELIMITER $$
create procedure alterar_cliente(
	in Pid_cliente int,
    in Pnome varchar(50),
    in pemail varchar(50),
    in Ptelefone varchar(50),
    in Pendereco varchar(50),
    in Pforma_pagamento varchar(50))
begin
	update cliente
	set nome = Pnome, email = Pemail, telefone = Ptelefone, endereco = Pendereco, forma_pagamento = Pforma_pagamento
    where id_cliente = Pid_cliente;
end $$
DELIMITER ;

DELIMITER $$
create procedure excluir_cliente(in Pid_cliente int)
begin
	delete from cliente
    where id_cliente = Pid_cliente;
end $$
DELIMITER ;

DELIMITER $$
create procedure selecionar_todos_cliente()
begin
	select* from cliente;
end $$
DELIMITER ;

drop table cliente;
drop  procedure inserir_cliente;
