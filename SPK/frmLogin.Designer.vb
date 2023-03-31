<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.cmdLogin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUserName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(269, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Lapor admin jika belum mempunyai akun."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(207, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Sistem Pemilihan Keputusan"
        '
        'cmdLogin
        '
        Me.cmdLogin.ActiveBorderThickness = 1
        Me.cmdLogin.ActiveCornerRadius = 20
        Me.cmdLogin.ActiveFillColor = System.Drawing.Color.SkyBlue
        Me.cmdLogin.ActiveForecolor = System.Drawing.Color.White
        Me.cmdLogin.ActiveLineColor = System.Drawing.Color.Transparent
        Me.cmdLogin.BackColor = System.Drawing.Color.White
        Me.cmdLogin.BackgroundImage = CType(resources.GetObject("cmdLogin.BackgroundImage"), System.Drawing.Image)
        Me.cmdLogin.ButtonText = "Login"
        Me.cmdLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogin.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.cmdLogin.IdleBorderThickness = 1
        Me.cmdLogin.IdleCornerRadius = 20
        Me.cmdLogin.IdleFillColor = System.Drawing.Color.MediumSlateBlue
        Me.cmdLogin.IdleForecolor = System.Drawing.Color.LightSteelBlue
        Me.cmdLogin.IdleLineColor = System.Drawing.Color.LightSteelBlue
        Me.cmdLogin.Location = New System.Drawing.Point(242, 439)
        Me.cmdLogin.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmdLogin.Name = "cmdLogin"
        Me.HelpProvider1.SetShowHelp(Me.cmdLogin, True)
        Me.cmdLogin.Size = New System.Drawing.Size(217, 46)
        Me.cmdLogin.TabIndex = 18
        Me.cmdLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Tugas_Besar_Kelompok_2___SI_Penjualan.My.Resources.Resources.log_out
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(668, 13)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 31)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(202, 103)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(332, 222)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword.HintForeColor = System.Drawing.Color.Silver
        Me.txtPassword.HintText = "Password"
        Me.txtPassword.isPassword = False
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtPassword.LineIdleColor = System.Drawing.Color.Gray
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtPassword.LineThickness = 3
        Me.txtPassword.Location = New System.Drawing.Point(212, 391)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(287, 37)
        Me.txtPassword.TabIndex = 17
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtUserName
        '
        Me.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUserName.HintForeColor = System.Drawing.Color.Silver
        Me.txtUserName.HintText = "Username"
        Me.txtUserName.isPassword = False
        Me.txtUserName.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtUserName.LineIdleColor = System.Drawing.Color.Gray
        Me.txtUserName.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtUserName.LineThickness = 3
        Me.txtUserName.Location = New System.Drawing.Point(212, 345)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(287, 37)
        Me.txtUserName.TabIndex = 16
        Me.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(725, 516)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents cmdLogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUserName As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
