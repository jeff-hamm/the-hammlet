pushd $PSScriptRoot 
try {
#    ./Config.ps1
    dotnet publish -o $HaNetDaemonPath
}
finally {
    popd
}