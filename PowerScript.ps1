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

    $controllerFileName = $TextInfo.ToTitleCase($_.BaseName) + "Controller.cs"

    $inputPath = $_.DirectoryName + '\' + $_.Name;


    $command = 'dotnet ' + $currentPath + '/nswag_dll/dotnet-nswag.dll swagger2cscontroller /input:' + $inputPath +' /classname:' + $controllerName + ' /namespace:VelocityEhs.Service.InternalApi.Ehs.InstanceApi.Controllers /output:' + $currentPath + '/Controllers/' + $controllerFileName + ' /UseLiquidTemplates:true /AspNetNamespace:"Microsoft.AspNetCore.Mvc" /ControllerBaseClass:"Microsoft.AspNetCore.Mvc.Controller"';
    
    Write-Host "Found schema " $_.Name
    Write-Host "Generating " $controllerFileName " ..."

    Invoke-Expression "$command"
}