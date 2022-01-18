<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RiwayatTransaksi
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
        Me.BtnLihat = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTAkhir = New System.Windows.Forms.DateTimePicker()
        Me.DTAwal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGRiwayatTransaksi = New System.Windows.Forms.DataGridView()
        CType(Me.DGRiwayatTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLihat
        '
        Me.BtnLihat.Location = New System.Drawing.Point(39, 520)
        Me.BtnLihat.Name = "BtnLihat"
        Me.BtnLihat.Size = New System.Drawing.Size(122, 29)
        Me.BtnLihat.TabIndex = 23
        Me.BtnLihat.Text = "Lihat"
        Me.BtnLihat.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(726, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(642, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 25)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "/"
        '
        'DTAkhir
        '
        Me.DTAkhir.Location = New System.Drawing.Point(667, 139)
        Me.DTAkhir.Name = "DTAkhir"
        Me.DTAkhir.Size = New System.Drawing.Size(154, 27)
        Me.DTAkhir.TabIndex = 20
        '
        'DTAwal
        '
        Me.DTAwal.Location = New System.Drawing.Point(482, 139)
        Me.DTAwal.Name = "DTAwal"
        Me.DTAwal.Size = New System.Drawing.Size(154, 27)
        Me.DTAwal.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(307, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 38)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Riwayat Transaksi"
        '
        'DGRiwayatTransaksi
        '
        Me.DGRiwayatTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRiwayatTransaksi.Location = New System.Drawing.Point(39, 215)
        Me.DGRiwayatTransaksi.Name = "DGRiwayatTransaksi"
        Me.DGRiwayatTransaksi.RowHeadersWidth = 51
        Me.DGRiwayatTransaksi.RowTemplate.Height = 29
        Me.DGRiwayatTransaksi.Size = New System.Drawing.Size(782, 299)
        Me.DGRiwayatTransaksi.TabIndex = 17
        '
        'RiwayatTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 577)
        Me.Controls.Add(Me.BtnLihat)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTAkhir)
        Me.Controls.Add(Me.DTAwal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGRiwayatTransaksi)
        Me.Name = "RiwayatTransaksi"
        Me.Text = "RiwayatTransaksi"
        CType(Me.DGRiwayatTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLihat As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DTAkhir As DateTimePicker
    Friend WithEvents DTAwal As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DGRiwayatTransaksi As DataGridView
End Class
