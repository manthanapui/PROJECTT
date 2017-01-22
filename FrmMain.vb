
Public Class FrmMain


    Private Sub TSEmployee_Click(sender As Object, e As EventArgs) Handles TSEmployee.Click
        Dim mdiform As New FrmEmployee
        mdiform.MdiParent = Me
        mdiform.Show()
    End Sub

    Private Sub TStoRoom_Click(sender As Object, e As EventArgs) Handles TStoRoom.Click
        Dim mdiform As New FrmDetailRoom
        mdiform.MdiParent = Me
        mdiform.Show()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TSCustomer_Click(sender As Object, e As EventArgs) Handles TSCustomer.Click
        Dim mdiform As New FrmCustomer
        mdiform.MdiParent = Me
        mdiform.Show()
    End Sub

    Private Sub TSToPrefix_Click(sender As Object, e As EventArgs) Handles TSToPrefix.Click
        Dim mdiform As New FrmPrefix
        mdiform.MdiParent = Me
        mdiform.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim mbr As MsgBoxResult
        mbr = MsgBox("คุณต้องการ Logout ใช่หรือไม่ ?",
        MsgBoxStyle.OkCancel +
        MsgBoxStyle.Question +
        MsgBoxStyle.ApplicationModal,
        "ออกจากโปรแกรม")
        If (mbr = MsgBoxResult.Ok) Then
            Me.Close()

        End If
    End Sub

    Private Sub TSToPass_Click(sender As Object, e As EventArgs) Handles TSToPass.Click
        Dim mdiform As New FrmEmployee

        mdiform.MdiParent = Me
        mdiform.Show()
    End Sub
End Class
