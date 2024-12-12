CREATE TABLE Movies (
    MovieID INT PRIMARY KEY IDENTITY(1,1), -- Auto-increment ID
    MovieName NVARCHAR(100) NOT NULL,
    Genre NVARCHAR(50) NOT NULL,
    Status NVARCHAR(20) NOT NULL, -- e.g., "Now Showing", "Coming Soon"
    Price DECIMAL(10, 2) NOT NULL,
    CinemaRoom INT NOT NULL,
   
);