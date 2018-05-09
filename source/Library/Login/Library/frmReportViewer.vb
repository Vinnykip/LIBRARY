' Library Management System v1.0
'
' Programmed by: Sergio Galvez (galvezsergio19@yahoo.com)
' Website: http://galvezsergio.url.ph
' 
' A simple VB.net system with MS Access DB, developed for personal
' project folio. 
' 
' Hope you'll like this .... Thanks!

Public Class frmReportViewer
    Private pDataset As DataSet
    Private pReportPath As String
    Private pReportTitle As String

    Public Property ReportDataSet As DataSet
        Get
            Return pDataset
        End Get
        Set(ByVal value As DataSet)
            pDataset = value
        End Set
    End Property
    Public Property ReportPath As String
        Get
            Return pReportPath
        End Get
        Set(ByVal value As String)
            pReportPath = value
        End Set
    End Property
    Public Property ReportTitle As String
        Get
            Return pReportTitle
        End Get
        Set(ByVal value As String)
            pReportTitle = value
        End Set
    End Property

    Private Sub frmReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PrintPreview()
    End Sub
    Public Sub PrintPreview()
        Dim rptDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
        'Dim lCRViewerForm As ReportViewer = Nothing
        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            If rptDocument Is Nothing Then
                rptDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            End If

            'If lCRViewerForm Is Nothing Then
            '    lCRViewerForm = New ReportViewer
            'End If

            'If Not IO.File.Exists(pReportPath) Then
            '    Throw (New Exception("Unable to locate report file:" & _
            '        vbCrLf & pReportPath))
            '    Exit Sub
            'End If
            If Microsoft.VisualBasic.Right(pReportPath, 1) = "\" Then
                pReportPath = pReportPath & GetReportFileName()
            Else
                pReportPath = pReportPath & "\" & GetReportFileName()
            End If

            rptDocument.Load(pReportPath)
            rptDocument.SetDataSource(pDataset.Tables(0))

            CrystalReportViewer1.ReportSource = rptDocument


            'lCRViewerForm.Text = pReportTitle
            'lCRViewerForm.ShowDialog()
            'rptDocument.Dispose()
            'lCRViewerForm = Nothing

        Catch ex As Exception
            MessageBox.Show("mod_generic - PrintPreview" & ControlChars.NewLine & ex.Message.ToString())
            Exit Sub
        Finally

        End Try
    End Sub
    Function GetReportFileName() As String
        Dim sRptFileName As String = String.Empty

        Select Case pReportTitle
            Case "List of Books"
                sRptFileName = "ListOfBooks.rpt"
        End Select
        Return sRptFileName
    End Function
End Class