CREATE TABLE [dbo].[PatientProfile]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PatientId] NCHAR(10) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [BirthDate] DATE NOT NULL, 
    [Address] NVARCHAR(MAX) NOT NULL, 
    [ContactNumber] INT NOT NULL, 
    [EmailAddress] NVARCHAR(50) NOT NULL
)
