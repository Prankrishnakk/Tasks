create database DaliyTasks
use DaliyTasks
CREATE TABLE Books (
    BookID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(100),
    Author NVARCHAR(100),
    PublicationYear INT
);

INSERT INTO Books (Title, Author, PublicationYear)
VALUES 
('To Kill a Mockingbird', 'Harper Lee', 1960),
('1984', 'George Orwell', 1949),
('Pride and Prejudice', 'Jane Austen', 1813),
('Animal Farm', 'George Orwell', 1945),
('The Great Gatsby', 'F. Scott Fitzgerald', 1925);

SELECT * FROM Books
WHERE PublicationYear = 1949;

SELECT * FROM Books
WHERE Author = 'George Orwell';

SELECT DISTINCT Author FROM Books;




