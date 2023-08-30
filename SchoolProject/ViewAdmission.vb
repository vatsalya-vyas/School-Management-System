Imports System.Data.OleDb
Imports System.Data

Public Class ViewAdmission
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub ViewRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=|DataDirectory|\SchoolProject.accdb;")
        con.Open()
        Dim da As New OleDbDataAdapter("Select * from tblAdmission", con)
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ' Close()
    End Sub

End Class