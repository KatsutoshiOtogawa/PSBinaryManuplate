
# 

@{
    ModuleVersion = '#tagVersion'
    Author = 'Otogawa Katsutoshi'
    Copyright = 'Otogawa Katsutoshi. All rights reserved.'
    # Supported PSEditions
    CompatiblePSEditions = 'Core', 'Desktop'
    PowerShellVersion = '5.1'
    Description = 'Multi platform binary join and split.'
    GUID = '1e2fcd4a-ea9f-4edd-bcc2-ddd2692338eb'
    ModuleToProcess = 'PSBinaryManuplate.psm1'
    FunctionsToExport = 'Join-BinaryItem'
        # 'Split-BinaryItem'

    PrivateData = @{
        PSData = @{
            Tags = 'Binary','split'
            ProjectUri = 'https://github.com/KatsutoshiOtogawa/PSBinaryManuplate'
            LicenseUri = 'https://github.com/KatsutoshiOtogawa/PSBinaryManuplate/blob/v#tagVersion/PSBinaryManuplate/LICENSE'
            ReleaseNotes = 'Release notes for version 1.0'
        }
    }
    # RequiredModules = @{

    # }
}
