Public Class InfoPenyewa

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        If Not String.IsNullOrEmpty(Home.DataPenyewa.fotoKTPProperty) Then
            PicFoto.Load(Home.DataPenyewa.fotoKTPProperty)
            PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        ' Add any initialization after the InitializeComponent() call.
        LblNIK.Text = Home.DataPenyewa.nikProperty
        LblNama.Text = Home.DataPenyewa.namaProperty
        LblAlamat.Text = Home.DataPenyewa.alamatProperty
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class