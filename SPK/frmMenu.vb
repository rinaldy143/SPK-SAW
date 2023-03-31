Imports System.Data.Odbc
Public Class frmMenu
    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()

        If Strings.Mid(strMenuAkses, 1, 1) = "1" Then mnuFileMaster.Visible = True Else mnuFileMaster.Visible = False
        If Strings.Mid(strMenuAkses, 6, 1) = "1" Then mnuHakAkses.Visible = True Else mnuHakAkses.Visible = False

        Status1.Text = strUser
        Timer1.Interval = 1000
        Timer2.Interval = 1000

        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                ctl.BackgroundImage = Me.BackgroundImage
            End If
        Next ctl
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Status3.Text = Format(Now, "dd MMM yyyy | HH:mm:ss")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Status2.Text = "Sistem Pemilihan Keputusan" Then
            Status2.Text = "Sistem"
        ElseIf Status2.Text = "Sistem" Then
            Status2.Text = "Sistem Pemilihan"
        Else
            Status2.Text = "Sistem Pemilihan Keputusan"
        End If
    End Sub
    Private Sub mnuMasterHakAkses_Click(sender As Object, e As EventArgs) Handles mnuHakAkses.Click
        frmHakAkses.Show()
        frmHakAkses.StartPosition = FormStartPosition.CenterScreen
        frmHakAkses.MdiParent = Me
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        If MsgBox("Anda yakin ingin keluar dari akun ini?", vbYesNo, "Konfirmasi") = vbNo Then
            Exit Sub
        ElseIf vbYes Then
            Me.Close()
            frmLogin.Show()
            frmLogin.txtUserName.Focus()
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        If MsgBox("Anda yakin ingin keluar dari Aplikasi ini?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        End
    End Sub

    Private Sub Status2_Click(sender As Object, e As EventArgs) Handles Status2.Click

    End Sub

    Private Sub SaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaToolStripMenuItem.Click
        frmInput.Show()
        frmInput.StartPosition = FormStartPosition.CenterScreen
        frmInput.MdiParent = Me
    End Sub

    Private Sub HitungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HitungToolStripMenuItem.Click
        frmNormalisasi.Show()
        frmNormalisasi.StartPosition = FormStartPosition.CenterScreen
        frmNormalisasi.MdiParent = Me
    End Sub

    Private Sub mnuMasterBarang_Click(sender As Object, e As EventArgs)

    End Sub
End Class