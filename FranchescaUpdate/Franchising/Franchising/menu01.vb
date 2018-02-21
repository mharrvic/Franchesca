
Imports System.ComponentModel
Imports System.Text




Public Class menu01
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        OpenForm(GetType(menuapplicants))
    End Sub
    Public Sub OpenForm(ByVal typeform As Type)
        For Each frm As Form In MdiChildren
            If frm.GetType() = typeform Then
                frm.Activate()
                Return

            End If
        Next
        Dim f As Form = DirectCast(Activator.CreateInstance(typeform), Form)
        f.MdiParent = Me
        f.Show()

    End Sub
    Private Sub menu01_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        OpenForm(GetType(menuReports))
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DoYouWantToGoBack.ItemClick
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub BackstageViewClientControl1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackstageViewTabItem1_SelectedChanged(sender As Object, e As DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs)
        OpenForm(GetType(menuReports))
    End Sub
End Class
