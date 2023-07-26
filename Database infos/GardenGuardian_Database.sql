drop DATABASE IF EXISTS GardenGuardian_Database;
create database GardenGuardian_Database;
use GardenGuardian_Database;


/* TABLES */
create table plants(
	id INTEGER auto_increment,
	plant_name varchar(30),
	plant_schedule int,
	plant_weekMonth ENUM ('WEEK','MONTH'),
	plant_lastWatering date,
	plant_imagePath varchar (100),
    primary key(id)
					);

INSERT INTO plants VALUES ('Hortensia',2,'WEEK',21/05/2023,'C:\Users\adrie\Pictures\Plants\hortensia.png');
INSERT INTO plants VALUES ('Tulipe',	0,	'WEEK',	21/06/2023,	'C:\Users\adrie\Pictures\Plants\Tulipe.png');