CREATE TABLE [dbo].[Account]
(
	[AccountNo] Int Not Null,
	[Balance] Money Not Null,
	Constraint PK_AccountNo Primary Key (AccountNo),
	Constraint CHK_Balance Check(Balance > 0)
)
