param(
	[string]$Folder,
	[string]$HaHost,
	[string]$Port,
	[switch]$Ssl,
	[string]$Token,
	[string]$BypassCert
)
$GenArgs=@('-fpe')
if($Folder) { $GenArgs += "-f $Folder" }
if($HaHost) { $GenArgs += "-host $HaHost" }
if($Port) { $GenArgs += "-port $Port" }
if($Ssl) { $GenArgs += "-ssl" }
if($Token) { $GenArgs += "-token $Token" }
if($BypassCert) { $GenArgs += "-bypass-cert" }
nd-codegen -fpe @GenArgs
