<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCancelOrder
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
        Column3 = New DataGridViewButtonColumn()
        txt_search = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridView1.Location = New Point(14, 47)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(905, 458)
        DataGridView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "OrderNo"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Total Price"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Action"
        Column3.Name = "Column3"
        Column3.Text = ""
        ' 
        ' txt_search
        ' 
        txt_search.Location = New Point(14, 14)
        txt_search.Margin = New Padding(4, 3, 4, 3)
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(905, 23)
        txt_search.TabIndex = 1
        ' 
        ' frmCancelOrder
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(933, 519)
        Controls.Add(txt_search)
        Controls.Add(DataGridView1)
        Margin = New Padding(4, 3, 4, 3)
        Name = "frmCancelOrder"
        Text = "Cancel Order"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewButtonColumn
End Class
