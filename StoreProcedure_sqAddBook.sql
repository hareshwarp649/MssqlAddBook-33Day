USE [Address_Book_Service]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateContacts]    Script Date: 14-Apr-22 8:44:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spUpdateContacts]
(
@FirstName VARCHAR(30),
@LastName VARCHAR(40),
@City VARCHAR(40),
@Zip INT,
@State VARCHAR(50)
)
AS
BEGIN TRY
UPDATE PersonContactsTable SET City = @City WHERE FirstName = @FirstName AND LastName = @LastName
UPDATE PersonContactsTable SET StateName = @State WHERE FirstName = @FirstName AND LastName = @LastName
UPDATE PersonContactsTable SET Zip = @Zip WHERE FirstName = @FirstName AND LastName = @LastName
END TRY

BEGIN CATCH
SELECT
ERROR_NUMBER() AS ErrorNumber,
ERROR_STATE() AS ErrorState,
ERROR_PROCEDURE() AS ErrorProcedure,
ERROR_LINE() AS ErrorLine,
ERROR_MESSAGE() AS ErrorMessage;
END CATCH