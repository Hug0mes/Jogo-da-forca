Imports System.Math
Public Class Form1

    Dim tentcertos, tenterrados, letra As Char
    Dim i, gera As Integer
    Dim palavra As String

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click

        Randomize()
        gera = Int(Rnd() * 5) + 1

        Select Case gera

            Case 1
                palavra = "MONKEY D LUFY"
            Case 2
                palavra = "SAIKI K"
            Case 3
                palavra = "JONH CENA"
            Case 4
                palavra = "SPONGBOB"
            Case 5
                palavra = "JACKIE CHAN"
            Case 6
                palavra = "BART SIMPSON"
        End Select

        For i = 1 To palavra.Length - 1
            Label2.Text = Label2.Text + " _ "
        Next
    End Sub

    Sub verificar(ByVal palavra As String)


    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        letra = "B"
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        letra = "C"
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        letra = "D"
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        letra = "E"
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        letra = "F"
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        letra = "G"
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        letra = "H"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        letra = "I"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        letra = "J"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        letra = "K"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        letra = "L"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        letra = "M"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        letra = "N"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        letra = "O"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        letra = "P"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        letra = "Q"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        letra = "R"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        letra = "S"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        letra = "T"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        letra = "S"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        letra = "T"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        letra = "W"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        letra = "X"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        letra = "Y"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        letra = "Z"
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        letra = "A"

    End Sub
End Class
