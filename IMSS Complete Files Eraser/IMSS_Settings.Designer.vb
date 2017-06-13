<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_Settings
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_Settings))
        Me._IMSS_ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me._IMSS_Info = New System.Windows.Forms.PictureBox()
        Me._IMSS_Info_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Numeric = New System.Windows.Forms.NumericUpDown()
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Click_Panels = New DevComponents.DotNetBar.PanelEx()
        Me._IMS_Cancel = New System.Windows.Forms.Button()
        Me._IMSS_Save = New System.Windows.Forms.Button()
        CType(Me._IMSS_Info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_Numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_MainPanel.SuspendLayout()
        Me._IMSS_Click_Panels.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_ToolTip
        '
        Me._IMSS_ToolTip.AutoPopDelay = 20000
        Me._IMSS_ToolTip.InitialDelay = 400
        Me._IMSS_ToolTip.ReshowDelay = 100
        '
        '_IMSS_Info
        '
        Me._IMSS_Info.Image = Global.IMSS_Complete_Files_Eraser.My.Resources.Resources._IMSS_Info_Icon_16x16
        Me._IMSS_Info.Location = New System.Drawing.Point(235, 12)
        Me._IMSS_Info.Name = "_IMSS_Info"
        Me._IMSS_Info.Size = New System.Drawing.Size(16, 16)
        Me._IMSS_Info.TabIndex = 1
        Me._IMSS_Info.TabStop = False
        Me._IMSS_ToolTip.SetToolTip(Me._IMSS_Info, resources.GetString("_IMSS_Info.ToolTip"))
        '
        '_IMSS_Info_Label
        '
        Me._IMSS_Info_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_Info_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Info_Label.Location = New System.Drawing.Point(12, 12)
        Me._IMSS_Info_Label.Name = "_IMSS_Info_Label"
        Me._IMSS_Info_Label.Size = New System.Drawing.Size(178, 15)
        Me._IMSS_Info_Label.TabIndex = 0
        Me._IMSS_Info_Label.Text = "Specifies number of overwrite passes"
        '
        '_IMSS_Numeric
        '
        Me._IMSS_Numeric.Location = New System.Drawing.Point(196, 10)
        Me._IMSS_Numeric.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me._IMSS_Numeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me._IMSS_Numeric.Name = "_IMSS_Numeric"
        Me._IMSS_Numeric.Size = New System.Drawing.Size(35, 20)
        Me._IMSS_Numeric.TabIndex = 1
        Me._IMSS_Numeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Info)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Numeric)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Info_Label)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(255, 80)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 0
        '
        '_IMSS_Click_Panels
        '
        Me._IMSS_Click_Panels.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_Click_Panels.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Click_Panels.Controls.Add(Me._IMS_Cancel)
        Me._IMSS_Click_Panels.Controls.Add(Me._IMSS_Save)
        Me._IMSS_Click_Panels.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_Click_Panels.Location = New System.Drawing.Point(0, 47)
        Me._IMSS_Click_Panels.Name = "_IMSS_Click_Panels"
        Me._IMSS_Click_Panels.Size = New System.Drawing.Size(255, 33)
        Me._IMSS_Click_Panels.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_Click_Panels.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_Click_Panels.Style.BackColor2.Color = System.Drawing.Color.LightGray
        Me._IMSS_Click_Panels.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_Click_Panels.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_Click_Panels.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top
        Me._IMSS_Click_Panels.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_Click_Panels.Style.GradientAngle = 90
        Me._IMSS_Click_Panels.TabIndex = 1
        '
        '_IMS_Cancel
        '
        Me._IMS_Cancel.Location = New System.Drawing.Point(103, 7)
        Me._IMS_Cancel.Name = "_IMS_Cancel"
        Me._IMS_Cancel.Size = New System.Drawing.Size(73, 23)
        Me._IMS_Cancel.TabIndex = 1
        Me._IMS_Cancel.Text = "Cancel"
        Me._IMS_Cancel.UseVisualStyleBackColor = True
        '
        '_IMSS_Save
        '
        Me._IMSS_Save.Location = New System.Drawing.Point(182, 7)
        Me._IMSS_Save.Name = "_IMSS_Save"
        Me._IMSS_Save.Size = New System.Drawing.Size(61, 23)
        Me._IMSS_Save.TabIndex = 0
        Me._IMSS_Save.Text = "Save"
        Me._IMSS_Save.UseVisualStyleBackColor = True
        '
        'IMSS_Settings
        '
        Me.AcceptButton = Me._IMSS_Save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 80)
        Me.Controls.Add(Me._IMSS_Click_Panels)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(271, 142)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(271, 118)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(271, 118)
        Me.Name = "IMSS_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        CType(Me._IMSS_Info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_Numeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_MainPanel.PerformLayout()
        Me._IMSS_Click_Panels.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents _IMSS_Info_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Numeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents _IMSS_Info As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_Click_Panels As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMS_Cancel As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Save As System.Windows.Forms.Button
End Class
