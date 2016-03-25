Imports System.IO

Public Class Select_Folder
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Form1.Show()
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Edit.Show()
        Close()
    End Sub

    Private Sub browsebutton_Click(sender As Object, e As EventArgs) Handles browsebutton.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then

            If File.Exists(FolderBrowserDialog1.SelectedPath + "\server.properties") Then
                My.Settings.path = FolderBrowserDialog1.SelectedPath
                My.Settings.Save()
                pathtext.Text = FolderBrowserDialog1.SelectedPath
                Button1.Enabled = True
            Else
                Button1.Enabled = False
                MsgBox("Failed to find server.properties in the selected Folder, please select one where a server has been installed.")
                pathtext.Text = ""
            End If

        End If
    End Sub

    Private Sub Select_Folder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
    End Sub
End Class