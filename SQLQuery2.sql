--use master;
--go
--drop database if exists edunovawp2;
--go
--create table dijete(
--ime varchar(50),
--prezime varchar(50),
--radionica varchar(50),
--uciteljica varchar(50)
--);

--create table radionica(
--ime varchar(50),
--vrijeme datetime,
--uciteljica varchar(50)
--);

create table uciteljica(
ime varchar(50),
radionica varchar(50),
sifra int
);
