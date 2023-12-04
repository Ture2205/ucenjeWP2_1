create database zadatak;
use zadatak;

create table zupanija (
sifra int primary key not null,
naziv varchar(20) not null,
zupan varchar(20) not null
);


create table opcina (
sifra int primary key identity (1001, 1) not null,
naziv varchar (50) not null,
zupanija int not null foreign key references zupanija (sifra)
);

create table mjesto(
sifra int primary key identity (200, 1) not null,
naziv varchar (50) not null,
opcina int not null foreign key references opcina(sifra)
);


create table zupan(
sifra int primary key identity (200, 1) not null,
ime varchar(50) not null,
prezime varchar(50) not null
);

insert into zupanija values('33000', 'Viroviti�ka', 'Igor Androvi�')
insert into zupanija values('31000', 'Osjecko baranjska', 'Mato Luki�')
insert into zupanija values('33000', 'Po�e�ko slavonska', 'Antonija Jozi�')

select *from zupanija;

insert into opcina values ('Sopje', '33525')
insert into opcina values ('�a�avica', '33523')
insert into opcina values('Nova Bukovica', '33518')
