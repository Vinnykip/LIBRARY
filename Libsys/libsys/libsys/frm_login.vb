Imports System.Data.OleDb

Public Class frm_login
    Dim conn As New OleDbConnection
  

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If Me.UsernameTextBox.Text = "" Or Me.PasswordTextBox.Text = "" Then Exit Sub
        '------------------------'

        Dim sqlQRY As String = "SELECT * FROM Users WHERE user_type='admin' AND  username = '" & Me.UsernameTextBox.Text & "' AND password = '" & Me.PasswordTextBox.Text & "'"

        Dim cmd As OleDbCommand = New OleDbCommand(sqlQRY, conn)

        Dim rdr As OleDbDataReader = cmd.ExecuteReader

        rdr.Read()

        '-----------------------'
        Dim sqlQRY1 As String = "SELECT * FROM Users WHERE user_type='employee' AND  username = '" & Me.UsernameTextBox.Text & "' AND password = '" & Me.PasswordTextBox.Text & "'"

        Dim cmd1 As OleDbCommand = New OleDbCommand(sqlQRY1, conn)

        Dim rdr1 As OleDbDataReader = cmd1.ExecuteReader

        rdr1.Read()
        '-----------------------'

        If rdr.HasRows = True Then
            Dim Username As String = rdr("Username").ToString
            Dim Password As String = rdr("Password").ToString


            frm_loading.Show()


            Me.Hide()
          

        ElseIf rdr1.HasRows = True Then
            Dim Username As String = rdr1("Username").ToString
            Dim Password As String = rdr1("Password").ToString

            frm_main.SettingsToolStripMenuItem.Enabled = False
            frm_loading.Show()

           
     


            Me.Hide()

        Else
            MessageBox.Show("Invalid Password or Username", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cnString As String

        cnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\libsys.mdb"

        'Create connection
        conn = New OleDbConnection(cnString)

        Try
            ' Open connection
            conn.Open()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close connection
            'conn.Close()
        End Try
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Text = Date.Today

    End Sub

End Class
