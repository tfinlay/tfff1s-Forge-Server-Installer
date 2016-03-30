Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MessageBox.Show("Installation Cancelled")
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If forge.Checked = True Then
            Me.Hide()
            Form2.Show()
            Me.Close()
        ElseIf spigotcheck.Checked = True
            Me.Hide()
            spigot.Show()
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        spigotcheck.Checked = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        forge.Checked = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'MsgBox("This Feature is not currently Available")
        Hide()
        Select_Folder.Show()
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.updateCheck = True Then
            Call CheckForUpdates()
        Else
            Label1.Text = "Updates Disabled"
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("https://github.com/tfff1OFFICIAL/tfff1s-Forge-Server-Installer/wiki")
    End Sub

    Public Sub CheckForUpdates()
        Try
            'My.Settings.lastupdatecheck = Date.Now
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://server-installer.weebly.com/uploads/2/0/2/4/20242643/version.txt")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadLine()
            Dim currentversion As String = Application.ProductVersion.ToString
            If newestversion.Contains(currentversion) Then
                Label1.Text = "No Updates Found"
            Else
                Dim result As Integer = MessageBox.Show("There is an update available for tfff1's Simple Server Installer, Would you like to download it?", "Update Available!", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    Label1.Text = "Updates Ignored"
                ElseIf result = DialogResult.Yes Then
                    Dim TheBrowser As Object = CreateObject("InternetExplorer.Application")
                    TheBrowser.Visible = True
                    TheBrowser.Navigate(sr.ReadLine)
                    MsgBox("Close tfff1's Simple Server Installer and run the newly downloaded exe to run the new version")
                End If
            End If
        Catch
            Label1.Text = "Failed to check for updates!"
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Options.Show()
    End Sub
End Class
