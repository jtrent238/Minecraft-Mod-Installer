Imports SharpRaven
Imports SharpRaven.Data
Public Class EpicProportions

    Dim ravenClient = New RavenClient("https://d9874a6f8da04419a005b9d605c98913:04c03a64682a44818dbb761136574ef7@sentry.io/221100")

    Private Sub EpicProportions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            My.Computer.Network.DownloadFile("https://github.com/jtrent238/PopularMMOS-EpicProportions-Mod/releases/download/1.4.8.9/epicproportionsmod-1.4.8.9-full.jar", "temp\dl\mods\epicproportionsmod-1.4.8.9-full.jar")
            My.Computer.FileSystem.CopyFile("temp\dl\mods\epicproportionsmod-1.4.8.9-full.jar", Environment.SpecialFolder.UserProfile.ToString + "\AppData\Roaming\.minecraft\mods", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            MsgBox("Installed!")
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            My.Computer.Network.DownloadFile("https://github.com/jtrent238/PopularMMOS-EpicProportions-Mod/releases/download/1.4.8.9/epicproportionsmod-1.4.8.9.jar", "temp\dl\mods\epicproportionsmod-1.4.8.9.jar")
            My.Computer.FileSystem.CopyFile("temp\dl\mods\epicproportionsmod-1.4.8.9.jar", Environment.SpecialFolder.UserProfile.ToString + "\AppData\Roaming\.minecraft\mods", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            MsgBox("Installed!")
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            My.Computer.Network.DownloadFile("https://github.com/jtrent238/PopularMMOS-EpicProportions-Mod/releases/download/1.2.7.5/epicproportionsmod-halloween-addon-1.0.0.1.jar", "temp\dl\mods\epicproportionsmod-halloween-addon-1.0.0.1.jar")
            My.Computer.FileSystem.CopyFile("temp\dl\mods\epicproportionsmod-halloween-addon-1.0.0.1.jar", Environment.SpecialFolder.UserProfile.ToString + "\AppData\Roaming\.minecraft\mods", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            MsgBox("Installed!")
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            My.Computer.Network.DownloadFile("https://github.com/jtrent238/PopularMMOS-EpicProportions-Mod/releases/download/1.3.7.5/epicproportionsmod-christmasaddon-1.0.0.0.jar", "temp\dl\mods\epicproportionsmod-christmasaddon-1.0.0.0.jar")
            My.Computer.FileSystem.CopyFile("temp\dl\mods\epicproportionsmod-christmasaddon-1.0.0.0.jar", Environment.SpecialFolder.UserProfile.ToString + "\AppData\Roaming\.minecraft\mods", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            MsgBox("Installed!")
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub
End Class