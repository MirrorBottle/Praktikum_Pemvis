<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ResultComboBox = New System.Windows.Forms.ComboBox()
        Me.LengthComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LengthTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.ConvertBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ResultComboBox
        '
        Me.ResultComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResultComboBox.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResultComboBox.FormattingEnabled = True
        Me.ResultComboBox.Items.AddRange(New Object() {"km", "hm", "dam", "m", "dm", "cm", "mm"})
        Me.ResultComboBox.Location = New System.Drawing.Point(476, 74)
        Me.ResultComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ResultComboBox.Name = "ResultComboBox"
        Me.ResultComboBox.Size = New System.Drawing.Size(133, 33)
        Me.ResultComboBox.TabIndex = 0
        '
        'LengthComboBox
        '
        Me.LengthComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LengthComboBox.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LengthComboBox.FormattingEnabled = True
        Me.LengthComboBox.Items.AddRange(New Object() {"km", "hm", "dam", "m", "dm", "cm", "mm"})
        Me.LengthComboBox.Location = New System.Drawing.Point(476, 24)
        Me.LengthComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LengthComboBox.Name = "LengthComboBox"
        Me.LengthComboBox.Size = New System.Drawing.Size(133, 33)
        Me.LengthComboBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Input Panjang"
        '
        'LengthTextBox
        '
        Me.LengthTextBox.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LengthTextBox.Location = New System.Drawing.Point(158, 24)
        Me.LengthTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LengthTextBox.Name = "LengthTextBox"
        Me.LengthTextBox.Size = New System.Drawing.Size(314, 32)
        Me.LengthTextBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(10, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hasil Konversi"
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Enabled = False
        Me.ResultTextBox.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResultTextBox.Location = New System.Drawing.Point(158, 74)
        Me.ResultTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.Size = New System.Drawing.Size(314, 32)
        Me.ResultTextBox.TabIndex = 6
        '
        'ConvertBtn
        '
        Me.ConvertBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ConvertBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ConvertBtn.Location = New System.Drawing.Point(10, 123)
        Me.ConvertBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ConvertBtn.Name = "ConvertBtn"
        Me.ConvertBtn.Size = New System.Drawing.Size(297, 44)
        Me.ConvertBtn.TabIndex = 7
        Me.ConvertBtn.Text = "Konversi"
        Me.ConvertBtn.UseVisualStyleBackColor = False
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ResetBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResetBtn.Location = New System.Drawing.Point(324, 123)
        Me.ResetBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(284, 44)
        Me.ResetBtn.TabIndex = 8
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 197)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.ConvertBtn)
        Me.Controls.Add(Me.ResultTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LengthTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LengthComboBox)
        Me.Controls.Add(Me.ResultComboBox)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ResultComboBox As ComboBox
    Friend WithEvents LengthComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LengthTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ResultTextBox As TextBox
    Friend WithEvents ConvertBtn As Button
    Friend WithEvents ResetBtn As Button
End Class
