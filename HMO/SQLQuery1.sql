USE HMO
--CREATE TABLE Patients(
--	ID varchar(11) PRIMARY KEY,
--	FirstName varchar(225) NOT NULL,
--	LastName varchar(225) NOT NULL,
--	Phone varchar(9) NOT NULL,
--	CellPhone varchar(10),
--	Adress varchar(225) NOT NULL,
--	BirthDate date NOT NULL,
	
--)

CREATE TABLE PatientsCorona(
	PatientCode int PRIMARY KEY IDENTITY (1, 1),
	PatientID varchar(11),
	Vaccine1 date, 
	Vaccine2 date, 
	Vaccine3 date,
	Vaccine4 date,
	Manufacturer1 varchar(225),
	Manufacturer2 varchar(225),
	Manufacturer3 varchar(225),
	Manufacturer4 varchar(225),
	RecoveryDate date,
	FOREIGN KEY (PatientID) REFERENCES Patients(ID)
)