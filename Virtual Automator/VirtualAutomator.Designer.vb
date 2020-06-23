<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VirtualAutomator
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
        Me.MOTD = New System.Windows.Forms.Panel()
        Me.MOTDViewGuideBtn = New System.Windows.Forms.Button()
        Me.MOTDRunSetupBtn = New System.Windows.Forms.Button()
        Me.MOTDBuildInfo = New System.Windows.Forms.TextBox()
        Me.MOTDlogo = New System.Windows.Forms.TextBox()
        Me.SetupPATH = New System.Windows.Forms.Panel()
        Me.RouterOSPathLable = New System.Windows.Forms.Label()
        Me.SetupPathRouterOSBrowse = New System.Windows.Forms.Button()
        Me.SetupPathRouterOSPath = New System.Windows.Forms.TextBox()
        Me.Windows10PathLable = New System.Windows.Forms.Label()
        Me.SetupPathWindows10Browse = New System.Windows.Forms.Button()
        Me.SetupPathWindows10Path = New System.Windows.Forms.TextBox()
        Me.ServerPathLable = New System.Windows.Forms.Label()
        Me.SetupPathServerBrowse = New System.Windows.Forms.Button()
        Me.SetupPathServerPath = New System.Windows.Forms.TextBox()
        Me.SetupPathNextBtn = New System.Windows.Forms.Button()
        Me.SetupPathLogo = New System.Windows.Forms.TextBox()
        Me.ConsoleOutput = New System.Windows.Forms.Panel()
        Me.ConsoleBox = New System.Windows.Forms.ListBox()
        Me.BrowseForFileServer = New System.Windows.Forms.OpenFileDialog()
        Me.StorageLocation = New System.Windows.Forms.Panel()
        Me.VMFolderPath = New System.Windows.Forms.Label()
        Me.BrowsePathInstallPath = New System.Windows.Forms.Button()
        Me.installpathtext = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.AppConfig = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.MOTD.SuspendLayout()
        Me.SetupPATH.SuspendLayout()
        Me.ConsoleOutput.SuspendLayout()
        Me.StorageLocation.SuspendLayout()
        Me.SuspendLayout()
        '
        'MOTD
        '
        Me.MOTD.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.MOTD.Controls.Add(Me.MOTDViewGuideBtn)
        Me.MOTD.Controls.Add(Me.MOTDRunSetupBtn)
        Me.MOTD.Controls.Add(Me.MOTDBuildInfo)
        Me.MOTD.Controls.Add(Me.MOTDlogo)
        Me.MOTD.Location = New System.Drawing.Point(12, 12)
        Me.MOTD.Name = "MOTD"
        Me.MOTD.Size = New System.Drawing.Size(427, 256)
        Me.MOTD.TabIndex = 0
        '
        'MOTDViewGuideBtn
        '
        Me.MOTDViewGuideBtn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MOTDViewGuideBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MOTDViewGuideBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MOTDViewGuideBtn.Location = New System.Drawing.Point(253, 130)
        Me.MOTDViewGuideBtn.Name = "MOTDViewGuideBtn"
        Me.MOTDViewGuideBtn.Size = New System.Drawing.Size(75, 23)
        Me.MOTDViewGuideBtn.TabIndex = 3
        Me.MOTDViewGuideBtn.Text = "View Guides"
        Me.MOTDViewGuideBtn.UseVisualStyleBackColor = True
        '
        'MOTDRunSetupBtn
        '
        Me.MOTDRunSetupBtn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MOTDRunSetupBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MOTDRunSetupBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MOTDRunSetupBtn.Location = New System.Drawing.Point(89, 130)
        Me.MOTDRunSetupBtn.Name = "MOTDRunSetupBtn"
        Me.MOTDRunSetupBtn.Size = New System.Drawing.Size(75, 23)
        Me.MOTDRunSetupBtn.TabIndex = 2
        Me.MOTDRunSetupBtn.Text = "Run Setup"
        Me.MOTDRunSetupBtn.UseVisualStyleBackColor = True
        '
        'MOTDBuildInfo
        '
        Me.MOTDBuildInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.MOTDBuildInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MOTDBuildInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.MOTDBuildInfo.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOTDBuildInfo.ForeColor = System.Drawing.SystemColors.Window
        Me.MOTDBuildInfo.Location = New System.Drawing.Point(0, 233)
        Me.MOTDBuildInfo.Name = "MOTDBuildInfo"
        Me.MOTDBuildInfo.ReadOnly = True
        Me.MOTDBuildInfo.Size = New System.Drawing.Size(424, 15)
        Me.MOTDBuildInfo.TabIndex = 1
        Me.MOTDBuildInfo.Text = "com.stefaneady.VirtualAutomator                                  V0.0.1"
        Me.MOTDBuildInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MOTDlogo
        '
        Me.MOTDlogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.MOTDlogo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MOTDlogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.MOTDlogo.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOTDlogo.ForeColor = System.Drawing.SystemColors.Window
        Me.MOTDlogo.Location = New System.Drawing.Point(0, 33)
        Me.MOTDlogo.Name = "MOTDlogo"
        Me.MOTDlogo.ReadOnly = True
        Me.MOTDlogo.Size = New System.Drawing.Size(424, 33)
        Me.MOTDlogo.TabIndex = 0
        Me.MOTDlogo.Text = "Virtual Automator"
        Me.MOTDlogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SetupPATH
        '
        Me.SetupPATH.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.SetupPATH.Controls.Add(Me.RouterOSPathLable)
        Me.SetupPATH.Controls.Add(Me.SetupPathRouterOSBrowse)
        Me.SetupPATH.Controls.Add(Me.SetupPathRouterOSPath)
        Me.SetupPATH.Controls.Add(Me.Windows10PathLable)
        Me.SetupPATH.Controls.Add(Me.SetupPathWindows10Browse)
        Me.SetupPATH.Controls.Add(Me.SetupPathWindows10Path)
        Me.SetupPATH.Controls.Add(Me.ServerPathLable)
        Me.SetupPATH.Controls.Add(Me.SetupPathServerBrowse)
        Me.SetupPATH.Controls.Add(Me.SetupPathServerPath)
        Me.SetupPATH.Controls.Add(Me.SetupPathNextBtn)
        Me.SetupPATH.Controls.Add(Me.SetupPathLogo)
        Me.SetupPATH.Location = New System.Drawing.Point(474, 12)
        Me.SetupPATH.Name = "SetupPATH"
        Me.SetupPATH.Size = New System.Drawing.Size(427, 256)
        Me.SetupPATH.TabIndex = 4
        '
        'RouterOSPathLable
        '
        Me.RouterOSPathLable.AutoSize = True
        Me.RouterOSPathLable.ForeColor = System.Drawing.Color.White
        Me.RouterOSPathLable.Location = New System.Drawing.Point(30, 165)
        Me.RouterOSPathLable.Name = "RouterOSPathLable"
        Me.RouterOSPathLable.Size = New System.Drawing.Size(93, 13)
        Me.RouterOSPathLable.TabIndex = 12
        Me.RouterOSPathLable.Text = "Router OS VHDX:"
        Me.RouterOSPathLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SetupPathRouterOSBrowse
        '
        Me.SetupPathRouterOSBrowse.Location = New System.Drawing.Point(335, 160)
        Me.SetupPathRouterOSBrowse.Name = "SetupPathRouterOSBrowse"
        Me.SetupPathRouterOSBrowse.Size = New System.Drawing.Size(75, 23)
        Me.SetupPathRouterOSBrowse.TabIndex = 11
        Me.SetupPathRouterOSBrowse.Text = "Browse"
        Me.SetupPathRouterOSBrowse.UseVisualStyleBackColor = True
        '
        'SetupPathRouterOSPath
        '
        Me.SetupPathRouterOSPath.Location = New System.Drawing.Point(129, 162)
        Me.SetupPathRouterOSPath.Name = "SetupPathRouterOSPath"
        Me.SetupPathRouterOSPath.ReadOnly = True
        Me.SetupPathRouterOSPath.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SetupPathRouterOSPath.Size = New System.Drawing.Size(200, 20)
        Me.SetupPathRouterOSPath.TabIndex = 10
        Me.SetupPathRouterOSPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Windows10PathLable
        '
        Me.Windows10PathLable.AutoSize = True
        Me.Windows10PathLable.ForeColor = System.Drawing.Color.White
        Me.Windows10PathLable.Location = New System.Drawing.Point(14, 134)
        Me.Windows10PathLable.Name = "Windows10PathLable"
        Me.Windows10PathLable.Size = New System.Drawing.Size(109, 13)
        Me.Windows10PathLable.TabIndex = 9
        Me.Windows10PathLable.Text = "Windows 10 Pro ISO:"
        Me.Windows10PathLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SetupPathWindows10Browse
        '
        Me.SetupPathWindows10Browse.Location = New System.Drawing.Point(335, 129)
        Me.SetupPathWindows10Browse.Name = "SetupPathWindows10Browse"
        Me.SetupPathWindows10Browse.Size = New System.Drawing.Size(75, 23)
        Me.SetupPathWindows10Browse.TabIndex = 8
        Me.SetupPathWindows10Browse.Text = "Browse"
        Me.SetupPathWindows10Browse.UseVisualStyleBackColor = True
        '
        'SetupPathWindows10Path
        '
        Me.SetupPathWindows10Path.Location = New System.Drawing.Point(129, 131)
        Me.SetupPathWindows10Path.Name = "SetupPathWindows10Path"
        Me.SetupPathWindows10Path.ReadOnly = True
        Me.SetupPathWindows10Path.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SetupPathWindows10Path.Size = New System.Drawing.Size(200, 20)
        Me.SetupPathWindows10Path.TabIndex = 7
        Me.SetupPathWindows10Path.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ServerPathLable
        '
        Me.ServerPathLable.AutoSize = True
        Me.ServerPathLable.ForeColor = System.Drawing.Color.White
        Me.ServerPathLable.Location = New System.Drawing.Point(14, 104)
        Me.ServerPathLable.Name = "ServerPathLable"
        Me.ServerPathLable.Size = New System.Drawing.Size(109, 13)
        Me.ServerPathLable.TabIndex = 6
        Me.ServerPathLable.Text = "Windows Server ISO:"
        Me.ServerPathLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SetupPathServerBrowse
        '
        Me.SetupPathServerBrowse.Location = New System.Drawing.Point(335, 99)
        Me.SetupPathServerBrowse.Name = "SetupPathServerBrowse"
        Me.SetupPathServerBrowse.Size = New System.Drawing.Size(75, 23)
        Me.SetupPathServerBrowse.TabIndex = 5
        Me.SetupPathServerBrowse.Text = "Browse"
        Me.SetupPathServerBrowse.UseVisualStyleBackColor = True
        '
        'SetupPathServerPath
        '
        Me.SetupPathServerPath.Location = New System.Drawing.Point(129, 101)
        Me.SetupPathServerPath.Name = "SetupPathServerPath"
        Me.SetupPathServerPath.ReadOnly = True
        Me.SetupPathServerPath.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SetupPathServerPath.Size = New System.Drawing.Size(200, 20)
        Me.SetupPathServerPath.TabIndex = 3
        Me.SetupPathServerPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SetupPathNextBtn
        '
        Me.SetupPathNextBtn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SetupPathNextBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SetupPathNextBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SetupPathNextBtn.Location = New System.Drawing.Point(173, 204)
        Me.SetupPathNextBtn.Name = "SetupPathNextBtn"
        Me.SetupPathNextBtn.Size = New System.Drawing.Size(75, 23)
        Me.SetupPathNextBtn.TabIndex = 2
        Me.SetupPathNextBtn.Text = "Next"
        Me.SetupPathNextBtn.UseVisualStyleBackColor = True
        '
        'SetupPathLogo
        '
        Me.SetupPathLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.SetupPathLogo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SetupPathLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.SetupPathLogo.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetupPathLogo.ForeColor = System.Drawing.SystemColors.Window
        Me.SetupPathLogo.Location = New System.Drawing.Point(0, 33)
        Me.SetupPathLogo.Name = "SetupPathLogo"
        Me.SetupPathLogo.ReadOnly = True
        Me.SetupPathLogo.Size = New System.Drawing.Size(424, 33)
        Me.SetupPathLogo.TabIndex = 0
        Me.SetupPathLogo.Text = "Enter File Paths"
        Me.SetupPathLogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ConsoleOutput
        '
        Me.ConsoleOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ConsoleOutput.Controls.Add(Me.ConsoleBox)
        Me.ConsoleOutput.Location = New System.Drawing.Point(937, 12)
        Me.ConsoleOutput.Name = "ConsoleOutput"
        Me.ConsoleOutput.Size = New System.Drawing.Size(427, 256)
        Me.ConsoleOutput.TabIndex = 6
        '
        'ConsoleBox
        '
        Me.ConsoleBox.FormattingEnabled = True
        Me.ConsoleBox.HorizontalScrollbar = True
        Me.ConsoleBox.Location = New System.Drawing.Point(3, 3)
        Me.ConsoleBox.Name = "ConsoleBox"
        Me.ConsoleBox.Size = New System.Drawing.Size(421, 251)
        Me.ConsoleBox.TabIndex = 0
        '
        'BrowseForFileServer
        '
        Me.BrowseForFileServer.AddExtension = False
        Me.BrowseForFileServer.CheckFileExists = False
        Me.BrowseForFileServer.CheckPathExists = False
        Me.BrowseForFileServer.FileName = "BrowseForFileServer"
        '
        'StorageLocation
        '
        Me.StorageLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.StorageLocation.Controls.Add(Me.VMFolderPath)
        Me.StorageLocation.Controls.Add(Me.BrowsePathInstallPath)
        Me.StorageLocation.Controls.Add(Me.installpathtext)
        Me.StorageLocation.Controls.Add(Me.Button4)
        Me.StorageLocation.Controls.Add(Me.AppConfig)
        Me.StorageLocation.Location = New System.Drawing.Point(12, 274)
        Me.StorageLocation.Name = "StorageLocation"
        Me.StorageLocation.Size = New System.Drawing.Size(427, 256)
        Me.StorageLocation.TabIndex = 13
        '
        'VMFolderPath
        '
        Me.VMFolderPath.AutoSize = True
        Me.VMFolderPath.ForeColor = System.Drawing.Color.White
        Me.VMFolderPath.Location = New System.Drawing.Point(33, 104)
        Me.VMFolderPath.Name = "VMFolderPath"
        Me.VMFolderPath.Size = New System.Drawing.Size(90, 13)
        Me.VMFolderPath.TabIndex = 6
        Me.VMFolderPath.Text = "Path To Install In:"
        Me.VMFolderPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BrowsePathInstallPath
        '
        Me.BrowsePathInstallPath.Location = New System.Drawing.Point(335, 99)
        Me.BrowsePathInstallPath.Name = "BrowsePathInstallPath"
        Me.BrowsePathInstallPath.Size = New System.Drawing.Size(75, 23)
        Me.BrowsePathInstallPath.TabIndex = 5
        Me.BrowsePathInstallPath.Text = "Browse"
        Me.BrowsePathInstallPath.UseVisualStyleBackColor = True
        '
        'installpathtext
        '
        Me.installpathtext.Location = New System.Drawing.Point(129, 101)
        Me.installpathtext.Name = "installpathtext"
        Me.installpathtext.ReadOnly = True
        Me.installpathtext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.installpathtext.Size = New System.Drawing.Size(200, 20)
        Me.installpathtext.TabIndex = 3
        Me.installpathtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button4
        '
        Me.Button4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Location = New System.Drawing.Point(173, 204)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Next"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'AppConfig
        '
        Me.AppConfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.AppConfig.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AppConfig.Cursor = System.Windows.Forms.Cursors.Default
        Me.AppConfig.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppConfig.ForeColor = System.Drawing.SystemColors.Window
        Me.AppConfig.Location = New System.Drawing.Point(0, 33)
        Me.AppConfig.Name = "AppConfig"
        Me.AppConfig.ReadOnly = True
        Me.AppConfig.Size = New System.Drawing.Size(424, 33)
        Me.AppConfig.TabIndex = 0
        Me.AppConfig.Text = "Enter Storage Location"
        Me.AppConfig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VirtualAutomator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2641, 647)
        Me.Controls.Add(Me.StorageLocation)
        Me.Controls.Add(Me.ConsoleOutput)
        Me.Controls.Add(Me.SetupPATH)
        Me.Controls.Add(Me.MOTD)
        Me.Name = "VirtualAutomator"
        Me.Text = "Virtual Automator"
        Me.MOTD.ResumeLayout(False)
        Me.MOTD.PerformLayout()
        Me.SetupPATH.ResumeLayout(False)
        Me.SetupPATH.PerformLayout()
        Me.ConsoleOutput.ResumeLayout(False)
        Me.StorageLocation.ResumeLayout(False)
        Me.StorageLocation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MOTD As Panel
    Friend WithEvents MOTDViewGuideBtn As Button
    Friend WithEvents MOTDRunSetupBtn As Button
    Friend WithEvents MOTDBuildInfo As TextBox
    Friend WithEvents MOTDlogo As TextBox
    Friend WithEvents SetupPATH As Panel
    Friend WithEvents SetupPathNextBtn As Button
    Friend WithEvents SetupPathLogo As TextBox
    Friend WithEvents SetupPathServerBrowse As Button
    Friend WithEvents SetupPathServerPath As TextBox
    Friend WithEvents ConsoleOutput As Panel
    Friend WithEvents ConsoleBox As ListBox
    Friend WithEvents BrowseForFileServer As OpenFileDialog
    Friend WithEvents RouterOSPathLable As Label
    Friend WithEvents SetupPathRouterOSBrowse As Button
    Friend WithEvents SetupPathRouterOSPath As TextBox
    Friend WithEvents Windows10PathLable As Label
    Friend WithEvents SetupPathWindows10Browse As Button
    Friend WithEvents SetupPathWindows10Path As TextBox
    Friend WithEvents ServerPathLable As Label
    Friend WithEvents StorageLocation As Panel
    Friend WithEvents VMFolderPath As Label
    Friend WithEvents BrowsePathInstallPath As Button
    Friend WithEvents installpathtext As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents AppConfig As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
