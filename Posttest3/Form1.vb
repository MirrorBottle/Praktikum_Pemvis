Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function GetTicketPrice() As Integer
        Dim price As Integer
        Select Case ComboDay.SelectedIndex
            Case 0 To 3
                price = 35000
        ' The following is the only Case clause that evaluates to True.
            Case 4
                price = 45000
            Case 5 To 6
                price = 55000
            Case Else
                price = 0
        End Select

        Return price
    End Function
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        ComboDetailTitle.SelectedIndex = ComboTitle.SelectedIndex
        TextDetailStudio.Text = TextStudio.Text
        ComboDetailDay.SelectedIndex = ComboDay.SelectedIndex
        TextDetailTotal.Text = TextTotal.Text
        RadioDetailTime1.Checked = RadioTime1.Checked
        RadioDetailTime2.Checked = RadioTime2.Checked
        RadioDetailTime3.Checked = RadioTime3.Checked
        RadioDetailTime4.Checked = RadioTime4.Checked

        For Each i As Integer In CheckListSits.CheckedIndices
            CheckListDetailSits.SetItemChecked(i, True)
        Next

        Dim price As Integer = Me.GetTicketPrice()
        Dim amount = price * Val(TextTotal.Text)
        TextDetailPayment.Text = Format(amount, "STANDARD")
        TabControl1.SelectedTab = Me.TabPage2
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ComboTitle.Text = ""
        TextStudio.Text = ""
        ComboDay.Text = ""
        TextTotal.Text = ""
        RadioTime1.Checked = False
        RadioTime2.Checked = False
        RadioTime3.Checked = False
        RadioTime4.Checked = False
        For i As Integer = 0 To CheckListSits.Items.Count - 1
            CheckListSits.SetItemChecked(i, False)
        Next

        ComboDetailTitle.Text = ""
        TextDetailStudio.Text = ""
        ComboDetailDay.Text = ""
        TextDetailTotal.Text = ""
        RadioDetailTime1.Checked = False
        RadioDetailTime2.Checked = False
        RadioDetailTime3.Checked = False
        RadioDetailTime4.Checked = False
        TextDetailPayment.Text = ""
        For i As Integer = 0 To CheckListDetailSits.Items.Count - 1
            CheckListDetailSits.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub ComboTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTitle.SelectedIndexChanged
        Dim studio = "Studio " & (ComboTitle.SelectedIndex + 1)
        TextStudio.Text = studio
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub CheckListSits_ItemCheck(sender As Object, e As EventArgs) Handles CheckListSits.SelectedIndexChanged
        TextTotal.Text = CheckListSits.CheckedItems.Count
    End Sub
End Class
