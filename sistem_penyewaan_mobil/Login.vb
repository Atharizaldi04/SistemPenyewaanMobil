Public Class Login
    Public Shared Users As Users
    Public Shared nama As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        'Edit 18 December 2021
        Users = New Users()
        '//CLOSE

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim plainUsername As String = TxtUsername.Text
        Dim plainPassword As String = TxtPassword.Text
        nama = TxtUsername.Text

        Dim data_user As List(Of String) = Users.CheckAuthDatabase(plainUsername, plainPassword)
        If data_user.Count > 0 Then
            Users.userProperty = data_user(1)
            Home.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Password")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Registrasi.Show()
    End Sub
End Class