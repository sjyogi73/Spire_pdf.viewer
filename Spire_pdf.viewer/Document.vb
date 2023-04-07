Imports Spire.License.LicenseProvider

Public Class Document
    Private Sub Document_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' PdfViewer1.LoadFromFile("..\..\..\Reference\sample.pdf")
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PdfViewer1.LoadFromFile(OpenFileDialog1.FileName)
        End If
    End Sub
End Class