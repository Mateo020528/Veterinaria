USE bl0sp4y0biwcqjb7myr9;
/*Tabla propietarios*/
CREATE TABLE Owners (
Id int primary key	auto_increment,
Names varchar (50),                        
LastNames varchar (50),
Email varchar (100) unique,
Address varchar (30),
Phone varchar (25)
);


INSERT INTO Owners VALUES (2, "Julian", "Velez","julian@gmail.com","cra1-0#2", "999-999-001");
SELECT * FROM Owners;

/*Tabla de veterinarios*/

CREATE TABLE Vets (
Id int primary key auto_increment,
Name varchar (120),
Phone varchar (25),
Address varchar (30),
Email varchar (100) unique
);

INSERT INTO Vets VALUES ( 3, "Crokus", "111-0909-0099", "The Twin cabes", "Crokus@gmail.com");

SELECT * FROM Vets;


/*Tabla Mascotas*/
CREATE TABLE Pets (
Id int primary key auto_increment,
Name varchar (25),
Specie Enum ("Cat", "Dog"),
Race Enum ("Angora","Criollo","Pitbull","Pincher"),
DateBirth Date,
OwnerId int,
Photo text,
foreign key (OwnerId) REFERENCES Owners(Id)
);
DROP TABLE Pets;
INSERT INTO Pets VALUES (2, "Michi", "Cat", "Angora", "2024-09-10", 3 ,"https://pixabay.com/es/photos/gatitos-mascota-felinos-gatos-3535404/");
SELECT * FROM Pets;

/*Tabla Citas*/
CREATE TABLE Quotes (
Id int primary key auto_increment,
Date Date,
PetId int,
foreign key (PetId) REFERENCES Pets (Id),
VetId int,
foreign key (VetId) REFERENCES Vets (Id),
Description text
);
DROP TABLE Quotes;
INSERT INTO Quotes VALUES (2, "2023-12-12", 2, 1, "/////////");

SELECT * FROM Quotes;

