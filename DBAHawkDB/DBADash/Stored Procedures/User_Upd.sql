CREATE PROC DBAHawk.User_Upd(
	@UserID INT,
	@TimeZone VARCHAR(50),
	@Theme VARCHAR(50)
)
AS
UPDATE DBAHawk.Users
	SET TimeZone = @TimeZone,
	Theme = @Theme
WHERE UserID = @UserID