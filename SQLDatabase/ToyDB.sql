Create DATABASE ToyDB
GO

USE ToyDB
GO

CREATE TABLE Toy
(
	ToyID	int	IDENTITY PRIMARY KEY
	,Title varchar(60) NOT NULL
	,Description varchar(60) Not Null
	,Color varchar(30)
	,Company varchar(30)
	,type varchar(30)
)