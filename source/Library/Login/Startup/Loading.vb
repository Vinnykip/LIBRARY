' Library Management System v1.0
'
' Programmed by: Sergio Galvez (galvezsergio19@yahoo.com)
' Website: http://galvezsergio.url.ph
' 
' A simple VB.net system with MS Access DB, developed for personal
' project folio. 
' 
' Hope you'll like this .... Thanks!

Public Class Loading

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.ProgressBar1.Value = Me.ProgressBar1.Value + 2

        If Me.ProgressBar1.Value = 100 Then
            Me.Timer1.Enabled = False
            Me.Close()
            ''FrmLoginoptions.Show()
            Main.Strip1.Visible = True
            Main.Strip2.Visible = True
            'Main.PnlDesktop.Visible = True
            Main.BtnLibrary_Click(sender, e)
        End If
    End Sub
End Class