﻿Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim R As Integer
        Dim A As Integer
        Dim B As Integer
        A = TextBox1.Text
        B = TextBox2.Text
        R = A + B
        Label1.Text = R
    End Sub
End Class
