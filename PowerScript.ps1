param
(   
    [string]$slnDir,
    [string]$projectDir
)

$currentPath = (Get-Location).Path;
$schemaPath = $currentPath + "\Schema";

Get-ChildItem $schemaPath -Filter *.json | 
Foreach-Object {
    $TextInfo = (Get-Culture).TextInfo

    $controllerName = $TextInfo.ToTitleCase($_.BaseName);

    $controllerFileName = $controllerName + "Controller.cs"

    $inputPath = $_.DirectoryName + '\' + $_.Name;


    $command = 'dotnet ' + $currentPath + '/nswag_dll/dotnet-nswag.dll swagger2cscontroller /input:' + $inputPath + ' /namespace:VelocityEhs.Service.InternalApi.Ehs.InstanceApi.Controllers /output:' + $currentPath + '/Controllers/' + $controllerFileName + ' /UseLiquidTemplates:true /operationGenerationMode:MultipleClientsFromFirstTagAndPathSegments /ControllerBaseClass:"Microsoft.AspNetCore.Mvc.Controller"';
    
    Write-Host "Found schema " $_.Name
    Write-Host "Generating " $controllerFileName " ..."

    Invoke-Expression "$command"
}

Get-ChildItem $schemaPath -Filter *.yaml | 
Foreach-Object {
    $TextInfo = (Get-Culture).TextInfo

    $controllerName = $TextInfo.ToTitleCase($_.BaseName);

    $controllerFileName = $controllerName + "Controller.cs"

    $inputPath = $_.DirectoryName + '\' + $_.Name;


    $command = 'dotnet ' + $currentPath + '/nswag_dll/dotnet-nswag.dll swagger2cscontroller /input:' + $inputPath + ' /namespace:VelocityEhs.Service.InternalApi.Ehs.InstanceApi.Controllers /output:' + $currentPath + '/Controllers/' + $controllerFileName + ' /UseLiquidTemplates:true /operationGenerationMode:MultipleClientsFromFirstTagAndPathSegments /ControllerBaseClass:"Microsoft.AspNetCore.Mvc.Controller"';
    
    Write-Host "Found schema " $_.Name
    Write-Host "Generating " $controllerFileName " ..."

    Invoke-Expression "$command"
}