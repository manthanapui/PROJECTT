<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCustomer
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BttOK = New System.Windows.Forms.Button()
        Me.TextSearch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtRoom = New System.Windows.Forms.TextBox()
        Me.Txt_tel = New System.Windows.Forms.TextBox()
        Me.Txt_cus = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.cbb1 = New System.Windows.Forms.ComboBox()
        Me.DataGrideCus = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_zip = New System.Windows.Forms.TextBox()
        Me.Txt_addr = New System.Windows.Forms.TextBox()
        Me.DateCus = New System.Windows.Forms.DateTimePicker()
        Me.Txt_last = New System.Windows.Forms.TextBox()
        Me.Txt_name = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.DataGrideCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BttOK
        '
        Me.BttOK.AutoSize = True
        Me.BttOK.BackColor = System.Drawing.SystemColors.Control
        Me.BttOK.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BttOK.Location = New System.Drawing.Point(1263, 12)
        Me.BttOK.Name = "BttOK"
        Me.BttOK.Size = New System.Drawing.Size(75, 39)
        Me.BttOK.TabIndex = 15
        Me.BttOK.Text = "ค้นหา"
        Me.BttOK.UseVisualStyleBackColor = False
        '
        'TextSearch
        '
        Me.TextSearch.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextSearch.Location = New System.Drawing.Point(1064, 15)
        Me.TextSearch.Name = "TextSearch"
        Me.TextSearch.Size = New System.Drawing.Size(193, 33)
        Me.TextSearch.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(988, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 26)
        Me.Label9.TabIndex = 322
        Me.Label9.Text = "ค้นหา (ชื่อ)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 450)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 26)
        Me.Label10.TabIndex = 409
        Me.Label10.Text = "ห้องเลขที่ :"
        '
        'TxtRoom
        '
        Me.TxtRoom.Location = New System.Drawing.Point(169, 447)
        Me.TxtRoom.Name = "TxtRoom"
        Me.TxtRoom.ReadOnly = True
        Me.TxtRoom.Size = New System.Drawing.Size(230, 33)
        Me.TxtRoom.TabIndex = 10
        '
        'Txt_tel
        '
        Me.Txt_tel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_tel.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txt_tel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txt_tel.Location = New System.Drawing.Point(169, 369)
        Me.Txt_tel.MaxLength = 10
        Me.Txt_tel.Name = "Txt_tel"
        Me.Txt_tel.Size = New System.Drawing.Size(230, 33)
        Me.Txt_tel.TabIndex = 8
        '
        'Txt_cus
        '
        Me.Txt_cus.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_cus.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txt_cus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txt_cus.Location = New System.Drawing.Point(169, 96)
        Me.Txt_cus.MaxLength = 13
        Me.Txt_cus.Name = "Txt_cus"
        Me.Txt_cus.Size = New System.Drawing.Size(228, 33)
        Me.Txt_cus.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(24, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 26)
        Me.Label1.TabIndex = 406
        Me.Label1.Text = "เลขประจำตัวประชาชน :"
        '
        'Btn_Delete
        '
        Me.Btn_Delete.BackColor = System.Drawing.Color.Snow
        Me.Btn_Delete.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_Delete.Location = New System.Drawing.Point(292, 486)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(107, 35)
        Me.Btn_Delete.TabIndex = 12
        Me.Btn_Delete.Text = "ลบข้อมูล"
        Me.Btn_Delete.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.Snow
        Me.BtnEdit.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnEdit.Location = New System.Drawing.Point(169, 486)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(107, 35)
        Me.BtnEdit.TabIndex = 11
        Me.BtnEdit.Text = "แก้ไข"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'cbb1
        '
        Me.cbb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb1.FormattingEnabled = True
        Me.cbb1.Location = New System.Drawing.Point(169, 134)
        Me.cbb1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbb1.Name = "cbb1"
        Me.cbb1.Size = New System.Drawing.Size(228, 34)
        Me.cbb1.TabIndex = 3
        '
        'DataGrideCus
        '
        Me.DataGrideCus.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrideCus.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrideCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrideCus.Location = New System.Drawing.Point(403, 57)
        Me.DataGrideCus.Name = "DataGrideCus"
        Me.DataGrideCus.Size = New System.Drawing.Size(935, 470)
        Me.DataGrideCus.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 372)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 26)
        Me.Label8.TabIndex = 404
        Me.Label8.Text = "เบอร์โทรฯ :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 333)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 26)
        Me.Label7.TabIndex = 403
        Me.Label7.Text = "รหัสไปรษณีย์ :"
        '
        'Txt_zip
        '
        Me.Txt_zip.Location = New System.Drawing.Point(169, 330)
        Me.Txt_zip.MaxLength = 5
        Me.Txt_zip.Name = "Txt_zip"
        Me.Txt_zip.Size = New System.Drawing.Size(230, 33)
        Me.Txt_zip.TabIndex = 7
        '
        'Txt_addr
        '
        Me.Txt_addr.Location = New System.Drawing.Point(169, 252)
        Me.Txt_addr.Multiline = True
        Me.Txt_addr.Name = "Txt_addr"
        Me.Txt_addr.Size = New System.Drawing.Size(229, 72)
        Me.Txt_addr.TabIndex = 6
        '
        'DateCus
        '
        Me.DateCus.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateCus.Location = New System.Drawing.Point(169, 408)
        Me.DateCus.Name = "DateCus"
        Me.DateCus.Size = New System.Drawing.Size(230, 33)
        Me.DateCus.TabIndex = 9
        Me.DateCus.Value = New Date(2016, 12, 1, 0, 0, 0, 0)
        '
        'Txt_last
        '
        Me.Txt_last.Location = New System.Drawing.Point(169, 213)
        Me.Txt_last.MaxLength = 50
        Me.Txt_last.Name = "Txt_last"
        Me.Txt_last.Size = New System.Drawing.Size(229, 33)
        Me.Txt_last.TabIndex = 5
        '
        'Txt_name
        '
        Me.Txt_name.Location = New System.Drawing.Point(169, 174)
        Me.Txt_name.MaxLength = 50
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.Size = New System.Drawing.Size(229, 33)
        Me.Txt_name.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 26)
        Me.Label6.TabIndex = 397
        Me.Label6.Text = "คำนำหน้า"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 26)
        Me.Label5.TabIndex = 395
        Me.Label5.Text = "นามสกุล  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 413)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 26)
        Me.Label4.TabIndex = 393
        Me.Label4.Text = "วันเดือนปีเกิด :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 26)
        Me.Label3.TabIndex = 392
        Me.Label3.Text = "ที่อยู่ :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 26)
        Me.Label2.TabIndex = 389
        Me.Label2.Text = "ชื่อ  :"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(169, 57)
        Me.TxtID.MaxLength = 8
        Me.TxtID.Name = "TxtID"
        Me.TxtID.ReadOnly = True
        Me.TxtID.Size = New System.Drawing.Size(228, 33)
        Me.TxtID.TabIndex = 1
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_id.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_id.Location = New System.Drawing.Point(403, 57)
        Me.txt_id.MaxLength = 15
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(125, 33)
        Me.txt_id.TabIndex = 412
        Me.txt_id.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(24, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 26)
        Me.Label16.TabIndex = 411
        Me.Label16.Text = "รหัสลูกค้า :"
        '
        'FrmCustomer
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtRoom)
        Me.Controls.Add(Me.Txt_tel)
        Me.Controls.Add(Me.Txt_cus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.cbb1)
        Me.Controls.Add(Me.DataGrideCus)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Txt_zip)
        Me.Controls.Add(Me.Txt_addr)
        Me.Controls.Add(Me.DateCus)
        Me.Controls.Add(Me.Txt_last)
        Me.Controls.Add(Me.Txt_name)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BttOK)
        Me.Controls.Add(Me.TextSearch)
        Me.Controls.Add(Me.Label9)
        Me.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ข้อมูลลูกค้า"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGrideCus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BttOK As Button
    Friend WithEvents TextSearch As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtRoom As TextBox
    Friend WithEvents Txt_tel As TextBox
    Friend WithEvents Txt_cus As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents cbb1 As ComboBox
    Friend WithEvents DataGrideCus As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_zip As TextBox
    Friend WithEvents Txt_addr As TextBox
    Friend WithEvents DateCus As DateTimePicker
    Friend WithEvents Txt_last As TextBox
    Friend WithEvents Txt_name As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label16 As Label
End Class
