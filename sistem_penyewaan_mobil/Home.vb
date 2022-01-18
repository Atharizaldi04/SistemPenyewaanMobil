Public Class Home
    Public Shared DataPenyewa As DataPenyewa
    Public Shared DataJenisMobil As DataJenisMobil
    Public Shared DataMobil As DataMobil
    Public Shared DataSewa As DataSewa
    Public Shared DataRiwayatTransaksi As DataRiwayatTransaksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DataPenyewa = New DataPenyewa()
        DataJenisMobil = New DataJenisMobil()
        DataMobil = New DataMobil()
        DataSewa = New DataSewa()
        DataRiwayatTransaksi = New DataRiwayatTransaksi()
        Namaadmin.Text = Login.nama

    End Sub
    Private Sub Namaadmin_Click(sender As Object, e As EventArgs) Handles Namaadmin.Click

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sistemPenyewaanMobil.Show()
        Me.Hide()
        Namaadmin.Text = " "
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Penyewa.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Sewa.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        JenisMobil.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Mobil.Show()
    End Sub

    Private Sub Home_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Namaadmin.Text = Login.nama
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RiwayatTransaksi.Show()
    End Sub
End Class