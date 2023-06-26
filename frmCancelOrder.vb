Imports System.Data.OleDb
Imports System.IO
Public Class frmCancelOrder
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\coffee.accdb")
    Dim dr As OleDbDataReader
    Dim i As Integer

    Dim btncategory As New Button
    Private Sub frmCancelOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        orderload()
    End Sub

    Sub orderload()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("SELECT sum(`price`) as `price`,`orderno` FROM OrderMaster group by orderno", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("orderno"), dr.Item("price"))

            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("SELECT sum(`price`) as `price`,`orderno` FROM OrderMaster where orderno like '%" & txt_search.Text & "%' group by orderno ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("orderno"), dr.Item("price"))

            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If MsgBox("Are You Sure Cancel this Order", MsgBoxStyle.Information + vbYesNo) = vbYes Then
            Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
            If colname = "Column2" Then
                conn.Open()
                Dim cmd As New OleDb.OleDbCommand("DELETE FROM `OrderMaster` WHERE orderno=@orderno", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@orderno", DataGridView1.CurrentRow.Cells(0).Value.ToString)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Order Cancel Successfully")

                End If
            End If
            conn.Close()
        Else
            Return
        End If
        orderload()
    End Sub
End Class
