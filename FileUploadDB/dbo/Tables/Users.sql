CREATE TABLE [dbo].[Users]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [UserName] NVARCHAR(50) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Gender] CHAR(1) NOT NULL, 
    [PhoneNumber] NUMERIC(10) NOT NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    [EmergencyContactName] NVARCHAR(50) NULL, 
    [EmergencyContactNumber] NUMERIC(10) NULL
)
