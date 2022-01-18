﻿Public Class TambahMobil

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
        DTTanggalData.Format = DateTimePickerFormat.Custom
        DTTanggalData.CustomFormat = "yyyy/MM/dd"
    End Sub


    Private Sub ReloadDataTableDatabase()
        DGJenisMobil.DataSource = Home.DataJenisMobil.GetDataJenisMobilDatabase()
    End Sub



    Private Sub TambahMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "|*.*"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PictMobil.Load(picKoleksiDir)
        PictMobil.SizeMode = PictureBoxSizeMode.StretchImage
        Home.DataMobil.foto_mobilProperty = picKoleksiDir.ToString()
        Home.DataMobil.foto_mobilProperty = Home.DataMobil.foto_mobilProperty.Replace("\", "/")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.DataMobil.id_jenis_mobilProperty = Txtidjenis.Text.ToString()
        Home.DataMobil.merekProperty = TxtMerk.Text.ToString()
        Home.DataMobil.platnomorProperty = TxtPlatNomor.Text.ToString()
        Home.DataMobil.harga_sewaProperty = TxtHargaSewa.Text.ToString()
        Home.DataMobil.tahun_pembuatanProperty = TxtTahunPembuatan.Text.ToString()
        Home.DataMobil.tanggal_data_masukProperty = DTTanggalData.Value.ToString("yyyy/MM/dd")
        Home.DataMobil.status_sewaProperty = CBStatus.SelectedItem().ToString()

        Home.DataMobil.AddDataMobilDatabase(Home.DataMobil.id_jenis_mobilProperty,
                                                Home.DataMobil.foto_mobilProperty,
                                                Home.DataMobil.merekProperty,
                                                Home.DataMobil.platnomorProperty,
                                                Home.DataMobil.harga_sewaProperty,
                                                Home.DataMobil.tahun_pembuatanProperty,
                                                Home.DataMobil.tanggal_data_masukProperty,
                                                Home.DataMobil.status_sewaProperty
                                                )

        Dim InfoTambah = New InfoMobil()
        InfoTambah.Show()
        Me.Close()
    End Sub

    Private Sub DGJenisMobil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGJenisMobil.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGJenisMobil.Rows(index)

        Txtidjenis.Text = selectedRow.Cells(0).Value
        TxtJenisMobil.Text = selectedRow.Cells(1).Value
    End Sub

End Class