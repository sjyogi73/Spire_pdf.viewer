﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Viewer
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()

        'Initialize Spire License Key
        'Spire.License.LicenseProvider.SetLicenseFile(licenseFile)

        Spire.License.LicenseProvider.SetLicenseKey(key)

        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PdfViewer1 = New Spire.PdfViewer.Forms.PdfViewer()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.PdfViewer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1220, 670)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1009, 52)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(9, 10)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PdfViewer1
        '
        Me.PdfViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PdfViewer1.FindTextHighLightColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.PdfViewer1.FormFillEnabled = False
        Me.PdfViewer1.IgnoreCase = False
        Me.PdfViewer1.IsToolBarVisible = True
        Me.PdfViewer1.Location = New System.Drawing.Point(0, 4)
        Me.PdfViewer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PdfViewer1.MultiPagesThreshold = 60
        Me.PdfViewer1.Name = "PdfViewer1"
        Me.PdfViewer1.OnRenderPageExceptionEvent = Nothing
        Me.PdfViewer1.Size = New System.Drawing.Size(1216, 662)
        Me.PdfViewer1.TabIndex = 0
        Me.PdfViewer1.Text = "PdfViewer1"
        Me.PdfViewer1.Threshold = 60
        Me.PdfViewer1.ViewerBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1220, 670)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Viewer"
        Me.Text = "Spire License Evaluation"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PdfViewer1 As Spire.PdfViewer.Forms.PdfViewer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
End Class
