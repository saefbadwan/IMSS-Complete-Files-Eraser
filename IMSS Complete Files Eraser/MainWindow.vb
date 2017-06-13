Imports Microsoft.Win32

Public Class MainWindow
    Public Sub New()
        If My.Computer.Registry.CurrentUser.OpenSubKey("Software\Sysinternals") Is Nothing Then
            My.Computer.Registry.CurrentUser.CreateSubKey("Software\Sysinternals")
            My.Computer.Registry.CurrentUser.CreateSubKey("Software\Sysinternals\sDelete").SetValue("EulaAccepted", 1, RegistryValueKind.DWord)
        End If
        If Not IO.File.Exists(Environment.CurrentDirectory & "\IMSS_CoreDeleter.exe") Then IO.File.WriteAllBytes(Environment.CurrentDirectory & "\IMSS_CoreDeleter.exe", My.Resources.IMSS_CoreDeleter)
        If IO.File.Exists(Environment.CurrentDirectory & "\IMSS_CoreDeleter.exe") Then IO.File.SetAttributes(Environment.CurrentDirectory & "\IMSS_CoreDeleter.exe", IO.FileAttributes.Hidden)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._IMSS_MainPanel.Controls.Add(IMSS_Main._IMSS_CREATE_CONTROLS())
        For Each _IMSS_Control As IMSS_Main In Me._IMSS_MainPanel.Controls
            Me.AcceptButton = _IMSS_Control.Button1
            Exit For
        Next _IMSS_Control
    End Sub

End Class
