Imports System.IO
Imports System.Net
Imports System.Text
'Imports System.IO.Compression
Public Class Edit
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
    Public jarTitle As String
    Private Async Sub installbutton_Click(sender As Object, e As EventArgs) Handles installbutton.Click
Checking:
        If CheckBox1.Checked = True Then
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

                If Forge.Checked = True Then
                    Directory.CreateDirectory(path & "\mods")
                ElseIf Spigot.Checked = True Then
                    Directory.CreateDirectory(path + "\plugins")
                ElseIf Vanilla.Checked = True Then
                End If

                If Forge.Checked = True Then
                    jarTitle = "Forge_Server"
                ElseIf Spigot.Checked = True Then
                    jarTitle = "Spigot_Server"
                ElseIf Vanilla.Checked = True Then
                    jarTitle = "Vanilla_Server"
                End If

                statuslabel.Text = "Creating start file..."
                sb3.AppendLine("@echo off")
                sb3.AppendLine("TITLE Forge Server")
                sb3.AppendLine("echo THIS FILE HAS BEEN GENERATED BY TFFF1'S FORGE SERVER INSTALLER:")
                sb3.AppendLine("echo Check out the website: ")
                sb3.AppendLine("echo http://www.minecraft-mod-installer.weebly.com")
                sb3.AppendLine("echo starting server...")
                sb3.AppendLine("java -Xms" + Rammb.Value.ToString + "M -Xmx" + Rammb.Value.ToString + "M -jar " + jarTitle + ".jar")
                sb3.AppendLine("echo server has either stopped or crashed.")
                sb3.AppendLine("pause")

                Using outstart As StreamWriter = New StreamWriter(path + "\start.cmd", True)
                    Await outstart.WriteAsync(sb3.ToString())
                End Using

                'check if a mod folder has been selected. If so copy it's contents to mods folder in server.
                If pathtext2.TextLength > 0 Then
                    If Forge.Checked = True Then
                        My.Computer.FileSystem.CopyDirectory(pathtext2.Text, path + "\mods")
                    ElseIf Spigot.checked = True Then
                        My.Computer.FileSystem.CopyDirectory(pathtext2.Text, path + "\plugins")
                    End If
                Else
                    MessageBox.Show("To continue with installation you must have read and agreed to the Minecraft EULA")
                End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Vanilla.Checked = True Then
            Button2.Enabled = False
            pathtext2.Enabled = False
            Label14.Enabled = False
        ElseIf Forge.Checked = True Or Spigot.Checked = True Then
            Button2.Enabled = True
            pathtext2.Enabled = True
            Label14.Enabled = True
        End If

        If Forge.Checked = True Then
            Label14.Text = "If you have a folder full of mods you want to add to your server then choose it here:"
        ElseIf Spigot.Checked = True Then
            Label14.Text = "If you have a folder full of plugins you want to add to your server then choose it here:"
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Setup Cancelled")
        Close()
    End Sub

    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        path = My.Settings.path
        Label1.Text = "Selected Server: " + path
        Using sr As New StringReader(My.Settings.path + "\server.properties")
            Dim currentline As String
            Dim lineCount As Integer = File.ReadAllLines(path + "\server.properties").Length
scan:
            currentline = sr.ReadLine()
            If currentline.Contains("#") Then
                lineCount = lineCount - 1
                GoTo scan
            End If

        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Hide()
        Select_Folder.Show()
        Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Process.Start("https://github.com/tfff1OFFICIAL/tfff1s-Forge-Server-Installer/wiki/Local-IP-Address-%28IPv4%29")
    End Sub
End Class