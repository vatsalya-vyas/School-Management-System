Public Class Main

    Private Sub btn_Admission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Admission.Click
        FormAdmission.Show()

    End Sub

    Private Sub btn_Tuition_Fees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Tuition_Fees.Click
        FormFee.Show()

    End Sub

    Private Sub btn_Teacher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Teacher.Click
        FormTeacher.Show()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SearchAdmission.Show()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        SearchFee.Show()

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Searchteacher.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        EditAdmission.Show()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        EditFee.Show()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        EditTeacher.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ViewAdmission.Show()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ViewFee.Show()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ViewTeacher.Show()

    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Text = Date.Now.ToString("hh:mm:ss")
        Label2.Text = Date.Now.ToString("dd MMM yyyy")
    End Sub
End Class