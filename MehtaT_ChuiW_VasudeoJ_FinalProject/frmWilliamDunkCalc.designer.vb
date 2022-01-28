<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWilliamDunkCalc
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
        Me.lblColour2 = New System.Windows.Forms.Label()
        Me.lblColour3 = New System.Windows.Forms.Label()
        Me.lblColour4 = New System.Windows.Forms.Label()
        Me.lblColour5 = New System.Windows.Forms.Label()
        Me.lblColour6 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnShowResults = New System.Windows.Forms.Button()
        Me.btnDunkData = New System.Windows.Forms.Button()
        Me.picDisplay = New System.Windows.Forms.PictureBox()
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Location = New System.Drawing.Point(-57, -20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(838, 98)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Dunk Calculator"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColour2
        '
        Me.lblColour2.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblColour2.Location = New System.Drawing.Point(-143, 48)
        Me.lblColour2.Name = "lblColour2"
        Me.lblColour2.Size = New System.Drawing.Size(838, 121)
        Me.lblColour2.TabIndex = 12
        '
        'lblColour3
        '
        Me.lblColour3.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.lblColour3.Location = New System.Drawing.Point(-29, 160)
        Me.lblColour3.Name = "lblColour3"
        Me.lblColour3.Size = New System.Drawing.Size(838, 94)
        Me.lblColour3.TabIndex = 11
        '
        'lblColour4
        '
        Me.lblColour4.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.lblColour4.Location = New System.Drawing.Point(-132, 236)
        Me.lblColour4.Name = "lblColour4"
        Me.lblColour4.Size = New System.Drawing.Size(838, 101)
        Me.lblColour4.TabIndex = 10
        '
        'lblColour5
        '
        Me.lblColour5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.lblColour5.Location = New System.Drawing.Point(-101, 327)
        Me.lblColour5.Name = "lblColour5"
        Me.lblColour5.Size = New System.Drawing.Size(838, 107)
        Me.lblColour5.TabIndex = 9
        '
        'lblColour6
        '
        Me.lblColour6.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblColour6.Location = New System.Drawing.Point(-101, 407)
        Me.lblColour6.Name = "lblColour6"
        Me.lblColour6.Size = New System.Drawing.Size(838, 119)
        Me.lblColour6.TabIndex = 8
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCalculate.FlatAppearance.BorderSize = 5
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCalculate.Location = New System.Drawing.Point(363, 99)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(220, 58)
        Me.btnCalculate.TabIndex = 15
        Me.btnCalculate.Text = "Calculate Dunk!"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnReturn.FlatAppearance.BorderSize = 5
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReturn.Location = New System.Drawing.Point(363, 352)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(220, 70)
        Me.btnReturn.TabIndex = 16
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnShowResults
        '
        Me.btnShowResults.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnShowResults.Enabled = False
        Me.btnShowResults.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnShowResults.FlatAppearance.BorderSize = 5
        Me.btnShowResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowResults.ForeColor = System.Drawing.SystemColors.Control
        Me.btnShowResults.Location = New System.Drawing.Point(363, 184)
        Me.btnShowResults.Name = "btnShowResults"
        Me.btnShowResults.Size = New System.Drawing.Size(220, 58)
        Me.btnShowResults.TabIndex = 18
        Me.btnShowResults.Text = "Show Results"
        Me.btnShowResults.UseVisualStyleBackColor = False
        '
        'btnDunkData
        '
        Me.btnDunkData.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnDunkData.Enabled = False
        Me.btnDunkData.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDunkData.FlatAppearance.BorderSize = 5
        Me.btnDunkData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDunkData.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDunkData.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDunkData.Location = New System.Drawing.Point(363, 266)
        Me.btnDunkData.Name = "btnDunkData"
        Me.btnDunkData.Size = New System.Drawing.Size(220, 58)
        Me.btnDunkData.TabIndex = 19
        Me.btnDunkData.Text = "Dunk Database"
        Me.btnDunkData.UseVisualStyleBackColor = False
        '
        'picDisplay
        '
        Me.picDisplay.BackColor = System.Drawing.Color.Transparent
        Me.picDisplay.Image = Global.MehtaT_ChuiW_VasudeoJ_FinalProject.My.Resources.Resources.donovandunk3_dunkcalc
        Me.picDisplay.Location = New System.Drawing.Point(12, 99)
        Me.picDisplay.Name = "picDisplay"
        Me.picDisplay.Size = New System.Drawing.Size(238, 400)
        Me.picDisplay.TabIndex = 17
        Me.picDisplay.TabStop = False
        '
        'frmWilliamDunkCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 515)
        Me.Controls.Add(Me.btnDunkData)
        Me.Controls.Add(Me.btnShowResults)
        Me.Controls.Add(Me.picDisplay)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblColour2)
        Me.Controls.Add(Me.lblColour3)
        Me.Controls.Add(Me.lblColour4)
        Me.Controls.Add(Me.lblColour5)
        Me.Controls.Add(Me.lblColour6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmWilliamDunkCalc"
        Me.Text = "Form1"
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblColour2 As Label
    Friend WithEvents lblColour3 As Label
    Friend WithEvents lblColour4 As Label
    Friend WithEvents lblColour5 As Label
    Friend WithEvents lblColour6 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents picDisplay As PictureBox
    Friend WithEvents btnShowResults As Button
    Friend WithEvents btnDunkData As Button
End Class
