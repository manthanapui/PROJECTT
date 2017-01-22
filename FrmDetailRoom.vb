Imports System.Data
Imports System.Data.SqlClient
Public Class FrmDetailRoom

    Private Sub lblRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim lbl As Label = CType(sender, Label)
        txtFloorID.Text = Mid(lbl.Tag, 1, 1) : iSelectFloorID = txtFloorID.Text
        txtRoomID.Text = lbl.Tag : iSelectRoomID = lbl.Tag
        FrmRoom.Show()
    End Sub
    Private Sub btnStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btn As Button = CType(sender, Button)
        txtStatus.Text = btn.Tag
    End Sub


    Private Sub Display_GroupBox1()
        Dim iTempRoomID As Integer = 0
        For Each ctrl As Object In GroupBox1.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl As Label = CType(ctrl, Label)
                iTempRoomID = CInt(lbl.Tag)
                sql = "SELECT * FROM Table_Room WHERE IDRoom =" & iTempRoomID
                cmd = New SqlCommand(sql, cn)
                cmd_dataTable()

                If DS.Tables("table").Rows.Count > 0 Then
                    AddHandler lbl.Click, AddressOf lblRoom_Click
                    lbl.Text = DS.Tables("table")(0)("IDRoom")
                    Select Case DS.Tables("table")(0)("IDStatusRoom")
                        Case 1             ' จอง
                            lbl.Image = ImageList1.Images.Item("b3.png")
                            lbl.BackColor = Color.FromName("YELLOW")
                        Case 2             'เต็ม
                            lbl.Image = ImageList1.Images.Item("b2.png")
                            lbl.BackColor = Color.FromName("Lime")
                        Case Else       ' ว่าง
                            lbl.Image = ImageList1.Images.Item("b1.png")
                            lbl.BackColor = Color.FromName("LightCoral")
                    End Select
                End If
            End If
        Next ctrl
    End Sub
    Private Sub refresh_Room()
        sql = "select * from Table_Room"
    End Sub
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each btn As Button In FlowLayoutPanel1.Controls
            AddHandler btn.Click, AddressOf btnStatus_Click
        Next

        Call Display_GroupBox1()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Display_GroupBox1()
    End Sub
End Class