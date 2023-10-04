Public Class Form1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim Text1, Text3 As String
        Dim Text2 As Integer
        Text1 = "Visual"
        Text2 = "22"
        Text3 = Text1 & Text2
        MsgBox(Text3)
    End Sub
End Class
