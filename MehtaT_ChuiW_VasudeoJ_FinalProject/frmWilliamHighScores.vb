'*******************************************************
' FORM	        :	frmWilliamHighScores
'  
' OUTLINE		:	This form will show the player's attributes and 
'                   how they compare to the attributes of the creators.  
'                   The user can click "Return" to return to the main form.
'                   
' PROGRAMMER	:	William Chiu
'
'  DATE		    :	December 20, 2018
' ******************************************************
Public Class frmWilliamHighScores
    Private Sub frmWilliamHighScores_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblNameInput.Text = frmWilliamDunkCalc.personName
        lblRimInput.Text = frmWilliamDunkCalc.verticalJump & " inches"
        lblDunkInput.Text = frmWilliamDunkCalc.finalAnswer & " inches"
        lblCanDunkInput.Text = frmWilliamDunkCalc.canDunkString
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        frmWilliamDunkCalc.Show()
        Me.Hide()
    End Sub
End Class