<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penyewa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Penyewa))
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridPenyewa = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridPenyewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(225, 69)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 31)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Lihat"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(28, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 31)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Penyewa"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(110, 69)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 31)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(69, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 33)
        Me.Button2.TabIndex = 23
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.sistem_penyewaan_mobil.My.Resources.Resources.ceklis
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(28, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 33)
        Me.Button1.TabIndex = 22
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridPenyewa
        '
        Me.DataGridPenyewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPenyewa.Location = New System.Drawing.Point(28, 106)
        Me.DataGridPenyewa.Name = "DataGridPenyewa"
        Me.DataGridPenyewa.RowHeadersWidth = 51
        Me.DataGridPenyewa.RowTemplate.Height = 29
        Me.DataGridPenyewa.Size = New System.Drawing.Size(550, 422)
        Me.DataGridPenyewa.TabIndex = 21
        '
        'Penyewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 540)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridPenyewa)
        Me.Name = "Penyewa"
        Me.Text = "Penyewa"
        CType(Me.DataGridPenyewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridPenyewa As DataGridView
End Class
