USE AZMARI
GO
--Stored Procedures
CREATE PROC uspSignUpListener
@FirstName varchar(25), @Lastname varchar (25), @Gender char, @Email varchar(25), @Password varchar(25), 
@Picture VARBINARY(MAX),@PrefrenceName1 varchar(25),@PrefrenceName2 varchar(25)
AS
BEGIN
	
	INSERT INTO Listener(FirstName,LastName,Gender,Email,Password,Picture)
	VALUES				(@FirstName,@Lastname,@Gender,@Email,@Password,@Picture)
	
	DECLARE @ListenerID int = dbo.getListenerID(@Email)

	INSERT INTO Prefrences(Listener_ID,PrefrenceName)
	VALUES				  (@ListenerID,@PrefrenceName1)

	INSERT INTO Prefrences(Listener_ID,PrefrenceName)
	VALUES				  (@ListenerID,@PrefrenceName2) 
END
GO

CREATE PROC uspSignUpArtist
@FirstName varchar(25), @Lastname varchar (25), @Stagename varchar(25), @Gender char, @Email varchar(25),
@Password varchar(25), @Picture VARBINARY(MAX) 
AS
BEGIN
	INSERT INTO Artist  (FirstName,LastName,Stagename,Gender,Email,Password,Picture)
	VALUES				(@FirstName,@Lastname,@Stagename,@Gender,@Email,@Password,@Picture)
END
GO

CREATE PROC uspLoginListener
@Email varchar(25),
@Password varchar(25)
AS
BEGIN
	SELECT * FROM Listener
	WHERE Email = @Email AND Password = @Password
END
GO

CREATE PROC uspLoginArtist
@Email varchar(25),
@Password varchar(25)
AS
BEGIN
	SELECT * FROM Artist
	WHERE Email = @Email AND Password = @Password
END
GO




CREATE PROC uspPublishMusic
@MusicName varchar(25),@MusicFile VARBINARY(MAX),@Picture VARBINARY(MAX),@ArtistEmail varchar(25),@Genre varchar(25)
AS
BEGIN
	DECLARE @ArtistID int = dbo.getArtistID(@ArtistEmail)
	DECLARE @ListenerID int
	INSERT INTO Music (MusicName,MusicFile,Picture,Artist_ID)
	VALUES			  (@MusicName,@MusicFile,@Picture,@ArtistID)

	DECLARE @MusicID int = dbo.getMusicID(@MusicName)
	INSERT INTO Genre(Music_ID,GenreName)
	VALUES (@MusicID,@Genre)


	SELECT @ListenerID = Listener_ID
	FROM Follows
	WHERE Artist_ID = @ArtistID

	UPDATE Listener
	SET Notification += 1
	WHERE ListenerID = @ListenerID
END
GO

CREATE PROC uspCreatePlaylist
@ListenerEmail varchar(25) 
AS
BEGIN
	DECLARE @ListenerID int = dbo.getListenerID(@ListenerEmail)
	
	INSERT INTO Playlist (Listener_ID)
	VALUES			     (@ListenerID)
END
GO

CREATE PROC uspAddToPlaylist
@ListenerEmail varchar(25),@MusicName varchar(25) 
AS
BEGIN
	DECLARE @MusicID int = dbo.getMusicID(@MusicName)
	DECLARE @PlaylistID int = dbo.getPlaylistID(@ListenerEmail)		
	
	INSERT INTO AddedTo(Music_ID,Playlist_ID)
	VALUES			   (@MusicID,@PlaylistID )
END
GO

CREATE PROC uspFollowArtist
@ListenerEmail varchar(25), @ArtistEmail varchar(25)
AS
BEGIN
		
	DECLARE @ListenerID int = dbo.getListenerID(@ListenerEmail)
	DECLARE @ArtistID int = dbo.getArtistID(@ArtistEmail)

	INSERT INTO Follows (Listener_ID,Artist_ID)
	VALUES              (@ListenerID,@ArtistID)
END
GO

CREATE PROC uspListenerPlaysMusic
@ListenerEmail varchar(25), @MusicName varchar(25)
AS
BEGIN
		
	DECLARE @ListenerID int = dbo.getListenerID(@ListenerEmail)
	DECLARE @MusicID int = dbo.getMusicID(@MusicName)
	

	UPDATE Listener
	SET Music_ID = @MusicID
	WHERE ListenerID = @ListenerID

	UPDATE Music
	SET Listeners += 1
	WHERE MusicID = @MusicID

	SELECT MusicFile
	FROM Music
	WHERE MusicID = @MusicID
END
GO

CREATE PROC uspAmountOFListeners
@MusicName varchar(25),@ArtistEmail varchar(25),@ListenerNumber int OUTPUT
AS
BEGIN
	DECLARE @ArtistID int = dbo.getArtistID(@ArtistEmail)	
	DECLARE @MusicID int = dbo.getMusicID(@MusicName)

	SELECT @ListenerNumber = Listeners
	FROM Music
	Where Artist_ID = @ArtistID and MusicID = @MusicID
	
END
GO

CREATE PROC uspTopTenSongs
AS
BEGIN
	
	SELECT TOP 10 MusicName,Picture,Listeners
	FROM Music
	ORDER BY Listeners DESC
END
GO

CREATE PROC uspPopulateArtistPage
@ArtistEmail varchar(25)
AS
BEGIN
	DECLARE @ArtistID int = dbo.getArtistID(@ArtistEmail)

	SELECT MusicName,Picture,Listeners,MusicFile
	FROM Music
	WHERE Artist_ID = @ArtistID
END
GO

CREATE PROC uspGetAllSongs
AS
BEGIN
	SELECT MusicName,m.Picture,Listeners,MusicFile,Stagename
	FROM Music m JOIN Artist a
	ON m.Artist_ID = a.ArtistID
