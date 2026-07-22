CREATE PROC DBAHawk.SavedViews_Del(
	@UserID INT,
	@ViewType TINYINT,
	@Name NVARCHAR(50)
)
AS
DELETE DBAHawk.SavedViews
WHERE UserID = @UserID
AND Name = @Name
AND ViewType = @ViewType