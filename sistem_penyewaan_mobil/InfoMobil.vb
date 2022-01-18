Public Class InfoMobil
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        If Not String.IsNullOrEmpty(Home.DataMobil.foto_mobilProperty) Then
            PictMobil.Load(Home.DataMobil.foto_mobilProperty)
            PictMobil.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        ' Add any initialization after the InitializeComponent() call.
        LblJenisMobil.Text = Home.DataMobil.id_jenis_mobilProperty
        LblMerek.Text = Home.DataMobil.merekProperty
        LblPlatNomor.Text = Home.DataMobil.platnomorProperty
        LblHargaSewa.Text = Home.DataMobil.harga_sewaProperty
        LblTahunPembuatan.Text = Home.DataMobil.tahun_pembuatanProperty
        LblTanggalDataMasuk.Text = Home.DataMobil.tanggal_data_masukProperty
        LblStatusSewa.Text = Home.DataMobil.status_sewaProperty
        ReloadDataTableDatabase()

    End Sub

    Private Sub ReloadDataTableDatabase()
        DGJenisMobil.DataSource = Home.DataJenisMobil.GetDataJenisMobilDatabase()
    End Sub

    Private Sub InfoMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class