Public Class PrintHelper
    Friend TextToBePrinted As String

    Public Sub Prt(text As String, printer As String)
        TextToBePrinted = text
        Dim prn As New Printing.PrintDocument
        Using (prn)
            prn.PrinterSettings.PrinterName = printer
            AddHandler prn.PrintPage, AddressOf Me.PrintPageHandler
            prn.Print()
            RemoveHandler prn.PrintPage, AddressOf Me.PrintPageHandler
        End Using
    End Sub

    Private Sub PrintPageHandler(ByVal sender As Object, ByVal args As Printing.PrintPageEventArgs)
        Dim myFont As New Font("Courier New", 9)
        args.Graphics.DrawString(TextToBePrinted, New Font(myFont, FontStyle.Regular), Brushes.Black, 50, 50)
    End Sub
End Class
