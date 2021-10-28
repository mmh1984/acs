Public Class frmbookingdetails
    Dim bookingid As String
    Dim servicelist As New List(Of ServiceInfo)
    Public Sub New(ByVal param As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bookingid = param
        lblbookingno.Text = "Booking no: " + bookingid
    End Sub
    Private Sub frmbookingdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnremove.Enabled = False
        btnadd.Enabled = False
        btnupdate.Enabled = False
        btncancel.Enabled = False

        load_service_details()
        reset_input()

    End Sub

    Private Sub load_service_details()
        Try

            Dim obj1 As New ServiceInfo
            servicelist = obj1.get_servicedetails(bookingid, "BOOKING")
            If servicelist IsNot Nothing Then
                Dim lvdetails As New ListViewItem
                For i = 0 To servicelist.Count - 1
                    lvdetails = lvservicedetails.Items.Add(servicelist(i).getAC)
                    lvdetails.SubItems.Add(servicelist(i).getBrand)
                    lvdetails.SubItems.Add(servicelist(i).getUnits)
                    lvdetails.SubItems.Add(servicelist(i).getComp)
                    lvdetails.SubItems.Add(servicelist(i).getGas)
                    lvdetails.SubItems.Add(servicelist(i).getDesc)
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load service details", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub lvservicedetails_Click(sender As Object, e As EventArgs) Handles lvservicedetails.Click
        If lvservicedetails.Items.Count > 0 Then
            Dim index As Integer
            index = lvservicedetails.SelectedIndices(0)
            cbxactype.Text = servicelist(index).getAC
            cbxcompressor.Text = servicelist(index).getComp
            cbxgas.Text = servicelist(index).getGas
            cbxunits.Text = servicelist(index).getUnits


            If servicelist(index).getBrand.Contains("(Inverter)") Then
                txtbrandmodel.Text = servicelist(index).getBrand.Replace("(Inverter)", "")
                rbinverter.Checked = True
                rbnormal.Checked = False
            Else
                txtbrandmodel.Text = servicelist(index).getBrand.Replace("(Normal)", "")
                rbinverter.Checked = False
                rbnormal.Checked = True
            End If

            gbACDetails.Enabled = True
            btnnew.Enabled = True
            btnadd.Enabled = False
            btnupdate.Enabled = True
            btncancel.Enabled = True
            btnremove.Enabled = True
        End If
    End Sub
    Private Sub reset_input()
        cbxactype.SelectedIndex = 0
        cbxcompressor.SelectedIndex = 0
        cbxgas.SelectedIndex = 0
        cbxunits.SelectedIndex = 0
        txtbrandmodel.Clear()
        txtremarks.Clear()
        rbnormal.Checked = True
        rbinverter.Checked = True

    End Sub
    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        gbACDetails.Enabled = True
        reset_input()
        btnnew.Enabled = False
        btnadd.Enabled = True
        btncancel.Enabled = True


    End Sub

    Private Sub lvservicedetails_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvservicedetails.SelectedIndexChanged

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        reset_input()
        gbACDetails.Enabled = False
        btnremove.Enabled = False
    End Sub

    Private Sub btncanceladd_Click(sender As Object, e As EventArgs) Handles btncanceladd.Click
        reset_input()
        gbACDetails.Enabled = False
        btnnew.Enabled = True
        btnremove.Enabled = False

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        reset_input()
        gbACDetails.Enabled = False
        btnremove.Enabled = False
        btnnew.Enabled = True

    End Sub
End Class