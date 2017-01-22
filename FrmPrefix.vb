Imports System.Data
Imports System.Data.SqlClient
Public Class FrmPrefix
    Public Sub formatGrid()

        With DataGridView1

            .Columns(0).HeaderText = "รหัสคำนำหน้านาม"
            .Columns(1).HeaderText = "คำนำหน้านาม"
            .Columns(0).Width = 140
            .Columns(1).Width = 135
            DataGridView1.Columns(2).Visible = False



        End With
    End Sub

    Private Sub auto_Number()
        sql = "select max(auto_id) from Table_Prefix"
        Try
            Dim numchar_id As String = "PF-" & (cmd_excuteScalar() + 1).ToString.PadLeft(3, "0")
            TxtID.Text = numchar_id
            txt_id.Text = cmd_excuteScalar() + 1
        Catch ex As Exception
            TxtID.Text = "PF-001"
            txt_id.Text = 1
        End Try
    End Sub
    Private Sub FrmPrefix_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_Profix()
        auto_Number()
    End Sub
    Private Sub refresh_Profix()
        sql = "select * from Table_Prefix"
        DataGridView1.DataSource = cmd_dataTable()
        formatGrid()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer = DataGridView1.CurrentRow.Index
        TxtID.Text = DataGridView1.Item(0, i).Value
        TxtProfix.Text = DataGridView1.Item(1, i).Value
        DataGridView1.Columns(0).Visible = True
        DataGridView1.Columns(1).Visible = True
        DataGridView1.Columns(2).Visible = False


    End Sub
    Private Sub BttInsert_Click(sender As Object, e As EventArgs) Handles BttInsert.Click

        sql = "INSERT INTO Table_Prefix(ID_prefix,prefix,auto_id)
        VALUES(@ID_prefix,@prefix,@auto_id)"
        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@ID_prefix", TxtID.Text)
        cmd.Parameters.AddWithValue("@prefix", TxtProfix.Text)
        cmd.Parameters.AddWithValue("@auto_id", txt_id.Text)


        If TxtProfix.Text = "" Then
            MessageBox.Show("คุณยังไม่ได้กรอกข้อมูล")
        Else
            Dim r As Integer = cmd.ExecuteNonQuery()
            If r <= 0 Then
                MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถเพิ่มข้อมูลได้")
                Exit Sub
            Else
                MessageBox.Show("บันทึกข้อมูลแล้ว")
            End If
        End If
        refresh_Profix()
            TxtID.Text = ""
        TxtProfix.Text = ""
        auto_Number()
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        sql = String.Format("update Table_Prefix set prefix='{0}' where ID_prefix='{1}'", TxtProfix.Text, TxtID.Text)
        If cmd_excuteNonQuery() = 0 Then
            MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถแก้ไขข้อมูลได้")
        Else
            MessageBox.Show("แก้ไขข้อมูลแล้ว")
        End If
        refresh_Profix()
        TxtID.Text = ""
        TxtProfix.Text = ""
        auto_Number()
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Dim result As DialogResult =
            MessageBox.Show("ท่านต้องการลบข้อมูลจริงหรือไม่", "ยืนยันการลบ", MessageBoxButtons.OKCancel)
        If result = DialogResult.Cancel Then
            Exit Sub
        End If
        sql = "delete from Table_Prefix where ID_Prefix = '" & TxtID.Text & "'"
        If cmd_excuteNonQuery() = 0 Then
            MessageBox.Show("เกิดข้อผิดพลาด")
        Else
            MessageBox.Show("ลบข้อมูลแล้ว")
        End If
        refresh_Profix()
        TxtID.Text = ""
        TxtProfix.Text = ""
        auto_Number()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs)
        TxtID.Text = ""
        TxtProfix.Text = ""
    End Sub
End Class