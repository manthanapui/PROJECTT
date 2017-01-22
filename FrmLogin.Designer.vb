<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Cancel1 = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(129, 121)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(108, 33)
        Me.TextBox14.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(129, 164)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(108, 33)
        Me.TextBox1.TabIndex = 2
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.BackColor = System.Drawing.Color.Transparent
        Me.Lbl2.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lbl2.Location = New System.Drawing.Point(47, 166)
        Me.Lbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(59, 26)
        Me.Lbl2.TabIndex = 355
        Me.Lbl2.Text = "รหัสผ่าน"
        Me.Lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.BackColor = System.Drawing.Color.Transparent
        Me.Lbl1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lbl1.Location = New System.Drawing.Point(47, 123)
        Me.Lbl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(68, 26)
        Me.Lbl1.TabIndex = 354
        Me.Lbl1.Text = "ชื่อผู้ใช้งาน"
        Me.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cancel1
        '
        Me.Cancel1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Cancel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cancel1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cancel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cancel1.Location = New System.Drawing.Point(179, 239)
        Me.Cancel1.Name = "Cancel1"
        Me.Cancel1.Size = New System.Drawing.Size(89, 38)
        Me.Cancel1.TabIndex = 4
        Me.Cancel1.Text = "ยกเลิก"
        Me.Cancel1.UseVisualStyleBackColor = False
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.LemonChiffon
        Me.OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.OK.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.OK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.OK.Location = New System.Drawing.Point(84, 239)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(89, 38)
        Me.OK.TabIndex = 3
        Me.OK.Text = "ตกลง"
        Me.OK.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.OK.UseVisualStyleBackColor = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.Cancel1)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox14)
        Me.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ลงชื่อเข้าระบบ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Lbl2 As Label
    Friend WithEvents Lbl1 As Label
    Friend WithEvents Cancel1 As Button
    Friend WithEvents OK As Button
End Class
