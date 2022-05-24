Public Class Form2

  

    Dim num1, num2, suma As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        Label4.Text = num1 + num2

    End Sub
End Class