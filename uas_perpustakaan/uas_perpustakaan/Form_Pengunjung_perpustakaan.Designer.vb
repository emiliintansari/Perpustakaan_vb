<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Pengunjung_perpustakaan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Pengunjung_perpustakaan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_nama = New System.Windows.Forms.TextBox()
        Me.tb_nim = New System.Windows.Forms.TextBox()
        Me.cbx_programstd = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LandingPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_kirim = New System.Windows.Forms.Button()
        Me.rb_baca = New System.Windows.Forms.RadioButton()
        Me.rd_pinjam = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(218, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(218, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nim"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(218, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Program Studi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(218, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Keperluan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(218, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tgl Berkunjung"
        '
        'tb_nama
        '
        Me.tb_nama.Location = New System.Drawing.Point(357, 92)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(200, 20)
        Me.tb_nama.TabIndex = 5
        '
        'tb_nim
        '
        Me.tb_nim.Location = New System.Drawing.Point(357, 123)
        Me.tb_nim.Name = "tb_nim"
        Me.tb_nim.Size = New System.Drawing.Size(200, 20)
        Me.tb_nim.TabIndex = 7
        '
        'cbx_programstd
        '
        Me.cbx_programstd.FormattingEnabled = True
        Me.cbx_programstd.Location = New System.Drawing.Point(357, 157)
        Me.cbx_programstd.Name = "cbx_programstd"
        Me.cbx_programstd.Size = New System.Drawing.Size(200, 21)
        Me.cbx_programstd.TabIndex = 11
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gray
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LandingPageToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(771, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LandingPageToolStripMenuItem
        '
        Me.LandingPageToolStripMenuItem.Name = "LandingPageToolStripMenuItem"
        Me.LandingPageToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.LandingPageToolStripMenuItem.Text = "BACK"
        '
        'btn_kirim
        '
        Me.btn_kirim.BackColor = System.Drawing.Color.Salmon
        Me.btn_kirim.ForeColor = System.Drawing.Color.Black
        Me.btn_kirim.Location = New System.Drawing.Point(239, 261)
        Me.btn_kirim.Name = "btn_kirim"
        Me.btn_kirim.Size = New System.Drawing.Size(318, 23)
        Me.btn_kirim.TabIndex = 14
        Me.btn_kirim.Text = "Kirim"
        Me.btn_kirim.UseVisualStyleBackColor = False
        '
        'rb_baca
        '
        Me.rb_baca.AutoSize = True
        Me.rb_baca.BackColor = System.Drawing.Color.Transparent
        Me.rb_baca.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rb_baca.Location = New System.Drawing.Point(357, 192)
        Me.rb_baca.Name = "rb_baca"
        Me.rb_baca.Size = New System.Drawing.Size(72, 17)
        Me.rb_baca.TabIndex = 15
        Me.rb_baca.TabStop = True
        Me.rb_baca.Text = "Membaca"
        Me.rb_baca.UseVisualStyleBackColor = False
        '
        'rd_pinjam
        '
        Me.rd_pinjam.AutoSize = True
        Me.rd_pinjam.BackColor = System.Drawing.Color.Transparent
        Me.rd_pinjam.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rd_pinjam.Location = New System.Drawing.Point(467, 192)
        Me.rd_pinjam.Name = "rd_pinjam"
        Me.rd_pinjam.Size = New System.Drawing.Size(72, 17)
        Me.rd_pinjam.TabIndex = 16
        Me.rd_pinjam.TabStop = True
        Me.rd_pinjam.Text = "Meminjam"
        Me.rd_pinjam.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(357, 221)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 17
        Me.DateTimePicker1.Value = New Date(2023, 8, 2, 11, 57, 52, 0)
        '
        'Form_Pengunjung_perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(771, 359)
        Me.ControlBox = False
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.rd_pinjam)
        Me.Controls.Add(Me.rb_baca)
        Me.Controls.Add(Me.btn_kirim)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cbx_programstd)
        Me.Controls.Add(Me.tb_nim)
        Me.Controls.Add(Me.tb_nama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Pengunjung_perpustakaan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengunjung"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_nama As TextBox
    Friend WithEvents tb_nim As TextBox
    Friend WithEvents cbx_programstd As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LandingPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_kirim As Button
    Friend WithEvents rb_baca As RadioButton
    Friend WithEvents rd_pinjam As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
