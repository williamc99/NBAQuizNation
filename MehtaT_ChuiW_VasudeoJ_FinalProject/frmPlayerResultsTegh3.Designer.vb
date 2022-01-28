<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlayerResultsTegh3
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnStart.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnStart.Location = New System.Drawing.Point(12, 324)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(275, 34)
        Me.btnStart.TabIndex = 33
        Me.btnStart.Text = "Start Snapshot Gamemode!"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblResults
        '
        Me.lblResults.BackColor = System.Drawing.Color.White
        Me.lblResults.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblResults.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblResults.Location = New System.Drawing.Point(429, 77)
        Me.lblResults.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(367, 281)
        Me.lblResults.TabIndex = 27
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExit
        '
        Me.lblExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblExit.Location = New System.Drawing.Point(797, 9)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(16, 22)
        Me.lblExit.TabIndex = 26
        Me.lblExit.Text = "X"
        Me.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitle.Location = New System.Drawing.Point(-4, -1)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(830, 60)
        Me.lblTitle.TabIndex = 25
        Me.lblTitle.Text = "Results"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnMain.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMain.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMain.Location = New System.Drawing.Point(293, 324)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(120, 34)
        Me.btnMain.TabIndex = 34
        Me.btnMain.Text = "Main Menu"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'picPlayer
        '
        Me.picPlayer.Location = New System.Drawing.Point(12, 77)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(401, 224)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer.TabIndex = 28
        Me.picPlayer.TabStop = False
        '
        'frmPlayerResultsTegh3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(826, 384)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPlayerResultsTegh3"
        Me.Text = "frmPlayerResultsTegh3"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents lblResults As Label
    Friend WithEvents lblExit As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnMain As Button
End Class
