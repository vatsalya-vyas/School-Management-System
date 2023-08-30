Imports System.Data.OleDb
Public Class FormAdmission
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=|DataDirectory|\SchoolProject.accdb;")
        If txt_name.Text = "" Then txt_name.Focus() : Exit Sub
        If txt_fathername.Text = "" Then txt_fathername.Focus() : Exit Sub
        con.Open()
        Try
            cmd = New OleDbCommand("insert into tblAdmission(StudentName,FatherName,MotherName,DoB,Gender,Address,Class,PreSchoolName) Values('" + txt_name.Text + "','" + txt_fathername.Text + "','" + txt_mothername.Text + "','" + txt_dbo.Text + "','" + ComboBox1.Text + "','" + txt_permanent_address.Text + "','" + cb_class.Text + "','" + txt_previous_school.Text + "')", con)
            cmd.ExecuteNonQuery()


            MsgBox("Record Saved Successfully")
            Me.Close()

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub
End Class