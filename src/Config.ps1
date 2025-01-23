class HammeletDaemon {
    $Name="hammassistant";
    $ServerName=$this.Name + ".local";
    $Port=8123;
    $ConfigPath="\\$($this.ServerName)\config";
    $NetDaemonVersion="5"
    $NetDaemonPath=$this.ConfigPath + "\netdaemon" + $this.NetDaemonVersion
    $DriveRoot=$this.ConfigPath
    $PersistDrive=$true
    $NdSlug="c6a2317c_netdaemon" + $this.NetDaemonVersion
    $NdJson='{"addon": "' + $this.NdSlug + '"}'
    $SrcPath=$PSScriptRoot
    $HaDrive
    $IsConnected
    MapDrive() {
        $Root=$this.DriveRoot
        if(!$this.HaDrive) {
            $Credential=(Get-SecretCredential -Name $this.DriveRoot -UserName "homeassistant" -Message "Enter the password for the Home Assistant user for $Root")
            Get-DriveOrCreate -RootPath $Root -Credential $Credential -Persist
            $this.HaDrive=$Env:HaDrive=$global:HaDrive=$global:CurrentPSDrive
        }
    }
    Connect() {
        if(!$this.IsConnected) {
            Import-Module Home-Assistant
            $Token = Get-SecretString -Name "HaToken" -AsPlainText
            $ip=(Resolve-DNSName 'hammassistant' | where Ip4Address -ne $null |  select -ExpandProperty IP4Address)
            Write-Information "Connecting to $($this.ServerName) [$ip]"
            New-HomeAssistantSession -ip $ip -port $this.Port -token $Token
            $this.IsConnected=$true
        }
    }
    InvokeService($service) {
        $this.Connect()
        Write-Information "Invoking $service"
        Invoke-HomeAssistantService -service $service -json $this.NdJson
    }
    UpdateTool() {
        dotnet tool update -g NetDaemon.HassModel.CodeGen
    }
    EntityUpdate() {
        $GenArgs=@('-fpe')
        # if($Folder) { $GenArgs += "-f $Folder" }
        # if($HaHost) { $GenArgs += "-host $HaHost" }
        # if($Port) { $GenArgs += "-port $Port" }
        # if($Ssl) { $GenArgs += "-ssl" }
        # if($Token) { $GenArgs += "-token $Token" }
        # if($BypassCert) { $GenArgs += "-bypass-cert" }
        nd-codegen -fpe @GenArgs 2>&1 | Write-Information
    }    
    RestartService() {
        # Point to the HA PowerSHell Module
        $this.InvokeService("HASSIO.ADDON_STOP")
        $this.InvokeService("HASSIO.ADDON_START")
    }
    Deploy() {
        $this.InvokeService("HASSIO.ADDON_STOP")
        ls -File $this.NetDaemonPath | %{
            rm $_ -Force -Recurse -Verbose
        } 
        pushd $this.SrcPath
        try {
            Write-Information "dotnet publish -c Release Hammlet.csproj -o $this.NetDaemonPath -v d"
            dotnet publish -c Release "Hammlet.csproj" -o $this.NetDaemonPath 2>&1 | Write-Information
        }
        finally {
            popd
        }
        $this.InvokeService("HASSIO.ADDON_START")
    }
}
function ReloadHammelet() {
    $global:Ha=$Null 
    . $PSScriptRoot\Config.ps1
    return $global:Ha
}
if($global:Ha) {
    return $global:Ha
}
$global:Ha=New-Object HammeletDaemon
$global:Ha.MapDrive()
return $Ha