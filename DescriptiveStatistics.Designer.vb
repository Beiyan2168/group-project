<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DescriptiveStatistics
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
        Me.RTBDescriptiveStatistics = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RTBDescriptiveStatistics
        '
        Me.RTBDescriptiveStatistics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTBDescriptiveStatistics.Location = New System.Drawing.Point(0, 0)
        Me.RTBDescriptiveStatistics.Name = "RTBDescriptiveStatistics"
        Me.RTBDescriptiveStatistics.Size = New System.Drawing.Size(670, 291)
        Me.RTBDescriptiveStatistics.TabIndex = 1
        Me.RTBDescriptiveStatistics.Text = ""
        '
        'DescriptiveStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 291)
        Me.Controls.Add(Me.RTBDescriptiveStatistics)
        Me.Name = "DescriptiveStatistics"
        Me.Text = "DescriptiveStatistics"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RTBDescriptiveStatistics As System.Windows.Forms.RichTextBox
End Class
