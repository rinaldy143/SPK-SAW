<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInput
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNilai1 = New System.Windows.Forms.TextBox()
        Me.txtNilai2 = New System.Windows.Forms.TextBox()
        Me.txtNilai3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNilai4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNilai5 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNilai6 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.DataSet1 = New Tugas_Besar_Kelompok_2___SI_Penjualan.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(267, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Awal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(70, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Altenatif"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(70, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(70, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nilai Investasi 10 tahun"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(70, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Daya Dukung Produksi"
        '
        'txtNilai1
        '
        Me.txtNilai1.Location = New System.Drawing.Point(252, 112)
        Me.txtNilai1.Name = "txtNilai1"
        Me.txtNilai1.Size = New System.Drawing.Size(100, 22)
        Me.txtNilai1.TabIndex = 5
        '
        'txtNilai2
        '
        Me.txtNilai2.Location = New System.Drawing.Point(252, 152)
        Me.txtNilai2.Name = "txtNilai2"
        Me.txtNilai2.Size = New System.Drawing.Size(100, 22)
        Me.txtNilai2.TabIndex = 6
        '
        'txtNilai3
        '
        Me.txtNilai3.Location = New System.Drawing.Point(252, 189)
        Me.txtNilai3.Name = "txtNilai3"
        Me.txtNilai3.Size = New System.Drawing.Size(100, 22)
        Me.txtNilai3.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(249, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "1. = Kurang mendukung"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(249, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "2. = cukup mendukung"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(249, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "3. = sangat mendukung"
        '
        'txtNilai4
        '
        Me.txtNilai4.Location = New System.Drawing.Point(252, 229)
        Me.txtNilai4.Name = "txtNilai4"
        Me.txtNilai4.Size = New System.Drawing.Size(100, 22)
        Me.txtNilai4.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(70, 316)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 19)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Prioritas Kebutuhan"
        '
        'txtNilai5
        '
        Me.txtNilai5.Location = New System.Drawing.Point(252, 316)
        Me.txtNilai5.Name = "txtNilai5"
        Me.txtNilai5.Size = New System.Drawing.Size(100, 22)
        Me.txtNilai5.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(249, 377)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "3. = Cukup Berprioritas"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(249, 360)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 17)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "2. = Berprioritas"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(249, 341)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(158, 17)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "1. = Sangat Berprioritas"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(71, 395)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 19)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Ketersediaan"
        '
        'txtNilai6
        '
        Me.txtNilai6.Location = New System.Drawing.Point(252, 397)
        Me.txtNilai6.Name = "txtNilai6"
        Me.txtNilai6.Size = New System.Drawing.Size(100, 22)
        Me.txtNilai6.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(251, 459)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(191, 17)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "3. = Sangat mudah diperoleh"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(251, 442)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(186, 17)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "2. = Cukup mudah diperoleh"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(251, 423)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(126, 17)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "1. = Sulit diperoleh"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(70, 512)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(192, 36)
        Me.btnSimpan.TabIndex = 22
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(497, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(520, 309)
        Me.DataGridView1.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(296, 512)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 36)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 586)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtNilai6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNilai5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNilai4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNilai3)
        Me.Controls.Add(Me.txtNilai2)
        Me.Controls.Add(Me.txtNilai1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmInput"
        Me.Text = "Input"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNilai1 As TextBox
    Friend WithEvents txtNilai2 As TextBox
    Friend WithEvents txtNilai3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNilai4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNilai5 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNilai6 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
End Class
