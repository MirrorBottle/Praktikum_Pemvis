Imports MySql.Data.MySqlClient

Public Class VehicleForm
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Connect()
        Dim VehicleName = TextVehicleName.Text
        Dim PoliceNumber = TextPoliceNumber.Text
        Dim CilinderType = TextCilinderType.Text
        Dim Year = Val(TextYear.Text)
        Dim FuelType = ComboFuelType.Text
        Dim VehicleType = ComboVehicleType.Text


        If VehicleName = "" Or PoliceNumber = "" Or CilinderType = "" Or TextYear.Text = "" Or FuelType = "" Or VehicleType = "" Then
            MsgBox("Data Belum Lengkap!")
            TextVehicleName.Focus()
            Exit Sub
        Else
            CilinderType = CilinderType & " CC"
            Dim SaveQuery = New MySqlCommand($"INSERT INTO vehicles VALUES(NULL, '{VehicleName}', '{PoliceNumber}', '{CilinderType}', {Year}, '{FuelType}', '{VehicleType}')", Connection)
            SaveQuery.ExecuteNonQuery()
            MsgBox("Simpan data sukses!", MsgBoxStyle.Information, "Perhatian")
            Me.Close()
            VehicleListForm.LoadData()
        End If
    End Sub

    Private Sub VehicleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class