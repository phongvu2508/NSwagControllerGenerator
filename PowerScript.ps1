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
    $controllerFileName = "Controller.cs"
    $clientFileName =  "EhsApiClient.cs"

    if ($controllerName -eq "InternalApi") {

        # $controllerFileName = $controllerName + "Controller.cs"

        $inputPath = $_.DirectoryName + '\' + $_.Name;

        $command = 'dotnet ' + $currentPath + '/nswag_dll_internal/dotnet-nswag.dll swagger2cscontroller /input:' + $inputPath + `
                    ' /namespace:VelocityEhs.Service.InternalApi.Ehs.InstanceApi.Controllers /output:' + $currentPath + `
                    '/GeneratedFiles/InternalAPI/' + $controllerFileName + `
                    ' /UseLiquidTemplates:true /operationGenerationMode:MultipleClientsFromFirstTagAndPathSegments' + `
                    ' /ControllerBaseClass:"Microsoft.AspNetCore.Mvc.Controller" /ResponseArrayType:"System.Collections.Generic.ICollection"';
    
        Write-Host "Found schema " $_.Name
        Write-Host "Generating " $controllerFileName " ..."

        Invoke-Expression "$command"

        # $clientFileName =  "EhsApiClient.cs"

        $clientCommand = 'dotnet ' + $currentPath + '/nswag_dll_web/dotnet-nswag.dll swagger2csclient /input:' + $inputPath + `
                            ' /namespace:VelocityEhs.UI.Web.Ehs.Infrastructure /ClassName:EhsApiClient /output:' + $currentPath + `
                            '/GeneratedFiles/WebAPI/' + $clientFileName + ' /UseLiquidTemplates:true /ResponseArrayType:"System.Collections.ObjectModel.Collection"' + `
                            ' /GenerateClientInterfaces:true /GenerateContractsOutput:true /ContractsNamespace:VelocityEhs.UI.Web.Ehs.Application.Contracts' + `
                            ' /ContractsOutput:' + $currentPath + '/GeneratedFiles/WebAPI/I' + $clientFileName;
    
        Write-Host "Generating " $clientCommand " ..."

        Invoke-Expression "$clientCommand"

        $clientCommandPublic = 'dotnet ' + $currentPath + '/nswag_dll_web/dotnet-nswag.dll swagger2csclient /input:' + $inputPath + `
                                ' /namespace:VelocityEhs.Service.PublicApi.Ehs.Infrastructure /ClassName:EhsApiClient /output:' + $currentPath + `
                                '/GeneratedFiles/PublicAPI/' + $clientFileName + ' /UseLiquidTemplates:true /ResponseArrayType:"System.Collections.ObjectModel.Collection"' + `
                                ' /GenerateClientInterfaces:true /GenerateContractsOutput:true /ContractsNamespace:VelocityEhs.Service.PublicApi.Ehs.Application.Contracts' + `
                                ' /ContractsOutput:' + $currentPath + '/GeneratedFiles/PublicAPI/I' + $clientFileName;
    
        Write-Host "Generating " $clientCommandPublic " ..."

        Invoke-Expression "$clientCommandPublic"

    }

    if ($controllerName -eq "WebApi") {

        # $controllerFileName = $controllerName + "Controller.cs"

        $inputPath = $_.DirectoryName + '\' + $_.Name;

        $command = 'dotnet ' + $currentPath + '/nswag_dll_web/dotnet-nswag.dll swagger2cscontroller /input:' + $inputPath + `
                    ' /namespace:VelocityEhs.UI.Web.Ehs.WebApi.Controllers /output:' + $currentPath + '/GeneratedFiles/WebAPI/' + $controllerFileName + `
                    ' /UseLiquidTemplates:true /operationGenerationMode:MultipleClientsFromFirstTagAndPathSegments' + `
                    ' /ControllerBaseClass:"Microsoft.AspNetCore.Mvc.Controller" /ResponseArrayType:"System.Collections.Generic.ICollection"';
    
        Write-Host "Found schema " $_.Name
        Write-Host "Generating " $controllerFileName " ..."

        Invoke-Expression "$command"

    }

    if ($controllerName -eq "PublicApi") {

        # $controllerFileName = $controllerName + "Controller.cs"

        $inputPath = $_.DirectoryName + '\' + $_.Name;

        $command = 'dotnet ' + $currentPath + '/nswag_dll_web/dotnet-nswag.dll swagger2cscontroller /input:' + $inputPath + `
                    ' /namespace:VelocityEhs.Service.PublicApi.Ehs.GatewayApi.Controllers /output:' + $currentPath + '/GeneratedFiles/PublicAPI/' + $controllerFileName + `
                    ' /UseLiquidTemplates:true /operationGenerationMode:MultipleClientsFromFirstTagAndPathSegments' + `
                    ' /ControllerBaseClass:"Microsoft.AspNetCore.Mvc.Controller" /ResponseArrayType:"System.Collections.Generic.ICollection"';
    
        Write-Host "Found schema " $_.Name
        Write-Host "Generating " $controllerFileName " ..."

        Invoke-Expression "$command"

    }

    if ($controllerName -eq "MobileApi") {

        # $controllerFileName = $controllerName + "Controller.cs"

        $inputPath = $_.DirectoryName + '\' + $_.Name;

        $command = 'dotnet ' + $currentPath + '/nswag_dll_web/dotnet-nswag.dll swagger2cscontroller /input:' + $inputPath + `
                    ' /namespace:VelocityEhs.UI.Web.Ehs.MobileApi.Controllers /output:' + $currentPath + '/GeneratedFiles/MobileAPI/' + $controllerFileName + `
                    ' /UseLiquidTemplates:true /operationGenerationMode:MultipleClientsFromFirstTagAndPathSegments' + `
                    ' /ControllerBaseClass:"Microsoft.AspNetCore.Mvc.Controller" /ResponseArrayType:"System.Collections.Generic.ICollection"';
    
        Write-Host "Found schema " $_.Name
        Write-Host "Generating " $controllerFileName " ..."

        Invoke-Expression "$command"

    }
}