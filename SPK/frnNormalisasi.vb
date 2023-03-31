Imports System.Data.Odbc
Public Class frmNormalisasi
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call KONEKSI()
        DA = New OdbcDataAdapter("select * from isi", CONN)
        DS = New DataSet
        DA.Fill(DS, "isi")
        DataGridView1.DataSource = DS.Tables("isi")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Hitung_pembagi()
    End Sub

    Sub Hitung_pembagi()
        Dim Min_C1, Max_C2, Max_C3, Min_C4, Max_C5 As Double
        Dim NC1, NC2, NC3, NC4, NC5, Preferensi As Double
        Dim r As Int16

        Min_C1 = (From Row As DataGridViewRow In DataGridView1.Rows
                  Where Row.Cells(2).FormattedValue.ToString() <> String.Empty
                  Select Convert.ToDouble(Row.Cells(2).FormattedValue)
                 ).Min()
        Max_C2 = (From Row As DataGridViewRow In DataGridView1.Rows
                  Where Row.Cells(3).FormattedValue.ToString() <> String.Empty
                  Select Convert.ToDouble(Row.Cells(3).FormattedValue)
                 ).Max()
        Max_C3 = (From Row As DataGridViewRow In DataGridView1.Rows
                  Where Row.Cells(4).FormattedValue.ToString() <> String.Empty
                  Select Convert.ToDouble(Row.Cells(4).FormattedValue)
                 ).Max()
        Min_C4 = (From Row As DataGridViewRow In DataGridView1.Rows
                  Where Row.Cells(5).FormattedValue.ToString() <> String.Empty
                  Select Convert.ToDouble(Row.Cells(5).FormattedValue)
                 ).Min()
        Max_C5 = (From Row As DataGridViewRow In DataGridView1.Rows
                  Where Row.Cells(6).FormattedValue.ToString() <> String.Empty
                  Select Convert.ToDouble(Row.Cells(6).FormattedValue)
                 ).Max()

        TextBox1.Text = Min_C1
        TextBox2.Text = Max_C2
        TextBox3.Text = Max_C3
        TextBox4.Text = Min_C4
        TextBox5.Text = Max_C5

        For Each row As DataGridViewRow In DataGridView1.Rows


            NC1 = Min_C1 / row.Cells(2).Value
            NC2 = row.Cells(3).Value / Max_C2
            NC3 = row.Cells(4).Value / Max_C3
            NC4 = Min_C4 / row.Cells(5).Value
            NC5 = row.Cells(6).Value / Max_C5
            Preferensi = (0.25 * NC1) + (0.15 * NC2) + (0.3 * NC3) + (0.25 * NC4) + (0.05 * NC5)
            For r = 0 To DataGridView2.RowCount - 1
                DataGridView2.Rows(r).Cells(5).Value = r
            Next
            r = r + 1

            Call KONEKSI()
            DA = New OdbcDataAdapter("select * from Normalisasi", CONN)
            DS = New DataSet
            DA.Fill(DS, "Normalisasi")
            DataGridView2.DataSource = DS.Tables("Normalisasi")
            DataGridView2.ReadOnly = True
            Dim InputData As String = "INSERT INTO Normalisasi (NC1, NC2, NC3, NC4, NC5, Preferensi, rank) VALUES ('" & NC1 & "', '" & NC2 & "', '" & NC3 & "', '" & NC4 & "', '" & NC5 & "', '" & Preferensi & "',  '" & r & "')"
            CMD = New OdbcCommand(InputData, CONN)
            CMD.ExecuteNonQuery()
        Next


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Call Hitung_pembagi()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Normalisasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Anda yakin ingin keluar?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Me.Close()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class