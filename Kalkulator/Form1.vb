﻿Public Class Form1

    Dim num1, num2 As Double
    Dim op, timpa

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LabelHasil.Text = "0" Or timpa = True Then
            LabelHasil.Text = "1"
            timpa = False
        Else
            LabelHasil.Text = LabelHasil.Text & "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If LabelHasil.Text = "0" Or timpa = True Then
            LabelHasil.Text = "2"
            timpa = False
        Else
            LabelHasil.Text = LabelHasil.Text & "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If LabelHasil.Text = "0" Or timpa = True Then
            LabelHasil.Text = "3"
            timpa = False
        Else
            LabelHasil.Text = LabelHasil.Text & "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If LabelHasil.Text = "0" Or timpa = True Then
            LabelHasil.Text = "4"
            timpa = False
        Else
            LabelHasil.Text = LabelHasil.Text & "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If LabelHasil.Text = "0" Or timpa = True Then
            LabelHasil.Text = "5"
            timpa = False
        Else
            LabelHasil.Text = LabelHasil.Text & "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If LabelHasil.Text = "0" Or timpa = True Then
            LabelHasil.Text = "6"
            timpa = False
        Else
            LabelHasil.Text = LabelHasil.Text & "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If LabelHasil.Text = "0" Or timpa = True Then
            LabelHasil.Text = "7"
            timpa = False
        Else
            LabelHasil.Text = LabelHasil.Text & "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If LabelHasil.Text = "0" Or timpa = True Then
            LabelHasil.Text = "8"
            timpa = False
        Else
            LabelHasil.Text = LabelHasil.Text & "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If LabelHasil.Text = "0" Or timpa = True Then
            LabelHasil.Text = "9"
            timpa = False
        Else
            LabelHasil.Text = LabelHasil.Text & "9"
        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs)
        If LabelHasil.Text = "0" Or timpa = True Then
            LabelHasil.Text = "0"
            timpa = False
        Else
            LabelHasil.Text = LabelHasil.Text & "0"
        End If
    End Sub

    Private Sub ButtonKoma_Click(sender As Object, e As EventArgs)
        If InStr(LabelHasil.Text, ",") = 0 Then
            LabelHasil.Text = LabelHasil.Text & ","
        End If
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        timpa = True
        op = "+"
        num1 = LabelHasil.Text
    End Sub

    Private Sub ButtonKurang_Click(sender As Object, e As EventArgs) Handles ButtonKurang.Click
        timpa = True
        op = "-"
        num1 = LabelHasil.Text
    End Sub

    Private Sub ButtonKali_Click(sender As Object, e As EventArgs) Handles ButtonKali.Click
        timpa = True
        op = "*"
        num1 = LabelHasil.Text
    End Sub

    Private Sub ButtonBagi_Click(sender As Object, e As EventArgs) Handles ButtonBagi.Click
        timpa = True
        op = "/"
        num1 = LabelHasil.Text
    End Sub

    Private Sub ButtonHasil_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Select Case op
            Case "+"
                LabelHasil.Text = Val(num1) + Val(LabelHasil.Text)
                timpa = True
            Case "-"
                LabelHasil.Text = Val(num1) - Val(LabelHasil.Text)
                timpa = True
            Case "/"
                LabelHasil.Text = Val(num1) / Val(LabelHasil.Text)
                timpa = True
            Case "*"
                LabelHasil.Text = Val(num1) * Val(LabelHasil.Text)
                timpa = True
        End Select

    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        LabelHasil.Text = "0"
        num1 = 0
        op = ""
    End Sub
End Class