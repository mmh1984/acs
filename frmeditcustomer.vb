
Public Class frmeditcustomer
    Dim customerid As String
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Public Sub New(ByVal id As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        customerid = id
        load_customer_info()
    End Sub

    Private Sub load_customer_info()
        Try

            Dim custobj As New Customers
            Dim custlist As New List(Of Customers)
            custlist = custobj.search_customer_id(customerid)
            For i = 0 To custlist.Count - 1
                txtid.Text = custlist(i).getCode
                txtname.Text = custlist(i).getName
                txtcompany.Text = custlist(i).getCompany
                txtaddress.Text = custlist(i).getAddress
                txtphone.Text = custlist(i).getPhone
                cbxdistrict.Text = custlist(i).getDistrict
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtphone.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "/" Or Asc(e.KeyChar) = 8 Or e.KeyChar = "+") '8 is backsapce
    End Sub
End Class