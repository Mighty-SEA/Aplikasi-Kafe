Imports System.Data.OleDb
Imports System.IO
Public Class frmReport
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\coffee.accdb")
    Dim dr As OleDbDataReader
    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadReport()
    End Sub
    Sub loadReport()

        Try
            conn.Open()
            Dim ds As New DataSet1
            Dim da As New OleDb.OleDbDataAdapter

            da.SelectCommand = New OleDbCommand("select * from OrderMaster", conn)
            da.SelectCommand.Parameters.Clear()
            da.Fill(ds, "DataTable1")

            Dim rpt As New CrystalReport1
            rpt.Load(Application.StartupPath & "\CrystalReport1.rpt")
            rpt.SetDataSource(ds.Tables("DataTable1"))

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.RefreshReport()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Btn_Filter_Click(sender As Object, e As EventArgs) Handles Btn_Filter.Click



        Try
            conn.Open()
            Dim ds As New DataSet1
            Dim da As New OleDb.OleDbDataAdapter

            da.SelectCommand = New OleDbCommand("select * from OrderMaster where orderdate between '" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "' and '" & DateTimePicker2.Value.ToString("dd/MM/yyyy") & "'", conn)
            da.SelectCommand.Parameters.Clear()
            da.Fill(ds, "DataTable1")

            Dim rpt As New CrystalReport1
            rpt.Load(Application.StartupPath & "\CrystalReport1.rpt")
            rpt.SetDataSource(ds.Tables("DataTable1"))

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.RefreshReport()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
End Class