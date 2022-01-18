Public Class SelesaiSewa

    Public Shared FotoMobil
    Public Shared FotoKTP
    Public Shared TotalHari
    Dim id_mobil
    Dim id_penyewa
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        DTTanggalKembali.Format = DateTimePickerFormat.Custom
        DTTanggalKembali.CustomFormat = "yyyy/MM/dd"

        DTTanggalPinjam.Format = DateTimePickerFormat.Custom
        DTTanggalPinjam.CustomFormat = "yyyy/MM/dd"

        DTRencana_Kembali.Format = DateTimePickerFormat.Custom
        DTRencana_Kembali.CustomFormat = "yyyy/MM/dd"

        If Not String.IsNullOrEmpty(Home.DataSewa.foto_mobilProperty) Then
            PicFoto.Load(Home.DataSewa.foto_mobilProperty)
            PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        If Not String.IsNullOrEmpty(Home.DataSewa.foto_ktpProperty) Then
            PictKTP.Load(Home.DataSewa.foto_ktpProperty)
            PictKTP.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        DTRencana_Kembali.Value = Home.DataSewa.rencana_pinjamProperty
        DTTanggalPinjam.Value = Home.DataSewa.tanggal_pinjamProperty
        TotalHari = Home.DataSewa.lamaSewaProperty
        TxtMerek.Text = Home.DataSewa.merkProperty
        TxtPlatNomor.Text = Home.DataSewa.platNomorProperty
        TxtNik.Text = Home.DataSewa.nikProperty
        TxtNama.Text = Home.DataSewa.namaProperty
        TxtBiayaSewa.Text = FormatCurrency(Home.DataSewa.hargaunitProperty)
        TXTTotalBiaya.Text = FormatCurrency(Home.DataSewa.total_biaya_SewaProperty)
        id_mobil = Home.DataSewa.id_mobilProperty
        id_penyewa = Home.DataSewa.id_penyewaProperty

        DTRencana_Kembali.Enabled = False
        DTTanggalPinjam.Enabled = False
        TxtMerek.ReadOnly = True
        TxtPlatNomor.ReadOnly = True
        TxtNik.ReadOnly = True
        TxtNama.ReadOnly = True
        TxtBiayaSewa.ReadOnly = True
        TXTTotalBiaya.ReadOnly = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dt1 As DateTime = Convert.ToDateTime(DTRencana_Kembali.Text)
        Dim dt2 As DateTime = Convert.ToDateTime(DTTanggalKembali.Text)
        Dim ts As TimeSpan
        Dim TotalTerlambat
        Dim totaldenda
        Dim biaya
        Dim totalbayar

        ts = dt2.Subtract(dt1)
        TotalTerlambat = Convert.ToInt32(ts.Days)
        totaldenda = TotalTerlambat * 500000

        biaya = Home.DataSewa.total_biaya_SewaProperty
        TxtTerlambat.Text = TotalTerlambat.ToString() + " Hari"
        TxtDenda.Text = FormatCurrency(totaldenda)
        TxtTotalBayar.Text = FormatCurrency(totaldenda + Home.DataSewa.total_biaya_SewaProperty)
        totalbayar = totaldenda + Home.DataSewa.total_biaya_SewaProperty

        Home.DataRiwayatTransaksi.biayaProperty = biaya
        Home.DataRiwayatTransaksi.dendaProperty = totaldenda
        Home.DataRiwayatTransaksi.total_bayarProperty = totalbayar
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Home.DataRiwayatTransaksi.merkProperty = TxtMerek.Text.ToString()
        Home.DataRiwayatTransaksi.plat_nomorProperty = TxtPlatNomor.Text.ToString()
        Home.DataRiwayatTransaksi.nikProperty = TxtNik.Text.ToString()
        Home.DataRiwayatTransaksi.namaProperty = TxtNama.Text.ToString()
        Home.DataRiwayatTransaksi.tanggal_pinjamProperty = DTTanggalPinjam.Value.ToString("yyyy/MM/dd")
        Home.DataRiwayatTransaksi.tanggal_kembaliProperty = DTTanggalKembali.Value.ToString("yyyy/MM/dd")


        Home.DataRiwayatTransaksi.foto_mobilProperty = Home.DataSewa.foto_mobilProperty.ToString()
        Home.DataRiwayatTransaksi.foto_mobilProperty = Home.DataRiwayatTransaksi.foto_mobilProperty.Replace("\", "/")

        Home.DataRiwayatTransaksi.foto_ktpProperty = Home.DataSewa.foto_ktpProperty.ToString()
        Home.DataRiwayatTransaksi.foto_ktpProperty = Home.DataRiwayatTransaksi.foto_ktpProperty.Replace("\", "/")

        Home.DataRiwayatTransaksi.status_mobilProperty = "Tersedia"
        Home.DataRiwayatTransaksi.status_penyewaProperty = "Tersedia"

        Home.DataRiwayatTransaksi.AddDataRiwayatDatabase(Home.DataRiwayatTransaksi.foto_mobilProperty,
                                                        Home.DataRiwayatTransaksi.foto_ktpProperty,
                                                        Home.DataRiwayatTransaksi.merkProperty,
                                                        Home.DataRiwayatTransaksi.plat_nomorProperty,
                                                        Home.DataRiwayatTransaksi.nikProperty,
                                                        Home.DataRiwayatTransaksi.namaProperty,
                                                        Home.DataRiwayatTransaksi.tanggal_pinjamProperty,
                                                        Home.DataRiwayatTransaksi.tanggal_kembaliProperty,
                                                        Home.DataRiwayatTransaksi.biayaProperty,
                                                        Home.DataRiwayatTransaksi.dendaProperty,
                                                        Home.DataRiwayatTransaksi.total_bayarProperty
                                                        )


        Home.DataMobil.UpdateStatusMobilByIDDatabase(id_mobil,
                                                     Home.DataRiwayatTransaksi.status_mobilProperty)

        Home.DataPenyewa.UpdateStatusPenyewaByIDDatabase(id_penyewa,
                                                         Home.DataRiwayatTransaksi.status_penyewaProperty)

        Home.DataSewa.DeleteDataSewalByIDDatabase(Sewa.SelectedTableSewa)
        Me.Close()
    End Sub
End Class