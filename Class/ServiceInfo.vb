Imports System.Data.SqlClient

Public Class ServiceInfo
    Dim db As SqlConnection
    Dim serviceno, refno, reftype, actype, acbrand, units, comp, gas, desc As String

    Public Sub New()
        serviceno = ""
        refno = ""
        reftype = ""
        actype = ""
        acbrand = ""
        units = ""
        comp = ""
        gas = ""
        desc = ""

    End Sub

    Public Sub setNo(ByVal param As String)
        serviceno = param

    End Sub
    Public Sub setRef(ByVal param As String)
        refno = param

    End Sub
    Public Sub setRefType(ByVal param As String)
        reftype = param

    End Sub
    Public Sub setAC(ByVal param As String)
        actype = param

    End Sub
    Public Sub setBrand(ByVal param As String)
        acbrand = param

    End Sub
    Public Sub setUnits(ByVal param As String)
        units = param

    End Sub
    Public Sub setComp(ByVal param As String)
        comp = param

    End Sub
    Public Sub setGas(ByVal param As String)
        gas = param

    End Sub
    Public Sub setDesc(ByVal param As String)
        desc = param

    End Sub

    'getters
    'serviceno, refno, reftype, actype, acbrand, units, comp, gas, desc
    Public Function getNo() As String
        Return serviceno
    End Function

    Public Function getRef() As String
        Return refno
    End Function
    Public Function getRefType() As String
        Return reftype
    End Function
    Public Function getAC() As String
        Return actype
    End Function
    Public Function getBrand() As String
        Return acbrand
    End Function
    Public Function getUnits() As String
        Return units
    End Function
    Public Function getComp() As String
        Return comp
    End Function
    Public Function getGas() As String
        Return gas
    End Function
    Public Function getDesc() As String
        Return desc
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

    Public Sub save_booking_info(ByVal list1 As List(Of ServiceInfo))

        Try
            open_connection()

            For i = 0 To list1.Count - 1
                Dim cmd As SqlCommand
                Dim str As String
                str = "INSERT INTO tblserviceinfo (referenceno,referencetype,actype,acbrand,noofunits,compressorlocation,gas,servicedescription) 
                      VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8)"
                cmd = New SqlCommand(str, db)
                cmd.Parameters.AddWithValue("@v1", list1(i).getRef)
                cmd.Parameters.AddWithValue("@v2", list1(i).getRefType)
                cmd.Parameters.AddWithValue("@v3", list1(i).getAC)
                cmd.Parameters.AddWithValue("@v4", list1(i).getBrand)
                cmd.Parameters.AddWithValue("@v5", list1(i).getUnits)
                cmd.Parameters.AddWithValue("@v6", list1(i).getComp)
                cmd.Parameters.AddWithValue("@v7", list1(i).getGas)
                cmd.Parameters.AddWithValue("@v8", list1(i).getDesc)
                cmd.ExecuteNonQuery()

                cmd.Dispose()
            Next
            MessageBox.Show("Booking Saved", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Information)
            db.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Service Info", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub

    Public Function get_servicedetails(ByVal param1 As String, ByVal param2 As String)
        Dim servicelist As New List(Of ServiceInfo)
        Try
            open_connection()
            Dim cmd As SqlCommand
            Dim str As String
            Dim rs As SqlDataReader
            str = "SELECT * FROM tblserviceinfo WHERE referenceno=@param1 AND referencetype=@param2"
            cmd = New SqlCommand(str, db)
            cmd.Parameters.AddWithValue("@param1", param1)
            cmd.Parameters.AddWithValue("@param2", param2)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim obj1 As New ServiceInfo
                    obj1.setNo(rs(0))
                    obj1.setRef(rs(1))
                    obj1.setRefType(rs(2))
                    obj1.setAC(rs(3))
                    obj1.setBrand(rs(4))
                    obj1.setUnits(rs(5))
                    obj1.setComp(rs(6))
                    obj1.setGas(rs(7))
                    servicelist.Add(obj1)
                End While
            End If
            rs.Close()
            cmd.Dispose()
            db.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Service Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return servicelist
    End Function

    Public Sub save_single_ac(ByVal param As ServiceInfo)
        Try
            open_connection()
            Dim cmd As SqlCommand
            Dim str As String
            str = "INSERT INTO tblserviceinfo (referenceno,referencetype,actype,acbrand,noofunits,compressorlocation,gas,servicedescription) 
                      VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8)"
            cmd = New SqlCommand(str, db)
            cmd.Parameters.AddWithValue("@v1", param.getRef)
            cmd.Parameters.AddWithValue("@v2", param.getRefType)
            cmd.Parameters.AddWithValue("@v3", param.getAC)
            cmd.Parameters.AddWithValue("@v4", param.getBrand)
            cmd.Parameters.AddWithValue("@v5", param.getUnits)
            cmd.Parameters.AddWithValue("@v6", param.getComp)
            cmd.Parameters.AddWithValue("@v7", param.getGas)
            cmd.Parameters.AddWithValue("@v8", param.getDesc)
            cmd.ExecuteNonQuery()

            cmd.Dispose()
            MessageBox.Show("AC details saved", "Booking Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Service Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
