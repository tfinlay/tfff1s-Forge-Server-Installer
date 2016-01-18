Imports System.ComponentModel
Imports System.IO.Compression
Imports System.Security.Permissions

Module Module1
    Sub unzip()
        'Dim startPath As String = "c:\example\start"
        'location of zip file:
        Dim zipPath As String = My.Settings.ziplocation
        'Folder to extract to:
        Dim extractPath As String = My.Settings.installdirectory

        'ZipFile.CreateFromDirectory(startPath, zipPath)

        ZipFile.ExtractToDirectory(zipPath, extractPath)

        If My.Computer.FileSystem.DirectoryExists(My.Settings.installdirectory + "\TEMP") Then
            System.IO.Directory.Delete(My.Settings.installdirectory + "\TEMP", True)
        End If

        Form2.ProgressBar1.Value = "100"

        Form2.Hide()
        done.Show()
        Form2.Close()
    End Sub
End Module