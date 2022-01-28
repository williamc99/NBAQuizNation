'*******************************************************
' FORM	        :	frmWilliamSnapshotResult
'  
' OUTLINE		:	This form has one video player and a button.  The user is prompted
'                   to click on the play button, where it will show the video for the respective
'                   question.  Upon clicking "Next", it will hide the form and show the 
'                   question form.  
' 
' PROGRAMMER	:	William Chiu
'
'  DATE		    :	December 20, 2018
' ******************************************************

Public Class frmWilliamSnapshotResult
    Public answerString As String
    Dim questionNumber As Integer = 1

    Private Sub btnNext_Click_1(sender As Object, e As EventArgs) Handles btnNext.Click
        frmWilliamSnapshotQuestion.Show()
        Me.Hide()
        questionNumber += 5
        wmpPlayer.Ctlcontrols.stop()
        If questionNumber = 26 Then
            MessageBox.Show("Thank you for taking the Snapshot Quiz!  You got " & frmWilliamSnapshotQuestion.correctCount & " right out of 5!  Please click 'Main Menu' to return to the home screen.", "RESULTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub wmpPlayer_Enter(sender As Object, e As EventArgs) Handles wmpPlayer.Enter

        Dim appPath As String = Application.StartupPath()
        Select Case frmWilliamSnapshotQuestion.player

            Case frmWilliamSnapshotQuestion.playersArray(0) 'Chris Paul
                Select Case questionNumber
                    Case 1
                        wmpPlayer.URL = appPath & "\chrispaulvideo1.mp4"
                    Case 6
                        wmpPlayer.URL = appPath & "\chrispaulvideo2.mp4"
                    Case 11
                        wmpPlayer.URL = appPath & "\chrispaulvideo3.mp4"
                    Case 16
                        wmpPlayer.URL = appPath & "\chrispaulvideo4.mp4"
                    Case 21
                        wmpPlayer.URL = appPath & "\chrispaulvideo5.mp4"
                End Select

            Case frmWilliamSnapshotQuestion.playersArray(1) 'Steph Curry
                Select Case questionNumber
                    Case 1
                        wmpPlayer.URL = appPath & "\stephencurryvideo1.mp4"
                    Case 6
                        wmpPlayer.URL = appPath & "\stephencurryvideo2.mp4"
                    Case 11
                        wmpPlayer.URL = appPath & "\stephencurryvideo3.mp4"
                    Case 16
                        wmpPlayer.URL = appPath & "\stephencurryvideo4.mp4"
                    Case 21
                        wmpPlayer.URL = appPath & "\stephencurryvideo5.mp4"
                End Select

            Case frmWilliamSnapshotQuestion.playersArray(2) 'Jrue Holiday
                Select Case questionNumber
                    Case 1
                        wmpPlayer.URL = appPath & "\jrueholidayvideo1.mp4"
                    Case 6
                        wmpPlayer.URL = appPath & "\jrueholidayvideo2.mp4"
                    Case 11
                        wmpPlayer.URL = appPath & "\jrueholidayvideo3.mp4"
                    Case 16
                        wmpPlayer.URL = appPath & "\jrueholidayvideo4.mp4"
                    Case 21
                        wmpPlayer.URL = appPath & "\jrueholidayvideo5.mp4"
                End Select

            Case frmWilliamSnapshotQuestion.playersArray(3) 'James Harden
                Select Case questionNumber
                    Case 1
                        wmpPlayer.URL = appPath & "\jameshardenvideo1.mp4"
                    Case 6
                        wmpPlayer.URL = appPath & "\jameshardenvideo2.mp4"
                    Case 11
                        wmpPlayer.URL = appPath & "\jameshardenvideo3.mp4"
                    Case 16
                        wmpPlayer.URL = appPath & "\jameshardenvideo4.mp4"
                    Case 21
                        wmpPlayer.URL = appPath & "\jameshardenvideo5.mp4"
                End Select

            Case frmWilliamSnapshotQuestion.playersArray(4) 'Jimmy Butler
                Select Case questionNumber
                    Case 1
                        wmpPlayer.URL = appPath & "\jimmybutlervideo1.mp4"
                    Case 6
                        wmpPlayer.URL = appPath & "\jimmybutlervideo2.mp4"
                    Case 11
                        wmpPlayer.URL = appPath & "\jimmybutlervideo3.mp4"
                    Case 16
                        wmpPlayer.URL = appPath & "\jimmybutlervideo4.mp4"
                    Case 21
                        wmpPlayer.URL = appPath & "\jimmybutlervideo5.mp4"
                End Select

            Case frmWilliamSnapshotQuestion.playersArray(5) 'Klay Thompson
                Select Case questionNumber
                    Case 1
                        wmpPlayer.URL = appPath & "\klaythompsonvideo1.mp4"
                    Case 6
                        wmpPlayer.URL = appPath & "\klaythompsonvideo2.mp4"
                    Case 11
                        wmpPlayer.URL = appPath & "\klaythompsonvideo3.mp4"
                    Case 16
                        wmpPlayer.URL = appPath & "\klaythompsonvideo4.mp4"
                    Case 21
                        wmpPlayer.URL = appPath & "\klaythompsonvideo5.mp4"
                End Select

            Case frmWilliamSnapshotQuestion.playersArray(6) 'LeBron James

                Select Case questionNumber
                    Case 1
                        wmpPlayer.URL = appPath & "\lebronjamesvideo1.mp4"
                    Case 6
                        wmpPlayer.URL = appPath & "\lebronjamesvideo2.mp4"
                    Case 11
                        wmpPlayer.URL = appPath & "\lebronjamesvideo3.mp4"
                    Case 16
                        wmpPlayer.URL = appPath & "\lebronjamesvideo4.mp4"
                    Case 21
                        wmpPlayer.URL = appPath & "\lebronjamesvideo5.mp4"
                End Select

            Case frmWilliamSnapshotQuestion.playersArray(7) 'Kawhi Leonard
                Select Case questionNumber
                    Case 1
                        wmpPlayer.URL = appPath & "\kawhileonardvideo1.mp4"
                    Case 6
                        wmpPlayer.URL = appPath & "\kawhileonardvideo2.mp4"
                    Case 11
                        wmpPlayer.URL = appPath & "\kawhileonardvideo3.mp4"
                    Case 16
                        wmpPlayer.URL = appPath & "\kawhileonardvideo4.mp4"
                    Case 21
                        wmpPlayer.URL = appPath & "\kawhileonardvideo5.mp4"
                End Select

            Case frmWilliamSnapshotQuestion.playersArray(8) 'Kevin Durant
                Select Case questionNumber
                    Case 1
                        wmpPlayer.URL = appPath & "\kevindurantvideo1.mp4"
                    Case 6
                        wmpPlayer.URL = appPath & "\kevindurantvideo2.mp4"
                    Case 11
                        wmpPlayer.URL = appPath & "\kevindurantvideo3.mp4"
                    Case 16
                        wmpPlayer.URL = appPath & "\kevindurantvideo4.mp4"
                    Case 21
                        wmpPlayer.URL = appPath & "\kevindurantvideo5.mp4"
                End Select

            Case frmWilliamSnapshotQuestion.playersArray(9) 'Anthony Davis
                Select Case questionNumber
                    Case 1
                        wmpPlayer.URL = appPath & "\anthonydavisvideo1.mp4"
                    Case 6
                        wmpPlayer.URL = appPath & "\anthonydavisvideo2.mp4"
                    Case 11
                        wmpPlayer.URL = appPath & "\anthonydavisvideo3.mp4"
                    Case 16
                        wmpPlayer.URL = appPath & "\anthonydavisvideo4.mp4"
                    Case 21
                        wmpPlayer.URL = appPath & "\anthonydavisvideo5.mp4"
                End Select

            Case frmWilliamSnapshotQuestion.playersArray(10) 'Draymond Green
                Select Case questionNumber
                    Case 1
                        wmpPlayer.URL = appPath & "\draymondgreenvideo1.mp4"
                    Case 6
                        wmpPlayer.URL = appPath & "\draymondgreenvideo2.mp4"
                    Case 11
                        wmpPlayer.URL = appPath & "\draymondgreenvideo3.mp4"
                    Case 16
                        wmpPlayer.URL = appPath & "\draymondgreenvideo4.mp4"
                    Case 21
                        wmpPlayer.URL = appPath & "\draymondgreenvideo5.mp4"
                End Select

            Case frmWilliamSnapshotQuestion.playersArray(11) 'Blake Griffin
                Select Case questionNumber
                    Case 1
                        wmpPlayer.URL = appPath & "\blakegriffinvideo1.mp4"
                    Case 6
                        wmpPlayer.URL = appPath & "\blakegriffinvideo2.mp4"
                    Case 11
                        wmpPlayer.URL = appPath & "\blakegriffinvideo3.mp4"
                    Case 16
                        wmpPlayer.URL = appPath & "\blakegriffinvideo4.mp4"
                    Case 21
                        wmpPlayer.URL = appPath & "\blakegriffinvideo5.mp4"
                End Select

            Case frmWilliamSnapshotQuestion.playersArray(12) 'DeMarcus Cousins
                Select Case questionNumber
                    Case 1
                        wmpPlayer.URL = appPath & "\demarcuscousinsvideo1.mp4"
                    Case 6
                        wmpPlayer.URL = appPath & "\demarcuscousinsvideo2.mp4"
                    Case 11
                        wmpPlayer.URL = appPath & "\demarcuscousinsvideo3.mp4"
                    Case 16
                        wmpPlayer.URL = appPath & "\demarcuscousinsvideo4.mp4"
                    Case 21
                        wmpPlayer.URL = appPath & "\demarcuscousinsvideo5.mp4"
                End Select

            Case frmWilliamSnapshotQuestion.playersArray(13) 'Nikola Jokic
                Select Case questionNumber
                    Case 1
                        wmpPlayer.URL = appPath & "\nikolajokicvideo1.mp4"
                    Case 6
                        wmpPlayer.URL = appPath & "\nikolajokicvideo2.mp4"
                    Case 11
                        wmpPlayer.URL = appPath & "\nikolajokicvideo3.mp4"
                    Case 16
                        wmpPlayer.URL = appPath & "\nikolajokicvideo4.mp4"
                    Case 21
                        wmpPlayer.URL = appPath & "\nikolajokicvideo5.mp4"
                End Select

            Case frmWilliamSnapshotQuestion.playersArray(14) 'Karl-Anthony Towns
                Select Case questionNumber
                    Case 1
                        wmpPlayer.URL = appPath & "\karlanthonytownsvideo1.mp4"
                    Case 6
                        wmpPlayer.URL = appPath & "\karlanthonytownsvideo2.mp4"
                    Case 11
                        wmpPlayer.URL = appPath & "\karlanthonytownsvideo3.mp4"
                    Case 16
                        wmpPlayer.URL = appPath & "\karlanthonytownsvideo4.mp4"
                    Case 21
                        wmpPlayer.URL = appPath & "\karlanthonytownsvideo5.mp4"
                End Select
        End Select
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Hide()
    End Sub

    Public Sub btnCorrectAnswer_Click(sender As Object, e As EventArgs) Handles btnCorrectAnswer.Click
        btnCorrectAnswer.Text = answerString
    End Sub
End Class