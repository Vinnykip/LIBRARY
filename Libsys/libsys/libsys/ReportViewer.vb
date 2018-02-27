
Namespace Microsoft.Reporting.WinForms
    Class ReportViewer

        Friend Cursor As Cursor
        Friend Location As Point
        Friend Size As Size
        Friend TabIndex As Integer
        Friend Value As BindingSource
        Friend Margin As Padding

        Property LocalReport As Object

        Property Name As String

        Sub RefreshReport()
            Throw New NotImplementedException
        End Sub

    End Class
End Namespace
