Imports System.Data.SqlClient

Public Class ChangePin
    Public Property Acc As String
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sarahalsabeh\Documents\ATMVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Dim MyAcc As Integer
    Private Sub ChangePin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyAcc = Convert.ToInt32(Acc)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj = New MainForm
        Obj.Acc = Acc
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Pin1Tb.Text = "" Or Pin2Tb.Text = "" Then
            MsgBox("Missing Information")
        ElseIf Pin1Tb.Text = Pin2Tb.Text Then


            Try
                Dim Bal = 0
                Con.Open()
                Dim query = "Update AccountTb set PIN='" & Pin1Tb.Text & "' where ACCNUM=" & MyAcc & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("PIN Changed Successful")
                Con.Close()
                Dim Log = New Login()
                Log.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("PIN1 and PIN2 donnot match")
        End If
    End Sub
End Class