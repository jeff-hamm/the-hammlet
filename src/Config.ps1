class HammeletDaemon {
    $Name="dreamassistant";
    $LocalSuffix=".local";
    $RemoteSuffix=".infinitebutts.com";
    $PreferLocal=$true;
    $ServerName=$this.Name + ($this.PreferLocal ? $this.LocalSuffix : $this.RemoteSuffix);
    $Scheme=$this.PreferLocal ? "http" : "https";
    $Url="$Scheme`://$($this.ServerName)";
    $IsSsl=$this.Url.StartsWith("https")
    $Port=$this.IsSsl ? 443 : 8123;
    $PreferDns=$false;
    $Ip="192.168.1.161";
#    $ConfigPath="\\$($this.ServerName)\config";
#    $ConfigPath="\\$($this.Ip)\config";
    $ConfigPath="Z:\\";
    $NetDaemonVersion="5"
    $NetDaemonPath=$this.ConfigPath + "\netdaemon" + $this.NetDaemonVersion
    $DriveRoot=$this.ConfigPath
    $PersistDrive=$true
    $NdSlug="c6a2317c_netdaemon" + $this.NetDaemonVersion
    $NdJson='{"addon": "' + $this.NdSlug + '"}'
    $SrcPath=$PSScriptRoot
    $HaDrive
    IsConnected() {
        $global:ha_api_configured
    }
    MapDrive() {
        $Root=$this.DriveRoot
        if(!$this.HaDrive) {
            $Credential=(Get-SecretCredential -Name $this.DriveRoot -UserName "homeassistant" -Message "Enter the password for the Home Assistant user for $Root")
            Get-DriveOrCreate -RootPath $Root -Credential $Credential -Persist
            $this.HaDrive=$Env:HaDrive=$global:HaDrive=$global:CurrentPSDrive
        }
    }
    Connect() {
        
        if(!$this.IsConnected()) {
            Import-Module Home-Assistant
            $Token = Get-SecretString -Name "Ha$($this.Name)Token" -AsPlainText
            $HaHost=$this.PreferDns ? $this.ServerName : $this.Ip
            echo "Connecting to $HaHost"
            if(!$HaHost) {
                if($this.ServerName) {
                    $this.Ip=$HaHost=(Resolve-DNSName $this.ServerName | where Ip4Address -ne $null |  select -ExpandProperty IP4Address)
                }
            }
            echo "Connecting to $($this.Scheme)`://$HaHost`:$($this.Port)"
            New-HomeAssistantSession -ip $HaHost -port $this.Port -token $Token -scheme $this.Scheme
            $global:ha_api_configured=$true
#            $this.IsConnected=$true
        }
    }
    Disconnect() {
        if($this.IsConnected()) {
            $global:ha_api_configured=$false
 #           $this.IsConnected=$false
        }
    }
    InvokeService($service) {
        $this.Connect()
        try {
            Write-Information "Invoking $service"
            Invoke-HomeAssistantService -service $service -json $this.NdJson
        }
        catch {
            $this.Disconnect()
            throw
        }
    }
    UpdateTool() {
        dotnet tool update -g NetDaemon.HassModel.CodeGen
    }
    $Tool="..\submodules\netdaemon\src\HassModel\NetDaemon.HassModel.CodeGenerator\bin\Debug\net9.0\NetDaemon.HassModel.CodeGenerator.exe"
#    $Tool="nd-codegen"
    EntityUpdate() {
        $GenArgs="-fpe"
        # if($Folder) { $GenArgs += "-f $Folder" }
        # if($HaHost) { $GenArgs += "-host $HaHost" }
        # if($Port) { $GenArgs += "-port $Port" }
        # if($Ssl) { $GenArgs += "-ssl" }
        
        # if($Token) { $GenArgs += "-token $Token" }
        # if($BypassCert) { $GenArgs += "-bypass-cert" }
        $token=(Get-SecretString -Name "Ha$($this.Name)Token" -AsPlainText)
        if($this.IsSsl) { 
            $GenArgs += " -ssl true" 
        }
        $HaHost=$this.Ip
        if(!$HaHost) {
            $HaHost=$this.ServerName
        }
        Invoke-Expression "$($This.Tool) $GenArgs -host $($HaHost) -port $($This.Port) -token $token 2>&1 | Write-Information"
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
$global:InformationPreference="Continue"
return $Ha