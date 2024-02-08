Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2 As Integer
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        If num1 > num2 Then
            MessageBox.Show("El numero mayor es " & num1 & " y el numero menor es " & num2)
        Else
            If num2 > num1 Then
                MessageBox.Show("El numero mayor es " & num2 & " y el numero menor es " & num1)
            Else
                MessageBox.Show("Los numeros son iguales")
            End If
        End If

    End Sub
End Class
