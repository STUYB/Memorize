DROP TABLE IF EXISTS Players;
DROP TABLE IF EXISTS Games;
DROP TABLE IF EXISTS Highscores;

-- Create DB's: Players, Games, Highscores
CREATE TABLE Players (
	id INT NOT NULL IDENTITY,
	username NVARCHAR(50) NOT NULL,
	password NVARCHAR(50) NOT NULL,
	country NVARCHAR(50) NOT NULL,
	PRIMARY KEY (id)
);
CREATE TABLE Games (
	id INT NOT NULL IDENTITY,
	name NVARCHAR(50) NOT NULL,
	size NVARCHAR(50) NOT NULL,
	timer INT NOT NULL,
	theme NVARCHAR(50) NOT NULL,
	PRIMARY KEY (id)
);
CREATE TABLE Highscores (
	id INT NOT NULL IDENTITY,
	username NVARCHAR(50) NOT NULL,
	game NVARCHAR(50) NOT NULL,
	clicks INT NOT NULL,
	PRIMARY KEY (id)
);

-- Fill DB's:
INSERT INTO [Players] (username, password, country) VALUES ('joseph', 'wolf', 'Space');
INSERT INTO [Highscores] (username, game, clicks) VALUES ('joseph', 'Classic S', 20);
-- Classic Games
INSERT INTO [Games] (name, size, timer, theme) VALUES ('Classic S', 'SMALL', 0, 'Classic');
INSERT INTO [Games] (name, size, timer, theme) VALUES ('Classic M', 'MEDIUM', 0, 'Classic');
INSERT INTO [Games] (name, size, timer, theme) VALUES ('Classic L', 'LARGE', 0, 'Classic');
INSERT INTO [Games] (name, size, timer, theme) VALUES ('Classic Hard', 'LARGE', 60, 'Classic');
-- Halloween Games
INSERT INTO [Games] (name, size, timer, theme) VALUES ('Halloween S', 'SMALL', 0, 'Halloween');
INSERT INTO [Games] (name, size, timer, theme) VALUES ('Halloween M', 'MEDIUM', 0, 'Halloween');
INSERT INTO [Games] (name, size, timer, theme) VALUES ('Halloween L', 'LARGE', 0, 'Halloween');
INSERT INTO [Games] (name, size, timer, theme) VALUES ('Halloween Hard', 'LARGE', 60, 'Halloween');
-- Xmas Games
INSERT INTO [Games] (name, size, timer, theme) VALUES ('Xmas S', 'SMALL', 0, 'Xmas');
INSERT INTO [Games] (name, size, timer, theme) VALUES ('Xmas M', 'MEDIUM', 0, 'Xmas');
INSERT INTO [Games] (name, size, timer, theme) VALUES ('Xmas L', 'LARGE', 0, 'Xmas');
INSERT INTO [Games] (name, size, timer, theme) VALUES ('Xmas Hard', 'LARGE', 60, 'Xmas');
