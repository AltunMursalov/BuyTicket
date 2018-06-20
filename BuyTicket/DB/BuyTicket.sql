USE [master]
GO

CREATE DATABASE TicketBuy
GO

USE [TicketBuy]
GO

CREATE TABLE Films (
	Id int IDENTITY(1,1),
	Film_Name nvarchar(60) NOT NULL,
	[Year] int NOT NULL,
	Duration int NOT NULL,

	CONSTRAINT PK_Film_Id PRIMARY KEY (Id)
);
GO

CREATE TABLE [Types] (
	Id int IDENTITY(1, 1),
	[Type_Name] nvarchar(20) NOT NULL,

	CONSTRAINT PK_Type_Id PRIMARY KEY (Id)
);
GO

CREATE TABLE Halls (
	Id int IDENTITY(1, 1),
	NumOfHall int NOT NULL,
	SeatRowCount int NOT NULL,
	SeatColCount int NOT NULL,

	CONSTRAINT PK_Hall_Id PRIMARY KEY (Id)
);
GO

CREATE TABLE Seans (
	Id int IDENTITY(1, 1),
	Seans_Data DATE NOT NULL,
	Seans_Time TIME NOT NULL,
	Price int NOT NULL,
	Film_Id int NOT NULL,
	[Type_Id] int NOT NULL,
	Hall_Id int NOT NULL,

	CONSTRAINT PK_Seans_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Seans_Film_Id FOREIGN KEY (Film_Id) REFERENCES Films(Id),
	CONSTRAINT FK_Seans_Type_Id FOREIGN KEY ([Type_Id]) REFERENCES [Types](Id),
	CONSTRAINT FK_Seans_Hall_Id FOREIGN KEY (Hall_Id) REFERENCES Halls(Id),
);
GO

CREATE TABLE Tickets (
	Email nvarchar(30) NOT NULL,
	Seat_Row int,
	Seat_Col int,
	Ticket_DateTime DATETIME2 NOT NULL,
	Seans_Id int NOT NULL,

	CONSTRAINT PK_Ticket_Id PRIMARY KEY (Seat_Col, Seat_Row, Seans_Id),
	CONSTRAINT FK_Ticket_Seans_Id FOREIGN KEY (Seans_Id) REFERENCES Seans(Id)
);
GO

INSERT INTO Films (Film_Name, [Year], Duration)
VALUES (N'Хан Соло', 2018, 150), (N'Реинкарниация', 2018, 130), (N'Дэдпул', 2018, 110), (N'Мир Юрского Периуда', 2018, 130)
GO

INSERT INTO [Types] ([Type_Name])
VALUES (N'2D'), (N'3D')
GO

INSERT INTO Halls (NumOfHall, SeatColCount, SeatRowCount)
VALUES (1, 5, 6), (2, 6, 8), (3, 4, 4)
GO

INSERT INTO Seans (Film_Id, Hall_Id, Price, [Type_Id], Seans_Data, Seans_Time)
VALUES (2, 1, 10, 1, GETDATE(), GETDATE()) 

INSERT INTO Tickets (Email, Seans_Id, Seat_Col, Seat_Row, Ticket_DateTime)
VALUES (N'TEST', 2, 2, 2, GETDATE())

SELECT * FROM Tickets

SELECT * FROM Seans