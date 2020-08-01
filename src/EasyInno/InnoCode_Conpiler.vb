﻿Public Class InnoCode_Conpiler
    Public Shared Sub InnoCode()
        'The code below is just sample code, and is planned to made
        'dynamicly as user input is given, for now, though, this will do.
        '
        EasyInno.InnoCodeRichTxtBox.Text = "; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName """ + EasyInno.softwareName_txt.Text + """
#define MyAppVersion """ + EasyInno.softwareVer_txt.Text + """
#define MyAppPublisher """ + EasyInno.appPublisher_txt.Text + """
#define MyAppURL """ + EasyInno.appWebsite_txt.Text + """
#define MyAppExeName ""MyProg.exe""

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{GUID Generator coming soon}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputBaseFilename=mysetup
Compression=lzma
SolidCompression=yes
WizardStyle=" + EasyInno.wizardStyle_cmb.Text + "

[Languages]
Name: ""english""; MessagesFile: ""compiler:Default.isl""

[Tasks]
Name: ""desktopicon""; Description: ""{cm:CreateDesktopIcon}""; GroupDescription: ""{cm:AdditionalIcons}""; Flags: unchecked

[Files]
Source: ""C:\Program Files (x86)\Inno Setup 6\Examples\MyProg.exe""; DestDir: ""{app}""; Flags: ignoreversion
; NOTE: Don't use ""Flags: ignoreversion"" on any shared system files

[Icons]
Name: ""{autoprograms}\{#MyAppName}""; Filename: ""{app}\{#MyAppExeName}""
Name: ""{autodesktop}\{#MyAppName}""; Filename: ""{app}\{#MyAppExeName}""; Tasks: desktopicon

[Run]
Filename: ""{app}\{#MyAppExeName}""; Description: ""{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}""; Flags: nowait postinstall skipifsilent
"
    End Sub
    Public Shared Sub GUIDGenerator()
        Dim GUIDGen As Guid
        GUIDGen = Guid.NewGuid()
        Debug.WriteLine(GUIDGen)
    End Sub
End Class
