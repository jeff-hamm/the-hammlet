function Set-Env($Name, $Value) {
    Set-Variable -Name $Name -Value $Value -Scope Global -Force
    si -Path "Env:\$Name" -Value $Value -Force
    
}
Set-Env("HaName", "hammassistant")
Set-Env("HaServerName", "$HaName.local")
Set-Env("HaConfigPath", "\\$HaServerName\config")

Set-Env("HaToken", 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiI0NWIyMTNiZjk1M2M0NDliODMwYzllMWNlOGIyMzgwYyIsImlhdCI6MTczMzcyNDM3NiwiZXhwIjoyMDQ5MDg0Mzc2fQ.yXDNL8lFhO1WN5IeI-p98kPQj55uCUmGy6P7vr9vNvo')
Set-Env("HaNetDaemonPath", "\\$HaConfigPath\netdaemon5")
. "$PsScriptRoot/Map-Drive.ps1"
