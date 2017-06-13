<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_Main
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_Main))
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me._IMSS_Targets_ListInfo = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_Name = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Path = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Files = New ComponentOwl.BetterListView.BetterListViewGroup()
        Me._IMSS_Folders = New ComponentOwl.BetterListView.BetterListViewGroup()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me._IMSS_Decription_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me._IMSS_OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me._IMSS_MainProgressBar = New System.Windows.Forms.ProgressBar()
        Me._IMSS_Catogry = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Info = New System.Windows.Forms.PictureBox()
        Me._IMSS_CurrentFile = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_CoreDeleter = New System.ComponentModel.BackgroundWorker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        CType(Me._IMSS_Targets_ListInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_Info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(90, 95)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(420, 108)
        Me.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = resources.GetString("LabelX2.Text")
        Me.LabelX2.TextLineAlignment = System.Drawing.StringAlignment.Near
        Me.LabelX2.WordWrap = True
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(90, 68)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(269, 21)
        Me.LabelX1.TabIndex = 3
        Me.LabelX1.Text = "Welcome to complete files eraser"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 209)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Button9)
        Me.PanelEx1.Controls.Add(Me.Button5)
        Me.PanelEx1.Controls.Add(Me.Button6)
        Me.PanelEx1.Controls.Add(Me.Button4)
        Me.PanelEx1.Controls.Add(Me.Button2)
        Me.PanelEx1.Controls.Add(Me.Button1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx1.Location = New System.Drawing.Point(0, 344)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1555, 47)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.White
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.LightGray
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 6
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(1468, 13)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 6
        Me.Button9.Text = "Cancel"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(535, 13)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Settings"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(873, 13)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Back"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(954, 13)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Next"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(345, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(426, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '_IMSS_Targets_ListInfo
        '
        Me._IMSS_Targets_ListInfo.Columns.AddRange(New Object() {Me._IMSS_Name, Me._IMSS_Path})
        Me._IMSS_Targets_ListInfo.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Targets_ListInfo.Groups.AddRange(New Object() {Me._IMSS_Files, Me._IMSS_Folders})
        Me._IMSS_Targets_ListInfo.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_Targets_ListInfo.Location = New System.Drawing.Point(535, 4)
        Me._IMSS_Targets_ListInfo.Name = "_IMSS_Targets_ListInfo"
        Me._IMSS_Targets_ListInfo.ShowGroups = True
        Me._IMSS_Targets_ListInfo.Size = New System.Drawing.Size(500, 304)
        Me._IMSS_Targets_ListInfo.TabIndex = 7
        '
        '_IMSS_Name
        '
        Me._IMSS_Name.Name = "_IMSS_Name"
        Me._IMSS_Name.Text = "Name"
        Me._IMSS_Name.Width = 189
        '
        '_IMSS_Path
        '
        Me._IMSS_Path.Name = "_IMSS_Path"
        Me._IMSS_Path.Text = "Path"
        Me._IMSS_Path.Width = 292
        '
        '_IMSS_Files
        '
        Me._IMSS_Files.Font = New System.Drawing.Font("Segoe UI", 10.66667!)
        Me._IMSS_Files.Header = "Files"
        Me._IMSS_Files.Image = Global.IMSS_Complete_Files_Eraser.My.Resources.Resources._IMSS_Files_icon_24x24
        Me._IMSS_Files.Name = "_IMSS_Files"
        '
        '_IMSS_Folders
        '
        Me._IMSS_Folders.Font = New System.Drawing.Font("Segoe UI", 10.66667!)
        Me._IMSS_Folders.Header = "Folders"
        Me._IMSS_Folders.Image = Global.IMSS_Complete_Files_Eraser.My.Resources.Resources._IMSS_Folders_icon_24x24
        Me._IMSS_Folders.Name = "_IMSS_Folders"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = Global.IMSS_Complete_Files_Eraser.My.Resources.Resources._IMSS_Add_Icon_16x16
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(959, 314)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Add Files"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = Global.IMSS_Complete_Files_Eraser.My.Resources.Resources._IMSS_RegeditAdd_MainIcon_16x16
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(862, 314)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(91, 23)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Add Folders"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = False
        '
        '_IMSS_Decription_Label
        '
        Me._IMSS_Decription_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_Decription_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Decription_Label.Location = New System.Drawing.Point(535, 318)
        Me._IMSS_Decription_Label.Name = "_IMSS_Decription_Label"
        Me._IMSS_Decription_Label.Size = New System.Drawing.Size(305, 15)
        Me._IMSS_Decription_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_Decription_Label.TabIndex = 10
        Me._IMSS_Decription_Label.Text = "Please select the files or folders you want to permanently delete"
        '
        '_IMSS_OpenFile
        '
        Me._IMSS_OpenFile.FileName = "OpenFileDialog1"
        '
        '_IMSS_MainProgressBar
        '
        Me._IMSS_MainProgressBar.Location = New System.Drawing.Point(1111, 77)
        Me._IMSS_MainProgressBar.Name = "_IMSS_MainProgressBar"
        Me._IMSS_MainProgressBar.Size = New System.Drawing.Size(432, 23)
        Me._IMSS_MainProgressBar.TabIndex = 11
        '
        '_IMSS_Catogry
        '
        Me._IMSS_Catogry.AutoSize = True
        '
        '
        '
        Me._IMSS_Catogry.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Catogry.Location = New System.Drawing.Point(1111, 56)
        Me._IMSS_Catogry.Name = "_IMSS_Catogry"
        Me._IMSS_Catogry.Size = New System.Drawing.Size(56, 15)
        Me._IMSS_Catogry.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_Catogry.TabIndex = 12
        Me._IMSS_Catogry.Text = "Catgory  : "
        '
        '_IMSS_Info
        '
        Me._IMSS_Info.Image = Global.IMSS_Complete_Files_Eraser.My.Resources.Resources._IMSS_LoadimgGif_Icon
        Me._IMSS_Info.Location = New System.Drawing.Point(1112, 104)
        Me._IMSS_Info.Name = "_IMSS_Info"
        Me._IMSS_Info.Size = New System.Drawing.Size(16, 16)
        Me._IMSS_Info.TabIndex = 13
        Me._IMSS_Info.TabStop = False
        '
        '_IMSS_CurrentFile
        '
        '
        '
        '
        Me._IMSS_CurrentFile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_CurrentFile.Location = New System.Drawing.Point(1134, 104)
        Me._IMSS_CurrentFile.Name = "_IMSS_CurrentFile"
        Me._IMSS_CurrentFile.Size = New System.Drawing.Size(409, 15)
        Me._IMSS_CurrentFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_CurrentFile.TabIndex = 14
        Me._IMSS_CurrentFile.Text = "Catgory  : "
        '
        '_IMSS_CoreDeleter
        '
        Me._IMSS_CoreDeleter.WorkerReportsProgress = True
        Me._IMSS_CoreDeleter.WorkerSupportsCancellation = True
        '
        'IMSS_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_CurrentFile)
        Me.Controls.Add(Me._IMSS_Info)
        Me.Controls.Add(Me._IMSS_Catogry)
        Me.Controls.Add(Me._IMSS_MainProgressBar)
        Me.Controls.Add(Me._IMSS_Decription_Label)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me._IMSS_Targets_ListInfo)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "IMSS_Main"
        Me.Size = New System.Drawing.Size(1555, 391)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        CType(Me._IMSS_Targets_ListInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_Info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Targets_ListInfo As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_Name As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Path As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Decription_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_FolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents _IMSS_OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents _IMSS_Files As ComponentOwl.BetterListView.BetterListViewGroup
    Friend WithEvents _IMSS_Folders As ComponentOwl.BetterListView.BetterListViewGroup
    Friend WithEvents _IMSS_MainProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents _IMSS_Catogry As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Info As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_CurrentFile As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_CoreDeleter As System.ComponentModel.BackgroundWorker

End Class
