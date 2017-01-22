Imports System.Data
Imports System.Data.SqlClient
Public Class FrmEmployee
    Private Sub FrmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        sql = "SELECT * FROM Table_Prefix"
        cmd_dataTable()
        cbbprefix.DataSource = DS.Tables("table")
        cbbprefix.DisplayMember = "prefix"
        cbbprefix.ValueMember = "ID_prefix"
        auto_Number()
        refresh_employee()
    End Sub
    Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.Enter
                ProcessDialogKey(Keys.Tab)
            Case Keys.Escape
                ProcessDialogKey(Keys.Shift Or Keys.Tab)
        End Select
        Return MyBase.ProcessDialogKey(keyData)
    End Function



    Public Sub formatGrid()

        With DataGridView1
            .Columns(0).HeaderText = "รหัสพนักงาน"
            .Columns(1).HeaderText = "เลขประจำตัวประชาชน"
            .Columns(2).HeaderText = "คำนำหน้านาม"
            .Columns(3).HeaderText = "ชื่อ"
            .Columns(4).HeaderText = "นามสกุล"
            .Columns(5).HeaderText = "ที่อยู่"
            .Columns(6).HeaderText = "เบอร์โทร"
            .Columns(7).HeaderText = "User"
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(10).Visible = False

            .Columns(0).Width = 110
            .Columns(1).Width = 150
            .Columns(2).Width = 150
            .Columns(3).Width = 150
            .Columns(4).Width = 150
            .Columns(5).Width = 474

        End With
        With DataGridView2

            .Columns(3).HeaderText = "ชื่อผู้ใช้งาน"
            .Columns(7).HeaderText = "User"
            DataGridView2.Columns(0).Visible = False
            DataGridView2.Columns(1).Visible = False
            DataGridView2.Columns(2).Visible = False
            DataGridView2.Columns(4).Visible = False
            DataGridView2.Columns(5).Visible = False
            DataGridView2.Columns(6).Visible = False
            DataGridView2.Columns(8).Visible = False
            DataGridView2.Columns(9).Visible = False
            DataGridView2.Columns(10).Visible = False



        End With
        With DataGridView3



            .Columns(3).HeaderText = "ชื่อผู้ใช้งาน"
            .Columns(7).HeaderText = "User"
            .Columns(9).HeaderText = "ระดับผู้ใช้งาน"
            DataGridView3.Columns(0).Visible = False
            DataGridView3.Columns(1).Visible = False
            DataGridView3.Columns(2).Visible = False
            DataGridView3.Columns(3).Visible = True
            DataGridView3.Columns(4).Visible = False
            DataGridView3.Columns(5).Visible = False
            DataGridView3.Columns(6).Visible = False
            DataGridView3.Columns(7).Visible = True
            DataGridView3.Columns(8).Visible = False
            DataGridView3.Columns(9).Visible = True
            DataGridView3.Columns(10).Visible = False
            .Columns(3).Width = 150
            .Columns(7).Width = 150
            .Columns(9).Width = 150


        End With
    End Sub

    Private Sub refresh_employee()
        sql = "SELECT Table_Employee.ID_EM,id_card,Table_Prefix.prefix,Table_Employee.name_emp,last_emp,addr_emp,
                tel_emp,user_emp,pass_emp,class,auto_id
                FROM  Table_Employee,Table_Prefix
                where Table_Employee.ID_prefix = Table_Prefix.ID_prefix"

        DataGridView1.DataSource = cmd_dataTable()
        DataGridView2.DataSource = cmd_dataTable()
        DataGridView3.DataSource = cmd_dataTable()
        formatGrid()

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim i As Integer = DataGridView1.CurrentRow.Index
        TxtID.Text = DataGridView1.Item(0, i).Value
        TxtEm1.Text = DataGridView1.Item(1, i).Value
        cbbprefix.Text = DataGridView1.Item(2, i).Value
        TxtEm2.Text = DataGridView1.Item(3, i).Value
        Txtem3.Text = DataGridView1.Item(4, i).Value
        Txtem4.Text = DataGridView1.Item(5, i).Value
        Txtem5.Text = DataGridView1.Item(6, i).Value
        Txtem6.Text = DataGridView1.Item(7, i).Value
        Txtem7.Text = DataGridView1.Item(8, i).Value
        Txtemp8.Text = DataGridView1.Item(10, i).Value
        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(9).Visible = False
        DataGridView1.Columns(10).Visible = False


    End Sub



    Private Sub BttInsert_Click(sender As Object, e As EventArgs) Handles BttInsert.Click
        'ตรวจสอบข้อมูลซ้ำจากตาราง Table_Employee

        Dim intNumRows As Integer
        sql = "SELECT COUNT(*) FROM Table_Employee WHERE id_card = '" & Me.TxtEm1.Text & "' "
        cmd = New SqlCommand(sql, cn)
        intNumRows = cmd.ExecuteScalar() 'อ่านข้อมูลคอลัมน์แรกในตาราง
        If intNumRows > 0 Then
            MessageBox.Show("คุณกรอกข้อมูลซ้ำ")
        Else
            sql = "INSERT INTO Table_Employee(ID_EM,id_card,ID_prefix,name_emp,last_emp,addr_emp,
            tel_emp,user_emp,pass_emp,auto_idem)
            VALUES(@ID_EM,@id,@prefix,@name,@last,@addr,@tel_emp,@user_emp,@pass_emp,@auto_idem)"
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ID_EM", TxtID.Text)
            cmd.Parameters.AddWithValue("@id", TxtEm1.Text)
            cmd.Parameters.AddWithValue("@prefix", cbbprefix.SelectedValue)
            cmd.Parameters.AddWithValue("@name", TxtEm2.Text)
            cmd.Parameters.AddWithValue("@last", Txtem3.Text)
            cmd.Parameters.AddWithValue("@addr", Txtem4.Text)
            cmd.Parameters.AddWithValue("@tel_emp", Txtem5.Text)
            cmd.Parameters.AddWithValue("@user_emp", Txtem6.Text)
            cmd.Parameters.AddWithValue("@pass_emp", Txtem7.Text)
            cmd.Parameters.AddWithValue("@auto_idem", txt_id.Text)



            If TxtEm1.Text = "" Or TxtEm2.Text = "" Or Txtem3.Text = "" Or Txtem4.Text = "" Or Txtem5.Text = "" Or Txtem6.Text = "" Or Txtem7.Text = "" Then
                MessageBox.Show("คุณกรอกข้อมูลไม่ครบ")
                Exit Sub
            ElseIf TxtEm1.TextLength < 13 Then
                MessageBox.Show("กรุณาข้อมูลให้ครบ 13 ตัว", "เกิดข้อผิดพลาด")
                    TxtEm1.Focus()
                    Exit Sub
                ElseIf Txtem5.TextLength < 10 Then
                    MessageBox.Show("กรุณาข้อมูลให้ครบ 10 ตัว", "เกิดข้อผิดพลาด")
                    Txtem5.Focus()
                    Exit Sub
                End If

                Dim r As Integer = cmd.ExecuteNonQuery()
                If r <= 0 Then
                    MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถเพิ่มข้อมูลได้")
                    Exit Sub
                Else
                MessageBox.Show("บันทึกข้อมูลแล้ว")
                TxtEm1.Text = ""
                cbbprefix.SelectedValue = ""
                TxtEm2.Text = ""
                Txtem3.Text = ""
                Txtem4.Text = ""
                Txtem5.Text = ""
                Txtem6.Text = ""
                Txtem7.Text = ""
            End If
            End If
        auto_Number()
        refresh_employee()
    End Sub
    Private Sub auto_Number()
        sql = "select max(auto_idem) from Table_Employee"
        Try
            Dim numchar_id As String = "EM-" & (cmd_excuteScalar() + 1).ToString.PadLeft(3, "0")
            TxtID.Text = numchar_id
            txt_id.Text = cmd_excuteScalar() + 1
        Catch ex As Exception
            TxtID.Text = "EM-001"
            txt_id.Text = 1
        End Try
    End Sub


    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Dim result As DialogResult =
            MessageBox.Show("ท่านต้องการลบข้อมูลจริงหรือไม่", "ยืนยันการลบ", MessageBoxButtons.OKCancel)
        If result = DialogResult.Cancel Then
            Exit Sub
        End If
        sql = "delete from Table_Employee where id_card = '" & TxtEm1.Text & "'"
        If cmd_excuteNonQuery() = 0 Then
            MessageBox.Show("เกิดข้อผิดพลาด")
        Else
            MessageBox.Show("ลบข้อมูลแล้ว")
        End If
        refresh_employee()
        TxtEm1.Text = ""
        cbbprefix.SelectedValue = ""
        TxtEm2.Text = ""
        Txtem3.Text = ""
        Txtem4.Text = ""
        Txtem5.Text = ""
        Txtem6.Text = ""
        Txtem7.Text = ""
    End Sub


    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim i As Integer = DataGridView2.CurrentRow.Index

        TxtUser.Text = DataGridView2.Item(7, i).Value
        TextBox1.Text = DataGridView2.Item(8, i).Value
        TextBox2.Text = DataGridView2.Item(0, i).Value
        DataGridView2.Columns(0).Visible = False
        DataGridView2.Columns(1).Visible = False
        DataGridView2.Columns(2).Visible = False
        DataGridView2.Columns(3).Visible = True
        DataGridView2.Columns(4).Visible = False
        DataGridView2.Columns(5).Visible = False
        DataGridView2.Columns(6).Visible = False
        DataGridView2.Columns(7).Visible = True
        DataGridView2.Columns(8).Visible = False
        DataGridView2.Columns(9).Visible = False
        DataGridView2.Columns(10).Visible = False
    End Sub

    Private Sub BtnEdit1_Click(sender As Object, e As EventArgs) Handles BtnEdit1.Click
        If Txtpassold.Text <> TextBox1.Text Then
            MessageBox.Show("คุณกรอกรหัสเก่าผิดพลาด", "เกิดข้อผิดพลาด")
        Else
            sql = "UPDATE Table_Employee 
                SET user_emp = @user_emp,pass_emp = @pass_emp
                WHERE ID_EM = @idemp "
            cmd = New SqlCommand(sql, cn)
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@user_emp", TxtUser.Text)
            cmd.Parameters.AddWithValue("@pass_emp", Txtpassnew.Text)
            cmd.Parameters.AddWithValue("@idemp", TextBox2.Text)



            Dim r As Integer = cmd.ExecuteNonQuery()
            If r <= 0 Then
                MessageBox.Show("ไม่สามารถแก้ไขข้อมูลได้", "เกิดข้อผิดพลาด")
            Else
                MessageBox.Show("ข้อมูลได้รับการแก้ไขแล้ว")
            End If
        End If
        Txtpassold.Text = ""
        TxtUser.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        Txtpassnew.Text = ""
        refresh_employee()
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        Dim i As Integer = DataGridView3.CurrentRow.Index

        Txtuser1.Text = DataGridView3.Item(7, i).Value

        DataGridView3.Columns(0).Visible = False
        DataGridView3.Columns(1).Visible = False
        DataGridView3.Columns(2).Visible = False
        DataGridView3.Columns(3).Visible = True
        DataGridView3.Columns(4).Visible = False
        DataGridView3.Columns(5).Visible = False
        DataGridView3.Columns(6).Visible = False
        DataGridView3.Columns(7).Visible = True
        DataGridView3.Columns(8).Visible = False
        DataGridView3.Columns(9).Visible = True
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TxtEm1.Text = "" Then
            BtnEdit.Enabled = False
            Btn_Delete.Enabled = False
            BttInsert.Enabled = True
        Else

            BtnEdit.Enabled = True
            Btn_Delete.Enabled = True

        End If

    End Sub
    Private Sub TxtEm1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEm1.KeyPress

        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57
                e.Handled = False
            Case 13
                Dim a As Integer = Len(TxtEm1.Text)
                If a < 13 Then
                    MessageBox.Show("กรุณาข้อมูลให้ครบ 13 ตัว", "เกิดข้อผิดพลาด")
                    TxtEm1.Focus()
                Else
                    cbbprefix.Focus()
                End If
            Case Else
                e.Handled = True
                MessageBox.Show("กรอกได้เฉพาะตัวเลข", "เกิดข้อผิดพลาด")

        End Select
    End Sub



    Private Sub Txtem5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtem5.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57
                e.Handled = False
            Case 13
                Dim a As Integer = Len(Txtem5.Text)
                If a < 10 Then
                    MessageBox.Show("กรุณาป้อนข้อมูลให้ครบ 10 ตัว", "เกิดข้อผิดพลาด")
                    Txtem5.Focus()
                Else
                    Txtem6.Focus()
                End If
            Case Else
                e.Handled = True
                MessageBox.Show("กรอกได้เฉพาะตัวเลข", "เกิดข้อผิดพลาด")

        End Select
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        sql = "UPDATE Table_Employee 
                SET id_card = @id_card,ID_prefix = @prefix,name_emp = @name,last_emp = @last,addr_emp = @addr_emp,
                tel_emp = @tel_emp,user_emp = @user_emp
                WHERE ID_EM = @idemp "
        cmd = New SqlCommand(sql, cn)
        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@id_card", TxtEm1.Text)
        cmd.Parameters.AddWithValue("@prefix", cbbprefix.SelectedValue)
        cmd.Parameters.AddWithValue("@name", TxtEm2.Text)
        cmd.Parameters.AddWithValue("@last", Txtem3.Text)
        cmd.Parameters.AddWithValue("@addr_emp", Txtem4.Text)
        cmd.Parameters.AddWithValue("@tel_emp", Txtem5.Text)
        cmd.Parameters.AddWithValue("@user_emp", Txtem6.Text)
        cmd.Parameters.AddWithValue("@idemp", TxtID.Text)

        Dim r As Integer = cmd.ExecuteNonQuery()
        If TxtEm1.TextLength < 13 Then
            MessageBox.Show("กรุณาข้อมูลให้ครบ 13 ตัว", "เกิดข้อผิดพลาด")
            TxtEm1.Focus()
            Exit Sub
        ElseIf Txtem5.TextLength <10 Then
            MessageBox.Show("กรุณาข้อมูลให้ครบ 10 ตัว", "เกิดข้อผิดพลาด")
            Txtem5.Focus()
            Exit Sub
        End If
        If r <= 0 Then
            MessageBox.Show("เกิดข้อผิดพลาดเนื่องจากยังไม่ได้บันทึก", "เกิดข้อผิดพลาด")


        Else
            MessageBox.Show("ข้อมูลได้รับการแก้ไขแล้ว")
            TxtEm1.Text = ""
            cbbprefix.SelectedValue = ""
            TxtEm2.Text = ""
            Txtem3.Text = ""
            Txtem4.Text = ""
            Txtem5.Text = ""
            Txtem6.Text = ""
            Txtem7.Text = ""
            Txtemp8.Text = ""

        End If
        refresh_employee()
        auto_Number()
    End Sub

    Private Sub BtnEdit2_Click(sender As Object, e As EventArgs) Handles BtnEdit2.Click
        sql = String.Format("update Table_Employee set class='{0}' where user_emp='{1}'", Txtclass.Text, Txtuser1.Text)
        If cmd_excuteNonQuery() = 0 Then
            MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถแก้ไขข้อมูลได้")
        Else
            MessageBox.Show("แก้ไขข้อมูลแล้ว")
        End If
        Txtclass.Text = ""
        TxtUser.Text = ""

        refresh_employee()
    End Sub


End Class


