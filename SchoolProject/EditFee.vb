﻿Imports System.Data.OleDb
Public Class EditFee
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=|DataDirectory|\SchoolProject.accdb;")
        con.Open()
        Using cmd As New OleDbCommand()
            cmd.CommandText = "Select * from [tblFee] where [FeeID] =@ID "
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@ID", TextBox1.Text.Trim())

            Dim dt As New DataTable()
            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
                If (dt.Rows.Count > 0) Then

                    TextBox1.Text = dt.Rows(0)(0).ToString()
                    TextBox6.Text = dt.Rows(0)(1).ToString()
                    TextBox2.Text = dt.Rows(0)(2).ToString()
                    TextBox3.Text = dt.Rows(0)(3).ToString()
                    TextBox5.Text = dt.Rows(0)(4).ToString()
                    TextBox4.Text = dt.Rows(0)(5).ToString()
                    TextBox7.Text = dt.Rows(0)(6).ToString()


                Else
                    MsgBox("Record Not Found", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)

                End If


            End Using
        End Using

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'FOR UPDATE
        con.Close()
        If TextBox1.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Please Fill All The Required Details")
            Exit Sub
        End If

        con.Open()
        cmd = New OleDbCommand("Update [tblFee] Set [AdmissionNo]='" & TextBox6.Text & "',[StudentName]='" & TextBox2.Text & "',[Class]='" & TextBox3.Text & "',[PayMode]='" & TextBox4.Text & "',[Amount]='" & TextBox5.Text & "',[Date]='" & TextBox7.Text & "' Where [FeeID]=" & Convert.ToInt32(TextBox1.Text) & " ", con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Record Update Successfully..")

            Me.Hide()
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()

        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        con.Close()

        If TextBox1.Text = "" Then

            MsgBox("Please Fill All The Required Details")
            Exit Sub
        End If
        Dim msg As Integer = MsgBox("Do You Really Want To Delete Fee Record :-'" & TextBox1.Text & "' ?", MsgBoxStyle.YesNoCancel, "Delete Customer Record")

        If msg = DialogResult.Yes Then
            con.Open()

            cmd = New OleDbCommand("Delete from [tblFee] Where [FeeID]=" & TextBox1.Text & "", con)
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class