Imports System.Data.Odbc
Public Class frmLogin
    Private Sub login()
        Call KONEKSI()
        CMD = New OdbcCommand("select * from login where User='" & txtUserName.Text & "' and Password='" & txtPassword.Text & "'", CONN)
        'rinaldiokta
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows = False Then
            MsgBox("User Name and Password Salah", vbInformation, "Info")
        Else 'Data ditemukan
            strUser = DR.Item("user")
            strMenuAkses = DR.Item("MenuAkses")
            txtUserName.Text = "" : txtPassword.Text = ""
            frmMenu.Show()
            Me.Hide()
        End If
        DR.Close()
    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs)
        Call login()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub txtPassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtPassword.OnValueChanged
        txtPassword.isPassword = True
    End Sub

    Private Sub cmdLogin_Click_1(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Call login()

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class