'*******************************************************
' FORM  	    :	frmJeetPosition
'  
' OUTLINE		:	This form will ask the user a series of questions
'                   to determine what basketball position would be best
'                   suited for him.  The user can select from 4 buttons which will
'                   disable upon click of one.  After the quiz, the user can return
'                   back to the main menu.
' 
' PROGRAMMER	:	Jeet Vasudeo
'
'  DATE		    :	December 20, 2018
' ******************************************************

Imports System.IO
Public Class frmJeetPosition
    Private questionNumber As Integer = 1
    Private sg As Integer
    Private pg As Integer
    Private sf As Integer
    Private pf As Integer
    Private ct As Integer
    Private questionCounter As Integer = 1
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        btnNext.Text = "Next"
        btnA.Enabled = True
        btnB.Enabled = True
        btnC.Enabled = True
        btnD.Enabled = True
        btnNext.Enabled = False
        FormulateQuestion()
        btnA.BackColor = Color.FromArgb(66, 66, 66)
        btnB.BackColor = Color.FromArgb(66, 66, 66)
        btnC.BackColor = Color.FromArgb(66, 66, 66)
        btnD.BackColor = Color.FromArgb(66, 66, 66)

    End Sub
    Sub FormulateQuestion()
        Dim questionsData() As String = GetData()
        Dim max As Integer
        Dim name As String = "Point Guard"
        If questionNumber < 41 Then
            lblQuestion.Text = questionsData(questionNumber)
            btnA.Text = questionsData(questionNumber + 1)
            btnB.Text = questionsData(questionNumber + 2)
            btnC.Text = questionsData(questionNumber + 3)
            btnD.Text = questionsData(questionNumber + 4)
            questionNumber += 5
        Else
            If sg > max Then
                max = sg
                name = "Shooting Guard"
                sg = 0
            End If
            If pg > max Then
                max = pg
                name = "Point Guard"
                pg = 0
            End If
            If sf > max Then
                max = sf
                name = "Small Forward"
                sf = 0
            End If
            If pf > max Then
                max = pf
                name = "Power Forward"
                pf = 0
            End If
            If ct > max Then
                max = ct
                name = "Center"
                ct = 0
            End If

            If max = pg Or max = sf Or max = pf Or max = ct Or max = sg Then
                If sg >= max Then
                    max = sg
                    name &= " and/or" & " " & "Shooting Guard"

                End If
                If pg >= max Then
                    max = pg
                    name &= " and/or" & " " & "Point Guard"

                End If
                If sf >= max Then
                    max = sf
                    name &= " and/or" & " " & "Small Forward"

                End If
                If pf >= max Then
                    max = pf
                    name &= " and/or" & " " & "Power Forward"

                End If
                If ct >= max Then
                    max = ct
                    name &= " and/or" & " " & "Center"
                End If
            End If
            btnA.Enabled = False
            btnB.Enabled = False
            btnC.Enabled = False
            btnD.Enabled = False
            btnNext.Enabled = False
            MessageBox.Show("Your position is a" & " " & name)
        End If

        Select Case questionCounter
            Case 1
                picBox1.Image = My.Resources.anthonydavis_playerselected
            Case 2
                picBox1.Image = My.Resources.blakegriffin_playerselected
            Case 3
                picBox1.Image = My.Resources.chrispaul_playerselected
            Case 4
                picBox1.Image = My.Resources.demarcuscousins_playerselected
            Case 5
                picBox1.Image = My.Resources.draymondgreen_playerselected
            Case 6
                picBox1.Image = My.Resources.jamesharden_playerseleted
            Case 7
                picBox1.Image = My.Resources.jimmybutler_playerselected
            Case 8
                picBox1.Image = My.Resources.TallMen
        End Select
        questionCounter += 1
    End Sub
    Function GetData()
        Dim QuestionsFile As StreamReader
        Dim questionsData(0) As String
        Dim filePath = "positionquestions.txt"
        Dim readLineString As String
        If File.Exists(filePath) Then
            QuestionsFile = My.Computer.FileSystem.OpenTextFileReader(filePath)


            Dim count As Integer
            Do
                count += 1
                readLineString = QuestionsFile.ReadLine
                ReDim Preserve questionsData(questionsData.Length)
                questionsData(count) = readLineString
            Loop Until readLineString Is Nothing

            System.Console.WriteLine(questionsData)
            QuestionsFile.Close()
        Else
            MessageBox.Show("File does not exists!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return questionsData
    End Function
    Sub AnswerA()
        Select Case questionNumber
            Case 6
                pg += 1
            Case 11
                sf += 1
                pg += 1
            Case 16
                sf += 2
                pf += 1
            Case 21
                pg += 1
            Case 26
                sg += 1
                sf += 1
            Case 31
                sg += 2
            Case 36
                sg += 2
                sf += 1
            Case 41
                sg += 1
        End Select
        Call ButtonEnabling()
    End Sub
    Sub AnswerB()
        Select Case questionNumber
            Case 6
                sg += 1
            Case 11
                pg += 1
            Case 16
                ct += 2
                pf += 1
            Case 21
                sf += 1
                pf += 1
            Case 26
                ct += 1
                pf += 1
            Case 31
                ct += 2
                pf += 1
            Case 36
                sf += 1
                pf += 1
            Case 41
                ct += 1
                pf += 1
        End Select
        Call ButtonEnabling()
    End Sub
    Sub AnswerC()
        Select Case questionNumber

            Case 6
                pf += 1
                sf += 1
            Case 11
                sg += 1
            Case 16
                sg += 2
                pg += 1
            Case 21
                sg += 1
            Case 26
                pg += 1
                pf += 1
            Case 31
                pg += 2
            Case 36
                pg += 2
            Case 41
                pg += 1
        End Select
        Call ButtonEnabling()
    End Sub
    Sub AnswerD()
        Select Case questionNumber

            Case 6
                ct += 1
            Case 11
                pf += 1
                ct += 1
            Case 16
                pg += 1
            Case 21
                ct += 1
            Case 26
                pg += 1
            Case 31
                sf += 2
                pf += 1
            Case 36
                ct += 2
                pf += 1
            Case 41
                sg += 1
                pf += 1
        End Select
        Call ButtonEnabling()
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        btnA.BackColor = Color.FromArgb(207, 216, 220)
        Call AnswerA()
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        btnB.BackColor = Color.FromArgb(207, 216, 220)
        Call AnswerB()
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        btnC.BackColor = Color.FromArgb(207, 216, 220)
        Call AnswerC()
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        btnD.BackColor = Color.FromArgb(207, 216, 220)
        Call AnswerD()
    End Sub
    Sub ButtonEnabling()
        btnA.Enabled = False
        btnB.Enabled = False
        btnC.Enabled = False
        btnD.Enabled = False
        btnNext.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmMainTegh1.Show()
        Me.Close()
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub
End Class
