
Imports System.Data.SqlClient
Public Class Login
    Public Property AccountNum As String
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sarahalsabeh\Documents\ATMVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim Obj = New REGISTRATION()
        Me.Hide()
        Obj.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If AccNumTb.Text = "" Or PinTb.Text = "" Then
            MsgBox("Enter The Account Number and PIN Number ")
        Else
            Con.Open()
            Dim query = "Select * from AccountTb where AccNum='" & AccNumTb.Text & "' and PIN='" & PinTb.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Wrong Username Or Password")
            Else
                Dim Obj = New MainForm
                Obj.Acc = AccNumTb.Text
                Obj.Show()
                Me.Hide()
            End If
            Con.Close()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class