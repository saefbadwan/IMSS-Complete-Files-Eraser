Imports ComponentOwl.BetterListView
Imports DevComponents.DotNetBar

Public Class IMSS_Main
    Private Shared _IMSS_CONTROL As IMSS_Main
    Friend Shared Function _IMSS_CREATE_CONTROLS() As IMSS_Main
        If _IMSS_CONTROL Is Nothing Then
            _IMSS_CONTROL = New IMSS_Main

            '_IMSS_CONTROL.Dock = DockStyle.Fill
        End If
        Return _IMSS_CONTROL
    End Function
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _IMSS_SetupDilogs()
    End Sub

#Region " IMSS Click Functions Decleration"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _IMSS_Slide(0, -530, -24)
    End Sub
    'Private _IMSS_DeleterThread As Threading.Thread = Nothing
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If _IMSS_Targets_ListInfo.Items.Count > 0 Then
            _IMSS_MainProgressBar.Maximum = _IMSS_Targets_ListInfo.Items.Count()
            _IMSS_Slide(-530, -1020, -24)
            Me.Location = New Point(Me.Location.X - 24, Me.Location.Y)
            _IMSS_CoreDeleter.RunWorkerAsync()
            '_IMSS_DeleterThread = New Threading.Thread(Sub() _IMSS_TargetsDeleter(_IMSS_Targets_ListInfo, My.Settings._IMSS_NumberOfPassesOper)) : _IMSS_DeleterThread.Start()
        Else
            MessageBox.Show("Please select files or folders you want to completely delete", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        _IMSS_Slide(-530, 0, 24)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        IMSS_Settings.ShowDialog()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If _IMSS_OpenFile.ShowDialog() = DialogResult.OK Then
            For i As Integer = 0 To _IMSS_OpenFile.FileNames.Length - 1 Step 1
                With _IMSS_Targets_ListInfo.Groups(0).Items.Add(IO.Path.GetFileNameWithoutExtension(_IMSS_OpenFile.FileNames(i)))
                    Try : .Image = _IMSS_ResizeImage(Icon.ExtractAssociatedIcon(_IMSS_OpenFile.FileNames(i)).ToBitmap(), 16, 16) : Catch : End Try
                    .SubItems.Add(_IMSS_OpenFile.FileNames(i))
                End With
            Next i
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If _IMSS_FolderBrowser.ShowDialog() = DialogResult.OK Then
            With _IMSS_Targets_ListInfo.Groups(1).Items.Add(IO.Path.GetFileName(_IMSS_FolderBrowser.SelectedPath))
                .Image = My.Resources._IMSS_FoldersMini_icon_16x16
                .SubItems.Add(_IMSS_FolderBrowser.SelectedPath())
            End With
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            _IMSS_CoreDeleter.CancelAsync()
        Catch : End Try
        Application.Exit()
    End Sub

#End Region

#Region " IMSS Functions Decleration Uint"

    Private Sub _IMSS_Slide(ByVal _IMSS_From As Short, ByVal _IMSS_To As Short, ByVal _IMSS_Step As Short)
        For i As Integer = _IMSS_From To _IMSS_To Step _IMSS_Step
            Me.Location = New Point(i, Me.Location.Y)
            Application.DoEvents()
        Next i
    End Sub

    Private Sub _IMSS_SetupDilogs()
        _IMSS_OpenFile.FileName = ""
        _IMSS_OpenFile.Multiselect = True
        _IMSS_OpenFile.Filter = " AllFiles |*.*"
    End Sub

#Region " IMSS ResizeImage Function Declration"
    Private Function _IMSS_ResizeImage(ByVal SourceImage As Drawing.Image, ByVal TargetWidth As Int32, ByVal TargetHeight As Int32) As Drawing.Bitmap
        Dim bmSource = New Drawing.Bitmap(SourceImage)
        Return _IMSS_ResizeImage(bmSource, TargetWidth, TargetHeight)
    End Function

    Private Function _IMSS_ResizeImage(ByVal bmSource As Drawing.Bitmap, ByVal TargetWidth As Int32, ByVal TargetHeight As Int32) As Drawing.Bitmap
        Dim bmDest As New Drawing.Bitmap(TargetWidth, TargetHeight, Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim nSourceAspectRatio = bmSource.Width / bmSource.Height
        Dim nDestAspectRatio = bmDest.Width / bmDest.Height

        Dim NewX = 0
        Dim NewY = 0
        Dim NewWidth = bmDest.Width
        Dim NewHeight = bmDest.Height

        If nDestAspectRatio = nSourceAspectRatio Then
            'same ratio
        ElseIf nDestAspectRatio > nSourceAspectRatio Then
            'Source is taller
            NewWidth = Convert.ToInt32(Math.Floor(nSourceAspectRatio * NewHeight))
            NewX = Convert.ToInt32(Math.Floor((bmDest.Width - NewWidth) / 2))
        Else
            'Source is wider
            NewHeight = Convert.ToInt32(Math.Floor((1 / nSourceAspectRatio) * NewWidth))
            NewY = Convert.ToInt32(Math.Floor((bmDest.Height - NewHeight) / 2))
        End If

        Using grDest = Drawing.Graphics.FromImage(bmDest)
            With grDest
                .CompositingQuality = Drawing.Drawing2D.CompositingQuality.HighQuality
                .InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                .PixelOffsetMode = Drawing.Drawing2D.PixelOffsetMode.HighQuality
                .SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias
                .CompositingMode = Drawing.Drawing2D.CompositingMode.SourceOver

                .DrawImage(bmSource, NewX, NewY, NewWidth, NewHeight)
            End With
        End Using

        Return bmDest
    End Function
#End Region

    Private _IMSS_Process As New Process
    Private Sub _IMSS_DeleterCore(ByVal _IMSS_FilePath As String, ByVal _IMSS_NumberOfPasses As Short, ByVal _IMSS_DeleterStatus As Boolean)
        If _IMSS_DeleterStatus = True Then
            MsgBox(True)
            _IMSS_Process.StartInfo = New ProcessStartInfo("cmd", "/c " & "IMSS_CoreDeleter.exe -p " & _IMSS_NumberOfPasses & " -q -a " & """" & _IMSS_FilePath & """") With {.UseShellExecute = False,
                                                                                                                         .CreateNoWindow = True}
        Else
            _IMSS_Process.StartInfo = New ProcessStartInfo("cmd", "/c " & "IMSS_CoreDeleter.exe -p " & _IMSS_NumberOfPasses & " -q -a -s " & """" & _IMSS_FilePath & """") With {.UseShellExecute = False,
                                                                                                                         .CreateNoWindow = True}
        End If
        _IMSS_Process.Start()
        _IMSS_Process.WaitForExit()
    End Sub
#Region " IMSS Invoke Functions Uint"
    Private Delegate Sub _IMSS_ChangeLabelDelegate(ByRef _IMSS_Label As LabelX, ByVal _IMSS_Value As String)
    Private Sub _IMSS_ChangeLabel(ByRef _IMSS_Label As LabelX, ByVal _IMSS_Value As String)
        If _IMSS_Label.InvokeRequired = True Then
            _IMSS_Label.Invoke(New _IMSS_ChangeLabelDelegate(AddressOf _IMSS_ChangeLabel), _IMSS_Label, _IMSS_Value)
        Else
            _IMSS_Label.Text = _IMSS_Value
        End If
    End Sub
    Private Delegate Sub _IMSS_ProgressBarAddValueDelegate(ByRef _IMSS_ProgressBar As ProgressBar)
    Private Sub _IMSS_ProgressBarAddValue(ByRef _IMSS_ProgressBar As ProgressBar)
        If _IMSS_ProgressBar.InvokeRequired = True Then
            _IMSS_ProgressBar.Invoke(New _IMSS_ProgressBarAddValueDelegate(AddressOf _IMSS_ProgressBarAddValue), _IMSS_ProgressBar)
        Else
            _IMSS_ProgressBar.Value += 1
        End If
    End Sub
#End Region
#End Region

    Private Sub _IMSS_CoreDeleter_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles _IMSS_CoreDeleter.DoWork
        If _IMSS_Targets_ListInfo.Groups(0).Items.Count > 0 Then
            _IMSS_ChangeLabel(_IMSS_Catogry, "Catgory : Files")
            For Each _IMSS_Item In _IMSS_Targets_ListInfo.Groups(0).Items
                _IMSS_ChangeLabel(_IMSS_CurrentFile, _IMSS_Item.SubItems(1).Text)
                Try
                    _IMSS_DeleterCore(_IMSS_Item.SubItems(1).Text, My.Settings._IMSS_NumberOfPassesOper, True)
                    _IMSS_ProgressBarAddValue(_IMSS_MainProgressBar)
                Catch : End Try
            Next _IMSS_Item
        End If
        If _IMSS_Targets_ListInfo.Groups(1).Items.Count > 0 Then
            _IMSS_ChangeLabel(_IMSS_Catogry, "Catgory : Folders")
            For Each _IMSS_Item In _IMSS_Targets_ListInfo.Groups(1).Items
                _IMSS_ChangeLabel(_IMSS_CurrentFile, _IMSS_Item.SubItems(1).Text)
                Try
                    _IMSS_DeleterCore(_IMSS_Item.SubItems(1).Text, My.Settings._IMSS_NumberOfPassesOper, False)
                    _IMSS_ProgressBarAddValue(_IMSS_MainProgressBar)
                Catch : End Try
            Next _IMSS_Item
        End If
        System.Threading.Thread.Sleep(1000)
    End Sub

    Private Sub _IMSS_CoreDeleter_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles _IMSS_CoreDeleter.RunWorkerCompleted
        _IMSS_Targets_ListInfo.Items.Clear()
        _IMSS_Slide(-1034, 0, 24)
        MessageBox.Show("All selected files has been deleted successfully !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub
End Class
