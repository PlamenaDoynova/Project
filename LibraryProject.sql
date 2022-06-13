CREATE TABLE Roles
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(20) NOT NULL,
	CONSTRAINT UQ_Role UNIQUE(Name)
);

CREATE TABLE Users
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(15) NOT NULL,
	LastName VARCHAR(20) NOT NULL,
	UserName VARCHAR(15) NOT NULL,
	Pass VARCHAR(20) NOT NULL,
	Role INT NOT NULL,
	CONSTRAINT UQ_User UNIQUE(UserName),
	CONSTRAINT FK_Users_Roles
		FOREIGN KEY (Role)
		REFERENCES Roles(Id)
);

CREATE TABLE Publisher
(
	Id INT PRIMARY KEY IDENTITY,
    Name VARCHAR(20) NOT NULL,
	CONSTRAINT UQ_Publisher UNIQUE(Name)
);

CREATE TABLE Genre
(
	Id INT PRIMARY KEY IDENTITY,
    Name VARCHAR(15) NOT NULL,
	CONSTRAINT UQ_Genre UNIQUE(Name)
);

CREATE TABLE Books
(
	Id INT PRIMARY KEY IDENTITY,
    Name VARCHAR(20) NOT NULL,
    Publisher INT NOT NULL,
    Genre INT NOT NULL,
    Price INT NOT NULL,
	CONSTRAINT UQ_Book UNIQUE(Name),
    CONSTRAINT FK_Books_Publisher
		FOREIGN KEY (Publisher)
        REFERENCES Publisher(Id),
	CONSTRAINT FK_Books_Genre
		FOREIGN KEY (Genre)
        REFERENCES Genre(Id)
);
drop table Books;
INSERT INTO Roles VALUES
	('Guest'),
	('Admin')

INSERT INTO Users VALUES
	('Ivan', 'Nikolov', 'ivan', 'in', 1),
	('Maria', 'Petrova', 'maria', 'mp', 2);

INSERT INTO Publisher VALUES
	('Siela'),
    ('Anubis'),
	('Letera');

INSERT INTO Genre VALUES
	('historical'),
	('childrens books'),
	('scientific'),
	('novels');

INSERT INTO Books VALUES
	('Course to victory', 1, 1, 15),
	('Franklin', 1, 2, 10),
	('Ìedicinal plants', 1, 3, 25),
	('Ulysses', 1, 4, 20),
	('Grant', 2, 1, 30),
	('The snowy day', 2, 2, 12),
	('Insectpedia', 2, 3, 25),
	('Lolita', 2, 4, 30),
	('Leningrad', 3, 1, 20),
	('Little Bear', 3, 2, 14),
	('Universe', 3, 3, 18);