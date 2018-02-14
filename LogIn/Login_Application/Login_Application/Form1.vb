Option Explicit On
Option Strict On

Imports System.Data.OleDb

Public Class Form1
    Dim objCon As New OleDbConnection
    Dim strSQL As String
    Dim strConnection As String = "Provider= Microsoft.ACE.OLEDB.12.0; Data Source=C:\LogIn\Login_Database.accdb"
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim attempt As Integer = 0

    Private Sub bunifuFlatButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton3.Click

        Dim warning As String = "Warning!" & vbNewLine & vbNewLine +
            "If attempt var = 3" + vbNewLine +
            "System will shutdown."

        If (BunifuTextbox1.text = "") And (BunifuTextbox2.text = "") Then
            attempt = attempt + 1
            MsgBox("Please input username and password!" & vbNewLine & vbNewLine +
                   warning, MsgBoxStyle.Exclamation, "Sorry sir! " &
                   "Now attempt var = " & attempt)
        ElseIf (BunifuTextbox1.text = "") Then
            attempt = attempt + 1
            MsgBox("Please input your username!" & vbNewLine & vbNewLine +
                   warning, MsgBoxStyle.Information, "Sorry sir! " &
                   "Now attempt var = " & attempt)
        ElseIf (BunifuTextbox2.text = "") Then
            attempt = attempt + 1
            MsgBox("Please input password!" & vbNewLine & vbNewLine +
                   warning, MsgBoxStyle.Information, "Sorry sir! " &
                   "Now attempt var = " & attempt)
        Else

            Dim strName = BunifuTextbox1.text
            Dim strPass = BunifuTextbox2.text

            With objCon
                .Close()
                If .State = ConnectionState.Closed Then
                    .ConnectionString = strConnection
                    .Open()
                    MsgBox("ConnectionState.Open", MsgBoxStyle.Information, "Connected")
                End If
            End With

            ds.Clear()
            strSQL = "Select * From adminTbl Where adm_username ='" & BunifuTextbox1.text & "' And adm_password ='" & BunifuTextbox2.text & "'"
            da = New OleDbDataAdapter(strSQL, objCon)
            da.Fill(ds, "adminTbl")

            If ds.Tables("adminTbl").Rows.Count <> 0 Then
                'Play Login Sound
                My.Computer.Audio.Play(Application.StartupPath + "\cubase_sound\Wah_LogIn.Wav")
                MaximizeBox = True
                MinimizeBox = True
                '- MyBase.Hide()
                MsgBox("Hello! " + strName + vbNewLine +
                       "Log in successful", MsgBoxStyle.OkOnly,
                       "Wel come " + strName)
                Me.Show()
            Else
                MaximizeBox = False
                MinimizeBox = False
                attempt = attempt +
                MsgBox("Oop! --> " & strName & "  _&_  " & strPass + vbNewLine + vbNewLine +
                       "The username or password yor entered" + vbNewLine +
                       "is not valid." + vbNewLine +
                       "Please try again", MsgBoxStyle.Exclamation, "Invalid")
            End If
        End If

        If attempt = 3 Then
            MsgBox("Windows is shutting down...", MsgBoxStyle.Critical, "Good bye sir!")
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        If objCon.State = ConnectionState.Open Then
            objCon.Close()
            MsgBox("Good bye sir" + vbNewLine +
            "ConnectionState.Closed", MsgBoxStyle.Information, "Thank you for watching")
        End If

        Dim msg As String = "Do you want to Exit?"
        Dim title As String = "Exit Application"
        Dim buttons As MessageBoxButtons = MessageBoxButtons.YesNoCancel
        Dim icons As MessageBoxIcon = MessageBoxIcon.Exclamation
        Dim result As DialogResult = MessageBox.Show(msg, title, buttons, icons, MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            'Play Exit Sound
            My.Computer.Audio.Play(Application.StartupPath + "\cubase_sound\Wah_Exit.Wav")
            MessageBox.Show("Thank you for watching." + vbNewLine +
                            "f. iBasskung.", "Exit Application Confirm")
            Me.Close()
        ElseIf result = DialogResult.No Then
            MsgBox("No Pressed", CType(MsgBoxStyle.Information & MsgBoxStyle.OkOnly, MsgBoxStyle), "No Button")
        Else
            MsgBox("Cancel Pressed", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle), "Cancel Button")
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MaximizeBox = False
        MinimizeBox = False

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class