Imports System.IO
Imports System.Net
Imports System.Text
'Imports System.IO.Compression
Public Class spigot
    Public path As String
    Public ip As String
    Public portno As String
    Public motd As String
    Public WG As String
    Public currentdate As String
    Public installdate As String
    Public oplevel As String
    Public netherq As String
    Public flightq As String
    Public pa As String
    Public worldseed As String
    Public forcegmq As String
    Public npcsq As String
    Public animalsq As String
    Public hardcoreq As String
    Public snooperq As String
    Public onlineq As String
    Public pvpq As String
    Public difficulty As String
    Public cbq As String
    Public maxplayer As String
    Public monstersq As String
    Public structuresq As String
    Public viewdist As String
    Public gamemode As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles browsebutton.Click
        MessageBox.Show("It is recommended that you select a new and empty folder")
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            pathtext.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles installbutton.Click
Checking:
        If CheckBox1.Checked = True Then
            'If EULA is Agreed to:
            If pathtext.TextLength = 0 Then
                MessageBox.Show("You have not selected a folder. Pleases select one before continuing")
            Else
                Dim result As Integer = MessageBox.Show("Are you sure you want to continue?", "Are you sure?", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    Me.Show()
                ElseIf result = DialogResult.Yes Then
                    MessageBox.Show("Installing... you will be notified when installation is completed")
                    'Working Begins
                    GoTo Installing
                    'here is the working code under the label "Installing:" which makes the "goto installing" jump to here.
                    'This was later moved up here due to an error about the code trying to run prematurely.
                    'The GoTo is now useless (it's just here cos why not?)
