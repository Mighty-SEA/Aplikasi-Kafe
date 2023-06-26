<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Btn_Exit = New Button()
        btn_ManageCoffee = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        txt_search = New TextBox()
        lbl_OrderDate = New Label()
        lbl_orderno = New Label()
        DataGridView1 = New DataGridView()
        Column5 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Btn_Pay = New Button()
        Btn_NewOrder = New Button()
        Btn_CancelOrder = New Button()
        Btn_report = New Button()
        Timer1 = New Timer(components)
        lbl_total = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Btn_Exit
        ' 
        Btn_Exit.Location = New Point(14, 14)
        Btn_Exit.Margin = New Padding(4, 3, 4, 3)
        Btn_Exit.Name = "Btn_Exit"
        Btn_Exit.Size = New Size(88, 27)
        Btn_Exit.TabIndex = 0
        Btn_Exit.Text = "Exit"
        Btn_Exit.UseVisualStyleBackColor = True
        ' 
        ' btn_ManageCoffee
        ' 
        btn_ManageCoffee.Location = New Point(14, 47)
        btn_ManageCoffee.Margin = New Padding(4, 3, 4, 3)
        btn_ManageCoffee.Name = "btn_ManageCoffee"
        btn_ManageCoffee.Size = New Size(115, 27)
        btn_ManageCoffee.TabIndex = 1
        btn_ManageCoffee.Text = "Manage Coffee"
        btn_ManageCoffee.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Location = New Point(14, 81)
        FlowLayoutPanel1.Margin = New Padding(4, 3, 4, 3)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(373, 540)
        FlowLayoutPanel1.TabIndex = 2
        ' 
        ' txt_search
        ' 
        txt_search.Location = New Point(138, 51)
        txt_search.Margin = New Padding(4, 3, 4, 3)
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(249, 23)
        txt_search.TabIndex = 3
        ' 
        ' lbl_OrderDate
        ' 
        lbl_OrderDate.AutoSize = True
        lbl_OrderDate.Location = New Point(394, 14)
        lbl_OrderDate.Margin = New Padding(4, 0, 4, 0)
        lbl_OrderDate.Name = "lbl_OrderDate"
        lbl_OrderDate.Size = New Size(67, 15)
        lbl_OrderDate.TabIndex = 4
        lbl_OrderDate.Text = "Order Date:"
        ' 
        ' lbl_orderno
        ' 
        lbl_orderno.AutoSize = True
        lbl_orderno.Location = New Point(394, 47)
        lbl_orderno.Margin = New Padding(4, 0, 4, 0)
        lbl_orderno.Name = "lbl_orderno"
        lbl_orderno.Size = New Size(62, 15)
        lbl_orderno.TabIndex = 5
        lbl_orderno.Text = "Order No.:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column5, Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(398, 81)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(467, 366)
        DataGridView1.TabIndex = 6
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Column5.HeaderText = "#"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 39
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Coffee Code"
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
        Column3.HeaderText = "Price"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Qty"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Btn_Pay
        ' 
        Btn_Pay.Location = New Point(777, 453)
        Btn_Pay.Margin = New Padding(4, 3, 4, 3)
        Btn_Pay.Name = "Btn_Pay"
        Btn_Pay.Size = New Size(88, 27)
        Btn_Pay.TabIndex = 7
        Btn_Pay.Text = "Pay"
        Btn_Pay.UseVisualStyleBackColor = True
        ' 
        ' Btn_NewOrder
        ' 
        Btn_NewOrder.Location = New Point(682, 453)
        Btn_NewOrder.Margin = New Padding(4, 3, 4, 3)
        Btn_NewOrder.Name = "Btn_NewOrder"
        Btn_NewOrder.Size = New Size(88, 27)
        Btn_NewOrder.TabIndex = 8
        Btn_NewOrder.Text = "New Order"
        Btn_NewOrder.UseVisualStyleBackColor = True
        ' 
        ' Btn_CancelOrder
        ' 
        Btn_CancelOrder.Location = New Point(544, 453)
        Btn_CancelOrder.Margin = New Padding(4, 3, 4, 3)
        Btn_CancelOrder.Name = "Btn_CancelOrder"
        Btn_CancelOrder.Size = New Size(132, 27)
        Btn_CancelOrder.TabIndex = 9
        Btn_CancelOrder.Text = "Cancel Order"
        Btn_CancelOrder.UseVisualStyleBackColor = True
        ' 
        ' Btn_report
        ' 
        Btn_report.Location = New Point(447, 453)
        Btn_report.Margin = New Padding(4, 3, 4, 3)
        Btn_report.Name = "Btn_report"
        Btn_report.Size = New Size(90, 27)
        Btn_report.TabIndex = 10
        Btn_report.Text = "Report"
        Btn_report.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' lbl_total
        ' 
        lbl_total.AutoSize = True
        lbl_total.Location = New Point(776, 428)
        lbl_total.Margin = New Padding(4, 0, 4, 0)
        lbl_total.Name = "lbl_total"
        lbl_total.Size = New Size(38, 15)
        lbl_total.TabIndex = 11
        lbl_total.Text = "Total: "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(878, 635)
        Controls.Add(lbl_total)
        Controls.Add(Btn_report)
        Controls.Add(Btn_CancelOrder)
        Controls.Add(Btn_NewOrder)
        Controls.Add(Btn_Pay)
        Controls.Add(DataGridView1)
        Controls.Add(lbl_orderno)
        Controls.Add(lbl_OrderDate)
        Controls.Add(txt_search)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(btn_ManageCoffee)
        Controls.Add(Btn_Exit)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btn_Exit As Button
    Friend WithEvents btn_ManageCoffee As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents txt_search As TextBox
    Friend WithEvents lbl_OrderDate As Label
    Friend WithEvents lbl_orderno As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Btn_Pay As Button
    Friend WithEvents Btn_NewOrder As Button
    Friend WithEvents Btn_CancelOrder As Button
    Friend WithEvents Btn_report As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_total As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
