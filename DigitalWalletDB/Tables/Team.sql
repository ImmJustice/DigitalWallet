CREATE TABLE [dbo].[Team]
(
	[TeamID] Int Not Null,
	[ProjectName] NvarChar(50) Not Null,
	[AccountNo] Int Not Null,
	Constraint PK_TeamID Primary Key (TeamID),
	Constraint FK_AccountID Foreign Key (AccountNo) References Account(AccountNo)
)
