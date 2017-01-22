<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmployee
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnEdit2 = New System.Windows.Forms.Button()
        Me.Txtclass = New System.Windows.Forms.ComboBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Txtuser1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TbP_class = New System.Windows.Forms.TabPage()
        Me.Txtpassnew = New System.Windows.Forms.TextBox()
        Me.Txtpassold = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnEdit1 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbP_emp = New System.Windows.Forms.TabPage()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txtem5 = New System.Windows.Forms.TextBox()
        Me.TxtEm1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txtem7 = New System.Windows.Forms.TextBox()
        Me.Txtemp8 = New System.Windows.Forms.TextBox()
        Me.Txtem6 = New System.Windows.Forms.TextBox()
        Me.Txtem3 = New System.Windows.Forms.TextBox()
        Me.Txtem4 = New System.Windows.Forms.TextBox()
        Me.TxtEm2 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BttInsert = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbbprefix = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbP_class.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbP_emp.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtnEdit2)
        Me.TabPage2.Controls.Add(Me.Txtclass)
        Me.TabPage2.Controls.Add(Me.DataGridView3)
        Me.TabPage2.Controls.Add(Me.Txtuser1)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1356, 556)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "เปลี่ยนระดับผู้ใช้"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnEdit2
        '
        Me.BtnEdit2.BackColor = System.Drawing.Color.Snow
        Me.BtnEdit2.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnEdit2.Location = New System.Drawing.Point(1064, 131)
        Me.BtnEdit2.Name = "BtnEdit2"
        Me.BtnEdit2.Size = New System.Drawing.Size(270, 37)
        Me.BtnEdit2.TabIndex = 417
        Me.BtnEdit2.Text = "แก้ไข"
        Me.BtnEdit2.UseVisualStyleBackColor = False
        '
        'Txtclass
        '
        Me.Txtclass.FormattingEnabled = True
        Me.Txtclass.Items.AddRange(New Object() {"Admin" & Global.Microsoft.VisualBasic.ChrW(9), "User"})
        Me.Txtclass.Location = New System.Drawing.Point(143, 48)
        Me.Txtclass.Name = "Txtclass"
        Me.Txtclass.Size = New System.Drawing.Size(310, 34)
        Me.Txtclass.TabIndex = 415
        '
        'DataGridView3
        '
        Me.DataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(11, 174)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(1327, 363)
        Me.DataGridView3.TabIndex = 413
        '
        'Txtuser1
        '
        Me.Txtuser1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Txtuser1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txtuser1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txtuser1.Location = New System.Drawing.Point(143, 6)
        Me.Txtuser1.MaxLength = 50
        Me.Txtuser1.Name = "Txtuser1"
        Me.Txtuser1.ReadOnly = True
        Me.Txtuser1.Size = New System.Drawing.Size(310, 33)
        Me.Txtuser1.TabIndex = 409
        Me.Txtuser1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(10, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 26)
        Me.Label12.TabIndex = 412
        Me.Label12.Text = "Class :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(10, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 26)
        Me.Label14.TabIndex = 410
        Me.Label14.Text = "UserName :"
        '
        'TbP_class
        '
        Me.TbP_class.Controls.Add(Me.Txtpassnew)
        Me.TbP_class.Controls.Add(Me.Txtpassold)
        Me.TbP_class.Controls.Add(Me.TextBox2)
        Me.TbP_class.Controls.Add(Me.Label15)
        Me.TbP_class.Controls.Add(Me.TextBox1)
        Me.TbP_class.Controls.Add(Me.Label11)
        Me.TbP_class.Controls.Add(Me.BtnEdit1)
        Me.TbP_class.Controls.Add(Me.DataGridView2)
        Me.TbP_class.Controls.Add(Me.TxtUser)
        Me.TbP_class.Controls.Add(Me.Label8)
        Me.TbP_class.Location = New System.Drawing.Point(4, 22)
        Me.TbP_class.Name = "TbP_class"
        Me.TbP_class.Padding = New System.Windows.Forms.Padding(3)
        Me.TbP_class.Size = New System.Drawing.Size(1356, 556)
        Me.TbP_class.TabIndex = 2
        Me.TbP_class.Text = "เปลี่ยนรหัสผ่าน"
        Me.TbP_class.UseVisualStyleBackColor = True
        '
        'Txtpassnew
        '
        Me.Txtpassnew.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txtpassnew.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txtpassnew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txtpassnew.Location = New System.Drawing.Point(143, 85)
        Me.Txtpassnew.MaxLength = 50
        Me.Txtpassnew.Name = "Txtpassnew"
        Me.Txtpassnew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpassnew.Size = New System.Drawing.Size(310, 33)
        Me.Txtpassnew.TabIndex = 422
        '
        'Txtpassold
        '
        Me.Txtpassold.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txtpassold.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txtpassold.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txtpassold.Location = New System.Drawing.Point(143, 45)
        Me.Txtpassold.MaxLength = 50
        Me.Txtpassold.Name = "Txtpassold"
        Me.Txtpassold.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpassold.Size = New System.Drawing.Size(310, 33)
        Me.Txtpassold.TabIndex = 421
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox2.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox2.Location = New System.Drawing.Point(143, 85)
        Me.TextBox2.MaxLength = 15
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(125, 33)
        Me.TextBox2.TabIndex = 420
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(10, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 26)
        Me.Label15.TabIndex = 419
        Me.Label15.Text = "New Password :"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(143, 45)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(101, 33)
        Me.TextBox1.TabIndex = 417
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(10, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 26)
        Me.Label11.TabIndex = 416
        Me.Label11.Text = "Old Password :"
        '
        'BtnEdit1
        '
        Me.BtnEdit1.BackColor = System.Drawing.Color.Snow
        Me.BtnEdit1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnEdit1.Location = New System.Drawing.Point(1064, 131)
        Me.BtnEdit1.Name = "BtnEdit1"
        Me.BtnEdit1.Size = New System.Drawing.Size(270, 37)
        Me.BtnEdit1.TabIndex = 414
        Me.BtnEdit1.Text = "แก้ไข"
        Me.BtnEdit1.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(11, 174)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1327, 363)
        Me.DataGridView2.TabIndex = 413
        '
        'TxtUser
        '
        Me.TxtUser.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TxtUser.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtUser.Location = New System.Drawing.Point(143, 6)
        Me.TxtUser.MaxLength = 50
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.ReadOnly = True
        Me.TxtUser.Size = New System.Drawing.Size(310, 33)
        Me.TxtUser.TabIndex = 409
        Me.TxtUser.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(10, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 26)
        Me.Label8.TabIndex = 410
        Me.Label8.Text = "UserName :"
        '
        'TbP_emp
        '
        Me.TbP_emp.Controls.Add(Me.TxtID)
        Me.TbP_emp.Controls.Add(Me.txt_id)
        Me.TbP_emp.Controls.Add(Me.Label16)
        Me.TbP_emp.Controls.Add(Me.Label13)
        Me.TbP_emp.Controls.Add(Me.Txtem5)
        Me.TbP_emp.Controls.Add(Me.TxtEm1)
        Me.TbP_emp.Controls.Add(Me.Label7)
        Me.TbP_emp.Controls.Add(Me.Txtem7)
        Me.TbP_emp.Controls.Add(Me.Txtemp8)
        Me.TbP_emp.Controls.Add(Me.Txtem6)
        Me.TbP_emp.Controls.Add(Me.Txtem3)
        Me.TbP_emp.Controls.Add(Me.Txtem4)
        Me.TbP_emp.Controls.Add(Me.TxtEm2)
        Me.TbP_emp.Controls.Add(Me.DataGridView1)
        Me.TbP_emp.Controls.Add(Me.Btn_Delete)
        Me.TbP_emp.Controls.Add(Me.BtnEdit)
        Me.TbP_emp.Controls.Add(Me.BttInsert)
        Me.TbP_emp.Controls.Add(Me.Label9)
        Me.TbP_emp.Controls.Add(Me.Label10)
        Me.TbP_emp.Controls.Add(Me.Label5)
        Me.TbP_emp.Controls.Add(Me.cbbprefix)
        Me.TbP_emp.Controls.Add(Me.Label6)
        Me.TbP_emp.Controls.Add(Me.Label4)
        Me.TbP_emp.Controls.Add(Me.Label3)
        Me.TbP_emp.Controls.Add(Me.Label2)
        Me.TbP_emp.Controls.Add(Me.Label1)
        Me.TbP_emp.Location = New System.Drawing.Point(4, 35)
        Me.TbP_emp.Name = "TbP_emp"
        Me.TbP_emp.Padding = New System.Windows.Forms.Padding(3)
        Me.TbP_emp.Size = New System.Drawing.Size(1356, 543)
        Me.TbP_emp.TabIndex = 0
        Me.TbP_emp.Text = "ประวัติผู้ใช้ระบบ"
        Me.TbP_emp.UseVisualStyleBackColor = True
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(107, 9)
        Me.TxtID.MaxLength = 8
        Me.TxtID.Name = "TxtID"
        Me.TxtID.ReadOnly = True
        Me.TxtID.Size = New System.Drawing.Size(124, 33)
        Me.TxtID.TabIndex = 410
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_id.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_id.Location = New System.Drawing.Point(157, 138)
        Me.txt_id.MaxLength = 15
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(125, 33)
        Me.txt_id.TabIndex = 409
        Me.txt_id.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(10, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 26)
        Me.Label16.TabIndex = 408
        Me.Label16.Text = "รหัสพนักงาน :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(469, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 26)
        Me.Label13.TabIndex = 406
        '
        'Txtem5
        '
        Me.Txtem5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txtem5.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txtem5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txtem5.Location = New System.Drawing.Point(1136, 50)
        Me.Txtem5.MaxLength = 10
        Me.Txtem5.Name = "Txtem5"
        Me.Txtem5.Size = New System.Drawing.Size(198, 33)
        Me.Txtem5.TabIndex = 6
        '
        'TxtEm1
        '
        Me.TxtEm1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtEm1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtEm1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtEm1.Location = New System.Drawing.Point(393, 9)
        Me.TxtEm1.MaxLength = 13
        Me.TxtEm1.Name = "TxtEm1"
        Me.TxtEm1.Size = New System.Drawing.Size(163, 33)
        Me.TxtEm1.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 26)
        Me.Label7.TabIndex = 403
        Me.Label7.Text = "ตารางข้อมูลพนักงาน : "
        '
        'Txtem7
        '
        Me.Txtem7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txtem7.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txtem7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txtem7.Location = New System.Drawing.Point(314, 92)
        Me.Txtem7.MaxLength = 15
        Me.Txtem7.Name = "Txtem7"
        Me.Txtem7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtem7.Size = New System.Drawing.Size(125, 33)
        Me.Txtem7.TabIndex = 8
        '
        'Txtemp8
        '
        Me.Txtemp8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txtemp8.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txtemp8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txtemp8.Location = New System.Drawing.Point(314, 92)
        Me.Txtemp8.MaxLength = 15
        Me.Txtemp8.Name = "Txtemp8"
        Me.Txtemp8.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtemp8.Size = New System.Drawing.Size(125, 33)
        Me.Txtemp8.TabIndex = 402
        '
        'Txtem6
        '
        Me.Txtem6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txtem6.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txtem6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txtem6.Location = New System.Drawing.Point(106, 90)
        Me.Txtem6.MaxLength = 20
        Me.Txtem6.Name = "Txtem6"
        Me.Txtem6.Size = New System.Drawing.Size(125, 33)
        Me.Txtem6.TabIndex = 7
        '
        'Txtem3
        '
        Me.Txtem3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txtem3.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txtem3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txtem3.Location = New System.Drawing.Point(1136, 10)
        Me.Txtem3.MaxLength = 50
        Me.Txtem3.Name = "Txtem3"
        Me.Txtem3.Size = New System.Drawing.Size(198, 33)
        Me.Txtem3.TabIndex = 4
        '
        'Txtem4
        '
        Me.Txtem4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txtem4.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txtem4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txtem4.Location = New System.Drawing.Point(106, 49)
        Me.Txtem4.MaxLength = 250
        Me.Txtem4.Name = "Txtem4"
        Me.Txtem4.Size = New System.Drawing.Size(941, 33)
        Me.Txtem4.TabIndex = 5
        '
        'TxtEm2
        '
        Me.TxtEm2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtEm2.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtEm2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtEm2.Location = New System.Drawing.Point(870, 9)
        Me.TxtEm2.MaxLength = 50
        Me.TxtEm2.Name = "TxtEm2"
        Me.TxtEm2.Size = New System.Drawing.Size(177, 33)
        Me.TxtEm2.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 174)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1327, 363)
        Me.DataGridView1.TabIndex = 401
        '
        'Btn_Delete
        '
        Me.Btn_Delete.BackColor = System.Drawing.Color.Snow
        Me.Btn_Delete.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_Delete.Location = New System.Drawing.Point(1252, 131)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(82, 37)
        Me.Btn_Delete.TabIndex = 12
        Me.Btn_Delete.Text = "ลบข้อมูล"
        Me.Btn_Delete.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.Snow
        Me.BtnEdit.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnEdit.Location = New System.Drawing.Point(1164, 131)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(82, 37)
        Me.BtnEdit.TabIndex = 11
        Me.BtnEdit.Text = "แก้ไขข้อมูล"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BttInsert
        '
        Me.BttInsert.BackColor = System.Drawing.Color.Snow
        Me.BttInsert.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BttInsert.Location = New System.Drawing.Point(1076, 131)
        Me.BttInsert.Name = "BttInsert"
        Me.BttInsert.Size = New System.Drawing.Size(82, 37)
        Me.BttInsert.TabIndex = 10
        Me.BttInsert.Text = "เพิ่มข้อมูล"
        Me.BttInsert.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(237, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 26)
        Me.Label9.TabIndex = 396
        Me.Label9.Text = "Password :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 26)
        Me.Label10.TabIndex = 394
        Me.Label10.Text = "UserName :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1056, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 26)
        Me.Label5.TabIndex = 392
        Me.Label5.Text = "นามสกุล :"
        '
        'cbbprefix
        '
        Me.cbbprefix.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.cbbprefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbprefix.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbbprefix.FormattingEnabled = True
        Me.cbbprefix.Location = New System.Drawing.Point(687, 10)
        Me.cbbprefix.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbbprefix.Name = "cbbprefix"
        Me.cbbprefix.Size = New System.Drawing.Size(107, 34)
        Me.cbbprefix.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(596, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 26)
        Me.Label6.TabIndex = 389
        Me.Label6.Text = "คำนำหน้า : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1056, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 26)
        Me.Label4.TabIndex = 388
        Me.Label4.Text = "เบอร์โทรฯ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 26)
        Me.Label3.TabIndex = 385
        Me.Label3.Text = "ที่อยู่ :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(829, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 26)
        Me.Label2.TabIndex = 384
        Me.Label2.Text = "ชื่อ :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(248, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 26)
        Me.Label1.TabIndex = 383
        Me.Label1.Text = "เลขประจำตัวประชาชน :"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TbP_emp)
        Me.TabControl1.Controls.Add(Me.TbP_class)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(150, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1364, 582)
        Me.TabControl1.TabIndex = 385
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FrmEmployee
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1350, 725)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "พนักงาน"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbP_class.ResumeLayout(False)
        Me.TbP_class.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbP_emp.ResumeLayout(False)
        Me.TbP_emp.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Txtuser1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TbP_class As TabPage
    Friend WithEvents TbP_emp As TabPage
    Friend WithEvents Txtem7 As TextBox
    Friend WithEvents Txtemp8 As TextBox
    Friend WithEvents Txtem6 As TextBox
    Friend WithEvents Txtem3 As TextBox
    Friend WithEvents Txtem4 As TextBox
    Friend WithEvents TxtEm2 As TextBox
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BttInsert As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbbprefix As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents BtnEdit1 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Txtclass As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TxtEm1 As TextBox
    Friend WithEvents Txtem5 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Txtpassnew As TextBox
    Friend WithEvents Txtpassold As TextBox
    Friend WithEvents BtnEdit2 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents TxtID As TextBox
End Class
