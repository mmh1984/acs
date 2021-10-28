Public Class frmbooking
    Dim bookinglist As New List(Of Booking)
    Private Sub frmbooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_bookings()
        load_dates()
    End Sub
    Private Sub load_dates()
        Dim year As Integer = Convert.ToInt32(Today.Year)
        cbYear.Items.Add(year)
        cbYear.Items.Add(year + 1)
        For i = 1 To 12
            cbMonth.Items.Add(i)
        Next
        cbYear.SelectedIndex = 0
        cbMonth.SelectedIndex = Today.Month - 1
    End Sub
    Private Sub load_bookings()
        Try
            bookinglist.Clear()

            Dim obj1 As New Booking
            bookinglist = obj1.get_bookings(Today.ToString("yyyy-MM-dd"))
            If bookinglist IsNot Nothing Then
                lvbookings.Items.Clear()
                For i = 0 To bookinglist.Count - 1
                    Dim lvitem As ListViewItem
                    lvitem = lvbookings.Items.Add(bookinglist(i).getCustCode)
                    lvitem.SubItems.Add(bookinglist(i).getBDate)
                    lvitem.SubItems.Add(bookinglist(i).getCust)
                    lvitem.SubItems.Add(bookinglist(i).getAddress)
                    lvitem.SubItems.Add(bookinglist(i).getSDate)
                    lvitem.SubItems.Add(bookinglist(i).getSTime)

                Next
            Else
                MessageBox.Show("Booking", "No bookings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "No bookings", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub search_bookings(ByVal param1 As String, ByVal param2 As String)
        Try
            bookinglist.Clear()

            Dim obj1 As New Booking
            bookinglist = obj1.search_bookings(param1, param2)
            If bookinglist IsNot Nothing Then
                MessageBox.Show(bookinglist.Count & " Result(s)", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lvbookings.Items.Clear()
                For i = 0 To bookinglist.Count - 1
                    Dim lvitem As ListViewItem
                    lvitem = lvbookings.Items.Add(bookinglist(i).getCustCode)
                    lvitem.SubItems.Add(bookinglist(i).getBDate)
                    lvitem.SubItems.Add(bookinglist(i).getCust)
                    lvitem.SubItems.Add(bookinglist(i).getAddress)
                    lvitem.SubItems.Add(bookinglist(i).getSDate)
                    lvitem.SubItems.Add(bookinglist(i).getSTime)

                Next
            Else
                MessageBox.Show("No bookings on the date(s) selected", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "No bookings", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        Dim dialog1 As New frmaddbooking
        dialog1.ShowDialog()

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        search_bookings(cbMonth.SelectedItem, cbYear.SelectedItem)

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        load_bookings()
        cbYear.SelectedIndex = 0
        cbMonth.SelectedIndex = Today.Month - 1
    End Sub

    Private Sub lvbookings_Click(sender As Object, e As EventArgs) Handles lvbookings.Click
        If lvbookings.Items.Count <> 0 Then
            Dim bookingid As String
            Dim selectedindex As Integer
            selectedindex = lvbookings.SelectedIndices(0)
            bookingid = bookinglist(selectedindex).getID
            Dim obj1 As New frmbookingdetails(bookingid)
            obj1.ShowDialog()

        End If
    End Sub
End Class