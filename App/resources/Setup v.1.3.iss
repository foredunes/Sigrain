
#define MyAppName "Sigran"
#define MyAppVersion "1.3"
#define MyAppPublisher "Sigran, Inc."
#define MyAppURL "https://github.com/foredunes/sigran"
#define MyAppExeName "Sigran.exe"

[Setup]
AppId ={{ C7755C12 - 71D3 - 48B1 - 9A19 - E8DC112845A5}
AppName ={#MyAppName}
AppVersion ={#MyAppVersion}
AppPublisher ={#MyAppPublisher}
AppPublisherURL ={#MyAppURL}
AppSupportURL ={#MyAppURL}
AppUpdatesURL ={#MyAppURL}
DefaultDirName ={autopf}\{#MyAppName}
DisableProgramGroupPage = yes
LicenseFile = ..\..\LICENSE
OutputDir = ..\bin\Release
OutputBaseFilename = Sigran 1.3
SetupIconFile = logo64x64.ico
Compression = lzma
SolidCompression = yes
WizardStyle = modern
WizardSmallImageFile = logo138x140.bmp
DisableReadyPage = yes
DisableWelcomePage = no
WizardImageFile = panel328x604.bmp

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "brazilianportuguese"; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"
Name: "portuguese"; MessagesFile: "compiler:Languages\Portuguese.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}";

[Files]
Source: "..\bin\Debug\Sigran.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\bin\Debug\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, "&", "&&")}}"; Flags: nowait postinstall skipifsilent
                