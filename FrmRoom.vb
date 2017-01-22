Imports System.Data
Imports System.Data.SqlClient
Public Class FrmRoom
    Private Sub FrmRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        sql = "SELECT * FROM Table_Prefix"
        cmd_dataTable()
        CBB_pre.DataSource = DS.Tables("table")
        CBB_pre.DisplayMember = "prefix"
        CBB_pre.ValueMember = "ID_Prefix"
        sql = "SELECT * FROM Table_StatusRoom"
        cmd_dataTable()
        CBB_Status.DataSource = DS.Tables("table")
        CBB_Status.DisplayMember = "StatusRoom"
        CBB_Status.ValueMember = "IDStatusRoom"
        sql = "SELECT * FROM Table_TypeRoom"
        cmd_dataTable()
        CBB_Type.DataSource = DS.Tables("table")
        CBB_Type.DisplayMember = "TypeRoom"
        CBB_Type.ValueMember = "IDTypeRoom"
        auto_NumberRES()
        auto_Number()

        Me.Date_cus.Value = DateTime.Now.AddDays(0)
        Me.DateRES.Value = DateTime.Now.AddDays(0)
        Me.DateIN.Value = DateTime.Now.AddDays(0)
        Call Display_Customer()
        Call Display_Room()
        Call Display_Reservation()
        refresh_Customer()
        refresh_Reservation()
        If TXT_IDC.Text = "" Or CBB_pre.Text = "" Or TXT_NameCus.Text = "" Or TXT_CusLast.Text = "" Or TXTRoom.Text = "" Or Txt_tel.Text = "" Or Txt_zip.Text = "" Then
            EditCus.Enabled = False
            Delete_cus.Enabled = False
        Else
            Addnew.Enabled = False
        End If

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

    Private Sub refresh_Customer()
        sql = "select * from Table_Customer"
    End Sub
    Private Sub Display_Customer()
        sql = "SELECT * FROM Table_Customer WHERE IDRoom =" & iSelectRoomID & ""
        cmd = New SqlCommand(sql, cn)
        cmd_dataTable()
        If DS.Tables("table").Rows.Count > 0 Then
            TxtID.Text = DS.Tables("table")(0)("IDCUS")
            TXT_IDC.Text = DS.Tables("table")(0)("id_card")
            CBB_pre.SelectedValue = DS.Tables("table")(0)("ID_prefix")
            TXT_NameCus.Text = DS.Tables("table")(0)("name_cus")
            TXT_CusLast.Text = DS.Tables("table")(0)("last_cus")
            Date_cus.Value = DS.Tables("table")(0)("brithday")
            TXT_AddrCus.Text = DS.Tables("table")(0)("addr_cus")
            Txt_zip.Text = DS.Tables("table")(0)("zip")
            Txt_tel.Text = DS.Tables("table")(0)("tel_cus")
        End If

        sql = "SELECT * FROM Table_Room WHERE IDRoom = " & iSelectRoomID & ""
        cmd = New SqlCommand(sql, cn)
        cmd_dataTable()
        If DS.Tables("table").Rows.Count > 0 Then
            TXTRoom.Text = DS.Tables("table")(0)("IDRoom")
        End If
        refresh_Customer()

    End Sub


    Private Sub refresh_Room()
        sql = "SELECT Table_Room.IDRoom,Table_Rent.IDRent,Table_StatusRoom.StatusRoom,Table_TypeRoom.TypeRoom,Table_Room.Floor
                FROM  Table_Room,Table_Rent,Table_StatusRoom,Table_TypeRoom
                where Table_Room.IDRent = Table_Rent.IDRent AND Table_Room.IDStatusRoom = Table_StatusRoom.IDStatusRoom AND Table_StatusRoom.IDTypeRoom = Table_TypeRoom.IDTypeRoom"
    End Sub



    Private Sub EditCus_Click(sender As Object, e As EventArgs) Handles EditCus.Click
        sql = "UPDATE Table_Customer 
                SET id_card = @id,ID_prefix = @prefix,name_cus = @name,last_cus = @last,brithday = @brithday,
            addr_cus = @addr,zip = @zip,tel_cus = @tel
                WHERE IDRoom = @id_room "
        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@id", TXT_IDC.Text)
        cmd.Parameters.AddWithValue("@prefix", CBB_pre.SelectedValue)
        cmd.Parameters.AddWithValue("@name", TXT_NameCus.Text)
        cmd.Parameters.AddWithValue("@last", TXT_CusLast.Text)
        cmd.Parameters.AddWithValue("@brithday", Date_cus.Value)
        cmd.Parameters.AddWithValue("@addr", TXT_AddrCus.Text)
        cmd.Parameters.AddWithValue("@zip", Txt_zip.Text)
        cmd.Parameters.AddWithValue("@tel", Txt_tel.Text)
        cmd.Parameters.AddWithValue("@id_room", TXTRoom.Text)

        If TXT_IDC.TextLength < 13 Then
            MessageBox.Show("กรุณาข้อมูลให้ครบ 13 ตัว", "เกิดข้อผิดพลาด")
            TXT_IDC.Focus()
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
        End If
        refresh_Customer()
    End Sub

    Private Sub Delete_cus_Click(sender As Object, e As EventArgs) Handles Delete_cus.Click
        Dim result As DialogResult =
            MessageBox.Show("ท่านต้องการลบข้อมูลจริงหรือไม่", "ยืนยันการลบ", MessageBoxButtons.OKCancel)
        If result = DialogResult.Cancel Then
            Exit Sub
        End If
        sql = "delete from Table_Customer where IDCUS = '" & TxtID.Text & "'"
        If cmd_excuteNonQuery() = 0 Then
            MessageBox.Show("เกิดข้อผิดพลาด")
        Else
            MessageBox.Show("ลบข้อมูลแล้ว")
        End If
        refresh_Customer()
    End Sub

    Private Sub Display_Room()
        sql = "SELECT * FROM Table_Room WHERE IDRoom =" & iSelectRoomID & ""
        cmd = New SqlCommand(sql, cn)
        cmd_dataTable()
        If DS.Tables("table").Rows.Count > 0 Then
            TXT_Room.Text = DS.Tables("table")(0)("IDRoom")
            TXT_Rent.Text = DS.Tables("table")(0)("IDRent")
            CBB_Status.SelectedValue = DS.Tables("table")(0)("IDStatusRoom")
            CBB_Type.SelectedValue = DS.Tables("table")(0)("IDTypeRoom")
            TXT_Floor.Text = DS.Tables("table")(0)("Floor")
            refresh_Room()
        End If
        refresh_Customer()
    End Sub

    Private Sub BTTSave_Room_Click(sender As Object, e As EventArgs) Handles BTTSave_Room.Click
        sql = "UPDATE Table_Room 
                SET IDRent = @rent,IDStatusRoom = @status,IDTypeRoom = @type
                WHERE IDRoom = @id_room "
        cmd.CommandText = sql
        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@rent", TXT_Rent.Text)
        cmd.Parameters.AddWithValue("@status", CBB_Status.SelectedValue)
        cmd.Parameters.AddWithValue("@type", CBB_Type.SelectedValue)
        cmd.Parameters.AddWithValue("@id_room", TXT_Room.Text)

        Dim r As Integer = cmd.ExecuteNonQuery()
        If r <= 0 Then
            MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถแก้ไขข้อมูลได้")
        Else
            MessageBox.Show("ข้อมูลได้รับการแก้ไขแล้ว")
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
                    Date_cus.Focus()
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

    Private Sub auto_Number()
        sql = "select max(auto_idcus) from Table_Customer"
        Try
            Dim numchar_id As String = "CT-" & (cmd_excuteScalar() + 1).ToString.PadLeft(5, "0")
            TxtID.Text = numchar_id
            TXT_ID.Text = cmd_excuteScalar() + 1
        Catch ex As Exception
            TxtID.Text = "CT-00001"
            TXT_ID.Text = 1
        End Try
    End Sub

    Private Sub auto_NumberRES()
        sql = "select max(auto_idres) from Table_Reservation"
        Try
            Dim numchar_id As String = "RT-" & (cmd_excuteScalar() + 1).ToString.PadLeft(5, "0")
            TXTRES.Text = numchar_id
            TXTRESe.Text = cmd_excuteScalar() + 1
        Catch ex As Exception
            TXTRES.Text = "RT-00001"
            TXTRESe.Text = 1
        End Try
    End Sub
    Private Sub Addnew_Click(sender As Object, e As EventArgs) Handles Addnew.Click
        Dim intNumRows As Integer
        sql = "SELECT COUNT(*) FROM Table_Customer WHERE id_card = '" & Me.TXT_IDC.Text & "' "
        cmd = New SqlCommand(sql, cn)
        intNumRows = cmd.ExecuteScalar() 'อ่านข้อมูลคอลัมน์แรกในตาราง
        If intNumRows > 0 Then
            MessageBox.Show("คุณกรอกข้อมูลซ้ำ")
        Else
            sql = "INSERT INTO Table_Customer(IDCUS,id_card,ID_prefix,name_cus,last_cus,brithday,
            addr_cus,zip,tel_cus,IDRoom,auto_idcus)
            VALUES(@IDCUS,@id,@prefix,@name,@last,@brithday,@addr,@zip,@tel,@IDRoom,@auto_idcus)"
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@IDCUS", TxtID.Text)
            cmd.Parameters.AddWithValue("@id", TXT_IDC.Text)
            cmd.Parameters.AddWithValue("@prefix", CBB_pre.SelectedValue)
            cmd.Parameters.AddWithValue("@name", TXT_NameCus.Text)
            cmd.Parameters.AddWithValue("@last", TXT_CusLast.Text)
            cmd.Parameters.AddWithValue("@brithday", Date_cus.Value)
            cmd.Parameters.AddWithValue("@addr", TXT_AddrCus.Text)
            cmd.Parameters.AddWithValue("@zip", Txt_zip.Text)
            cmd.Parameters.AddWithValue("@tel", Txt_tel.Text)
            cmd.Parameters.AddWithValue("@IDRoom", TXTRoom.Text)
            cmd.Parameters.AddWithValue("@auto_idcus", TXT_ID.Text)

            If TXT_IDC.Text = "" Or CBB_pre.Text = "" Or TXT_NameCus.Text = "" Or TXT_CusLast.Text = "" Or
                Date_cus.Text = "" Or TXT_AddrCus.Text = "" Or Txt_zip.Text = "" Or Txt_tel.Text = "
                " Or TXTRoom.Text = "" Then
                MessageBox.Show("คุณกรอกข้อมูลไม่ครบ")
                Exit Sub
            ElseIf TXT_IDC.TextLength < 13 Then
                MessageBox.Show("กรุณาข้อมูลให้ครบ 13 ตัว", "เกิดข้อผิดพลาด")
                TXT_IDC.Focus()
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
                MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถเพิ่มข้อมูลได้")
                Exit Sub
            Else
                MessageBox.Show("บันทึกข้อมูลแล้ว")
            End If
        End If
    End Sub

    Private Sub TXT_IDC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_IDC.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57
                e.Handled = False
            Case 13
                Dim a As Integer = Len(TXT_IDC.Text)
                If a < 13 Then
                    MessageBox.Show("กรุณาข้อมูลให้ครบ 13 ตัว", "เกิดข้อผิดพลาด")
                    TXT_IDC.Focus()
                Else
                    CBB_pre.Focus()
                End If
            Case Else
                e.Handled = True
                MessageBox.Show("กรอกได้เฉพาะตัวเลข", "เกิดข้อผิดพลาด")

        End Select
    End Sub

    Private Sub Display_Reservation()
        sql = "SELECT Table_Reservation.IDRES,Table_Customer.IDCUS,Table_Reservation.DateRes,DateIn,Deposit
                FROM  Table_Reservation,Table_Customer
                where Table_Reservation.ID_CUS = Table_Customer.IDCUS AND Table_Reservation.IDRoom =" & iSelectRoomID & ""
        cmd = New SqlCommand(sql, cn)
        cmd_dataTable()
        If DS.Tables("table").Rows.Count > 0 Then
            TXTRES.Text = DS.Tables("table")(0)("IDRES")
            TXTCUS.Text = DS.Tables("table")(0)("IDCUS")
            DateRES.Value = DS.Tables("table")(0)("DateRes")
            DateIN.Value = DS.Tables("table")(0)("DateIn")
            TXTDEP.Text = DS.Tables("table")(0)("Deposit")
        End If

        sql = "Select * FROM Table_Room WHERE IDRoom = " & iSelectRoomID & ""
        cmd = New SqlCommand(sql, cn)
        cmd_dataTable()
        If DS.Tables("table").Rows.Count > 0 Then
            TXTROOMr.Text = DS.Tables("table")(0)("IDRoom")
        End If
        refresh_Reservation()

    End Sub
    Private Sub refresh_Reservation()
        sql = "Select Table_Reservation.IDRES,Table_Customer.name_cus,Table_Reservation.DateRes,DateIn,Deposit
                From Table_Reservation, Table_Customer
                Where Table_Reservation.ID_CUS = Table_Customer.IDCUS "
    End Sub

    Private Sub BTNRES_Click(sender As Object, e As EventArgs) Handles BTNRES.Click
        Dim intNumRows As Integer
        sql = "SELECT COUNT(*) FROM Table_Reservation WHERE IDRES = '" & Me.TXTRES.Text & "' "
        cmd = New SqlCommand(sql, cn)
        intNumRows = cmd.ExecuteScalar() 'อ่านข้อมูลคอลัมน์แรกในตาราง
        If intNumRows > 0 Then
            MessageBox.Show("คุณกรอกข้อมูลซ้ำ")
        Else
            sql = "INSERT INTO Table_Reservation(IDRES,ID_CUS,IDRoom,DateRes,DateIn,Deposit,auto_idres)
            VALUES(@IDCUS,@IDRES,@IDRoom,@DateRes,@DateIn,@Deposit,@auto_idres)"
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@IDRES", TXTRES.Text)
            cmd.Parameters.AddWithValue("@IDCUS", TXTCUS.Text)
            cmd.Parameters.AddWithValue("@IDRoom", TXTROOMr.Text)
            cmd.Parameters.AddWithValue("@DateRes", DateRES.Value)
            cmd.Parameters.AddWithValue("@DateIn", DateIN.Value)
            cmd.Parameters.AddWithValue("@Deposit", TXTDEP.Text)
            cmd.Parameters.AddWithValue("@auto_idres", TXTRESe.Text)
            If TXTCUS.Text = "" Or TXTDEP.Text = "" Then
                MessageBox.Show("คุณกรอกข้อมูลไม่ครบ")
                Exit Sub
            ElseIf TXTDEP.Text < 1000 Then
                MessageBox.Show("ต้องชำระค่ามัดจำอย่างน้อย 1,000 บาท ", "เกิดข้อผิดพลาด")
                Exit Sub
            End If
            Dim r As Integer = cmd.ExecuteNonQuery()
            If r <= 0 Then
                MessageBox.Show("ไม่สามารถเพิ่มข้อมูลได้", "เกิดข้อผิดพลาด")
                Exit Sub
            Else
                MessageBox.Show("บันทึกข้อมูลแล้ว")
            End If
        End If
    End Sub


    Private Sub TXTDEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTDEP.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57
                e.Handled = False
            Case 13
                Dim a As Integer = Len(TXT_IDC.Text)
                If a < 3 Then
                    MessageBox.Show("ต้องชำระค่ามัดจำอย่างน้อย 1,000 บาท", "เกิดข้อผิดพลาด")
                    TXTDEP.Focus()
                Else
                    DateIN.Focus()
                End If
            Case Else
                e.Handled = True
                MessageBox.Show("กรอกได้เฉพาะตัวเลข", "เกิดข้อผิดพลาด")

        End Select
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        sql = "UPDATE Table_Reservation 
                SET ID_CUS = @ID_CUS,DateRES = @DateRES,DateIN = @DateIN,Deposit = @Deposit
                WHERE IDRES = @IDRES "
        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@IDRES", TXTRES.Text)
        cmd.Parameters.AddWithValue("@ID_CUS", TXTCUS.Text)
        cmd.Parameters.AddWithValue("@DateRes", DateRES.Value)
        cmd.Parameters.AddWithValue("@DateIn", DateIN.Value)
        cmd.Parameters.AddWithValue("@Deposit", TXTDEP.Text)
        If TXTCUS.Text = "" Or TXTDEP.Text = "" Then
            MessageBox.Show("คุณกรอกข้อมูลไม่ครบ")
            Exit Sub
        ElseIf TXTDEP.Text < 1000 Then
            MessageBox.Show("ต้องชำระค่ามัดจำอย่างน้อย 1,000 บาท ", "เกิดข้อผิดพลาด")
            Exit Sub
        End If
        Dim r As Integer = cmd.ExecuteNonQuery()
        If r <= 0 Then
            MessageBox.Show("ไม่สามารถแก้ไขข้อมูลได้", "เกิดข้อผิดพลาด")
        Else
            MessageBox.Show("ข้อมูลได้รับการแก้ไขแล้ว")
        End If
    End Sub
End Class