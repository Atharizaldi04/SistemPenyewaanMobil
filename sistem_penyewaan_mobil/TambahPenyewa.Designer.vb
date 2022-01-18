<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahPenyewa
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
        Me.RTBAlamat = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNIK = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RTBAlamat
        '
        Me.RTBAlamat.Location = New System.Drawing.Point(442, 260)
        Me.RTBAlamat.Name = "RTBAlamat"
        Me.RTBAlamat.Size = New System.Drawing.Size(253, 120)
        Me.RTBAlamat.TabIndex = 66
        Me.RTBAlamat.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(263, 411)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 29)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "Tambah Penyewa"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PicFoto
        '
        Me.PicFoto.Location = New System.Drawing.Point(36, 135)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(141, 106)
        Me.PicFoto.TabIndex = 64
        Me.PicFoto.TabStop = False
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Location = New System.Drawing.Point(36, 260)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(141, 29)
        Me.BtnTambahGambar.TabIndex = 63
        Me.BtnTambahGambar.Text = "Upload Foto KTP"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(199, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Alamat Penyewa"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(442, 195)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(253, 27)
        Me.TxtNama.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(199, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Nama Penyewa"
        '
        'TxtNIK
        '
        Me.TxtNIK.Location = New System.Drawing.Point(442, 135)
        Me.TxtNIK.Name = "TxtNIK"
        Me.TxtNIK.Size = New System.Drawing.Size(253, 27)
        Me.TxtNIK.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(199, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 20)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Nik"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(263, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(244, 38)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Tambah Penyewa"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TambahPenyewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 465)
        Me.Controls.Add(Me.RTBAlamat)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNIK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Name = "TambahPenyewa"
        Me.Text = "TambahPenyewa"
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RTBAlamat As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNIK As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
