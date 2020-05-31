Public Class EasyInno
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgramLocationDropdown.Text = "Program Files folder" Then
            ApplicationLocationTxtBox.Enabled = False
        ElseIf ProgramLocationDropdown.Text = "" Then
            ProgramLocationDropdown.SelectedIndex = 0
        ElseIf ProgramLocationDropdown.Text = "(Custom)" Then
            ApplicationLocationTxtBox.Enabled = True
        End If
        If NoInstallLocationChkBox.Checked = True Then
            AllowChangeInstallLocChkBox.Enabled = False

        End If
    End Sub

    Private Sub EasyInno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
