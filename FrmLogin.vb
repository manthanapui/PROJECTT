Public Class FrmLogin
    Private Sub Cancel1_Click(sender As Object, e As EventArgs) Handles Cancel1.Click
        Dim mbr As MsgBoxResult
        mbr = MsgBox("ออกจากโปรแกรมหรือไม่?",
        MsgBoxStyle.OkCancel +
        MsgBoxStyle.Question +
        MsgBoxStyle.ApplicationModal,
        "ออกจากโปรแกรม")
        If (mbr = MsgBoxResult.Ok) Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If TextBox14.Text = "" Or TextBox1.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "เกิดข้อผิดพลาด")
            Return
        End If
        sql = "SELECT * FROM Table_Employee WHERE user_emp ='" & TextBox14.Text & "'AND pass_emp ='" & TextBox1.Text & "'"
        cmd_dataTable()
        If DS.Tables("table").Rows.Count <= 0 Then
            MessageBox.Show("คุณกรอก Username หรือ Password ไม่ถูกต้อง", "เกิดข้อผิดพลาด")
            TextBox1.Text = ""
            TextBox14.Text = ""
        Else
            If DS.Tables("table").Rows(0)("class") = "Admin" Then
                FrmEmployee.Enabled = True
            Else
                FrmEmployee.Enabled = False


                TextBox1.Text = ""
                TextBox14.Text = ""

            End If
        End If
        FrmMain.Show()


    End Sub



End Class