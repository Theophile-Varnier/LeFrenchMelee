DROP SCHEMA lefrenchmelee;
CREATE SCHEMA lefrenchmelee;
use lefrenchmelee;

CREATE TABLE Member(
	Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	Pseudo VARCHAR(50) UNIQUE NOT NULL,
	Password VARCHAR(500) NOT NULL
);