USE master
GO

--drop database if it exists
IF DB_ID('email_log') IS NOT NULL
BEGIN
	ALTER DATABASE email_log SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE email_log;
END

CREATE DATABASE email_log
GO

USE email_log
GO

--create tables
CREATE TABLE email_log (
	email_id int IDENTITY(1,1) NOT NULL,
	sender varchar(50) NOT NULL,
	recipient varchar(50) NOT NULL,
	email_subject varchar(150) NOT NULL,
	email_body varchar(1000) NOT NULL,	
	email_date date NOT NULL,
	email_sent bit NOT NULL,
	CONSTRAINT PK_email_id PRIMARY KEY (email_id)
)

GO