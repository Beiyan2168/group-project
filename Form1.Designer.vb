<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Graphs = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Line = New System.Windows.Forms.ToolStripMenuItem()
        Me.Descriptive_Statistics = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGV_employed = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DGV_employed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Open, Me.DeleteToolStripMenuItem, Me.Graphs, Me.Descriptive_Statistics, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(714, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Open
        '
        Me.Open.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Open.ForeColor = System.Drawing.Color.Black
        Me.Open.Name = "Open"
        Me.Open.Size = New System.Drawing.Size(48, 19)
        Me.Open.Text = "Open"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(52, 19)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Graphs
        '
        Me.Graphs.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bar, Me.Line})
        Me.Graphs.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graphs.Name = "Graphs"
        Me.Graphs.Size = New System.Drawing.Size(57, 19)
        Me.Graphs.Text = "Graphs"
        '
        'Bar
        '
        Me.Bar.Image = CType(resources.GetObject("Bar.Image"), System.Drawing.Image)
        Me.Bar.Name = "Bar"
        Me.Bar.Size = New System.Drawing.Size(97, 22)
        Me.Bar.Text = "Bar"
        '
        'Line
        '
        Me.Line.Image = CType(resources.GetObject("Line.Image"), System.Drawing.Image)
        Me.Line.Name = "Line"
        Me.Line.Size = New System.Drawing.Size(97, 22)
        Me.Line.Text = "Line"
        '
        'Descriptive_Statistics
        '
        Me.Descriptive_Statistics.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descriptive_Statistics.Name = "Descriptive_Statistics"
        Me.Descriptive_Statistics.Size = New System.Drawing.Size(132, 19)
        Me.Descriptive_Statistics.Text = "Descriptive Statistics"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 19)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DGV_employed
        '
        Me.DGV_employed.BackgroundColor = System.Drawing.Color.White
        Me.DGV_employed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_employed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_employed.Location = New System.Drawing.Point(0, 25)
        Me.DGV_employed.Name = "DGV_employed"
        Me.DGV_employed.Size = New System.Drawing.Size(714, 316)
        Me.DGV_employed.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 341)
        Me.Controls.Add(Me.DGV_employed)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Employed Persons Working Less Than 30 Hours"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DGV_employed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Open As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Graphs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Line As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Descriptive_Statistics As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DGV_employed As System.Windows.Forms.DataGridView

End Class
