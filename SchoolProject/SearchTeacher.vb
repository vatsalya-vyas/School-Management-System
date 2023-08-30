
Imports System.Data.OleDb
Public Class Searchteacher
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=|DataDirectory|\SchoolProject.accdb;")
        con.Open()
        Using cmd As New OleDbCommand()
            cmd.CommandText = "Select * from [Teacher] where [TID] =@ID "
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@ID", TextBox7.Text.Trim())

            Dim dt As New DataTable()
            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
                If (dt.Rows.Count > 0) Then
                    TextBox7.Text = dt.Rows(0)(0).ToString()
                    TextBox1.Text = dt.Rows(0)(1).ToString()
                    TextBox2.Text = dt.Rows(0)(2).ToString()
                    TextBox3.Text = dt.Rows(0)(3).ToString()
                    ComboBox1.Text = dt.Rows(0)(4).ToString()
                    TextBox4.Text = dt.Rows(0)(5).ToString()
                    TextBox5.Text = dt.Rows(0)(6).ToString()
                    TextBox6.Text = dt.Rows(0)(7).ToString()


                Else
                    MsgBox("Record Not Found", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)

                End If


            End Using
        End Using
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub
End Class