<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWilliamSnapshotResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWilliamSnapshotResult))
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnCorrectAnswer = New System.Windows.Forms.Button()
        Me.lblCorrectAnswer = New System.Windows.Forms.Label()
        Me.wmpPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.lblPlay = New System.Windows.Forms.Label()
        CType(Me.wmpPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblExit
        '
        Me.lblExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblExit.Location = New System.Drawing.Point(750, 9)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(16, 22)
        Me.lblExit.TabIndex = 36
        Me.lblExit.Text = "X"
        Me.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitle.Location = New System.Drawing.Point(0, -3)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(830, 60)
        Me.lblTitle.TabIndex = 35
        Me.lblTitle.Text = "Results"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 630)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(494, 23)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Double Click the Video Player to Go into Fullscreen!"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNext.Location = New System.Drawing.Point(617, 619)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(149, 34)
        Me.btnNext.TabIndex = 50
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnCorrectAnswer
        '
        Me.btnCorrectAnswer.BackColor = System.Drawing.Color.White
        Me.btnCorrectAnswer.Enabled = False
        Me.btnCorrectAnswer.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCorrectAnswer.FlatAppearance.BorderSize = 3
        Me.btnCorrectAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCorrectAnswer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCorrectAnswer.Location = New System.Drawing.Point(370, 560)
        Me.btnCorrectAnswer.Name = "btnCorrectAnswer"
        Me.btnCorrectAnswer.Size = New System.Drawing.Size(254, 59)
        Me.btnCorrectAnswer.TabIndex = 51
        Me.btnCorrectAnswer.UseVisualStyleBackColor = False
        '
        'lblCorrectAnswer
        '
        Me.lblCorrectAnswer.AutoSize = True
        Me.lblCorrectAnswer.BackColor = System.Drawing.Color.Transparent
        Me.lblCorrectAnswer.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectAnswer.ForeColor = System.Drawing.Color.White
        Me.lblCorrectAnswer.Location = New System.Drawing.Point(204, 577)
        Me.lblCorrectAnswer.Name = "lblCorrectAnswer"
        Me.lblCorrectAnswer.Size = New System.Drawing.Size(160, 23)
        Me.lblCorrectAnswer.TabIndex = 52
        Me.lblCorrectAnswer.Text = "Correct Answer:"
        '
        'wmpPlayer
        '
        Me.wmpPlayer.Enabled = True
        Me.wmpPlayer.Location = New System.Drawing.Point(7, 60)
        Me.wmpPlayer.Name = "wmpPlayer"
        Me.wmpPlayer.OcxState = CType(resources.GetObject("wmpPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpPlayer.Size = New System.Drawing.Size(774, 494)
        Me.wmpPlayer.TabIndex = 54
        '
        'lblPlay
        '
        Me.lblPlay.AutoSize = True
        Me.lblPlay.BackColor = System.Drawing.Color.Transparent
        Me.lblPlay.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlay.ForeColor = System.Drawing.Color.Gray
        Me.lblPlay.Location = New System.Drawing.Point(4, 557)
        Me.lblPlay.Name = "lblPlay"
        Me.lblPlay.Size = New System.Drawing.Size(205, 18)
        Me.lblPlay.TabIndex = 55
        Me.lblPlay.Text = "Press ""Play"" to Play Video"
        '
        'frmWilliamSnapshotResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(793, 677)
        Me.Controls.Add(Me.lblPlay)
        Me.Controls.Add(Me.wmpPlayer)
        Me.Controls.Add(Me.lblCorrectAnswer)
        Me.Controls.Add(Me.btnCorrectAnswer)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmWilliamSnapshotResult"
        Me.Text = "frmWilliamSnapshotResult"
        CType(Me.wmpPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblExit As Label
    Friend WithEvents lblTitle As Label
    ' Friend WithEvents wmpResults As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnCorrectAnswer As Button
    Friend WithEvents lblCorrectAnswer As Label
    Friend WithEvents wmpPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents lblPlay As Label
End Class
