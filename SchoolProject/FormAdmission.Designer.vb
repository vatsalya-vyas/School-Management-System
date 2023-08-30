<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmission
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.button1 = New System.Windows.Forms.Button()
        Me.txt_permanent_address = New System.Windows.Forms.TextBox()
        Me.cb_class = New System.Windows.Forms.ComboBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txt_previous_school = New System.Windows.Forms.TextBox()
        Me.txt_mothername = New System.Windows.Forms.TextBox()
        Me.txt_dbo = New System.Windows.Forms.TextBox()
        Me.txt_fathername = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.BackgroundImage = Global.SchoolManagementSystem_Project.My.Resources.Resources.EXTRA2
        Me.button1.ForeColor = System.Drawing.Color.White
        Me.button1.Location = New System.Drawing.Point(400, 524)
        Me.button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(283, 55)
        Me.button1.TabIndex = 14
        Me.button1.Text = "Create Admission"
        Me.button1.UseVisualStyleBackColor = True
        '
        'txt_permanent_address
        '
        Me.txt_permanent_address.Location = New System.Drawing.Point(240, 225)
        Me.txt_permanent_address.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_permanent_address.Multiline = True
        Me.txt_permanent_address.Name = "txt_permanent_address"
        Me.txt_permanent_address.Size = New System.Drawing.Size(484, 80)
        Me.txt_permanent_address.TabIndex = 11
        '
        'cb_class
        '
        Me.cb_class.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_class.FormattingEnabled = True
        Me.cb_class.Items.AddRange(New Object() {"Nursery", "L.K.G", "U.K.G", "1st Class", "2nd Class", "3rd Class", "4th Class", "5th Class", "6th Class", "7th Class", "8th Class", "9th Class", "10th Class"})
        Me.cb_class.Location = New System.Drawing.Point(240, 326)
        Me.cb_class.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_class.Name = "cb_class"
        Me.cb_class.Size = New System.Drawing.Size(292, 28)
        Me.cb_class.TabIndex = 12
        Me.cb_class.Text = "Select"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.ComboBox1)
        Me.groupBox1.Controls.Add(Me.button1)
        Me.groupBox1.Controls.Add(Me.txt_permanent_address)
        Me.groupBox1.Controls.Add(Me.cb_class)
        Me.groupBox1.Controls.Add(Me.txt_previous_school)
        Me.groupBox1.Controls.Add(Me.txt_mothername)
        Me.groupBox1.Controls.Add(Me.txt_dbo)
        Me.groupBox1.Controls.Add(Me.txt_fathername)
        Me.groupBox1.Controls.Add(Me.txt_name)
        Me.groupBox1.Controls.Add(Me.label12)
        Me.groupBox1.Controls.Add(Me.label9)
        Me.groupBox1.Controls.Add(Me.label8)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.groupBox1.Location = New System.Drawing.Point(53, 15)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupBox1.Size = New System.Drawing.Size(993, 593)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "New Admission"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBox1.Location = New System.Drawing.Point(725, 169)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(236, 36)
        Me.ComboBox1.TabIndex = 15
        '
        'txt_previous_school
        '
        Me.txt_previous_school.Location = New System.Drawing.Point(240, 380)
        Me.txt_previous_school.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_previous_school.Multiline = True
        Me.txt_previous_school.Name = "txt_previous_school"
        Me.txt_previous_school.Size = New System.Drawing.Size(723, 75)
        Me.txt_previous_school.TabIndex = 13
        '
        'txt_mothername
        '
        Me.txt_mothername.Location = New System.Drawing.Point(724, 96)
        Me.txt_mothername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_mothername.Name = "txt_mothername"
        Me.txt_mothername.Size = New System.Drawing.Size(239, 34)
        Me.txt_mothername.TabIndex = 5
        '
        'txt_dbo
        '
        Me.txt_dbo.Location = New System.Drawing.Point(240, 162)
        Me.txt_dbo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_dbo.Name = "txt_dbo"
        Me.txt_dbo.Size = New System.Drawing.Size(239, 34)
        Me.txt_dbo.TabIndex = 4
        '
        'txt_fathername
        '
        Me.txt_fathername.Location = New System.Drawing.Point(240, 102)
        Me.txt_fathername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_fathername.Name = "txt_fathername"
        Me.txt_fathername.Size = New System.Drawing.Size(239, 34)
        Me.txt_fathername.TabIndex = 4
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(240, 50)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(239, 34)
        Me.txt_name.TabIndex = 3
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.Color.Black
        Me.label12.Location = New System.Drawing.Point(44, 396)
        Me.label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(134, 19)
        Me.label12.TabIndex = 12
        Me.label12.Text = "Previous School : "
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Black
        Me.label9.Location = New System.Drawing.Point(44, 331)
        Me.label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(119, 19)
        Me.label9.TabIndex = 9
        Me.label9.Text = "Admission For :"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.Black
        Me.label8.Location = New System.Drawing.Point(44, 235)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(149, 19)
        Me.label8.TabIndex = 8
        Me.label8.Text = "Permanent Address :"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.Black
        Me.label7.Location = New System.Drawing.Point(553, 177)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(72, 19)
        Me.label7.TabIndex = 7
        Me.label7.Text = "Gender : "
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.Black
        Me.label6.Location = New System.Drawing.Point(44, 177)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(111, 19)
        Me.label6.TabIndex = 6
        Me.label6.Text = "Date Of Birth :"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Black
        Me.label5.Location = New System.Drawing.Point(553, 112)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(117, 19)
        Me.label5.TabIndex = 5
        Me.label5.Text = "Mother Name : "
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(44, 112)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(105, 19)
        Me.label4.TabIndex = 4
        Me.label4.Text = "Father Name :"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(44, 66)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(62, 19)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Name : "
        '
        'FormAdmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SchoolManagementSystem_Project.My.Resources.Resources.form_admission
        Me.ClientSize = New System.Drawing.Size(1084, 623)
        Me.Controls.Add(Me.groupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormAdmission"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admission"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents txt_permanent_address As System.Windows.Forms.TextBox
    Private WithEvents cb_class As System.Windows.Forms.ComboBox
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents txt_previous_school As System.Windows.Forms.TextBox
    Private WithEvents txt_mothername As System.Windows.Forms.TextBox
    Private WithEvents txt_fathername As System.Windows.Forms.TextBox
    Private WithEvents txt_name As System.Windows.Forms.TextBox
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents txt_dbo As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
