<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainTegh1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainTegh1))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPlayerTitle = New System.Windows.Forms.Label()
        Me.lblPositionTitle = New System.Windows.Forms.Label()
        Me.lblDunkCalcTitle = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.btnPlayer = New System.Windows.Forms.Button()
        Me.btnPosition = New System.Windows.Forms.Button()
        Me.btnDunkCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitle.Location = New System.Drawing.Point(-5, -7)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(740, 60)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "NBA Quiz Nation"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayerTitle
        '
        Me.lblPlayerTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerTitle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPlayerTitle.Location = New System.Drawing.Point(7, 78)
        Me.lblPlayerTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayerTitle.Name = "lblPlayerTitle"
        Me.lblPlayerTitle.Size = New System.Drawing.Size(235, 401)
        Me.lblPlayerTitle.TabIndex = 8
        Me.lblPlayerTitle.Text = "What NBA Player Am I?"
        Me.lblPlayerTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblPositionTitle
        '
        Me.lblPositionTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblPositionTitle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPositionTitle.Location = New System.Drawing.Point(240, 88)
        Me.lblPositionTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPositionTitle.Name = "lblPositionTitle"
        Me.lblPositionTitle.Size = New System.Drawing.Size(237, 391)
        Me.lblPositionTitle.TabIndex = 13
        Me.lblPositionTitle.Text = "What Position do I Play?"
        Me.lblPositionTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblDunkCalcTitle
        '
        Me.lblDunkCalcTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDunkCalcTitle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDunkCalcTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDunkCalcTitle.Location = New System.Drawing.Point(480, 78)
        Me.lblDunkCalcTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDunkCalcTitle.Name = "lblDunkCalcTitle"
        Me.lblDunkCalcTitle.Size = New System.Drawing.Size(221, 401)
        Me.lblDunkCalcTitle.TabIndex = 15
        Me.lblDunkCalcTitle.Text = "Dunk Calculator"
        Me.lblDunkCalcTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblExit
        '
        Me.lblExit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblExit.Location = New System.Drawing.Point(685, 9)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(20, 22)
        Me.lblExit.TabIndex = 16
        Me.lblExit.Text = "X"
        Me.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSelect
        '
        Me.lblSelect.BackColor = System.Drawing.Color.Transparent
        Me.lblSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblSelect.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSelect.Location = New System.Drawing.Point(5, 53)
        Me.lblSelect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(730, 35)
        Me.lblSelect.TabIndex = 17
        Me.lblSelect.Text = "Select Gamemode:"
        Me.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlayer
        '
        Me.btnPlayer.BackgroundImage = Global.MehtaT_ChuiW_VasudeoJ_FinalProject.My.Resources.Resources.lebronjames
        Me.btnPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlayer.Location = New System.Drawing.Point(14, 88)
        Me.btnPlayer.Name = "btnPlayer"
        Me.btnPlayer.Size = New System.Drawing.Size(219, 366)
        Me.btnPlayer.TabIndex = 12
        Me.btnPlayer.UseVisualStyleBackColor = True
        '
        'btnPosition
        '
        Me.btnPosition.BackgroundImage = Global.MehtaT_ChuiW_VasudeoJ_FinalProject.My.Resources.Resources.kobebryant
        Me.btnPosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPosition.Location = New System.Drawing.Point(249, 88)
        Me.btnPosition.Name = "btnPosition"
        Me.btnPosition.Size = New System.Drawing.Size(219, 366)
        Me.btnPosition.TabIndex = 11
        Me.btnPosition.UseVisualStyleBackColor = True
        '
        'btnDunkCalc
        '
        Me.btnDunkCalc.BackgroundImage = Global.MehtaT_ChuiW_VasudeoJ_FinalProject.My.Resources.Resources.dunkCalculator
        Me.btnDunkCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDunkCalc.Location = New System.Drawing.Point(484, 88)
        Me.btnDunkCalc.Name = "btnDunkCalc"
        Me.btnDunkCalc.Size = New System.Drawing.Size(219, 366)
        Me.btnDunkCalc.TabIndex = 9
        Me.btnDunkCalc.UseVisualStyleBackColor = True
        '
        'frmMainTegh1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(717, 502)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.btnPlayer)
        Me.Controls.Add(Me.btnPosition)
        Me.Controls.Add(Me.btnDunkCalc)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblPlayerTitle)
        Me.Controls.Add(Me.lblPositionTitle)
        Me.Controls.Add(Me.lblDunkCalcTitle)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMainTegh1"
        Me.Text = "What NBA Player am I?"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPlayerTitle As Label
    Friend WithEvents btnDunkCalc As Button
    Friend WithEvents btnPosition As Button
    Friend WithEvents btnPlayer As Button
    Friend WithEvents lblPositionTitle As Label
    Friend WithEvents lblDunkCalcTitle As Label
    Friend WithEvents lblExit As Label
    Friend WithEvents lblSelect As Label
End Class
