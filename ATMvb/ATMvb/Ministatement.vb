Imports System.Data.SqlClient

Public Class Ministatement
    Public Property Acc As String
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sarahalsabeh\Documents\ATMVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DisplayTr()
        Con.Open()
        Dim query = "Select TOP(5) * from TransactionTb where ACCNUM='" & Acc & "'"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet()
        adapter.Fill(ds)
        TransactionDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Ministatement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayTr()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj = New MainForm()
        Obj.Acc = Acc
        Obj.Show()
        Me.Hide()
    End Sub
End Class