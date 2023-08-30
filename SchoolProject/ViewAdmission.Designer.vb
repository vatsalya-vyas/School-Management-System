<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAdmission
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
        Me.AdmissionNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreSchoolNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblAdmissionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolProjectDataSet = New SchoolManagementSystem_Project.SchoolProjectDataSet()
        Me.TblAdmissionTableAdapter = New SchoolManagementSystem_Project.SchoolProjectDataSetTableAdapters.tblAdmissionTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAdmissionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdmissionNoDataGridViewTextBoxColumn, Me.StudentNameDataGridViewTextBoxColumn, Me.FatherNameDataGridViewTextBoxColumn, Me.MotherNameDataGridViewTextBoxColumn, Me.DoBDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.PreSchoolNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblAdmissionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 63)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1279, 539)
        Me.DataGridView1.TabIndex = 0
        '
        'AdmissionNoDataGridViewTextBoxColumn
        '
        Me.AdmissionNoDataGridViewTextBoxColumn.DataPropertyName = "AdmissionNo"
        Me.AdmissionNoDataGridViewTextBoxColumn.HeaderText = "AdmissionNo"
        Me.AdmissionNoDataGridViewTextBoxColumn.Name = "AdmissionNoDataGridViewTextBoxColumn"
        '
        'StudentNameDataGridViewTextBoxColumn
        '
        Me.StudentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName"
        Me.StudentNameDataGridViewTextBoxColumn.HeaderText = "StudentName"
        Me.StudentNameDataGridViewTextBoxColumn.Name = "StudentNameDataGridViewTextBoxColumn"
        '
        'FatherNameDataGridViewTextBoxColumn
        '
        Me.FatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName"
        Me.FatherNameDataGridViewTextBoxColumn.HeaderText = "FatherName"
        Me.FatherNameDataGridViewTextBoxColumn.Name = "FatherNameDataGridViewTextBoxColumn"
        '
        'MotherNameDataGridViewTextBoxColumn
        '
        Me.MotherNameDataGridViewTextBoxColumn.DataPropertyName = "MotherName"
        Me.MotherNameDataGridViewTextBoxColumn.HeaderText = "MotherName"
        Me.MotherNameDataGridViewTextBoxColumn.Name = "MotherNameDataGridViewTextBoxColumn"
        '
        'DoBDataGridViewTextBoxColumn
        '
        Me.DoBDataGridViewTextBoxColumn.DataPropertyName = "DoB"
        Me.DoBDataGridViewTextBoxColumn.HeaderText = "DoB"
        Me.DoBDataGridViewTextBoxColumn.Name = "DoBDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        '
        'PreSchoolNameDataGridViewTextBoxColumn
        '
        Me.PreSchoolNameDataGridViewTextBoxColumn.DataPropertyName = "PreSchoolName"
        Me.PreSchoolNameDataGridViewTextBoxColumn.HeaderText = "PreSchoolName"
        Me.PreSchoolNameDataGridViewTextBoxColumn.Name = "PreSchoolNameDataGridViewTextBoxColumn"
        '
        'TblAdmissionBindingSource
        '
        Me.TblAdmissionBindingSource.DataMember = "tblAdmission"
        Me.TblAdmissionBindingSource.DataSource = Me.SchoolProjectDataSet
        '
        'SchoolProjectDataSet
        '
        Me.SchoolProjectDataSet.DataSetName = "SchoolProjectDataSet"
        Me.SchoolProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblAdmissionTableAdapter
        '
        Me.TblAdmissionTableAdapter.ClearBeforeFill = True
        '
        'ViewAdmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1323, 608)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ViewAdmission"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewRecord"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAdmissionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SchoolProjectDataSet As SchoolManagementSystem_Project.SchoolProjectDataSet
    Friend WithEvents TblAdmissionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblAdmissionTableAdapter As SchoolManagementSystem_Project.SchoolProjectDataSetTableAdapters.tblAdmissionTableAdapter
    Friend WithEvents AdmissionNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FatherNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotherNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DoBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreSchoolNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
