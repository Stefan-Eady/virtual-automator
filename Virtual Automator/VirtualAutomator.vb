Public Class VirtualAutomator
    Private Sub VirtualAutomator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsoleBox.Items.Add(DateTime.Now + ":  " + "Service Has Started")
        ConsoleBox.Items.Add(DateTime.Now + ":  " + "Virtual Automator - Version 0.0.1")
        ConsoleBox.Items.Add(DateTime.Now + ":  " + "By Stefan Eady - com.stefaneady.virtualautomator")
        MOTD.Show()
        SetupPATH.Hide()

    End Sub

    Private Sub MOTDRunSetupBtn_Click(sender As Object, e As EventArgs) Handles MOTDRunSetupBtn.Click
        MOTD.Hide()
        SetupPATH.Show()
        ConsoleBox.Items.Add(DateTime.Now + ":  " + "Switeched View To Setup Page 1")

    End Sub

    Private Sub MOTDViewGuideBtn_Click(sender As Object, e As EventArgs) Handles MOTDViewGuideBtn.Click
        ConsoleBox.Items.Add(DateTime.Now + ":  " + "Opened WIKI In New Window")
        Dim wiki As String = "https://github.com/Stefan-Eady/virtual-automator/wiki"
        Process.Start(wiki)
    End Sub

    Private Sub SetupPathServerBrowse_Click(sender As Object, e As EventArgs) Handles SetupPathServerBrowse.Click
        Dim ServerPath As String

        BrowseForFileServer.InitialDirectory = "C:\"
        BrowseForFileServer.Title = "Select Server ISO"
        BrowseForFileServer.CheckFileExists = True
        BrowseForFileServer.CheckPathExists = True
        BrowseForFileServer.DefaultExt = "iso"
        BrowseForFileServer.Filter = "iso files (*.iso)|*.iso"
        BrowseForFileServer.FilterIndex = 2
        BrowseForFileServer.RestoreDirectory = True
        BrowseForFileServer.ReadOnlyChecked = True
        BrowseForFileServer.ShowReadOnly = True
        BrowseForFileServer.ShowDialog()
        ServerPath = BrowseForFileServer.FileName

        SetupPathServerPath.Text = ServerPath
        If SetupPathServerPath.Text.Equals("BrowseForFileServer") Then
            SetupPathServerPath.Text = " "
            ConsoleBox.Items.Add(DateTime.Now + ":  " + "WARN -Windows Server Path Change Was Canceled")
        Else
            ConsoleBox.Items.Add(DateTime.Now + ":  " + "Windows Server Path Was Updated To:" + ServerPath)
        End If


    End Sub

    Private Sub BrowseForFileServer_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles BrowseForFileServer.FileOk

    End Sub
End Class
