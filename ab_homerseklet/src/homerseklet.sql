create table homerseklet(
azon int not null primary key,
varos varchar(40) not null,
napszak varchar(10) not null,
datum date not null,
ertek float(3,1) not null,
csapadek int null
);

insert into homerseklet(azon, varos,napszak,datum,ertek,csapadek)
values
(31,"Budapest","este","2008-01-12",1.8,12),
(32,"Ózd","reggel","2009-12-28",5.5,5),
(38,"Vác","reggel","2012-06-28",32.8,0),
(39,"Vác","délután","2014-10-18",16.5,4),
(40,"Ózd","este","2018-03-28",21.7,0);
