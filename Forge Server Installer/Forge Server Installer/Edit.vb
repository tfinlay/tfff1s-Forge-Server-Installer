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
        If Not CheckBox1.Checked = True Then
            MsgBox("You must have read and agreed to the Minecraft EULA Before Continuing")
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
                installdate = "#Server installed: " + currentdate.ToString() + " Local Time using Tfff1's Server Installer"
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
                sb.AppendLine("generator-settings=" & WG)
                sb.AppendLine("op-permission-level=" & oplevel)
                sb.AppendLine("allow-nether=" & netherq)
                sb.AppendLine("level-name=world")
                sb.AppendLine("enable-query=False")
                sb.AppendLine("allow-flight=" & flightq)
                sb.AppendLine("announce-player-achievements=" & pa)
                sb.AppendLine("server-port=" & portno)
                sb.AppendLine("level-type=" & levelType.SelectedText.ToString())
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
                sb.AppendLine("resource-pack=" & resourcePack.Text.ToString())
                sb.AppendLine("resource-pack-sha1=" & resourceSHA1.Text.ToString())
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

                Using outfile As StreamWriter = New StreamWriter(path + "\server.properties", False)
                    Await outfile.WriteAsync(sb.ToString())
                End Using



                File.Create(path & "\eula.txt").Dispose()
                sb2.AppendLine("#By changing the setting below to TRUE you are indicating your agreement to our EULA (https://account.mojang.com/documents/minecraft_eula).")
                sb2.AppendLine("#" & currentdate)
                sb2.AppendLine("eula=true")

                Using outeula As StreamWriter = New StreamWriter(path + "\eula.txt", False)
                    Await outeula.WriteAsync(sb2.ToString())
                End Using

                If Forge.Checked = True Then
                    Directory.CreateDirectory(path & "\mods")
                ElseIf Spigot.Checked = True Then
                    Directory.CreateDirectory(path + "\plugins")
                ElseIf Vanilla.Checked = True Then
                End If

                If Forge.Checked = True Then
                    Using sr As StreamReader = New StreamReader(path + "\start.cmd")
Read:
                        Dim currentLine = sr.ReadLine()
                        If currentLine.Contains("java -Xms") Then
                            Dim split = currentLine.Split(" "c)
                            jarTitle = split(4)
                        Else
                            GoTo Read
                        End If
                    End Using
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
                sb3.AppendLine("java -Xms" + Rammb.Value.ToString + "M -Xmx" + Rammb.Value.ToString + "M -jar " + jarTitle)
                sb3.AppendLine("echo server has either stopped or crashed.")
                sb3.AppendLine("pause")

                Using outstart As StreamWriter = New StreamWriter(path + "\start.cmd", False)
                    Await outstart.WriteAsync(sb3.ToString())
                End Using

                'check if a mod folder has been selected. If so copy it's contents to mods folder in server.
                Try
                    If pathtext2.TextLength > 0 Then
                        If Forge.Checked = True Then
                            My.Computer.FileSystem.CopyDirectory(pathtext2.Text, path + "\mods")
                        ElseIf Spigot.checked = True Then
                            My.Computer.FileSystem.CopyDirectory(pathtext2.Text, path + "\plugins")
                        End If
                    Else
                        'MessageBox.Show("To continue with installation you must have read and agreed to the Minecraft EULA")
                    End If
                Catch
                    MsgBox("An Error Ocurred when copying your mods/plugins folder.")
                End Try
            End If
            Hide()
            My.Settings.installdirectory = My.Settings.path
            My.Settings.doneSender = "edit"
            My.Settings.Save()
            done.Show()
            Close()
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
        Call LoadManager()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Hide()
        Select_Folder.Show()
        Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Process.Start("https://github.com/tfff1OFFICIAL/tfff1s-Forge-Server-Installer/wiki/Local-IP-Address-%28IPv4%29")
    End Sub

    Public Sub LoadManager()
        'Load IP Address:
        Dim tmpHostName As String = System.Net.Dns.GetHostName()
        Dim myIPaddress = Dns.GetHostByName(tmpHostName).AddressList(0).ToString()

        IPv4.Text = "Your Local Network IP is: " + myIPaddress

        'Get Server Properties:
        path = My.Settings.path
        Label1.Text = "Selected Server: " + path
        Dim currentline As String
        Try
            Dim linecount As Integer = File.ReadAllLines(path + "\server.properties").Count
            Using sr As StreamReader = File.OpenText(path + "\server.properties")
