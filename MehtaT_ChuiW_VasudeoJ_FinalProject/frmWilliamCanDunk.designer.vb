<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWilliamCanDunk
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
        Me.picDunk = New System.Windows.Forms.PictureBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        CType(Me.picDunk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Location = New System.Drawing.Point(-80, -6)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(838, 98)
        Me.lblTitle.TabIndex = 19
        Me.lblTitle.Text = "Congratulations on Being Able to Dunk!"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColour2
        '
        Me.lblColour2.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblColour2.Location = New System.Drawing.Point(-131, 43)
        Me.lblColour2.Name = "lblColour2"
        Me.lblColour2.Size = New System.Drawing.Size(838, 121)
        Me.lblColour2.TabIndex = 18
        '
        'lblColour3
        '
        Me.lblColour3.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.lblColour3.Location = New System.Drawing.Point(-17, 155)
        Me.lblColour3.Name = "lblColour3"
        Me.lblColour3.Size = New System.Drawing.Size(838, 94)
        Me.lblColour3.TabIndex = 17
        '
        'lblColour4
        '
        Me.lblColour4.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.lblColour4.Location = New System.Drawing.Point(-120, 231)
        Me.lblColour4.Name = "lblColour4"
        Me.lblColour4.Size = New System.Drawing.Size(838, 114)
        Me.lblColour4.TabIndex = 16
        '
        'lblColour5
        '
        Me.lblColour5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.lblColour5.Location = New System.Drawing.Point(-98, 345)
        Me.lblColour5.Name = "lblColour5"
        Me.lblColour5.Size = New System.Drawing.Size(838, 107)
        Me.lblColour5.TabIndex = 15
        '
        'lblColour6
        '
        Me.lblColour6.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblColour6.Location = New System.Drawing.Point(-89, 383)
        Me.lblColour6.Name = "lblColour6"
        Me.lblColour6.Size = New System.Drawing.Size(838, 119)
        Me.lblColour6.TabIndex = 14
        '
        'picDunk
        '
        Me.picDunk.Image = My.Resources.Resources.donovanactuallydunks
        Me.picDunk.Location = New System.Drawing.Point(82, 74)
        Me.picDunk.Name = "picDunk"
        Me.picDunk.Size = New System.Drawing.Size(538, 268)
        Me.picDunk.TabIndex = 20
        Me.picDunk.TabStop = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnReturn.FlatAppearance.BorderSize = 5
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReturn.Location = New System.Drawing.Point(239, 355)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(220, 70)
        Me.btnReturn.TabIndex = 21
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'frmCanDunk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 437)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.picDunk)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblColour2)
        Me.Controls.Add(Me.lblColour3)
        Me.Controls.Add(Me.lblColour4)
        Me.Controls.Add(Me.lblColour5)
        Me.Controls.Add(Me.lblColour6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCanDunk"
        CType(Me.picDunk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblColour2 As Label
    Friend WithEvents lblColour3 As Label
    Friend WithEvents lblColour4 As Label
    Friend WithEvents lblColour5 As Label
    Friend WithEvents lblColour6 As Label
    Friend WithEvents picDunk As PictureBox
    Friend WithEvents btnReturn As Button
End Class
