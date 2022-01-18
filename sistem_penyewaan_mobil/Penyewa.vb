Public Class Penyewa

    Public Shared SelectedTablePenyewa
    Public Shared SelectedTablePenyewaNama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ReloadDataTableDatabase()

        ' Add any initialization after the InitializeComponent() call.

    End Sub



    Private Sub ReloadDataTableDatabase()
        DataGridPenyewa.DataSource = Home.DataPenyewa.GetDataPenyewaDatabase()
    End Sub

    Private Sub Penyewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TambahPenyewa.Show()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim selectedPenyewa As List(Of String) = Home.DataPenyewa.GetDataPenyewaByIDDatabase(SelectedTablePenyewa)

        Home.DataPenyewa.nikProperty = selectedPenyewa(0)
        Home.DataPenyewa.namaProperty = selectedPenyewa(1)
        Home.DataPenyewa.alamatProperty = selectedPenyewa(2)
        Home.DataPenyewa.fotoKTPProperty = selectedPenyewa(3)

        Dim FormInfo = New InfoPenyewa()
        FormInfo.Show()
    End Sub

    Private Sub DataGridPenyewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridPenyewa.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridPenyewa.Rows(index)

        SelectedTablePenyewa = selectedRow.Cells(0).Value
        SelectedTablePenyewaNama = selectedRow.Cells(2).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim selectedPenyewa As List(Of String) = Home.DataPenyewa.GetDataPenyewaByIDDatabase(SelectedTablePenyewa)

        Home.DataPenyewa.nikProperty = selectedPenyewa(0)
        Home.DataPenyewa.namaProperty = selectedPenyewa(1)
        Home.DataPenyewa.alamatProperty = selectedPenyewa(2)
        Home.DataPenyewa.fotoKTPProperty = selectedPenyewa(3)

        Dim FormInfo = New EditPenyewa()
        FormInfo.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Home.DataPenyewa.removePenyewa(Home.DataPenyewa.nikProperty)
        Dim FormHapus = New HapusPenyewa()
        FormHapus.Show()
    End Sub
End Class