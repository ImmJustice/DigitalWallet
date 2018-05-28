CREATE TABLE [dbo].[Transaction]
(
	[AccountTo] Int Not Null,
	[AccountFrom] Int,
	[Amount] Money Not Null,
	[InvoiceNo] Int,
	[DatePaid] Datetime Not Null,
	Constraint PK_AccountCompound Primary Key (AccountTo,DatePaid),
	Constraint FK_TransAccountTo Foreign Key (AccountTo) References Account(AccountNo),
	Constraint FK_TransAccountFrom Foreign Key (AccountFrom) References Account(AccountNo),
	Constraint FK_TransInvoiceNo Foreign Key (InvoiceNo) References Invoice(InvoiceNo),
	Constraint CHK_TransAmount Check(Amount > 0)
)
