Imports MySql.Data.MySqlClient
Public Class RiwayatTransaksi

    Public Shared SelectedTableRiwayat

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=sistem_penyewaan_mobil")

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        DTAwal.Format = DateTimePickerFormat.Custom
        DTAwal.CustomFormat = "yyyy/MM/dd"

        DTAkhir.Format = DateTimePickerFormat.Custom
        DTAkhir.CustomFormat = "yyyy/MM/dd"

    End Sub

    'Private Sub ReloadDataTableDatabase()
    '    DGRiwayatTransaksi.DataSource = Home.DataRiwayatTransaksi.GetDataRiwayatDatabase()
    'End Sub

    Private Sub RiwayatTransaksi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'ReloadDataTableDatabase()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM `riwayat` WHERE `tanggal_pinjam` BETWEEN @d1 AND @d2", connection)

        command.Parameters.Add("@d1", MySqlDbType.Date).Value = DTAwal.Value
        command.Parameters.Add("@d2", MySqlDbType.Date).Value = DTAkhir.Value

        Dim adapter As New MySqlDataAdapter(command)

        adapter.Fill(table)
        DGRiwayatTransaksi.DataSource = table
    End Sub

    Private Sub RiwayatTransaksi_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM riwayat", connection)

        adapter.Fill(table)
        DGRiwayatTransaksi.DataSource = table
    End Sub

    Private Sub BtnLihat_Click(sender As Object, e As EventArgs) Handles BtnLihat.Click
        Dim selectedRiwayat As List(Of String) = Home.DataRiwayatTransaksi.GetDataRiwayatEditByIDDatabase(SelectedTableRiwayat)

        Home.DataRiwayatTransaksi.foto_mobilProperty = selectedRiwayat(0)
        Home.DataRiwayatTransaksi.foto_ktpProperty = selectedRiwayat(1)
        Home.DataRiwayatTransaksi.merkProperty = selectedRiwayat(2)
        Home.DataRiwayatTransaksi.plat_nomorProperty = selectedRiwayat(3)
        Home.DataRiwayatTransaksi.nikProperty = selectedRiwayat(4)
        Home.DataRiwayatTransaksi.namaProperty = selectedRiwayat(5)
        Home.DataRiwayatTransaksi.tanggal_pinjamProperty = selectedRiwayat(6)
        Home.DataRiwayatTransaksi.tanggal_kembaliProperty = selectedRiwayat(7)
        Home.DataRiwayatTransaksi.biayaProperty = selectedRiwayat(8)
        Home.DataRiwayatTransaksi.dendaProperty = selectedRiwayat(9)
        Home.DataRiwayatTransaksi.total_bayarProperty = selectedRiwayat(10)

        Dim FormInfo = New InfoRiwayatTransaksi()
        FormInfo.Show()
    End Sub

    Private Sub DGRiwayatTransaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGRiwayatTransaksi.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGRiwayatTransaksi.Rows(index)

        SelectedTableRiwayat = selectedRow.Cells(0).Value
    End Sub
End Class