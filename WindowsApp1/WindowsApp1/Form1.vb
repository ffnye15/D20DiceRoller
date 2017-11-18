Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim number1 As Integer
        Dim number2 As Integer

        Dim success As String
        Dim fail As String
        Dim tie As String

        success = "You have succeeded!"
        fail = "You have failed!"
        tie = "You have tied, roll again!"

        Randomize()
        ' Rolls your dice
        number1 = Int(Rnd() * 20) + 1
        txtYourRoll.Text = number1

        Randomize()
        ' Rolls enemies dice
        number2 = Int(Rnd() * 20) + 1
        txtEnemyRoll.Text = number2

        If number1 > number2 Then
            txtResults.Text = success
        ElseIf number1 < number2 Then
            txtResults.Text = fail
        ElseIf number1 = number2 Then
            txtResults.Text = tie
        End If

    End Sub

End Class
