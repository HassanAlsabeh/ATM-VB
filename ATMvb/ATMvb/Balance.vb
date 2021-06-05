Imports System.Data.SqlClient

Public Class Balance
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BalLbl_Click(sender As Object, e As EventArgs) Handles BalLbl.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
    Public Property Acc As String
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj = New MainForm
        Obj.Show()
        Me.Hide()
    End Sub
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sarahalsabeh\Documents\ATMVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub GetBalance()
        Con.Open()
        Dim cmd As SqlCommand
        Dim query = "select Balance from AccountTb where AccNum=" & Account & ""
        cmd = New SqlCommand(query, Con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable
        dt = New DataTable
        sda.Fill(dt)
        BalLbl.Text = Convert.ToInt32(dt.Rows(0)(0).ToString())
        Con.Close()

    End Sub
    Dim Account As Integer
    Private Sub Balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Account = Convert.ToInt32(Acc)
        AccNumLbl.Text = Acc
        GetBalance()
    End Sub
End Class