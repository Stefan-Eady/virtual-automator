Public Class VirtualAutomator
    Private Sub VirtualAutomator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsoleBox.Items.Add(DateTime.Now + ":  " + "[MOTD] Service Has Started")
        ConsoleBox.Items.Add(DateTime.Now + ":  " + "[MOTD] Virtual Automator - Version 0.0.1")
        ConsoleBox.Items.Add(DateTime.Now + ":  " + "[MOTD] By Stefan Eady - com.stefaneady.virtualautomator")
        ConsoleBox.Items.Add("")
        MOTD.Show()
        SetupPATH.Hide()
        StorageLocation.Hide()

    End Sub

    Private Sub MOTDRunSetupBtn_Click(sender As Object, e As EventArgs) Handles MOTDRunSetupBtn.Click
        MOTD.Hide()
        SetupPATH.Show()
        ConsoleBox.Items.Add(DateTime.Now + ":  " + "[INFO] Switeched View To Path Setup Page 1")

    End Sub

    Private Sub MOTDViewGuideBtn_Click(sender As Object, e As EventArgs) Handles MOTDViewGuideBtn.Click
        ConsoleBox.Items.Add(DateTime.Now + ":  " + "[INFO] Opened WIKI In New Window")
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
            ConsoleBox.Items.Add(DateTime.Now + ":  " + "[WARN] Windows Server Path Change Was Canceled")
        Else
            ConsoleBox.Items.Add(DateTime.Now + ":  " + "[INFO] Windows Server Path Was Updated To: " + ServerPath)
        End If


    End Sub

    Private Sub BrowseForFileServer_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles BrowseForFileServer.FileOk

    End Sub

    Private Sub SetupPathWindows10Browse_Click(sender As Object, e As EventArgs) Handles SetupPathWindows10Browse.Click
        Dim Win10Path As String

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
        Win10Path = BrowseForFileServer.FileName

        SetupPathWindows10Path.Text = Win10Path
        If SetupPathWindows10Path.Text.Equals("BrowseForFileServer") Then
            SetupPathWindows10Path.Text = " "
            ConsoleBox.Items.Add(DateTime.Now + ":  " + "[WARN] Windows 10 Path Change Was Canceled")
        Else
            ConsoleBox.Items.Add(DateTime.Now + ":  " + "[INFO] Windows 10 Path Was Updated To: " + Win10Path)
        End If
    End Sub

    Private Sub AppConfig_TextChanged(sender As Object, e As EventArgs) Handles AppConfig.TextChanged

    End Sub

    Private Sub BrowsePathInstallPath_Click(sender As Object, e As EventArgs) Handles BrowsePathInstallPath.Click
        Dim OldPath As String
        OldPath = installpathtext.Text
        FolderBrowserDialog1.ShowDialog()
        installpathtext.Text = FolderBrowserDialog1.SelectedPath
        If installpathtext.Text.Equals(OldPath) Then
            ConsoleBox.Items.Add(DateTime.Now + ":  " + "[WARN] Install Path Change Was Canceled")
        Else
            ConsoleBox.Items.Add(DateTime.Now + ":  " + "[INFO] Install Path Was Updated To: " + FolderBrowserDialog1.SelectedPath)
        End If
    End Sub

    Private Sub SetupPathNextBtn_Click(sender As Object, e As EventArgs) Handles SetupPathNextBtn.Click
        If SetupPathRouterOSPath.Text IsNot "" And SetupPathWindows10Path IsNot "" And SetupPathServerPath IsNot "" Then
            ConsoleBox.Items.Add(DateTime.Now + ":  " + "[INFO] Paths Have Been Saved Into Memory")
            SetupPATH.Hide()
            StorageLocation.Show()
            ConsoleBox.Items.Add(DateTime.Now + ":  " + "[INFO] Switeched View To Install Location Page 1")
        Else
            ConsoleBox.Items.Add(DateTime.Now + ":  " + " [ERROR] - All Paths Have Not Been Set")
        End If

    End Sub

    Private Sub SetupPathRouterOSBrowse_Click(sender As Object, e As EventArgs) Handles SetupPathRouterOSBrowse.Click
        Dim RouterOSPath As String

        BrowseForFileServer.InitialDirectory = "C:\"
        BrowseForFileServer.Title = "Select RouterOS VHDX"
        BrowseForFileServer.CheckFileExists = True
        BrowseForFileServer.CheckPathExists = True
        BrowseForFileServer.DefaultExt = "iso"
        BrowseForFileServer.Filter = "VHDX files (*.VHDX)|*.VHDX"
        BrowseForFileServer.FilterIndex = 2
        BrowseForFileServer.RestoreDirectory = True
        BrowseForFileServer.ReadOnlyChecked = True
        BrowseForFileServer.ShowReadOnly = True
        BrowseForFileServer.ShowDialog()
        RouterOSPath = BrowseForFileServer.FileName

        SetupPathRouterOSPath.Text = RouterOSPath
        If SetupPathRouterOSPath.Text.Equals("BrowseForFileServer") Then
            SetupPathRouterOSPath.Text = " "
            ConsoleBox.Items.Add(DateTime.Now + ":  " + "[WARN] RoouterOS Path Change Was Canceled")
        Else
            ConsoleBox.Items.Add(DateTime.Now + ":  " + "[INFO] RoouterOS Path Was Updated To: " + RouterOSPath)
        End If
    End Sub
End Class
