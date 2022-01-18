<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahMobil
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
        Me.Txtidjenis = New System.Windows.Forms.TextBox()
        Me.DTTanggalData = New System.Windows.Forms.DateTimePicker()
        Me.TxtPlatNomor = New System.Windows.Forms.TextBox()
        Me.PictMobil = New System.Windows.Forms.PictureBox()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DGJenisMobil = New System.Windows.Forms.DataGridView()
        Me.CBStatus = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTahunPembuatan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMerk = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtHargaSewa = New System.Windows.Forms.TextBox()
        Me.TxtJenisMobil = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGJenisMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txtidjenis
        '
        Me.Txtidjenis.Location = New System.Drawing.Point(844, 183)
        Me.Txtidjenis.Name = "Txtidjenis"
        Me.Txtidjenis.Size = New System.Drawing.Size(26, 27)
        Me.Txtidjenis.TabIndex = 135
        '
        'DTTanggalData
        '
        Me.DTTanggalData.Location = New System.Drawing.Point(543, 448)
        Me.DTTanggalData.Name = "DTTanggalData"
        Me.DTTanggalData.Size = New System.Drawing.Size(250, 27)
        Me.DTTanggalData.TabIndex = 134
        '
        'TxtPlatNomor
        '
        Me.TxtPlatNomor.Location = New System.Drawing.Point(543, 271)
        Me.TxtPlatNomor.Name = "TxtPlatNomor"
        Me.TxtPlatNomor.Size = New System.Drawing.Size(253, 27)
        Me.TxtPlatNomor.TabIndex = 133
        '
        'PictMobil
        '
        Me.PictMobil.Location = New System.Drawing.Point(41, 174)
        Me.PictMobil.Name = "PictMobil"
        Me.PictMobil.Size = New System.Drawing.Size(184, 106)
        Me.PictMobil.TabIndex = 132
        Me.PictMobil.TabStop = False
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Location = New System.Drawing.Point(41, 299)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(184, 29)
        Me.BtnTambahGambar.TabIndex = 131
        Me.BtnTambahGambar.Text = "Upload Foto Mobil"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(685, 606)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 29)
        Me.Button1.TabIndex = 130
        Me.Button1.Text = "Tambah Mobil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(965, 163)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(186, 31)
        Me.Label11.TabIndex = 129
        Me.Label11.Text = "Data Jenis Mobil"
        '
        'DGJenisMobil
        '
        Me.DGJenisMobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGJenisMobil.Location = New System.Drawing.Point(844, 216)
        Me.DGJenisMobil.Name = "DGJenisMobil"
        Me.DGJenisMobil.RowHeadersWidth = 51
        Me.DGJenisMobil.RowTemplate.Height = 29
        Me.DGJenisMobil.Size = New System.Drawing.Size(426, 322)
        Me.DGJenisMobil.TabIndex = 128
        '
        'CBStatus
        '
        Me.CBStatus.FormattingEnabled = True
        Me.CBStatus.Items.AddRange(New Object() {"Tersedia", "Tidak Tersedia"})
        Me.CBStatus.Location = New System.Drawing.Point(543, 510)
        Me.CBStatus.Name = "CBStatus"
        Me.CBStatus.Size = New System.Drawing.Size(253, 28)
        Me.CBStatus.TabIndex = 127
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(297, 513)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 20)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "Satatus Sewa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(297, 448)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 20)
        Me.Label8.TabIndex = 125
        Me.Label8.Text = "Tanggal Data Masuk"
        '
        'TxtTahunPembuatan
        '
        Me.TxtTahunPembuatan.Location = New System.Drawing.Point(543, 388)
        Me.TxtTahunPembuatan.Name = "TxtTahunPembuatan"
        Me.TxtTahunPembuatan.Size = New System.Drawing.Size(253, 27)
        Me.TxtTahunPembuatan.TabIndex = 124
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(297, 388)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Tahun Pembuatan"
        '
        'TxtMerk
        '
        Me.TxtMerk.Location = New System.Drawing.Point(543, 221)
        Me.TxtMerk.Name = "TxtMerk"
        Me.TxtMerk.Size = New System.Drawing.Size(253, 27)
        Me.TxtMerk.TabIndex = 122
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(600, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(206, 38)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "Tambah Mobil"
        '
        'TxtHargaSewa
        '
        Me.TxtHargaSewa.Location = New System.Drawing.Point(543, 327)
        Me.TxtHargaSewa.Name = "TxtHargaSewa"
        Me.TxtHargaSewa.Size = New System.Drawing.Size(253, 27)
        Me.TxtHargaSewa.TabIndex = 120
        '
        'TxtJenisMobil
        '
        Me.TxtJenisMobil.Location = New System.Drawing.Point(543, 174)
        Me.TxtJenisMobil.Name = "TxtJenisMobil"
        Me.TxtJenisMobil.Size = New System.Drawing.Size(253, 27)
        Me.TxtJenisMobil.TabIndex = 119
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(297, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "Harga Sewa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(297, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Plat Nomor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(297, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Merk"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(297, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Jenis Mobil"
        '
        'TambahMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1318, 666)
        Me.Controls.Add(Me.Txtidjenis)
        Me.Controls.Add(Me.DTTanggalData)
        Me.Controls.Add(Me.TxtPlatNomor)
        Me.Controls.Add(Me.PictMobil)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DGJenisMobil)
        Me.Controls.Add(Me.CBStatus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTahunPembuatan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtMerk)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtHargaSewa)
        Me.Controls.Add(Me.TxtJenisMobil)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Name = "TambahMobil"
        Me.Text = "TambahMobil"
        CType(Me.PictMobil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGJenisMobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtidjenis As TextBox
    Friend WithEvents DTTanggalData As DateTimePicker
    Friend WithEvents TxtPlatNomor As TextBox
    Friend WithEvents PictMobil As PictureBox
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents DGJenisMobil As DataGridView
    Friend WithEvents CBStatus As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtTahunPembuatan As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtMerk As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtHargaSewa As TextBox
    Friend WithEvents TxtJenisMobil As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
End Class
