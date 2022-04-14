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
        FOREIGN KEY (idAttore) REFERENCES attore(id));




insert into film(titolo,durata,genere) values("Mission Impossibile",140,"Azione");
insert into film(titolo,durata,genere) values("Mission Impossibile",135,"Azione");
insert into film(titolo,durata,genere) values("Star Trek",110,"Fantascienza");
insert into film(titolo,durata,genere) values("Will Hunting",120,"Drammatico");

insert into film(titolo,durata,genere) values("Mission Impossibile",140,"Azione");
insert into film(titolo,durata,genere) values("Mission Impossibile",135,"Azione");
insert into film(titolo,durata,genere) values("Star Trek",110,"Fantascienza");
insert into film(titolo,durata,genere) values("Will Hunting",120,"Drammatico");


insert into regista(nome,cognome) values("Damon","Lindelof"); /* Star trek */
insert into regista(nome,cognome) values("Gus van","Sant"); /* Will hunting */
insert into regista(nome,cognome) values("Brad","Bird"); /* Mission Impossible */

insert into attore(nome,cognome) values("Chris","Pine"); /* Star trek */
insert into attore(nome,cognome) values("Matt","Damon"); /* Will hunting */
insert into attore(nome,cognome) values("Tom","Cruise"); /* Mission Impossible */


alter table attore drop column  protagonista ;
alter table interpretazione add protagonista boolean;

insert into direzione(idRegista,idFIlm) values (1,0);
insert into direzione(idRegista,idFIlm) values (2,0);
insert into direzione(idRegista,idFIlm) values (3,0);
insert into direzione(idRegista,idFIlm) values (4,0);

select * from film;




