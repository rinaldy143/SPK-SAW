Imports System.Data.Odbc
Public Class frmHakAkses
    Dim strCodeAkses As String
    Private Sub PemilihanMenuAkses()
        If chkFileMaster.Checked = True Then strCodeAkses = 1 Else strCodeAkses = 0
        If chkMasterBarang.Checked = True Then strCodeAkses = strCodeAkses & 1 Else strCodeAkses = strCodeAkses & 0
        If chkMasterKaryawan.Checked = True Then strCodeAkses = strCodeAkses & 1 Else strCodeAkses = strCodeAkses & 0
        If chkMasterPelanggan.Checked = True Then strCodeAkses = strCodeAkses & 1 Else strCodeAkses = strCodeAkses & 0
        If chkMasterSupplier.Checked = True Then strCodeAkses = strCodeAkses & 1 Else strCodeAkses = strCodeAkses & 0
        If chkHakAkses.Checked = True Then strCodeAkses = strCodeAkses & 1 Else strCodeAkses = strCodeAkses & 0
        If chkFileTransaksi.Checked = True Then strCodeAkses = strCodeAkses & 1 Else strCodeAkses = strCodeAkses & 0
        If chkTransJual.Checked = True Then strCodeAkses = strCodeAkses & 1 Else strCodeAkses = strCodeAkses & 0
        If chkTransBeli.Checked = True Then strCodeAkses = strCodeAkses & 1 Else strCodeAkses = strCodeAkses & 0
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        If MsgBox("Anda yakin data sudah benar?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Call KONEKSI()
        Try
            Dim str As String
            CMD = New OdbcCommand("select * from login where user='" &
               txtUser.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            Call PemilihanMenuAkses()
            If DR.HasRows = False Then 'Mode Tambah Data
                str = "insert into login values ('" & txtUser.Text & "','" & _txtPassword.Text & "','" & strCodeAkses & "')"
                DR.Close()
                CMD = New OdbcCommand(str, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan", vbInformation, "Info")
                Call Bersih()
            Else 'Mode Edit Data
                DR.Close()
                If MsgBox("Data sudah ada sebelumnya, anda ingin mengupdate?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
                str = "Update login set password='" & txtPassword.Text & "', MenuAkses='" & strCodeAkses & "' Where user='" & txtUser.Text & "'"
                CMD = New OdbcCommand(str, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil TerUpdate", vbInformation, "Info")
                Call Bersih()
            End If
        Catch ex As Exception
            MsgBox("Data Tidak Berhasil Disimpan", vbInformation, "Error")
        End Try
    End Sub

    Private Sub Cari()
        If CodeCari = False Then strCari = InputBox("Masukkan User Name!", "Cari Data")
        Call KONEKSI()
        CMD = New OdbcCommand("select * from login where User like '%" & strCari & "%'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows = False Then
            MsgBox("Data tidak ditemukan", vbInformation, "Info")
        Else 'Data ditemukan Rinaldi Oktarinanda
            txtUser.Text = DR.Item("User")
            txtPassword.Text = DR.Item("Password")
            If Strings.Left(DR.Item("MenuAkses"), 1) = "1" Then chkFileMaster.Checked = True Else chkFileMaster.Checked = True
            If Strings.Mid(DR.Item("MenuAkses"), 2, 1) = "1" Then chkMasterBarang.Checked = True Else chkMasterBarang.Checked = True
            If Strings.Mid(DR.Item("MenuAkses"), 3, 1) = "1" Then chkMasterKaryawan.Checked = True Else chkMasterKaryawan.Checked = True
            If Strings.Mid(DR.Item("MenuAkses"), 4, 1) = "1" Then chkMasterPelanggan.Checked = True Else chkMasterPelanggan.Checked = True
            If Strings.Mid(DR.Item("MenuAkses"), 5, 1) = "1" Then chkMasterSupplier.Checked = True Else chkMasterSupplier.Checked = True
            If Strings.Mid(DR.Item("MenuAkses"), 6, 1) = "1" Then chkHakAkses.Checked = True Else chkHakAkses.Checked = True
            If Strings.Mid(DR.Item("MenuAkses"), 7, 1) = "1" Then chkFileTransaksi.Checked = True Else chkFileTransaksi.Checked = True
            If Strings.Mid(DR.Item("MenuAkses"), 8, 1) = "1" Then chkTransJual.Checked = True Else chkTransJual.Checked = True
            If Strings.Mid(DR.Item("MenuAkses"), 9, 1) = "1" Then chkTransBeli.Checked = True Else chkTransBeli.Checked = True
        End If
        DR.Close() : txtUser.Focus() ': strCari = "" : CodeCari = False
    End Sub
    Private Sub Bersih()
        txtUser.Text = "" : txtPassword.Text = ""
        chkFileMaster.Checked = False
        chkMasterBarang.Checked = False
        chkMasterKaryawan.Checked = False
        chkMasterPelanggan.Checked = False
        chkMasterSupplier.Checked = False
        chkHakAkses.Checked = False
        chkFileTransaksi.Checked = False
        chkTransJual.Checked = False
        txtUser.Focus()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Call Cari()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtUser.Text = "" Then MsgBox("Lakukan pencarian dahulu!", vbExclamation, "Perhatian") : Exit Sub
        If MsgBox("Anda yakin ingin menghapus?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Call KONEKSI()
        str = "delete from login where User ='" & txtUser.Text & "'"
        CMD = New OdbcCommand(str, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil TerHapus", vbInformation, "Info")
        Call Bersih()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Bersih()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        If MsgBox("Anda yakin ingin keluar?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Me.Close()
    End Sub

End Class