$path = (Split-Path $MyInvocation.MyCommand.Path -Parent)
$src = Get-Content (Join-Path $path Kernel32Dll.cs) -Raw

Add-Type -TypeDefinition $src
