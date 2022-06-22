Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms



Module Module1
    Public con As New MySqlConnection("server=127.0.0.1;user id=root;database=dbraffle")
    Public cmd As New MySqlCommand
    ' Public adpt As New MySqlDataAdapter
    Public ds As New dbraffleDataSet
    Public dt As New DataTable
    Public SQLCMD As String = "SELECT * FROM tblticket"
    Dim result As Integer
    'Get the value of last ticket number stored in the database
    Public Sub getLastTicketNumber(label As Label)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = "SELECT TicketNum FROM tblticket WHERE TicketNum=(SELECT MAX(TicketNum) FROM tblticket);"
            End With
            label.Text = cmd.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Dispose()
        End Try
    End Sub
    'Generate  Ticket based on number of tickets
    Public Sub generateTicket(query As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = query
            End With
            result = cmd.ExecuteNonQuery()
            If result > 0 Then

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Dispose()
        End Try
    End Sub
    'view ticket containing unique ticket number
    Public Sub viewTicket(reportViewer As ReportViewer)
        Dim rpdts As ReportDataSource
        Try
            With reportViewer.LocalReport
                .ReportPath = "D:\Projects\Raffle Ticket AutoNum\RaffleTicketAutoNumber\Report.rdlc"
                .DataSources.Clear()
            End With
            Dim adpt As New MySqlDataAdapter
            con.Open()
            adpt.SelectCommand = New MySqlCommand(SQLCMD, con)
            adpt.Fill(ds.Tables("tblticket"))
            con.Close()

            rpdts = New ReportDataSource("DataSet1", ds.Tables("tblticket"))
            reportViewer.LocalReport.DataSources.Add(rpdts)

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout)
            reportViewer.ZoomMode = ZoomMode.PageWidth
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Dispose()
        End Try
    End Sub


End Module