Installing:
                    installbutton.Text = "Installation in Progress"
                    installbutton.Enabled = False
                    Dim sb As StringBuilder = New StringBuilder()
                    Dim sb2 As StringBuilder = New StringBuilder()
                    Dim sb3 As StringBuilder = New StringBuilder()
                    path = pathtext.Text
                    My.Settings.installdirectory = path.ToString
                    My.Settings.Save()
                    ip = iptext.Text
                    portno = port.Value
                    motd = message.Text
                    WG = worldgen.Text
                    currentdate = DateTime.Now
                    installdate = "#Server installed: " & currentdate
                    installdate = installdate & " Local Time using Tfff1's Server Installer"
                    oplevel = oppermlevel.Value
                    netherq = nether.CheckState
                    flightq = flight.CheckState
                    worldseed = seed.Text
                    maxplayer = MaxPlayers.Value
                    viewdist = viewdistance.Value

                    If Not Directory.Exists(path) Then
                        Directory.CreateDirectory(path)
                    End If

                    If nether.CheckState = CheckState.Checked Then
                        netherq = "True"
                    Else
                        netherq = "False"
                    End If

                    If flight.CheckState = CheckState.Checked Then
                        flightq = "True"
                    Else
                        flightq = "False"
                    End If

                    If playerachievements.CheckState = CheckState.Checked Then
                        pa = "True"
                    Else
                        pa = "False"
                    End If

                    If forcegm.CheckState = CheckState.Checked Then
                        forcegmq = "True"
                    Else
                        forcegmq = "False"
                    End If

                    If npcs.CheckState = CheckState.Checked Then
                        npcsq = "True"
                    Else
                        npcsq = "False"

                    End If

                    If animals.CheckState = CheckState.Checked Then
                        animalsq = "True"
                    Else
                        animalsq = "False"
                    End If

                    If hardcore.CheckState = CheckState.Checked Then
                        hardcoreq = "True"
                    Else
                        hardcoreq = "False"

                    End If

                    If snooper.CheckState = CheckState.Checked Then
                        snooperq = "True"
                    Else
                        snooperq = "False"
                    End If

                    If online.CheckState = CheckState.Checked Then
                        onlineq = "True"
                    Else
                        onlineq = "False"
                    End If

                    If pvp.CheckState = CheckState.Checked Then
                        pvpq = "True"
                    Else
                        pvpq = "False"
                    End If

                    If Peaceful.Checked Then
                        difficulty = "0"
                    ElseIf Easy.Checked Then
                        difficulty = "1"
                    ElseIf Normal.Checked Then
                        difficulty = "2"
                    ElseIf Hard.Checked Then
                        difficulty = "3"
                    End If

                    If commandblocks.CheckState = CheckState.Checked Then
                        cbq = "true"
                    Else
                        cbq = "false"
                    End If

                    If Adventure.Checked Then
                        gamemode = "2"
                    ElseIf Survival.Checked Then
                        gamemode = "0"
                    ElseIf Creative.Checked Then
                        gamemode = "1"

                    End If

                    If monsters.CheckState = CheckState.Checked Then
                        monstersq = "true"
                    Else
                        monstersq = "false"
                    End If

                    If structures.CheckState = CheckState.Checked Then
                        structuresq = "true"
                    Else
                        structuresq = "false"
                    End If

                    File.Create(path & "\server.properties").Dispose()
                    sb.AppendLine("#Minecraft server properties")
                    sb.AppendLine(installdate)
                    sb.AppendLine("generator-settings=")
                    sb.AppendLine("op-permission-level=" & oplevel)
                    sb.AppendLine("allow-nether=" & netherq)
                    sb.AppendLine("level-name=world")
                    sb.AppendLine("enable-query=False")
                    sb.AppendLine("allow-flight=" & flightq)
                    sb.AppendLine("announce-player-achievements=" & pa)
                    sb.AppendLine("server-port=" & portno)
                    sb.AppendLine("level-type=" & WG)
                    sb.AppendLine("enable-rcon=False")
                    sb.AppendLine("level-seed=" & worldseed)
                    sb.AppendLine("force-gamemode=" & forcegmq)
                    sb.AppendLine("server-ip=" & ip)
                    sb.AppendLine("max-build-height=" & "256")
                    sb.AppendLine("spawn-npcs=" & npcsq)
                    sb.AppendLine("white-list=False")
                    sb.AppendLine("spawn-animals=" & animalsq)
                    sb.AppendLine("hardcore=" & hardcoreq)
                    sb.AppendLine("snooper-enabled=" & snooperq)
                    sb.AppendLine("online-mode=" & onlineq)
                    sb.AppendLine("resource-pack=")
                    sb.AppendLine("pvp=" & pvpq)
                    sb.AppendLine("difficulty=" & difficulty)
                    sb.AppendLine("enable-command-block=" & cbq)
                    sb.AppendLine("gamemode=" & gamemode)
                    sb.AppendLine("player-idle-timeout=0")
                    sb.AppendLine("max-players=" & maxplayer)
                    sb.AppendLine("spawn-monsters=" & monstersq)
                    sb.AppendLine("generate-structures=" & structuresq)
                    sb.AppendLine("view-distance=" & viewdist)
                    sb.AppendLine("motd=" & motd)

                    Using outfile As StreamWriter = New StreamWriter(path + "\server.properties", True)
                        Await outfile.WriteAsync(sb.ToString())
                    End Using



                    File.Create(path & "\eula.txt").Dispose()
                    sb2.AppendLine("#By changing the setting below to TRUE you are indicating your agreement to our EULA (https://account.mojang.com/documents/minecraft_eula).")
                    sb2.AppendLine("#" & currentdate)
                    sb2.AppendLine("eula=true")

                    Using outeula As StreamWriter = New StreamWriter(path + "\eula.txt", True)
                        Await outeula.WriteAsync(sb2.ToString())
                    End Using

                    Directory.CreateDirectory(path + "\plugins")

                    statuslabel.Text = "Creating start file..."
                    sb3.AppendLine("@echo off")
                    sb3.AppendLine("TITLE Spigot Server")
                    sb3.AppendLine("echo THIS FILE HAS BEEN GENERATED BY TFFF1'S FORGE SERVER INSTALLER:")
                    sb3.AppendLine("echo Check out the website: ")
                    sb3.AppendLine("echo http://www.minecraft-mod-installer.weebly.com")
                    sb3.AppendLine("echo [INFO] starting server...")
                    sb3.AppendLine("java -Xms" + Rammb.Value.ToString + "M -Xmx" + Rammb.Value.ToString + "M -jar spigot_server.jar")
                    sb3.AppendLine("echo [INFO] server has either Stopped or Crashed.")
                    sb3.AppendLine("echo [TIP] If the server has crashed, try removing plugins one at a time in order to find which one is causing the error!")
                    sb3.AppendLine("pause")

                    Using outstart As StreamWriter = New StreamWriter(path + "\start.cmd", True)
                        Await outstart.WriteAsync(sb3.ToString())
                    End Using

                    'check if a mod folder has been selected. If so copy it's contents to mods folder in server.
                    If pathtext2.TextLength > 0 Then
                        My.Computer.FileSystem.CopyDirectory(pathtext2.Text, path + "\plugins")
                    End If

                    If bukkitgui.Checked = True Then
                        statuslabel.Text = "Downloading Bukkit GUI from Official Website"
                        My.Computer.Network.DownloadFile("http://addons-origin.cursecdn.com/files/880/722/BukkitGUI.exe", path + "\BukkitGUI.exe")
                    End If

                    statuslabel.Text = "Current Status: Downloading spigot_server.jar"
                    Dim client As WebClient = New WebClient
                    AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
                    AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
                    If v18.Checked = True Then
                        client.DownloadFileAsync(New Uri("http://getspigot.org/spigot18/spigot_server.jar"), path + "\spigot_server.jar")
                    ElseIf v175.Checked = True Then
                        client.DownloadFileAsync(New Uri("http://getspigot.org/spigot/spigot-1.7.5-R0.1-SNAPSHOT-1387.jar"), path + "\spigot_server.jar")
                    ElseIf v179.Checked = True Then
                        client.DownloadFileAsync(New Uri("http://getspigot.org/spigot/spigot-1.7.9-R0.3-SNAPSHOTBuild1543.jar"), path + "\spigot_server.jar")
                    ElseIf v1710.Checked = True Then
                        client.DownloadFileAsync(New Uri("http://getspigot.org/spigot/spigot-1.7.10-R0.1-SNAPSHOTBuild1646.jar"), path + "\spigot_server.jar")
                    End If


                Else
                    MessageBox.Show("To continue with installation you must have read and agreed to the Minecraft EULA")

                End If
            End If
        End If





    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        ProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        statuslabel.Text = "Installation Complete!"
        ProgressBar1.Value = 100
        Me.Hide()
        done.Show()
        Me.Close()
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Setup Cancelled")
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles iptext.TextChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Computer.Network.IsAvailable Then
            MsgBox("Server installation requires an internet connection. Please try again when you have one")
            Close()
        End If

        iptext.Text = "Enter your server's ip address"
        WebBrowser1.Navigate("https://account.mojang.com/documents/minecraft_eula")
        worldgen.Text = "DEFAULT"
        MaxPlayers.Value = "20"
        viewdistance.Value = "10"
        message.Text = "A Minecraft Server"
        oppermlevel.Value = "4"
        port.Value = "25565"
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        WebBrowser1.Navigate("https://account.mojang.com/documents/minecraft_eula")
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As MouseEventArgs) Handles worldgen.MouseDown
        Dim result As Integer = MessageBox.Show("DO NOT CHANGE THIS UNLESS YOU KNOW WHAT YOUR DOING. Do you still wish to continue?", "Are you Sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("Reverting to DEFAULT")
            worldgen.Text = "DEFAULT"
        ElseIf result = DialogResult.Yes Then

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        worldgen.Text = "DEFAULT"
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles oppermlevel.ValueChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        port.Value = "25565"
    End Sub

    Private Sub TextBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles iptext.MouseDown
        iptext.SelectAll()
    End Sub

    Private Sub Rammb_ValueChanged(sender As Object, e As EventArgs) Handles Rammb.ValueChanged
        If Rammb.Value < 2000 Then
            MsgBox("Ram allocation values under 1000 are not recommended. Reverting to 2000...")
            Rammb.Value = 2000
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If (FolderBrowserDialog2.ShowDialog() = DialogResult.OK) Then
            pathtext2.Text = FolderBrowserDialog2.SelectedPath
        End If
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If v18.Checked = True Then
        '    clearlagg.Enabled = False
        '    worldedit.Enabled = True
        '    plugman.Enabled = True
        '    essentials.Enabled = True
        '    multiverse.Enabled = True
        'ElseIf v172.Checked = True
        '    multiverse.Enabled = True
        '    essentials.Enabled = True
        '    bukkitgui.Enabled = True
        '    plugman.Enabled = True
        '    worldedit.Enabled = True
        '    clearlagg.Enabled = True

        'End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form1.Show()
        Me.Close()
    End Sub
End Class