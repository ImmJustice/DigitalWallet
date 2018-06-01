/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
IF '$(LoadTestData)' = 'true'

BEGIN


INSERT INTO ACCOUNT (AccountNo, Balance) VALUES
(12345, $500.00),
(23456, $20000.00),
(34567, $1573.92),
(45678, $7432.06),
(56789, $806.12),
(11111, $99999.99);

INSERT INTO INVOICE (InvoiceNo, AccountTo, AccountFrom, DateIssued, Amount) VALUES
(10001, 12345, 56789, '2018-05-28', $14.62),
(10002, 23456, 45678, '2018-04-27', $731.94),
(10003, 34567, 23456, '2018-02-16', $261.96),
(10004, 45678, 34567, '2018-03-05', $305.12),
(10005, 56789, 12345, '2018-01-01', $450.00);

INSERT INTO TEAM (TeamID, ProjectName, AccountNo) VALUES
(98765, 'Sin City', 12345),
(87654, 'Salt Lake', 23456),
(76543, 'Aerial Pink', 34567),
(65432, 'Bourne Again', 45678),
(54321, 'Laughing Lizard', 56789);

INSERT INTO [TRANSACTION](AccountTo, AccountFrom, Amount, InvoiceNo, DatePaid) VALUES
(56789, 12345, $14.62, 10001, '2018-06-28'),
(45678, 23456, $731.94, 10002, '2018-07-27'),
(23456, 34567, $261.96, 10003, '2018-02-26'),
(34567, 45678, $305.12, 10004, '2018-03-16'),
(12345, 56789, $450.00, 10005, '2018-01-31');

INSERT INTO [USER] (UserID, UserType, FirstName,  LastName, Email, PhoneNo, AccountNo) VALUES
(15935, 'S', 'Joe', 'Davis', 'jdavis@gmail.com', 04756382224, 12345),
(35795, 'S', 'Richard', 'Anderson', 'r.anderson@student.swin.edu.au', 0447448362, 23456),
(75365, 'S', 'Mary', 'Smith', 'mrysmth@hotmail.com', 0456123321, 34567),
(95125, 'S', 'Paul', 'Lever', 'plever@gmail.com', 0444895632, 45678),
(85245, 'S', 'Robby', 'Robbo', 'robinator@aol.com', 0478963258, 56789),
(55555, 'R', 'Anh', 'Nguyen', 'anhguyen@yahoomail.com.au', 0444444444, 11111); 

INSERT INTO WORKALLOCATION (TeamID, UserID, [Role]) VALUES
(98765, 12345, 'Leader'),
(98765, 23456, 'Member'),
(98765, 34567, 'Resource'),
(87654, 23456, 'Leader'),
(87654, 34567, 'Member'),
(87654, 45678, 'Resource'),
(76543, 34567, 'Leader'),
(76543, 45678, 'Member'),
(76543, 56789, 'Resource'),
(65432, 45678, 'Leader'),
(65432, 56789, 'Member'),
(65432, 12345, 'Resource'),
(54321, 56789, 'Leader'),
(54321, 12345, 'Member'),
(54321, 23456, 'Resource');

END;