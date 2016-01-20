<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.browsebutton = New System.Windows.Forms.Button()
        Me.pathtext = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.installbutton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.iptext = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.message = New System.Windows.Forms.TextBox()
        Me.worldgen = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.playerachievements = New System.Windows.Forms.CheckBox()
        Me.hardcore = New System.Windows.Forms.CheckBox()
        Me.animals = New System.Windows.Forms.CheckBox()
        Me.npcs = New System.Windows.Forms.CheckBox()
        Me.forcegm = New System.Windows.Forms.CheckBox()
        Me.online = New System.Windows.Forms.CheckBox()
        Me.snooper = New System.Windows.Forms.CheckBox()
        Me.monsters = New System.Windows.Forms.CheckBox()
        Me.commandblocks = New System.Windows.Forms.CheckBox()
        Me.pvp = New System.Windows.Forms.CheckBox()
        Me.structures = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MaxPlayers = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.viewdistance = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.oppermlevel = New System.Windows.Forms.NumericUpDown()
        Me.Peaceful = New System.Windows.Forms.RadioButton()
        Me.Hard = New System.Windows.Forms.RadioButton()
        Me.Normal = New System.Windows.Forms.RadioButton()
        Me.Easy = New System.Windows.Forms.RadioButton()
        Me.port = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.nether = New System.Windows.Forms.CheckBox()
        Me.flight = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.seed = New System.Windows.Forms.TextBox()
        Me.Creative = New System.Windows.Forms.RadioButton()
        Me.Adventure = New System.Windows.Forms.RadioButton()
        Me.Survival = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.statuslabel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Rammb = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.v152 = New System.Windows.Forms.RadioButton()
        Me.v162 = New System.Windows.Forms.RadioButton()
        Me.v164 = New System.Windows.Forms.RadioButton()
        Me.v188 = New System.Windows.Forms.RadioButton()
        Me.v172 = New System.Windows.Forms.RadioButton()
        Me.v1710 = New System.Windows.Forms.RadioButton()
        Me.v18 = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pathtext2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.IPv4 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.MaxPlayers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewdistance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oppermlevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.port, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Rammb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(204, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Where would you like your server installed?"
        '
        'browsebutton
        '
        Me.browsebutton.Location = New System.Drawing.Point(492, 128)
        Me.browsebutton.Name = "browsebutton"
        Me.browsebutton.Size = New System.Drawing.Size(75, 23)
        Me.browsebutton.TabIndex = 1
        Me.browsebutton.Text = "Browse"
        Me.browsebutton.UseVisualStyleBackColor = True
        '
        'pathtext
        '
        Me.pathtext.Enabled = False
        Me.pathtext.Location = New System.Drawing.Point(48, 130)
        Me.pathtext.Name = "pathtext"
        Me.pathtext.Size = New System.Drawing.Size(438, 20)
        Me.pathtext.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(913, 640)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'installbutton
        '
        Me.installbutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.installbutton.Location = New System.Drawing.Point(749, 640)
        Me.installbutton.Name = "installbutton"
        Me.installbutton.Size = New System.Drawing.Size(155, 23)
        Me.installbutton.TabIndex = 4
        Me.installbutton.Text = "Install >"
        Me.installbutton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(234, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Server ip:"
        '
        'iptext
        '
        Me.iptext.Location = New System.Drawing.Point(157, 169)
        Me.iptext.Name = "iptext"
        Me.iptext.Size = New System.Drawing.Size(194, 20)
        Me.iptext.TabIndex = 6
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CheckBox1.Location = New System.Drawing.Point(749, 613)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(239, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "I have read and agree to the Minecraft EULA"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(604, 12)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(496, 595)
        Me.WebBrowser1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(204, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Server Message Of The Day / Description"
        '
        'message
        '
        Me.message.Location = New System.Drawing.Point(48, 237)
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(519, 20)
        Me.message.TabIndex = 10
        '
        'worldgen
        '
        Me.worldgen.Location = New System.Drawing.Point(52, 293)
        Me.worldgen.Name = "worldgen"
        Me.worldgen.Size = New System.Drawing.Size(194, 20)
        Me.worldgen.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(290, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "World Gen Settings (leave alone if you don't know what it is)"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(252, 293)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(55, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Default"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'playerachievements
        '
        Me.playerachievements.AutoSize = True
        Me.playerachievements.Checked = True
        Me.playerachievements.CheckState = System.Windows.Forms.CheckState.Checked
        Me.playerachievements.Location = New System.Drawing.Point(49, 379)
        Me.playerachievements.Name = "playerachievements"
        Me.playerachievements.Size = New System.Drawing.Size(171, 17)
        Me.playerachievements.TabIndex = 14
        Me.playerachievements.Text = "Announce Player Achivements"
        Me.playerachievements.UseVisualStyleBackColor = True
        '
        'hardcore
        '
        Me.hardcore.AutoSize = True
        Me.hardcore.Location = New System.Drawing.Point(49, 471)
        Me.hardcore.Name = "hardcore"
        Me.hardcore.Size = New System.Drawing.Size(70, 17)
        Me.hardcore.TabIndex = 15
        Me.hardcore.Text = "Hardcore"
        Me.hardcore.UseVisualStyleBackColor = True
        '
        'animals
        '
        Me.animals.AutoSize = True
        Me.animals.Checked = True
        Me.animals.CheckState = System.Windows.Forms.CheckState.Checked
        Me.animals.Location = New System.Drawing.Point(49, 448)
        Me.animals.Name = "animals"
        Me.animals.Size = New System.Drawing.Size(98, 17)
        Me.animals.TabIndex = 16
        Me.animals.Text = "Spawn Animals"
        Me.animals.UseVisualStyleBackColor = True
        '
        'npcs
        '
        Me.npcs.AutoSize = True
        Me.npcs.Checked = True
        Me.npcs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.npcs.Location = New System.Drawing.Point(49, 425)
        Me.npcs.Name = "npcs"
        Me.npcs.Size = New System.Drawing.Size(156, 17)
        Me.npcs.TabIndex = 17
        Me.npcs.Text = "Spawn npc's (Villagers etc.)"
        Me.npcs.UseVisualStyleBackColor = True
        '
        'forcegm
        '
        Me.forcegm.AutoSize = True
        Me.forcegm.Location = New System.Drawing.Point(49, 402)
        Me.forcegm.Name = "forcegm"
        Me.forcegm.Size = New System.Drawing.Size(110, 17)
        Me.forcegm.TabIndex = 18
        Me.forcegm.Text = "Force Gamemode"
        Me.forcegm.UseVisualStyleBackColor = True
        '
        'online
        '
        Me.online.AutoSize = True
        Me.online.Checked = True
        Me.online.CheckState = System.Windows.Forms.CheckState.Checked
        Me.online.Location = New System.Drawing.Point(261, 402)
        Me.online.Name = "online"
        Me.online.Size = New System.Drawing.Size(86, 17)
        Me.online.TabIndex = 19
        Me.online.Text = "Online Mode"
        Me.online.UseVisualStyleBackColor = True
        '
        'snooper
        '
        Me.snooper.AutoSize = True
        Me.snooper.Checked = True
        Me.snooper.CheckState = System.Windows.Forms.CheckState.Checked
        Me.snooper.Location = New System.Drawing.Point(261, 379)
        Me.snooper.Name = "snooper"
        Me.snooper.Size = New System.Drawing.Size(108, 17)
        Me.snooper.TabIndex = 20
        Me.snooper.Text = "Snooper Enabled"
        Me.snooper.UseVisualStyleBackColor = True
        '
        'monsters
        '
        Me.monsters.AutoSize = True
        Me.monsters.Checked = True
        Me.monsters.CheckState = System.Windows.Forms.CheckState.Checked
        Me.monsters.Location = New System.Drawing.Point(261, 471)
        Me.monsters.Name = "monsters"
        Me.monsters.Size = New System.Drawing.Size(175, 17)
        Me.monsters.TabIndex = 21
        Me.monsters.Text = "Spawn Monsters (Zombies etc.)"
        Me.monsters.UseVisualStyleBackColor = True
        '
        'commandblocks
        '
        Me.commandblocks.AutoSize = True
        Me.commandblocks.Location = New System.Drawing.Point(261, 448)
        Me.commandblocks.Name = "commandblocks"
        Me.commandblocks.Size = New System.Drawing.Size(144, 17)
        Me.commandblocks.TabIndex = 22
        Me.commandblocks.Text = "Enable Command Blocks"
        Me.commandblocks.UseVisualStyleBackColor = True
        '
        'pvp
        '
        Me.pvp.AutoSize = True
        Me.pvp.Checked = True
        Me.pvp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.pvp.Location = New System.Drawing.Point(261, 425)
        Me.pvp.Name = "pvp"
        Me.pvp.Size = New System.Drawing.Size(46, 17)
        Me.pvp.TabIndex = 23
        Me.pvp.Text = "PvP"
        Me.pvp.UseVisualStyleBackColor = True
        '
        'structures
        '
        Me.structures.AutoSize = True
        Me.structures.Checked = True
        Me.structures.CheckState = System.Windows.Forms.CheckState.Checked
        Me.structures.Location = New System.Drawing.Point(447, 379)
        Me.structures.Name = "structures"
        Me.structures.Size = New System.Drawing.Size(121, 17)
        Me.structures.TabIndex = 24
        Me.structures.Text = "Generate Structures"
        Me.structures.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(444, 406)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Max Players:"
        '
        'MaxPlayers
        '
        Me.MaxPlayers.Location = New System.Drawing.Point(518, 402)
        Me.MaxPlayers.Maximum = New Decimal(New Integer() {1569325056, 23283064, 0, 0})
        Me.MaxPlayers.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MaxPlayers.Name = "MaxPlayers"
        Me.MaxPlayers.Size = New System.Drawing.Size(50, 20)
        Me.MaxPlayers.TabIndex = 26
        Me.MaxPlayers.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(433, 426)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "View Distance:"
        '
        'viewdistance
        '
        Me.viewdistance.Location = New System.Drawing.Point(518, 424)
        Me.viewdistance.Name = "viewdistance"
        Me.viewdistance.Size = New System.Drawing.Size(50, 20)
        Me.viewdistance.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(279, 501)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Difficulty"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(411, 448)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Op Permission Level:"
        '
        'oppermlevel
        '
        Me.oppermlevel.Location = New System.Drawing.Point(518, 446)
        Me.oppermlevel.Name = "oppermlevel"
        Me.oppermlevel.Size = New System.Drawing.Size(50, 20)
        Me.oppermlevel.TabIndex = 31
        '
        'Peaceful
        '
        Me.Peaceful.AutoSize = True
        Me.Peaceful.Location = New System.Drawing.Point(49, 523)
        Me.Peaceful.Name = "Peaceful"
        Me.Peaceful.Size = New System.Drawing.Size(82, 17)
        Me.Peaceful.TabIndex = 32
        Me.Peaceful.Text = "Peaceful (0)"
        Me.Peaceful.UseVisualStyleBackColor = True
        '
        'Hard
        '
        Me.Hard.AutoSize = True
        Me.Hard.Location = New System.Drawing.Point(478, 523)
        Me.Hard.Name = "Hard"
        Me.Hard.Size = New System.Drawing.Size(63, 17)
        Me.Hard.TabIndex = 34
        Me.Hard.Text = "Hard (3)"
        Me.Hard.UseVisualStyleBackColor = True
        '
        'Normal
        '
        Me.Normal.AutoSize = True
        Me.Normal.Location = New System.Drawing.Point(326, 523)
        Me.Normal.Name = "Normal"
        Me.Normal.Size = New System.Drawing.Size(73, 17)
        Me.Normal.TabIndex = 35
        Me.Normal.Text = "Normal (2)"
        Me.Normal.UseVisualStyleBackColor = True
        '
        'Easy
        '
        Me.Easy.AutoSize = True
        Me.Easy.Checked = True
        Me.Easy.Location = New System.Drawing.Point(184, 523)
        Me.Easy.Name = "Easy"
        Me.Easy.Size = New System.Drawing.Size(63, 17)
        Me.Easy.TabIndex = 36
        Me.Easy.TabStop = True
        Me.Easy.Text = "Easy (1)"
        Me.Easy.UseVisualStyleBackColor = True
        '
        'port
        '
        Me.port.Location = New System.Drawing.Point(392, 169)
        Me.port.Maximum = New Decimal(New Integer() {65534, 0, 0, 0})
        Me.port.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(94, 20)
        Me.port.TabIndex = 37
        Me.port.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(357, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Port:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(492, 167)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(55, 23)
        Me.Button4.TabIndex = 39
        Me.Button4.Text = "Default"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'nether
        '
        Me.nether.AutoSize = True
        Me.nether.Checked = True
        Me.nether.CheckState = System.Windows.Forms.CheckState.Checked
        Me.nether.Location = New System.Drawing.Point(447, 471)
        Me.nether.Name = "nether"
        Me.nether.Size = New System.Drawing.Size(84, 17)
        Me.nether.TabIndex = 40
        Me.nether.Text = "Allow nether"
        Me.nether.UseVisualStyleBackColor = True
        '
        'flight
        '
        Me.flight.AutoSize = True
        Me.flight.Location = New System.Drawing.Point(49, 495)
        Me.flight.Name = "flight"
        Me.flight.Size = New System.Drawing.Size(76, 17)
        Me.flight.TabIndex = 41
        Me.flight.Text = "Allow flight"
        Me.flight.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(411, 277)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "World Seed:"
        '
        'seed
        '
        Me.seed.Location = New System.Drawing.Point(358, 293)
        Me.seed.Name = "seed"
        Me.seed.Size = New System.Drawing.Size(194, 20)
        Me.seed.TabIndex = 43
        '
        'Creative
        '
        Me.Creative.AutoSize = True
        Me.Creative.Location = New System.Drawing.Point(435, 19)
        Me.Creative.Name = "Creative"
        Me.Creative.Size = New System.Drawing.Size(64, 17)
        Me.Creative.TabIndex = 46
        Me.Creative.Text = "Creative"
        Me.Creative.UseVisualStyleBackColor = True
        '
        'Adventure
        '
        Me.Adventure.AutoSize = True
        Me.Adventure.Location = New System.Drawing.Point(37, 19)
        Me.Adventure.Name = "Adventure"
        Me.Adventure.Size = New System.Drawing.Size(74, 17)
        Me.Adventure.TabIndex = 45
        Me.Adventure.Text = "Adventure"
        Me.Adventure.UseVisualStyleBackColor = True
        '
        'Survival
        '
        Me.Survival.AutoSize = True
        Me.Survival.Checked = True
        Me.Survival.Location = New System.Drawing.Point(215, 19)
        Me.Survival.Name = "Survival"
        Me.Survival.Size = New System.Drawing.Size(63, 17)
        Me.Survival.TabIndex = 47
        Me.Survival.TabStop = True
        Me.Survival.Text = "Survival"
        Me.Survival.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Survival)
        Me.GroupBox1.Controls.Add(Me.Adventure)
        Me.GroupBox1.Controls.Add(Me.Creative)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(48, 570)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 50)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(234, 554)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 13)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Select a Default Gamemode"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Enabled = False
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 673)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1112, 23)
        Me.ProgressBar1.TabIndex = 51
        '
        'statuslabel
        '
        Me.statuslabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.statuslabel.AutoSize = True
        Me.statuslabel.Location = New System.Drawing.Point(1, 657)
        Me.statuslabel.Name = "statuslabel"
        Me.statuslabel.Size = New System.Drawing.Size(125, 13)
        Me.statuslabel.TabIndex = 52
        Me.statuslabel.Text = "Current Status: Waiting..."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(162, 623)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 13)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Server RAM (Megabytes)"
        '
        'Rammb
        '
        Me.Rammb.Location = New System.Drawing.Point(295, 623)
        Me.Rammb.Maximum = New Decimal(New Integer() {16000, 0, 0, 0})
        Me.Rammb.Name = "Rammb"
        Me.Rammb.Size = New System.Drawing.Size(91, 20)
        Me.Rammb.TabIndex = 54
        Me.Rammb.Value = New Decimal(New Integer() {4000, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(181, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(304, 13)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Which Minecraft Version would you like your server to support?"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.v152)
        Me.GroupBox2.Controls.Add(Me.v162)
        Me.GroupBox2.Controls.Add(Me.v164)
        Me.GroupBox2.Controls.Add(Me.v188)
        Me.GroupBox2.Controls.Add(Me.v172)
        Me.GroupBox2.Controls.Add(Me.v1710)
        Me.GroupBox2.Controls.Add(Me.v18)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(586, 71)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(1, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 67)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'v152
        '
        Me.v152.AutoSize = True
        Me.v152.Location = New System.Drawing.Point(378, 19)
        Me.v152.Name = "v152"
        Me.v152.Size = New System.Drawing.Size(49, 17)
        Me.v152.TabIndex = 6
        Me.v152.Text = "1.5.2"
        Me.v152.UseVisualStyleBackColor = True
        '
        'v162
        '
        Me.v162.AutoSize = True
        Me.v162.Location = New System.Drawing.Point(344, 42)
        Me.v162.Name = "v162"
        Me.v162.Size = New System.Drawing.Size(49, 17)
        Me.v162.TabIndex = 5
        Me.v162.Text = "1.6.2"
        Me.v162.UseVisualStyleBackColor = True
        '
        'v164
        '
        Me.v164.AutoSize = True
        Me.v164.Location = New System.Drawing.Point(308, 19)
        Me.v164.Name = "v164"
        Me.v164.Size = New System.Drawing.Size(49, 17)
        Me.v164.TabIndex = 4
        Me.v164.Text = "1.6.4"
        Me.v164.UseVisualStyleBackColor = True
        '
        'v188
        '
        Me.v188.AutoSize = True
        Me.v188.Location = New System.Drawing.Point(172, 19)
        Me.v188.Name = "v188"
        Me.v188.Size = New System.Drawing.Size(49, 17)
        Me.v188.TabIndex = 3
        Me.v188.Text = "1.8.8"
        Me.v188.UseVisualStyleBackColor = True
        '
        'v172
        '
        Me.v172.AutoSize = True
        Me.v172.Location = New System.Drawing.Point(270, 42)
        Me.v172.Name = "v172"
        Me.v172.Size = New System.Drawing.Size(49, 17)
        Me.v172.TabIndex = 2
        Me.v172.Text = "1.7.2"
        Me.v172.UseVisualStyleBackColor = True
        '
        'v1710
        '
        Me.v1710.AutoSize = True
        Me.v1710.Checked = True
        Me.v1710.Location = New System.Drawing.Point(236, 19)
        Me.v1710.Name = "v1710"
        Me.v1710.Size = New System.Drawing.Size(55, 17)
        Me.v1710.TabIndex = 1
        Me.v1710.TabStop = True
        Me.v1710.Text = "1.7.10"
        Me.v1710.UseVisualStyleBackColor = True
        '
        'v18
        '
        Me.v18.AutoSize = True
        Me.v18.Location = New System.Drawing.Point(209, 42)
        Me.v18.Name = "v18"
        Me.v18.Size = New System.Drawing.Size(40, 17)
        Me.v18.TabIndex = 0
        Me.v18.Text = "1.8"
        Me.v18.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(114, 319)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(397, 13)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "If you have a folder full of mods you want to add to your server then choose it h" &
    "ere:"
        '
        'pathtext2
        '
        Me.pathtext2.Enabled = False
        Me.pathtext2.Location = New System.Drawing.Point(48, 336)
        Me.pathtext2.Name = "pathtext2"
        Me.pathtext2.Size = New System.Drawing.Size(438, 20)
        Me.pathtext2.TabIndex = 58
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(492, 334)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(4, 7)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 60
        Me.Button5.Text = "< Back"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'IPv4
        '
        Me.IPv4.AutoSize = True
        Me.IPv4.Location = New System.Drawing.Point(157, 196)
        Me.IPv4.Name = "IPv4"
        Me.IPv4.Size = New System.Drawing.Size(211, 13)
        Me.IPv4.TabIndex = 61
        Me.IPv4.Text = "Your Local Network IP is: 192.192.192.192"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(374, 191)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(111, 23)
        Me.Button6.TabIndex = 62
        Me.Button6.Text = "What is this?"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AcceptButton = Me.installbutton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1112, 696)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.IPv4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pathtext2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Rammb)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.statuslabel)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.seed)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.flight)
        Me.Controls.Add(Me.nether)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.port)
        Me.Controls.Add(Me.Easy)
        Me.Controls.Add(Me.Normal)
        Me.Controls.Add(Me.Hard)
        Me.Controls.Add(Me.Peaceful)
        Me.Controls.Add(Me.oppermlevel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.viewdistance)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MaxPlayers)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.structures)
        Me.Controls.Add(Me.pvp)
        Me.Controls.Add(Me.commandblocks)
        Me.Controls.Add(Me.monsters)
        Me.Controls.Add(Me.snooper)
        Me.Controls.Add(Me.online)
        Me.Controls.Add(Me.forcegm)
        Me.Controls.Add(Me.npcs)
        Me.Controls.Add(Me.animals)
        Me.Controls.Add(Me.hardcore)
        Me.Controls.Add(Me.playerachievements)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.worldgen)
        Me.Controls.Add(Me.message)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.iptext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.installbutton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pathtext)
        Me.Controls.Add(Me.browsebutton)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Minecraft Forge Server Installer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MaxPlayers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewdistance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oppermlevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.port, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Rammb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents browsebutton As Button
    Friend WithEvents pathtext As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents installbutton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents iptext As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Label3 As Label
    Friend WithEvents message As TextBox
    Friend WithEvents worldgen As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents playerachievements As CheckBox
    Friend WithEvents hardcore As CheckBox
    Friend WithEvents animals As CheckBox
    Friend WithEvents npcs As CheckBox
    Friend WithEvents forcegm As CheckBox
    Friend WithEvents online As CheckBox
    Friend WithEvents snooper As CheckBox
    Friend WithEvents monsters As CheckBox
    Friend WithEvents commandblocks As CheckBox
    Friend WithEvents pvp As CheckBox
    Friend WithEvents structures As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MaxPlayers As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents viewdistance As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents oppermlevel As NumericUpDown
    Friend WithEvents Peaceful As RadioButton
    Friend WithEvents Hard As RadioButton
    Friend WithEvents Normal As RadioButton
    Friend WithEvents Easy As RadioButton
    Friend WithEvents port As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents nether As CheckBox
    Friend WithEvents flight As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents seed As TextBox
    Friend WithEvents Creative As RadioButton
    Friend WithEvents Adventure As RadioButton
    Friend WithEvents Survival As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents statuslabel As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Rammb As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents v152 As RadioButton
    Friend WithEvents v162 As RadioButton
    Friend WithEvents v164 As RadioButton
    Friend WithEvents v188 As RadioButton
    Friend WithEvents v172 As RadioButton
    Friend WithEvents v1710 As RadioButton
    Friend WithEvents v18 As RadioButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label14 As Label
    Friend WithEvents pathtext2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents IPv4 As Label
    Friend WithEvents Button6 As Button
End Class
