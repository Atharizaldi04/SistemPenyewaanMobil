Imports System.Text
Imports MySql.Data.MySqlClient

Public Class DataRiwayatTransaksi
    Private id_riwayat As String
    Private foto_mobil As String
    Private foto_ktp As String
    Private merk As String
    Private plat_nomor As String
    Private nik As String
    Private nama As String
    Private tanggal_pinjam As String
    Private tanggal_kembali As String
    Private biaya As String
    Private denda As String
    Private total_bayar As String
    Private status_mobil As String
    Private status_penyewa As String

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


    Public Function GetDataRiwayatDatabase() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = " SELECT id_riwayat AS 'ID',
                                    merk AS 'Merek', 
                                    plat_nomor AS 'Plat Nomor',
                                    nik AS 'NIK Penyewa',
                                    nama AS 'Nama Penyewa', 
                                    tanggal_pinjam AS 'Tanggal Pinjam',
                                    tanggal_kembali AS 'Tanggal Kembali',
                                    biaya AS 'BIaya', 
                                    denda AS 'Denda',
                                    total_bayar AS 'Total Bayar',
                                    foto_mobil AS 'foto_mobil',
                                    foto_ktp AS 'foto_ktp Bayar'
                                    FROM riwayat"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataRiwayatTanggalDatabase(tanggal1, tanggal2) As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = (" SELECT id_riwayat AS 'ID',
                                    merk AS 'Merek', 
                                    plat_nomor AS 'Plat Nomor',
                                    nik AS 'NIK Penyewa',
                                    nama AS 'Nama Penyewa', 
                                    tanggal_pinjam AS 'Tanggal Pinjam',
                                    tanggal_kembali AS 'Tanggal Kembali',
                                    biaya AS 'BIaya', 
                                    denda AS 'Denda',
                                    total_bayar AS 'Total Bayar',
                                    foto_mobil AS 'foto_mobil',
                                    foto_ktp AS 'foto_ktp Bayar'
                                    FROM riwayat WHERE tanggal_pinjam between
                                    tanggal1 and tanggal2")
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataRiwayatDatabase(foto_mobil As String,
                                            foto_ktp As String,
                                            merk As String,
                                            plat_nomor As String,
                                            nik As String,
                                            nama As String,
                                            tanggal_pinjam As String,
                                            tanggal_kembali As String,
                                            biaya As String,
                                            denda As String,
                                            total_bayar As String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO RIWAYAT(foto_mobil,
                                            foto_ktp,
                                            merk,
                                            plat_nomor,
                                            nik,
                                            nama,
                                            tanggal_pinjam,
                                            tanggal_kembali,
                                            biaya,
                                            denda,
                                            total_bayar
                                            ) VALUE('" _
            & foto_mobil & "', '" _
            & foto_ktp & "', '" _
            & merk & "', '" _
            & plat_nomor & "', '" _
            & nik & "', '" _
            & nama & "', '" _
            & tanggal_pinjam & "', '" _
            & tanggal_kembali & "', '" _
            & biaya & "', '" _
            & denda & "', '" _
            & total_bayar & "')"
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

    Public Function GetDataRiwayatEditByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT    foto_mobil,
                                            foto_ktp,
                                            merk,
                                            plat_nomor,
                                            nik,
                                            nama,
                                            tanggal_pinjam,
                                            tanggal_kembali,
                                            biaya,
                                            denda,
                                            total_bayar
                                    FROM riwayat
                                    WHERE id_riwayat ='" & ID & "'"

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
            result.Add(sqlRead.GetString(8).ToString())
            result.Add(sqlRead.GetString(9).ToString())
            result.Add(sqlRead.GetString(10).ToString())
        End While
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function


    Public Property total_bayarProperty() As String
        Get
            Return total_bayar
        End Get
        Set(ByVal value As String)
            total_bayar = value
        End Set
    End Property

    Public Property dendaProperty() As String
        Get
            Return denda
        End Get
        Set(ByVal value As String)
            denda = value
        End Set
    End Property


    Public Property biayaProperty() As String
        Get
            Return biaya
        End Get
        Set(ByVal value As String)
            biaya = value
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

    Public Property tanggal_pinjamProperty() As String
        Get
            Return tanggal_pinjam
        End Get
        Set(ByVal value As String)
            tanggal_pinjam = value
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

    Public Property nikProperty() As String
        Get
            Return nik
        End Get
        Set(ByVal value As String)
            nik = value
        End Set
    End Property

    Public Property plat_nomorProperty() As String
        Get
            Return plat_nomor
        End Get
        Set(ByVal value As String)
            plat_nomor = value
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

    Public Property foto_ktpProperty() As String
        Get
            Return foto_ktp
        End Get
        Set(ByVal value As String)
            foto_ktp = value
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

    Public Property id_riwayatProperty() As String
        Get
            Return id_riwayat
        End Get
        Set(ByVal value As String)
            id_riwayat = value
        End Set
    End Property

    Public Property status_mobilProperty() As String
        Get
            Return status_mobil
        End Get
        Set(ByVal value As String)
            status_mobil = value
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


End Class
