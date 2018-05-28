CREATE TABLE [dbo].[Invoice]
(
	[InvoiceNo] Int Not Null,
	[AccountTo] Int Not Null,
	[AccountFrom] Int Not Null,
	[DateIssued] DateTime Not Null,
	[Amount] Money Not Null,
	Constraint PK_Invoice Primary Key (InvoiceNo),
	Constraint FK_InvoiceAccountTo Foreign Key (AccountTo) References Account(AccountNo),
	Constraint FK_InvoiceAccountFrom Foreign Key (AccountFrom) References Account(AccountNo),

	Constraint CHK_InvoiceAmount Check(Amount > 0)
)
