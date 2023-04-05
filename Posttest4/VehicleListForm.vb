Imports MySql.Data.MySqlClient

Public Class VehicleListForm

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DataGarasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataGarasiToolStripMenuItem.Click
        GarageListForm.ShowDialog()
    End Sub

    Public Sub LoadData()
        Connect()
        Adapter = New MySqlDataAdapter("SELECT * FROM vehicles", Connection)
        Dataset = New DataSet("vehicles")
        Dataset.Clear()
        Adapter.Fill(Dataset, "vehicles")
        DataGridView1.DataSource = Dataset.Tables("vehicles")
        DataGridView1.Refresh()
    End Sub

    Private Sub VehicleListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LoadData()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        VehicleForm.ShowDialog()
    End Sub
End Class