Scan:
                If Not linecount > 0 Then
                    GoTo FinishedRead
                    MsgBox("Finished Scanning server.properties")
                End If
                'Read The Next Line:
                currentline = sr.ReadLine.ToString
                'Check if it's commented:
                If currentline.ToString.Contains("#") Then
                    linecount = linecount - 1
                    'MsgBox("Contains #")
                    GoTo Scan
                End If

                'Start Looking for information:
                'MsgBox("No # in this line: " + currentline)
                If currentline.Contains("generator-settings=") Then
                    'look for: generator-settings=
                    worldgen.Text = currentline.Remove(0, 19)
                    GoTo FinishedLine
                ElseIf currentline.Contains("op-permission-level=") Then
                    oppermlevel.Value = currentline.Remove(0, 20)
                    GoTo FinishedLine
                ElseIf currentline.Contains("allow-nether=") Then
                    nether.Checked = currentline.Remove(0, 13)
                    GoTo FinishedLine
                ElseIf currentline.Contains("level-name=") Then
                    GoTo FinishedLine
                ElseIf currentline.Contains("enable-query=") Then
                    GoTo FinishedLine
                ElseIf currentline.Contains("allow-flight=") Then
                    flight.Checked = currentline.Remove(0, 13)
                    GoTo FinishedLine
                ElseIf currentline.Contains("announce-player-achievements=") Then
                    playerachievements.Checked = currentline.Remove(0, 29)
                    GoTo FinishedLine
                ElseIf currentline.Contains("server-port=") Then
                    port.Value = currentline.Remove(0, 12)
                    GoTo FinishedLine
                ElseIf currentline.Contains("max-world-size=") Then
                    GoTo FinishedLine
                ElseIf currentline.Contains("level-type=") Then
                    ' Find the string in ListBox2.
                    Dim index As Integer = levelType.FindString(currentline.Remove(0, 11))
                    ' If the item was not found in ListBox 2 display a message box, otherwise select it in ListBox2.
                    If index = -1 Then
                        MessageBox.Show("Item: " + currentline.Remove(0, 11).ToString() + " isn't a valid Level Type.")
                    Else
                        levelType.SelectedIndex = index
                    End If
                    GoTo FinishedLine
                ElseIf currentline.Contains("enable-rcon=") Then
                    GoTo FinishedLine
                ElseIf currentline.Contains("force-gamemode=") Then
                    forcegm.Checked = currentline.Remove(0, 15)
                    GoTo FinishedLine
                ElseIf currentline.Contains("level-seed=") Then
                    seed.Text = currentline.Remove(0, 11)
                    GoTo FinishedLine
                ElseIf currentline.Contains("server-ip=") Then
                    iptext.Text = currentline.Remove(0, 10)
                    GoTo FinishedLine
                ElseIf currentline.Contains("network-compression-threshold=") Then
                    GoTo FinishedLine
                ElseIf currentline.Contains("max-build-height=") Then
                    GoTo FinishedLine
                ElseIf currentline.Contains("spawn-npcs=") Then
                    npcs.Checked = currentline.Remove(0, 11)
                    GoTo FinishedLine
                ElseIf currentline.Contains("white-list=") Then
                    GoTo FinishedLine
                ElseIf currentline.Contains("spawn-animals=") Then
                    animals.Checked = currentline.Remove(0, 14)
                    GoTo FinishedLine
                ElseIf currentline.Contains("snooper-enabled=") Then
                    snooper.Checked = currentline.Remove(0, 16)
                    GoTo FinishedLine
                ElseIf currentline.Contains("hardcore=") Then
                    hardcore.Checked = currentline.Remove(0, 9)
                    GoTo FinishedLine
                ElseIf currentline.Contains("online-mode=") Then
                    online.Checked = currentline.Remove(0, 12)
                    GoTo FinishedLine
                ElseIf currentline.Contains("pvp=") Then
                    pvp.Checked = currentline.Remove(0, 4)
                    GoTo FinishedLine
                ElseIf currentline.Contains("difficulty=") Then
                    If currentline.Contains("0") Then
                        Peaceful.Checked = True
                    ElseIf currentline.Contains("1") Then
                        Easy.Checked = True
                    ElseIf currentline.Contains("2") Then
                        Normal.Checked = True
                    ElseIf currentline.Contains("3") Then
                        Hard.Checked = True
                    Else
                        MsgBox("Failed to find valid difficulty value. Setting to default")
                        Easy.Checked = True
                    End If
                    GoTo FinishedLine
                ElseIf currentline.Contains("enable-command-block=") Then
                    commandblocks.Checked = currentline.Remove(0, 21)
                    GoTo FinishedLine
                ElseIf currentline.Contains("player-idle-timeout=") Then
                    GoTo FinishedLine
                ElseIf currentline.Contains("gamemode=") Then
                    If currentline.Contains("2") Then
                        Adventure.Checked = True
                    ElseIf currentline.Contains("0") Then
                        Survival.Checked = True
                    ElseIf currentline.Contains("1") Then
                        Creative.Checked = True
                    ElseIf currentline.Contains("3") Then
                        MsgBox("Spectator gamemode is not yet supported in tfff1's Server Installer. Will revert to survival.")
                        Survival.Checked = True
                    Else
                        MsgBox("Unrecognised value for gamemode. Reverting to survival")
                        Survival.Checked = True
                    End If
                    GoTo FinishedLine
                ElseIf currentline.Contains("max-players=") Then
                    MaxPlayers.Value = currentline.Remove(0, 12)
                    GoTo FinishedLine
                ElseIf currentline.Contains("spawn-monsters=") Then
                    monsters.Checked = currentline.Remove(0, 15)
                    GoTo FinishedLine
                ElseIf currentline.Contains("view-distance=") Then
                    viewdistance.Value = currentline.Remove(0, 14)
                    GoTo FinishedLine
                ElseIf currentline.Contains("generate-structures=") Then
                    structures.Checked = currentline.Remove(0, 20)
                    GoTo FinishedLine
                ElseIf currentline.Contains("motd=") Then
                    message.Text = currentline.Remove(0, 5)
                    GoTo FinishedLine
                ElseIf currentline.Contains("resource-pack-sha1=") Then
                    resourceSHA1.Text = currentline.Remove(0, 19)
                    GoTo FinishedLine
                ElseIf currentline.Contains("resource-pack=") Then
                    resourcePack.Text = currentline.Remove(0, 14)
                    GoTo FinishedLine
                Else
                    MsgBox("This line (" + currentline.ToString + ") contains an unrecognised string")
                    GoTo FinishedLine
                End If
FinishedLine:
                linecount = linecount - 1
                GoTo Scan
            End Using
        Catch
            MsgBox("An Error Ocurred when reading server.properties")
        End Try

FinishedRead:
        MsgBox("Finished Reading from server.properties")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        port.Value = 25565
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (FolderBrowserDialog2.ShowDialog() = DialogResult.OK) Then
            pathtext2.Text = FolderBrowserDialog2.SelectedPath
        End If
    End Sub

    Private Sub levelType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles levelType.SelectedIndexChanged
        If levelType.SelectedIndex = 4 Then
            worldgen.Enabled = True
        Else
            worldgen.Enabled = False
            worldgen.Text = ""
        End If
    End Sub

    Private Sub IPv4_Click(sender As Object, e As EventArgs) Handles IPv4.Click
        Dim tmpHostName As String = Dns.GetHostName()
        Dim myIPaddress = Dns.GetHostByName(tmpHostName).AddressList(0).ToString()
        iptext.Text = myIPaddress
    End Sub
End Class