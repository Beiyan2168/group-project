'import data from excel
Imports System.Data.OleDb
Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'show the form in center
        Me.CenterToScreen()
    End Sub
    Dim myconnection As OleDbConnection
    Dim dataset As DataSet
    Dim mycommand As OleDbDataAdapter

    Private Sub Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Open.Click
        'open excel file
        Dim op As New OpenFileDialog
        Dim path As String

        Try
            op.Filter = " MS EXCEL (*.xls)|*.xls"
            If op.ShowDialog = Windows.Forms.DialogResult.OK Then
                path = op.FileName
                myconnection = New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & path & ";Extended Properties=Excel 8.0")
                mycommand = New OleDbDataAdapter("select * from [bptms_Employed_less_than_30_hou$]", myconnection)
                mycommand.TableMappings.Add("Table", "sanmno")
                dataset = New DataSet
                mycommand.Fill(dataset)
                DGV_employed.DataSource = dataset.Tables(0)
                DGV_employed.Refresh()
                myconnection.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


        'styles and formatting
        With DGV_employed
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        End With

        DGV_employed.GridColor = Color.Black
        DGV_employed.CellBorderStyle = DataGridViewCellBorderStyle.None
        DGV_employed.BackgroundColor = Color.Gray

        DGV_employed.DefaultCellStyle.SelectionBackColor = Color.Pink
        DGV_employed.DefaultCellStyle.SelectionForeColor = Color.Black

        DGV_employed.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]

        DGV_employed.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV_employed.AllowUserToResizeColumns = False

        DGV_employed.RowsDefaultCellStyle.BackColor = Color.MintCream
        DGV_employed.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub

    Private Sub Bar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bar.Click
        'bar graph
        Graph1.Show()
        Dim Year() As Single = {1982, 1983, 1984, 1985, 1986, 1987, 1988, 1989, 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998, 1999, 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016}
        Dim total() As Double = {401.9, 520.9, 661.6, 696.5, 789.5, 750.6, 860.6, 665.6, 599.1, 0, 515, 653.3, 0, 482.4, 556.8, 509.8, 486.9, 464.7, 491.4, 525, 516.7, 529, 599.3, 484.4, 471.9, 511.3, 470.7, 478.7, 503, 520.6, 589.3, 645.8, 534.8, 580.3, 502.8}
        Graph1.Chart1.Series("Year").Points.DataBindXY(Year, total)
    End Sub

    Private Sub Line_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Line.Click
        'line graph
        Graph2.Show()
        Dim Year() As Single = {1982, 1983, 1984, 1985, 1986, 1987, 1988, 1989, 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998, 1999, 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016}
        Dim total() As Double = {401.9, 520.9, 661.6, 696.5, 789.5, 750.6, 860.6, 665.6, 599.1, 0, 515, 653.3, 0, 482.4, 556.8, 509.8, 486.9, 464.7, 491.4, 525, 516.7, 529, 599.3, 484.4, 471.9, 511.3, 470.7, 478.7, 503, 520.6, 589.3, 645.8, 534.8, 580.3, 502.8}
        Graph2.Chart1.Series("Year").Points.DataBindXY(Year, total)
    End Sub
    Private Sub Descriptive_Statistics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Descriptive_Statistics.Click
        DescriptiveStatistics.Show()
        'calculate the population(count)
        Dim count As Integer = 0
        For Year As Single = 1982 To 2016
            count = count + 1
        Next

        'calculate the total employer
        Dim total_employer As Double
        Dim total() As Double = {401.9, 520.9, 661.6, 696.5, 789.5, 750.6, 860.6, 665.6, 599.1, 0, 515, 653.3, 0, 482.4, 556.8, 509.8, 486.9, 464.7, 491.4, 525, 516.7, 529, 599.3, 484.4, 471.9, 511.3, 470.7, 478.7, 503, 520.6, 589.3, 645.8, 534.8, 580.3, 502.8}
        Dim i As Double
        For Each i In total
            total_employer = i + total_employer
        Next i

        Dim mean As Double
        mean = total_employer / count

        Dim variance As Double
        'let x^2=x
        Dim x As Double
        For Each i In total
            x = i ^ 2 + x
        Next i
        variance = (x / count) - (mean ^ 2)

        Dim standard_deviation As Double
        standard_deviation = System.Math.Sqrt(variance)

        With DescriptiveStatistics
            .RTBDescriptiveStatistics.AppendText(" Descriptive Statistics ")
            '.RTBDescriptiveStatistics.SelectionAlignment = HorizontalAlignment.Center
            .RTBDescriptiveStatistics.AppendText(vbNewLine)
            .RTBDescriptiveStatistics.AppendText(" The Mean is = " & mean)
            .RTBDescriptiveStatistics.AppendText(vbNewLine)
            .RTBDescriptiveStatistics.AppendText(vbNewLine)
            .RTBDescriptiveStatistics.AppendText(vbNewLine)
            .RTBDescriptiveStatistics.AppendText(" The Variance is = " & variance)
            .RTBDescriptiveStatistics.AppendText(vbNewLine)
            .RTBDescriptiveStatistics.AppendText(vbNewLine)
            .RTBDescriptiveStatistics.AppendText(vbNewLine)
            .RTBDescriptiveStatistics.AppendText(" The Standard Deviaiton is = " & standard_deviation)
            .RTBDescriptiveStatistics.AppendText(vbNewLine)
            .RTBDescriptiveStatistics.AppendText(vbNewLine)
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'exit the program
        If (MessageBox.Show("Are u sure Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        'delete or cleaning the data
        DGV_employed.Rows.Remove(DGV_employed.SelectedRows(0))
    End Sub
End Class