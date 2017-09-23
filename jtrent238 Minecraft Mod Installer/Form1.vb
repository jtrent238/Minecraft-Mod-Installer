Imports SharpRaven
Imports SharpRaven.Data
Public Class Form1

    Dim ravenClient = New RavenClient("https://d9874a6f8da04419a005b9d605c98913:04c03a64682a44818dbb761136574ef7@sentry.io/221100")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            EpicProportions.Show()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub
End Class
