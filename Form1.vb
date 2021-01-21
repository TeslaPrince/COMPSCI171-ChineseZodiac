Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim zodiac() As String = {"Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Sheep"}
        Dim year As Integer
        Dim calc As Integer
        year = CInt(txtYear.Text)
        calc = year Mod 12
        If calc = 0 Then
            txtAnimal.Text = zodiac(0)
        ElseIf calc = 1 Then
            txtAnimal.Text = zodiac(1)
        ElseIf calc = 2 Then
            txtAnimal.Text = zodiac(2)
        ElseIf calc = 3 Then
            txtAnimal.Text = zodiac(3)
        ElseIf calc = 4 Then
            txtAnimal.Text = zodiac(4)
        ElseIf calc = 5 Then
            txtAnimal.Text = zodiac(5)
        ElseIf calc = 6 Then
            txtAnimal.Text = zodiac(6)
        ElseIf calc = 7 Then
            txtAnimal.Text = zodiac(7)
        ElseIf calc = 8 Then
            txtAnimal.Text = zodiac(8)
        ElseIf calc = 9 Then
            txtAnimal.Text = zodiac(9)
        ElseIf calc = 10 Then
            txtAnimal.Text = zodiac(10)
        ElseIf calc = 11 Then
            txtAnimal.Text = zodiac(11)
        Else
            txtAnimal.Text = "Invalid Input"
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtAnimal.Text = ""
        txtYear.Text = ""
    End Sub
End Class
