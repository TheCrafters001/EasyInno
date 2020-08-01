Public Class SelectInnoVer
    Private Sub SelectInnoVer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.InnoCompilerVer = "6" Then
            inno6_rad.Checked = True
            inno5_rad.Checked = False
            innoCurrent_lbl.Text = "Current Version: " & My.Settings.InnoCompilerVer
        ElseIf My.Settings.InnoCompilerVer = "5" Then
            inno6_rad.Checked = False
            inno5_rad.Checked = True
            innoCurrent_lbl.Text = "Current Version: " & My.Settings.InnoCompilerVer
        End If
    End Sub
End Class