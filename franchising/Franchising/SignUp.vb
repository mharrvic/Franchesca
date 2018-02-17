Public Class SignUp
    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles txtNameSign.OnValueChanged

    End Sub

    Private Sub BunifuCustomLabel3_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel3.Click

    End Sub

    Private Sub BunifuCheckbox1_OnChange(sender As Object, e As EventArgs) Handles chkArgee.OnChange

    End Sub

    Private Sub picExeSign_Click(sender As Object, e As EventArgs) Handles picExeSign.Click
        Application.Exit()
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
End Class