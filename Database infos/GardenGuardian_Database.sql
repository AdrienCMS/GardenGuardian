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

INSERT INTO plants (plant_name,plant_schedule,plant_weekMonth,plant_lastWatering,plant_imagePath) VALUES ('Hortensia',2,'WEEK','2023-05-21','C:\\Users\\adrie\\Pictures\\Plants\\hortensia.png');
INSERT INTO plants (plant_name,plant_schedule,plant_weekMonth,plant_lastWatering,plant_imagePath) VALUES('Tulipe',	0,	'WEEK',	'2023-05-25',	'C:\\Users\\adrie\\Pictures\\Plants\\Tulipe.png');