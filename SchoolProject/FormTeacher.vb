Imports System.Data.OleDb
Public Class FormTeacher
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then TextBox1.Focus() : Exit Sub
        If TextBox2.Text = "" Then TextBox2.Focus() : Exit Sub
        If TextBox3.Text = "" Then TextBox3.Focus() : Exit Sub

        If TextBox4.Text = "" Then TextBox4.Focus() : Exit Sub
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=|DataDirectory|\SchoolProject.accdb;")
        Try
            con.Open()
            cmd = New OleDbCommand("Insert into [Teacher]([TeacherName],[FatherName],[DOB],[Gender],[TotalExp],[Subject],[PreSchool]) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')", con)

            cmd.ExecuteNonQuery()

            MsgBox("Record Saved Successfully", MsgBoxStyle.Information)
            Me.Hide()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class