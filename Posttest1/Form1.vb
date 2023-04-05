Public Class Form1

    Private Sub ConvertBtn_Click(sender As Object, e As EventArgs) Handles ConvertBtn.Click
        Dim units = New String() {"km", "hm", "dam", "m", "dm", "cm", "mm"}
        Dim lengthUnitIndex As Integer = Array.IndexOf(units, LengthComboBox.Text)
        Dim resultUnitIndex As Integer = Array.IndexOf(units, ResultComboBox.Text)

        If lengthUnitIndex = -1 Or resultUnitIndex = -1 Then
            MsgBox("Satuan panjang tidak lengkap!")
            Return
        End If

        Dim indexDiff = lengthUnitIndex - resultUnitIndex
        Dim convertion = Math.Pow(10, Math.Abs(indexDiff))
        Dim result = If((indexDiff < 0), Val(LengthTextBox.Text) * convertion, Val(LengthTextBox.Text) / convertion)
        ResultTextBox.Text = result.ToString()
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        ResultTextBox.Text = ""
        LengthTextBox.Text = ""
        LengthComboBox.Text = ""
        ResultComboBox.Text = ""
    End Sub
End Class
