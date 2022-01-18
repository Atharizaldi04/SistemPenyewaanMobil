Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Public Class Users
    'Edit 18 December 2021
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String
    'Variabel Declaration
    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = " "
    Private database As String = "sistem_penyewaan_mobil"
    '//Close

    Private user As String
    Private password As String
    Private email As String
    Private foto As String
    Private usersDataTable As New ArrayList()

    Private TripleDes As New TripleDESCryptoServiceProvider

    Public Property userProperty() As String
        Get
            Return user
        End Get
        Set(ByVal value As String)
            user = value
        End Set
    End Property

    Public Property fotoProperty() As String
        Get
            Return foto
        End Get
        Set(ByVal value As String)
            foto = value
        End Set
    End Property

    Public Property passwordProperty() As String
        Get
            Return password
        End Get
        Set(ByVal value As String)
            password = value
        End Set
    End Property
    Public Property emailProperty() As String
        Get
            Return email
        End Get
        Set(ByVal value As String)
            email = value
        End Set
    End Property

    Public Function EncryptData(ByVal plaintext As String) As String
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)
        Dim ms As New System.IO.MemoryStream
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)
    End Function

    'Public Function CheckAuth(username As String, ByVal plainPassword As String) As String
    '    Dim realPassword As String = EncryptData("1234")
    '    Dim realUsername As String = "aldiansyah"

    '    For Each barisUser In getUsersDataTable()
    '        Dim dataUsername As String = barisUser(0)
    '        Dim dataPassword As String = barisUser(1)
    '        If String.Compare(username, dataUsername) = 0 Then
    '            If String.Compare(username, dataUsername) = 0 And String.Compare(EncryptData(plainPassword), dataPassword) = 0 Then
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        End If
    '    Next
    '    Return False
    'End Function

    'Public Function AddUsersDataTable(username As String,
    '                                password As String)
    '    usersDataTable.Add({username,
    '                         EncryptData(password)
    '                         })
    'End Function

    Public ReadOnly Property getUsersDataTable() As ArrayList
        Get
            Return usersDataTable
        End Get
    End Property

    'Edit 18 December 2021
    Public Function EncryptMD5(ByVal password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return x.ToString()
    End Function

    Public Function AddUsersDatabase(user As String, email As String, password As String, foto As String)
        Try
            dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username_db + " ;" _
                                    + "password = " + password_db + " ;" + "database = " + database
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO users( user, email, password, foto) VALUE('" _
                & user & "', '" _
                & email & "', '" _
                & EncryptMD5(password) & "', '" _
                & foto & "')"
            '& fotouser_regist & "', '"

            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function CheckAuthDatabase(username_login As String, password_login As String) As List(Of String)
        Try
            Dim result As New List(Of String)
            dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username_db + " ;" _
                                + "password = " + password_db + " ;" + "database = " + database
            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim QueryAUTH = "SELECT id, user FROM users
                             WHERE user ='" & username_login & "'AND password = '" & EncryptMD5(password_login) & "'"
            sqlCommand.CommandText = QueryAUTH
            Debug.WriteLine(QueryAUTH)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function

    'Get data for Users from Database
    Public Function GetDataUsersFromDatabase() As DataTable
        Dim result_users As New DataTable
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username_db + " ;" _
                                + "password = " + password_db + " ;" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = " SELECT id AS 'ID',
                                    user AS 'Username'
                                    FROM users"
        sqlRead = sqlCommand.ExecuteReader

        result_users.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result_users
    End Function
    Public Function GetNamaUsersFromDatabase(nama As String)
        Dim result_users As New DataTable
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username_db + " ;" _
                                + "password = " + password_db + " ;" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = " SELECT user
                                    FROM users
                                    WHERE user ='" & nama & "'"
        sqlRead = sqlCommand.ExecuteReader

        result_users.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result_users
    End Function

End Class
