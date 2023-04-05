Imports System.Linq.Expressions

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        TxtBasicSalary.Select()

    End Sub

    Private Sub Calculate()
        If TxtBasicSalary.Text IsNot "" And ComboMonth.Text IsNot "" Then
            Dim normalAllowance = 50000
            Dim sickAllowance = 20000
            Dim noReasonAllowance = 30000
            Dim leaveAllowance = 5000

            Dim monthDays = Val(TxtMonth.Text)
            Dim basicSalary = Val(TxtBasicSalary.Text)
            Dim sickDays = If((TxtSick.Text Is ""), 0, Val(TxtSick.Text))
            Dim noReasonDays = If((TxtNoReason.Text Is ""), 0, Val(TxtNoReason.Text))
            Dim leaveDays = If((TxtLeave.Text Is ""), 0, Val(TxtLeave.Text))

            Dim allowance = (monthDays * normalAllowance) - (sickDays * sickAllowance) - (noReasonDays * noReasonAllowance) - (leaveDays * leaveAllowance)
            Dim netSalary = basicSalary + allowance

            TxtAllowance.Text = allowance.ToString()
            TxtNetSalary.Text = netSalary.ToString()
        End If
    End Sub

    Private Sub Clear()
        TxtBasicSalary.Text = ""
        ComboMonth.Text = ""
        TxtMonth.Text = ""
        TxtSick.Text = ""
        TxtNoReason.Text = ""
        TxtLeave.Text = ""
        TxtAllowance.Text = ""
        TxtNetSalary.Text = ""

        TxtBasicSalary.Focus()
    End Sub
    Private Sub ComboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMonth.SelectedIndexChanged
        Dim monthDays = New Integer() {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        Dim days = monthDays(ComboMonth.SelectedIndex) - 4
        TxtMonth.Text = days.ToString()
        Calculate()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If TxtBasicSalary.Text Is "" Then
            MsgBox("Gaji pokok tidak boleh kosong", vbCritical, "Gagal!")
            Return
        End If

        If ComboMonth.Text Is "" Then
            MsgBox("Bulan tidak boleh kosong", vbCritical, "Gagal!")
            Return
        End If

        Dim listitem As ListViewItem = ListView1.Items.Add(BasicSalary.Text)
        listitem.SubItems.Add(ComboMonth.Text)
        listitem.SubItems.Add(TxtMonth.Text)
        listitem.SubItems.Add(TxtSick.Text)
        listitem.SubItems.Add(TxtNoReason.Text)
        listitem.SubItems.Add(TxtLeave.Text)
        listitem.SubItems.Add(TxtAllowance.Text)
        listitem.SubItems.Add(TxtNetSalary.Text)

        MsgBox("Data berhasil ditambah!", vbOK, "Berhasil!")

        Clear()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Clear()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub TxtBasicSalary_TextChanged(sender As Object, e As EventArgs) Handles TxtBasicSalary.TextChanged
        Calculate()
    End Sub

    Private Sub TxtSick_TextChanged(sender As Object, e As EventArgs) Handles TxtSick.TextChanged
        Calculate()
    End Sub

    Private Sub TxtNoReason_TextChanged(sender As Object, e As EventArgs) Handles TxtNoReason.TextChanged
        Calculate()
    End Sub

    Private Sub TxtLeave_TextChanged(sender As Object, e As EventArgs) Handles TxtLeave.TextChanged
        Calculate()
    End Sub
End Class
