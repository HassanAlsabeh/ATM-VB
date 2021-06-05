Public Class splash
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MyProgress.Increment(5)
        Dim Per As String
        Per = Convert.ToString(MyProgress.Value)
        PercentageLbl.Text = Per + "%"
        If MyProgress.Value = 100 Then
            Me.Hide()
            Dim Obj = New Login
            Obj.Show()
            Timer1.Enabled = False
        End If
    End Sub
End Class
