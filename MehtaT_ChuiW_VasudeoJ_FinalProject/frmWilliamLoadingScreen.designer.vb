<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWilliamLoadingScreen
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
        Me.components = New System.ComponentModel.Container()
        Me.timLoading = New System.Windows.Forms.Timer(Me.components)
        Me.prgbLoading = New System.Windows.Forms.ProgressBar()
        Me.picLoading = New System.Windows.Forms.PictureBox()
        Me.lblLoaded = New System.Windows.Forms.Label()
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timLoading
        '
        '
        'prgbLoading
        '
        Me.prgbLoading.Location = New System.Drawing.Point(12, 395)
        Me.prgbLoading.Name = "prgbLoading"
        Me.prgbLoading.Size = New System.Drawing.Size(141, 24)
        Me.prgbLoading.TabIndex = 3
        '
        'picLoading 
        '
        Me.picLoading.BackColor = System.Drawing.Color.Transparent
        Me.picLoading.Image = My.Resources.Resources.greywheel_loadingscreen
        Me.picLoading.Location = New System.Drawing.Point(578, 331)
        Me.picLoading.Name = "picLoading"
        Me.picLoading.Size = New System.Drawing.Size(129, 88)
        Me.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLoading.TabIndex = 4
        Me.picLoading.TabStop = False
        '
        'lblLoaded
        '
        Me.lblLoaded.AutoSize = True
        Me.lblLoaded.BackColor = System.Drawing.Color.Transparent
        Me.lblLoaded.Font = New System.Drawing.Font("Arial", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoaded.ForeColor = System.Drawing.SystemColors.Control
        Me.lblLoaded.Location = New System.Drawing.Point(574, 326)
        Me.lblLoaded.Name = "lblLoaded"
        Me.lblLoaded.Size = New System.Drawing.Size(123, 93)
        Me.lblLoaded.TabIndex = 5
        Me.lblLoaded.Text = "✓"
        '
        'frmWilliamLoadingScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = My.Resources.Resources.finalproject_loadingscreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(719, 447)
        Me.Controls.Add(Me.lblLoaded)
        Me.Controls.Add(Me.picLoading)
        Me.Controls.Add(Me.prgbLoading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmWilliamLoadingScreen"
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timLoading As Timer
    Friend WithEvents prgbLoading As ProgressBar
    Friend WithEvents picLoading As PictureBox
    Friend WithEvents lblLoaded As Label
End Class
