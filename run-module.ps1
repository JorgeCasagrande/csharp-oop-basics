# run-module.ps1

# Folders
$modules = @(
    "01-classes-and-objects",
    "02-encapsulation",
    "03-inheritance",
    "04-polymorphism",
    "05-interfaces",
    "06-abstraction",
    "07-virtual-methods-and-override",
    "08-static-and-sealed-classes",
    "09-integrated-exercise"
)

Write-Host "Available modules:"
for ($i=0; $i -lt $modules.Length; $i++) {
    Write-Host "$($i+1): $($modules[$i])"
}

# User Entry
[int]$selection = 0
while ($selection -lt 1 -or $selection -gt $modules.Length) {
    $selection = Read-Host "Select the module number to run (1-$($modules.Length))"
    if (-not [int]::TryParse($selection, [ref]$null)) {
        Write-Host "Please enter a valid number."
        $selection = 0
    }
}

$moduleToRun = $modules[$selection - 1]
Write-Host "Running module: $moduleToRun"

# modulePath
$modulePath = Join-Path -Path (Get-Location) -ChildPath $moduleToRun

if (-Not (Test-Path $modulePath)) {
    Write-Host "Error: Module path not found: $modulePath"
    exit 1
}

# Run the module
Write-Host "Executing 'dotnet run' in $modulePath"
Push-Location $modulePath
dotnet run
Pop-Location