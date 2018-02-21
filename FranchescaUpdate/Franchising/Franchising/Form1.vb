

Imports MySql.Data.MySqlClient
Public Class Form1

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand



    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel1.Click
        SignUp.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("DO YOU WANT TO EXIT?", "EXIT", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            Me.Show()

        Else
            Application.ExitThread()
        End If



    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblCreate.Click
        SignUp.Show()
        Me.Hide()
    End Sub



    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            txtPassLog.isPassword = False

        Else
            txtPassLog.isPassword = True

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;user id=root;password=root;database=clients"
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from clients.members where userName='" & txtNameLog.Text & "' and passWord='" & txtPassLog.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            Dim READER As MySqlDataReader
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("Username and Password are correct")
                menu01.Show()
                Me.Hide()

            Else
                MessageBox.Show("Username and Password are not correct")



            End If

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub txtPassLog_OnValueChanged(sender As Object, e As EventArgs) Handles txtPassLog.OnValueChanged

    End Sub
End Class

