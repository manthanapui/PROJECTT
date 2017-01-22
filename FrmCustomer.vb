Imports System.Data
Imports System.Data.SqlClient
Public Class FrmCustomer
    Private Sub FrmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        sql = "SELECT * FROM Table_Prefix"
        cmd_dataTable()
        cbb1.DataSource = DS.Tables("table")
        cbb1.DisplayMember = "prefix"
        cbb1.ValueMember = "ID_Prefix"
        refresh_Customer()
        Me.DateCus.Value = DateTime.Now.AddDays(0)

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

        With DataGrideCus
            .Columns(0).HeaderText = "รหัสลูกค้า"
            .Columns(1).HeaderText = "เลขประจำตัวประชาชน"
            .Columns(2).HeaderText = "คำนำหน้านาม"
            .Columns(3).HeaderText = "ชื่อ"
            .Columns(4).HeaderText = "นามสกุล"
            .Columns(5).HeaderText = "วันเดือนปีเกิด"
            .Columns(6).HeaderText = "ที่อยู่"
            .Columns(7).HeaderText = "รหัสไปรษณีย์"
            .Columns(8).HeaderText = "เบอร์โทรศัพท์"
            .Columns(9).HeaderText = "ห้อง"
            DataGrideCus.Columns(9).Visible = False

            .Columns(0).Width = 100
            .Columns(1).Width = 180
            .Columns(2).Width = 120
            .Columns(3).Width = 100
            .Columns(4).Width = 100
            .Columns(5).Width = 120
            .Columns(6).Width = 250
            .Columns(7).Width = 120
            .Columns(8).Width = 120



        End With
    End Sub


    Private Sub refresh_Customer()
        sql = "SELECT Table_Customer.IDCUS,id_card,Table_Prefix.prefix,Table_Customer.name_cus,last_cus,brithday,
                addr_cus,zip,tel_cus,IDRoom
                FROM  Table_Customer,Table_Prefix
                where Table_Customer.ID_prefix = Table_Prefix.ID_prefix"
        DataGrideCus.DataSource = cmd_dataTable()
        formatGrid()

    End Sub


    Private Sub Addnew_Click_1(sender As Object, e As EventArgs)
        Dim intNumRows As Integer
        sql = "SELECT COUNT(*) FROM Table_Customer WHERE id_card = '" & Me.Txt_cus.Text & "' "
        cmd = New SqlCommand(sql, cn)
        intNumRows = cmd.ExecuteScalar() 'อ่านข้อมูลคอลัมน์แรกในตาราง
        If intNumRows > 0 Then
            MessageBox.Show("คุณกรอกข้อมูลซ้ำ")
        Else
            sql = "INSERT INTO Table_Customer(id_customer,prefix,name_cus,last_cus,brithday,
            addr_cus,zip,tel_cus,id_room)
            VALUES(@id,@prefix,@name,@last,@brithday,@addr,@zip,@tel,@id_room)"
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", Txt_cus.Text)
            cmd.Parameters.AddWithValue("@prefix", cbb1.Text)
            cmd.Parameters.AddWithValue("@name", Txt_name.Text)
            cmd.Parameters.AddWithValue("@last", Txt_last.Text)
            cmd.Parameters.AddWithValue("@brithday", DateCus.Value)
            cmd.Parameters.AddWithValue("@addr", Txt_addr.Text)
            cmd.Parameters.AddWithValue("@zip", Txt_zip.Text)
            cmd.Parameters.AddWithValue("@tel", Txt_tel.Text)


            If Txt_cus.Text = "" Or cbb1.Text = "" Or Txt_name.Text = "" Or Txt_last.Text = "" Or
                DateCus.Text = "" Or Txt_addr.Text = "" Or Txt_zip.Text = "" Or Txt_tel.Text = "
               " Then
                MessageBox.Show("คุณกรอกข้อมูลไม่ครบ")
            Else

                Dim r As Integer = cmd.ExecuteNonQuery()
                If r = -1 Then
                    MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถเพิ่มข้อมูลได้")
                Else
                    MessageBox.Show("บันทึกข้อมูลแล้ว")
                End If
            End If
        End If
        refresh_Customer()

    End Sub





    Private Sub Txt_cus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_cus.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57
                e.Handled = False
            Case 13
                Dim a As Integer = Len(Txt_cus.Text)
                If a < 13 Then
                    MessageBox.Show("กรุณาข้อมูลให้ครบ 13 ตัว", "เกิดข้อผิดพลาด")
                    Txt_cus.Focus()
                Else
                    cbb1.Focus()
                End If
            Case Else
                e.Handled = True
                MessageBox.Show("กรอกได้เฉพาะตัวเลข", "เกิดข้อผิดพลาด")

        End Select
    End Sub

    Private Sub Txt_zip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_zip.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57
                e.Handled = False
            Case 13
                Dim a As Integer = Len(Txt_zip.Text)
                If a < 5 Then
                    MessageBox.Show("กรุณาข้อมูลให้ครบ 5 ตัว", "เกิดข้อผิดพลาด")
                    Txt_zip.Focus()
                Else
                    Txt_tel.Focus()
                End If
            Case Else
                e.Handled = True
                MessageBox.Show("กรอกได้เฉพาะตัวเลข", "เกิดข้อผิดพลาด")

        End Select
    End Sub





    Private Sub DataGrideCus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrideCus.CellContentClick
        Dim i As Integer = DataGrideCus.CurrentRow.Index
        TxtID.Text = DataGrideCus.Item(0, i).Value
        Txt_cus.Text = DataGrideCus.Item(1, i).Value
        cbb1.Text = DataGrideCus.Item(2, i).Value
        Txt_name.Text = DataGrideCus.Item(3, i).Value
        Txt_last.Text = DataGrideCus.Item(4, i).Value
        DateCus.Text = DataGrideCus.Item(5, i).Value
        Txt_addr.Text = DataGrideCus.Item(6, i).Value
        Txt_zip.Text = DataGrideCus.Item(7, i).Value
        Txt_tel.Text = DataGrideCus.Item(8, i).Value
        TxtRoom.Text = DataGrideCus.Item(9, i).Value
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        sql = "UPDATE Table_Customer 
                SET id_card = @id,ID_prefix = @prefix,name_cus = @name,last_cus = @last,brithday = @brithday,
                addr_cus = @addr,zip = @zip,tel_cus = @tel,IDRoom = @id_room 
                WHERE @idcus = IDCUS"
        cmd = New SqlCommand(sql, cn)
        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@idcus", TxtID.Text)
        cmd.Parameters.AddWithValue("@id", Txt_cus.Text)
        cmd.Parameters.AddWithValue("@prefix", cbb1.SelectedValue)
        cmd.Parameters.AddWithValue("@name", Txt_name.Text)
        cmd.Parameters.AddWithValue("@last", Txt_last.Text)
        cmd.Parameters.AddWithValue("@brithday", DateCus.Value)
        cmd.Parameters.AddWithValue("@addr", Txt_addr.Text)
        cmd.Parameters.AddWithValue("@zip", Txt_zip.Text)
        cmd.Parameters.AddWithValue("@tel", Txt_tel.Text)
        cmd.Parameters.AddWithValue("@id_room", TxtRoom.Text)


        If Txt_cus.TextLength < 13 Then
            MessageBox.Show("กรุณาข้อมูลให้ครบ 13 ตัว", "เกิดข้อผิดพลาด")
            Txt_cus.Focus()
            Exit Sub
        ElseIf Txt_zip.TextLength < 5 Then
            MessageBox.Show("กรุณาข้อมูลให้ครบ 5 ตัว", "เกิดข้อผิดพลาด")
            Txt_zip.Focus()
            Exit Sub
        ElseIf Txt_tel.TextLength < 10 Then
            MessageBox.Show("กรุณาข้อมูลให้ครบ 10 ตัว", "เกิดข้อผิดพลาด")
            Txt_tel.Focus()
            Exit Sub
        End If

        Dim r As Integer = cmd.ExecuteNonQuery()
        If r <= 0 Then
            MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถแก้ไขข้อมูลได้")
        Else
            MessageBox.Show("ข้อมูลได้รับการแก้ไขแล้ว")
            TxtID.Text = ""
            Txt_cus.Text = ""
            cbb1.SelectedValue = ""
            Txt_name.Text = ""
            Txt_last.Text = ""
            DateCus.Text = ""
            Txt_addr.Text = ""
            Txt_zip.Text = ""
            Txt_tel.Text = ""
            TxtRoom.Text = ""
        End If
        refresh_Customer()
    End Sub

    Private Sub BttOK_Click(sender As Object, e As EventArgs) Handles BttOK.Click
        sql = String.Format("SELECT Table_Customer.IDCUS,id_card,Table_Prefix.prefix,Table_Customer.name_cus,last_cus,brithday,
                addr_cus,zip,tel_cus,IDRoom,IDCUS FROM Table_Customer,Table_Prefix WHERE Table_Customer.ID_prefix = Table_Prefix.ID_prefix AND name_cus LIKE '{0}'", TextSearch.Text)
        DataGrideCus.DataSource = cmd_dataTable()
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Dim result As DialogResult =
          MessageBox.Show("ท่านต้องการลบข้อมูลจริงหรือไม่", "ยืนยันการลบ", MessageBoxButtons.OKCancel)
        If result = DialogResult.Cancel Then
            Exit Sub
        End If
        sql = "delete from Table_Customer where id_card = '" & Txt_cus.Text & "'"
        If cmd_excuteNonQuery() = 0 Then
            MessageBox.Show("เกิดข้อผิดพลาด")
        Else
            MessageBox.Show("ลบข้อมูลแล้ว")
        End If
        refresh_Customer()
    End Sub

    Private Sub Txt_tel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_tel.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57
                e.Handled = False
            Case 13
                Dim a As Integer = Len(Txt_tel.Text)
                If a < 10 Then
                    MessageBox.Show("กรุณาข้อมูลให้ครบ 10 ตัว", "เกิดข้อผิดพลาด")
                    Txt_tel.Focus()
                Else
                    DateCus.Focus()
                End If
            Case Else
                e.Handled = True
                MessageBox.Show("กรอกได้เฉพาะตัวเลข", "เกิดข้อผิดพลาด")

        End Select
    End Sub
End Class