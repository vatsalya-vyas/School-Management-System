<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTeacher
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeacherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalExpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreSchoolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeacherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolProjectDataSet = New SchoolManagementSystem_Project.SchoolProjectDataSet()
        Me.TeacherTableAdapter = New SchoolManagementSystem_Project.SchoolProjectDataSetTableAdapters.TeacherTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIDDataGridViewTextBoxColumn, Me.TeacherNameDataGridViewTextBoxColumn, Me.FatherNameDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.TotalExpDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn, Me.PreSchoolDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TeacherBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(47, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1210, 513)
        Me.DataGridView1.TabIndex = 0
        '
        'TIDDataGridViewTextBoxColumn
        '
        Me.TIDDataGridViewTextBoxColumn.DataPropertyName = "TID"
        Me.TIDDataGridViewTextBoxColumn.HeaderText = "TID"
        Me.TIDDataGridViewTextBoxColumn.Name = "TIDDataGridViewTextBoxColumn"
        '
        'TeacherNameDataGridViewTextBoxColumn
        '
        Me.TeacherNameDataGridViewTextBoxColumn.DataPropertyName = "TeacherName"
        Me.TeacherNameDataGridViewTextBoxColumn.HeaderText = "TeacherName"
        Me.TeacherNameDataGridViewTextBoxColumn.Name = "TeacherNameDataGridViewTextBoxColumn"
        '
        'FatherNameDataGridViewTextBoxColumn
        '
        Me.FatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName"
        Me.FatherNameDataGridViewTextBoxColumn.HeaderText = "FatherName"
        Me.FatherNameDataGridViewTextBoxColumn.Name = "FatherNameDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'TotalExpDataGridViewTextBoxColumn
        '
        Me.TotalExpDataGridViewTextBoxColumn.DataPropertyName = "TotalExp"
        Me.TotalExpDataGridViewTextBoxColumn.HeaderText = "TotalExp"
        Me.TotalExpDataGridViewTextBoxColumn.Name = "TotalExpDataGridViewTextBoxColumn"
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        '
        'PreSchoolDataGridViewTextBoxColumn
        '
        Me.PreSchoolDataGridViewTextBoxColumn.DataPropertyName = "PreSchool"
        Me.PreSchoolDataGridViewTextBoxColumn.HeaderText = "PreSchool"
        Me.PreSchoolDataGridViewTextBoxColumn.Name = "PreSchoolDataGridViewTextBoxColumn"
        '
        'TeacherBindingSource
        '
        Me.TeacherBindingSource.DataMember = "Teacher"
        Me.TeacherBindingSource.DataSource = Me.SchoolProjectDataSet
        '
        'SchoolProjectDataSet
        '
        Me.SchoolProjectDataSet.DataSetName = "SchoolProjectDataSet"
        Me.SchoolProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TeacherTableAdapter
        '
        Me.TeacherTableAdapter.ClearBeforeFill = True
        '
        'ViewTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 573)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewTeacher"
        Me.Text = "ViewTeacher"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SchoolProjectDataSet As SchoolManagementSystem_Project.SchoolProjectDataSet
    Friend WithEvents TeacherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeacherTableAdapter As SchoolManagementSystem_Project.SchoolProjectDataSetTableAdapters.TeacherTableAdapter
    Friend WithEvents TIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeacherNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FatherNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalExpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreSchoolDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
