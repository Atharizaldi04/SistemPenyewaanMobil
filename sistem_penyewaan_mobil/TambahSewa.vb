Public Class TambahSewa

    Public Shared FotoMobil
    Public Shared FotoKTP
    Public Shared TotalHari


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ReloadDataTableDatabase()
        ' Add any initialization after the InitializeComponent() call.
        DTRencana_kembali.Format = DateTimePickerFormat.Custom
        DTRencana_kembali.CustomFormat = "yyyy/MM/dd"
        DTTanggalPinjam.Format = DateTimePickerFormat.Custom
        DTTanggalPinjam.CustomFormat = "yyyy/MM/dd"

    End Sub



    Private Sub ReloadDataTableDatabase()
        DGMobil.DataSource = Home.DataMobil.GetDataMobilDatabase()
        DGPenyewa.DataSource = Home.DataPenyewa.GetDataPenyewaDatabase()

    End Sub

    Private Sub TambahSewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.DataSewa.id_mobilProperty = Txtidmobil.Text.ToString()
        Home.DataSewa.id_penyewaProperty = Txtidpenyewa.Text.ToString()
        Home.DataSewa.rencana_pinjamProperty = DTRencana_kembali.Value.ToString("yyyy/MM/dd")
        Home.DataSewa.tanggal_pinjamProperty = DTTanggalPinjam.Value.ToString("yyyy/MM/dd")
        Home.DataSewa.lamaSewaProperty = TotalHari
        Home.DataSewa.merkProperty = TxtMerek.Text.ToString()
        Home.DataSewa.platNomorProperty = TxtPlatNomor.Text.ToString()
        Home.DataSewa.nikProperty = TxtNik.Text.ToString()
        Home.DataSewa.namaProperty = TxtNama.Text.ToString()
        Home.DataSewa.hargaunitProperty = TxtBiayaSewa.Text.ToString()
        Home.DataSewa.status_sewaProperty = "Belum Selesai"
        Home.DataSewa.tanggal_kembaliProperty = Nothing
        Home.DataSewa.biaya_kelebihan_pinjamProperty = Nothing
        Home.DataSewa.status_sewa_mobilProperty = "Tidak Tersedia"
        Home.DataSewa.status_penyewaProperty = "Tidak Tersedia"


        Home.DataSewa.AddDataSewaDatabase(Home.DataSewa.id_mobilProperty,
                                                Home.DataSewa.id_penyewaProperty,
                                                Home.DataSewa.rencana_pinjamProperty,
                                                Home.DataSewa.tanggal_pinjamProperty,
                                                Home.DataSewa.total_biaya_SewaProperty,
                                                Home.DataSewa.status_sewaProperty,
                                                Home.DataSewa.biaya_kelebihan_pinjamProperty,
                                                Home.DataSewa.total_bayarProperty,
                                                Home.DataSewa.lamaSewaProperty
                                                )

        Home.DataMobil.UpdateStatusMobilByIDDatabase(Home.DataSewa.id_mobilProperty,
                                                     Home.DataSewa.status_sewa_mobilProperty)

        Home.DataPenyewa.UpdateStatusPenyewaByIDDatabase(Home.DataSewa.id_penyewaProperty,
                                                         Home.DataSewa.status_penyewaProperty)


        Dim InfoTambah = New InfoSewa()
        InfoTambah.Show()
        Me.Close()

    End Sub

    Private Sub DGMobil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGMobil.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGMobil.Rows(index)

        If selectedRow.Cells(7).Value.ToString() = "Tersedia" Then
            Txtidmobil.Text = selectedRow.Cells(0).Value
            TxtMerek.Text = selectedRow.Cells(2).Value
            TxtPlatNomor.Text = selectedRow.Cells(3).Value
            TxtBiayaSewa.Text = FormatCurrency(selectedRow.Cells(4).Value)
        Else
            MessageBox.Show("Mobil Tidak Tersedia.")
        End If

        'FotoMobil = selectedRow.Cells(8).Value
        If Not String.IsNullOrEmpty(selectedRow.Cells(8).Value) Then
            PicFoto.Load(selectedRow.Cells(8).Value)
            PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
            Home.DataSewa.foto_mobilProperty = selectedRow.Cells(8).Value.ToString
            Home.DataSewa.foto_mobilProperty = Home.DataSewa.foto_mobilProperty.Replace("\", "/")
        End If



    End Sub

    Private Sub DGPenyewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPenyewa.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGPenyewa.Rows(index)

        If selectedRow.Cells(5).Value.ToString() = "Tersedia" Then
            Txtidpenyewa.Text = selectedRow.Cells(0).Value
            TxtNik.Text = selectedRow.Cells(1).Value
            TxtNama.Text = selectedRow.Cells(2).Value
        Else
            MessageBox.Show("Penyewa Sedang Melakukan Sewa")
        End If

        If Not String.IsNullOrEmpty(selectedRow.Cells(4).Value) Then
            'FotoKTP = selectedRow.Cells(4).Value
            PictKTP.Load(selectedRow.Cells(4).Value)
            PictKTP.SizeMode = PictureBoxSizeMode.StretchImage
            Home.DataSewa.foto_ktpProperty = selectedRow.Cells(4).Value.ToString
            Home.DataSewa.foto_ktpProperty = Home.DataSewa.foto_ktpProperty.Replace("\", "/")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dt1 As DateTime = Convert.ToDateTime(DTTanggalPinjam.Text)
        Dim dt2 As DateTime = Convert.ToDateTime(DTRencana_kembali.Text)
        Dim ts As TimeSpan

        Dim totalbiaya

        ts = dt2.Subtract(dt1)
        TotalHari = Convert.ToInt32(ts.Days)
        totalbiaya = TotalHari * TxtBiayaSewa.Text
        TXTTotalBiaya.Text = FormatCurrency(totalbiaya)
        Home.DataSewa.total_biaya_SewaProperty = totalbiaya
    End Sub
End Class