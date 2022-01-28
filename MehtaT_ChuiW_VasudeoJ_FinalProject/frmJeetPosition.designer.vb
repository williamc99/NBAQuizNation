<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJeetPosition
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
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.picBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnB
        '
        Me.btnB.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnB.Enabled = False
        Me.btnB.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnB.Location = New System.Drawing.Point(173, 289)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(156, 70)
        Me.btnB.TabIndex = 0
        Me.btnB.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnNext.Location = New System.Drawing.Point(272, 365)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(363, 48)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Start"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnD
        '
        Me.btnD.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnD.Enabled = False
        Me.btnD.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnD.Location = New System.Drawing.Point(493, 289)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(142, 70)
        Me.btnD.TabIndex = 2
        Me.btnD.UseVisualStyleBackColor = False
        '
        'btnC
        '
        Me.btnC.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnC.Enabled = False
        Me.btnC.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnC.Location = New System.Drawing.Point(335, 289)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(152, 70)
        Me.btnC.TabIndex = 4
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btnA
        '
        Me.btnA.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnA.Enabled = False
        Me.btnA.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnA.Location = New System.Drawing.Point(12, 289)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(153, 70)
        Me.btnA.TabIndex = 5
        Me.btnA.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(13, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(623, 82)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "What Position Are you?"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQuestion
        '
        Me.lblQuestion.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lblQuestion.Location = New System.Drawing.Point(343, 70)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(292, 192)
        Me.lblQuestion.TabIndex = 8
        Me.lblQuestion.Text = "> Click Start To Begin"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(12, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(254, 48)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Main Menu"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblExit
        '
        Me.lblExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lblExit.ForeColor = System.Drawing.Color.Black
        Me.lblExit.Location = New System.Drawing.Point(620, 9)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(16, 22)
        Me.lblExit.TabIndex = 27
        Me.lblExit.Text = "X"
        Me.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picBox1
        '
        Me.picBox1.Location = New System.Drawing.Point(25, 70)
        Me.picBox1.Name = "picBox1"
        Me.picBox1.Size = New System.Drawing.Size(313, 192)
        Me.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBox1.TabIndex = 6
        Me.picBox1.TabStop = False
        '
        'frmJeetPosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(648, 427)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picBox1)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnD)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmJeetPosition"
        Me.Text = "What Position Are You?"
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnB As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnD As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnA As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents picBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblExit As Label
End Class
