<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahJenisMobil
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
        Me.DTPJenisMobil = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtJeniMobil = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DTPJenisMobil
        '
        Me.DTPJenisMobil.Location = New System.Drawing.Point(162, 200)
        Me.DTPJenisMobil.Name = "DTPJenisMobil"
        Me.DTPJenisMobil.Size = New System.Drawing.Size(236, 27)
        Me.DTPJenisMobil.TabIndex = 31
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(172, 278)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxtJeniMobil
        '
        Me.TxtJeniMobil.Location = New System.Drawing.Point(162, 127)
        Me.TxtJeniMobil.Name = "TxtJeniMobil"
        Me.TxtJeniMobil.Size = New System.Drawing.Size(236, 27)
        Me.TxtJeniMobil.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Created At"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Jenis Mobil"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(88, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 38)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Tambah Jenis Mobil"
        '
        'TambahJenisMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 344)
        Me.Controls.Add(Me.DTPJenisMobil)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TxtJeniMobil)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TambahJenisMobil"
        Me.Text = "TambahJenisMobil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DTPJenisMobil As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtJeniMobil As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
