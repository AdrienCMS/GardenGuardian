drop DATABASE IF EXISTS GardenGuardian_Database;
create database GardenGuardian_Database;
use GardenGuardian_Database;


/* TABLES */
create table machine(
	machine_id INTEGER auto_increment,
	machine_ip varchar(15),
	machine_location varchar(15),
	machine_water_supply double,
	machine_ground_humidity double,
    primary key(machine_id)
					);
					
create table plants(
	id INTEGER auto_increment,
	plant_name varchar(30),
	plant_schedule int,
	plant_weekMonth ENUM ('WEEK','MONTH'),
	plant_lastWatering date,
	plant_imagePath varchar (100),
	ref_machine_id integer,
    foreign key(ref_machine_id) references machine(machine_id) ON UPDATE CASCADE,
    primary key(id)
					);
					
create table scheduling(
	scheduling_id INTEGER auto_increment,
	watering_date date,
	ref_plant_id integer,
	foreign key(ref_plant_id) references plants(id) ON UPDATE CASCADE,
    primary key(scheduling_id)
					);

INSERT INTO machine (machine_ip,machine_location,machine_water_supply,machine_ground_humidity) VALUES ("192.168.4.1","Paris/France",10.0,10.0);
INSERT INTO machine (machine_ip,machine_location,machine_water_supply,machine_ground_humidity) VALUES ("192.168.4.2","Paris/France",7.5,50.0);
INSERT INTO plants (plant_name,plant_schedule,plant_weekMonth,plant_lastWatering,plant_imagePath,ref_machine_id) VALUES ('Hortensia',2,'WEEK','2023-05-21','C:\\Users\\adrie\\Pictures\\Plants\\hortensia.png',2);
INSERT INTO plants (plant_name,plant_schedule,plant_weekMonth,plant_lastWatering,plant_imagePath,ref_machine_id) VALUES('Tulipe',	1,	'WEEK',	'2023-05-25',	'C:\\Users\\adrie\\Pictures\\Plants\\Tulipe.png',1);