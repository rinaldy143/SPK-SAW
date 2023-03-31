<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHakAkses
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.chkMasterSupplier = New System.Windows.Forms.CheckBox()
        Me.chkTransBeli = New System.Windows.Forms.CheckBox()
        Me.chkTransJual = New System.Windows.Forms.CheckBox()
        Me.chkHakAkses = New System.Windows.Forms.CheckBox()
        Me.chkMasterPelanggan = New System.Windows.Forms.CheckBox()
        Me.chkMasterKaryawan = New System.Windows.Forms.CheckBox()
        Me.chkMasterBarang = New System.Windows.Forms.CheckBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.chkFileTransaksi = New System.Windows.Forms.CheckBox()
        Me.chkFileMaster = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkMasterSupplier
        '
        Me.chkMasterSupplier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkMasterSupplier.AutoSize = True
        Me.chkMasterSupplier.BackColor = System.Drawing.SystemColors.Control
        Me.chkMasterSupplier.Location = New System.Drawing.Point(296, 308)
        Me.chkMasterSupplier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkMasterSupplier.Name = "chkMasterSupplier"
        Me.chkMasterSupplier.Size = New System.Drawing.Size(82, 21)
        Me.chkMasterSupplier.TabIndex = 51
        Me.chkMasterSupplier.Text = "Supplier"
        Me.chkMasterSupplier.UseVisualStyleBackColor = False
        '
        'chkTransBeli
        '
        Me.chkTransBeli.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkTransBeli.AutoSize = True
        Me.chkTransBeli.BackColor = System.Drawing.SystemColors.Control
        Me.chkTransBeli.Location = New System.Drawing.Point(437, 251)
        Me.chkTransBeli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkTransBeli.Name = "chkTransBeli"
        Me.chkTransBeli.Size = New System.Drawing.Size(96, 21)
        Me.chkTransBeli.TabIndex = 55
        Me.chkTransBeli.Text = "Pembelian"
        Me.chkTransBeli.UseVisualStyleBackColor = False
        '
        'chkTransJual
        '
        Me.chkTransJual.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkTransJual.AutoSize = True
        Me.chkTransJual.BackColor = System.Drawing.SystemColors.Control
        Me.chkTransJual.Location = New System.Drawing.Point(437, 223)
        Me.chkTransJual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkTransJual.Name = "chkTransJual"
        Me.chkTransJual.Size = New System.Drawing.Size(93, 21)
        Me.chkTransJual.TabIndex = 54
        Me.chkTransJual.Text = "Penjualan"
        Me.chkTransJual.UseVisualStyleBackColor = False
        '
        'chkHakAkses
        '
        Me.chkHakAkses.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkHakAkses.AutoSize = True
        Me.chkHakAkses.BackColor = System.Drawing.SystemColors.Control
        Me.chkHakAkses.Location = New System.Drawing.Point(296, 336)
        Me.chkHakAkses.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkHakAkses.Name = "chkHakAkses"
        Me.chkHakAkses.Size = New System.Drawing.Size(97, 21)
        Me.chkHakAkses.TabIndex = 52
        Me.chkHakAkses.Text = "Hak Akses"
        Me.chkHakAkses.UseVisualStyleBackColor = False
        '
        'chkMasterPelanggan
        '
        Me.chkMasterPelanggan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkMasterPelanggan.AutoSize = True
        Me.chkMasterPelanggan.BackColor = System.Drawing.SystemColors.Control
        Me.chkMasterPelanggan.Location = New System.Drawing.Point(296, 279)
        Me.chkMasterPelanggan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkMasterPelanggan.Name = "chkMasterPelanggan"
        Me.chkMasterPelanggan.Size = New System.Drawing.Size(98, 21)
        Me.chkMasterPelanggan.TabIndex = 50
        Me.chkMasterPelanggan.Text = "Pelanggan"
        Me.chkMasterPelanggan.UseVisualStyleBackColor = False
        '
        'chkMasterKaryawan
        '
        Me.chkMasterKaryawan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkMasterKaryawan.AutoSize = True
        Me.chkMasterKaryawan.BackColor = System.Drawing.SystemColors.Control
        Me.chkMasterKaryawan.Location = New System.Drawing.Point(296, 251)
        Me.chkMasterKaryawan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkMasterKaryawan.Name = "chkMasterKaryawan"
        Me.chkMasterKaryawan.Size = New System.Drawing.Size(92, 21)
        Me.chkMasterKaryawan.TabIndex = 49
        Me.chkMasterKaryawan.Text = "Karyawan"
        Me.chkMasterKaryawan.UseVisualStyleBackColor = False
        '
        'chkMasterBarang
        '
        Me.chkMasterBarang.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkMasterBarang.AutoSize = True
        Me.chkMasterBarang.BackColor = System.Drawing.SystemColors.Control
        Me.chkMasterBarang.Location = New System.Drawing.Point(296, 223)
        Me.chkMasterBarang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkMasterBarang.Name = "chkMasterBarang"
        Me.chkMasterBarang.Size = New System.Drawing.Size(76, 21)
        Me.chkMasterBarang.TabIndex = 48
        Me.chkMasterBarang.Text = "Barang"
        Me.chkMasterBarang.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnKeluar.Location = New System.Drawing.Point(373, 428)
        Me.btnKeluar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(208, 28)
        Me.btnKeluar.TabIndex = 68
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBatal.Location = New System.Drawing.Point(588, 393)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(100, 28)
        Me.btnBatal.TabIndex = 67
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHapus.Location = New System.Drawing.Point(481, 393)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(100, 28)
        Me.btnHapus.TabIndex = 66
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCari.Location = New System.Drawing.Point(373, 393)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(100, 28)
        Me.btnCari.TabIndex = 65
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdSimpan.Location = New System.Drawing.Point(265, 393)
        Me.cmdSimpan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(100, 28)
        Me.cmdSimpan.TabIndex = 64
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'chkFileTransaksi
        '
        Me.chkFileTransaksi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkFileTransaksi.AutoSize = True
        Me.chkFileTransaksi.Location = New System.Drawing.Point(419, 194)
        Me.chkFileTransaksi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkFileTransaksi.Name = "chkFileTransaksi"
        Me.chkFileTransaksi.Size = New System.Drawing.Size(118, 21)
        Me.chkFileTransaksi.TabIndex = 53
        Me.chkFileTransaksi.Text = "File Transaksi"
        Me.chkFileTransaksi.UseVisualStyleBackColor = True
        '
        'chkFileMaster
        '
        Me.chkFileMaster.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkFileMaster.AutoSize = True
        Me.chkFileMaster.BackColor = System.Drawing.SystemColors.Control
        Me.chkFileMaster.Location = New System.Drawing.Point(276, 194)
        Me.chkFileMaster.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkFileMaster.Name = "chkFileMaster"
        Me.chkFileMaster.Size = New System.Drawing.Size(99, 21)
        Me.chkFileMaster.TabIndex = 47
        Me.chkFileMaster.Text = "File Master"
        Me.chkFileMaster.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(137, 196)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Menu Akses"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.Location = New System.Drawing.Point(276, 133)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(225, 22)
        Me.txtPassword.TabIndex = 46
        '
        'txtUser
        '
        Me.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUser.Location = New System.Drawing.Point(276, 96)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(225, 22)
        Me.txtUser.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 137)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "User"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 29)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Pemberian Akses Menu"
        '
        'frmHakAkses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 506)
        Me.Controls.Add(Me.chkMasterSupplier)
        Me.Controls.Add(Me.chkTransBeli)
        Me.Controls.Add(Me.chkTransJual)
        Me.Controls.Add(Me.chkHakAkses)
        Me.Controls.Add(Me.chkMasterPelanggan)
        Me.Controls.Add(Me.chkMasterKaryawan)
        Me.Controls.Add(Me.chkMasterBarang)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.chkFileTransaksi)
        Me.Controls.Add(Me.chkFileMaster)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmHakAkses"
        Me.Text = "Manajemen Hak Akses"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkMasterSupplier As CheckBox
    Friend WithEvents chkTransBeli As CheckBox
    Friend WithEvents chkTransJual As CheckBox
    Friend WithEvents chkHakAkses As CheckBox
    Friend WithEvents chkMasterPelanggan As CheckBox
    Friend WithEvents chkMasterKaryawan As CheckBox
    Friend WithEvents chkMasterBarang As CheckBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents cmdSimpan As Button
    Friend WithEvents chkFileTransaksi As CheckBox
    Friend WithEvents chkFileMaster As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
