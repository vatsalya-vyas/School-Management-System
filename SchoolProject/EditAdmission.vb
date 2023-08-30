Imports System.Data.OleDb
Public Class EditAdmission
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'FOR UPDATE
        con.Close()
        If TextBox1.Text = "" Or txt_name.Text = "" Or txt_name.Text = "" Or txt_fathername.Text = "" Or txt_mothername.Text = "" Or txt_dbo.Text = "" Or txt_permanent_address.Text = "" Then
            MsgBox("Please Fill All The Required Details")
            Exit Sub
        End If

        con.Open()
        cmd = New OleDbCommand("Update [tblAdmission] Set [StudentName]='" & txt_name.Text & "',[FatherName]='" & txt_fathername.Text & "',[MotherName]='" & txt_mothername.Text & "',[DoB]='" & txt_dbo.Text & "',[Gender]='" & ComboBox1.Text & "',[Address]='" & txt_permanent_address.Text & "',[Class]='" & cb_class.Text & "',[PreSchoolName]='" & txt_previous_school.Text & "' Where [AdmissionNo]=" & Convert.ToInt32(TextBox1.Text) & " ", con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Record Updated Successfully..")

            Me.Hide()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()

        End Try
    End Sub

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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con.Close()

        If TextBox1.Text = "" Then

            MsgBox("Please Fill All The Required Details")
            Exit Sub
        End If
        Dim msg As Integer = MsgBox("Do You Really Want To Delete Student Record :-'" & TextBox1.Text & "' ?", MsgBoxStyle.YesNoCancel, "Delete Customer Record")

        If msg = DialogResult.Yes Then
            con.Open()

            cmd = New OleDbCommand("Delete from [tblAdmission] Where [AdmissionNo]=" & TextBox1.Text & "", con)
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Record Deleted Successfully")

                Me.Hide()

                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

            End Try
        End If
    End Sub
End Class