Imports System.Data.SqlClient

Public Class FastCash
    Public Property Acc As String
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sarahalsabeh\Documents\ATMVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Dim OldBalance = 0
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
    Private Sub FastCash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetBalance()
        MyAcc = Convert.ToInt32(Acc)
    End Sub
    Dim MyAcc = 0
    Dim Amount As Integer
    Private Sub UpdateBal(Amt As Integer)
        Dim Account = Convert.ToInt32(Acc)
        Dim NewBal = OldBalance - Amt
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
        If OldBalance < 100 Then
            MsgBox("No Enough Balance")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "WithDraw"
            Amount = 100
            Try
                Dim Bal = 0
                Con.Open()
                Dim query = "insert into TransactionTb values(" & MyAcc & ",'" & TrType & "'," & Amount & ",'" & Date.Today.Date & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull")
                Con.Close()
                UpdateBal(Amount)
                Dim Obj = New MainForm()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim Obj = New MainForm()
        Obj.Acc = Acc
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If OldBalance < 500 Then
            MsgBox("No Enough Balance")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "WithDraw"
            Amount = 500
            Try
                Dim Bal = 0
                Con.Open()
                Dim query = "insert into TransactionTb values(" & MyAcc & ",'" & TrType & "'," & Amount & ",'" & Date.Today.Date & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull")
                Con.Close()
                UpdateBal(Amount)
                Dim Obj = New MainForm()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If OldBalance < 1000 Then
            MsgBox("No Enough Balance")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "WithDraw"
            Amount = 1000
            Try
                Dim Bal = 0
                Con.Open()
                Dim query = "insert into TransactionTb values(" & MyAcc & ",'" & TrType & "'," & Amount & ",'" & Date.Today.Date & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull")
                Con.Close()
                UpdateBal(Amount)
                Dim Obj = New MainForm()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If OldBalance < 2000 Then
            MsgBox("No Enough Balance")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "WithDraw"
            Amount = 2000
            Try
                Dim Bal = 0
                Con.Open()
                Dim query = "insert into TransactionTb values(" & MyAcc & ",'" & TrType & "'," & Amount & ",'" & Date.Today.Date & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull")
                Con.Close()
                UpdateBal(Amount)
                Dim Obj = New MainForm()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If OldBalance < 5000 Then
            MsgBox("No Enough Balance")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "WithDraw"
            Amount = 5000
            Try
                Dim Bal = 0
                Con.Open()
                Dim query = "insert into TransactionTb values(" & MyAcc & ",'" & TrType & "'," & Amount & ",'" & Date.Today.Date & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull")
                Con.Close()
                UpdateBal(Amount)
                Dim Obj = New MainForm()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If OldBalance < 10000 Then
            MsgBox("No Enough Balance")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "WithDraw"
            Amount = 10000
            Try
                Dim Bal = 0
                Con.Open()
                Dim query = "insert into TransactionTb values(" & MyAcc & ",'" & TrType & "'," & Amount & ",'" & Date.Today.Date & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull")
                Con.Close()
                UpdateBal(Amount)
                Dim Obj = New MainForm()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class