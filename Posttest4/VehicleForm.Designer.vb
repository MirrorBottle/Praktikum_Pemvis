<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VehicleForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.TextVehicleName = New System.Windows.Forms.TextBox()
        Me.TextPoliceNumber = New System.Windows.Forms.TextBox()
        Me.TextCilinderType = New System.Windows.Forms.TextBox()
        Me.TextYear = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboFuelType = New System.Windows.Forms.ComboBox()
        Me.ComboVehicleType = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tambah Data Kendaraan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(19, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Kendaraan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(19, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "No. Polisi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(19, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Isi Silinder"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(19, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tahun"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(19, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 21)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Jenis BBM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(19, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 21)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Tipe Guna"
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnAdd.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAdd.Location = New System.Drawing.Point(12, 396)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(121, 42)
        Me.BtnAdd.TabIndex = 10
        Me.BtnAdd.Text = "Simpan"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnClear.Location = New System.Drawing.Point(393, 396)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(121, 42)
        Me.BtnClear.TabIndex = 11
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'TextVehicleName
        '
        Me.TextVehicleName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextVehicleName.Location = New System.Drawing.Point(192, 79)
        Me.TextVehicleName.Name = "TextVehicleName"
        Me.TextVehicleName.Size = New System.Drawing.Size(322, 29)
        Me.TextVehicleName.TabIndex = 12
        '
        'TextPoliceNumber
        '
        Me.TextPoliceNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextPoliceNumber.Location = New System.Drawing.Point(192, 123)
        Me.TextPoliceNumber.Name = "TextPoliceNumber"
        Me.TextPoliceNumber.Size = New System.Drawing.Size(142, 29)
        Me.TextPoliceNumber.TabIndex = 13
        '
        'TextCilinderType
        '
        Me.TextCilinderType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextCilinderType.Location = New System.Drawing.Point(192, 165)
        Me.TextCilinderType.Name = "TextCilinderType"
        Me.TextCilinderType.Size = New System.Drawing.Size(142, 29)
        Me.TextCilinderType.TabIndex = 14
        '
        'TextYear
        '
        Me.TextYear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextYear.Location = New System.Drawing.Point(192, 210)
        Me.TextYear.Name = "TextYear"
        Me.TextYear.Size = New System.Drawing.Size(142, 29)
        Me.TextYear.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(340, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 21)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "CC"
        '
        'ComboFuelType
        '
        Me.ComboFuelType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboFuelType.FormattingEnabled = True
        Me.ComboFuelType.Items.AddRange(New Object() {"Premium", "Pertalite", "Pertamax", "Dexlite", "Solar"})
        Me.ComboFuelType.Location = New System.Drawing.Point(192, 259)
        Me.ComboFuelType.Name = "ComboFuelType"
        Me.ComboFuelType.Size = New System.Drawing.Size(142, 29)
        Me.ComboFuelType.TabIndex = 17
        '
        'ComboVehicleType
        '
        Me.ComboVehicleType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboVehicleType.FormattingEnabled = True
        Me.ComboVehicleType.Items.AddRange(New Object() {"Jabatan", "Operasional", "Barang", "Penumpang"})
        Me.ComboVehicleType.Location = New System.Drawing.Point(192, 313)
        Me.ComboVehicleType.Name = "ComboVehicleType"
        Me.ComboVehicleType.Size = New System.Drawing.Size(142, 29)
        Me.ComboVehicleType.TabIndex = 18
        '
        'VehicleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 450)
        Me.Controls.Add(Me.ComboVehicleType)
        Me.Controls.Add(Me.ComboFuelType)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextYear)
        Me.Controls.Add(Me.TextCilinderType)
        Me.Controls.Add(Me.TextPoliceNumber)
        Me.Controls.Add(Me.TextVehicleName)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VehicleForm"
        Me.Text = "Form Data Kendaraan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents TextVehicleName As TextBox
    Friend WithEvents TextPoliceNumber As TextBox
    Friend WithEvents TextCilinderType As TextBox
    Friend WithEvents TextYear As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboFuelType As ComboBox
    Friend WithEvents ComboVehicleType As ComboBox
End Class
