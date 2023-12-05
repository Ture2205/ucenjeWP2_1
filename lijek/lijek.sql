create database lijek;

use lijek;

create table pacijent(
sifra int not null primary key,
ime varchar(20) not null,
prezime varchar(20) not null,
datumro�enja datetime,
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

insert into pacijent values('1001', 'Mario','Tur�ek','1995-05-22','M','Eutyrox')
select *from lijek;
insert into lijek values ('1001', 'na recept','1', '52', 'oralno', '2023-11-27')

--Pacijent mo�e imati vi�e lijekova (jedan-na-vi�e veza).
--Svaki lijek pripada samo jednom pacijentu.