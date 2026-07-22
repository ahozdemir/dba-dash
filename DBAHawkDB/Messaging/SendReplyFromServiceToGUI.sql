CREATE PROC Messaging.SendReplyFromServiceToGUI(
	@RecvReqDlgHandle UNIQUEIDENTIFIER,
	@Payload VARBINARY(MAX)
)
AS
DECLARE @SQL NVARCHAR(MAX)
SET @SQL = N'
SEND ON CONVERSATION @RecvReqDlgHandle
    MESSAGE TYPE
    [//dbadash.com/DBAHawkService/Reply]
    (@Payload);'

EXEC sp_executesql @SQL,N'@RecvReqDlgHandle UNIQUEIDENTIFIER,@Payload VARBINARY(MAX)',@RecvReqDlgHandle,@Payload