CREATE TABLE [dbo].[WorkAllocation]
(
	[TeamID] Int Not Null,
	[UserID] Int Not Null,
	[Role] NVarChar(10) Not Null,
	Constraint PK_WACompound Primary Key (TeamID, UserID),
	Constraint CHK_Role Check (Role =  'Leader' Or Role = 'Member' Or Role = 'Resource')
)
