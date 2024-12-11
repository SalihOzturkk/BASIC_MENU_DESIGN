Public Class Form1

    Public Function sifre_yarat(seviye)
        Dim sifre As String = ""
        Dim rasgele As New Random
        Dim i As Integer
        Dim dizi As Char() = "QWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ".ToArray()
        For i = 1 To seviye
            sifre += dizi(rasgele.Next(dizi.Count()))

        Next
        TextBox1.Text = sifre

        Return sifre
    End Function
    Public seviye As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBox1.SelectedIndex = -1) Then
            MsgBox("LÜTFEN SEVİYE SEÇİNİZ", 0, "HATA")
            Exit Sub
        End If
        If (ComboBox1.SelectedIndex = 0) Then seviye = 6
        If (ComboBox1.SelectedIndex = 1) Then seviye = 8
        If (ComboBox1.SelectedIndex = 2) Then seviye = 12

        sifre_yarat(seviye)

    End Sub
End Class
