Public Class done
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Settings.doneSender = "forge" Then
            MsgBox("Double Click on start.cmd to start your Server. If at first it says the 'jarfile is corrupt' close the window, wait a few minutes and try again.")
        Else
            MsgBox("Double Click on start.cmd to start your Server. If at first it says the 'jarfile is corrupt' delete and reinstall.")
        End If
        Process.Start(My.Settings.installdirectory)
        Close()
    End Sub
End Class