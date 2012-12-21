[Setup]
AppName=DTWrapper
AppCopyright=Created by Cyro
AppId={{4A1746B1-28DB-4152-98D0-8C6D645AB7B1}
SetupIconFile=..\DTWrapper\programIcon.ico
DefaultDirName={pf}\DTWrapper
DefaultGroupName=DTWrapper
UninstallDisplayName=DTWrapper
OutputBaseFilename=DTWrapper-setup
Compression=lzma2/ultra64
InternalCompressLevel=ultra
CompressionThreads=2
AppVersion=1.0.0
LicenseFile=licence.txt
UninstallDisplayIcon={app}\DTWrapper.exe

[Files]
Source: "..\DTWrapper\bin\Release\DTWrapper.exe"; DestDir: "{app}"
Source: "..\DTWrapper\bin\Release\DTWrapper.BDD.dll"; DestDir: "{app}"
Source: "..\DTWrapper\bin\Release\DTWrapper.CLI.dll"; DestDir: "{app}"
Source: "..\DTWrapper\bin\Release\DTWrapper.GUI.dll"; DestDir: "{app}"
Source: "..\DTWrapper\bin\Release\DTWrapper.Helpers.dll"; DestDir: "{app}"
Source: "..\DTWrapper\bin\Release\DTWrapper.Localization.dll"; DestDir: "{app}"
Source: "..\DTWrapper\bin\Release\DTWrapper.ShellExtension.dll"; DestDir: "{app}"
Source: "..\DTWrapper\bin\Release\Microsoft.WindowsAPICodePack.dll"; DestDir: "{app}"
Source: "..\DTWrapper\bin\Release\Microsoft.WindowsAPICodePack.Shell.dll"; DestDir: "{app}"
Source: "licence.txt"; DestDir: "{app}"; DestName: "LICENCE.txt"
Source: "..\DTWrapper\bin\Release\fr\DTWrapper.resources.dll"; DestDir: "{app}\fr"; Components: languages/french
Source: "..\DTWrapper\bin\Release\fr\DTWrapper.Localization.resources.dll"; DestDir: "{app}\fr"; Components: languages/french

[Dirs]
Name: "{app}\fr"; Components: languages/french

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"

[Icons]
Name: "{userdesktop}\DTWrapper"; Filename: "{app}\DTWrapper.exe"; WorkingDir: "{app}"; IconFilename: "{app}\DTWrapper.exe"; Tasks: desktopicon
Name: "{group}\DTWrapper"; Filename: "{app}\DTWrapper.exe"; WorkingDir: "{app}"; IconFilename: "{app}\DTWrapper.exe"
Name: "{group}\{cm:UninstallProgram,DTWrapper}"; Filename: "{uninstallexe}"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"

[Components]
Name: "main"; Description: "{cm:components_main}"; Types: full minimal custom; Flags: fixed
Name: "languages"; Description: "{cm:components_languages}"; Types: full
Name: "languages/english"; Description: "{cm:components_languages_english}"; Types: full custom minimal; Flags: fixed
Name: "languages/french"; Description: "{cm:components_languages_french}"; Types: full

[Types]
Name: "full"; Description: "{cm:types_full}"
Name: "minimal"; Description: "{cm:types_minimal}"
Name: "custom"; Description: "{cm:types_custom}"; Flags: iscustom

[Run]
Filename: "{app}\DTWrapper.exe"; Flags: nowait postinstall runasoriginaluser unchecked skipifsilent; Description: "{cm:LaunchProgram,DTWrapper}"


[CustomMessages]
components_main=Required Files
french.components_main=Fichiers Requis
components_languages=Languages
french.components_languages=Langues
components_languages_english=English
french.components_languages_english=Anglais
components_languages_french=French
french.components_languages_french=Français
types_full=Full Installation (All components will be installed)
french.types_full=Installation Complète (Tous les composants seront installés)
types_minimal=Minimal Installation (Only required components will be installed)
french.types_minimal=Installation Minimale (Seuls les composants requis seront installés)
types_custom=Custom Installation (Selected components will be installed)
french.types_custom=Installation Personnalisée (Seuls les composants séléctionnés seront installés)
