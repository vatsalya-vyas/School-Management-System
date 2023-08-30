<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchAdmission
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_fathername = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txt_permanent_address = New System.Windows.Forms.TextBox()
        Me.cb_class = New System.Windows.Forms.ComboBox()
        Me.txt_previous_school = New System.Windows.Forms.TextBox()
        Me.txt_mothername = New System.Windows.Forms.TextBox()
        Me.txt_dbo = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.label1.Location = New System.Drawing.Point(31, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(140, 17)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Enter Admission No :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(214, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 23)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.SchoolManagementSystem_Project.My.Resources.Resources.Login_Image_210
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(386, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 29)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_fathername
        '
        Me.txt_fathername.Location = New System.Drawing.Point(180, 83)
        Me.txt_fathername.Name = "txt_fathername"
        Me.txt_fathername.Size = New System.Drawing.Size(180, 29)
        Me.txt_fathername.TabIndex = 4
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(180, 41)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(180, 29)
        Me.txt_name.TabIndex = 3
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.Color.Black
        Me.label12.Location = New System.Drawing.Point(33, 322)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(111, 16)
        Me.label12.TabIndex = 12
        Me.label12.Text = "Previous School : "
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Black
        Me.label9.Location = New System.Drawing.Point(33, 269)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(95, 16)
        Me.label9.TabIndex = 9
        Me.label9.Text = "Admission for :"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.Black
        Me.label8.Location = New System.Drawing.Point(33, 191)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(124, 16)
        Me.label8.TabIndex = 8
        Me.label8.Text = "Permanent Address :"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.Black
        Me.label7.Location = New System.Drawing.Point(415, 144)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(60, 16)
        Me.label7.TabIndex = 7
        Me.label7.Text = "Gender : "
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.Black
        Me.label6.Location = New System.Drawing.Point(33, 144)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(91, 16)
        Me.label6.TabIndex = 6
        Me.label6.Text = "Date Of Birth :"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Black
        Me.label5.Location = New System.Drawing.Point(415, 91)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(97, 16)
        Me.label5.TabIndex = 5
        Me.label5.Text = "Mother Name : "
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.ComboBox1)
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
        Me.groupBox1.Location = New System.Drawing.Point(40, 61)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(745, 392)
        Me.groupBox1.TabIndex = 4
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "New Admission"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBox1.Location = New System.Drawing.Point(544, 137)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 29)
        Me.ComboBox1.TabIndex = 15
        '
        'txt_permanent_address
        '
        Me.txt_permanent_address.Location = New System.Drawing.Point(180, 183)
        Me.txt_permanent_address.Multiline = True
        Me.txt_permanent_address.Name = "txt_permanent_address"
        Me.txt_permanent_address.Size = New System.Drawing.Size(364, 66)
        Me.txt_permanent_address.TabIndex = 11
        '
        'cb_class
        '
        Me.cb_class.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_class.FormattingEnabled = True
        Me.cb_class.Items.AddRange(New Object() {"Nursery", "L.K.G", "U.K.G", "1st Class", "2nd Class", "3rd Class", "4th Class", "5th Class", "6th Class", "7th Class", "8th Class", "9th Class", "10th Class"})
        Me.cb_class.Location = New System.Drawing.Point(180, 265)
        Me.cb_class.Name = "cb_class"
        Me.cb_class.Size = New System.Drawing.Size(220, 24)
        Me.cb_class.TabIndex = 12
        Me.cb_class.Text = "Select"
        '
        'txt_previous_school
        '
        Me.txt_previous_school.Location = New System.Drawing.Point(180, 309)
        Me.txt_previous_school.Multiline = True
        Me.txt_previous_school.Name = "txt_previous_school"
        Me.txt_previous_school.Size = New System.Drawing.Size(543, 62)
        Me.txt_previous_school.TabIndex = 13
        '
        'txt_mothername
        '
        Me.txt_mothername.Location = New System.Drawing.Point(543, 78)
        Me.txt_mothername.Name = "txt_mothername"
        Me.txt_mothername.Size = New System.Drawing.Size(180, 29)
        Me.txt_mothername.TabIndex = 5
        '
        'txt_dbo
        '
        Me.txt_dbo.Location = New System.Drawing.Point(180, 132)
        Me.txt_dbo.Name = "txt_dbo"
        Me.txt_dbo.Size = New System.Drawing.Size(180, 29)
        Me.txt_dbo.TabIndex = 4
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(33, 91)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(88, 16)
        Me.label4.TabIndex = 4
        Me.label4.Text = "Father Name :"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(33, 54)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(52, 16)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Name : "
        '
        'SearchAdmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SchoolManagementSystem_Project.My.Resources.Resources.search_admission
        Me.ClientSize = New System.Drawing.Size(811, 511)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.label1)
        Me.Name = "SearchAdmission"
        Me.Text = "Search"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents txt_fathername As System.Windows.Forms.TextBox
    Private WithEvents txt_name As System.Windows.Forms.TextBox
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents txt_permanent_address As System.Windows.Forms.TextBox
    Private WithEvents cb_class As System.Windows.Forms.ComboBox
    Private WithEvents txt_previous_school As System.Windows.Forms.TextBox
    Private WithEvents txt_mothername As System.Windows.Forms.TextBox
    Private WithEvents txt_dbo As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
End Class
