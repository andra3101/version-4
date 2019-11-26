DROP DATABASE IF EXISTS parchis;
CREATE DATABASE parchis;

USE parchis;

CREATE TABLE Jugador(
	Id INT PRIMARY KEY NOT NULL,
	Nombre VARCHAR(20),
	Pass VARCHAR(20),
	Edad INT
)ENGINE = InnoDB;

CREATE TABLE Partida(
	Id INT PRIMARY KEY NOT NULL,
	Ganador VARCHAR(20),
	Perdedor VARCHAR(20),
	Fecha VARCHAR(20),
	PuntosGanador INT,
	PuntosPerdedor INT
)ENGINE = InnoDB;

CREATE TABLE Relacion(
	IdJugador INT,
	FOREIGN KEY(IdJugador) REFERENCES Jugador(Id),
	IdPartida INT,
	FOREIGN KEY(IdPartida) REFERENCES Partida(Id),
	Puntos INT,
	Color VARCHAR(10),
	Sacar5 INT
)ENGINE = InnoDB;

INSERT INTO Jugador (Id,Nombre,Pass,Edad) VALUES (1,'Marcus','qwerty',23);
INSERT INTO Jugador (Id,Nombre,Pass,Edad) VALUES (2,'Jordi','123456',5);
INSERT INTO Jugador (Id,Nombre,Pass,Edad) VALUES (3,'Andra','hola',5);
INSERT INTO Jugador (Id,Nombre,Pass,Edad) VALUES (4,'Gabriel','zxcvbn',19);
INSERT INTO Jugador (Id,Nombre,Pass,Edad) VALUES (5,'Luis','123456',19);

INSERT INTO Partida (Id, Ganador, Perdedor, Fecha, PuntosGanador, PuntosPerdedor) VALUES (1,'Marcus','Jordi','2019-10-06',50,2);
INSERT INTO Partida (Id, Ganador, Perdedor, Fecha, PuntosGanador, PuntosPerdedor) VALUES (2,'Andra','Gabriel','2018-06-13',20,14);


INSERT INTO Relacion (IdJugador, IdPartIda, Puntos, Color, Sacar5) VALUES (1,1,50,'rojo',10);
INSERT INTO Relacion (IdJugador, IdPartIda, Puntos, Color, Sacar5) VALUES (2,1,20,'azul',10);
INSERT INTO Relacion (IdJugador, IdPartIda, Puntos, Color, Sacar5) VALUES (3,1,30,'verde',10);
INSERT INTO Relacion (IdJugador, IdPartIda, Puntos, Color, Sacar5) VALUES (4,1,10,'amarillo',10);

INSERT INTO Relacion (IdJugador, IdPartIda, Puntos, Color, Sacar5) VALUES (1,2,50,'rojo',10);
INSERT INTO Relacion (IdJugador, IdPartIda, Puntos, Color, Sacar5) VALUES (3,2,30,'verde',10);
INSERT INTO Relacion (IdJugador, IdPartIda, Puntos, Color, Sacar5) VALUES (4,2,10,'amarillo',10);


