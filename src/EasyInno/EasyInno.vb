Public Class EasyInno
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If programLocation_cmb.Text = "Program Files folder" Then
            appLocation_txt.Enabled = False
        ElseIf programLocation_cmb.Text = "" Then
            programLocation_cmb.SelectedIndex = 0
        ElseIf programLocation_cmb.Text = "(Custom)" Then
            appLocation_txt.Enabled = True
        End If
        If noInstFolder_chk.Checked = True Then
            allowChangeInstLoca_chk.Enabled = False

        End If
        InnoCode_Conpiler.InnoCode()
    End Sub

    Private Sub EasyInno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        programLocation_cmb.SelectedIndex = 0
        wizardStyle_cmb.SelectedIndex = 0
    End Sub
End Class
