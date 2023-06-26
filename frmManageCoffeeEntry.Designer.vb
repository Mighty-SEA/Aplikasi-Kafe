<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManageCoffeeEntry
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
        btn_Browse = New Button()
        txt_Coffeename = New TextBox()
        txt_coffeeCode = New TextBox()
        Pic_Coffeeimg = New PictureBox()
        Combo_size = New ComboBox()
        Check_Status = New CheckBox()
        Btn_Save = New Button()
        Btn_Edit = New Button()
        btn_Delete = New Button()
        txt_price = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(Pic_Coffeeimg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_Browse
        ' 
        btn_Browse.Location = New Point(9, 185)
        btn_Browse.Margin = New Padding(4, 3, 4, 3)
        btn_Browse.Name = "btn_Browse"
        btn_Browse.Size = New Size(147, 27)
        btn_Browse.TabIndex = 0
        btn_Browse.Text = "Browse"
        btn_Browse.UseVisualStyleBackColor = True
        ' 
        ' txt_Coffeename
        ' 
        txt_Coffeename.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        txt_Coffeename.Location = New Point(272, 47)
        txt_Coffeename.Margin = New Padding(4, 3, 4, 3)
        txt_Coffeename.Name = "txt_Coffeename"
        txt_Coffeename.Size = New Size(194, 29)
        txt_Coffeename.TabIndex = 1
        ' 
        ' txt_coffeeCode
        ' 
        txt_coffeeCode.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        txt_coffeeCode.Location = New Point(272, 12)
        txt_coffeeCode.Margin = New Padding(4, 3, 4, 3)
        txt_coffeeCode.Name = "txt_coffeeCode"
        txt_coffeeCode.Size = New Size(194, 29)
        txt_coffeeCode.TabIndex = 2
        ' 
        ' Pic_Coffeeimg
        ' 
        Pic_Coffeeimg.Location = New Point(8, 12)
        Pic_Coffeeimg.Margin = New Padding(4, 3, 4, 3)
        Pic_Coffeeimg.Name = "Pic_Coffeeimg"
        Pic_Coffeeimg.Size = New Size(148, 156)
        Pic_Coffeeimg.SizeMode = PictureBoxSizeMode.StretchImage
        Pic_Coffeeimg.TabIndex = 3
        Pic_Coffeeimg.TabStop = False
        ' 
        ' Combo_size
        ' 
        Combo_size.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Combo_size.FormattingEnabled = True
        Combo_size.Items.AddRange(New Object() {"SMALL", "MEDIUM", "BIG"})
        Combo_size.Location = New Point(272, 83)
        Combo_size.Margin = New Padding(4, 3, 4, 3)
        Combo_size.Name = "Combo_size"
        Combo_size.Size = New Size(194, 29)
        Combo_size.TabIndex = 5
        ' 
        ' Check_Status
        ' 
        Check_Status.AutoSize = True
        Check_Status.Location = New Point(187, 160)
        Check_Status.Margin = New Padding(4, 3, 4, 3)
        Check_Status.Name = "Check_Status"
        Check_Status.Size = New Size(71, 19)
        Check_Status.TabIndex = 6
        Check_Status.Text = "Tersedia "
        Check_Status.UseVisualStyleBackColor = True
        ' 
        ' Btn_Save
        ' 
        Btn_Save.Location = New Point(379, 185)
        Btn_Save.Margin = New Padding(4, 3, 4, 3)
        Btn_Save.Name = "Btn_Save"
        Btn_Save.Size = New Size(88, 27)
        Btn_Save.TabIndex = 7
        Btn_Save.Text = "Save"
        Btn_Save.UseVisualStyleBackColor = True
        ' 
        ' Btn_Edit
        ' 
        Btn_Edit.Location = New Point(187, 185)
        Btn_Edit.Margin = New Padding(4, 3, 4, 3)
        Btn_Edit.Name = "Btn_Edit"
        Btn_Edit.Size = New Size(88, 27)
        Btn_Edit.TabIndex = 8
        Btn_Edit.Text = "Edit"
        Btn_Edit.UseVisualStyleBackColor = True
        ' 
        ' btn_Delete
        ' 
        btn_Delete.Location = New Point(283, 185)
        btn_Delete.Margin = New Padding(4, 3, 4, 3)
        btn_Delete.Name = "btn_Delete"
        btn_Delete.Size = New Size(88, 27)
        btn_Delete.TabIndex = 9
        btn_Delete.Text = "Delete"
        btn_Delete.UseVisualStyleBackColor = True
        ' 
        ' txt_price
        ' 
        txt_price.AcceptsTab = True
        txt_price.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        txt_price.Location = New Point(272, 119)
        txt_price.Margin = New Padding(4, 3, 4, 3)
        txt_price.Name = "txt_price"
        txt_price.Size = New Size(194, 29)
        txt_price.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(185, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 21)
        Label1.TabIndex = 10
        Label1.Text = "Kode Kopi"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(185, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 21)
        Label2.TabIndex = 10
        Label2.Text = "Nama Kopi"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(185, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 21)
        Label3.TabIndex = 10
        Label3.Text = "Ukuran"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(185, 122)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 21)
        Label4.TabIndex = 10
        Label4.Text = "Harga"
        ' 
        ' frmManageCoffeeEntry
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(485, 221)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_Delete)
        Controls.Add(Btn_Edit)
        Controls.Add(Btn_Save)
        Controls.Add(Check_Status)
        Controls.Add(Combo_size)
        Controls.Add(Pic_Coffeeimg)
        Controls.Add(txt_price)
        Controls.Add(txt_coffeeCode)
        Controls.Add(txt_Coffeename)
        Controls.Add(btn_Browse)
        Margin = New Padding(4, 3, 4, 3)
        Name = "frmManageCoffeeEntry"
        Text = "Manage Coffee Entry"
        CType(Pic_Coffeeimg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_Browse As Button
    Friend WithEvents txt_Coffeename As TextBox
    Friend WithEvents txt_coffeeCode As TextBox
    Friend WithEvents Pic_Coffeeimg As PictureBox
    Friend WithEvents Combo_size As ComboBox
    Friend WithEvents Check_Status As CheckBox
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
