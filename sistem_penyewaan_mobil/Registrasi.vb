Public Class Registrasi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TxtUsername.Text.Length > 0 And TxtPassword.Text.Length > 0 And TxtEmail.Text.Length > 0 Then
            Login.Users.AddUsersDatabase(TxtUsername.Text, TxtEmail.Text, TxtPassword.Text, Login.Users.fotoProperty)
            Me.Close()
        Else
            MessageBox.Show("Lengkapi Data")
        End If
        Login.Users.fotoProperty = Login.Users.fotoProperty
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "All Format|*.*|Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif"
        OpenFileDialog1.ShowDialog()

        PicFoto.Load(OpenFileDialog1.FileName)
        PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        Login.Users.fotoProperty = OpenFileDialog1.FileName
        Login.Users.fotoProperty = OpenFileDialog1.ToString()
        Login.Users.fotoProperty = Login.Users.fotoProperty.Replace("\", "/")
    End Sub


End Class