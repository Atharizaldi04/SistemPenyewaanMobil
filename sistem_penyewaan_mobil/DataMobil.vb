Imports System.Text
Imports MySql.Data.MySqlClient
Public Class DataMobil
    Private id_mobil As String
    Private id_jenis_mobil As String
    Private foto_mobil As String
    Private merek As String
    Private platnomor As String
    Private harga_sewa As String
    Private tahun_pembuatan As String
    Private tanggal_data_masuk As String
    Private status_sewa As String
    Private jenis_mobil As String

    'Update 8 December MySql ---- until // close
    Public Shared ID
    Private koleksiDataTable As New ArrayList()
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    'Variabel Declaration
    Private sqlQuery As String
    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = " "
    Private database As String = "sistem_penyewaan_mobil"

    Public Function GetDataMobilDatabase() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = " SELECT mobil.id_mobil AS 'ID',
                                    db_jenismobil.jenis_mobil AS 'Jenis Mobil', 
                                    mobil.merek AS 'Merek Mobil',
                                    mobil.platnomor AS 'Plat Nomor',
                                    mobil.harga_sewa AS 'Harga Sewa', 
                                    mobil.tahun_pembuatan AS 'Tahun Pembuatan',
                                    mobil.tanggal_data_masuk AS 'Tanggal Data Masuk',
                                    mobil.status_sewa AS 'Status',
                                    mobil.foto_mobil AS 'Foto Mobil'
                                    FROM mobil
                                    INNER JOIN db_jenismobil ON mobil.id_jenis_mobil = db_jenismobil.id_jenis_mobil"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataMobilDatabase(id_jenis_mobil As String,
                                            foto_mobil As String,
                                            merek As String,
                                            platnomor As String,
                                            harga_sewa As String,
                                            tahun_pembuatan As String,
                                            tanggal_data_masuk As String,
                                            status_sewa As String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO MOBIL(id_jenis_mobil,
                                          foto_mobil,
                                          merek,
                                          platnomor,
                                          harga_sewa,
                                          tahun_pembuatan,
                                          tanggal_data_masuk,
                                          status_sewa) VALUE('" _
            & id_jenis_mobil & "', '" _
            & foto_mobil & "', '" _
            & merek & "', '" _
            & platnomor & "', '" _
            & harga_sewa & "', '" _
            & tahun_pembuatan & "', '" _
            & tanggal_data_masuk & "', '" _
            & status_sewa & "')"
            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataMObilByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis_mobil,
                                          foto_mobil,
                                          merek,
                                          platnomor,
                                          harga_sewa,
                                          tahun_pembuatan,
                                          tanggal_data_masuk,
                                          status_sewa
                                    FROM mobil
                                    WHERE id_mobil ='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
        End While
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataJenisMobilByIDDatabase(jenis_mobil) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT jenis_mobil
                                    FROM db_jenismobil
                                    WHERE jenis_mobil ='" & jenis_mobil & "'"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
        End While
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataMobilByIDDatabase(ID As Integer,
                                                id_jenis_mobil As String,
                                                foto_mobil As String,
                                                merek As String,
                                                platnomor As String,
                                                harga_sewa As String,
                                                tahun_pembuatan As String,
                                                tanggal_data_masuk As String,
                                                status_sewa As String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE mobil SET " &
            "id_jenis_mobil = '" & id_jenis_mobil & "', " &
            "foto_mobil = '" & foto_mobil & "', " &
            "merek = '" & merek & "', " &
            "platnomor = '" & platnomor & "', " &
            "harga_sewa = '" & harga_sewa & "', " &
            "tahun_pembuatan = '" & tahun_pembuatan & "', " &
            "tanggal_data_masuk = '" & tanggal_data_masuk & "', " &
            "status_sewa = '" & status_sewa & "' " &
            "WHERE id_mobil = '" & ID & "'"
            'Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function UpdateStatusMobilByIDDatabase(ID As Integer,
                                                status_sewa As String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE mobil SET " &
            "status_sewa = '" & status_sewa & "' " &
            "WHERE id_mobil = '" & ID & "'"
            'Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function DeleteDataMobilByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM mobil " &
                        "WHERE id_mobil = '" & ID & "'"
            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlQuery)

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Property id_jenis_mobilProperty() As String
        Get
            Return id_jenis_mobil
        End Get
        Set(ByVal value As String)
            id_jenis_mobil = value
        End Set
    End Property
    Public Property merekProperty() As String
        Get
            Return merek
        End Get
        Set(ByVal value As String)
            merek = value
        End Set
    End Property
    Public Property jenis_mobilProperty() As String
        Get
            Return jenis_mobil
        End Get
        Set(ByVal value As String)
            jenis_mobil = value
        End Set
    End Property

    Public Property platnomorProperty() As String
        Get
            Return platnomor
        End Get
        Set(ByVal value As String)
            platnomor = value
        End Set
    End Property
    Public Property harga_sewaProperty() As String
        Get
            Return harga_sewa
        End Get
        Set(ByVal value As String)
            harga_sewa = value
        End Set
    End Property
    Public Property tahun_pembuatanProperty() As String
        Get
            Return tahun_pembuatan
        End Get
        Set(ByVal value As String)
            tahun_pembuatan = value
        End Set
    End Property

    Public Property tanggal_data_masukProperty() As String
        Get
            Return tanggal_data_masuk
        End Get
        Set(ByVal value As String)
            tanggal_data_masuk = value
        End Set
    End Property

    Public Property status_sewaProperty() As String
        Get
            Return status_sewa
        End Get
        Set(ByVal value As String)
            status_sewa = value
        End Set
    End Property

    Public Property foto_mobilProperty() As String
        Get
            Return foto_mobil
        End Get
        Set(ByVal value As String)
            foto_mobil = value
        End Set
    End Property

End Class
