Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fileName As String = "\test.jpg"
        Dim fi As New System.IO.FileInfo(Application.StartupPath + fileName)
        Dim copyFile As System.IO.FileInfo = fi.CopyTo("d:\testFolder" + fileName)
    End Sub
End Class
