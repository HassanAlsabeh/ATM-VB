Imports System.Data.SqlClient

Public Class Withdraw
    Public Property Acc As String
    Dim MyAcc As Integer
    Private Sub Withdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyAcc = Convert.ToInt32(Acc)
        GetBalance()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj = New MainForm()
        Obj.Acc = Acc
        Obj.Show()
        Me.Hide()
    End Sub
    Dim OldBalance = 0
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sarahalsabeh\Documents\ATMVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub GetBalance()
        Con.Open()
        Dim cmd As SqlCommand
        Dim query = "select Balance from AccountTb where AccNum=" & Acc & ""
        cmd = New SqlCommand(query, Con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable
        dt = New DataTable
        sda.Fill(dt)
        OldBalance = Convert.ToInt32(dt.Rows(0)(0).ToString())
        BalLbl.Text = OldBalance
        Con.Close()

    End Sub
    Private Sub UpdateBal()
        Dim Account = Convert.ToInt32(Acc)
        Dim NewBal = OldBalance - Convert.ToInt32(AmountTb.Text)
        Try
            ' Dim Bal = 0
            Con.Open()
            Dim query = "Update AccountTb set Balance = " & NewBal & " Where AccNum=" & Acc & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Balance Updated")
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If AmountTb.Text = "" Then
            MsgBox("Missing Information")
        ElseIf Convert.ToInt32(AmountTb.Text) > OldBalance Then
            MsgBox("No Enough Money")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "WithDraw"
            Try
                Dim Bal = 0
                Con.Open()
                Dim query = "insert into TransactionTb values(" & MyAcc & ",'" & TrType & "'," & AmountTb.Text & ",'" & Date.Today.Date & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull")
                Con.Close()
                UpdateBal()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class