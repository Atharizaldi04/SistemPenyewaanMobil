Public Class InfoRiwayatTransaksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not String.IsNullOrEmpty(Home.DataRiwayatTransaksi.foto_mobilProperty) Then
            PicFoto.Load(Home.DataRiwayatTransaksi.foto_mobilProperty)
            PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        If Not String.IsNullOrEmpty(Home.DataRiwayatTransaksi.foto_ktpProperty) Then
            PictKTP.Load(Home.DataRiwayatTransaksi.foto_ktpProperty)
            PictKTP.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LblTotalBiaya.Text = FormatCurrency(Home.DataRiwayatTransaksi.biayaProperty)
        LblDenda.Text = FormatCurrency(Home.DataRiwayatTransaksi.dendaProperty)
        LblTotalBayar.Text = FormatCurrency(Home.DataRiwayatTransaksi.total_bayarProperty)
        LblMerk.Text = Home.DataRiwayatTransaksi.merkProperty
        LblNamaPenyewa.Text = Home.DataRiwayatTransaksi.namaProperty
        LblNik.Text = Home.DataRiwayatTransaksi.nikProperty
        LblPlatNomor.Text = Home.DataRiwayatTransaksi.plat_nomorProperty
        LblRencanaKembali.Text = Home.DataRiwayatTransaksi.tanggal_kembaliProperty
        LblTglPinjam.Text = Home.DataRiwayatTransaksi.tanggal_pinjamProperty


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class