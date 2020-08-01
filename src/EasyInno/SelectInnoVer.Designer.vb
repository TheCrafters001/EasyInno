<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectInnoVer
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
        Me.select_grp = New System.Windows.Forms.GroupBox()
        Me.select_btn = New System.Windows.Forms.Button()
        Me.inno5_rad = New System.Windows.Forms.RadioButton()
        Me.inno6_rad = New System.Windows.Forms.RadioButton()
        Me.innoCurrent_lbl = New System.Windows.Forms.Label()
        Me.select_grp.SuspendLayout()
        Me.SuspendLayout()
        '
        'select_grp
        '
        Me.select_grp.Controls.Add(Me.innoCurrent_lbl)
        Me.select_grp.Controls.Add(Me.inno6_rad)
        Me.select_grp.Controls.Add(Me.inno5_rad)
        Me.select_grp.Location = New System.Drawing.Point(12, 12)
        Me.select_grp.Name = "select_grp"
        Me.select_grp.Size = New System.Drawing.Size(410, 158)
        Me.select_grp.TabIndex = 0
        Me.select_grp.TabStop = False
        Me.select_grp.Text = "Select a Version"
        '
        'select_btn
        '
        Me.select_btn.Location = New System.Drawing.Point(347, 176)
        Me.select_btn.Name = "select_btn"
        Me.select_btn.Size = New System.Drawing.Size(75, 23)
        Me.select_btn.TabIndex = 1
        Me.select_btn.Text = "Select"
        Me.select_btn.UseVisualStyleBackColor = True
        '
        'inno5_rad
        '
        Me.inno5_rad.AutoSize = True
        Me.inno5_rad.Location = New System.Drawing.Point(6, 19)
        Me.inno5_rad.Name = "inno5_rad"
        Me.inno5_rad.Size = New System.Drawing.Size(91, 17)
        Me.inno5_rad.TabIndex = 0
        Me.inno5_rad.TabStop = True
        Me.inno5_rad.Text = "Inno Setup 5"
        Me.inno5_rad.UseVisualStyleBackColor = True
        '
        'inno6_rad
        '
        Me.inno6_rad.AutoSize = True
        Me.inno6_rad.Location = New System.Drawing.Point(6, 42)
        Me.inno6_rad.Name = "inno6_rad"
        Me.inno6_rad.Size = New System.Drawing.Size(91, 17)
        Me.inno6_rad.TabIndex = 1
        Me.inno6_rad.TabStop = True
        Me.inno6_rad.Text = "Inno Setup 6"
        Me.inno6_rad.UseVisualStyleBackColor = True
        '
        'innoCurrent_lbl
        '
        Me.innoCurrent_lbl.AutoSize = True
        Me.innoCurrent_lbl.Location = New System.Drawing.Point(6, 142)
        Me.innoCurrent_lbl.Name = "innoCurrent_lbl"
        Me.innoCurrent_lbl.Size = New System.Drawing.Size(93, 13)
        Me.innoCurrent_lbl.TabIndex = 2
        Me.innoCurrent_lbl.Text = "Current Version: "
        '
        'SelectInnoVer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 211)
        Me.Controls.Add(Me.select_btn)
        Me.Controls.Add(Me.select_grp)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectInnoVer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select a Version"
        Me.select_grp.ResumeLayout(False)
        Me.select_grp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents select_grp As GroupBox
    Friend WithEvents select_btn As Button
    Friend WithEvents inno6_rad As RadioButton
    Friend WithEvents inno5_rad As RadioButton
    Friend WithEvents innoCurrent_lbl As Label
End Class
