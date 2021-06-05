Public Class MainForm
    Public Property Acc As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Obj = New Deposit()
        Obj.Acc = AccNumLbl.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AccNumLbl.Text = Acc
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim Obj = New Login()
        Obj.Show()
        Acc = AccNumLbl.Text
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Obj = New Balance()
        Obj.Acc = AccNumLbl.Text
        Obj.Show()
        Me.Hide()
    End Sub
End Class