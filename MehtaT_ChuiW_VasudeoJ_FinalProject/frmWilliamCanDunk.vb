'*******************************************************
' FORM	        :	frmWilliamCanDunk
'  
' OUTLINE		:	This form will show a gif of an NBA player dunking.  
'                   The user can press "Return" to go back to the main form.
'                   
' PROGRAMMER	:	William Chiu
'
'  DATE		    :	December 20, 2018
' ******************************************************

Public Class frmWilliamCanDunk
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        frmWilliamDunkCalc.Show()
        Me.Hide()
    End Sub
End Class