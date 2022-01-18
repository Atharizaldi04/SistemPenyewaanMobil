Public Class Mobil
    Public Shared SelectedTableMobil
    Public Shared SelectedTablePlatMobil
    Public Shared Selectedjb

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()

    End Sub



    Private Sub ReloadDataTableDatabase()
        DGMobil.DataSource = Home.DataMobil.GetDataMobilDatabase()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TambahMobil.Show()
    End Sub

    Private Sub Mobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub DGMobil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGMobil.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGMobil.Rows(index)

        SelectedTableMobil = selectedRow.Cells(0).Value
        SelectedTablePlatMobil = selectedRow.Cells(2).Value
        Selectedjb = selectedRow.Cells(1).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FormHapus = New HapusMobil()
        FormHapus.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim selectedMobil As List(Of String) = Home.DataMobil.GetDataMObilByIDDatabase(SelectedTableMobil)

        Home.DataMobil.id_jenis_mobilProperty = selectedMobil(0)
        Home.DataMobil.foto_mobilProperty = selectedMobil(1)
        Home.DataMobil.merekProperty = selectedMobil(2)
        Home.DataMobil.platnomorProperty = selectedMobil(3)
        Home.DataMobil.harga_sewaProperty = selectedMobil(4)
        Home.DataMobil.tahun_pembuatanProperty = selectedMobil(5)
        Home.DataMobil.tanggal_data_masukProperty = selectedMobil(6)
        Home.DataMobil.status_sewaProperty = selectedMobil(7)

        Dim FormInfo = New InfoMobil()
        FormInfo.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim selectedMobil As List(Of String) = Home.DataMobil.GetDataMObilByIDDatabase(SelectedTableMobil)
        Dim selectedJenisMobil As List(Of String) = Home.DataMobil.GetDataJenisMobilByIDDatabase(Selectedjb)

        Home.DataMobil.id_jenis_mobilProperty = selectedMobil(0)
        Home.DataMobil.foto_mobilProperty = selectedMobil(1)
        Home.DataMobil.merekProperty = selectedMobil(2)
        Home.DataMobil.platnomorProperty = selectedMobil(3)
        Home.DataMobil.harga_sewaProperty = selectedMobil(4)
        Home.DataMobil.tahun_pembuatanProperty = selectedMobil(5)
        Home.DataMobil.tanggal_data_masukProperty = selectedMobil(6)
        Home.DataMobil.status_sewaProperty = selectedMobil(7)
        Home.DataMobil.jenis_mobilProperty = selectedJenisMobil(0)

        Dim FormInfo = New EditMobil()
        FormInfo.Show()
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class