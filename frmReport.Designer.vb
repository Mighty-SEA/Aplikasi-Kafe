<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReport
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
        Btn_Filter = New Button()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Btn_Filter
        ' 
        Btn_Filter.Location = New Point(810, 14)
        Btn_Filter.Margin = New Padding(4, 3, 4, 3)
        Btn_Filter.Name = "Btn_Filter"
        Btn_Filter.Size = New Size(110, 27)
        Btn_Filter.TabIndex = 1
        Btn_Filter.Text = "Filter"
        Btn_Filter.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(14, 14)
        DateTimePicker1.Margin = New Padding(4, 3, 4, 3)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(233, 23)
        DateTimePicker1.TabIndex = 2
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(254, 14)
        DateTimePicker2.Margin = New Padding(4, 3, 4, 3)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(233, 23)
        DateTimePicker2.TabIndex = 3
        ' 
        ' frmReport
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(933, 519)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Btn_Filter)
        Margin = New Padding(4, 3, 4, 3)
        Name = "frmReport"
        Text = "Report"
        ResumeLayout(False)
    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Btn_Filter As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker

End Class
