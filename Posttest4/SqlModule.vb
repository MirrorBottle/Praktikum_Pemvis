Imports System
Imports System.Data
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Module SqlModule
    Public Connection As MySqlConnection
    Public Cmd As MySqlCommand
    Public Reader As MySqlDataReader
    Public Adapter As MySqlDataAdapter
    Public Dataset As DataSet
    Public Str As String

    Sub Connect()
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)
        Try
            Dim Dns As String = "server=localhost;userid=root;password=;database=yellow_bird"
            Connection = New MySqlConnection(Dns)
            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
