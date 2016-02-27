Imports System.IO
Public Class done
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Double Click on start.cmd to start your Server")
        Process.Start(My.Settings.installdirectory)
        Me.Close()
    End Sub
End Class