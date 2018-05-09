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
Imports System.Data.OleDb
Public Class FrmLogin

    'FORM CLOSE and MINIMIZE BUTTON
    Private Sub PictureBox1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.MouseHover
        Btnclose.BackColor = Color.Gray
    End Sub

    Private Sub Btnclose_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.MouseLeave
        Btnclose.BackColor = Color.Black
    End Sub

    Private Sub Btnmin_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmin.MouseHover
        Btnmin.BackColor = Color.Gray
    End Sub

    Private Sub Btnmin_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmin.MouseLeave
        Btnmin.BackColor = Color.Black
    End Sub

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        End
    End Sub

    Private Sub Btnmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txttitle.HeaderText = "Login"
        Me.Text = "Login"
        loginimage.Image = Login.My.Resources.Resources.admin
        Txtuser.Clear()
        txtpass.Clear()
        txtuserid.Clear()
    End Sub

    Private Sub CloudButton1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BtnLogin.BackColor = Color.Black
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        End
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        Dim cn As New OleDbConnection("Provider = Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Dbase\LibraryDB.accdb")
        cn.Open()

        If txtuserid.Text = "" Or Txtuser.Text = "" Or txtpass.Text = "" Then
            MessageBox.Show("Please fill out all the fields", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
                Dim dr As OleDbDataReader
                Dim cmd As New OleDbCommand
            cmd.CommandText = "SELECT [Uname], [Pword] FROM users Where AccntNo= '" & txtuserid.Text & "' "
                cmd.Connection = cn

                If cn.State = ConnectionState.Closed Then cn.Open()
                dr = cmd.ExecuteReader

                If dr.Read Then
                    If UCase(dr(1)) = UCase(txtpass.Text) And UCase(dr(0)) = UCase(Txtuser.Text) Then
                        Main.ToolUname.Text = Txtuser.Text
                        Main.ToolRole.Text = "Administrator"
                        Me.Close()
                        Loading.MdiParent = Main
                        Loading.Show()
                    Else
                        MessageBox.Show("Wrong Username or Password Entered. Please make sure you typed the correct credentials for your account.", "User Fields Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Wrong Account Number or Access. Please re-type your account number and make sure you have the correct account access.", "Äccount Access Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
        End If
    End Sub

    Private Sub LnkNew_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkNew.LinkClicked
        If InputBox("Enter Universal Administrator Password", "Administrator Password", "Default Password") = "p@ssw0rd" Then
            Dim obj As New FrmNewUser
            obj.MdiParent = Main
            obj.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Administrator Password")
        End If
    End Sub

    Private Sub toollogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toollogin.Click
        txtuserid.Text = "11-0129"
        Txtuser.Text = "sergio"
        txtpass.Text = "sergio"
        BtnLogin_Click(sender, e)
    End Sub
End Class