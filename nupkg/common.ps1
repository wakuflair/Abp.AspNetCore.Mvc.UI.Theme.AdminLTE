# Paths
$packFolder = (Get-Item -Path "./" -Verbose).FullName
$rootFolder = Join-Path $packFolder "../"

# List of projects
$projects = (

    "theme/Abp.AspNetCore.Mvc.UI.Theme.AdminLTE"
)