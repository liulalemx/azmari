CREATE DATABASE AZMARI
USE AZMARI

CREATE TABLE Artist(
ArtistID int not null IDENTITY(1,1) primary key,
Firstname varchar(25) not null,
Lastname varchar (25) not null,
Stagename varchar (25) not null,
Gender char not null,
Email varchar(25) not null UNIQUE,
Password varchar(25) not null,
Picture VARBINARY(MAX) NOT NULL,
Followers int DEFAULT 0,
)

CREATE TABLE Music(
MusicID int not null IDENTITY(1,1) primary key,
MusicName varchar(25) not null UNIQUE,
MusicFile VARBINARY(MAX) NOT NULL,
Picture VARBINARY(MAX) NOT NULL,
Artist_ID int foreign key references Artist(ArtistID),
Listeners int DEFAULT 0
)

CREATE TABLE Listener(
ListenerID int not null IDENTITY(1,1) primary key,
Firstname varchar(25) not null,
Lastname varchar (25) not null,
Gender char not null,
Email varchar(25) not null UNIQUE,
Password varchar(25) not null,
Picture VARBINARY(MAX) NOT NULL,
Notification int DEFAULT 0,
Music_ID int foreign key references Music(MusicID)
)

CREATE TABLE Playlist(
PlaylistID int not null IDENTITY(1,1) primary key,
Listener_ID int foreign key references Listener(ListenerID),
)

CREATE TABLE Follows(
Listener_ID int foreign key references Listener(ListenerID),
Artist_ID int foreign key references Artist(ArtistID),
)

CREATE TABLE Prefrences(
Listener_ID int foreign key references Listener(ListenerID),
PrefrenceName varchar(25) not null,
)

CREATE TABLE Genre(
Music_ID int foreign key references Music(MusicID),
GenreName varchar(25) not null,
)

CREATE TABLE AddedTo(
Music_ID int foreign key references Music(MusicID),
Playlist_ID int foreign key references Playlist(PlaylistID),
)

