select * from smjerovi;

select naziv, cijena from smjerovi;

select naziv, 'Osijek', 8, 9.8 from smjerovi;

select naziv as smjer, 'Osijek' as grad from smjerovi;

select naziv, len(naziv) as duzina,
getdate() as datum from smjerovi;

select 1;

select sifra as s, naziv as n, 'Edunova' as skola,
len(naziv) as duzina, * from smjerovi;

select * from smjerovi where sifra=1;

select * from polaznici where sifra!=7;

select *from polaznici where ime='Ivan';

select *from grupe where datumpocetka> '2023-09-01';

select * from polaznici where
not ime='Ivan';

select * from polaznici where ime not like '%a%';

select *from polaznici where prezime like 'B%žiæ';

select *from polaznici where prezime like '$nt';

select *from polaznici where 
sifra=2 or sifra=4 or sifra=7;

select *from polaznici where sifra not in (2,4,7);

select *from polaznici where 
sifra >=6 and sifra<=10;

select *from polaznici where
sifra between 6 and 10;


select * from grupe where
datumpocetka between '2023-01-01' and '2023-12-31';

select *from smjerovi;

select *from smjerovi where brojsati=null;


select *from smjerovi where brojsati is not null;


select isnull( brojsati,30) as bs from smjerovi;


select *from polaznici order by prezime desc, 2 desc;


select top 10 *from polaznici;

select top 10 percent *from polaznici;


select ime as djever, brojugovora as racun 
into nova
from polaznici;


select *from nova;

drop table nova;