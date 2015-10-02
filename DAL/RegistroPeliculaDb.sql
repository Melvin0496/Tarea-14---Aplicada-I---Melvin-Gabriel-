--create database RegistroPeliculaDb;

use RegistroPeliculaDb;

create table Peliculas(
PeliculaId int primary key identity(1,1),
Titulo varchar(50),
Descripcion varchar(100),
Ano int,
Calificacion int,
IMDB int,
CategoriaId int
);