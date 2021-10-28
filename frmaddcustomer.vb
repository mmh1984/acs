Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmaddcustomer
    Dim db As SqlConnection


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
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtname.Text.Length = 0 Then
            MessageBox.Show("Name cannot be empty", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not Regex.Match(txtname.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Name must be letters only", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtcompany.Text.Length = 0 Then
            MessageBox.Show("Company name cannot be empty", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtaddress.Text.Length = 0 Then
            MessageBox.Show("Address name cannot be empty", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtphone.Text.Length = 0 Then
            MessageBox.Show("Phone number cannot be empty", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            save_customer()
        End If
    End Sub
    Private Sub save_customer()
        Try
            Dim list1 As New List(Of String)
            list1.Add(txtname.Text.Trim)
            list1.Add(txtcompany.Text.Trim)
            list1.Add(txtaddress.Text.Trim)
            list1.Add(txtphone.Text.Trim)
            list1.Add(cbxdistrict.Text.Trim)

            Dim custobj As New Customers
            If (custobj.save_customer(list1)) Then
                MessageBox.Show("New customer created", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Save Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmaddcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxdistrict.SelectedIndex = 0
    End Sub

    Private Sub txtphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtphone.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "/" Or Asc(e.KeyChar) = 8 Or e.KeyChar = "+") '8 is backsapce
    End Sub
End Class