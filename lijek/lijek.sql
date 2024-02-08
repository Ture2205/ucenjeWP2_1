create database lijek;

use lijek;

--create table pacijent(
--sifra int not null primary key,
--ime varchar(20) not null,
--prezime varchar(20) not null,
--datumro�enja datetime,
--spol varchar(20) not null,
--lijek varchar(30) not null
--);

--create table lijek(
--sifra int not null primary key,
--tip varchar(30) not null,
--doza int not null,
--brojtableta int not null,
--nacinprimjene varchar(20),
--datumpodizanja datetime
--);

--create table doga�aj(
--doza int not null primary key,
--pacijent varchar(30) not null,
--lijek varchar (30) not null,
--vrijemeuzimanja datetime
--);

--select *from lijek;

--select *from pacijent;

--insert into pacijent values('1001', 'Mario','Tur�ek','1995-05-22','M','Eutyrox')
--select *from lijek;
--insert into lijek values ('1001', 'na recept','1', '52', 'oralno', '2023-11-27')

--select *from doga�aj;

--insert into doga�aj values('75', 'Mario', 'Eutyrox', '2023-11-27')

--Pacijent mo�e imati vi�e lijekova (jedan-na-vi�e veza).
--Svaki lijek pripada samo jednom pacijentu.


CREATE DATABASE lijek;

USE lijek;

CREATE TABLE pacijent (
    sifra INT NOT NULL PRIMARY KEY,
    ime VARCHAR(20) NOT NULL,
    prezime VARCHAR(20) NOT NULL,
    datumro�enja DATETIME,
    spol VARCHAR(20) NOT NULL,
    lijek VARCHAR(30) NOT NULL
);

CREATE TABLE lijek (
    sifra INT NOT NULL PRIMARY KEY,
    tip VARCHAR(30) NOT NULL,
    doza INT NOT NULL,
    brojtableta INT NOT NULL,
    nacinprimjene VARCHAR(20),
    datumpodizanja DATETIME
);

CREATE TABLE doga�aj (
    doza INT NOT NULL,
    pacijent INT NOT NULL,
    lijek INT NOT NULL,
    vrijemeuzimanja DATETIME,
    PRIMARY KEY (doza, pacijent, lijek),
    FOREIGN KEY (pacijent) REFERENCES pacijent(sifra),
    FOREIGN KEY (lijek) REFERENCES lijek(sifra)
);

-- Unos podataka
INSERT INTO pacijent VALUES (1001, 'Mario', 'Tur�ek', '1995-05-22', 'M', 'Eutyrox');
INSERT INTO lijek VALUES (1001, 'na recept', 1, 52, 'oralno', '2023-11-27');
--UPDATE lijek VALUES (1001, 'na recept', 1, 52, 'oralno', CAST('2023-11-27' AS DATETIME));
SELECT *FROM LIJEK;
SELECT *FROM doga�aj;