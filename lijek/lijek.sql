create database lijek;

use lijek;

create table pacijent(
sifra int not null primary key,
ime varchar(20) not null,
prezime varchar(20) not null,
datumroðenja datetime,
spol varchar(20) not null,
lijek varchar(30) not null
);

create table lijek(
sifra int not null primary key,
tip varchar(30) not null,
doza int not null,
brojtableta int not null,
nacinprimjene varchar(20),
datumpodizanja datetime
);

select *from lijek;

select *from pacijent;

insert into pacijent values('1001', 'Mario','Turèek','1995-05-22','M','Eutyrox')
select *from lijek;
insert into lijek values ('1001', 'na recept','1', '52', 'oralno', '2023-11-27')

--Pacijent može imati više lijekova (jedan-na-više veza).
--Svaki lijek pripada samo jednom pacijentu.