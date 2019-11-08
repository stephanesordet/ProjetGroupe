/* Titre : CréationDBGestionnaire*/
/* Auteur : Stephane.sordetcpnv.ch et Luana.kirchner-bannwart@cpnv.ch*/
/* Version : 07-OCT-2019*/


SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema Gestionnaire
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Gestionnaire
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Gestionnaire` DEFAULT CHARACTER SET utf8 ;
USE `Gestionnaire` ;

-- -----------------------------------------------------
-- Table `Gestionnaire`.`Suppliers`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Gestionnaire`.`Suppliers` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Sexe` VARCHAR(10) NULL,
  `Firstname` VARCHAR(40) NOT NULL,
  `Lastname` VARCHAR(30) NULL,
  `Company` VARCHAR(45) NULL,
  `City` VARCHAR(30) NOT NULL,
  `NPA` INT NOT NULL,
  `Street` VARCHAR(45) NOT NULL,
  `Email` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Gestionnaire`.`Restaurants`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Gestionnaire`.`Restaurants` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `NameRest.` VARCHAR(45) NOT NULL,
  `City` VARCHAR(30) NOT NULL,
  `NPA` INT NOT NULL,
  `Street` VARCHAR(45) NOT NULL,
  `Email` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Gestionnaire`.`Categories`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Gestionnaire`.`Categories` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Gestionnaire`.`Products`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Gestionnaire`.`Products` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(30) NOT NULL,
  `Categories_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Products_Category1_idx` (`Categories_id` ASC),
  CONSTRAINT `fk_Products_Category1`
    FOREIGN KEY (`Categories_id`)
    REFERENCES `Gestionnaire`.`Categories` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Gestionnaire`.`Products_has_Suppliers`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Gestionnaire`.`Products_has_Suppliers` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Products_id` INT NOT NULL,
  `Suppliers_id` INT NOT NULL,
  INDEX `fk_Products_has_Providers_Providers1_idx` (`Suppliers_id` ASC),
  INDEX `fk_Products_has_Providers_Products1_idx` (`Products_id` ASC),
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_Products_has_Providers_Products1`
    FOREIGN KEY (`Products_id`)
    REFERENCES `Gestionnaire`.`Products` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Products_has_Providers_Providers1`
    FOREIGN KEY (`Suppliers_id`)
    REFERENCES `Gestionnaire`.`Suppliers` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Gestionnaire`.`Unities`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Gestionnaire`.`Unities` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(10) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Gestionnaire`.`CommandeLines`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Gestionnaire`.`CommandeLines` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Quantity` INT NOT NULL,
  `Peremption` DATE NULL,
  `Products_id` INT NOT NULL,
  `OrderDate` DATE NULL,
  `ArrivalQuantity` INT NULL,
  `Unities_id` INT NOT NULL,
  `Suppliers_id` INT NULL,
  `Status` TINYINT(2) NULL,
  `ArrivalDate` DATE NULL,
  INDEX `fk_Products_has_Orders_Products1_idx` (`Products_id` ASC),
  PRIMARY KEY (`id`),
  INDEX `fk_CommandeLines_Unities1_idx` (`Unities_id` ASC),
  INDEX `fk_CommandeLines_Suppliers1_idx` (`Suppliers_id` ASC),
  CONSTRAINT `fk_Products_has_Orders_Products1`
    FOREIGN KEY (`Products_id`)
    REFERENCES `Gestionnaire`.`Products` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_CommandeLines_Unities1`
    FOREIGN KEY (`Unities_id`)
    REFERENCES `Gestionnaire`.`Unities` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_CommandeLines_Suppliers1`
    FOREIGN KEY (`Suppliers_id`)
    REFERENCES `Gestionnaire`.`Suppliers` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Create User
-- -----------------------------------------------------
CREATE USER 'AdminGestionnaire'@'127.0.0.1' IDENTIFIED BY 'Pa$$w0rd';
GRANT ALL PRIVILEGES ON Gestionnaire.* TO 'AdminGestionnaire'@'127.0.0.1';
FLUSH PRIVILEGES;

-- -----------------------------------------------------
-- Create unities
-- -----------------------------------------------------
INSERT INTO `gestionnaire`.`unities` (`Name`) VALUES ('Kg');
INSERT INTO `gestionnaire`.`unities` (`Name`) VALUES ('L');
INSERT INTO `gestionnaire`.`unities` (`Name`) VALUES ('Pièce');
INSERT INTO `gestionnaire`.`unities` (`Name`) VALUES ('g');