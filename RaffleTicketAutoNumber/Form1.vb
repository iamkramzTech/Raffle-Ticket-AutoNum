Public Class MainForm

    Dim Form4 As Object

    Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click
        'execute series of statement frmGenerateTicket to display 
        'inside PanelContent located on MainForm 

        'start With statement
        With frmGenerateTicket
            .TopLevel = False
            PanelContent.Controls.Add(frmGenerateTicket)
            .BringToFront()
            .Show()
        End With
        'End With statement
    End Sub

    Private Sub btnPrintpreview_Click(sender As Object, e As EventArgs) Handles btnPrintpreview.Click
        'execute series of statement frmGenerateTicket to display 
        'inside PanelContent located on MainForm 

        'start With statement
        With frmPreview
            .TopLevel = False
            PanelContent.Controls.Add(frmPreview)
            .BringToFront()
            .Show()
        End With
        'End With statement
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()
    End Sub

End Class
