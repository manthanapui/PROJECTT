<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepair
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
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DateRes = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 26)
        Me.Label18.TabIndex = 356
        Me.Label18.Text = "วันที่ซ่อม  :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(243, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 26)
        Me.Label17.TabIndex = 354
        Me.Label17.Text = "หมายเลขห้อง  :"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(102, 6)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(108, 33)
        Me.TextBox14.TabIndex = 351
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 26)
        Me.Label16.TabIndex = 348
        Me.Label16.Text = "รหัสการซ่อม :"
        '
        'DateRes
        '
        Me.DateRes.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateRes.Location = New System.Drawing.Point(102, 45)
        Me.DateRes.Name = "DateRes"
        Me.DateRes.Size = New System.Drawing.Size(340, 33)
        Me.DateRes.TabIndex = 357
        Me.DateRes.Value = New Date(2016, 5, 7, 0, 0, 0, 0)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(102, 162)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(340, 33)
        Me.TextBox1.TabIndex = 361
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 26)
        Me.Label1.TabIndex = 360
        Me.Label1.Text = "ค่าใช้จ่าย  :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(102, 84)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(340, 72)
        Me.TextBox2.TabIndex = 359
        Me.TextBox2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 26)
        Me.Label2.TabIndex = 358
        Me.Label2.Text = "รายการซ่อม :"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Snow
        Me.Button8.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button8.Location = New System.Drawing.Point(184, 212)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(82, 37)
        Me.Button8.TabIndex = 364
        Me.Button8.Text = "บันทึก"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Snow
        Me.Button1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(360, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 37)
        Me.Button1.TabIndex = 363
        Me.Button1.Text = "ออก"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Snow
        Me.Button2.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(96, 212)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 37)
        Me.Button2.TabIndex = 362
        Me.Button2.Text = "แก้ไข"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Snow
        Me.Button3.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.Location = New System.Drawing.Point(272, 212)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 37)
        Me.Button3.TabIndex = 365
        Me.Button3.Text = "ลบข้อมูล"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(333, 6)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(108, 34)
        Me.ComboBox4.TabIndex = 376
        '
        'FrmRepair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 261)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateRes)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.Label16)
        Me.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRepair"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลการแจ้งซ่อม"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents DateRes As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox4 As ComboBox
End Class
