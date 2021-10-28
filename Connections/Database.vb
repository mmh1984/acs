
Imports System.IO
Imports System.Data.SqlClient

Public Class Database
    Public Function Conn_String() As String
        Dim connstring As String = Nothing
        Try
            Dim openfile As StreamReader
            openfile = File.OpenText("c:\acs\connection.txt")
            While openfile.Peek <> -1
                connstring = openfile.ReadLine
            End While

            openfile.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return connstring

    End Function

End Class
