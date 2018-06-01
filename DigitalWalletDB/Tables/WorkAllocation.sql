CREATE TABLE [dbo].[WorkAllocation]
(
	[TeamID] Int Not Null,
	[UserID] Int Not Null,
	[Role] NVarChar(10) Not Null,
	Constraint PK_WACompound Primary Key (TeamID, UserID),
	Constraint FK_TeamID Foreign Key (TeamID) References Team(TeamID),
	Constraint FK_UserID Foreign Key (UserID) References [User](UserID),
	Constraint CHK_Role Check (Role =  'Leader' Or Role = 'Member' Or Role = 'Resource')
)
