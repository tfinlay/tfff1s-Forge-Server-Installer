<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckForUpdates = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(549, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Save and Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckForUpdates
        '
        Me.CheckForUpdates.AutoSize = True
        Me.CheckForUpdates.Location = New System.Drawing.Point(12, 12)
        Me.CheckForUpdates.Name = "CheckForUpdates"
        Me.CheckForUpdates.Size = New System.Drawing.Size(118, 17)
        Me.CheckForUpdates.TabIndex = 1
        Me.CheckForUpdates.Text = "Check For Updates"
        Me.CheckForUpdates.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 239)
        Me.Controls.Add(Me.CheckForUpdates)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Options"
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents CheckForUpdates As CheckBox
End Class
