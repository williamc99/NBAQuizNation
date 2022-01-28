'*******************************************************
' FORM	        :	frmWilliamCannotDunk
'  
' OUTLINE		:	This form will show a gif of an NBA player missing a dunk.  
'                   The user can press "Return" to go back to the main form.
'                   
' PROGRAMMER	:	William Chiu
'
'  DATE		    :	December 20, 2018
' ******************************************************
Public Class frmWilliamCannotDunk
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        frmWilliamDunkCalc.Show()
        Me.Close()
    End Sub
End Class