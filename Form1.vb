Imports System.Data.OleDb
Imports System.IO
Public Class Form1
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\coffee.accdb")
    Dim dr As OleDbDataReader
    Dim i As Integer
    Dim _filter As String = ""

    Dim overtotal As Decimal

    Private WithEvents pic As New PictureBox
    Private WithEvents lbldesc As New Label
    Private WithEvents lblprice As New Label

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_OrderDate.Text = Date.Now.ToString("dd/MM/yyyy")
        lbl_orderno.Text = getorderno()
        imageload()
    End Sub

    Function getorderno() As String
        Try
            Dim sdate As String = Now.ToString("yyyy")
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("select * from OrderMaster where orderno like '" & sdate & "%' order by id desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                getorderno = CLng(dr.Item("orderno").ToString) + 1
            Else
                getorderno = sdate & "0001"
            End If

            conn.Close()

        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Function

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        If MessageBox.Show("Are You Sure Exit", "CMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            End
        Else
            Return
        End If
    End Sub

    Private Sub btn_ManageCoffee_Click(sender As Object, e As EventArgs) Handles btn_ManageCoffee.Click
        frmManageCoffee.ShowDialog()
    End Sub

    Sub imageload()
        conn.Open()
        Dim cmd As New OleDb.OleDbCommand("SELECT `img`,`coffeecode`,`coffeename`,`size`,`price`,`status` FROM coffeeMaster", conn)
        dr = cmd.ExecuteReader
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Clear()

        While dr.Read
            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)


            Dim array(CInt(len)) As Byte
            dr.GetBytes(0, 0, array, 0, CInt(len))

            pic = New PictureBox
            pic.Width = 120
            pic.Height = 150
            pic.BackgroundImageLayout = ImageLayout.Stretch
            pic.Tag = dr.Item("coffeecode").ToString


            lbldesc = New Label
            lbldesc.ForeColor = Color.White
            lbldesc.BackColor = Color.DodgerBlue
            lbldesc.TextAlign = ContentAlignment.MiddleCenter
            lbldesc.Dock = DockStyle.Top
            lbldesc.Font = New Font("Segoe UI", 8, FontStyle.Bold)
            lbldesc.Tag = dr.Item("coffeecode").ToString


            lblprice = New Label
            lblprice.ForeColor = Color.White
            lblprice.BackColor = Color.DarkOrange
            lblprice.Dock = DockStyle.Bottom
            lblprice.TextAlign = ContentAlignment.MiddleCenter
            lblprice.AutoSize = False
            lblprice.Font = New Font("Segoe UI", 12, FontStyle.Bold)
            lblprice.Tag = dr.Item("coffeecode").ToString


            Dim ms As New System.IO.MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)
            pic.BackgroundImage = bitmap
            lbldesc.Text = dr.Item("coffeename").ToString
            lblprice.Text = dr.Item("price").ToString

            pic.Controls.Add(lbldesc)
            pic.Controls.Add(lblprice)
            FlowLayoutPanel1.Controls.Add(pic)

            AddHandler pic.Click, AddressOf Selectimg_Click
            AddHandler lbldesc.Click, AddressOf Selectimg_Click
            AddHandler lblprice.Click, AddressOf Selectimg_Click

        End While
        dr.Dispose()
        conn.Close()
    End Sub

    Public Sub Selectimg_Click(sender As Object, e As EventArgs)
        conn.Open()
        Dim cmd As New OleDb.OleDbCommand("select * from coffeeMaster where coffeecode like '" & sender.tag.ToString & "%' ", conn)
        dr = cmd.ExecuteReader
        While dr.Read = True
            DataGridView1.Rows.Add(New String() {DataGridView1.Rows.Count + 1, dr.Item("coffeecode").ToString, dr.Item("coffeename").ToString, dr.Item("price"), 1})
        End While

        conn.Close()

    End Sub
    Sub QtyValidate()

    End Sub

    Sub overalltotal()
        Dim i As Decimal
        Dim sum As Decimal = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            sum += DataGridView1.Rows(i).Cells(3).Value * DataGridView1.Rows(i).Cells(4).Value
        Next
        lbl_total.Text = CDec(sum)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        overalltotal()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        conn.Open()
        Dim cmd As New OleDb.OleDbCommand("SELECT `img`,`coffeecode`,`coffeename`,`size`,`price`,`status` FROM coffeeMaster Where coffeecode like '%" & txt_search.Text & "%' or coffeename like '%" & txt_search.Text & "%'", conn)
        dr = cmd.ExecuteReader
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Clear()

        While dr.Read
            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)


            Dim array(CInt(len)) As Byte
            dr.GetBytes(0, 0, array, 0, CInt(len))

            pic = New PictureBox
            pic.Width = 120
            pic.Height = 150
            pic.BackgroundImageLayout = ImageLayout.Stretch
            pic.Tag = dr.Item("coffeecode").ToString


            lbldesc = New Label
            lbldesc.ForeColor = Color.White
            lbldesc.BackColor = Color.DodgerBlue
            lbldesc.TextAlign = ContentAlignment.MiddleCenter
            lbldesc.Dock = DockStyle.Top
            lbldesc.Font = New Font("Segoe UI", 8, FontStyle.Bold)
            lbldesc.Tag = dr.Item("coffeecode").ToString


            lblprice = New Label
            lblprice.ForeColor = Color.White
            lblprice.BackColor = Color.DarkOrange
            lblprice.Dock = DockStyle.Bottom
            lblprice.TextAlign = ContentAlignment.MiddleCenter
            lblprice.AutoSize = False
            lblprice.Font = New Font("Segoe UI", 12, FontStyle.Bold)
            lblprice.Tag = dr.Item("coffeecode").ToString


            Dim ms As New System.IO.MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)
            pic.BackgroundImage = bitmap
            lbldesc.Text = dr.Item("coffeename").ToString
            lblprice.Text = dr.Item("price").ToString

            pic.Controls.Add(lbldesc)
            pic.Controls.Add(lblprice)
            FlowLayoutPanel1.Controls.Add(pic)

            AddHandler pic.Click, AddressOf Selectimg_Click
            AddHandler lbldesc.Click, AddressOf Selectimg_Click
            AddHandler lblprice.Click, AddressOf Selectimg_Click

        End While
        dr.Dispose()
        conn.Close()
    End Sub

    Sub clear()
        lbl_orderno.Text = getorderno()
        DataGridView1.Rows.Clear()
        lbl_total.Text = "000.00"

    End Sub
    Private Sub Btn_Pay_Click(sender As Object, e As EventArgs) Handles Btn_Pay.Click
        Try
            conn.Open()
            For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                Dim cmd As New OleDb.OleDbCommand("INSERT INTO `OrderMaster`(`orderno`, `orderdate`, `coffeecode`, `coffeename`, `price`, `qty`, `total`) VALUES (@orderno,@orderdate,@coffeecode,@coffeename,@price,@qty,@total)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@orderno", lbl_orderno.Text)
                cmd.Parameters.AddWithValue("@orderdate", lbl_OrderDate.Text)
                cmd.Parameters.AddWithValue("@coffeecode", DataGridView1.Rows(j).Cells(1).Value.ToString)
                cmd.Parameters.AddWithValue("@coffeename", DataGridView1.Rows(j).Cells(2).Value.ToString)
                cmd.Parameters.AddWithValue("@price", DataGridView1.Rows(j).Cells(3).Value.ToString)
                cmd.Parameters.AddWithValue("@qty", CDec(DataGridView1.Rows(j).Cells(4).Value.ToString))
                cmd.Parameters.AddWithValue("@total", lbl_total.Text)

                i = cmd.ExecuteNonQuery
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        frmBilling.Show()
        clear()

    End Sub

    Private Sub Btn_NewOrder_Click(sender As Object, e As EventArgs) Handles Btn_NewOrder.Click
        clear()
    End Sub

    Private Sub Btn_CancelOrder_Click(sender As Object, e As EventArgs) Handles Btn_CancelOrder.Click
        frmCancelOrder.Show()
    End Sub



    Private Sub Btn_report_Click(sender As Object, e As EventArgs) Handles Btn_report.Click
        frmReport.Show()
    End Sub
End Class