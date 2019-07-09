param
(   
    [string]$slnDir,
    [string]$projectDir
)

$currentPath = (Get-Location).Path;
$schemaPath = $currentPath + "\Schema";
$TextInfo = (Get-Culture).TextInfo

Get-ChildItem $schemaPath -Filter *.yaml | 
Foreach-Object {
    $controllerName = $TextInfo.ToTitleCase($_.BaseName);

    if($controllerName -eq "InternalApi") {

        $controllerFileName = $controllerName + "Controller.cs"

        $inputPath = $_.DirectoryName + '\' + $_.Name;


        $command = 'dotnet ' + $currentPath + '/nswag_dll_internal/dotnet-nswag.dll swagger2cscontroller /input:' + $inputPath + ' /namespace:VelocityEhs.Service.InternalApi.Ehs.InstanceApi.Controllers /output:' + $currentPath + '/GeneratedFiles/' + $controllerFileName + ' /UseLiquidTemplates:true /operationGenerationMode:MultipleClientsFromFirstTagAndPathSegments /ControllerBaseClass:"Microsoft.AspNetCore.Mvc.Controller" /ResponseArrayType:"System.Collections.Generic.ICollection"';
    
        Write-Host "Found schema " $_.Name
        Write-Host "Generating " $controllerFileName " ..."

        Invoke-Expression "$command"

        $clientFileName =  "Ehs" + $controllerName + "Client.cs"

        $clientCommand = 'dotnet ' + $currentPath + '/nswag_dll_web/dotnet-nswag.dll swagger2csclient /input:' + $inputPath + ' /namespace:VelocityEhs.UI.Web.Ehs.WebApi.Infrastructure /ClassName:EhsApiClient /output:' + $currentPath + '/GeneratedFiles/' + $clientFileName + ' /UseLiquidTemplates:true /ResponseArrayType:"System.Collections.ObjectModel.Collection" /GenerateClientInterfaces:true /GenerateContractsOutput:true /ContractsNamespace:VelocityEhs.UI.Web.Ehs.Application.Contracts /ContractsOutput:' + $currentPath + '/GeneratedFiles/I' + $clientFileName;
    
        Write-Host "Generating " $clientCommand " ..."

        Invoke-Expression "$clientCommand"

    }

    if($controllerName -eq "WebApi") {

        $controllerFileName = $controllerName + "Controller.cs"

        $inputPath = $_.DirectoryName + '\' + $_.Name;


        $command = 'dotnet ' + $currentPath + '/nswag_dll_web/dotnet-nswag.dll swagger2cscontroller /input:' + $inputPath + ' /namespace:VelocityEhs.UI.Web.Ehs.WebApi.Controllers /output:' + $currentPath + '/GeneratedFiles/' + $controllerFileName + ' /UseLiquidTemplates:true /operationGenerationMode:MultipleClientsFromFirstTagAndPathSegments /ControllerBaseClass:"Microsoft.AspNetCore.Mvc.Controller" /ResponseArrayType:"System.Collections.Generic.ICollection"';
    
        Write-Host "Found schema " $_.Name
        Write-Host "Generating " $controllerFileName " ..."

        Invoke-Expression "$command"

    }

    
}