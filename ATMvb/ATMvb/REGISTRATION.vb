
Imports System.Data.SqlClient
Public Class REGISTRATION
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sarahalsabeh\Documents\ATMVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Reset()
        AccNumTb.Text = ""
        NameTb.Text = ""
        FNameTb.Text = ""
        PhoneTb.Text = ""
        AddressTb.Text = ""
        EduCb.SelectedIndex = 0
        OccupatioTb.Text = ""
        PinTb.Text = ""

    End Sub
    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        If AccNumTb.Text = "" Or NameTb.Text = "" Or FNameTb.Text = "" Or PhoneTb.Text = "" Or AddressTb.Text = "" Or EduCb.SelectedIndex = -1 Or OccupatioTb.Text = "" Or PinTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                Dim Bal = 0
                Con.Open()
                Dim query = "insert into AccountTb values(" & AccNumTb.Text & ",'" & NameTb.Text & "','" & FNameTb.Text & "','" & DobDate.Value & "','" & PhoneTb.Text & "','" & AddressTb.Text & "','" & EduCb.SelectedItem.ToString() & "','" & OccupatioTb.Text & "','" & PinTb.Text & "'," & Bal & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Account Added")
                Con.Close()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim Obj = New Login()
        Me.Hide()
        Obj.Show()

    End Sub

    Private Sub REGISTRATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class