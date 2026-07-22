CREATE PROC DBAHawk.SavedViews_Get(
	@UserID INT,
	@ViewType TINYINT
)
AS
SELECT	Name,
		SavedObject 
FROM DBAHawk.SavedViews
WHERE UserID = @UserID
AND ViewType=@ViewType 
ORDER BY Name