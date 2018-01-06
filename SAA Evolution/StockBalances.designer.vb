<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockBalances
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ItemBalancesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SAAEvoDataset = New SAA_Evolution.SAAEvoDataset()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ItemBalancesTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.ItemBalancesTableAdapter()
        CType(Me.ItemBalancesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemBalancesBindingSource
        '
        Me.ItemBalancesBindingSource.DataMember = "ItemBalances"
        Me.ItemBalancesBindingSource.DataSource = Me.SAAEvoDataset
        '
        'SAAEvoDataset
        '
        Me.SAAEvoDataset.DataSetName = "SAAEvoDataset"
        Me.SAAEvoDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ItemBalancesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SAA_Evolution.StockBalances.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(676, 395)
        Me.ReportViewer1.TabIndex = 0
        '
        'ItemBalancesTableAdapter
        '
        Me.ItemBalancesTableAdapter.ClearBeforeFill = True
        '
        'StockBalances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 395)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "StockBalances"
        Me.Text = "Stock Balances"
        CType(Me.ItemBalancesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ItemBalancesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SAAEvoDataset As SAA_Evolution.SAAEvoDataset
    Friend WithEvents ItemBalancesTableAdapter As SAA_Evolution.SAAEvoDatasetTableAdapters.ItemBalancesTableAdapter

End Class
