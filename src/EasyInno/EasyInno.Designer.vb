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
        Me.SoftwareNameLabel = New System.Windows.Forms.Label()
        Me.ApplicationPublisherTxtBox = New System.Windows.Forms.TextBox()
        Me.SoftwareNameTxtBox = New System.Windows.Forms.TextBox()
        Me.ApplicationPublisherLabel = New System.Windows.Forms.Label()
        Me.SoftwareVerLabel = New System.Windows.Forms.Label()
        Me.ApplicationSiteTxtBox = New System.Windows.Forms.TextBox()
        Me.SoftwareVerTxtBox = New System.Windows.Forms.TextBox()
        Me.ApplicationWebsiteLabel = New System.Windows.Forms.Label()
        Me.ApplicationFolderPage = New System.Windows.Forms.TabPage()
        Me.NoInstallLocationChkBox = New System.Windows.Forms.CheckBox()
        Me.AllowChangeInstallLocChkBox = New System.Windows.Forms.CheckBox()
        Me.FolderNameTxtBox = New System.Windows.Forms.TextBox()
        Me.FolderNameLabel = New System.Windows.Forms.Label()
        Me.InstallLocationLabel = New System.Windows.Forms.Label()
        Me.ApplicationLocationTxtBox = New System.Windows.Forms.TextBox()
        Me.ProgramLocationDropdown = New System.Windows.Forms.ComboBox()
        Me.AppShortCuts = New System.Windows.Forms.TabPage()
        Me.WizardInfo = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WizardStyleComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InnoCode = New System.Windows.Forms.TabPage()
        Me.InnoCodeRichTxtBox = New System.Windows.Forms.RichTextBox()
        Me.FilesPage = New System.Windows.Forms.TabPage()
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
        Me.MainControl.SuspendLayout()
        Me.SetupDetails.SuspendLayout()
        Me.SoftwareDetailTabControl.SuspendLayout()
        Me.SoftwareInfoPage.SuspendLayout()
        Me.ApplicationFolderPage.SuspendLayout()
        Me.WizardInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.InnoCode.SuspendLayout()
        Me.AboutPage.SuspendLayout()
        CType(Me.EasyInnoSnake, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SetupDetails.Controls.Add(Me.Label1)
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
        Me.SoftwareInfoPage.Controls.Add(Me.btn_Creation)
        Me.SoftwareInfoPage.Controls.Add(Me.Btn_Compile)
        Me.SoftwareInfoPage.Controls.Add(Me.SoftwareNameLabel)
        Me.SoftwareInfoPage.Controls.Add(Me.ApplicationPublisherTxtBox)
        Me.SoftwareInfoPage.Controls.Add(Me.SoftwareNameTxtBox)
        Me.SoftwareInfoPage.Controls.Add(Me.ApplicationPublisherLabel)
        Me.SoftwareInfoPage.Controls.Add(Me.SoftwareVerLabel)
        Me.SoftwareInfoPage.Controls.Add(Me.ApplicationSiteTxtBox)
        Me.SoftwareInfoPage.Controls.Add(Me.SoftwareVerTxtBox)
        Me.SoftwareInfoPage.Controls.Add(Me.ApplicationWebsiteLabel)
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
        'SoftwareNameLabel
        '
        Me.SoftwareNameLabel.AutoSize = True
        Me.SoftwareNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoftwareNameLabel.Location = New System.Drawing.Point(6, 3)
        Me.SoftwareNameLabel.Name = "SoftwareNameLabel"
        Me.SoftwareNameLabel.Size = New System.Drawing.Size(132, 20)
        Me.SoftwareNameLabel.TabIndex = 1
        Me.SoftwareNameLabel.Text = "Software Name"
        '
        'ApplicationPublisherTxtBox
        '
        Me.ApplicationPublisherTxtBox.Location = New System.Drawing.Point(10, 118)
        Me.ApplicationPublisherTxtBox.Name = "ApplicationPublisherTxtBox"
        Me.ApplicationPublisherTxtBox.Size = New System.Drawing.Size(217, 20)
        Me.ApplicationPublisherTxtBox.TabIndex = 9
        Me.ApplicationPublisherTxtBox.Text = "My Company, Inc."
        '
        'SoftwareNameTxtBox
        '
        Me.SoftwareNameTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoftwareNameTxtBox.Location = New System.Drawing.Point(10, 26)
        Me.SoftwareNameTxtBox.Name = "SoftwareNameTxtBox"
        Me.SoftwareNameTxtBox.Size = New System.Drawing.Size(217, 20)
        Me.SoftwareNameTxtBox.TabIndex = 2
        Me.SoftwareNameTxtBox.Text = "My Application"
        '
        'ApplicationPublisherLabel
        '
        Me.ApplicationPublisherLabel.AutoSize = True
        Me.ApplicationPublisherLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationPublisherLabel.Location = New System.Drawing.Point(6, 95)
        Me.ApplicationPublisherLabel.Name = "ApplicationPublisherLabel"
        Me.ApplicationPublisherLabel.Size = New System.Drawing.Size(156, 20)
        Me.ApplicationPublisherLabel.TabIndex = 8
        Me.ApplicationPublisherLabel.Text = "Application Publisher"
        '
        'SoftwareVerLabel
        '
        Me.SoftwareVerLabel.AutoSize = True
        Me.SoftwareVerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoftwareVerLabel.Location = New System.Drawing.Point(6, 49)
        Me.SoftwareVerLabel.Name = "SoftwareVerLabel"
        Me.SoftwareVerLabel.Size = New System.Drawing.Size(147, 20)
        Me.SoftwareVerLabel.TabIndex = 3
        Me.SoftwareVerLabel.Text = "Software Version"
        '
        'ApplicationSiteTxtBox
        '
        Me.ApplicationSiteTxtBox.Location = New System.Drawing.Point(10, 164)
        Me.ApplicationSiteTxtBox.Name = "ApplicationSiteTxtBox"
        Me.ApplicationSiteTxtBox.Size = New System.Drawing.Size(217, 20)
        Me.ApplicationSiteTxtBox.TabIndex = 7
        Me.ApplicationSiteTxtBox.Text = "http://thecrafters001.ga/easyinno/"
        '
        'SoftwareVerTxtBox
        '
        Me.SoftwareVerTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoftwareVerTxtBox.Location = New System.Drawing.Point(10, 72)
        Me.SoftwareVerTxtBox.Name = "SoftwareVerTxtBox"
        Me.SoftwareVerTxtBox.Size = New System.Drawing.Size(217, 20)
        Me.SoftwareVerTxtBox.TabIndex = 4
        Me.SoftwareVerTxtBox.Text = "1.5"
        '
        'ApplicationWebsiteLabel
        '
        Me.ApplicationWebsiteLabel.AutoSize = True
        Me.ApplicationWebsiteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationWebsiteLabel.Location = New System.Drawing.Point(6, 141)
        Me.ApplicationWebsiteLabel.Name = "ApplicationWebsiteLabel"
        Me.ApplicationWebsiteLabel.Size = New System.Drawing.Size(149, 20)
        Me.ApplicationWebsiteLabel.TabIndex = 6
        Me.ApplicationWebsiteLabel.Text = "Application Website"
        '
        'ApplicationFolderPage
        '
        Me.ApplicationFolderPage.Controls.Add(Me.NoInstallLocationChkBox)
        Me.ApplicationFolderPage.Controls.Add(Me.AllowChangeInstallLocChkBox)
        Me.ApplicationFolderPage.Controls.Add(Me.FolderNameTxtBox)
        Me.ApplicationFolderPage.Controls.Add(Me.FolderNameLabel)
        Me.ApplicationFolderPage.Controls.Add(Me.InstallLocationLabel)
        Me.ApplicationFolderPage.Controls.Add(Me.ApplicationLocationTxtBox)
        Me.ApplicationFolderPage.Controls.Add(Me.ProgramLocationDropdown)
        Me.ApplicationFolderPage.Location = New System.Drawing.Point(4, 22)
        Me.ApplicationFolderPage.Name = "ApplicationFolderPage"
        Me.ApplicationFolderPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ApplicationFolderPage.Size = New System.Drawing.Size(782, 510)
        Me.ApplicationFolderPage.TabIndex = 1
        Me.ApplicationFolderPage.Text = "Application Folder"
        Me.ApplicationFolderPage.UseVisualStyleBackColor = True
        '
        'NoInstallLocationChkBox
        '
        Me.NoInstallLocationChkBox.AutoSize = True
        Me.NoInstallLocationChkBox.Location = New System.Drawing.Point(6, 148)
        Me.NoInstallLocationChkBox.Name = "NoInstallLocationChkBox"
        Me.NoInstallLocationChkBox.Size = New System.Drawing.Size(202, 17)
        Me.NoInstallLocationChkBox.TabIndex = 6
        Me.NoInstallLocationChkBox.Text = "This application doesn't need a folder"
        Me.NoInstallLocationChkBox.UseVisualStyleBackColor = True
        '
        'AllowChangeInstallLocChkBox
        '
        Me.AllowChangeInstallLocChkBox.AutoSize = True
        Me.AllowChangeInstallLocChkBox.Checked = True
        Me.AllowChangeInstallLocChkBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AllowChangeInstallLocChkBox.Location = New System.Drawing.Point(6, 125)
        Me.AllowChangeInstallLocChkBox.Name = "AllowChangeInstallLocChkBox"
        Me.AllowChangeInstallLocChkBox.Size = New System.Drawing.Size(212, 17)
        Me.AllowChangeInstallLocChkBox.TabIndex = 5
        Me.AllowChangeInstallLocChkBox.Text = "Allow the user to change install location"
        Me.AllowChangeInstallLocChkBox.UseVisualStyleBackColor = True
        '
        'FolderNameTxtBox
        '
        Me.FolderNameTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FolderNameTxtBox.Location = New System.Drawing.Point(3, 99)
        Me.FolderNameTxtBox.Name = "FolderNameTxtBox"
        Me.FolderNameTxtBox.Size = New System.Drawing.Size(277, 20)
        Me.FolderNameTxtBox.TabIndex = 4
        Me.FolderNameTxtBox.Text = "My Application"
        '
        'FolderNameLabel
        '
        Me.FolderNameLabel.AutoSize = True
        Me.FolderNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FolderNameLabel.Location = New System.Drawing.Point(6, 76)
        Me.FolderNameLabel.Name = "FolderNameLabel"
        Me.FolderNameLabel.Size = New System.Drawing.Size(111, 20)
        Me.FolderNameLabel.TabIndex = 3
        Me.FolderNameLabel.Text = "Folder Name"
        '
        'InstallLocationLabel
        '
        Me.InstallLocationLabel.AutoSize = True
        Me.InstallLocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstallLocationLabel.Location = New System.Drawing.Point(6, 3)
        Me.InstallLocationLabel.Name = "InstallLocationLabel"
        Me.InstallLocationLabel.Size = New System.Drawing.Size(132, 20)
        Me.InstallLocationLabel.TabIndex = 2
        Me.InstallLocationLabel.Text = "Install Location"
        '
        'ApplicationLocationTxtBox
        '
        Me.ApplicationLocationTxtBox.Location = New System.Drawing.Point(3, 53)
        Me.ApplicationLocationTxtBox.Name = "ApplicationLocationTxtBox"
        Me.ApplicationLocationTxtBox.Size = New System.Drawing.Size(277, 20)
        Me.ApplicationLocationTxtBox.TabIndex = 1
        '
        'ProgramLocationDropdown
        '
        Me.ProgramLocationDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProgramLocationDropdown.FormattingEnabled = True
        Me.ProgramLocationDropdown.Items.AddRange(New Object() {"Program Files folder", "(Custom)"})
        Me.ProgramLocationDropdown.Location = New System.Drawing.Point(3, 26)
        Me.ProgramLocationDropdown.Name = "ProgramLocationDropdown"
        Me.ProgramLocationDropdown.Size = New System.Drawing.Size(277, 21)
        Me.ProgramLocationDropdown.TabIndex = 0
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
        Me.WizardInfo.Controls.Add(Me.GroupBox1)
        Me.WizardInfo.Location = New System.Drawing.Point(4, 22)
        Me.WizardInfo.Name = "WizardInfo"
        Me.WizardInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.WizardInfo.Size = New System.Drawing.Size(782, 510)
        Me.WizardInfo.TabIndex = 3
        Me.WizardInfo.Text = "Wizard Info"
        Me.WizardInfo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.WizardStyleComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(149, 55)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Wizard Style"
        '
        'WizardStyleComboBox
        '
        Me.WizardStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WizardStyleComboBox.FormattingEnabled = True
        Me.WizardStyleComboBox.Items.AddRange(New Object() {"modern", "classic"})
        Me.WizardStyleComboBox.Location = New System.Drawing.Point(6, 19)
        Me.WizardStyleComboBox.Name = "WizardStyleComboBox"
        Me.WizardStyleComboBox.Size = New System.Drawing.Size(137, 21)
        Me.WizardStyleComboBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 545)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "bold = required"
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
        Me.InnoCodeRichTxtBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InnoCodeRichTxtBox.Location = New System.Drawing.Point(0, 0)
        Me.InnoCodeRichTxtBox.Name = "InnoCodeRichTxtBox"
        Me.InnoCodeRichTxtBox.ReadOnly = True
        Me.InnoCodeRichTxtBox.Size = New System.Drawing.Size(802, 561)
        Me.InnoCodeRichTxtBox.TabIndex = 0
        Me.InnoCodeRichTxtBox.Text = ""
        '
        'FilesPage
        '
        Me.FilesPage.Location = New System.Drawing.Point(4, 22)
        Me.FilesPage.Name = "FilesPage"
        Me.FilesPage.Padding = New System.Windows.Forms.Padding(3)
        Me.FilesPage.Size = New System.Drawing.Size(802, 561)
        Me.FilesPage.TabIndex = 1
        Me.FilesPage.Text = "Files"
        Me.FilesPage.UseVisualStyleBackColor = True
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
        Me.GroupBox1.ResumeLayout(False)
        Me.InnoCode.ResumeLayout(False)
        Me.AboutPage.ResumeLayout(False)
        Me.AboutPage.PerformLayout()
        CType(Me.EasyInnoSnake, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ApplicationPublisherTxtBox As TextBox
    Friend WithEvents ApplicationPublisherLabel As Label
    Friend WithEvents ApplicationSiteTxtBox As TextBox
    Friend WithEvents ApplicationWebsiteLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SoftwareVerTxtBox As TextBox
    Friend WithEvents SoftwareVerLabel As Label
    Friend WithEvents SoftwareNameTxtBox As TextBox
    Friend WithEvents SoftwareNameLabel As Label
    Friend WithEvents ProgramLocationDropdown As ComboBox
    Friend WithEvents InnoCodeRichTxtBox As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ApplicationLocationTxtBox As TextBox
    Friend WithEvents InstallLocationLabel As Label
    Friend WithEvents FolderNameTxtBox As TextBox
    Friend WithEvents FolderNameLabel As Label
    Friend WithEvents NoInstallLocationChkBox As CheckBox
    Friend WithEvents AllowChangeInstallLocChkBox As CheckBox
    Friend WithEvents AppShortCuts As TabPage
    Friend WithEvents WizardInfo As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents WizardStyleComboBox As ComboBox
    Friend WithEvents btn_Creation As Button
    Friend WithEvents Btn_Compile As Button
    Friend WithEvents EasyInnoSnake As PictureBox
End Class
