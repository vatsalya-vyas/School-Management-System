<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewFee
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
        Me.FeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdmissionNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayModeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblFeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolProjectDataSet = New SchoolManagementSystem_Project.SchoolProjectDataSet()
        Me.TblFeeTableAdapter = New SchoolManagementSystem_Project.SchoolProjectDataSetTableAdapters.tblFeeTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FeeIDDataGridViewTextBoxColumn, Me.AdmissionNoDataGridViewTextBoxColumn, Me.StudentNameDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.PayModeDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblFeeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 55)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1288, 537)
        Me.DataGridView1.TabIndex = 0
        '
        'FeeIDDataGridViewTextBoxColumn
        '
        Me.FeeIDDataGridViewTextBoxColumn.DataPropertyName = "FeeID"
        Me.FeeIDDataGridViewTextBoxColumn.HeaderText = "FeeID"
        Me.FeeIDDataGridViewTextBoxColumn.Name = "FeeIDDataGridViewTextBoxColumn"
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
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        '
        'PayModeDataGridViewTextBoxColumn
        '
        Me.PayModeDataGridViewTextBoxColumn.DataPropertyName = "PayMode"
        Me.PayModeDataGridViewTextBoxColumn.HeaderText = "PayMode"
        Me.PayModeDataGridViewTextBoxColumn.Name = "PayModeDataGridViewTextBoxColumn"
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'TblFeeBindingSource
        '
        Me.TblFeeBindingSource.DataMember = "tblFee"
        Me.TblFeeBindingSource.DataSource = Me.SchoolProjectDataSet
        '
        'SchoolProjectDataSet
        '
        Me.SchoolProjectDataSet.DataSetName = "SchoolProjectDataSet"
        Me.SchoolProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblFeeTableAdapter
        '
        Me.TblFeeTableAdapter.ClearBeforeFill = True
        '
        'ViewFee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 607)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ViewFee"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "showfee"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SchoolProjectDataSet As SchoolManagementSystem_Project.SchoolProjectDataSet
    Friend WithEvents TblFeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblFeeTableAdapter As SchoolManagementSystem_Project.SchoolProjectDataSetTableAdapters.tblFeeTableAdapter
    Friend WithEvents FeeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdmissionNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PayModeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
