<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManageCoffee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewCheckBoxColumn()
        btn_new = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridView1.Location = New Point(14, 14)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(905, 458)
        DataGridView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "CoffeeCode"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Description"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "SIZE"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "PRICE"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "STATUS"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' btn_new
        ' 
        btn_new.Location = New Point(832, 479)
        btn_new.Margin = New Padding(4, 3, 4, 3)
        btn_new.Name = "btn_new"
        btn_new.Size = New Size(88, 27)
        btn_new.TabIndex = 1
        btn_new.Text = "New"
        btn_new.UseVisualStyleBackColor = True
        ' 
        ' frmManageCoffee
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(933, 519)
        Controls.Add(btn_new)
        Controls.Add(DataGridView1)
        Margin = New Padding(4, 3, 4, 3)
        Name = "frmManageCoffee"
        Text = "Manage Coffee"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_new As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewCheckBoxColumn
End Class
