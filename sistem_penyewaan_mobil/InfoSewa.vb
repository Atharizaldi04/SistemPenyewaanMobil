Public Class InfoSewa
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not String.IsNullOrEmpty(Home.DataSewa.foto_mobilProperty) Then
            PicFoto.Load(Home.DataSewa.foto_mobilProperty)
            PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        If Not String.IsNullOrEmpty(Home.DataSewa.foto_ktpProperty) Then
            PictKTP.Load(Home.DataSewa.foto_ktpProperty)
            PictKTP.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LblHargaSewa.Text = FormatCurrency(Home.DataSewa.hargaunitProperty)
        LblLamaSewa.Text = Home.DataSewa.lamaSewaProperty
        LblMerk.Text = Home.DataSewa.merkProperty
        LblNamaPenyewa.Text = Home.DataSewa.namaProperty
        LblNik.Text = Home.DataSewa.nikProperty
        LblPlatNomor.Text = Home.DataSewa.platNomorProperty
        LblRencanaKembali.Text = Home.DataSewa.rencana_pinjamProperty
        LblTglPinjam.Text = Home.DataSewa.tanggal_pinjamProperty
        LblTotalBiaya.Text = FormatCurrency(Home.DataSewa.total_biaya_SewaProperty)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
End Class