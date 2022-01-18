Public Class JenisMobil

    Public Shared SelectedTableJenisMobil
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TambahJenisMobil.Show()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DGJenisMobil.DataSource = Home.DataJenisMobil.GetDataJenisMobilDatabase()
    End Sub

    Private Sub JenisMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Home.DataJenisMobil.DeleteDataJenisMobilByIDDatabase(SelectedTableJenisMobil)
        ReloadDataTableDatabase()
    End Sub

    Private Sub DGJenisMobil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGJenisMobil.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGJenisMobil.Rows(index)

        SelectedTableJenisMobil = selectedRow.Cells(0).Value
    End Sub
End Class