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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EasyInno))
        Me.MainControl = New System.Windows.Forms.TabControl()
        Me.SetupDetails = New System.Windows.Forms.TabPage()
        Me.InnoCode = New System.Windows.Forms.TabPage()
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
        Me.EasyInnoAboutBox = New System.Windows.Forms.RichTextBox()
        Me.EasyInnoAboutLabel = New System.Windows.Forms.Label()
        Me.MainControl.SuspendLayout()
        Me.AboutPage.SuspendLayout()
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
        Me.SetupDetails.Location = New System.Drawing.Point(4, 22)
        Me.SetupDetails.Name = "SetupDetails"
        Me.SetupDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.SetupDetails.Size = New System.Drawing.Size(802, 561)
        Me.SetupDetails.TabIndex = 0
        Me.SetupDetails.Text = "Setup Details"
        Me.SetupDetails.UseVisualStyleBackColor = True
        '
        'InnoCode
        '
        Me.InnoCode.Location = New System.Drawing.Point(4, 22)
        Me.InnoCode.Name = "InnoCode"
        Me.InnoCode.Size = New System.Drawing.Size(802, 561)
        Me.InnoCode.TabIndex = 19
        Me.InnoCode.Text = "Inno Code"
        Me.InnoCode.UseVisualStyleBackColor = True
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
        Me.AboutPage.Controls.Add(Me.EasyInnoAboutBox)
        Me.AboutPage.Controls.Add(Me.EasyInnoAboutLabel)
        Me.AboutPage.Location = New System.Drawing.Point(4, 22)
        Me.AboutPage.Name = "AboutPage"
        Me.AboutPage.Size = New System.Drawing.Size(802, 561)
        Me.AboutPage.TabIndex = 20
        Me.AboutPage.Text = "About"
        Me.AboutPage.UseVisualStyleBackColor = True
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
        Me.AboutPage.ResumeLayout(False)
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
End Class
