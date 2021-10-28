Imports System.Data.SqlClient

Public Class frmCustomerRecord
    Dim db As SqlConnection
    Dim idselected As String

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

    Private Sub frmCustomerRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        open_connection()
        btneditcustomer.Visible = False

    End Sub

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub lvCustomers_Click(sender As Object, e As EventArgs) Handles lvCustomers.Click
        If lvCustomers.Items.Count > 0 Then
            idselected = lvCustomers.SelectedItems(0).Text
            btneditcustomer.Visible = True
        End If
    End Sub

    Private Sub btneditcustomer_Click(sender As Object, e As EventArgs) Handles btneditcustomer.Click
        Dim dialog1 As New frmeditcustomer(idselected)
        dialog1.ShowDialog()

    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        Dim dialog1 As New frmaddcustomer
        dialog1.ShowDialog()

    End Sub

    Private Sub leftpanel_Paint(sender As Object, e As PaintEventArgs) Handles leftpanel.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
