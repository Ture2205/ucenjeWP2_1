use pacijent;

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