'*******************************************************
' FORM	        :	frmWilliamLoadingScreen
'  
' OUTLINE		:	This form will show a loading screen
'                   gif and picture.  The user will have to wait 5 seconds
'                   for the programme to load.  After 5 seconds the form will
'                   close and show the main menu.
' 
' PROGRAMMER	:	William Chiu
'
'  DATE		    :	December 20, 2018
' ******************************************************
Public Class frmWilliamLoadingScreen
    Private Sub frmWilliamLoadingScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        timLoading.Enabled = True
        prgbLoading.Hide()
        lblLoaded.Hide()
    End Sub

    Private Sub timLoading_Tick(sender As Object, e As EventArgs) Handles timLoading.Tick

        prgbLoading.Value = prgbLoading.Value + 1
        If prgbLoading.Value = 30 Then
            lblLoaded.Show()
            picLoading.Hide()
        End If

        If prgbLoading.Value = 40 Then
            timLoading.Enabled = False
            frmMainTegh1.Show()
            Me.Close()
        End If
    End Sub
End Class
