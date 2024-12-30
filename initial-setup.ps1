dotnet new install NetDaemon.Templates.Project
mkdir $1
cd $1
dotnet new nd-project
dotnet tool restore
.\update-entities.ps1
