<#
.SYNOPSIS
    Remove a connection from the DBAHawk config
.DESCRIPTION
    Remove a connection string from the ServiceConfig.json file.  
    Note: Changes to the config file require a service restart
.PARAMETER ConnectionString
    The connection string for the SQL Instance you want to remove from the config file
.PARAMETER BackupConfig
    Keep a copy of the old config file before saving
.EXAMPLE
    ./Remove-DBADashSource -ConnectionString "Data Source=MYSERVER;Integrated Security=SSPI;"
#>  
Param(
    [Parameter(Mandatory=$true)]
    [string]$ConnectionString,
    [bool]$BackupConfig=$true
)
if($BackupConfig){
    ./DBAHawkConfig -a "Remove" -c $ConnectionString
}
else{
    ./DBAHawkConfig -a "Remove" -c $ConnectionString --NoBackupConfig
}