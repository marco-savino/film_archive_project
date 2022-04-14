create database archivio_film;

use  archivio_film;

create table film(
		id int not null auto_increment primary key,
        titolo varchar(50),
        genere varchar(50),
        durata int);

create table regista(
		id int not null auto_increment primary key,
        nome varchar(50),
        cognome varchar(50));
        
create table attore(
		id int not null auto_increment primary key,
        nome varchar(50),
        cognome varchar(50));
        
        
 create table direzione(
		id int not null auto_increment primary key,
		idRegista int,
        idFilm int,
        FOREIGN KEY (idRegista) REFERENCES regista(id),
        FOREIGN KEY (idFIlm) REFERENCES film(id));


 create table interpretazione(
		id int not null auto_increment primary key,
		idFilm int,
        idAttore int,
        FOREIGN KEY (idFIlm) REFERENCES film(id),
        FOREIGN KEY (idAttore) REFERENCES attore(id),
        protagonista boolean);






insert into film(titolo,durata,genere) values("Mission Impossibile",140,"Azione");
insert into film(titolo,durata,genere) values("Mission Impossibile 2",135,"Azione");
insert into film(titolo,durata,genere) values("Star Trek",110,"Fantascienza");
insert into film(titolo,durata,genere) values("Will Hunting",120,"Drammatico");


insert into regista(nome,cognome) values("Damon","Lindelof"); /* Star trek */
insert into regista(nome,cognome) values("Gus van","Sant"); /* Will hunting */
insert into regista(nome,cognome) values("Brad","Bird"); /* Mission Impossible */

insert into attore(nome,cognome) values("Chris","Pine"); /* Star trek */
insert into attore(nome,cognome) values("Matt","Damon"); /* Will hunting */
insert into attore(nome,cognome) values("Tom","Cruise"); /* Mission Impossible */

insert into direzione(idRegista,idFIlm) values (1,3); /* 1 -Star trek */
insert into direzione(idRegista,idFIlm) values (2,4);  /* 2 - Will hunting */
insert into direzione(idRegista,idFIlm) values (3,1); /* 3 - Mission Impossible */
insert into direzione(idRegista,idFIlm) values (3,2); /* 4 -Mission impossible */

insert into interpretazione(idFilm,idAttore,protagonista) values (3,1,true); /* 1 -Star trek */
insert into interpretazione(idFilm,idAttore,protagonista) values (4,2,true);  /* 2 - Will hunting */
insert into interpretazione(idFilm,idAttore,protagonista) values (1,3,true); /* 3 - Mission Impossible */
insert into interpretazione(idFIlm,idAttore,protagonista) values (2,3,true); /* 4 -Mission impossible */



select regista.nome, regista.cognome  from regista inner join direzione on regista.id=direzione.idRegista where regista.nome = "Gus van";


select * from film;
select * from regista;
select * from attore;

select * from direzione;

select * from interpretazione;