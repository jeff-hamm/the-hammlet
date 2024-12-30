function Set-Env($Name, $Value) {
    Set-Variable -Name $Name -Value $Value -Scope Global -Force
    si -Path "Env:\$Name" -Value $Value -Force
}
$Env:HaName=$global:HaName="hammassistant"
$Env:HaServerName=$Global:HaServerName="$HaName.local"
$Env:HaConfigPath=$Global:HaConfigPath="\\$HaServerName\config"
$Env:HaToken=$Global:HaToken='eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiI0NWIyMTNiZjk1M2M0NDliODMwYzllMWNlOGIyMzgwYyIsImlhdCI6MTczMzcyNDM3NiwiZXhwIjoyMDQ5MDg0Mzc2fQ.yXDNL8lFhO1WN5IeI-p98kPQj55uCUmGy6P7vr9vNvo'
$Env:HaNetDaemonPath=$Global:HaNetDaemonPath="\\$HaConfigPath\netdaemon5"
$Credential = Get-SecretCredential -Name "\\$Env:HaServerName" -Username="$Env:HaName"
echo $Credential.UserName
$Inf
Get-DriveOrCreate -RootPath "\\$HaServerName\config" -Credential $Credential -Persist:$false -UserName "$Env:HaName"