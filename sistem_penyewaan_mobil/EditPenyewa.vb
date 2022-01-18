Public Class EditPenyewa
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PicFoto.Load(Home.DataPenyewa.fotoKTPProperty)
        PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        TxtNIK.Text = Home.DataPenyewa.nikProperty
        TxtNama.Text = Home.DataPenyewa.namaProperty
        RTBAlamat.Text = Home.DataPenyewa.alamatProperty
    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "|*.*"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PicFoto.Load(picKoleksiDir)
        PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        Home.DataPenyewa.fotoKTPProperty = picKoleksiDir.ToString()
        Home.DataPenyewa.fotoKTPProperty = Home.DataPenyewa.fotoKTPProperty.Replace("\", "/")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.DataPenyewa.nikProperty = TxtNIK.Text.ToString()
        Home.DataPenyewa.namaProperty = TxtNama.Text.ToString()
        Home.DataPenyewa.alamatProperty = RTBAlamat.Text.ToString()
        Home.DataPenyewa.status_penyewaProperty = "Tersedia"


        Home.DataPenyewa.UpdateDataPenyewaByIDDatabase(Penyewa.SelectedTablePenyewa,
                                                        Home.DataPenyewa.nikProperty,
                                                        Home.DataPenyewa.namaProperty,
                                                        Home.DataPenyewa.alamatProperty,
                                                        Home.DataPenyewa.fotoKTPProperty,
                                                        Home.DataPenyewa.status_penyewaProperty)

        Dim InfoTambah = New InfoPenyewa()
        InfoTambah.Show()
        Me.Close()
    End Sub
End Class