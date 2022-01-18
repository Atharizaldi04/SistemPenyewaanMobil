Public Class Sewa

    Public Shared SelectedTableSewa
    Public Shared SelectedIdPenyewa
    Public Shared SelectedIdMobil

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formtambah = New TambahSewa()
        formtambah.Show()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DGSewa.DataSource = Home.DataSewa.GetDataSewaDatabase()
    End Sub

    Private Sub Sewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim selectedSewa As List(Of String) = Home.DataSewa.GetDataSewaLihatByIDDatabase(SelectedTableSewa)
        Dim selectedMobil As List(Of String) = Home.DataSewa.GetDataMobilLihatByIDDatabase(SelectedIdMobil)
        Dim selectedPenyewa As List(Of String) = Home.DataSewa.GetDataPenyewaLihatByIDDatabase(SelectedIdPenyewa)

        Home.DataSewa.rencana_pinjamProperty = selectedSewa(0)
        Home.DataSewa.tanggal_pinjamProperty = selectedSewa(1)
        Home.DataSewa.total_biaya_SewaProperty = selectedSewa(2)
        Home.DataSewa.lamaSewaProperty = selectedSewa(3)
        Home.DataSewa.foto_mobilProperty = selectedMobil(0)
        Home.DataSewa.hargaunitProperty = selectedMobil(1)
        Home.DataSewa.merkProperty = selectedMobil(2)
        Home.DataSewa.platNomorProperty = selectedMobil(3)
        Home.DataSewa.namaProperty = selectedPenyewa(0)
        Home.DataSewa.nikProperty = selectedPenyewa(1)
        Home.DataSewa.foto_ktpProperty = selectedPenyewa(2)

        Dim FormInfo = New InfoSewa()
        FormInfo.Show()
    End Sub

    Private Sub DGSewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSewa.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGSewa.Rows(index)

        SelectedTableSewa = selectedRow.Cells(0).Value
        SelectedIdMobil = selectedRow.Cells(2).Value
        SelectedIdPenyewa = selectedRow.Cells(3).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim selectedSewa As List(Of String) = Home.DataSewa.GetDataSewaEditByIDDatabase(SelectedTableSewa)
        Dim selectedMobil As List(Of String) = Home.DataSewa.GetDataMobilLihatByIDDatabase(SelectedIdMobil)
        Dim selectedPenyewa As List(Of String) = Home.DataSewa.GetDataPenyewaLihatByIDDatabase(SelectedIdPenyewa)

        Home.DataSewa.id_mobilProperty = selectedSewa(0)
        Home.DataSewa.id_penyewaProperty = selectedSewa(1)
        Home.DataSewa.rencana_pinjamProperty = selectedSewa(2)
        Home.DataSewa.tanggal_pinjamProperty = selectedSewa(3)
        Home.DataSewa.lamaSewaProperty = selectedSewa(4)
        Home.DataSewa.total_biaya_SewaProperty = selectedSewa(5)
        Home.DataSewa.foto_mobilProperty = selectedMobil(0)
        Home.DataSewa.hargaunitProperty = selectedMobil(1)
        Home.DataSewa.merkProperty = selectedMobil(2)
        Home.DataSewa.platNomorProperty = selectedMobil(3)
        Home.DataSewa.namaProperty = selectedPenyewa(0)
        Home.DataSewa.nikProperty = selectedPenyewa(1)
        Home.DataSewa.foto_ktpProperty = selectedPenyewa(2)

        Dim FormInfo = New EditSewa()
        FormInfo.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedSewa As List(Of String) = Home.DataSewa.GetDataSewaLihatByIDDatabase(SelectedTableSewa)
        Dim selectedMobil As List(Of String) = Home.DataSewa.GetDataMobilLihatByIDDatabase(SelectedIdMobil)
        Dim selectedPenyewa As List(Of String) = Home.DataSewa.GetDataPenyewaLihatByIDDatabase(SelectedIdPenyewa)

        Home.DataSewa.rencana_pinjamProperty = selectedSewa(0)
        Home.DataSewa.tanggal_pinjamProperty = selectedSewa(1)
        Home.DataSewa.total_biaya_SewaProperty = selectedSewa(2)
        Home.DataSewa.lamaSewaProperty = selectedSewa(3)
        Home.DataSewa.foto_mobilProperty = selectedMobil(0)
        Home.DataSewa.hargaunitProperty = selectedMobil(1)
        Home.DataSewa.merkProperty = selectedMobil(2)
        Home.DataSewa.platNomorProperty = selectedMobil(3)
        Home.DataSewa.namaProperty = selectedPenyewa(0)
        Home.DataSewa.nikProperty = selectedPenyewa(1)
        Home.DataSewa.foto_ktpProperty = selectedPenyewa(2)
        Dim FormHapus = New HapusSewa()
        FormHapus.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim selectedSewa As List(Of String) = Home.DataSewa.GetDataSewaEditByIDDatabase(SelectedTableSewa)
        Dim selectedMobil As List(Of String) = Home.DataSewa.GetDataMobilLihatByIDDatabase(SelectedIdMobil)
        Dim selectedPenyewa As List(Of String) = Home.DataSewa.GetDataPenyewaLihatByIDDatabase(SelectedIdPenyewa)

        Home.DataSewa.id_mobilProperty = selectedSewa(0)
        Home.DataSewa.id_penyewaProperty = selectedSewa(1)
        Home.DataSewa.rencana_pinjamProperty = selectedSewa(2)
        Home.DataSewa.tanggal_pinjamProperty = selectedSewa(3)
        Home.DataSewa.lamaSewaProperty = selectedSewa(4)
        Home.DataSewa.total_biaya_SewaProperty = selectedSewa(5)
        Home.DataSewa.foto_mobilProperty = selectedMobil(0)
        Home.DataSewa.hargaunitProperty = selectedMobil(1)
        Home.DataSewa.merkProperty = selectedMobil(2)
        Home.DataSewa.platNomorProperty = selectedMobil(3)
        Home.DataSewa.namaProperty = selectedPenyewa(0)
        Home.DataSewa.nikProperty = selectedPenyewa(1)
        Home.DataSewa.foto_ktpProperty = selectedPenyewa(2)

        Dim FormInfo = New SelesaiSewa()
        FormInfo.Show()
    End Sub
End Class