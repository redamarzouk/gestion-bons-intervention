
Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If Ident.Text = "user" And MDP.Text = "userpassword" Then
            Me.Hide()
            Form4.Show()
        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub
End Class
