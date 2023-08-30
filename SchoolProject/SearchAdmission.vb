Imports System.Data.OleDb
Public Class SearchAdmission
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'con.Close()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=|DataDirectory|\SchoolProject.accdb;")
        con.Open()
        Using cmd As New OleDbCommand()
            cmd.CommandText = "Select * from [tblAdmission] where [AdmissionNo] =@ID "
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@ID", TextBox1.Text.Trim())

            Dim dt As New DataTable()
            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
                If (dt.Rows.Count > 0) Then

                    TextBox1.Text = dt.Rows(0)(0).ToString()
                    txt_name.Text = dt.Rows(0)(1).ToString()
                    txt_fathername.Text = dt.Rows(0)(2).ToString()
                    txt_mothername.Text = dt.Rows(0)(3).ToString()
                    txt_dbo.Text = dt.Rows(0)(4).ToString()
                    ComboBox1.Text = dt.Rows(0)(5).ToString()
                    txt_permanent_address.Text = dt.Rows(0)(6).ToString()
                    cb_class.Text = dt.Rows(0)(7).ToString()
                    txt_previous_school.Text = dt.Rows(0)(8).ToString()

                Else
                    MsgBox("Record Not Found", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)

                End If


            End Using
        End Using
    End Sub
End Class