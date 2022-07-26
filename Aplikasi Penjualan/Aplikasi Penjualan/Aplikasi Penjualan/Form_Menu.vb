﻿Public Class Form_Menu
    Private Sub Form_Menu_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
        Form_Login.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_Barang.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form_Penjualan.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form_Lap_Barang.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form_Lap_Jual_Harian.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form_Lap_Jual_Bulan.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form_Lap_Jual_Tahun.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form_User.ShowDialog()
    End Sub

    Private Sub Form_Menu_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        If lbl_level.Text = "Admin" Then
            Button1.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Button8.Enabled = True
        ElseIf lbl_level.Text = "Kasir" Then
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button8.Enabled = False
        Else
            Me.Close()
            Form_Login.Show()
            MessageBox.Show("Bukan Kasir dan Admin !!!")
        End If
    End Sub
End Class