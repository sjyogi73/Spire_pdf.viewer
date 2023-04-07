<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Document
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PdfDocumentViewer1 = New Spire.PdfViewer.Forms.PdfDocumentViewer()
        Me.PdfViewer1 = New Spire.PdfViewer.Forms.PdfViewer()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'PdfDocumentViewer1
        '
        Me.PdfDocumentViewer1.AutoScroll = True
        Me.PdfDocumentViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.PdfDocumentViewer1.FormFillEnabled = False
        Me.PdfDocumentViewer1.Location = New System.Drawing.Point(0, 0)
        Me.PdfDocumentViewer1.MultiPagesThreshold = 60
        Me.PdfDocumentViewer1.Name = "PdfDocumentViewer1"
        Me.PdfDocumentViewer1.OnRenderPageExceptionEvent = Nothing
        Me.PdfDocumentViewer1.PageLayoutMode = Spire.PdfViewer.Forms.PageLayoutMode.SinglePageContinuous
        Me.PdfDocumentViewer1.Size = New System.Drawing.Size(740, 389)
        Me.PdfDocumentViewer1.TabIndex = 0
        Me.PdfDocumentViewer1.Text = "PdfDocumentViewer1"
        Me.PdfDocumentViewer1.Threshold = 60
        Me.PdfDocumentViewer1.ViewerMode = Spire.PdfViewer.Forms.PdfViewerMode.PdfViewerMode.MultiPage
        Me.PdfDocumentViewer1.ZoomFactor = 1.0!
        Me.PdfDocumentViewer1.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.[Default]
        '
        'PdfViewer1
        '
        Me.PdfViewer1.FindTextHighLightColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.PdfViewer1.FormFillEnabled = False
        Me.PdfViewer1.IgnoreCase = False
        Me.PdfViewer1.IsToolBarVisible = True
        Me.PdfViewer1.Location = New System.Drawing.Point(0, 0)
        Me.PdfViewer1.MultiPagesThreshold = 60
        Me.PdfViewer1.Name = "PdfViewer1"
        Me.PdfViewer1.OnRenderPageExceptionEvent = Nothing
        Me.PdfViewer1.Size = New System.Drawing.Size(798, 438)
        Me.PdfViewer1.TabIndex = 1
        Me.PdfViewer1.Text = "PdfViewer1"
        Me.PdfViewer1.Threshold = 60
        Me.PdfViewer1.ViewerBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Document
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PdfViewer1)
        Me.Controls.Add(Me.PdfDocumentViewer1)
        Me.Name = "Document"
        Me.Text = "Document"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PdfDocumentViewer1 As Spire.PdfViewer.Forms.PdfDocumentViewer
    Friend WithEvents PdfViewer1 As Spire.PdfViewer.Forms.PdfViewer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
