'*******************************************************
' FORM  	    :	frmPlayerResultsTegh3 - Results
'  
' OUTLINE		:	This form show the user their results
'                   from the last gamemode and directs them 					
'                   to the Snapshot! gamemmode.
' 
' PROGRAMMER	:	Tegh Mehta
'
'  DATE		    :	December 14, 2018
' ******************************************************

Public Class frmPlayerResultsTegh3
    Private Sub frmPlayerResultsTegh3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sortedPlayersArr(,) As String = Me.Tag
        Dim percentageOne = Math.Round((sortedPlayersArr(0, 1) / 15) * 100, 0)
        Dim percentageTwo = Math.Round((sortedPlayersArr(1, 1) / 15) * 100, 0)
        Dim percentageThree = Math.Round((sortedPlayersArr(2, 1) / 15) * 100, 0)
        lblResults.Text = "You are " & percentageOne & "% " & sortedPlayersArr(0, 0) & vbNewLine &
            "You are " & percentageTwo & "% " & sortedPlayersArr(1, 0) & vbNewLine &
            "You are " & percentageThree & "% " & sortedPlayersArr(2, 0) & vbNewLine

        Select Case sortedPlayersArr(0, 0)
            Case "Chris Paul"
                picPlayer.Image = My.Resources.chrispaul_playerselected
            Case "Steph Curry"
                picPlayer.Image = My.Resources.stephcurry_playerselected
            Case "Jrue Holiday"
                picPlayer.Image = My.Resources.jrueholiday_playerselected
            Case "James Harden"
                picPlayer.Image = My.Resources.jamesharden_playerseleted
            Case "Jimmy Butler"
                picPlayer.Image = My.Resources.jimmybutler_playerselected
            Case "Klay Thompson"
                picPlayer.Image = My.Resources.klaythompson_playerselected
            Case "Lebron James"
                picPlayer.Image = My.Resources.lebronjames_playerselected
            Case "Kawhi Leonard"
                picPlayer.Image = My.Resources.kawhileonard_playerselected
            Case "Kevin Durant"
                picPlayer.Image = My.Resources.kevindurant_playerselected
            Case "Anthony Davis"
                picPlayer.Image = My.Resources.anthonydavis_playerselected
            Case "Draymond Green"
                picPlayer.Image = My.Resources.draymondgreen_playerselected
            Case "Blake Griffin"
                picPlayer.Image = My.Resources.blakegriffindunk
            Case "Demarcus Cousins"
                picPlayer.Image = My.Resources.demarcuscousins_playerselected
            Case "Nikola Jokic"
                picPlayer.Image = My.Resources.nikolajokic_playersselected
            Case "Karl-Anthony Towns"
                picPlayer.Image = My.Resources.karltowns_playerselected
        End Select
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        frmWilliamSnapshotQuestion.player = Me.Tag(0, 0)
        frmWilliamSnapshotQuestion.Show()
        Me.Close()
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        frmMainTegh1.Show()
        Me.Close()
    End Sub
End Class