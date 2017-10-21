Public Class HELP

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("C:\help\machine.pdf")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("C:\help\robot.pdf")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("C:\help\moule.pdf")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("C:\help\peripherique.pdf")
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("C:\help\inst generale.pdf")
    End Sub
End Class