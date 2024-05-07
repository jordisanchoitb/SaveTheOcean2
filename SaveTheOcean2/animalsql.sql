drop table if exists animal;
drop table if exists rescuedanimal;

create table animal (
    id serial primary key not null,
    name varchar,
    specie varchar,
    superfamily varchar,
    weightaprox decimal
);

INSERT INTO animal (name, specie, superfamily, weightaprox) VALUES('Donatello', 'Tortuga babaua', 'Tortuga marina', 120.0);
INSERT INTO animal (name, specie, superfamily, weightaprox) VALUES('Leonardo', 'Tortuga llaüt', 'Tortuga marina', 500.0);
INSERT INTO animal (name, specie, superfamily, weightaprox) VALUES('Shellby', 'Tortuga verda', 'Tortuga marina', 90.0);

INSERT INTO animal (name, specie, superfamily, weightaprox) VALUES('Skye', 'Gaviota de audouin', 'Au marina', 0.65);
INSERT INTO animal (name, specie, superfamily, weightaprox) VALUES('Marlin', 'Pardela cenicienta', 'Au marina', 1.0);
INSERT INTO animal (name, specie, superfamily, weightaprox) VALUES('Albatros', 'Alcatraz comu', 'Au marina', 2.0);
INSERT INTO animal (name, specie, superfamily, weightaprox) VALUES('Oceana', 'Cormoran gran', 'Au marina', 3.0);

INSERT INTO animal (name, specie, superfamily, weightaprox) VALUES('Moby', 'Delfín mular', 'Cetáceo', 300.0);
INSERT INTO animal (name, specie, superfamily, weightaprox) VALUES('Ondina', 'Orca transeúntes', 'Cetáceo', 3810.0);
INSERT INTO animal (name, specie, superfamily, weightaprox) VALUES('Luna', 'Ballena de groenlandia', 'Cetáceo', 75000.0);
INSERT INTO animal (name, specie, superfamily, weightaprox) VALUES('Fluke', 'Marsopas comun', 'Cetáceo', 53.0);

create table rescuedanimal (
	id serial primary key not null,
	idrescured varchar,
	rescuedate date,
	superfamily varchar,
	gradeafectation numeric,
	location varchar,
	nameplayer varchar,
	isRescued boolean
);




