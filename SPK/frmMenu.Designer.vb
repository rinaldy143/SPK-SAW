<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Status3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Status2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Status1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.mnuHakAkses = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HitungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Status3
        '
        Me.Status3.Name = "Status3"
        Me.Status3.Size = New System.Drawing.Size(42, 20)
        Me.Status3.Text = "Time"
        '
        'Status2
        '
        Me.Status2.ImageTransparentColor = System.Drawing.Color.White
        Me.Status2.Name = "Status2"
        Me.Status2.Size = New System.Drawing.Size(1091, 20)
        Me.Status2.Spring = True
        Me.Status2.Text = "Status"
        '
        'Status1
        '
        Me.Status1.Name = "Status1"
        Me.Status1.Size = New System.Drawing.Size(42, 20)
        Me.Status1.Text = "Akun"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status1, Me.Status2, Me.Status3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 738)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1195, 26)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "Status1"
        '
        'Timer2
        '
        '
        'mnuHakAkses
        '
        Me.mnuHakAkses.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_diagram_v2_08
        Me.mnuHakAkses.Name = "mnuHakAkses"
        Me.mnuHakAkses.Size = New System.Drawing.Size(159, 26)
        Me.mnuHakAkses.Text = "&Hak Akses"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(156, 6)
        '
        'mnuFileMaster
        '
        Me.mnuFileMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaToolStripMenuItem, Me.HitungToolStripMenuItem, Me.ToolStripMenuItem1, Me.mnuHakAkses})
        Me.mnuFileMaster.Name = "mnuFileMaster"
        Me.mnuFileMaster.Size = New System.Drawing.Size(95, 24)
        Me.mnuFileMaster.Text = "File &Master"
        '
        'SaToolStripMenuItem
        '
        Me.SaToolStripMenuItem.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_book_edit
        Me.SaToolStripMenuItem.Name = "SaToolStripMenuItem"
        Me.SaToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.SaToolStripMenuItem.Text = "Input"
        '
        'HitungToolStripMenuItem
        '
        Me.HitungToolStripMenuItem.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._32_list_edit
        Me.HitungToolStripMenuItem.Name = "HitungToolStripMenuItem"
        Me.HitungToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.HitungToolStripMenuItem.Text = "Hitung"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileMaster, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1195, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogout, Me.mnuExit})
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.KeluarToolStripMenuItem.Text = "&Keluar"
        '
        'mnuLogout
        '
        Me.mnuLogout.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._16_delete
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(190, 26)
        Me.mnuLogout.Text = "Keluar &Akun"
        '
        'mnuExit
        '
        Me.mnuExit.Image = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources._16_cross_circle_frame
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(190, 26)
        Me.mnuExit.Text = "Keluar &Aplikasi"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1195, 764)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Pemilihan Keputusan"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Status3 As ToolStripStatusLabel
    Friend WithEvents Status2 As ToolStripStatusLabel
    Friend WithEvents Status1 As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Timer2 As Timer
    Friend WithEvents mnuHakAkses As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuFileMaster As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuLogout As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents SaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HitungToolStripMenuItem As ToolStripMenuItem
End Class
