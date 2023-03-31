Imports System.Data.Odbc
Public Class frmInput
    Sub kondisiAwal()

        txtNilai1.Text = ""
        txtNilai2.Text = ""
        txtNilai3.Text = ""
        txtNilai4.Text = ""
        txtNilai5.Text = ""
        txtNilai6.Text = ""
        txtNilai1.Enabled = False
        txtNilai2.Enabled = False
        txtNilai3.Enabled = False
        txtNilai4.Enabled = False
        btnSimpan.Enabled = True
        Call KONEKSI()
        DA = New OdbcDataAdapter("select * from isi", CONN)
        DS = New DataSet
        DA.Fill(DS, "isi")
        DataGridView1.DataSource = DS.Tables("isi")
        DataGridView1.ReadOnly = True

    End Sub
    Sub siapIsi()
        txtNilai1.Enabled = True
        txtNilai2.Enabled = True
        txtNilai3.Enabled = True
        txtNilai4.Enabled = True
        txtNilai5.Enabled = True
        txtNilai6.Enabled = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNilai1.Text = "" Or txtNilai2.Text = "" Or txtNilai3.Text = "" Or txtNilai5.Text = "" Or txtNilai4.Text = "" Or txtNilai6.Text = "" Then
            MsgBox("Datanya ada yang belum terisi tuh!", vbInformation, "Error")
        Else
            Call KONEKSI()
            Dim InputData As String = "INSERT INTO isi (Alternatif, C1, C2, C3, C4, C5) VALUES ('" & txtNilai1.Text & "', '" & txtNilai2.Text & "', '" & txtNilai3.Text & "', '" & txtNilai4.Text & "', '" & txtNilai5.Text & "', '" & txtNilai6.Text & "')"
            CMD = New OdbcCommand(InputData, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Input Data Berhasil", vbInformation, "Info")
            Call kondisiAwal()

        End If
    End Sub

    Private Sub frmInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Anda yakin ingin keluar?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Me.Close()
    End Sub
End Class