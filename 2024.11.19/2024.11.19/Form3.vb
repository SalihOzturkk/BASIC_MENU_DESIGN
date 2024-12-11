Public Class Form3

    Private Sub ExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelToolStripMenuItem.Click

    End Sub

    Private Sub FarklıKaydetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FarklıKaydetToolStripMenuItem.Click
        MsgBox("İsmail Zorman")
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyData = Keys.F5) Then
            MsgBox("Ben - Sen - O")
        End If
        If (e.KeyData = Keys.F1) Then
            MsgBox("sa")

        End If
        If (e.KeyData = Keys.F2) Then
            MsgBox("as")

        End If


    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.SelectedItem = True

    End Sub
End Class