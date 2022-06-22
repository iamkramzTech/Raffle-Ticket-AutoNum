Public Class frmGenerateTicket

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim txtValue As Integer
        Dim controller As Integer
        If Me.txtNum.Text = "" Then
            MsgBox("TextField cannot be empty", MsgBoxStyle.Critical)
        Else
            Try
                txtValue = Integer.Parse(Me.txtNum.Text)
                If txtValue <= 0 Then
                    MsgBox("Minimum value must be 1", MsgBoxStyle.Critical)
                    Me.txtNum.Clear()
                ElseIf txtValue >= 1 Then
                    'Generate  Ticket based on number of tickets
                    'loop
                    'Dim lastTicketNumber As Integer = Integer.Parse(lastrowTicketnum.Text) 'last ticketnumber in tblticket row
                    Dim numTicket As Integer = txtValue 'no. of ticketnumber to be generated

                    With percentBar
                        .Minimum = 0
                        .Maximum = numTicket
                    End With
                    For controller = 1 To numTicket Step +1
                        generateTicket("INSERT INTO tblticket VALUES();")
                        percentBar.Increment(1)
                    Next
                End If
                percentBar.Value = 0
            Catch ex As System.FormatException
                MsgBox("Input not valid! Please Try again", MsgBoxStyle.Critical)
            Finally
                Me.txtNum.Clear()
                getLastTicketNumber(lastrowTicketnum)
            End Try

        End If
    End Sub

    Private Sub frmGenerateTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lastrowTicketnum.Text = ""
        getLastTicketNumber(lastrowTicketnum)

    End Sub
End Class