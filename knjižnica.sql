

select top 10 ime, prezime from autor;

select count(*) from autor;

-- izlistaj sve autore koji su rođeni u tvojoj godini rođenja

select *from autor where 
datumrodenja between '1995-01-01' and '1995-12-31';


--unesi sebe kao autora

insert into autor (sifra, ime, prezime,datumrodenja) values (123576, 'Mario', 'Turcek','1995-05-22' );


select *from katalog where
(naslov like '%bol' or naslov like '%ljubav')
and sifra not in (2541,2596,2680);

--neaktivni izdavači

select *from izdavac
where aktivan like '%0';


--izlistaj sve izdavače koji su drustva s ogranicenom odgovornoscu


select *from izdavac
where naziv like '%d%o%o%';

--izlistati sva smjesta u osjecko-baranjskoj zupaniji

select *from mjesto
where postanskibroj like '31%';

-- izlistaj sve autorice

select *from autor;

select distinct ime from autor
where ime like '%a';

select getdate();