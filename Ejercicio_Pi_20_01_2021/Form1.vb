Public Class Form1
    
    Const Pi As Single = 3.141592654
    Dim R, H, V As Single
    


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = ""
        TextBox2.Text = ""


        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        Me.Text = "Ejercicio Pi"
        Label1.Text = "Introduzca el diametro, en metros"
        Label2.Text = "Introduzca la altura, en metros"
        Label3.Text = ""
        Button1.Text = "Calcular"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
        R = Val(TextBox1.Text) / 2
        H = Val(TextBox2.Text)
        V = Pi * (R ^ 2) * H
        Label3.Font = New Font("Arial", 8, FontStyle.Bold)
        Label3.TextAlign = ContentAlignment.MiddleCenter
        Label3.Text = ("El volumen del cilindro es de " & V & " metros cubicos cuadrados")
    End Sub
End Class
