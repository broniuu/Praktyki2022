DROP TABLE IF EXISTS Departments;
CREATE TABLE Departments
(
	DepartmentID int NOT NULL ,
	Name varchar(50),
	CONSTRAINT PK_Departments PRIMARY KEY NONCLUSTERED (DepartmentID)
);

DROP TABLE IF EXISTS Books;
CREATE TABLE Books 
(
	BookID int NOT NULL ,
	Name varchar(50),
	DepartmentID int NOT NULL,
	CONSTRAINT PK_Books PRIMARY KEY NONCLUSTERED (BookID),
	CONSTRAINT FK_Books_Departments FOREIGN KEY (DepartmentID)
		REFERENCES Departments (DepartmentID)
		ON DELETE CASCADE
        ON UPDATE CASCADE
);

DROP TABLE IF EXISTS Authors;
CREATE TABLE Authors (
	AuthorID int NOT NULL,
	Name varchar(50),
	Surname varchar(50),
	CONSTRAINT PK_Authors PRIMARY KEY NONCLUSTERED (AuthorID)
);
DROP TABLE IF EXISTS BookAuthors;
CREATE TABLE BookAuthors 
(
	BookID int NOT NULL ,
	AuthorID int NOT NULL,
	CONSTRAINT FK_BookAuthors_Books FOREIGN KEY (BookID)
		REFERENCES Books (BookID)
		ON DELETE CASCADE
        ON UPDATE CASCADE,
	CONSTRAINT FK_BookAuthors_Authors FOREIGN KEY (AuthorID)
		REFERENCES Authors (AuthorID)
		ON DELETE CASCADE
        ON UPDATE CASCADE
);

DROP TABLE IF EXISTS Workers;
CREATE TABLE Workers
(
	WorkerID int NOT NULL ,
	Name varchar(50),
	Surname varchar(50),
	CONSTRAINT PK_Workers PRIMARY KEY NONCLUSTERED (WorkerID)
);

DROP TABLE IF EXISTS Wages;
CREATE TABLE Wages 
(
	WageID int NOT NULL ,
	Amount money NOT NULL,
	WorkerID int NOT NULL,
	CONSTRAINT PK_Books PRIMARY KEY NONCLUSTERED (WageID),
	CONSTRAINT PK_Books_Workers FOREIGN KEY (WorkerID)
		REFERENCES Workers (WorkerID)
		ON DELETE CASCADE
        ON UPDATE CASCADE
);