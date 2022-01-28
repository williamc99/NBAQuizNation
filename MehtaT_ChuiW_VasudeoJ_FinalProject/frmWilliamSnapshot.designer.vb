<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWilliamSnapshotQuestion
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
        Me.btnMain = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnAnswer4 = New System.Windows.Forms.Button()
        Me.btnAnswer3 = New System.Windows.Forms.Button()
        Me.btnAnswer2 = New System.Windows.Forms.Button()
        Me.btnAnswer1 = New System.Windows.Forms.Button()
        Me.picSnapshot = New System.Windows.Forms.PictureBox()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.picSnapshot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMain.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMain.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMain.Location = New System.Drawing.Point(287, 393)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(130, 34)
        Me.btnMain.TabIndex = 45
        Me.btnMain.Text = "Main Menu"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnStart.Location = New System.Drawing.Point(23, 393)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(252, 34)
        Me.btnStart.TabIndex = 44
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnAnswer4
        '
        Me.btnAnswer4.BackColor = System.Drawing.Color.White
        Me.btnAnswer4.Enabled = False
        Me.btnAnswer4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAnswer4.FlatAppearance.BorderSize = 3
        Me.btnAnswer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnswer4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer4.Location = New System.Drawing.Point(434, 368)
        Me.btnAnswer4.Name = "btnAnswer4"
        Me.btnAnswer4.Size = New System.Drawing.Size(254, 59)
        Me.btnAnswer4.TabIndex = 43
        Me.btnAnswer4.UseVisualStyleBackColor = False
        '
        'btnAnswer3
        '
        Me.btnAnswer3.BackColor = System.Drawing.Color.White
        Me.btnAnswer3.Enabled = False
        Me.btnAnswer3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAnswer3.FlatAppearance.BorderSize = 3
        Me.btnAnswer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnswer3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer3.Location = New System.Drawing.Point(434, 303)
        Me.btnAnswer3.Name = "btnAnswer3"
        Me.btnAnswer3.Size = New System.Drawing.Size(254, 59)
        Me.btnAnswer3.TabIndex = 42
        Me.btnAnswer3.UseVisualStyleBackColor = False
        '
        'btnAnswer2
        '
        Me.btnAnswer2.BackColor = System.Drawing.Color.White
        Me.btnAnswer2.Enabled = False
        Me.btnAnswer2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAnswer2.FlatAppearance.BorderSize = 3
        Me.btnAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnswer2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer2.Location = New System.Drawing.Point(434, 238)
        Me.btnAnswer2.Name = "btnAnswer2"
        Me.btnAnswer2.Size = New System.Drawing.Size(254, 59)
        Me.btnAnswer2.TabIndex = 41
        Me.btnAnswer2.UseVisualStyleBackColor = False
        '
        'btnAnswer1
        '
        Me.btnAnswer1.BackColor = System.Drawing.Color.White
        Me.btnAnswer1.Enabled = False
        Me.btnAnswer1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAnswer1.FlatAppearance.BorderSize = 3
        Me.btnAnswer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnswer1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer1.Location = New System.Drawing.Point(434, 173)
        Me.btnAnswer1.Name = "btnAnswer1"
        Me.btnAnswer1.Size = New System.Drawing.Size(254, 59)
        Me.btnAnswer1.TabIndex = 40
        Me.btnAnswer1.UseVisualStyleBackColor = False
        '
        'picSnapshot
        '
        Me.picSnapshot.Location = New System.Drawing.Point(23, 163)
        Me.picSnapshot.Name = "picSnapshot"
        Me.picSnapshot.Size = New System.Drawing.Size(394, 224)
        Me.picSnapshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSnapshot.TabIndex = 39
        Me.picSnapshot.TabStop = False
        '
        'lblQuestion
        '
        Me.lblQuestion.BackColor = System.Drawing.Color.White
        Me.lblQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblQuestion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.lblQuestion.Location = New System.Drawing.Point(24, 72)
        Me.lblQuestion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(663, 77)
        Me.lblQuestion.TabIndex = 38
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExit
        '
        Me.lblExit.ForeColor = System.Drawing.Color.Blue
        Me.lblExit.Location = New System.Drawing.Point(672, 10)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(16, 22)
        Me.lblExit.TabIndex = 37
        Me.lblExit.Text = "X"
        Me.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitle.Location = New System.Drawing.Point(-2, -1)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(740, 60)
        Me.lblTitle.TabIndex = 36
        Me.lblTitle.Text = "Snapshot!"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmWilliamSnapshotQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(710, 451)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnAnswer4)
        Me.Controls.Add(Me.btnAnswer3)
        Me.Controls.Add(Me.btnAnswer2)
        Me.Controls.Add(Me.btnAnswer1)
        Me.Controls.Add(Me.picSnapshot)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmWilliamSnapshotQuestion"
        CType(Me.picSnapshot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMain As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnAnswer4 As Button
    Friend WithEvents btnAnswer3 As Button
    Friend WithEvents btnAnswer2 As Button
    Friend WithEvents btnAnswer1 As Button
    Friend WithEvents picSnapshot As PictureBox
    Friend WithEvents lblQuestion As Label
    Friend WithEvents lblExit As Label
    Friend WithEvents lblTitle As Label
End Class
