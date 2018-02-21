
Imports MySql.Data.MySqlClient
Public Class SignUp

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles txtNameSign.OnValueChanged

    End Sub

    Private Sub BunifuCustomLabel3_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel3.Click

    End Sub

    Private Sub BunifuCheckbox1_OnChange(sender As Object, e As EventArgs) Handles chkArgee.OnChange

    End Sub

    Private Sub picExeSign_Click(sender As Object, e As EventArgs) Handles picExeSign.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("DO YOU WANT TO EXIT?", "EXIT", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            Me.Show()

        Else
            Application.ExitThread()
        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            txtPassword.isPassword = False

        Else
            txtPassword.isPassword = True

        End If
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;user id=root;password=root;database=clients"
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO clients.members (lastName, firstName, userName , passWord ,eMail) values ('" & txtLastSign.Text & "','" & txtNameSign.Text & "','" & txtUser.Text & "','" & txtPassword.Text & "','" & txtEmail.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            Dim READER As MySqlDataReader
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data Saved")
            Form2.Show()
            MysqlConn.Close()

            Form2.Show()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub
End Class