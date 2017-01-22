<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.setting = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSToPass = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSToPrefix = New System.Windows.Forms.ToolStripMenuItem()
        Me.ขอมลToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSToCus = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSToReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSToBill = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.เกยวกบระบบToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TStoRoom = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.บนทกคานำคาไฟฟาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.พมพใบเสรจใบแจงหนToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.คนหารายงานToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip2.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.setting, Me.ขอมลToolStripMenuItem, Me.HelToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1167, 34)
        Me.MenuStrip2.TabIndex = 30
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'setting
        '
        Me.setting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSToPass, Me.TSToPrefix})
        Me.setting.Name = "setting"
        Me.setting.Size = New System.Drawing.Size(100, 30)
        Me.setting.Text = "ตั้งค่าการใช้งาน"
        '
        'TSToPass
        '
        Me.TSToPass.Image = CType(resources.GetObject("TSToPass.Image"), System.Drawing.Image)
        Me.TSToPass.Name = "TSToPass"
        Me.TSToPass.Size = New System.Drawing.Size(165, 30)
        Me.TSToPass.Text = "กำหนดรหัสผ่าน"
        '
        'TSToPrefix
        '
        Me.TSToPrefix.Image = CType(resources.GetObject("TSToPrefix.Image"), System.Drawing.Image)
        Me.TSToPrefix.Name = "TSToPrefix"
        Me.TSToPrefix.Size = New System.Drawing.Size(165, 30)
        Me.TSToPrefix.Text = "คำนำหน้า"
        '
        'ขอมลToolStripMenuItem
        '
        Me.ขอมลToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSToCus, Me.TSToReport, Me.TSToBill})
        Me.ขอมลToolStripMenuItem.Name = "ขอมลToolStripMenuItem"
        Me.ขอมลToolStripMenuItem.Size = New System.Drawing.Size(54, 30)
        Me.ขอมลToolStripMenuItem.Text = "ข้อมูล"
        '
        'TSToCus
        '
        Me.TSToCus.Image = CType(resources.GetObject("TSToCus.Image"), System.Drawing.Image)
        Me.TSToCus.Name = "TSToCus"
        Me.TSToCus.Size = New System.Drawing.Size(202, 30)
        Me.TSToCus.Text = "ข้อมูลลูกค้า"
        '
        'TSToReport
        '
        Me.TSToReport.Image = CType(resources.GetObject("TSToReport.Image"), System.Drawing.Image)
        Me.TSToReport.Name = "TSToReport"
        Me.TSToReport.Size = New System.Drawing.Size(202, 30)
        Me.TSToReport.Text = "ระบบค้นหาและรายงาน"
        '
        'TSToBill
        '
        Me.TSToBill.Image = CType(resources.GetObject("TSToBill.Image"), System.Drawing.Image)
        Me.TSToBill.Name = "TSToBill"
        Me.TSToBill.Size = New System.Drawing.Size(202, 30)
        Me.TSToBill.Text = "พิมพ์ใบแจ้งหนี้"
        '
        'HelToolStripMenuItem
        '
        Me.HelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.เกยวกบระบบToolStripMenuItem1})
        Me.HelToolStripMenuItem.Name = "HelToolStripMenuItem"
        Me.HelToolStripMenuItem.Size = New System.Drawing.Size(48, 30)
        Me.HelToolStripMenuItem.Text = "Help"
        '
        'เกยวกบระบบToolStripMenuItem1
        '
        Me.เกยวกบระบบToolStripMenuItem1.Name = "เกยวกบระบบToolStripMenuItem1"
        Me.เกยวกบระบบToolStripMenuItem1.Size = New System.Drawing.Size(152, 30)
        Me.เกยวกบระบบToolStripMenuItem1.Text = "เกี่ยวกับระบบ"
        '
        'TStoRoom
        '
        Me.TStoRoom.Image = CType(resources.GetObject("TStoRoom.Image"), System.Drawing.Image)
        Me.TStoRoom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TStoRoom.Name = "TStoRoom"
        Me.TStoRoom.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.TStoRoom.Size = New System.Drawing.Size(106, 78)
        Me.TStoRoom.Text = "สถานะห้องพัก"
        Me.TStoRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSCustomer
        '
        Me.TSCustomer.Image = CType(resources.GetObject("TSCustomer.Image"), System.Drawing.Image)
        Me.TSCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSCustomer.Name = "TSCustomer"
        Me.TSCustomer.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.TSCustomer.Size = New System.Drawing.Size(92, 78)
        Me.TSCustomer.Text = "ลูกค้า"
        Me.TSCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'บนทกคานำคาไฟฟาToolStripMenuItem
        '
        Me.บนทกคานำคาไฟฟาToolStripMenuItem.Image = CType(resources.GetObject("บนทกคานำคาไฟฟาToolStripMenuItem.Image"), System.Drawing.Image)
        Me.บนทกคานำคาไฟฟาToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.บนทกคานำคาไฟฟาToolStripMenuItem.Name = "บนทกคานำคาไฟฟาToolStripMenuItem"
        Me.บนทกคานำคาไฟฟาToolStripMenuItem.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.บนทกคานำคาไฟฟาToolStripMenuItem.Size = New System.Drawing.Size(138, 78)
        Me.บนทกคานำคาไฟฟาToolStripMenuItem.Text = "บันทึกค่าน้ำ /ค่าไฟฟ้า"
        Me.บนทกคานำคาไฟฟาToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'พมพใบเสรจใบแจงหนToolStripMenuItem
        '
        Me.พมพใบเสรจใบแจงหนToolStripMenuItem.Image = CType(resources.GetObject("พมพใบเสรจใบแจงหนToolStripMenuItem.Image"), System.Drawing.Image)
        Me.พมพใบเสรจใบแจงหนToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.พมพใบเสรจใบแจงหนToolStripMenuItem.Name = "พมพใบเสรจใบแจงหนToolStripMenuItem"
        Me.พมพใบเสรจใบแจงหนToolStripMenuItem.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.พมพใบเสรจใบแจงหนToolStripMenuItem.Size = New System.Drawing.Size(152, 78)
        Me.พมพใบเสรจใบแจงหนToolStripMenuItem.Text = "พิมพ์ใบเสร็จ/ใบแจ้งหนี้"
        Me.พมพใบเสรจใบแจงหนToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'คนหารายงานToolStripMenuItem
        '
        Me.คนหารายงานToolStripMenuItem.Image = CType(resources.GetObject("คนหารายงานToolStripMenuItem.Image"), System.Drawing.Image)
        Me.คนหารายงานToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.คนหารายงานToolStripMenuItem.Name = "คนหารายงานToolStripMenuItem"
        Me.คนหารายงานToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.คนหารายงานToolStripMenuItem.Size = New System.Drawing.Size(124, 78)
        Me.คนหารายงานToolStripMenuItem.Text = "ค้นหารายงาน"
        Me.คนหารายงานToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.คนหารายงานToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSEmployee
        '
        Me.TSEmployee.Image = CType(resources.GetObject("TSEmployee.Image"), System.Drawing.Image)
        Me.TSEmployee.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TSEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSEmployee.Name = "TSEmployee"
        Me.TSEmployee.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.TSEmployee.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TSEmployee.Size = New System.Drawing.Size(101, 78)
        Me.TSEmployee.Text = "พนักงาน"
        Me.TSEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TSEmployee.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.TSEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(92, 78)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        Me.LogoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TStoRoom, Me.TSCustomer, Me.บนทกคานำคาไฟฟาToolStripMenuItem, Me.พมพใบเสรจใบแจงหนToolStripMenuItem, Me.คนหารายงานToolStripMenuItem, Me.TSEmployee, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 34)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 5, 0, 5)
        Me.MenuStrip1.Size = New System.Drawing.Size(1167, 88)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1167, 370)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip2
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ระบบหอพักฉัตรเพชรแมนชั่น"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents setting As ToolStripMenuItem
    Friend WithEvents ขอมลToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSToCus As ToolStripMenuItem
    Friend WithEvents TSToReport As ToolStripMenuItem
    Friend WithEvents TSToBill As ToolStripMenuItem
    Friend WithEvents HelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents เกยวกบระบบToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TSToPass As ToolStripMenuItem
    Friend WithEvents TSToPrefix As ToolStripMenuItem
    Friend WithEvents TStoRoom As ToolStripMenuItem
    Friend WithEvents TSCustomer As ToolStripMenuItem
    Friend WithEvents บนทกคานำคาไฟฟาToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents พมพใบเสรจใบแจงหนToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents คนหารายงานToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSEmployee As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
