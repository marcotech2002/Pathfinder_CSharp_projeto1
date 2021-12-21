
--create table tb_pessoa
--(
--	id_pessoa int Identity(1, 1),
--	nome_pessoa varchar(80) not null,
--	email_pessoa varchar(35) not null,
--	ativo_pessoa bit not null,
--	constraint pk_id_pessoa primary key (id_pessoa)
--);

--create table tb_categoria
--(
--	id_categoria int Identity(1, 1),
--	nome_categoria varchar(20) not null,
--	constraint pk_id_categoria primary key (id_categoria)
--);

--create table tb_cliente
--(
--	id_pessoa int,
--	id_categoria int not null,
--	ddd_cliente numeric(2) not null,
--	telefone_cliente varchar(9) not null,
--	cep_cliente char(8) not null,
--	uf_cliente char(2) not null,
--	cidade_cliente varchar(30) not null,
--	bairro_cliente varchar(20) not null,
--	logradouro_cliente varchar(30) not null,
--	constraint pk_id_pessoa2 primary key (id_pessoa),
--	constraint fk_id_pessoa foreign key (id_pessoa)
--		references tb_pessoa (id_pessoa),
--	constraint fk_id_categoria foreign key (id_categoria)
--		references tb_categoria (id_categoria)
--);

--create table tb_dependente
--(
--	id_pessoa int,
--	id_cliente int,
--	parentesco_dependente varchar(10),
--	constraint pk_id_pessoa3 primary key (id_pessoa),
--	constraint fk_id_pessoa2 foreign key (id_pessoa)
--		references tb_pessoa (id_pessoa),
--	constraint pk_id_cliente foreign key (id_cliente)
--		references tb_cliente (id_pessoa)
--);

--create table tb_mensalidade
--(
--	id_mensalidade int Identity(1, 1),
--	id_pessoa int not null,
--	dtv_mensalidade Date not null,
--	vlri_mensalidade float not null,
--	dtp_mensalidade Date not null,
--	juros_mensalidade int not null,
--	vlrf_mensalidade float not null,
--	quitada_mensalidade bit not null,
--	constraint pk_id_mensalidade primary key (id_mensalidade),
--	constraint fk_id_pessoa3 foreign key (id_pessoa)
--		references tb_cliente (id_pessoa)
--);

--use [CLUBE]
--go
--select tb_cliente.id_pessoa, tb_pessoa.nome_pessoa, tb_categoria.nome_categoria, tb_pessoa.email_pessoa, 
--       tb_cliente.ddd_cliente, tb_cliente.telefone_cliente, tb_cliente.cep_cliente, tb_cliente.uf_cliente,
--       tb_cliente.cidade_cliente, tb_cliente.bairro_cliente, tb_cliente.logradouro_cliente,
--       tb_pessoa.ativo_pessoa
--from tb_cliente
--inner join tb_pessoa
--    on tb_cliente.id_pessoa = tb_pessoa.id_pessoa
--inner join tb_categoria
--    on tb_cliente.id_categoria = tb_categoria.id_categoria
--order by tb_cliente.id_pessoa asc
--go

--use [CLUBE]
--go
--select tb_pessoa.id_pessoa, tb_pessoa.nome_pessoa, tb_pessoa.email_pessoa, 
--		tb_dependente.parentesco_dependente, tb_pessoa.ativo_pessoa
--from tb_dependente
--inner join tb_pessoa
--     on tb_dependente.id_pessoa = tb_pessoa.id_pessoa
--inner join tb_cliente
--     on tb_dependente.id_cliente = tb_cliente.id_pessoa
--order by tb_dependente.id_pessoa asc
--go


--use [CLUBE]
--go
--select nome_categoria from tb_categoria order by id_categoria asc
--go

--use [CLUBE]
--go
--select tb_pessoa.nome_pessoa
--from tb_pessoa
--inner join tb_cliente
--     on tb_cliente.id_pessoa = tb_pessoa.id_pessoa
--order by tb_cliente.id_pessoa asc
--go

--use [CLUBE]
--go
--SELECT @@IDENTITY  AS 'Identity';
--go

--insert into tb_categoria (nome_categoria)
--	values ('diamante')

--select id_mensalidade, dtv_mensalidade, vlri_mensalidade, dtp_mensalidade, juros_mensalidade, 
--vlrf_mensalidade, quitada_mensalidade
--from tb_mensalidade where id_pessoa = 1 order by id_mensalidade asc


--select tb_pessoa.id_pessoa, tb_pessoa.nome_pessoa, tb_cliente.id_categoria, tb_pessoa.email_pessoa,
--tb_cliente.ddd_cliente, tb_cliente.telefone_cliente, tb_cliente.cep_cliente, tb_cliente.uf_cliente, 
--tb_cliente.cidade_cliente, tb_cliente.bairro_cliente, tb_cliente.logradouro_cliente, 
--tb_pessoa.ativo_pessoa
--from tb_cliente
--inner join tb_pessoa
--     on tb_cliente.id_pessoa = tb_pessoa.id_pessoa
--where tb_pessoa.id_pessoa = 1

--use [CLUBE]
--go
--select * from tb_categoria
--go

--select tb_cliente.id_pessoa, tb_pessoa.nome_pessoa, tb_cliente.id_categoria, tb_pessoa.email_pessoa, 
--tb_cliente.ddd_cliente, tb_cliente.telefone_cliente, tb_cliente.cep_cliente, tb_cliente.uf_cliente,
--tb_cliente.cidade_cliente, tb_cliente.bairro_cliente, tb_cliente.logradouro_cliente,
--tb_pessoa.ativo_pessoa
--from tb_cliente
--inner join tb_pessoa
--   on tb_cliente.id_pessoa = tb_pessoa.id_pessoa
--where tb_cliente.id_pessoa = 1

select * from tb_dependente
