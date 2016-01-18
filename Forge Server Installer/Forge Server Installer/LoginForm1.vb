Imports System.Net

Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Private Sub resetPwField()
        ' If (InvokeRequired) Then
        'Invoke(Sub() resetPwField())
        '  Else
        ' TxtBox1.Text = ""
        ' End If
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        'Dim response As String = New WebClient().DownloadString("https://session.minecraft.net/game/getversion.jsp?user=" & TxtBox2.Text & "&password=" & TxtBox1.Text & "&version=13")
        'Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)
        'Dim ProcessProperties As New ProcessStartInfo
        'If (InStr(response, "Bad") Or InStr(response, "Invalid")) Then
        'MessageBox.Show("Invalid username/password")
        'resetPwField()
        ' Else
        Dim dl As String
        dl = "https://login.minecraft.net/?user=" & TxtBox2.Text
        dl = dl & "&password="
        dl = dl & TxtBox1.Text
        dl = dl & "&version=884"

        Dim str As String = New WebClient().DownloadString(dl)

        If (InStr(str, "Bad") Or InStr(str, "Invalid") Or InStr(str, "false")) Then
            MessageBox.Show("Invalid username/password")
            resetPwField()
        Else

            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click

    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles TxtBox2.TextChanged

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles TxtBox1.TextChanged

    End Sub
End Class
