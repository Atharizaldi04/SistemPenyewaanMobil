<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahSewa
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictKTP = New System.Windows.Forms.PictureBox()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.Txtidpenyewa = New System.Windows.Forms.TextBox()
        Me.Txtidmobil = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGMobil = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DGPenyewa = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtMerek = New System.Windows.Forms.TextBox()
        Me.TXTTotalBiaya = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtBiayaSewa = New System.Windows.Forms.TextBox()
        Me.TxtNik = New System.Windows.Forms.TextBox()
        Me.DTTanggalPinjam = New System.Windows.Forms.DateTimePicker()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.DTRencana_kembali = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtPlatNomor = New System.Windows.Forms.TextBox()
        CType(Me.PictKTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGPenyewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(359, 325)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 25)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Foto KTP Penyewa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(98, 325)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 25)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Foto Mobil"
        '
        'PictKTP
        '
        Me.PictKTP.Location = New System.Drawing.Point(324, 182)
        Me.PictKTP.Name = "PictKTP"
        Me.PictKTP.Size = New System.Drawing.Size(236, 129)
        Me.PictKTP.TabIndex = 114
        Me.PictKTP.TabStop = False
        '
        'PicFoto
        '
        Me.PicFoto.Location = New System.Drawing.Point(44, 182)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(236, 129)
        Me.PicFoto.TabIndex = 113
        Me.PicFoto.TabStop = False
        '
        'Txtidpenyewa
        '
        Me.Txtidpenyewa.Location = New System.Drawing.Point(614, 234)
        Me.Txtidpenyewa.Name = "Txtidpenyewa"
        Me.Txtidpenyewa.Size = New System.Drawing.Size(25, 27)
        Me.Txtidpenyewa.TabIndex = 112
        '
        'Txtidmobil
        '
        Me.Txtidmobil.Location = New System.Drawing.Point(614, 534)
        Me.Txtidmobil.Name = "Txtidmobil"
        Me.Txtidmobil.Size = New System.Drawing.Size(25, 27)
        Me.Txtidmobil.TabIndex = 111
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(814, 520)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 31)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Data Mobil"
        '
        'DGMobil
        '
        Me.DGMobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMobil.Location = New System.Drawing.Point(614, 567)
        Me.DGMobil.Name = "DGMobil"
        Me.DGMobil.RowHeadersWidth = 51
        Me.DGMobil.RowTemplate.Height = 29
        Me.DGMobil.Size = New System.Drawing.Size(541, 240)
        Me.DGMobil.TabIndex = 109
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(501, 949)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 29)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "Tambah Sewa"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(800, 215)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 31)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Data Penyewa"
        '
        'DGPenyewa
        '
        Me.DGPenyewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPenyewa.Location = New System.Drawing.Point(614, 267)
        Me.DGPenyewa.Name = "DGPenyewa"
        Me.DGPenyewa.RowHeadersWidth = 51
        Me.DGPenyewa.RowTemplate.Height = 29
        Me.DGPenyewa.Size = New System.Drawing.Size(541, 222)
        Me.DGPenyewa.TabIndex = 106
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(501, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(197, 38)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Tambah Sewa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(25, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(553, 235)
        Me.GroupBox1.TabIndex = 117
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dokumen"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.TxtMerek)
        Me.GroupBox2.Controls.Add(Me.TXTTotalBiaya)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtBiayaSewa)
        Me.GroupBox2.Controls.Add(Me.TxtNik)
        Me.GroupBox2.Controls.Add(Me.DTTanggalPinjam)
        Me.GroupBox2.Controls.Add(Me.TxtNama)
        Me.GroupBox2.Controls.Add(Me.DTRencana_kembali)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TxtPlatNomor)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 387)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(553, 534)
        Me.GroupBox2.TabIndex = 118
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Form"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(269, 495)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 102
        Me.Button2.Text = "Hitung"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxtMerek
        '
        Me.TxtMerek.Location = New System.Drawing.Point(269, 47)
        Me.TxtMerek.Name = "TxtMerek"
        Me.TxtMerek.Size = New System.Drawing.Size(253, 27)
        Me.TxtMerek.TabIndex = 72
        '
        'TXTTotalBiaya
        '
        Me.TXTTotalBiaya.Location = New System.Drawing.Point(269, 461)
        Me.TXTTotalBiaya.Name = "TXTTotalBiaya"
        Me.TXTTotalBiaya.Size = New System.Drawing.Size(253, 27)
        Me.TXTTotalBiaya.TabIndex = 101
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 20)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Merk"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 461)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 20)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "Total Biaya Sewa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Nik Penyewa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 339)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Rencana Kembali"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Tanggal Pinjam"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 400)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 20)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Harga Sewa Unit"
        '
        'TxtBiayaSewa
        '
        Me.TxtBiayaSewa.Location = New System.Drawing.Point(266, 400)
        Me.TxtBiayaSewa.Name = "TxtBiayaSewa"
        Me.TxtBiayaSewa.Size = New System.Drawing.Size(253, 27)
        Me.TxtBiayaSewa.TabIndex = 74
        '
        'TxtNik
        '
        Me.TxtNik.Location = New System.Drawing.Point(269, 158)
        Me.TxtNik.Name = "TxtNik"
        Me.TxtNik.Size = New System.Drawing.Size(253, 27)
        Me.TxtNik.TabIndex = 76
        '
        'DTTanggalPinjam
        '
        Me.DTTanggalPinjam.Location = New System.Drawing.Point(269, 274)
        Me.DTTanggalPinjam.Name = "DTTanggalPinjam"
        Me.DTTanggalPinjam.Size = New System.Drawing.Size(250, 27)
        Me.DTTanggalPinjam.TabIndex = 77
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(269, 210)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(253, 27)
        Me.TxtNama.TabIndex = 93
        '
        'DTRencana_kembali
        '
        Me.DTRencana_kembali.Location = New System.Drawing.Point(269, 339)
        Me.DTRencana_kembali.Name = "DTRencana_kembali"
        Me.DTRencana_kembali.Size = New System.Drawing.Size(250, 27)
        Me.DTRencana_kembali.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 20)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Nama Penyewa"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 20)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Plat Nomor"
        '
        'TxtPlatNomor
        '
        Me.TxtPlatNomor.Location = New System.Drawing.Point(269, 99)
        Me.TxtPlatNomor.Name = "TxtPlatNomor"
        Me.TxtPlatNomor.Size = New System.Drawing.Size(253, 27)
        Me.TxtPlatNomor.TabIndex = 89
        '
        'TambahSewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 1055)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictKTP)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.Txtidpenyewa)
        Me.Controls.Add(Me.Txtidmobil)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGMobil)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DGPenyewa)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "TambahSewa"
        Me.Text = "TambahSewa"
        CType(Me.PictKTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGMobil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGPenyewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictKTP As PictureBox
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents Txtidpenyewa As TextBox
    Friend WithEvents Txtidmobil As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGMobil As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents DGPenyewa As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtMerek As TextBox
    Friend WithEvents TXTTotalBiaya As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtBiayaSewa As TextBox
    Friend WithEvents TxtNik As TextBox
    Friend WithEvents DTTanggalPinjam As DateTimePicker
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents DTRencana_kembali As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtPlatNomor As TextBox
End Class
