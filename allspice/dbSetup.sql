CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

-- Deletes all of mine data 
DELETE FROM accounts WHERE id = "6307add455eeec07370f20c3";

-- STUB Recipes
CREATE TABLE IF NOT EXISTS recipes(
  id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
  picture VARCHAR(800),
  title VARCHAR(255) NOT NULL,
  subtitle VARCHAR(255),
  category VARCHAR(255),
  creatorId VARCHAR(255) NOT NULL,

  FOREIGN KEY (creatorId) REFERENCES accounts(id)
) default charset utf8 COMMENT "";

-- Creates a recipe table
INSERT INTO recipes
(picture, title, subtitle, category, creatorId)
VALUES
('https://images.unsplash.com/photo-1551782450-a2132b4ba21d?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1469&q=80', 'Beast Buger', 'The best burger in town', 'hamburger', '6307add455eeec07370f20c3');