Imports System.Globalization
Public Class DateConverter

    Dim dt As String

    Public Sub New(ByVal param As String)
        dt = param
    End Sub

    Public Function shortDate()
        Dim sDate As String = ""
        Try

            Dim dt1 As DateTime = DateTime.ParseExact(dt, "yyyy-MM-dd", CultureInfo.InvariantCulture)
            sDate = dt1.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Date Converter Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return sDate
    End Function

    Public Function sqlDate()
        Dim sDate As String = ""
        Try

            Dim dt1 As DateTime = DateTime.ParseExact(dt, "dd/MM/yyyy", CultureInfo.InvariantCulture)
            sDate = dt1.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Date Converter Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return sDate
    End Function
End Class