END
GO

CREATE PROC uspGetArtistSongs
@Email varchar(25)
AS
BEGIN
	DECLARE @ArtistID int = dbo.getArtistID(@Email)

	SELECT MusicName,m.Picture,Listeners,MusicFile,Stagename
	FROM Music m JOIN Artist a
	ON m.Artist_ID = a.ArtistID
	where m.Artist_ID = @ArtistID
END
GO

CREATE PROC uspGetArtistInfo
@ArtistEmail varchar(25)
AS
BEGIN
	DECLARE @ArtistID int = dbo.getArtistID(@ArtistEmail)

	SELECT *
	FROM Artist
	WHERE ArtistID = @ArtistID
END
GO


CREATE PROC uspPopulateListenerPage
@ListenerEmail varchar(25)
AS
BEGIN
	DECLARE @ListenerID int = dbo.getListenerID(@ListenerEmail)

	SELECT *
	FROM Listener
	WHERE ListenerID = @ListenerID
END
GO

CREATE PROC uspSearchSongOrArtist
@SearchText varchar(25), @type int
AS
BEGIN
	IF @type = 1
	BEGIN	
		Select Firstname
		FROM Artist
		WHERE Firstname like '%'+ISNULL(@SearchText,Firstname)
	END
	ELSE IF @type = 0
	BEGIN	
		Select MusicName
		FROM Music
		WHERE MusicName like '%'+ISNULL(@SearchText,MusicName)
	END
END
GO

CREATE PROC uspUpgradeAccount
@ListenerEmail varchar(25),@Stagename varchar(25)
AS
BEGIN
	DECLARE @ListenerID int = dbo.getListenerID(@ListenerEmail)
	DECLARE @FirstName varchar(25), @Lastname varchar (25),@Gender char, @Email varchar(25),
            @Password varchar(25), @Picture VARBINARY(MAX) 
	
	SELECT @FirstName = FirstName,@Lastname = LastName,@Gender = Gender,@Email = Email,@Password = Password,@Picture = Picture
	FROM Listener
	WHERE ListenerID = @ListenerID

	EXECUTE uspSignUpArtist @FirstName,@Lastname,@Stagename,@Gender,@Email,@Password,@Picture

END
GO

CREATE PROC uspUpdateListener 
@FirstName varchar(25), @Lastname varchar (25), @Gender char, @Email varchar(25),
@Picture VARBINARY(MAX) 
 
AS
BEGIN
	UPDATE Listener
	SET Firstname = @FirstName,
		Lastname = @Lastname,
		Gender = @Gender,
		Picture = @Picture 
		WHERE Email = @Email
END
GO

CREATE PROC uspUpdateArtist 
@FirstName varchar(25), @Lastname varchar (25), @Gender char, @Email varchar(25),
@Picture VARBINARY(MAX) 
 
AS
BEGIN
	UPDATE Artist
	SET Firstname = @FirstName,
		Lastname = @Lastname,
		Gender = @Gender,
		Picture = @Picture 
		WHERE Email = @Email
END
GO

CREATE PROC uspDeleteSong 
@MusicName varchar(25) 
 
AS
BEGIN
	DECLARE @MusicID int = dbo.getMusicID(@MusicName)

	DELETE FROM Genre
	WHERE Music_ID = @MusicID

	DELETE FROM Music
	WHERE MusicID = @MusicID
END
GO

CREATE PROC uspGenerateArtistReport
@ArtistEmail varchar(25)
AS
BEGIN
	DECLARE @ArtistID int = dbo.getArtistID(@ArtistEmail)

	SELECT MusicName,GenreName,Listeners
	FROM Music m join Genre g
	on m.MusicID = g.Music_ID
	WHERE m.Artist_ID = @ArtistID
END
GO

CREATE PROC uspSearchArtist
@Fname varchar(25), 
@Lname varchar(25), 
@Email varchar(25) 
AS
BEGIN
	SELECT Firstname, Lastname, Stagename, Picture, Email
	FROM Artist
	WHERE Email like '%'+ISNULL(@Email,Email)+'%' AND Firstname like '%'+ISNULL(@Fname,Firstname)+'%' AND
	Lastname like '%'+ISNULL(@Lname,Lastname)+'%' 
END
GO

--FUNCTIONS
CREATE FUNCTION getListenerID (@ListenerEmail VARCHAR(25))
RETURNS INT
AS
BEGIN
	DECLARE  @ListenerID INT
	SELECT @ListenerID = ListenerID
	FROM   Listener
	WHERE  Email = @ListenerEmail

	RETURN @ListenerID
END
GO

CREATE FUNCTION getArtistID (@ArtistEmail VARCHAR(25))
RETURNS INT
AS
BEGIN
	DECLARE  @ArtistID INT
	SELECT @ArtistID = ArtistID
	FROM   Artist
	WHERE  Email = @ArtistEmail

	RETURN @ArtistID 
END
GO

CREATE FUNCTION getMusicID (@MusicName VARCHAR(25))
RETURNS INT
AS
BEGIN
	DECLARE  @MusicID INT
	SELECT @MusicID = MusicID
	FROM   MUSIC
	WHERE  MusicName = @MusicName

	RETURN @MusicID 
END
GO

CREATE FUNCTION getPlaylistID (@ListenerEmail VARCHAR(25))
RETURNS INT
AS
BEGIN
	DECLARE @PlaylistID INT
	SELECT @PlaylistID = PlaylistID
	FROM   Playlist
	WHERE  Listener_ID = dbo.getListenerID(@ListenerEmail)

	RETURN @PlaylistID
END
GO