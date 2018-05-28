CREATE TABLE [dbo].[User]
(
	[UserID] Int Not Null,
	[UserType] NVarChar(1) Not Null,
	[FirstName] NVarChar(20),
	[LastName] NVarChar(20),
	[Email] NVarChar(40),
	[PhoneNo] Int,
	[AccountNo] Int,
	Constraint PK_UserID Primary Key (UserID),
	Constraint FK_AccountNo Foreign Key (AccountNo) References Account(AccountNo)
)
