Public Class frmaddbooking
    Dim idselected As Integer = 0
    Dim datetoday As String
    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtsearch.Text.Length = 0 Then
                MessageBox.Show("Search", "Enter customer's name", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                search_customer(txtsearch.Text.Trim)
            End If
        End If
    End Sub
    Private Sub search_customer(ByVal param As String)
        Try
            Dim custobj As New Customers
            Dim custlist As New List(Of Customers)
            custlist = custobj.search_customer_name(param)
            If custlist IsNot Nothing Then
                lvCustomers.Items.Clear()
                MessageBox.Show(custlist.Count & " Results for " & param)
                Dim itemlist As ListViewItem
                For i = 0 To custlist.Count - 1
                    itemlist = lvCustomers.Items.Add(custlist(i).getCode)
                    itemlist.SubItems.Add(custlist(i).getName)
                    itemlist.SubItems.Add(custlist(i).getCompany)
                    itemlist.SubItems.Add(custlist(i).getAddress)
                    itemlist.SubItems.Add(custlist(i).getPhone)
                    itemlist.SubItems.Add(custlist(i).getDistrict)
                Next

            Else
                MessageBox.Show("No results for " & param, "Customer Record:Search Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Customer Record:Search Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub



    Private Sub lvCustomers_Click(sender As Object, e As EventArgs) Handles lvCustomers.Click
        If lvCustomers.Items.Count > 0 Then
            idselected = lvCustomers.SelectedItems(0).Text
            BookingPanel.Enabled = True
            txtaddress.Clear()
            txtaddress.Enabled = False
            rbsameaddress.Checked = True
            rbdifferentaddress.Checked = False
            txtaddress.Text = lvCustomers.SelectedItems(0).SubItems(3).Text

        End If
    End Sub

    Private Sub rbsameaddress_CheckedChanged(sender As Object, e As EventArgs) Handles rbsameaddress.CheckedChanged
        If rbsameaddress.Checked = True Then
            txtaddress.Enabled = False
            txtaddress.Text = lvCustomers.SelectedItems(0).SubItems(3).Text
        End If
    End Sub

    Private Sub rbdifferentaddress_CheckedChanged(sender As Object, e As EventArgs) Handles rbdifferentaddress.CheckedChanged
        If rbdifferentaddress.Checked = True Then
            txtaddress.Enabled = True
            txtaddress.Clear()

        End If
    End Sub

    Private Sub frmaddbooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxampm.SelectedIndex = 0
        datetoday = Today.ToString("dd/MM/yyyy")

    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Dim d1 As Date = CDate(dtdate.Value)
        Dim d2 As Date = CDate(datetoday)

        If txtaddress.Text.Length <= 0 Then
            MessageBox.Show("Address cannot be empty", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ((d1 - d2).Days) <= 0 Then
            MessageBox.Show("Booking date cannot be later than today", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txttime.MaskCompleted = False Then
            MessageBox.Show("Select the booking time", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ServicePanel.Enabled = True
            cbxactype.SelectedIndex = 0
            cbxcompressor.SelectedIndex = 0
            cbxcompressor.SelectedIndex = 0
            cbxgas.SelectedIndex = 0
            cbxunits.SelectedIndex = 0
            txtbrandmodel.Clear()
            txtremarks.Clear()
            rbnormal.Checked = True
            btnremove.Enabled = False
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim actype As String = ""
        If rbinverter.Checked = True Then
            actype = "Inverter"
        ElseIf rbnormal.Checked = True Then
            actype = "Normal"

        End If

        Dim list1 As ListViewItem
        list1 = lvservicedetails.Items.Add(cbxactype.Text)
        list1.SubItems.Add(txtbrandmodel.Text & "(" & actype & ")")
        list1.SubItems.Add(cbxunits.Text)
        list1.SubItems.Add(cbxcompressor.Text)
        list1.SubItems.Add(cbxgas.Text)
        If (txtremarks.Text.Length = 0) Then
            list1.SubItems.Add("NA")
        Else
            list1.SubItems.Add(txtremarks.Text)
        End If

        cbxactype.SelectedIndex = 0
        cbxcompressor.SelectedIndex = 0
        cbxcompressor.SelectedIndex = 0
        cbxgas.SelectedIndex = 0
        cbxunits.SelectedIndex = 0
        txtbrandmodel.Clear()
        txtremarks.Clear()
        rbnormal.Checked = True

        'loop test




    End Sub

    Private Sub lvservicedetails_Click(sender As Object, e As EventArgs) Handles lvservicedetails.Click

        If lvservicedetails.Items.Count > 0 Then
            btnremove.Enabled = True
        Else
            btnremove.Enabled = False
        End If

    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        lvservicedetails.Items.RemoveAt(lvservicedetails.SelectedIndices(0))
        btnremove.Enabled = False
    End Sub

    Private Sub btnsavebooking_Click(sender As Object, e As EventArgs) Handles btnsavebooking.Click
        If lvservicedetails.Items.Count > 0 Then
            Dim list1 As New List(Of String)
            list1.Add(idselected)
            list1.Add(txtaddress.Text)
            list1.Add(Today.ToString("yyyy-MM-dd"))

            Dim dtobj As New DateConverter(dtdate.Value.ToString("dd/MM/yyyy"))
            list1.Add(dtobj.sqlDate)
            list1.Add(txttime.Text & " " & cbxampm.Text)
            list1.Add(txtremarks.Text)
            list1.Add("1")
            list1.Add("BOOKED")
            Dim bookingobj As New Booking
            Dim bookingno As String
            bookingno = bookingobj.save_booking(list1)

            service_info(bookingno)


        Else
            MessageBox.Show("No AC in the list", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub service_info(ByVal no As String)
        Try
            Dim list1 As New List(Of ServiceInfo)
            For i = 0 To lvservicedetails.Items.Count - 1
                Dim obj1 As New ServiceInfo
                obj1.setRef(no)
                obj1.setRefType("BOOKING")
                obj1.setAC(lvservicedetails.Items(i).Text)
                obj1.setBrand(lvservicedetails.Items(i).SubItems(1).Text)
                obj1.setUnits(lvservicedetails.Items(i).SubItems(2).Text)
                obj1.setComp(lvservicedetails.Items(i).SubItems(3).Text)
                obj1.setGas(lvservicedetails.Items(i).SubItems(4).Text)
                obj1.setDesc(lvservicedetails.Items(i).SubItems(5).Text)
                list1.Add(obj1)
            Next
            Dim serviceobj As New ServiceInfo
            serviceobj.save_booking_info(list1)

            Me.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class