Imports System.Text
Imports MySql.Data.MySqlClient
Public Class DataSewa
    Private id_sewa As String
    Private id_mobil As String
    Private id_penyewa As String
    Private rencana_pinjam As String
    Private tanggal_pinjam As String
    Private tanggal_kembali As String
    Private biaya_kelebihan_pinjam As String
    Private total_biaya_Sewa As String
    Private total_bayar As String
    Private status_sewa As String
    Private foto_mobil As String
    Private foto_ktp As String
    Private status_sewa_mobil As String
    Private status_penyewa As String

    Private merk As String
    Private platNomor As String
    Private nik As String
    Private nama As String
    Private lamaSewa As String
    Private hargaunit As String

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

    Public Function GetDataSewaDatabase() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = " SELECT sewa.id_sewa AS 'ID',
                                    mobil.merek AS 'Merek', 
                                    mobil.platnomor AS 'Plat Nomor',
                                    penyewa.nik AS 'Nik Penyewa',
                                    penyewa.nama AS 'Nama Penyewa', 
                                    sewa.tanggal_pinjam AS 'Tanggal Pinjam',
                                    sewa.rencana_pinjam AS 'Rencana Kembali',
                                    sewa.tanggal_kembali AS 'Tanggal Kembali',
                                    sewa.biaya_kelebihan_pinjam AS 'Biaya Kelebihan',
                                    sewa.total_biaya_sewa AS 'Total Biaya Sewa',
                                    sewa.total_bayar AS 'Total Bayar',
                                    sewa.status_sewa AS 'Status'
                                    FROM ((sewa
                                    INNER JOIN mobil ON sewa.id_mobil = mobil.id_mobil)
                                    INNER JOIN penyewa ON sewa.id_penyewa = penyewa.id_penyewa)"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataSewaDatabase(id_mobil As String,
                                            id_penyewa As String,
                                            rencana_pinjam As String,
                                            tanggal_pinjam As String,
                                            total_biaya_sewa As String,
                                            status_sewa As String,
                                            biaya_kelebihan_pinjam As String,
                                            total_bayar As String,
                                            lama_sewa As String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO SEWA(id_mobil,
                                            id_penyewa,
                                            rencana_pinjam,
                                            tanggal_pinjam,
                                            total_biaya_sewa,
                                            status_sewa,
                                            biaya_kelebihan_pinjam,
                                            total_bayar,
                                            lama_sewa) VALUE('" _
            & id_mobil & "', '" _
            & id_penyewa & "', '" _
            & rencana_pinjam & "', '" _
            & tanggal_pinjam & "', '" _
            & total_biaya_sewa & "', '" _
            & status_sewa & "', '" _
            & biaya_kelebihan_pinjam & "', '" _
            & total_bayar & "', '" _
            & lama_sewa & "')"
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

    Public Function GetDataSewaEditByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT    id_mobil,
                                            id_penyewa,
                                            rencana_pinjam,
                                            tanggal_pinjam,
                                            lama_sewa,
                                            total_biaya_sewa
                                    FROM sewa
                                    WHERE id_sewa ='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
        End While
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataSewaLihatByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT    rencana_pinjam,
                                            tanggal_pinjam,
                                            total_biaya_sewa,
                                            lama_sewa
                                    FROM sewa
                                    WHERE id_sewa ='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
        End While
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataMobilLihatByIDDatabase(ID As String) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT    foto_mobil,
                                            harga_sewa,
                                            merek,
                                            platnomor
                                    FROM mobil
                                    WHERE platnomor ='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
        End While
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataPenyewaLihatByIDDatabase(ID As String) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT    nama,
                                            nik,
                                            fotoKTP
                                    FROM penyewa
                                    WHERE nik ='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
        End While
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataSewaByIDDatabase(ID As Integer,
                                            id_mobil As String,
                                            id_penyewa As String,
                                            rencana_pinjam As String,
                                            tanggal_pinjam As String,
                                            total_biaya_sewa As String,
                                            status_sewa As String,
                                            biaya_kelebihan_pinjam As String,
                                            total_bayar As String,
                                            lama_sewa As String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE sewa SET " &
            "id_mobil = '" & id_mobil & "', " &
            "id_penyewa = '" & id_penyewa & "', " &
            "rencana_pinjam = '" & rencana_pinjam & "', " &
            "tanggal_pinjam = '" & tanggal_pinjam & "', " &
            "total_biaya_sewa = '" & total_biaya_sewa & "', " &
            "status_sewa = '" & status_sewa & "', " &
            "biaya_kelebihan_pinjam = '" & biaya_kelebihan_pinjam & "', " &
            "total_bayar = '" & total_bayar & "', " &
            "lama_sewa = '" & lama_sewa & "' " &
            "WHERE id_sewa = '" & ID & "'"
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

    Public Function DeleteDataSewalByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM sewa " &
                        "WHERE id_sewa = '" & ID & "'"
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

    Public Property id_mobilProperty() As String
        Get
            Return id_mobil
        End Get
        Set(ByVal value As String)
            id_mobil = value
        End Set
    End Property
    Public Property id_penyewaProperty() As String
        Get
            Return id_penyewa
        End Get
        Set(ByVal value As String)
            id_penyewa = value
        End Set
    End Property

    Public Property rencana_pinjamProperty() As String
        Get
            Return rencana_pinjam
        End Get
        Set(ByVal value As String)
            rencana_pinjam = value
        End Set
    End Property
    Public Property tanggal_pinjamProperty() As String
        Get
            Return tanggal_pinjam
        End Get
        Set(ByVal value As String)
            tanggal_pinjam = value
        End Set
    End Property
    Public Property tanggal_kembaliProperty() As String
        Get
            Return tanggal_kembali
        End Get
        Set(ByVal value As String)
            tanggal_kembali = value
        End Set
    End Property

    Public Property biaya_kelebihan_pinjamProperty() As String
        Get
            Return biaya_kelebihan_pinjam
        End Get
        Set(ByVal value As String)
            biaya_kelebihan_pinjam = value
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

    Public Property foto_ktpProperty() As String
        Get
            Return foto_ktp
        End Get
        Set(ByVal value As String)
            foto_ktp = value
        End Set
    End Property

    Public Property total_biaya_SewaProperty() As String
        Get
            Return total_biaya_Sewa
        End Get
        Set(ByVal value As String)
            total_biaya_Sewa = value
        End Set
    End Property

    Public Property merkProperty() As String
        Get
            Return merk
        End Get
        Set(ByVal value As String)
            merk = value
        End Set
    End Property

    Public Property status_penyewaProperty() As String
        Get
            Return status_penyewa
        End Get
        Set(ByVal value As String)
            status_penyewa = value
        End Set
    End Property

    Public Property platNomorProperty() As String
        Get
            Return platNomor
        End Get
        Set(ByVal value As String)
            platNomor = value
        End Set
    End Property

    Public Property nikProperty() As String
        Get
            Return nik
        End Get
        Set(ByVal value As String)
            nik = value
        End Set
    End Property

    Public Property namaProperty() As String
        Get
            Return nama
        End Get
        Set(ByVal value As String)
            nama = value
        End Set
    End Property

    Public Property lamaSewaProperty() As String
        Get
            Return lamaSewa
        End Get
        Set(ByVal value As String)
            lamaSewa = value
        End Set
    End Property

    Public Property hargaunitProperty() As String
        Get
            Return hargaunit
        End Get
        Set(ByVal value As String)
            hargaunit = value
        End Set
    End Property

    Public Property total_bayarProperty() As String
        Get
            Return total_bayar
        End Get
        Set(ByVal value As String)
            total_bayar = value
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

    Public Property status_sewa_mobilProperty() As String
        Get
            Return status_sewa_mobil
        End Get
        Set(ByVal value As String)
            status_sewa_mobil = value
        End Set
    End Property

End Class
