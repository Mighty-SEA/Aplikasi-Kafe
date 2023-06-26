Imports System.Data.OleDb
Imports System.IO
Public Class frmManageCoffeeEntry
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\coffee.accdb")
    Private Sub frmManageCoffeeEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btn_Browse_Click(sender As Object, e As EventArgs) Handles btn_Browse.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Pic_Coffeeimg.Image = Image.FromFile(pop.FileName)
        End If
    End Sub
    Sub clear()
        txt_coffeeCode.Clear()
        txt_Coffeename.Clear()
        txt_price.Clear()
        Combo_size.Text = ""
        Check_Status.Checked = False
        Pic_Coffeeimg.Image = Nothing
    End Sub
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        save()
    End Sub
    Sub save()
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("insert into coffeeMaster(`coffeecode`,`coffeename`,`size`,`price`,`status`,`img`) values (@coffeecode,@coffeename,@size,@price,@status,@img)", conn)
            Dim i As New Integer
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@coffeecode", txt_coffeeCode.Text)
            cmd.Parameters.AddWithValue("@coffeename", txt_Coffeename.Text)
            cmd.Parameters.AddWithValue("@size", Combo_size.Text)
            cmd.Parameters.AddWithValue("@price", txt_price.Text)
            cmd.Parameters.AddWithValue("@status", CBool(Check_Status.Checked.ToString))
            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            Pic_Coffeeimg.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@img", picture)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Coffee Register Success !", vbInformation)
            Else
                MsgBox("New Coffee Register Failed !", vbCritical)
            End If

            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        frmManageCoffee.DGV_load()
        Form1.imageload()
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        edit()
    End Sub
    Sub edit()
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("UPDATE `coffeeMaster` SET `coffeename`=@coffeename,`size`=@size,`price`=@price,`status`=@status,`img`=@img WHERE `coffeecode`=@coffeecode", conn)
            Dim i As New Integer
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@coffeename", txt_Coffeename.Text)
            cmd.Parameters.AddWithValue("@size", Combo_size.Text)
            cmd.Parameters.AddWithValue("@price", txt_price.Text)
            cmd.Parameters.AddWithValue("@status", CBool(Check_Status.Checked.ToString))

            'image convert to binary format

            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            Pic_Coffeeimg.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@img", picture)
            cmd.Parameters.AddWithValue("@coffeecode", txt_coffeeCode.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Coffee Update Success !", vbInformation)
            Else
                MsgBox("New Coffee Update Failed !", vbCritical)
            End If

            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        frmManageCoffee.DGV_load()
        Form1.imageload()
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        DELETE()
    End Sub
    Sub DELETE()

        If MsgBox("Are you Sure Delete This Record !", vbQuestion + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New OleDb.OleDbCommand("DELETE FROM `coffeeMaster` WHERE `coffeecode`=@coffeecode", conn)
                Dim i As New Integer
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@coffeecode", txt_coffeeCode.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Coffee Deleted Successfully !", vbInformation)
                Else
                    MsgBox("Coffee Deleted Failed !", vbCritical)
                End If

                Me.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            frmManageCoffee.DGV_load()
            Form1.imageload()
        End If
    End Sub
    Private Sub txt_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_price.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class