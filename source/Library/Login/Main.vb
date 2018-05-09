' Library Management System v1.0
'
' Programmed by: Sergio Galvez (galvezsergio19@yahoo.com)
' Website: http://galvezsergio.url.ph
' 
' A simple VB.net system with MS Access DB, developed for personal
' project folio. 
' 
' Hope you'll like this .... Thanks!

Option Explicit On
Public Class Main

    Private Sub Main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        notif.Visible = False
    End Sub

    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If OK_to_CloseNow Then
            'Do anything needed before Closing is finished running.

        Else
            SelectClose(Me)
            e.Cancel() = True
            tmrFancyStuff.Enabled = True
        End If
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        FrmLogin.MdiParent = Me
        FrmLogin.StartPosition = FormStartPosition.CenterScreen
        FrmLogin.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripLabel3.Text = Date.Now.ToString("MMM-dd-yyyy")
        ToolStripLabel4.Text = TimeOfDay
    End Sub

    Private Sub ToolShutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolShutdown.Click
        End
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolHide.Click
        Me.Hide()
        notif.Visible = True
        notif.Text = "My Application is currently running!"
    End Sub

    Private Sub notif_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles notif.DoubleClick
        Me.Show()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        End
    End Sub

    Private Sub BtnMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRestore.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Public Sub BtnLibrary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLibrary.Click
        ToolApp.Visible = True
        ToolApp.Select()
        ToolApp.ToolTipText = "Library System"
        PnlDesktop.Visible = False
        Main_Library.MdiParent = Me
        Main_Library.Show()
    End Sub

    Private Sub tmrFancyStuff_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFancyStuff.Tick
        FancyCLoseTick(Me)
    End Sub

    Private Sub ToolLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolLogout.Click
        Main_Library.Close()
        Strip1.Visible = False
        Strip2.Visible = False
        PnlDesktop.Visible = False
        FrmLogin.MdiParent = Me
        FrmLogin.Show()
    End Sub
End Class