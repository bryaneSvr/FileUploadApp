CREATE TYPE UsersType
AS TABLE
(
	[Id] BIGINT NOT NULL, 
    [UserName] NVARCHAR(50) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Gender] CHAR(1) NOT NULL, 
    [PhoneNumber] NUMERIC(10) NOT NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    [EmergencyContactName] NVARCHAR(50) NULL, 
    [EmergencyContactNumber] NUMERIC(10) NULL
);
GO

CREATE PROCEDURE [dbo].[InsertUsers]
	@users UsersType READONLY
AS
SET NOCOUNT ON
BEGIN
	INSERT INTO 
        dbo.Users 
        (
            Id
            , UserName
            , FirstName
            , LastName
            , Email
            , Gender
            , PhoneNumber
            , Address
			, EmergencyContactName
            , EmergencyContactNumber
        )
	SELECT 
        Id
        , UserName
        , FirstName
        , LastName
        , Email
        , Gender
        , PhoneNumber
        , Address
		, EmergencyContactName
        , EmergencyContactNumber
    FROM
        @users
        
END
