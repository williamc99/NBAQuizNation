'*******************************************************
' FORM  	    :	frmPlayerTegh2 - Main
'  
' OUTLINE		:	This form will allow the user to choose one of 3 				
'                   game modes.  Once one of the modes are 					
'                   clicked it will hide the main form and show the 
'      				new form.
' 
' PROGRAMMER	:	Tegh Mehta
'
'  DATE		    :	December 14, 2018
' ******************************************************

Public Class frmMainTegh1

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub btnPlayer_Click(sender As Object, e As EventArgs) Handles btnPlayer.Click
        frmPlayerTegh2.Show()
        Me.Close()
    End Sub

    Private Sub btnDunkCalc_Click(sender As Object, e As EventArgs) Handles btnDunkCalc.Click
        frmWilliamDunkCalc.Show()
        Me.Close()
    End Sub

    Private Sub btnPosition_Click(sender As Object, e As EventArgs) Handles btnPosition.Click
        frmJeetPosition.Show()
        Me.Close()
    End Sub
End Class
