-- Drop and recreate the Pets table
IF OBJECT_ID('dbo.Pets', 'U') IS NOT NULL
    DROP TABLE dbo.Pets;

CREATE TABLE dbo.Pets (
    PetID INT IDENTITY(1,1) PRIMARY KEY,--Unique ID for each pet
    PetName NVARCHAR(100) NOT NULL, --Name of each pet
    Mood NVARCHAR(50) NOT NULL,
    MoodImage VARBINARY(MAX),
    Action NVARCHAR(50) NOT NULL,
    ToyImage VARBINARY(MAX)
   
    
);





