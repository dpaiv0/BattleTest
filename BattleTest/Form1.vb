Public Class Form1
    Dim rnd As New Random
    Dim opponentHp As Integer = rnd.Next(800, 1301)
    Dim characterHp As Integer = 900
    Dim characterMp As Integer = 100
    Dim round As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Opponent's HP
        Label2.Text = opponentHp
        ProgressBar1.Maximum = opponentHp
        ProgressBar1.Value = opponentHp

        ' User's HP
        Label3.Text = characterHp
        ProgressBar2.Maximum = characterHp
        ProgressBar2.Value = characterHp

        ' User's MP
        Label7.Text = characterMp
        ProgressBar3.Maximum = characterMp
        ProgressBar3.Value = characterMp

        ' Set the round value
        Label6.Text = round

        ' Disable start button & enable skill buttons
        Button1.Enabled = False
        EnableSkillButtons()
        Button5.Enabled = False


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim criticalChance As Integer = rnd.Next(1, 5)

        If criticalChance = 4 Then
            If (Label2.Text - 80) <= 0 Then
                Label2.Text = 0
                ProgressBar1.Value = 0
                EndBattle("Character")
                Exit Sub
            End If

            ' 2x value of attack
            Label2.Text -= 80
            ProgressBar1.Value -= 80
        Else
            If (Label2.Text - 40) <= 0 Then
                Label2.Text = 0
                ProgressBar1.Value = 0
                EndBattle("Character")
                Exit Sub
            End If

            Label2.Text -= 40
            ProgressBar1.Value -= 40
        End If

        Label7.Text += 20
        ProgressBar3.Maximum += 20
        ProgressBar3.Value += 20

        DisableSkillButtons()
        DoEnemyAttack()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim criticalChance As Integer = rnd.Next(1, 5)

        If criticalChance = 4 Then
            If (Label2.Text - 180) <= 0 Then
                Label2.Text = 0
                ProgressBar1.Value = 0
                EndBattle("Character")
                Exit Sub
            End If

            ' 2x value of attack
            Label2.Text -= 180
            ProgressBar1.Value -= 180
        Else
            If (Label2.Text - 90) <= 0 Then
                Label2.Text = 0
                ProgressBar1.Value = 0
                EndBattle("Character")
                Exit Sub
            End If

            Label2.Text -= 90
            ProgressBar1.Value -= 90
        End If

        Label7.Text -= 30
        ProgressBar3.Value -= 30

        Label7.Text += 20
        ProgressBar3.Maximum += 20
        ProgressBar3.Value += 20

        DisableSkillButtons()
        DoEnemyAttack()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim criticalChance As Integer = rnd.Next(1, 5)

        If criticalChance = 4 Then
            If (Label2.Text - 220) <= 0 Then
                Label2.Text = 0
                ProgressBar1.Value = 0
                EndBattle("Character")
                Exit Sub
            End If

            ' 2x value of attack
            Label2.Text -= 220
            ProgressBar1.Value -= 220
        Else
            If (Label2.Text - 110) <= 0 Then
                Label2.Text = 0
                ProgressBar1.Value = 0
                EndBattle("Character")
                Exit Sub
            End If

            Label2.Text -= 110
            ProgressBar1.Value -= 110
        End If

        Label7.Text -= 50
        ProgressBar3.Value -= 50

        Label7.Text += 20
        ProgressBar3.Maximum += 20
        ProgressBar3.Value += 20

        DisableSkillButtons()
        DoEnemyAttack()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label3.Text += 50
        ProgressBar2.Value += 50

        Label7.Text -= 20
        ProgressBar3.Value -= 20

        Label7.Text += 20
        ProgressBar3.Maximum += 20
        ProgressBar3.Value += 20

        DisableSkillButtons()
        DoEnemyAttack()
    End Sub

    Sub DoEnemyAttack()
        Dim attack As Integer = rnd.Next(1, 4)
        Dim criticalChance As Integer = rnd.Next(1, 5)

        If attack = 1 Then
            If criticalChance = 4 Then
                If (Label3.Text - 80) <= 0 Then
                    Label3.Text = 0
                    ProgressBar2.Value = 0
                    EndBattle("Opponent")
                    Exit Sub
                End If

                Label3.Text -= 80
                ProgressBar2.Value -= 80
            Else
                If (Label3.Text - 40) <= 0 Then
                    Label3.Text = 0
                    ProgressBar2.Value = 0
                    EndBattle("Opponent")
                    Exit Sub
                End If

                Label3.Text -= 40
                ProgressBar2.Value -= 40
            End If
        ElseIf attack = 2 Then
            If criticalChance = 4 Then
                If (Label3.Text - 180) <= 0 Then
                    Label3.Text = 0
                    ProgressBar2.Value = 0
                    EndBattle("Opponent")
                    Exit Sub
                End If

                Label3.Text -= 180
                ProgressBar2.Value -= 180
            Else
                If (Label3.Text - 90) <= 0 Then
                    Label3.Text = 0
                    ProgressBar2.Value = 0
                    EndBattle("Opponent")
                    Exit Sub
                End If

                Label3.Text -= 90
                ProgressBar2.Value -= 90
            End If
        ElseIf attack = 3 Then
            If criticalChance = 4 Then
                If (Label3.Text - 220) <= 0 Then
                    Label3.Text = 0
                    ProgressBar2.Value = 0
                    EndBattle("Opponent")
                    Exit Sub
                End If

                Label3.Text -= 220
                ProgressBar2.Value -= 220
            Else
                If (Label3.Text - 110) <= 0 Then
                    Label3.Text = 0
                    ProgressBar2.Value = 0
                    EndBattle("Opponent")
                    Exit Sub
                End If

                Label3.Text -= 110
                ProgressBar2.Value -= 110
            End If
        End If

        NextRound()
    End Sub

    Sub NextRound()
        Label6.Text += 1
        EnableSkillButtons()

        If Label7.Text < 30 Then
            Button3.Enabled = False
        End If

        If Label7.Text < 50 Then
            Button4.Enabled = False
        End If

        If Label3.Text > 850 Then
            Button5.Enabled = False
        End If
    End Sub

    Sub DisableSkillButtons()
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
    End Sub

    Sub EnableSkillButtons()
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
    End Sub

    Sub EndBattle(ByVal winner As String)
        Label9.Text = $"{winner} wins!"
    End Sub
End Class
