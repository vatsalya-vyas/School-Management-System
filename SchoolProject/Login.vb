Imports System.Data.OleDb

Public Class Login
    Dim Str As String
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        End

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Enter username / Password", MsgBoxStyle.Critical)
        Else
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=|DataDirectory|\SchoolProject.accdb;")
            Str = "Select * from Login where UserName='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'"
            cmd = New OleDbCommand(Str, con)
            con.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            If dr.HasRows Then
                con.Close()
                Me.Hide()
                Main.Show()

            Else
                MsgBox("UserID & Password Not Matched", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)
            End If

            con.Close()
        End If
    End Sub
End Class
