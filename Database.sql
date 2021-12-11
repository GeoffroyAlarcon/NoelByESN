drop schema if exists  SecretSantaByESN; 
create schema SecretSantaByESN DEFAULT CHARACTER SET utf8;
use SecretSantaByESN; 
create table personne(
id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
nom VARCHAR(250) NOT null,
prenom VARCHAR(250) not null,
estEnCouple tinyint default 0
)
ENGINE = InnoDB 
DEFAULT CHARACTER SET = utf8;
CREATE TABLE pair_people (
id int PRIMARY KEY  NOT NULL AUTO_INCREMENT,
firstPersonId int NOT NULL,
secondPersonId int not null,
CONSTRAINT fk_firstPersonId FOREIGN KEY (firstPersonId) REFERENCES user(id) ON DELETE CASCADE,
CONSTRAINT fk_SecondPersonId FOREIGN KEY (secondPersonId) REFERENCES user(id) ON DELETE CASCADE
)
ENGINE = InnoDB 
DEFAULT CHARACTER SET = utf8;