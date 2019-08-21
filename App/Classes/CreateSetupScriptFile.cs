using Sigrain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigran.Classes
{
    class CreateSetupScriptFile
    {
        public static void Execute()
        {
            string content = @"
#define MyAppName ¨yyy¨
#define MyAppVersion ¨xxx¨
#define MyAppPublisher ¨yyy, Inc.¨
#define MyAppURL ¨https://github.com/foredunes/sigrain¨
#define MyAppExeName ¨Sigrain.exe¨

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
OutputBaseFilename = yyy xxx
SetupIconFile = logo64x64.ico
Compression = lzma
SolidCompression = yes
WizardStyle = modern
WizardSmallImageFile = logo138x140.bmp
DisableReadyPage = yes
DisableWelcomePage = no
WizardImageFile = panel328x604.bmp

[Languages]
Name: ¨english¨; MessagesFile: ¨compiler:Default.isl¨
Name: ¨brazilianportuguese¨; MessagesFile: ¨compiler:Languages\BrazilianPortuguese.isl¨
Name: ¨portuguese¨; MessagesFile: ¨compiler:Languages\Portuguese.isl¨

[Tasks]
Name: ¨desktopicon¨; Description: ¨{cm:CreateDesktopIcon}¨; GroupDescription: ¨{cm:AdditionalIcons}¨;

[Files]
Source: ¨..\bin\Debug\Sigrain.exe¨; DestDir: ¨{app}¨; Flags: ignoreversion
Source: ¨..\bin\Debug\*¨; DestDir: ¨{app}¨; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: ¨{autoprograms}\{#MyAppName}¨; Filename: ¨{app}\{#MyAppExeName}¨
Name: ¨{autodesktop}\{#MyAppName}¨; Filename: ¨{app}\{#MyAppExeName}¨; Tasks: desktopicon

[Run]
Filename: ¨{app}\{#MyAppExeName}¨; Description: ¨{cm:LaunchProgram,{#StringChange(MyAppName, ¨&¨, ¨&&¨)}}¨; Flags: nowait postinstall skipifsilent
                ";

            // Example #2: Write one string to a text file.
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllText(@"../../resources/Setup.iss", content.Replace('¨', '"').Replace("xxx", MainForm.AppVersion).Replace("yyy", MainForm.AppName));
        }
    }
}
