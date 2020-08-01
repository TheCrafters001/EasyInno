<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EasyInno
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EasyInno))
        Me.MainControl = New System.Windows.Forms.TabControl()
        Me.SetupDetails = New System.Windows.Forms.TabPage()
        Me.SoftwareDetailTabControl = New System.Windows.Forms.TabControl()
        Me.SoftwareInfoPage = New System.Windows.Forms.TabPage()
        Me.btn_Creation = New System.Windows.Forms.Button()
        Me.Btn_Compile = New System.Windows.Forms.Button()
        Me.softwareName_lbl = New System.Windows.Forms.Label()
        Me.appPublisher_txt = New System.Windows.Forms.TextBox()
        Me.softwareName_txt = New System.Windows.Forms.TextBox()
        Me.appPublisher_lbl = New System.Windows.Forms.Label()
        Me.softwareVer_lbl = New System.Windows.Forms.Label()
        Me.appWebsite_txt = New System.Windows.Forms.TextBox()
        Me.softwareVer_txt = New System.Windows.Forms.TextBox()
        Me.appWebsite_lbl = New System.Windows.Forms.Label()
        Me.ApplicationFolderPage = New System.Windows.Forms.TabPage()
        Me.noInstFolder_chk = New System.Windows.Forms.CheckBox()
        Me.allowChangeInstLoca_chk = New System.Windows.Forms.CheckBox()
        Me.folderName_txt = New System.Windows.Forms.TextBox()
        Me.folderName_lbl = New System.Windows.Forms.Label()
        Me.installLocation_lbl = New System.Windows.Forms.Label()
        Me.appLocation_txt = New System.Windows.Forms.TextBox()
        Me.programLocation_cmb = New System.Windows.Forms.ComboBox()
        Me.AppShortCuts = New System.Windows.Forms.TabPage()
        Me.WizardInfo = New System.Windows.Forms.TabPage()
        Me.wizardStyle_grp = New System.Windows.Forms.GroupBox()
        Me.wizardStyle_cmb = New System.Windows.Forms.ComboBox()
        Me.tip_lbl = New System.Windows.Forms.Label()
        Me.InnoCode = New System.Windows.Forms.TabPage()
        Me.InnoCodeRichTxtBox = New System.Windows.Forms.RichTextBox()
        Me.FilesPage = New System.Windows.Forms.TabPage()
        Me.files_lst = New System.Windows.Forms.ListBox()
        Me.Folders = New System.Windows.Forms.TabPage()
        Me.Icons = New System.Windows.Forms.TabPage()
        Me.INIFiles = New System.Windows.Forms.TabPage()
        Me.Registry = New System.Windows.Forms.TabPage()
        Me.Messages = New System.Windows.Forms.TabPage()
        Me.CustomMessages = New System.Windows.Forms.TabPage()
        Me.Types = New System.Windows.Forms.TabPage()
        Me.ComponentsPage = New System.Windows.Forms.TabPage()
        Me.Tasks = New System.Windows.Forms.TabPage()
        Me.Languages = New System.Windows.Forms.TabPage()
        Me.InstallRun = New System.Windows.Forms.TabPage()
        Me.InstallDelete = New System.Windows.Forms.TabPage()
        Me.UninstallRun = New System.Windows.Forms.TabPage()
        Me.UninstallDelete = New System.Windows.Forms.TabPage()
        Me.Code = New System.Windows.Forms.TabPage()
        Me.PreCompileSteps = New System.Windows.Forms.TabPage()
        Me.PostCompileSteps = New System.Windows.Forms.TabPage()
        Me.AboutPage = New System.Windows.Forms.TabPage()
        Me.EasyInnoSnake = New System.Windows.Forms.PictureBox()
        Me.EasyInnoAboutBox = New System.Windows.Forms.RichTextBox()
        Me.EasyInnoAboutLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.mainAppExe_grp = New System.Windows.Forms.GroupBox()
        Me.mainAppExe_txt = New System.Windows.Forms.TextBox()
        Me.mainAppExeBrowse_btn = New System.Windows.Forms.Button()
        Me.innoDetector_btn = New System.Windows.Forms.Button()
        Me.MainControl.SuspendLayout()
        Me.SetupDetails.SuspendLayout()
        Me.SoftwareDetailTabControl.SuspendLayout()
        Me.SoftwareInfoPage.SuspendLayout()
        Me.ApplicationFolderPage.SuspendLayout()
        Me.WizardInfo.SuspendLayout()
        Me.wizardStyle_grp.SuspendLayout()
        Me.InnoCode.SuspendLayout()
        Me.FilesPage.SuspendLayout()
        Me.AboutPage.SuspendLayout()
        CType(Me.EasyInnoSnake, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainAppExe_grp.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainControl
        '
        Me.MainControl.Controls.Add(Me.SetupDetails)
        Me.MainControl.Controls.Add(Me.InnoCode)
        Me.MainControl.Controls.Add(Me.FilesPage)
        Me.MainControl.Controls.Add(Me.Folders)
        Me.MainControl.Controls.Add(Me.Icons)
        Me.MainControl.Controls.Add(Me.INIFiles)
        Me.MainControl.Controls.Add(Me.Registry)
        Me.MainControl.Controls.Add(Me.Messages)
        Me.MainControl.Controls.Add(Me.CustomMessages)
        Me.MainControl.Controls.Add(Me.Types)
        Me.MainControl.Controls.Add(Me.ComponentsPage)
        Me.MainControl.Controls.Add(Me.Tasks)
        Me.MainControl.Controls.Add(Me.Languages)
        Me.MainControl.Controls.Add(Me.InstallRun)
        Me.MainControl.Controls.Add(Me.InstallDelete)
        Me.MainControl.Controls.Add(Me.UninstallRun)
        Me.MainControl.Controls.Add(Me.UninstallDelete)
        Me.MainControl.Controls.Add(Me.Code)
        Me.MainControl.Controls.Add(Me.PreCompileSteps)
        Me.MainControl.Controls.Add(Me.PostCompileSteps)
        Me.MainControl.Controls.Add(Me.AboutPage)
        Me.MainControl.Location = New System.Drawing.Point(12, 12)
        Me.MainControl.Name = "MainControl"
        Me.MainControl.SelectedIndex = 0
        Me.MainControl.Size = New System.Drawing.Size(810, 587)
        Me.MainControl.TabIndex = 0
        '
        'SetupDetails
        '
        Me.SetupDetails.Controls.Add(Me.SoftwareDetailTabControl)
        Me.SetupDetails.Controls.Add(Me.tip_lbl)
        Me.SetupDetails.Location = New System.Drawing.Point(4, 22)
        Me.SetupDetails.Name = "SetupDetails"
        Me.SetupDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.SetupDetails.Size = New System.Drawing.Size(802, 561)
        Me.SetupDetails.TabIndex = 0
        Me.SetupDetails.Text = "Setup Details"
        Me.SetupDetails.UseVisualStyleBackColor = True
        '
        'SoftwareDetailTabControl
        '
        Me.SoftwareDetailTabControl.Controls.Add(Me.SoftwareInfoPage)
        Me.SoftwareDetailTabControl.Controls.Add(Me.ApplicationFolderPage)
        Me.SoftwareDetailTabControl.Controls.Add(Me.AppShortCuts)
        Me.SoftwareDetailTabControl.Controls.Add(Me.WizardInfo)
        Me.SoftwareDetailTabControl.Location = New System.Drawing.Point(6, 6)
        Me.SoftwareDetailTabControl.Name = "SoftwareDetailTabControl"
        Me.SoftwareDetailTabControl.SelectedIndex = 0
        Me.SoftwareDetailTabControl.Size = New System.Drawing.Size(790, 536)
        Me.SoftwareDetailTabControl.TabIndex = 10
        '
        'SoftwareInfoPage
        '
        Me.SoftwareInfoPage.Controls.Add(Me.innoDetector_btn)
        Me.SoftwareInfoPage.Controls.Add(Me.btn_Creation)
        Me.SoftwareInfoPage.Controls.Add(Me.Btn_Compile)
        Me.SoftwareInfoPage.Controls.Add(Me.softwareName_lbl)
        Me.SoftwareInfoPage.Controls.Add(Me.appPublisher_txt)
        Me.SoftwareInfoPage.Controls.Add(Me.softwareName_txt)
        Me.SoftwareInfoPage.Controls.Add(Me.appPublisher_lbl)
        Me.SoftwareInfoPage.Controls.Add(Me.softwareVer_lbl)
        Me.SoftwareInfoPage.Controls.Add(Me.appWebsite_txt)
        Me.SoftwareInfoPage.Controls.Add(Me.softwareVer_txt)
        Me.SoftwareInfoPage.Controls.Add(Me.appWebsite_lbl)
        Me.SoftwareInfoPage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoftwareInfoPage.Location = New System.Drawing.Point(4, 22)
        Me.SoftwareInfoPage.Name = "SoftwareInfoPage"
        Me.SoftwareInfoPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SoftwareInfoPage.Size = New System.Drawing.Size(782, 510)
        Me.SoftwareInfoPage.TabIndex = 0
        Me.SoftwareInfoPage.Text = "Software Info"
        Me.SoftwareInfoPage.UseVisualStyleBackColor = True
        '
        'btn_Creation
        '
        Me.btn_Creation.Enabled = False
        Me.btn_Creation.Location = New System.Drawing.Point(595, 481)
        Me.btn_Creation.Name = "btn_Creation"
        Me.btn_Creation.Size = New System.Drawing.Size(100, 23)
        Me.btn_Creation.TabIndex = 11
        Me.btn_Creation.Text = "Creation Wizard"
        Me.btn_Creation.UseVisualStyleBackColor = True
        '
        'Btn_Compile
        '
        Me.Btn_Compile.Enabled = False
        Me.Btn_Compile.Location = New System.Drawing.Point(701, 481)
        Me.Btn_Compile.Name = "Btn_Compile"
        Me.Btn_Compile.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Compile.TabIndex = 10
        Me.Btn_Compile.Text = "Compile"
        Me.Btn_Compile.UseVisualStyleBackColor = True
        '
        'softwareName_lbl
        '
        Me.softwareName_lbl.AutoSize = True
        Me.softwareName_lbl.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.softwareName_lbl.Location = New System.Drawing.Point(6, 3)
        Me.softwareName_lbl.Name = "softwareName_lbl"
        Me.softwareName_lbl.Size = New System.Drawing.Size(87, 13)
        Me.softwareName_lbl.TabIndex = 1
        Me.softwareName_lbl.Text = "Software Name"
        '
        'appPublisher_txt
        '
        Me.appPublisher_txt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.appPublisher_txt.Location = New System.Drawing.Point(10, 101)
        Me.appPublisher_txt.Name = "appPublisher_txt"
        Me.appPublisher_txt.Size = New System.Drawing.Size(217, 22)
        Me.appPublisher_txt.TabIndex = 9
        Me.appPublisher_txt.Text = "My Company, Inc."
        '
        'softwareName_txt
        '
        Me.softwareName_txt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.softwareName_txt.Location = New System.Drawing.Point(10, 19)
        Me.softwareName_txt.Name = "softwareName_txt"
        Me.softwareName_txt.Size = New System.Drawing.Size(217, 22)
        Me.softwareName_txt.TabIndex = 2
        Me.softwareName_txt.Text = "My Application"
        '
        'appPublisher_lbl
        '
        Me.appPublisher_lbl.AutoSize = True
        Me.appPublisher_lbl.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.appPublisher_lbl.Location = New System.Drawing.Point(6, 85)
        Me.appPublisher_lbl.Name = "appPublisher_lbl"
        Me.appPublisher_lbl.Size = New System.Drawing.Size(117, 13)
        Me.appPublisher_lbl.TabIndex = 8
        Me.appPublisher_lbl.Text = "Application Publisher"
        '
        'softwareVer_lbl
        '
        Me.softwareVer_lbl.AutoSize = True
        Me.softwareVer_lbl.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.softwareVer_lbl.Location = New System.Drawing.Point(6, 44)
        Me.softwareVer_lbl.Name = "softwareVer_lbl"
        Me.softwareVer_lbl.Size = New System.Drawing.Size(94, 13)
        Me.softwareVer_lbl.TabIndex = 3
        Me.softwareVer_lbl.Text = "Software Version"
        '
        'appWebsite_txt
        '
        Me.appWebsite_txt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.appWebsite_txt.Location = New System.Drawing.Point(10, 142)
        Me.appWebsite_txt.Name = "appWebsite_txt"
        Me.appWebsite_txt.Size = New System.Drawing.Size(217, 22)
        Me.appWebsite_txt.TabIndex = 7
        Me.appWebsite_txt.Text = "http://thecrafters001.ga/easyinno/"
        '
        'softwareVer_txt
        '
        Me.softwareVer_txt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.softwareVer_txt.Location = New System.Drawing.Point(10, 60)
        Me.softwareVer_txt.Name = "softwareVer_txt"
        Me.softwareVer_txt.Size = New System.Drawing.Size(217, 22)
        Me.softwareVer_txt.TabIndex = 4
        Me.softwareVer_txt.Text = "1.5"
        '
        'appWebsite_lbl
        '
        Me.appWebsite_lbl.AutoSize = True
        Me.appWebsite_lbl.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.appWebsite_lbl.Location = New System.Drawing.Point(7, 126)
        Me.appWebsite_lbl.Name = "appWebsite_lbl"
        Me.appWebsite_lbl.Size = New System.Drawing.Size(111, 13)
        Me.appWebsite_lbl.TabIndex = 6
        Me.appWebsite_lbl.Text = "Application Website"
        '
        'ApplicationFolderPage
        '
        Me.ApplicationFolderPage.Controls.Add(Me.noInstFolder_chk)
        Me.ApplicationFolderPage.Controls.Add(Me.allowChangeInstLoca_chk)
        Me.ApplicationFolderPage.Controls.Add(Me.folderName_txt)
        Me.ApplicationFolderPage.Controls.Add(Me.folderName_lbl)
        Me.ApplicationFolderPage.Controls.Add(Me.installLocation_lbl)
        Me.ApplicationFolderPage.Controls.Add(Me.appLocation_txt)
        Me.ApplicationFolderPage.Controls.Add(Me.programLocation_cmb)
        Me.ApplicationFolderPage.Location = New System.Drawing.Point(4, 22)
        Me.ApplicationFolderPage.Name = "ApplicationFolderPage"
        Me.ApplicationFolderPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ApplicationFolderPage.Size = New System.Drawing.Size(782, 510)
        Me.ApplicationFolderPage.TabIndex = 1
        Me.ApplicationFolderPage.Text = "Application Folder"
        Me.ApplicationFolderPage.UseVisualStyleBackColor = True
        '
        'noInstFolder_chk
        '
        Me.noInstFolder_chk.AutoSize = True
        Me.noInstFolder_chk.Location = New System.Drawing.Point(6, 148)
        Me.noInstFolder_chk.Name = "noInstFolder_chk"
        Me.noInstFolder_chk.Size = New System.Drawing.Size(202, 17)
        Me.noInstFolder_chk.TabIndex = 6
        Me.noInstFolder_chk.Text = "This application doesn't need a folder"
        Me.noInstFolder_chk.UseVisualStyleBackColor = True
        '
        'allowChangeInstLoca_chk
        '
        Me.allowChangeInstLoca_chk.AutoSize = True
        Me.allowChangeInstLoca_chk.Checked = True
        Me.allowChangeInstLoca_chk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.allowChangeInstLoca_chk.Location = New System.Drawing.Point(6, 125)
        Me.allowChangeInstLoca_chk.Name = "allowChangeInstLoca_chk"
        Me.allowChangeInstLoca_chk.Size = New System.Drawing.Size(212, 17)
        Me.allowChangeInstLoca_chk.TabIndex = 5
        Me.allowChangeInstLoca_chk.Text = "Allow the user to change install location"
        Me.allowChangeInstLoca_chk.UseVisualStyleBackColor = True
        '
        'folderName_txt
        '
        Me.folderName_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folderName_txt.Location = New System.Drawing.Point(3, 99)
        Me.folderName_txt.Name = "folderName_txt"
        Me.folderName_txt.Size = New System.Drawing.Size(277, 20)
        Me.folderName_txt.TabIndex = 4
        Me.folderName_txt.Text = "My Application"
        '
        'folderName_lbl
        '
        Me.folderName_lbl.AutoSize = True
        Me.folderName_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folderName_lbl.Location = New System.Drawing.Point(6, 76)
        Me.folderName_lbl.Name = "folderName_lbl"
        Me.folderName_lbl.Size = New System.Drawing.Size(111, 20)
        Me.folderName_lbl.TabIndex = 3
        Me.folderName_lbl.Text = "Folder Name"
        '
        'installLocation_lbl
        '
        Me.installLocation_lbl.AutoSize = True
        Me.installLocation_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.installLocation_lbl.Location = New System.Drawing.Point(6, 3)
        Me.installLocation_lbl.Name = "installLocation_lbl"
        Me.installLocation_lbl.Size = New System.Drawing.Size(132, 20)
        Me.installLocation_lbl.TabIndex = 2
        Me.installLocation_lbl.Text = "Install Location"
        '
        'appLocation_txt
        '
        Me.appLocation_txt.Location = New System.Drawing.Point(3, 53)
        Me.appLocation_txt.Name = "appLocation_txt"
        Me.appLocation_txt.Size = New System.Drawing.Size(277, 20)
        Me.appLocation_txt.TabIndex = 1
        '
        'programLocation_cmb
        '
        Me.programLocation_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.programLocation_cmb.FormattingEnabled = True
        Me.programLocation_cmb.Items.AddRange(New Object() {"Program Files folder", "(Custom)"})
        Me.programLocation_cmb.Location = New System.Drawing.Point(3, 26)
        Me.programLocation_cmb.Name = "programLocation_cmb"
        Me.programLocation_cmb.Size = New System.Drawing.Size(277, 21)
        Me.programLocation_cmb.TabIndex = 0
        '
        'AppShortCuts
        '
        Me.AppShortCuts.Location = New System.Drawing.Point(4, 22)
        Me.AppShortCuts.Name = "AppShortCuts"
        Me.AppShortCuts.Size = New System.Drawing.Size(782, 510)
        Me.AppShortCuts.TabIndex = 2
        Me.AppShortCuts.Text = "Application Shortcuts"
        Me.AppShortCuts.UseVisualStyleBackColor = True
        '
        'WizardInfo
        '
        Me.WizardInfo.Controls.Add(Me.wizardStyle_grp)
        Me.WizardInfo.Location = New System.Drawing.Point(4, 22)
        Me.WizardInfo.Name = "WizardInfo"
        Me.WizardInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.WizardInfo.Size = New System.Drawing.Size(782, 510)
        Me.WizardInfo.TabIndex = 3
        Me.WizardInfo.Text = "Wizard Info"
        Me.WizardInfo.UseVisualStyleBackColor = True
        '
        'wizardStyle_grp
        '
        Me.wizardStyle_grp.Controls.Add(Me.wizardStyle_cmb)
        Me.wizardStyle_grp.Location = New System.Drawing.Point(6, 6)
        Me.wizardStyle_grp.Name = "wizardStyle_grp"
        Me.wizardStyle_grp.Size = New System.Drawing.Size(149, 55)
        Me.wizardStyle_grp.TabIndex = 0
        Me.wizardStyle_grp.TabStop = False
        Me.wizardStyle_grp.Text = "Wizard Style"
        '
        'wizardStyle_cmb
        '
        Me.wizardStyle_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.wizardStyle_cmb.FormattingEnabled = True
        Me.wizardStyle_cmb.Items.AddRange(New Object() {"modern", "classic"})
        Me.wizardStyle_cmb.Location = New System.Drawing.Point(6, 19)
        Me.wizardStyle_cmb.Name = "wizardStyle_cmb"
        Me.wizardStyle_cmb.Size = New System.Drawing.Size(137, 21)
        Me.wizardStyle_cmb.TabIndex = 1
        '
        'tip_lbl
        '
        Me.tip_lbl.AutoSize = True
        Me.tip_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tip_lbl.Location = New System.Drawing.Point(3, 545)
        Me.tip_lbl.Name = "tip_lbl"
        Me.tip_lbl.Size = New System.Drawing.Size(92, 13)
        Me.tip_lbl.TabIndex = 5
        Me.tip_lbl.Text = "bold = required"
        '
        'InnoCode
        '
        Me.InnoCode.Controls.Add(Me.InnoCodeRichTxtBox)
        Me.InnoCode.Location = New System.Drawing.Point(4, 22)
        Me.InnoCode.Name = "InnoCode"
        Me.InnoCode.Size = New System.Drawing.Size(802, 561)
        Me.InnoCode.TabIndex = 19
        Me.InnoCode.Text = "Inno Code"
        Me.InnoCode.UseVisualStyleBackColor = True
        '
        'InnoCodeRichTxtBox
        '
        Me.InnoCodeRichTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InnoCodeRichTxtBox.Cursor = System.Windows.Forms.Cursors.No
        Me.InnoCodeRichTxtBox.DetectUrls = False
        Me.InnoCodeRichTxtBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InnoCodeRichTxtBox.Location = New System.Drawing.Point(0, 0)
        Me.InnoCodeRichTxtBox.Name = "InnoCodeRichTxtBox"
        Me.InnoCodeRichTxtBox.ReadOnly = True
        Me.InnoCodeRichTxtBox.Size = New System.Drawing.Size(802, 561)
        Me.InnoCodeRichTxtBox.TabIndex = 0
        Me.InnoCodeRichTxtBox.Text = "#define MyAppName ""Sample Code Goes Here."""
        '
        'FilesPage
        '
        Me.FilesPage.Controls.Add(Me.mainAppExe_grp)
        Me.FilesPage.Controls.Add(Me.files_lst)
        Me.FilesPage.Location = New System.Drawing.Point(4, 22)
        Me.FilesPage.Name = "FilesPage"
        Me.FilesPage.Padding = New System.Windows.Forms.Padding(3)
        Me.FilesPage.Size = New System.Drawing.Size(802, 561)
        Me.FilesPage.TabIndex = 1
        Me.FilesPage.Text = "Files"
        Me.FilesPage.UseVisualStyleBackColor = True
        '
        'files_lst
        '
        Me.files_lst.FormattingEnabled = True
        Me.files_lst.Location = New System.Drawing.Point(385, 6)
        Me.files_lst.Name = "files_lst"
        Me.files_lst.Size = New System.Drawing.Size(411, 550)
        Me.files_lst.TabIndex = 0
        '
        'Folders
        '
        Me.Folders.Location = New System.Drawing.Point(4, 22)
        Me.Folders.Name = "Folders"
        Me.Folders.Size = New System.Drawing.Size(802, 561)
        Me.Folders.TabIndex = 2
        Me.Folders.Text = "Folders"
        Me.Folders.UseVisualStyleBackColor = True
        '
        'Icons
        '
        Me.Icons.Location = New System.Drawing.Point(4, 22)
        Me.Icons.Name = "Icons"
        Me.Icons.Size = New System.Drawing.Size(802, 561)
        Me.Icons.TabIndex = 3
        Me.Icons.Text = "Icons"
        Me.Icons.UseVisualStyleBackColor = True
        '
        'INIFiles
        '
        Me.INIFiles.Location = New System.Drawing.Point(4, 22)
        Me.INIFiles.Name = "INIFiles"
        Me.INIFiles.Size = New System.Drawing.Size(802, 561)
        Me.INIFiles.TabIndex = 4
        Me.INIFiles.Text = "INI Files"
        Me.INIFiles.UseVisualStyleBackColor = True
        '
        'Registry
        '
        Me.Registry.Location = New System.Drawing.Point(4, 22)
        Me.Registry.Name = "Registry"
        Me.Registry.Size = New System.Drawing.Size(802, 561)
        Me.Registry.TabIndex = 5
        Me.Registry.Text = "Registry"
        Me.Registry.UseVisualStyleBackColor = True
        '
        'Messages
        '
        Me.Messages.Location = New System.Drawing.Point(4, 22)
        Me.Messages.Name = "Messages"
        Me.Messages.Size = New System.Drawing.Size(802, 561)
        Me.Messages.TabIndex = 6
        Me.Messages.Text = "Messages"
        Me.Messages.UseVisualStyleBackColor = True
        '
        'CustomMessages
        '
        Me.CustomMessages.Location = New System.Drawing.Point(4, 22)
        Me.CustomMessages.Name = "CustomMessages"
        Me.CustomMessages.Size = New System.Drawing.Size(802, 561)
        Me.CustomMessages.TabIndex = 7
        Me.CustomMessages.Text = "Custom Messages"
        Me.CustomMessages.UseVisualStyleBackColor = True
        '
        'Types
        '
        Me.Types.Location = New System.Drawing.Point(4, 22)
        Me.Types.Name = "Types"
        Me.Types.Size = New System.Drawing.Size(802, 561)
        Me.Types.TabIndex = 8
        Me.Types.Text = "Types"
        Me.Types.UseVisualStyleBackColor = True
        '
        'ComponentsPage
        '
        Me.ComponentsPage.Location = New System.Drawing.Point(4, 22)
        Me.ComponentsPage.Name = "ComponentsPage"
        Me.ComponentsPage.Size = New System.Drawing.Size(802, 561)
        Me.ComponentsPage.TabIndex = 9
        Me.ComponentsPage.Text = "Components"
        Me.ComponentsPage.UseVisualStyleBackColor = True
        '
        'Tasks
        '
        Me.Tasks.Location = New System.Drawing.Point(4, 22)
        Me.Tasks.Name = "Tasks"
        Me.Tasks.Size = New System.Drawing.Size(802, 561)
        Me.Tasks.TabIndex = 10
        Me.Tasks.Text = "Tasks"
        Me.Tasks.UseVisualStyleBackColor = True
        '
        'Languages
        '
        Me.Languages.Location = New System.Drawing.Point(4, 22)
        Me.Languages.Name = "Languages"
        Me.Languages.Size = New System.Drawing.Size(802, 561)
        Me.Languages.TabIndex = 11
        Me.Languages.Text = "Languages"
        Me.Languages.UseVisualStyleBackColor = True
        '
        'InstallRun
        '
        Me.InstallRun.Location = New System.Drawing.Point(4, 22)
        Me.InstallRun.Name = "InstallRun"
        Me.InstallRun.Size = New System.Drawing.Size(802, 561)
        Me.InstallRun.TabIndex = 12
        Me.InstallRun.Text = "Install Run"
        Me.InstallRun.UseVisualStyleBackColor = True
        '
        'InstallDelete
        '
        Me.InstallDelete.Location = New System.Drawing.Point(4, 22)
        Me.InstallDelete.Name = "InstallDelete"
        Me.InstallDelete.Size = New System.Drawing.Size(802, 561)
        Me.InstallDelete.TabIndex = 13
        Me.InstallDelete.Text = "Install Delete"
        Me.InstallDelete.UseVisualStyleBackColor = True
        '
        'UninstallRun
        '
        Me.UninstallRun.Location = New System.Drawing.Point(4, 22)
        Me.UninstallRun.Name = "UninstallRun"
        Me.UninstallRun.Size = New System.Drawing.Size(802, 561)
        Me.UninstallRun.TabIndex = 14
        Me.UninstallRun.Text = "Uninstall Run"
        Me.UninstallRun.UseVisualStyleBackColor = True
        '
        'UninstallDelete
        '
        Me.UninstallDelete.Location = New System.Drawing.Point(4, 22)
        Me.UninstallDelete.Name = "UninstallDelete"
        Me.UninstallDelete.Size = New System.Drawing.Size(802, 561)
        Me.UninstallDelete.TabIndex = 15
        Me.UninstallDelete.Text = "Uninstall Delete"
        Me.UninstallDelete.UseVisualStyleBackColor = True
        '
        'Code
        '
        Me.Code.Location = New System.Drawing.Point(4, 22)
        Me.Code.Name = "Code"
        Me.Code.Size = New System.Drawing.Size(802, 561)
        Me.Code.TabIndex = 16
        Me.Code.Text = "Code"
        Me.Code.UseVisualStyleBackColor = True
        '
        'PreCompileSteps
        '
        Me.PreCompileSteps.Location = New System.Drawing.Point(4, 22)
        Me.PreCompileSteps.Name = "PreCompileSteps"
        Me.PreCompileSteps.Size = New System.Drawing.Size(802, 561)
        Me.PreCompileSteps.TabIndex = 17
        Me.PreCompileSteps.Text = "Pre-Compile Steps"
        Me.PreCompileSteps.UseVisualStyleBackColor = True
        '
        'PostCompileSteps
        '
        Me.PostCompileSteps.Location = New System.Drawing.Point(4, 22)
        Me.PostCompileSteps.Name = "PostCompileSteps"
        Me.PostCompileSteps.Size = New System.Drawing.Size(802, 561)
        Me.PostCompileSteps.TabIndex = 18
        Me.PostCompileSteps.Text = "Post-Compile Steps"
        Me.PostCompileSteps.UseVisualStyleBackColor = True
        '
        'AboutPage
        '
        Me.AboutPage.Controls.Add(Me.EasyInnoSnake)
        Me.AboutPage.Controls.Add(Me.EasyInnoAboutBox)
        Me.AboutPage.Controls.Add(Me.EasyInnoAboutLabel)
        Me.AboutPage.Location = New System.Drawing.Point(4, 22)
        Me.AboutPage.Name = "AboutPage"
        Me.AboutPage.Size = New System.Drawing.Size(802, 561)
        Me.AboutPage.TabIndex = 20
        Me.AboutPage.Text = "About"
        Me.AboutPage.UseVisualStyleBackColor = True
        '
        'EasyInnoSnake
        '
        Me.EasyInnoSnake.Image = Global.EasyInno.My.Resources.Resources.EasyInno_Icon
        Me.EasyInnoSnake.Location = New System.Drawing.Point(744, 3)
        Me.EasyInnoSnake.Name = "EasyInnoSnake"
        Me.EasyInnoSnake.Size = New System.Drawing.Size(55, 55)
        Me.EasyInnoSnake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.EasyInnoSnake.TabIndex = 2
        Me.EasyInnoSnake.TabStop = False
        '
        'EasyInnoAboutBox
        '
        Me.EasyInnoAboutBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EasyInnoAboutBox.Location = New System.Drawing.Point(3, 120)
        Me.EasyInnoAboutBox.Name = "EasyInnoAboutBox"
        Me.EasyInnoAboutBox.ReadOnly = True
        Me.EasyInnoAboutBox.Size = New System.Drawing.Size(796, 438)
        Me.EasyInnoAboutBox.TabIndex = 1
        Me.EasyInnoAboutBox.Text = resources.GetString("EasyInnoAboutBox.Text")
        '
        'EasyInnoAboutLabel
        '
        Me.EasyInnoAboutLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EasyInnoAboutLabel.Location = New System.Drawing.Point(3, 0)
        Me.EasyInnoAboutLabel.Name = "EasyInnoAboutLabel"
        Me.EasyInnoAboutLabel.Size = New System.Drawing.Size(796, 117)
        Me.EasyInnoAboutLabel.TabIndex = 0
        Me.EasyInnoAboutLabel.Text = "EasyInno" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "By TheCrafters001" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GNU GPL V3.0"
        Me.EasyInnoAboutLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        '
        'mainAppExe_grp
        '
        Me.mainAppExe_grp.Controls.Add(Me.mainAppExeBrowse_btn)
        Me.mainAppExe_grp.Controls.Add(Me.mainAppExe_txt)
        Me.mainAppExe_grp.Location = New System.Drawing.Point(6, 6)
        Me.mainAppExe_grp.Name = "mainAppExe_grp"
        Me.mainAppExe_grp.Size = New System.Drawing.Size(373, 160)
        Me.mainAppExe_grp.TabIndex = 2
        Me.mainAppExe_grp.TabStop = False
        Me.mainAppExe_grp.Text = "Main Application Executable"
        '
        'mainAppExe_txt
        '
        Me.mainAppExe_txt.Location = New System.Drawing.Point(6, 21)
        Me.mainAppExe_txt.Name = "mainAppExe_txt"
        Me.mainAppExe_txt.Size = New System.Drawing.Size(280, 20)
        Me.mainAppExe_txt.TabIndex = 0
        Me.mainAppExe_txt.Text = "C:\Program Files (x86)\Inno Setup 6\Examples\MyProg.exe"
        '
        'mainAppExeBrowse_btn
        '
        Me.mainAppExeBrowse_btn.Location = New System.Drawing.Point(292, 19)
        Me.mainAppExeBrowse_btn.Name = "mainAppExeBrowse_btn"
        Me.mainAppExeBrowse_btn.Size = New System.Drawing.Size(75, 23)
        Me.mainAppExeBrowse_btn.TabIndex = 1
        Me.mainAppExeBrowse_btn.Text = "Browse"
        Me.mainAppExeBrowse_btn.UseVisualStyleBackColor = True
        '
        'innoDetector_btn
        '
        Me.innoDetector_btn.Location = New System.Drawing.Point(473, 481)
        Me.innoDetector_btn.Name = "innoDetector_btn"
        Me.innoDetector_btn.Size = New System.Drawing.Size(116, 23)
        Me.innoDetector_btn.TabIndex = 12
        Me.innoDetector_btn.Text = "Setect Inno Version"
        Me.innoDetector_btn.UseVisualStyleBackColor = True
        '
        'EasyInno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 611)
        Me.Controls.Add(Me.MainControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "EasyInno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EasyInno"
        Me.MainControl.ResumeLayout(False)
        Me.SetupDetails.ResumeLayout(False)
        Me.SetupDetails.PerformLayout()
        Me.SoftwareDetailTabControl.ResumeLayout(False)
        Me.SoftwareInfoPage.ResumeLayout(False)
        Me.SoftwareInfoPage.PerformLayout()
        Me.ApplicationFolderPage.ResumeLayout(False)
        Me.ApplicationFolderPage.PerformLayout()
        Me.WizardInfo.ResumeLayout(False)
        Me.wizardStyle_grp.ResumeLayout(False)
        Me.InnoCode.ResumeLayout(False)
        Me.FilesPage.ResumeLayout(False)
        Me.AboutPage.ResumeLayout(False)
        Me.AboutPage.PerformLayout()
        CType(Me.EasyInnoSnake, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainAppExe_grp.ResumeLayout(False)
        Me.mainAppExe_grp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainControl As TabControl
    Friend WithEvents SetupDetails As TabPage
    Friend WithEvents InnoCode As TabPage
    Friend WithEvents FilesPage As TabPage
    Friend WithEvents Folders As TabPage
    Friend WithEvents Icons As TabPage
    Friend WithEvents INIFiles As TabPage
    Friend WithEvents Registry As TabPage
    Friend WithEvents Messages As TabPage
    Friend WithEvents CustomMessages As TabPage
    Friend WithEvents Types As TabPage
    Friend WithEvents ComponentsPage As TabPage
    Friend WithEvents Tasks As TabPage
    Friend WithEvents Languages As TabPage
    Friend WithEvents InstallRun As TabPage
    Friend WithEvents InstallDelete As TabPage
    Friend WithEvents UninstallRun As TabPage
    Friend WithEvents UninstallDelete As TabPage
    Friend WithEvents Code As TabPage
    Friend WithEvents PreCompileSteps As TabPage
    Friend WithEvents PostCompileSteps As TabPage
    Friend WithEvents AboutPage As TabPage
    Friend WithEvents EasyInnoAboutLabel As Label
    Friend WithEvents EasyInnoAboutBox As RichTextBox
    Friend WithEvents SoftwareDetailTabControl As TabControl
    Friend WithEvents SoftwareInfoPage As TabPage
    Friend WithEvents ApplicationFolderPage As TabPage
    Friend WithEvents appPublisher_txt As TextBox
    Friend WithEvents appPublisher_lbl As Label
    Friend WithEvents appWebsite_txt As TextBox
    Friend WithEvents appWebsite_lbl As Label
    Friend WithEvents tip_lbl As Label
    Friend WithEvents softwareVer_txt As TextBox
    Friend WithEvents softwareVer_lbl As Label
    Friend WithEvents softwareName_txt As TextBox
    Friend WithEvents softwareName_lbl As Label
    Friend WithEvents programLocation_cmb As ComboBox
    Friend WithEvents InnoCodeRichTxtBox As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents appLocation_txt As TextBox
    Friend WithEvents installLocation_lbl As Label
    Friend WithEvents folderName_txt As TextBox
    Friend WithEvents folderName_lbl As Label
    Friend WithEvents noInstFolder_chk As CheckBox
    Friend WithEvents allowChangeInstLoca_chk As CheckBox
    Friend WithEvents AppShortCuts As TabPage
    Friend WithEvents WizardInfo As TabPage
    Friend WithEvents wizardStyle_grp As GroupBox
    Friend WithEvents wizardStyle_cmb As ComboBox
    Friend WithEvents btn_Creation As Button
    Friend WithEvents Btn_Compile As Button
    Friend WithEvents EasyInnoSnake As PictureBox
    Friend WithEvents files_lst As ListBox
    Friend WithEvents mainAppExe_grp As GroupBox
    Friend WithEvents mainAppExeBrowse_btn As Button
    Friend WithEvents mainAppExe_txt As TextBox
    Friend WithEvents innoDetector_btn As Button
End Class
