<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlayerTegh2
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnAnswer1 = New System.Windows.Forms.Button()
        Me.btnAnswer2 = New System.Windows.Forms.Button()
        Me.btnAnswer3 = New System.Windows.Forms.Button()
        Me.btnAnswer4 = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.btnMain = New System.Windows.Forms.Button()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitle.Location = New System.Drawing.Point(-13, -2)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(740, 60)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "What NBA Player Am I?"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExit
        '
        Me.lblExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblExit.Location = New System.Drawing.Point(661, 9)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(16, 22)
        Me.lblExit.TabIndex = 17
        Me.lblExit.Text = "X"
        Me.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQuestion
        '
        Me.lblQuestion.BackColor = System.Drawing.Color.White
        Me.lblQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblQuestion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblQuestion.Location = New System.Drawing.Point(13, 71)
        Me.lblQuestion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(663, 77)
        Me.lblQuestion.TabIndex = 18
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAnswer1
        '
        Me.btnAnswer1.BackColor = System.Drawing.Color.White
        Me.btnAnswer1.Enabled = False
        Me.btnAnswer1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer1.Location = New System.Drawing.Point(423, 172)
        Me.btnAnswer1.Name = "btnAnswer1"
        Me.btnAnswer1.Size = New System.Drawing.Size(254, 59)
        Me.btnAnswer1.TabIndex = 20
        Me.btnAnswer1.UseVisualStyleBackColor = False
        '
        'btnAnswer2
        '
        Me.btnAnswer2.BackColor = System.Drawing.Color.White
        Me.btnAnswer2.Enabled = False
        Me.btnAnswer2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer2.Location = New System.Drawing.Point(423, 237)
        Me.btnAnswer2.Name = "btnAnswer2"
        Me.btnAnswer2.Size = New System.Drawing.Size(254, 59)
        Me.btnAnswer2.TabIndex = 21
        Me.btnAnswer2.UseVisualStyleBackColor = False
        '
        'btnAnswer3
        '
        Me.btnAnswer3.BackColor = System.Drawing.Color.White
        Me.btnAnswer3.Enabled = False
        Me.btnAnswer3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer3.Location = New System.Drawing.Point(423, 302)
        Me.btnAnswer3.Name = "btnAnswer3"
        Me.btnAnswer3.Size = New System.Drawing.Size(254, 59)
        Me.btnAnswer3.TabIndex = 22
        Me.btnAnswer3.UseVisualStyleBackColor = False
        '
        'btnAnswer4
        '
        Me.btnAnswer4.BackColor = System.Drawing.Color.White
        Me.btnAnswer4.Enabled = False
        Me.btnAnswer4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer4.Location = New System.Drawing.Point(423, 367)
        Me.btnAnswer4.Name = "btnAnswer4"
        Me.btnAnswer4.Size = New System.Drawing.Size(254, 59)
        Me.btnAnswer4.TabIndex = 23
        Me.btnAnswer4.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Snow
        Me.btnStart.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(154, 392)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(252, 34)
        Me.btnStart.TabIndex = 24
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'picPlayer
        '
        Me.picPlayer.Location = New System.Drawing.Point(12, 162)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(394, 224)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer.TabIndex = 19
        Me.picPlayer.TabStop = False
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnMain.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMain.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMain.Location = New System.Drawing.Point(12, 392)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(130, 34)
        Me.btnMain.TabIndex = 35
        Me.btnMain.Text = "Main Menu"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'frmPlayerTegh2
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(689, 443)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnAnswer4)
        Me.Controls.Add(Me.btnAnswer3)
        Me.Controls.Add(Me.btnAnswer2)
        Me.Controls.Add(Me.btnAnswer1)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPlayerTegh2"
        Me.Text = " "
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblExit As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents btnAnswer1 As Button
    Friend WithEvents btnAnswer2 As Button
    Friend WithEvents btnAnswer3 As Button
    Friend WithEvents btnAnswer4 As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnMain As Button
End Class
