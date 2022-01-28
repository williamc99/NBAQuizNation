'*******************************************************
' FORM	        :	frmWilliamDunkCalc
'  
' OUTLINE		:	This form will determine the needed vertical in inches to 
'                   dunk.  After entering attributes, it will calculate how the 
'                   vertical needed.  It will then ask if they can jump the desired
'                   height.  Depending on which choice was chose, a form will show.  
'                   
' PROGRAMMER	:	William Chiu
'
'  DATE		    :	December 20, 2018
' ******************************************************
Public Class frmWilliamDunkCalc
    Public flag As Boolean
    Public rimHeight, personHeight, standingReach, personWeight, verticalJump, finalAnswer As Decimal
    Public personName, canDunkString As String

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click



NameInput:

        personName = InputBox("Please enter your name: ", "NAME")
        If IsNumeric(personName) = True Then
            MessageBox.Show("Please enter a valid name!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            personName = Nothing
            GoTo NameInput
        ElseIf personName = Nothing Then
            MessageBox.Show("Please enter a valid name!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            personName = Nothing
            GoTo NameInput
        Else
            GoTo RimInput
        End If

RimInput:

        rimHeight = InputBox("Please enter the height of the rim (inches):" & vbNewLine & " (1 ft = 12 inches)", "HEIGHT", "120")
        If IsNumeric(rimHeight) = False Then
            MessageBox.Show("Please enter a valid height!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rimHeight = Nothing
            GoTo RimInput
        ElseIf rimHeight = Nothing Then
            MessageBox.Show("Please enter a valid height!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            personName = Nothing
            GoTo RimInput
        Else
            GoTo HeightInput
        End If

HeightInput:

        personHeight = InputBox("Please enter your height (inches):" & vbNewLine & " (1 ft = 12 inches)", "HEIGHT", "65")
        If IsNumeric(personHeight) = False Then
            MessageBox.Show("Please enter a valid height!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            personHeight = Nothing
            GoTo HeightInput
        ElseIf personHeight = Nothing Then
            MessageBox.Show("Please enter a valid height!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            personName = Nothing
            GoTo HeightInput
        Else
            GoTo StandingInput
        End If

StandingInput:

        standingReach = InputBox("Please enter your standing reach (inches):" & vbNewLine & " (1 ft = 12 inches)", "STANDING REACH", "72")
        If IsNumeric(standingReach) = False Then
            MessageBox.Show("Please enter a valid standing reach!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            standingReach = Nothing
            GoTo StandingInput
        ElseIf standingReach = Nothing Then
            MessageBox.Show("Please enter a valid standing reach!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            standingReach = Nothing
            GoTo StandingInput
        Else
            GoTo WeightInput
        End If

WeightInput:

        personWeight = InputBox("Please enter your weight (lbs): ", "WEIGHT", "120")
        If IsNumeric(personWeight) = False Then
            MessageBox.Show("Please enter a valid weight!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            personWeight = Nothing
            GoTo WeightInput
        ElseIf personWeight = Nothing Then
            MessageBox.Show("Please enter a valid weight!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            personWeight = Nothing
            GoTo WeightInput
        Else
            MessageBox.Show("Your stats have been recorded, please click 'Show Results'!", "RECORDED", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnCalculate.Enabled = False
            btnCalculate.FlatAppearance.BorderColor = Color.Black
            btnShowResults.Enabled = True
            btnShowResults.FlatAppearance.BorderColor = Color.Red
            btnDunkData.Enabled = True
            btnDunkData.FlatAppearance.BorderColor = Color.Red
        End If

    End Sub

    Private Sub btnShowResults_Click(sender As Object, e As EventArgs) Handles btnShowResults.Click

        verticalJump = rimHeight - standingReach
        finalAnswer = verticalJump + 6

        MessageBox.Show("You would need a " & verticalJump & " inch vertical to touch the rim and a " & finalAnswer & " inch vertical to dunk!", "RESULTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        DialogResult = MessageBox.Show("Can you jump " & finalAnswer & " inches?", "JUMP", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If DialogResult = DialogResult.Yes Then
            canDunkString = "Yes!"
            frmWilliamCanDunk.Show()
            Me.Hide()
        ElseIf DialogResult = DialogResult.No Then
            canDunkString = "No!"
            frmWilliamCannotDunk.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnCreatorsScores_Click(sender As Object, e As EventArgs) Handles btnDunkData.Click
        frmWilliamHighScores.Show()
        Me.Hide()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        frmMainTegh1.Show()
        Me.Hide()
    End Sub
End Class
