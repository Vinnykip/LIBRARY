' Library Management System v1.0
'
' Programmed by: Sergio Galvez (galvezsergio19@yahoo.com)
' Website: http://galvezsergio.url.ph
' 
' A simple VB.net system with MS Access DB, developed for personal
' project folio. 
' 
' Hope you'll like this .... Thanks!

Imports System.Data.OleDb
Public Class FrmNewUser

    Dim bytImage() As Byte
    Dim cn As New OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Dbase\LibraryDB.accdb;")
    Dim sql As String
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader

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
        Me.Close()
        FrmLogin.MdiParent = Main
        FrmLogin.Show()
    End Sub

    Private Sub Btnmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'FUNCTIONS

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        If BtnCancel.ButtonText = "Cancel" Then
            Me.Close()
            FrmLogin.MdiParent = Main
            FrmLogin.Show()
        ElseIf BtnCancel.ButtonText = "Close" Then
            Me.Close()
        Else

        End If
    End Sub

    Private Sub Btncreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncreate.Click

        If Btncreate.ButtonText = "Create" Then
            If txtaaccntno.Text = "" Or txtemail.Text = "" Or txtname.Text = "" Or txtuname.Text = "" Or txtpassword.Text = "" Or txtConformPass.Text = "" Then
                MessageBox.Show("All Fields are Required. Please fill up all the fields to create an entry for the new user", "Form Fields Required", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                If txtpassword.TextLength <= 5 Then
                    MessageBox.Show("The  Password Should be of Atleast 5 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtpassword.Focus()
                Else

                    If txtpassword.Text = txtConformPass.Text Then
                        If cn.State = ConnectionState.Closed Then cn.Open()
                        Dim sql As String = "INSERT INTO users(AccntNo, Uname, Pword, Fname, Email, Myimage) VALUES(@accntno, @uname, @pword, @Fname, @EmailAdd, @myimage)"
                        Dim cmd As OleDbCommand = New OleDbCommand(sql, cn)


                        ' Account Access
                        'Dim accntaccess As OleDbParameter = New OleDbParameter("@accntaccess", OleDbType.VarWChar, 50)
                        'accntaccess.Value = txtaccntaccess.Text.ToString()
                        'cmd.Parameters.Add(accntaccess)
                        'Account Number
                        Dim accntno As OleDbParameter = New OleDbParameter("@accntno", OleDbType.VarWChar, 50)
                        accntno.Value = txtaaccntno.Text.ToString()
                        cmd.Parameters.Add(accntno)
                        'Username
                        Dim Uname As OleDbParameter = New OleDbParameter("@Uname", OleDbType.VarWChar, 50)
                        Uname.Value = txtuname.Text.ToString()
                        cmd.Parameters.Add(Uname)
                        'Password
                        Dim Pword As OleDbParameter = New OleDbParameter("@Pword", OleDbType.VarWChar, 50)
                        Pword.Value = txtpassword.Text.ToString
                        cmd.Parameters.Add(Pword)
                        'Full Name
                        Dim Fname As OleDbParameter = New OleDbParameter("@Fname", OleDbType.VarWChar, 50)
                        Fname.Value = txtname.Text.ToString
                        cmd.Parameters.Add(Fname)
                        'Email
                        Dim EmailAdd As OleDbParameter = New OleDbParameter("@EmailAdd", OleDbType.VarWChar, 50)
                        EmailAdd.Value = txtemail.Text.ToString()
                        cmd.Parameters.Add(EmailAdd)
                        'Profile Image
                        Try
                            Dim ms As New System.IO.MemoryStream
                            Dim bmpImage As New Bitmap(myimage.Image)

                            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                            bytImage = ms.ToArray()
                            ms.Close()
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try

                        cmd.Parameters.AddWithValue("@myimage", bytImage)

                        If cmd.ExecuteNonQuery() Then
                            cn.Close()
                            MessageBox.Show("New User has been Added")
                            txtaaccntno.Clear()
                            txtname.Clear()
                            txtemail.Clear()
                            txtuname.Clear()
                            txtpassword.Clear()
                            txtConformPass.Clear()
                            myimage.Image = My.Resources.Resources.defaultimg
                            Btnbrowse.ButtonText = "Browse"
                            ''Me.Close()
                            ''FrmLogin.Show()
                            LoadUser()
                        Else
                            MessageBox.Show("User Failed to create")
                            Return
                        End If
                    Else
                        MessageBox.Show("Password did not Match", "Pasword Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtConformPass.Focus()
                    End If

                End If
            End If

        ElseIf Btncreate.ButtonText = "Update" Then
            If txtaaccntno.Text = "" Or txtemail.Text = "" Or txtname.Text = "" Or txtuname.Text = "" Or txtpassword.Text = "" Or txtConformPass.Text = "" Then
                MessageBox.Show("All Fields are Required. Please fill up all the fields to create an entry for the new user", "Form Fields Required", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                If txtpassword.TextLength <= 5 Then
                    MessageBox.Show("The  Password Should be of Atleast 5 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtpassword.Focus()
                Else

                    If txtpassword.Text = txtConformPass.Text Then
                        edituser()
                        ''MessageBox.Show("Done")
                        Btncreate.ButtonText = "Create"
                        LoadUser()
                    Else
                        MessageBox.Show("Password did not Match", "Pasword Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtConformPass.Focus()
                    End If
                End If

            End If
        End If


    End Sub

    Private Sub Btnbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbrowse.Click
        If Btnbrowse.ButtonText = "Browse" Then
            With ofdImage
                .InitialDirectory = "C:"
                .Filter = "Only Picture With JPG/JPEG/PNG Extension|*.jpg;*.jpeg;*.png"
                .FileName = Nothing
            End With
            If ofdImage.ShowDialog = Windows.Forms.DialogResult.OK Then
                myimage.Image = Image.FromFile(ofdImage.FileName)
                myimage.Tag = ofdImage.FileName
            Else
                myimage.Tag = ""
            End If
            Btnbrowse.ButtonText = "Reset"
        ElseIf Btnbrowse.ButtonText = "Reset" Then
            myimage.Image = My.Resources.Resources.defaultimg
            Btnbrowse.ButtonText = "Browse"
        Else
            myimage.Image = My.Resources.Resources.defaultimg
        End If

    End Sub

    Public Sub LoadUser()
        Try
            cn.Open()
            sql = "SELECT Fname FROM [users] Order By Fname asc"
            'ConnDB()
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            listUser.Items.Clear()
            Do While dr.Read = True
                listUser.Items.Add(dr(0))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            cn.Close()
            CloudHeader3.HeaderText = "Number of User Accounts: " & listUser.Items.Count
        End Try
    End Sub

    Private Sub FrmNewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadUser()
    End Sub

    Private Sub listUser_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles listUser.SelectedIndexChanged
        Try
            cn.Open()
            sql = "Select * FROM [users] WHERE Fname = '" & listUser.SelectedItem & "'"
            ''ConnDB()
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read = True Then
                txtaaccntno.Text = dr("AccntNo")
                txtname.Text = dr("Fname")
                txtemail.Text = dr("Email")
                txtuname.Text = dr("Uname")
                txtpassword.Text = dr("Pword")

                ShowDetails()
                disabledindex()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            cn.Close()
        End Try

        BtnEdit.Enabled = True
        BtnDelete.Enabled = True
    End Sub

    Private Sub ShowDetails()
        Try
            Dim cn As New OleDb.OleDbConnection
            Dim cmd As OleDb.OleDbCommand
            Dim dr As OleDb.OleDbDataReader

            cn.ConnectionString = "Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Dbase\LibraryDB.accdb;"
            cn.Open()

            cmd = cn.CreateCommand()
            cmd.CommandText = "SELECT myimage FROM users WHERE Fname =  '" & listUser.SelectedItem & "' "

            dr = cmd.ExecuteReader

            If dr.Read Then
                Dim bytImage() As Byte

                Try
                    bytImage = CType(dr(0), Byte())
                    Dim ms As New System.IO.MemoryStream(bytImage)
                    Dim bmImage As New Bitmap(ms)
                    ms.Close()

                    myimage.Image = bmImage
                    myimage.Refresh()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If

            dr.Close()
            cn.Close()

            cmd.Dispose()
            cn.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        txtaaccntno.Clear()
        txtname.Clear()
        txtemail.Clear()
        txtuname.Clear()
        txtpassword.Clear()
        txtConformPass.Clear()
        myimage.Image = My.Resources.Resources.defaultimg
        Btnbrowse.ButtonText = "Browse"
        txtaaccntno.Enabled = True
        txtname.Enabled = True
        txtuname.Enabled = True
        txtpassword.Enabled = True
        txtConformPass.Enabled = True
        txtemail.Enabled = True
        Btnbrowse.Enabled = True
        Btncreate.Enabled = True
    End Sub

    Public Sub disabledindex()
        txtaaccntno.Enabled = False
        txtname.Enabled = False
        txtuname.Enabled = False
        txtpassword.Enabled = False
        txtConformPass.Enabled = False
        txtemail.Enabled = False
        Btnbrowse.Enabled = False
        Btncreate.Enabled = False
    End Sub

    Public Sub enabledindex()
        txtaaccntno.Enabled = True
        txtname.Enabled = True
        txtuname.Enabled = True
        txtpassword.Enabled = True
        txtConformPass.Enabled = True
        txtemail.Enabled = True
        Btnbrowse.Enabled = True
        Btncreate.Enabled = True
    End Sub

    Public Sub edituser()
        Using cn As New OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Dbase\LibraryDB.accdb;")
            cn.Open()
            Dim cmd As New OleDbCommand("UPDATE users SET Fname = @fname, Uname = @Uname, Pword = @Pword, Email = @Email, Myimage = @myimage WHERE AccntNo = @AccntNo", cn)
            With cmd.Parameters
                .AddWithValue("@fname", txtname.Text)
                .AddWithValue("@Uname", txtuname.Text)
                .AddWithValue("@Pword", txtpassword.Text)
                .AddWithValue("@Email", txtemail.Text)

                'Try
                Dim ms As New System.IO.MemoryStream
                Dim bmpImage As New Bitmap(myimage.Image)

                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                bytImage = ms.ToArray()
                ms.Close()
                'Catch ex As Exception
                '    MsgBox(ex.ToString)
                'End Try

                .AddWithValue("@myimage", bytImage)
                .AddWithValue("@AccntNo", txtaaccntno.Text)

            End With
            cmd.ExecuteNonQuery()
            MessageBox.Show("User's Informations Successfuly Updated!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtaaccntno.Clear()
            txtname.Clear()
            txtemail.Clear()
            txtuname.Clear()
            txtpassword.Clear()
            txtConformPass.Clear()
            myimage.Image = My.Resources.Resources.defaultimg
            Btnbrowse.ButtonText = "Browse"
            cmd.Dispose()
            cn.Close()
        End Using
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        enabledindex()
        Btncreate.ButtonText = "Update"
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("Are you sure you want to delete " + listUser.SelectedItem + "with account number of " + txtaaccntno.Text, "User Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Using cn As New OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0; Data Source=|DataDirectory|\Dbase\LibraryDB.accdb;")
                cn.Open()
                Dim command As New OleDbCommand("DELETE from TblUser where AccntNo = @AccntNo", cn)
                command.Parameters.AddWithValue("@AccntNo", txtaaccntno.Text)
                command.ExecuteNonQuery()
                command.Dispose()
                command.Dispose()
                cn.Close()
                ''myimage.Image = EmployeeRecords.My.Resources.Resources.photo
                '' lblPreview.Text = "Preview"
            End Using
            LoadUser()
            txtaaccntno.Clear()
            txtname.Clear()
            txtemail.Clear()
            txtuname.Clear()
            txtpassword.Clear()
            txtConformPass.Clear()
            myimage.Image = My.Resources.Resources.defaultimg
            Btnbrowse.ButtonText = "Browse"
        End If
    End Sub

    Private Sub Btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnrefresh.Click
        LoadUser()
    End Sub

End Class