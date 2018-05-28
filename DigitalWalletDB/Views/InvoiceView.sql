CREATE VIEW [dbo].[InvoiceView]
	AS SELECT I.*, A.Balance
	FROM [Invoice] I
	inner join [Account] A
	on I.AccountFrom = A.AccountNo
