Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userName As String = "admin"
        Dim password As String = "Tumi1085"

        If (TextBox1.Text = userName And TextBox2.Text = password) Then
            MessageBox.Show("Login succesful!")
        Else
            MessageBox.Show("Unknown User!")
        End If
    End Sub
End Class
