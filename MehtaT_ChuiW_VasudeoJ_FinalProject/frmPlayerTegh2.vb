'*******************************************************
' FORM  	    :	frmPlayerTegh2 - What NBA Player Are You?
'  
' OUTLINE		:	This form asks the user several questions 				
'                   and uses an algorithm to determine which 				
'                   NBA Player they are. They direct the results 
'      				to the results gamemode.
' 
' PROGRAMMER	:	Tegh Mehta
'
'  DATE		    :	December 14, 2018
' ******************************************************

Imports System.IO

Public Class frmPlayerTegh2
    Private questionNumber As Integer = 1
    Private playersArray(,) As String = {
        {"Chris Paul", "0"}, {"Steph Curry", "0"}, {"Jrue Holiday", "0"},
        {"James Harden", "0"}, {"Jimmy Butler", "0"}, {"Klay Thompson", "0"},
        {"Lebron James", "0"}, {"Kawhi Leonard", "0"}, {"Kevin Durant", "0"},
        {"Anthony Davis", "0"}, {"Draymond Green", "0"}, {"Blake Griffin", "0"},
        {"Demarcus Cousins", "0"}, {"Nikola Jokic", "0"}, {"Karl-Anthony Towns", "0"}}



    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        FormulateQuestion()
    End Sub

    'This Sub Shows the Picture, Question and Answers
    Sub FormulateQuestion()
        Dim questionsData() As String = GetData()

        If questionNumber < 61 Then
            lblQuestion.Text = questionsData(questionNumber)
            btnAnswer1.Text = questionsData(questionNumber + 1)
            btnAnswer2.Text = questionsData(questionNumber + 2)
            btnAnswer3.Text = questionsData(questionNumber + 3)
            btnAnswer4.Text = questionsData(questionNumber + 4)

            Select Case questionNumber
                Case 1
                    picPlayer.Image = My.Resources.kawhiraptors
                Case 6
                    picPlayer.Image = My.Resources.boban
                Case 11
                    picPlayer.Image = My.Resources.hardenmad
                Case 16
                    picPlayer.Image = My.Resources.kdclutch
                Case 21
                    picPlayer.Image = My.Resources.curryshot
                Case 26
                    picPlayer.Image = My.Resources.joelembiidtrashtalk
                Case 31
                    picPlayer.Image = My.Resources.knicksbench
                Case 36
                    picPlayer.Image = My.Resources.MJ
                Case 41
                    picPlayer.Image = My.Resources.boogiecousins
                Case 46
                    picPlayer.Image = My.Resources.dfox
                Case 51
                    picPlayer.Image = My.Resources.blakegriffindunk
                Case 56
                    picPlayer.Image = My.Resources.gswchampionship
            End Select

            btnStart.Text = "Next"
            btnStart.Enabled = False
            btnAnswer1.Enabled = True
            btnAnswer2.Enabled = True
            btnAnswer3.Enabled = True
            btnAnswer4.Enabled = True

            questionNumber += 5
        Else
            ShowPlayer()
        End If
    End Sub

    'This sub displays which NBA Players you are most like.
    Sub ShowPlayer()
        Dim playersCombined(14) As String
        For count = 0 To 14
            playersCombined(count) = playersArray(count, 1) & "$" & playersArray(count, 0)
        Next
        playersCombined = playersCombined.OrderByDescending(Function(q) Int32.Parse(q.Split("$").First)).ToArray()
        Dim sortedPlayersArr(playersCombined.Length - 1, 1) As String
        For count As Integer = 0 To playersCombined.Length - 1
            sortedPlayersArr(count, 0) = playersCombined(count).Split("$")(1)
            sortedPlayersArr(count, 1) = playersCombined(count).Split("$")(0)
        Next
        frmPlayerResultsTegh3.Tag = sortedPlayersArr
        frmPlayerResultsTegh3.Show()
        Me.Close()
    End Sub

    'This Function gets the questions and answers from a file and returns it in an array.
    Function GetData()
        Dim playerQuestionsFile As StreamReader
        Dim questionsData(0) As String
        Dim filePath = "playerquestions.txt"
        If File.Exists(filePath) Then
            playerQuestionsFile = My.Computer.FileSystem.OpenTextFileReader(filePath)

            Dim readLineString As String
            Dim count As Integer
            Do
                count += 1
                readLineString = playerQuestionsFile.ReadLine
                ReDim Preserve questionsData(questionsData.Length)
                questionsData(count) = readLineString
            Loop Until readLineString Is Nothing

            System.Console.WriteLine(questionsData)
            playerQuestionsFile.Close()
        Else
            MessageBox.Show("File does not exists!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return questionsData
    End Function

    'This sub is the core of the algorithm. It take in user input and calculates which NBA Player you are most like on each click.
    Sub ClickAnswer(answer As Integer)
        Select Case questionNumber
            Case 6
                Select Case answer
                    Case 1
                        AddToPlayer({1, 5, 8, 10, 12})
                    Case 2
                        AddToPlayer({7, 9})
                    Case 3
                        AddToPlayer({6, 6, 0, 3, 11})
                    Case 4
                        AddToPlayer({2, 4, 13})
                End Select
            Case 11
                Select Case answer
                    Case 1
                        AddToPlayer({0, 1, 2})
                        RemoveFromPlayer({3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14})
                        RemoveFromPlayer({3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14})
                    Case 2
                        AddToPlayer({3, 4, 5})
                        RemoveFromPlayer({0, 1, 2, 6, 7, 8, 9, 10, 11, 12, 13, 14})
                        RemoveFromPlayer({0, 1, 2, 6, 7, 8, 9, 10, 11, 12, 13, 14})
                    Case 3
                        AddToPlayer({6, 7, 8, 10})
                        RemoveFromPlayer({0, 1, 2, 3, 4, 5, 9, 11, 12, 13, 14})
                        RemoveFromPlayer({0, 1, 2, 3, 4, 5, 9, 11, 12, 13, 14})
                    Case 4
                        AddToPlayer({9, 11, 12, 13, 14})
                        RemoveFromPlayer({0, 1, 2, 3, 4, 5, 6, 7, 8, 10})
                        RemoveFromPlayer({0, 1, 2, 3, 4, 5, 6, 7, 8, 10})
                End Select
            Case 16
                Select Case answer
                    Case 1
                        AddToPlayer({4, 9, 10, 12})
                    Case 2
                        AddToPlayer({7, 14})
                    Case 3
                        AddToPlayer({11, 6})
                    Case 4
                        AddToPlayer({0, 8, 1, 13})
                End Select
            Case 21
                Select Case answer
                    Case 1
                        AddToPlayer({14, 2, 10})
                    Case 2
                        AddToPlayer({3, 3, 0})
                    Case 3
                        AddToPlayer({12, 9})
                    Case 4
                        AddToPlayer({5, 5, 1, 1, 8, 8, 7})
                End Select
            Case 26
                Select Case answer
                    Case 1
                        AddToPlayer({6, 9, 12, 4})
                    Case 2
                        AddToPlayer({5, 5, 1, 1, 8, 8})
                    Case 3
                        AddToPlayer({0, 3, 7})
                    Case 4
                        AddToPlayer({10, 14, 11})
                End Select
            Case 31
                Select Case answer
                    Case 1
                        AddToPlayer({4, 4, 10, 12})
                    Case 2
                        AddToPlayer({7, 5, 13})
                    Case 3
                        AddToPlayer({1, 3})
                    Case 4
                        AddToPlayer({8, 8, 14, 14})
                End Select
            Case 36
                Select Case answer
                    Case 1
                        RemoveFromPlayer({6, 6, 1, 1, 8, 8, 4, 4, 3})
                    Case 2
                        AddToPlayer({1, 13, 11})
                    Case 3
                        AddToPlayer({14, 14, 14})
                    Case 4
                        AddToPlayer({4, 4, 4, 10, 10, 12, 12, 12, 6})
                End Select
            Case 41
                Select Case answer
                    Case 1
                        AddToPlayer({8, 9, 12})
                    Case 2
                        AddToPlayer({6, 3, 0, 1})
                    Case 3
                        AddToPlayer({2, 10})
                    Case 4
                        AddToPlayer({14})
                        RemoveFromPlayer({6, 3, 0, 1, 8, 9, 12})
                End Select
            Case 46
                Select Case answer
                    Case 1
                        AddToPlayer({6, 8, 3})
                    Case 2
                        AddToPlayer({14, 11, 7, 5, 5})
                    Case 3
                        AddToPlayer({0, 0, 10, 13})
                    Case 4
                        AddToPlayer({9, 9, 10, 12})
                End Select
            Case 51
                Select Case answer
                    Case 1
                        AddToPlayer({1, 5, 3})
                    Case 2
                        AddToPlayer({10, 2, 7})
                    Case 3
                        AddToPlayer({9, 12, 14})
                    Case 4
                        AddToPlayer({0, 0, 6, 13, 13})
                End Select
            Case 56
                Select Case answer
                    Case 1
                        AddToPlayer({6, 11, 11, 14})
                    Case 2
                        AddToPlayer({2, 1, 3, 3})
                    Case 3
                        AddToPlayer({0, 0, 13, 13, 12})
                    Case 4
                        AddToPlayer({7, 9, 9, 10})
                End Select
            Case 61
                Select Case answer
                    Case 1
                        AddToPlayer({11, 11, 8})
                    Case 2
                        AddToPlayer({11, 12})
                    Case 3
                        AddToPlayer({4, 4, 6, 0})
                    Case 4
                        AddToPlayer({7, 1, 10})
                End Select
        End Select


        Console.Write(playersArray)

        btnAnswer1.Enabled = False
        btnAnswer2.Enabled = False
        btnAnswer3.Enabled = False
        btnAnswer4.Enabled = False
        btnStart.Enabled = True
    End Sub

    'This sub increments items in the playerCountArray based on the array that was passed in.
    Sub AddToPlayer(playerIndexArray() As Integer)
        For Each player In playerIndexArray
            playersArray(player, 1) += 1
        Next
    End Sub

    'This sub deincrements items in the playerCountArray based on the array that was passed in.
    Sub RemoveFromPlayer(playerIndexArray() As Integer)
        For Each player In playerIndexArray
            playersArray(player, 1) -= 1
        Next
    End Sub

    Private Sub btnAnswer1_Click(sender As Object, e As EventArgs) Handles btnAnswer1.Click
        ClickAnswer(1)
    End Sub

    Private Sub btnAnswer2_Click(sender As Object, e As EventArgs) Handles btnAnswer2.Click
        ClickAnswer(2)
    End Sub

    Private Sub btnAnswer3_Click(sender As Object, e As EventArgs) Handles btnAnswer3.Click
        ClickAnswer(3)
    End Sub

    Private Sub btnAnswer4_Click(sender As Object, e As EventArgs) Handles btnAnswer4.Click
        ClickAnswer(4)
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        frmMainTegh1.Show()
        Me.Close()
    End Sub
End Class