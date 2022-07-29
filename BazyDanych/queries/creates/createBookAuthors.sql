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