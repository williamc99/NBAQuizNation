'*******************************************************
' FORM	        :	frmWilliamSnapshot
'  
' OUTLINE		:	This form will select a series of questions depending 
'                   on what player you got in the previous quiz.  The form will 
'                   show 5 pictures, with 4 prediction choices for each.  It will then show 
'                   videos for the respective pictures.  At the end, it will give a score out of 5,
'                   showing how many questions the user got right.  It will then show a message box
'                   telling the user to return to the main menu.
'
' PROGRAMMER	:	William Chiu
'
'  DATE		    :	December 20, 2018
' ******************************************************

Imports System.IO
Public Class frmWilliamSnapshotQuestion
    Public player = "Stephen Curry"
    Dim answerChecked As Boolean
    Public correctCount As Integer
    Public questionNumber As Integer = 1
    Public playersArray() As String = {
        "Chris Paul", "Stephen Curry", "Jrue Holiday",
        "James Harden", "Jimmy Butler", "Klay Thompson",
        "Lebron James", "Kawhi Leonard", "Kevin Durant",
        "Anthony Davis", "Draymond Green", "Blake Griffin",
        "Demarcus Cousins", "Nikola Jokic", "Karl-Anthony Towns"}

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        FormulateQuestions()
    End Sub

    Private Sub btnAnswer1_Click(sender As Object, e As EventArgs) Handles btnAnswer1.Click, btnAnswer2.Click, btnAnswer3.Click, btnAnswer4.Click
        Dim buttonArray() As Button = {btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4}
        Dim btnSender As Button = sender
        Dim buttonIndex As Integer
        Dim answerArray() As String = {
            "Break ankles and Shoot", "Put the ball through Defenders legs and Layup", "Drive in and hit a tough layup", "Hit a turning three pointer", "Hold the ball", 'Chris Paul answers
            "Pass through his own legs to teammate", "Break the defender’s ankles and just stare at him", "Nail a 30 feet 3 pointer", "Shoot a deep 3 pointer and get blocked", "Cross out the defenders and hit a tough layup", 'James Harden answers
            "Dribble through his teammates legs and drive in", "Jump over the defender to catch an alley oop", "Turn around and hit a fadeaway 3", "Flop into the audience", "Sprint in for a block off the glass", 'LeBron James answers
            "Turn around and block a dunk", "Run into opponent and start a fight", "Catch the ball and throw a full court pass", "Kick the defender in the nuts", "Catch a quick pass and posterize", 'Draymond Green answers
            "Overpower both of them and dunk it", "Continue running and slam it down with full power", "Proceed to fight a chair", "Defender gets in his way and he throws him down", "Miss the shot and not allow teammates to shake hand", 'DeMarcus Cousins answers
            "Make the game winning jump shot pointer", "Jrue throws down the dunk on Lebron", "He loses the ball mid-air", "Drops Knight and nails the shot", "Jrue comes up with a clutch block to save the game", ' Jrue Holiday Answers
            "Karl sends the ball into the stands", "Towns secures the rebound to seal the win", "Towns airballs the three and asks the coach to bench him", "Pop for a three", "Runs into the opposing player and slowly falls to the ground", ' Karl Anthony-Towns Answers
            "Blake kicks Davis nearly injuring him", "Attempts to Jump and slaps the ball out of hands but misses", "Bounce passes an alley-oop to Davis", "Davis does not dunk", "Catch a lob and dunk",' Anthony Davis Answers
            "Blake kicks Davis nearly injuring him", "Make the game winning 3", "Posterize (Dunk on) Kendrick Perkins", "Dunk all over Embiid", "Drive, make the layup and foul to win the game", ' Blake Griffin Answers
            "Makes a stepback three-pointer", "Catches the lob and dunks on Chris Bosh", "He falls off and gets soaked", "Jimmy blocks the ball hard", "He bumps into Butler and they fight", ' Jimmy Butler Answers
            "Argue with the ref and get ejected", "Run in and dunk on everyone", "Push them with all your power", "Bump heads with the defender closest to you", "Accept it and play it cool", 'Kevin Durant Answers
            "Shoot the ball", "Simple layup", "Move around and stick to the player he was guarding", "Get the fan ejected", "Shooting the ball", 'Klay Thompson Answers
            "He is excited to be a part of the new team", "Dunk on them", "‘97 Chevy Tahoe", "Go in and dunk the ball", "Shoots the ball from the 3 pt line", ' Kawhi Leonard Answers
            "Passes it behind the back to a teammate", "Blind pass it backwards for an alley oop", "A no look assist", "Shoot a 3 pt despite being a center", "Remove his anger by shooting a crazy shot that has no chance of going in", 'Nikola Jokic Answers
            "Fade back and shoot", "The shot goes in", "Block him?", "Gives up and sleeps on the floor", "Gets crossed out and shot on?" 'Stephen Curry Answers
       }

        For index = 0 To 3
            If answerArray.Contains(buttonArray(index).Text) Then
                buttonIndex = index
            End If
            buttonArray(index).FlatAppearance.BorderColor = Color.Red
        Next

        frmWilliamSnapshotResult.btnCorrectAnswer.Text = buttonArray(buttonIndex).Text
        buttonArray(buttonIndex).FlatAppearance.BorderColor = Color.Green

        If answerArray.Contains(btnSender.Text) Then
            correctCount += 1
        End If

        btnSender.ForeColor = Color.Red
        btnAnswer1.Enabled = False
        btnAnswer2.Enabled = False
        btnAnswer3.Enabled = False
        btnAnswer4.Enabled = False
        btnStart.Enabled = True
        answerChecked = True
    End Sub

    'This function will read which player is chosen and display the appropriate image
    Function GetPlayerQuestions()

        Dim playerQuestions(4) As String

        Select Case player
            Case playersArray(0)
                playerQuestions = GetFileQuestions("chrispaul.txt")
                Select Case questionNumber
                    Case 1
                        picSnapshot.Image = My.Resources.chrispaulimage1
                    Case 6
                        picSnapshot.Image = My.Resources.chrispaulimage2
                    Case 11
                        picSnapshot.Image = My.Resources.chrispaulimage3
                    Case 16
                        picSnapshot.Image = My.Resources.chrispaulimage4
                    Case 21
                        picSnapshot.Image = My.Resources.chrispaulimage5
                End Select
            Case playersArray(1)
                playerQuestions = GetFileQuestions("stephencurry.txt")
                Select Case questionNumber
                    Case 1
                        picSnapshot.Image = My.Resources.stephencurryimage1
                    Case 6
                        picSnapshot.Image = My.Resources.stephencurryimage2
                    Case 11
                        picSnapshot.Image = My.Resources.stephencurryimage3
                    Case 16
                        picSnapshot.Image = My.Resources.stephencurryimage4
                    Case 21
                        picSnapshot.Image = My.Resources.stephencurryimage5
                End Select
            Case playersArray(2)
                playerQuestions = GetFileQuestions("jrueholiday.txt")
                Select Case questionNumber
                    Case 1
                        picSnapshot.Image = My.Resources.jrueholidayimage1
                    Case 6
                        picSnapshot.Image = My.Resources.jrueholidayimage2
                    Case 11
                        picSnapshot.Image = My.Resources.jrueholidayimage3
                    Case 16
                        picSnapshot.Image = My.Resources.jrueholidayimage4
                    Case 21
                        picSnapshot.Image = My.Resources.jrueholidayimage5
                End Select
            Case playersArray(3)
                playerQuestions = GetFileQuestions("jamesharden.txt")
                Select Case questionNumber
                    Case 1
                        picSnapshot.Image = My.Resources.jameshardenimage1
                    Case 6
                        picSnapshot.Image = My.Resources.jameshardenimage2
                    Case 11
                        picSnapshot.Image = My.Resources.jameshardenimage3
                    Case 16
                        picSnapshot.Image = My.Resources.jameshardenimage4
                    Case 21
                        picSnapshot.Image = My.Resources.jameshardenimage5
                End Select
            Case playersArray(4)
                playerQuestions = GetFileQuestions("jimmybutler.txt")
                Select Case questionNumber
                    Case 1
                        picSnapshot.Image = My.Resources.jimmybutlerimage1
                    Case 6
                        picSnapshot.Image = My.Resources.jimmybutlerimage2
                    Case 11
                        picSnapshot.Image = My.Resources.jimmybutlerimage3
                    Case 16
                        picSnapshot.Image = My.Resources.jimmybutlerimage4
                    Case 21
                        picSnapshot.Image = My.Resources.jimmybutlerimage5
                End Select
            Case playersArray(5)
                playerQuestions = GetFileQuestions("klaythompson.txt")
                Select Case questionNumber
                    Case 1
                        picSnapshot.Image = My.Resources.klaythompsonimage1
                    Case 6
                        picSnapshot.Image = My.Resources.klaythompsonimage2
                    Case 11
                        picSnapshot.Image = My.Resources.klaythompsonimage3
                    Case 16
                        picSnapshot.Image = My.Resources.klaythompsonimage4
                    Case 21
                        picSnapshot.Image = My.Resources.klaythompsonimage5
                End Select
            Case playersArray(6)
                playerQuestions = GetFileQuestions("lebronjames.txt")
                Select Case questionNumber
                    Case 1
                        picSnapshot.Image = My.Resources.lebronjamesimage1
                    Case 6
                        picSnapshot.Image = My.Resources.lebronjamesimage2
                    Case 11
                        picSnapshot.Image = My.Resources.lebronjamesimage3
                    Case 16
                        picSnapshot.Image = My.Resources.lebronjamesimage4
                    Case 21
                        picSnapshot.Image = My.Resources.lebronjamesimage5
                End Select
            Case playersArray(7)
                playerQuestions = GetFileQuestions("kawhileonard.txt")
                Select Case questionNumber
                    Case 1
                        picSnapshot.Image = My.Resources.kawhileonardimage1
                    Case 6
                        picSnapshot.Image = My.Resources.kawhileonardimage2
                    Case 11
                        picSnapshot.Image = My.Resources.kawhileonardimage3
                    Case 16
                        picSnapshot.Image = My.Resources.kawhileonardimage4
                    Case 21
                        picSnapshot.Image = My.Resources.kawhileonardimage5
                End Select
            Case playersArray(8)
                playerQuestions = GetFileQuestions("kevindurant.txt")
                Select Case questionNumber
                    Case 1
                        picSnapshot.Image = My.Resources.kevindurantimage1
                    Case 6
                        picSnapshot.Image = My.Resources.kevindurantimage2
                    Case 11
                        picSnapshot.Image = My.Resources.kevindurantimage3
                    Case 16
                        picSnapshot.Image = My.Resources.kevindurantimage4
                    Case 21
                        picSnapshot.Image = My.Resources.kevindurantimage5
                End Select
            Case playersArray(9)
                playerQuestions = GetFileQuestions("anthonydavis.txt")
                Select Case questionNumber
                    Case 1
                        picSnapshot.Image = My.Resources.anthonydavisimage1
                    Case 6
                        picSnapshot.Image = My.Resources.anthonydavisimage2
                    Case 11
                        picSnapshot.Image = My.Resources.anthonydavisimage3
                    Case 16
                        picSnapshot.Image = My.Resources.anthonydavisimage4
                    Case 21
                        picSnapshot.Image = My.Resources.anthonydavisimage5
                End Select
            Case playersArray(10)
                playerQuestions = GetFileQuestions("draymondgreen.txt")
                Select Case questionNumber
                    Case 1
                        picSnapshot.Image = My.Resources.draymondgreenimage1
                    Case 6
                        picSnapshot.Image = My.Resources.draymondgreenimage2
                    Case 11
                        picSnapshot.Image = My.Resources.draymondgreenimage3
                    Case 16
                        picSnapshot.Image = My.Resources.draymondgreenimage4
                    Case 21
                        picSnapshot.Image = My.Resources.draymondgreenimage5
                End Select
            Case playersArray(11)
                playerQuestions = GetFileQuestions("blakegriffin.txt")
                Select Case questionNumber
                    Case 1
                        picSnapshot.Image = My.Resources.blakegriffinimage1
                    Case 6
                        picSnapshot.Image = My.Resources.blakegriffinimage2
                    Case 11
                        picSnapshot.Image = My.Resources.blakegriffinimage3
                    Case 16
                        picSnapshot.Image = My.Resources.blakegriffinimage4
                    Case 21
                        picSnapshot.Image = My.Resources.blakegriffinimage5
                End Select
            Case playersArray(12)
                playerQuestions = GetFileQuestions("demarcuscousins.txt")
                Select Case questionNumber
                    Case 1
                        picSnapshot.Image = My.Resources.demarcuscousinsimage1
                    Case 6
                        picSnapshot.Image = My.Resources.demarcuscousinsimage2
                    Case 11
                        picSnapshot.Image = My.Resources.demarcuscousinsimage3
                    Case 16
                        picSnapshot.Image = My.Resources.demarcuscousinsimage4
                    Case 21
                        picSnapshot.Image = My.Resources.demarcuscousinsimage5
                End Select
            Case playersArray(13)
                playerQuestions = GetFileQuestions("nikolajokic.txt")
                Select Case questionNumber
                    Case 1
                        picSnapshot.Image = My.Resources.nikolajokicimage1
                    Case 6
                        picSnapshot.Image = My.Resources.nikolajokicimage2
                    Case 11
                        picSnapshot.Image = My.Resources.nikolajokicimage3
                    Case 16
                        picSnapshot.Image = My.Resources.nikolajokicimage4
                    Case 21
                        picSnapshot.Image = My.Resources.nikolajokicimage5
                End Select
            Case playersArray(14)
                playerQuestions = GetFileQuestions("karlanthonytowns.txt")
                Select Case questionNumber
                    Case 1
                        picSnapshot.Image = My.Resources.karlanthonytownsimage1
                    Case 6
                        picSnapshot.Image = My.Resources.karlanthonytownsimage2
                    Case 11
                        picSnapshot.Image = My.Resources.karlanthonytownsimage3
                    Case 16
                        picSnapshot.Image = My.Resources.karlanthonytownsimage4
                    Case 21
                        picSnapshot.Image = My.Resources.karlanthonytownsimage5
                End Select
        End Select
        Return playerQuestions
    End Function

    'This function will get all the questions from a file and put it in a string array
    Function GetFileQuestions(filePath As String)
        Dim snapshotQuestionsFile As StreamReader
        Dim snapshotQuestions(0) As String
        Dim fileQuestion As String
        Dim count As Integer


        If File.Exists(filePath) Then
            snapshotQuestionsFile = File.OpenText(filePath)

            Do
                count += 1
                fileQuestion = snapshotQuestionsFile.ReadLine
                ReDim Preserve snapshotQuestions(snapshotQuestions.Length)
                snapshotQuestions(count) = fileQuestion
            Loop Until fileQuestion = Nothing

            snapshotQuestionsFile.Close()
        Else
            MessageBox.Show("File (" & filePath & ") does not exist!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return snapshotQuestions
    End Function
    'This procedure will display the questions and reset the appearance of the buttons
    Sub FormulateQuestions()

        Dim playerQuestions() As String = GetPlayerQuestions()

        If questionNumber < 26 Then 'number of questions
            lblQuestion.Text = playerQuestions(questionNumber)
            btnAnswer1.Text = playerQuestions(questionNumber + 1)
            btnAnswer2.Text = playerQuestions(questionNumber + 2)
            btnAnswer3.Text = playerQuestions(questionNumber + 3)
            btnAnswer4.Text = playerQuestions(questionNumber + 4)


            btnStart.Text = "View Video"
            btnStart.Enabled = False
            btnAnswer1.Enabled = True
            btnAnswer1.FlatAppearance.BorderColor = Color.White
            btnAnswer1.ForeColor = Color.Black
            btnAnswer2.Enabled = True
            btnAnswer2.FlatAppearance.BorderColor = Color.White
            btnAnswer2.ForeColor = Color.Black
            btnAnswer3.Enabled = True
            btnAnswer3.FlatAppearance.BorderColor = Color.White
            btnAnswer3.ForeColor = Color.Black
            btnAnswer4.Enabled = True
            btnAnswer4.FlatAppearance.BorderColor = Color.White
            btnAnswer4.ForeColor = Color.Black

            If answerChecked = True Then
                frmWilliamSnapshotResult.Show()
                Me.Hide()
                answerChecked = False
            End If

            questionNumber += 5
        Else
            frmWilliamSnapshotResult.Show()
            Me.Hide()
            btnStart.Enabled = False
        End If
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        frmMainTegh1.Show()
        Me.Close()
    End Sub
End Class

