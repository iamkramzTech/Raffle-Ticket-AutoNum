<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreview
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tblticketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbraffleDataSet = New RaffleTicketAutoNumber.dbraffleDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DbraffleDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblticketTableAdapter = New RaffleTicketAutoNumber.dbraffleDataSetTableAdapters.tblticketTableAdapter()
        CType(Me.tblticketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbraffleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DbraffleDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblticketBindingSource
        '
        Me.tblticketBindingSource.DataMember = "tblticket"
        Me.tblticketBindingSource.DataSource = Me.DbraffleDataSet
        '
        'DbraffleDataSet
        '
        Me.DbraffleDataSet.DataSetName = "dbraffleDataSet"
        Me.DbraffleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ReportViewer)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 372)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(311, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Developed by:  KRAMZ"
        '
        'ReportViewer
        '
        Me.ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.tblticketBindingSource
        Me.ReportViewer.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer.LocalReport.ReportEmbeddedResource = "RaffleTicketAutoNumber.Report.rdlc"
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(515, 372)
        Me.ReportViewer.TabIndex = 0
        '
        'DbraffleDataSetBindingSource
        '
        Me.DbraffleDataSetBindingSource.DataSource = Me.DbraffleDataSet
        Me.DbraffleDataSetBindingSource.Position = 0
        '
        'tblticketTableAdapter
        '
        Me.tblticketTableAdapter.ClearBeforeFill = True
        '
        'frmPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 397)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPreview"
        Me.Text = "Form3"
        CType(Me.tblticketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbraffleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DbraffleDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DbraffleDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbraffleDataSet As RaffleTicketAutoNumber.dbraffleDataSet
    Friend WithEvents tblticketTableAdapter As RaffleTicketAutoNumber.dbraffleDataSetTableAdapters.tblticketTableAdapter
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblticketBindingSource As System.Windows.Forms.BindingSource
End Class
