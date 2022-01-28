
Imports System.IO
Public Class frmJeetPosition
    Private questionNumber As Integer = 1
    Private Sg As Integer
    Private Pg As Integer
    Private Sf As Integer
    Private Pf As Integer
    Private C As Integer
    Private QuestionCounter As Integer = 1
    'Dim name As String = "SG"
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
        Dim max As Integer = Sg

        If questionNumber < 41 Then
            lblQuestion.Text = questionsData(questionNumber)
            btnA.Text = questionsData(questionNumber + 1)
            btnB.Text = questionsData(questionNumber + 2)
            btnC.Text = questionsData(questionNumber + 3)
            btnD.Text = questionsData(questionNumber + 4)
            questionNumber += 5
        Else
            If Sg > max Then
                max = Sg
                Name = "SG"
                Sg = 0

            End If
            If Pg > max Then
                max = Pg
                Name = "PG"
                Sg = 0
                Pg = 0
            End If
            If Sf > max Then
                max = Sf
                Name = "SF"

                Sf = 0
            End If
            If Pf > max Then
                max = Pf
                Name = "PF"

                Pf = 0
            End If
            If C > max Then
                max = C
                Name = "C"
                C = 0
            End If
            If max = Pg Or max = Sf Or max = Pf Or max = C Or max = Sg Then
                If Pg >= max Then
                    max = Pg
                    Name &= "and/or" & " " & "PG"

                End If
                If Sf >= max Then
                    max = Sf
                    Name &= "and/or" & " " & "SF"

                End If
                If Pf >= max Then
                    max = Pf
                    Name &= "and/or" & " " & "PF"

                End If
                If C >= max Then
                    max = C
                    Name &= "and/or" & " " & "C"

                End If
            End If
            btnA.Enabled = False
            btnB.Enabled = False
            btnC.Enabled = False
            btnD.Enabled = False
            btnNext.Enabled = False
            MessageBox.Show("Your position is a" & " " & Name)
        End If

        Select Case QuestionCounter
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
        QuestionCounter += 1
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
                Pg += 1
            Case 11
                Sf += 1
                Pg += 1
            Case 16
                Sf += 2
                Pf += 1
            Case 21
                Pg += 1
            Case 26
                Sg += 1
                Sf += 1
            Case 31
                Sg += 2
            Case 36
                Sg += 2
                Sf += 1
            Case 41
                Sg += 1
        End Select
        Call ButtonEnabling()
    End Sub
    Sub AnswerB()
        Select Case questionNumber
            Case 6
                Sg += 1
            Case 11
                Pg += 1
            Case 16
                C += 2
                Pf += 1
            Case 21
                Sf += 1
                Pf += 1
            Case 26
                C += 1
                Pf += 1
            Case 31
                C += 2
                Pf += 1
            Case 36
                Sf += 1
                Pf += 1
            Case 41
                C += 1
                Pf += 1
        End Select
        Call ButtonEnabling()
    End Sub
    Sub AnswerC()
        Select Case questionNumber

            Case 6
                Pf += 1
                Sf += 1
            Case 11
                Sg += 1
            Case 16
                Sg += 2
                Pg += 1
            Case 21
                Sg += 1
            Case 26
                Pg += 1
                Pf += 1
            Case 31
                Pg += 2
            Case 36
                Pg += 2
            Case 41
                Pg += 1
        End Select
        Call ButtonEnabling()
    End Sub
    Sub AnswerD()
        Select Case questionNumber

            Case 6
                C += 1
            Case 11
                Pf += 1
                C += 1
            Case 16
                Pg += 1
            Case 21
                C += 1
            Case 26
                Pg += 1
            Case 31
                Sf += 2
                Pf += 1
            Case 36
                C += 2
                Pf += 1
            Case 41
                Sg += 1
                Pf += 1
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
