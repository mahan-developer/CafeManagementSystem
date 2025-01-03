; Script updated to include prerequisites for SQL Server Express and .NET Framework.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Cafe Manager"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "Mahan Javaheri"
#define MyAppURL "https://www.javaheri.work/"
#define MyAppExeName "CafeManager.exe"
#define MyAppAssocName MyAppName + " File"
#define MyAppAssocExt ".myp"
#define MyAppAssocKey StringChange(MyAppAssocName, " ", "") + MyAppAssocExt

[Setup]
AppId={{8BB88787-E6C9-4E26-A866-58968E19E306}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
ArchitecturesAllowed=x64compatible
ArchitecturesInstallIn64BitMode=x64compatible
ChangesAssociations=yes
DisableProgramGroupPage=yes
OutputDir=C:\Users\majav\Desktop
OutputBaseFilename=mysetup
SetupIconFile=C:\Users\majav\Desktop\CafeManager\design\logo.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"
Name: "german"; MessagesFile: "compiler:Languages\German.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "D:\Cafe\CafeManager.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Cafe\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Cafe\SQLEXPR_x64_ENU.exe"; DestDir: "{tmp}"; Flags: ignoreversion
Source: "D:\Cafe\dotnet4.7.2.exe"; DestDir: "{tmp}"; Flags: ignoreversion

[Dirs]
Name: "{app}"; Permissions: users-modify

[Files]
Source: "D:\Cafe\errorlog.txt"; DestDir: "{app}"; Flags: ignoreversion; Permissions: users-modify

[Registry]
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\OpenWithProgids"; ValueType: string; ValueName: "{#MyAppAssocKey}"; ValueData: ""; Flags: uninsdeletevalue
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}"; ValueType: string; ValueName: ""; ValueData: "{#MyAppAssocName}"; Flags: uninsdeletekey
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\{#MyAppExeName},0"
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
Root: HKA; Subkey: "Software\Classes\Applications\{#MyAppExeName}\SupportedTypes"; ValueType: string; ValueName: ".myp"; ValueData: ""

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{tmp}\dotnet4.7.2.exe"; Parameters: "/promptrestart";
Filename: "{tmp}\SQLEXPR_x64_ENU.exe"; Parameters: "/Q /ACTION=Install /INSTANCENAME=SQLEXPRESS /FEATURES=SQL /TCPENABLED=1 /NPENABLED=1 /IACCEPTSQLSERVERLICENSETERMS"; Flags: shellexec waituntilterminated;
Filename: "{app}\{#MyAppExeName}"; Description: "Launch {#MyAppName}"; Flags: nowait postinstall skipifsilent

[Code]
const
  DotNet472Release = '461808'; // Release number for .NET Framework 4.7.2

function IsDotNetInstalled(const Release: string; const Reserved: Integer): Boolean;
var
  Value: Cardinal;
begin
  Result := False;
  if RegQueryDWordValue(HKLM, 'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full', 'Release', Value) then
    Result := Value >= StrToInt(Release);
end;

function NeedsDotNet: Boolean;
begin
  Result := not IsDotNetInstalled(DotNet472Release, 0); 
  if Result then
    SuppressibleMsgBox(
      FmtMessage(SetupMessage(msgWinVersionTooLowError), ['.NET Framework', '4.7.2']),
      mbCriticalError, MB_OK, IDOK
    );
end;


function NeedsSQLServer: Boolean;
begin
  Result := not RegKeyExists(HKLM,'SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL')
end;
