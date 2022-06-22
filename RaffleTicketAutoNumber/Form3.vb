Public Class frmPreview

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbraffleDataSet.tblticket' table. You can move, or remove it, as needed.
        Me.tblticketTableAdapter.Fill(Me.DbraffleDataSet.tblticket)
        viewTicket(ReportViewer)
        Me.ReportViewer.RefreshReport()

    End Sub

    Private Sub ReportViewer_ReportRefresh(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ReportViewer.ReportRefresh
        Me.tblticketTableAdapter.Fill(Me.DbraffleDataSet.tblticket)
        viewTicket(ReportViewer)
        Me.ReportViewer.RefreshReport()
    End Sub

    Private Sub ReportViewer_PageNavigation(sender As Object, e As Microsoft.Reporting.WinForms.PageNavigationEventArgs) Handles ReportViewer.PageNavigation

    End Sub
End Class