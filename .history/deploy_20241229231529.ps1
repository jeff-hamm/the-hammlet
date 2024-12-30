pushd $PSScriptRoot 
try {
#    ./Config.ps1
    dotnet publish Hammlet.NetDaemon.csproj -o $HaNetDaemonPath
}
finally {
    popd
}