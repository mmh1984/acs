Imports System.Data.SqlClient
Public Class Booking
    Dim db As SqlConnection
    Dim id, custcode, cust, address, bdate, sdate, stime, remarks, staffno, status As String

    Public Sub New()
        id = ""
        cust = ""
        address = ""
        bdate = ""
        sdate = ""
        stime = ""
        remarks = ""
        staffno = ""
        status = ""

    End Sub

    Public Sub setID(ByVal param As String)
        id = param
    End Sub
    Public Sub setCust(ByVal param As String)
        cust = param
    End Sub
    Public Sub setCustCode(ByVal param As String)
        custcode = param
    End Sub
    Public Sub setAddress(ByVal param As String)
        address = param
    End Sub
    Public Sub setBDate(ByVal param As String)
        bdate = param
    End Sub
    Public Sub setSDate(ByVal param As String)
        sdate = param
    End Sub
    Public Sub setSTime(ByVal param As String)
        stime = param
    End Sub
    Public Sub setRemarks(ByVal param As String)
        remarks = param
    End Sub
    Public Sub setStaff(ByVal param As String)
        staffno = param
    End Sub
    Public Sub setStatus(ByVal param As String)
        status = param
    End Sub
    Public Function getID()
        Return id

    End Function
    Public Function getCustCode()
        Return custcode

    End Function
    Public Function getCust()
        Return cust

    End Function
    Public Function getAddress()
        Return address

    End Function
    Public Function getBDate()
        Return bdate

    End Function
    Public Function getSDate()
        Return sdate

    End Function
    Public Function getSTime()
        Return stime

    End Function

    Public Function getRemarks()
        Return remarks

    End Function
    Public Function getStaffNo()
        Return staffno

    End Function
    Public Function getStatus()
        Return status

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

    Public Function save_booking(ByVal list1 As List(Of String))
        Dim bookingno As String = 0
        Try
            Dim cmd As SqlCommand
            Dim str As String

            open_connection()
            str = "INSERT INTO tblbooking (custcode,baddress,bdate,servicedate,servicetime,bremarks,staffno,bookingstatus) 
                   VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8 )"
            cmd = New SqlCommand(str, db)
            cmd.Parameters.AddWithValue("@v1", list1(0))
            cmd.Parameters.AddWithValue("@v2", list1(1))
            cmd.Parameters.AddWithValue("@v3", list1(2))
            cmd.Parameters.AddWithValue("@v4", list1(3))
            cmd.Parameters.AddWithValue("@v5", list1(4))
            cmd.Parameters.AddWithValue("@v6", list1(5))
            cmd.Parameters.AddWithValue("@v7", list1(6))
            cmd.Parameters.AddWithValue("@v8", list1(7))

            If (cmd.ExecuteNonQuery) Then
                Dim str2 As String
                str2 = "SELECT TOP 1(bookingid) FROM tblbooking where staffno=@v1 AND custcode = @v2 ORDER BY bookingid DESC"
                cmd = New SqlCommand(str2, db)
                cmd.Parameters.AddWithValue("@v1", list1(6))
                cmd.Parameters.AddWithValue("@v2", list1(0))
                bookingno = cmd.ExecuteScalar



            Else
                MessageBox.Show("Error Saving", "Save Booking", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cmd.Dispose()
            db.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Save Booking", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return bookingno
    End Function

    Function get_bookings(ByVal param As String)
        Dim bookinglist As New List(Of Booking)
        Try
            Dim cmd As SqlCommand
            Dim str As String
            Dim rs As SqlDataReader
            open_connection()
            str = "SELECT tblbooking.bookingid,tblbooking.custcode,tblbooking.bdate,
                    tblcustomers.custname,tblbooking.baddress,tblbooking.servicedate,tblbooking.servicetime 
                    FROM tblbooking 
                    INNER JOIN tblcustomers on
                    tblbooking.custcode =tblcustomers.custcode  AND
                    tblbooking.bookingstatus ='BOOKED' AND
                    tblbooking.servicedate >= @date
                    ORDER BY tblbooking.bdate  ASC"
            cmd = New SqlCommand(str, db)
            cmd.Parameters.AddWithValue("@date", param)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim obj1 As New Booking
                    obj1.setID(rs(0))
                    obj1.setCustCode(rs(1))
                    obj1.setBDate(rs(2))
                    obj1.setCust(rs(3))
                    obj1.setAddress(rs(4))
                    obj1.setSDate(rs(5))
                    obj1.setSTime(rs(6))
                    bookinglist.Add(obj1)
                End While
            End If


            rs.Close()
            cmd.Dispose()
            db.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Booking List", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return bookinglist

    End Function
    Function search_bookings(ByVal param1 As String, param2 As String)
        Dim bookinglist As New List(Of Booking)
        Try
            Dim cmd As SqlCommand
            Dim str As String
            Dim rs As SqlDataReader
            open_connection()
            str = "SELECT tblbooking.bookingid,tblbooking.custcode,tblbooking.bdate,
                    tblcustomers.custname,tblbooking.baddress,tblbooking.servicedate,tblbooking.servicetime 
                    FROM tblbooking 
                    INNER JOIN tblcustomers on
                    tblbooking.custcode =tblcustomers.custcode  AND
                    tblbooking.bookingstatus ='BOOKED' AND
                   MONTH(tblbooking.servicedate) = @month AND
					YEAR (tblbooking.servicedate ) =@year
                    ORDER BY tblbooking.bdate  ASC"
            cmd = New SqlCommand(str, db)
            cmd.Parameters.AddWithValue("@month", param1)
            cmd.Parameters.AddWithValue("@year", param2)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim obj1 As New Booking
                    obj1.setID(rs(0))
                    obj1.setCustCode(rs(1))
                    obj1.setBDate(rs(2))
                    obj1.setCust(rs(3))
                    obj1.setAddress(rs(4))
                    obj1.setSDate(rs(5))
                    obj1.setSTime(rs(6))
                    bookinglist.Add(obj1)
                End While
            End If


            rs.Close()
            cmd.Dispose()
            db.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Booking List", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return bookinglist

    End Function

End Class
