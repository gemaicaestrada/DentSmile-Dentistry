CREATE TABLE [dbo].[DentalInqury]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [ContactNumber] INT NOT NULL, 
    [EmailAddress] NVARCHAR(50) NOT NULL, 
    [SubjectMessage] NVARCHAR(50) NOT NULL, 
    [BodyMessage] NVARCHAR(50) NOT NULL
)
