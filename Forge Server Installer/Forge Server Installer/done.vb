Public Class done
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Computer.FileSystem.FileExists(My.Settings.installdirectory + "\start.cmd") Then
            Process.Start(My.Settings.installdirectory + "\start.cmd")
        Else
            MsgBox("Failed to find start.cmd. There is something wrong...")
        End If
    End Sub
End Class