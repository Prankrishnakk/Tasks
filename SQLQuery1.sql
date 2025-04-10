CREATE TABLE Books (
    BookID INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(100),
    Author NVARCHAR(100),
    PublicationYear INT
);
INSERT INTO Books (Title, Author, PublicationYear)
VALUES 
('The Pragmatic Programmer', 'Andrew Hunt', 1999),
('Clean Code', 'Robert C. Martin', 2008),
('The Clean Coder', 'Robert C. Martin', 2011),
('Introduction to Algorithms', 'Thomas H. Cormen', 2009),
('Design Patterns', 'Erich Gamma', 1994),
('Refactoring', 'Martin Fowler', 1999);
SELECT * FROM Books WHERE PublicationYear = 1999;
SELECT * FROM Books WHERE Author = 'Robert C. Martin';
SELECT DISTINCT Author FROM Books;

