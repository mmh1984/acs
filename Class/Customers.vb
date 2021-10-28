Imports System.Data.SqlClient

Public Class Customers

    Dim db As SqlConnection

    Dim code, name, company, address, phone, district As String

    Public Sub New()
        code = ""
        name = ""
        company = ""
        address = ""
        phone = ""
        district = ""

    End Sub
    Public Sub setCode(ByVal param As String)
        code = param

    End Sub
    Public Sub setName(ByVal param As String)
        name = param

    End Sub
    Public Sub setCompany(ByVal param As String)
        company = param

    End Sub
    Public Sub setAddress(ByVal param As String)
        address = param

    End Sub
    Public Sub setPhone(ByVal param As String)
        phone = param

    End Sub
    Public Sub setDistrict(ByVal param As String)
        district = param

    End Sub
    Public Function getCode()
        Return code

    End Function
    Public Function getName()
        Return name

    End Function
    Public Function getCompany()
        Return company

    End Function
    Public Function getAddress()
        Return address

    End Function
    Public Function getPhone()
        Return phone

    End Function
    Public Function getDistrict()
        Return district

    End Function
    Private Sub open_connection()
        Try
            Dim obj As New Database
            db = New SqlConnection(obj.Conn_String)
            db.Open()
            ' MessageBox.Show("Connected", "Open Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Connection", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Public Function search_customer_name(ByVal param As String) As List(Of Customers)
        Dim clist As New List(Of Customers)
        Try
            open_connection()

            Dim cmd As SqlCommand
            Dim rs As SqlDataReader
            Dim str As String

            str = "SELECT * FROM tblcustomers WHERE custname like @keyword"
            cmd = New SqlCommand(str, db)
            cmd.Parameters.AddWithValue("@keyword", "%" + param + "%")
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim obj As New Customers
                    obj.setCode(rs(0).ToString)
                    obj.setName(rs(1).ToString)
                    obj.setCompany(rs(2).ToString)
                    obj.setAddress(rs(3).ToString)
                    obj.setPhone(rs(4).ToString)
                    obj.setDistrict(rs(5).ToString)
                    clist.Add(obj)
                End While
            Else
                clist = Nothing
            End If
            rs.Close()
            cmd.Dispose()
            db.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Customers Class: Search customer name", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return clist
    End Function

    Public Function search_customer_id(ByVal param As String) As List(Of Customers)
        Dim clist As New List(Of Customers)
        Try
            open_connection()

            Dim cmd As SqlCommand
            Dim rs As SqlDataReader
            Dim str As String

            str = "SELECT * FROM tblcustomers WHERE custcode=@keyword"
            cmd = New SqlCommand(str, db)
            cmd.Parameters.AddWithValue("@keyword", param)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim obj As New Customers
                    obj.setCode(rs(0).ToString)
                    obj.setName(rs(1).ToString)
                    obj.setCompany(rs(2).ToString)
                    obj.setAddress(rs(3).ToString)
                    obj.setPhone(rs(4).ToString)
                    obj.setDistrict(rs(5).ToString)
                    clist.Add(obj)
                End While
            Else
                clist = Nothing
            End If
            rs.Close()
            cmd.Dispose()
            db.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Customers Class: Search customer name", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return clist
    End Function

    Public Function save_customer(ByVal param As List(Of String)) As Boolean
        Dim status As Boolean = False
        Try
            open_connection()
            Dim str As String
            Dim cmd As SqlCommand
            str = "INSERT INTO tblcustomers (custname,compname,custaddress,custphone,custdistrict) "
            str += "values (@v1,@v2,@v3,@v4,@v5) "
            cmd = New SqlCommand(str, db)
            cmd.Parameters.AddWithValue("@v1", param(0))
            cmd.Parameters.AddWithValue("@v2", param(1))
            cmd.Parameters.AddWithValue("@v3", param(2))
            cmd.Parameters.AddWithValue("@v4", param(3))
            cmd.Parameters.AddWithValue("@v5", param(4))
            If cmd.ExecuteNonQuery Then
                status = True
            End If
            cmd.Dispose()
            db.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Customers Class: Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return status
    End Function
End Class
