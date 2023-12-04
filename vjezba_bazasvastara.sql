--baza svaštara
--poklon za svatove u rasponu od 1000 do 1100 eura, koliko artikala se može kupiti

--use svastara;

select count (*)from artikli
where cijena between 1000 and  1100;

--izlistati sva mjesta u opæini èepin

select b.*
from opcine a inner join mjesta b
on a.sifra= b.opcina
where a.naziv='Èepin';

--postavite beketincima poštanski broj 31431

update mjesta set postanskiBroj= '31431' where sifra=1945;

--izlistatjte imena i prezimena svih kupaca iz mjesta Livana

select b.ime, b.prezime
from mjesta a inner join kupci b
on b.mjesto = a.sifra
where a.naziv='Slatina';


--koliko je bilo primki u 2017
select count(*) from primke where 
datum between '2017-01-01' and '2017-12-31';
--
select top 1 * from primke


select top 1 * from primke where 
datum between '2017-01-01' and '2017-12-31';

--što smo sve zaprimili na primci 14778/2017

select c.kratkinaziv, b.kolicina,b.cijena,
b.kolicina *b.cijena as iznos
from primke a
inner join artiklinaprimci b on a.sifra=b.primka
inner join artikli c on b.artikl = c.sifra
where a.rednibroj='14778/2017'
order by 4 desc;


--ukupni iznos na toj primci

select sum(b.kolicina * b.cijena) as ukupniznos
from primke a
inner join artiklinaprimci b on a.sifra=b.primka
inner join artikli c on b.artikl = c.sifra
where a.rednibroj='14778/2017';

--koliki su iznosi na svim primkama u sijeènju 2017 godine
select a.rednibroj, sum(b.kolicina * b.cijena) as ukupniznos
from primke a
inner join artiklinaprimci b on a.sifra=b.primka
inner join artikli c on b.artikl = c.sifra
where a.datum between '2017-01-01' and '2017-01-31'
group by a.rednibroj
order by 2 desc;

--koji dobavljaè je to dobavio u upit

select a.rednibroj, d.naziv,
sum(b.kolicina * b.cijena) as ukupniznos,
avg(b.kolicina * b.cijena) as prosjek,
min(b.kolicina * b.cijena) as minimalno,
max(b.kolicina * b.cijena) as maksimalno
from primke a
inner join artiklinaprimci b on a.sifra=b.primka
inner join artikli c on b.artikl = c.sifra
inner join dobavljaci d on a.dobavljac=d.sifra
where a.datum between '2017-01-01' and '2017-01-31'
group by a.rednibroj, d.naziv
having sum(b.kolicina * b.cijena)>7000000
order by 3 desc;

--traženje igle u plastu sijena
--obrisati sve artikle koji nisu nikada nabavljeni

select count(*) from artikli;

select distinct artikl from artiklinaprimci;

select *from artikli where sifra
not in(select distinct artikl from artiklinaprimci);

--brisanje artikla

delete from artikli where sifra
not in(select distinct artikl from artiklinaprimci);

--dz
--update i delete pomoæu spajanja tablica

update orders
set customername='novi kupac'
from orders 
join orderdetails on orders.orderid = orderdetails.orderid
where orderdetail.productname='product a';