<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim StringFormat1 As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.gbHolder = New Pomf_Uploader.sGroupbox()
        Me.btnUpdate = New Pomf_Uploader.sButton()
        Me.btnCancel = New Pomf_Uploader.sButton()
        Me.Alert = New Pomf_Uploader.sNotification()
        Me.tblink = New Pomf_Uploader.sTextbox()
        Me.gbHolder.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbHolder
        '
        Me.gbHolder.Border = True
        Me.gbHolder.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.gbHolder.ContainerColor = System.Drawing.Color.White
        Me.gbHolder.Controls.Add(Me.btnUpdate)
        Me.gbHolder.Controls.Add(Me.btnCancel)
        Me.gbHolder.Controls.Add(Me.Alert)
        Me.gbHolder.Controls.Add(Me.tblink)
        Me.gbHolder.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.gbHolder.HeaderForeColor = System.Drawing.Color.White
        Me.gbHolder.HeaderHeight = 40
        Me.gbHolder.HeaderShadow = True
        Me.gbHolder.HeaderSplitterColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.gbHolder.HeaderSplitterShadowColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.gbHolder.HeaderTitle = "Pomf Uploader"
        StringFormat1.Alignment = System.Drawing.StringAlignment.Near
        StringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat1.LineAlignment = System.Drawing.StringAlignment.Near
        StringFormat1.Trimming = System.Drawing.StringTrimming.Character
        Me.gbHolder.HeaderTitleAlgin = StringFormat1
        Me.gbHolder.HeaderTitleFont = New System.Drawing.Font("Arial", 12.0!)
        Me.gbHolder.Icon = Global.Pomf_Uploader.My.Resources.Resources.Pomf_Icon_Img
        Me.gbHolder.IconSize = 36
        Me.gbHolder.IconVisible = True
        Me.gbHolder.Location = New System.Drawing.Point(3, 3)
        Me.gbHolder.Name = "gbHolder"
        Me.gbHolder.Quality = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.gbHolder.RoundedCorners = 12
        Me.gbHolder.Size = New System.Drawing.Size(375, 143)
        Me.gbHolder.SplitterBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.gbHolder.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.gbHolder.SplitterHeight = 50
        Me.gbHolder.SplitterShadowColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.gbHolder.SplitterVisible = True
        Me.gbHolder.TabIndex = 2
        Me.gbHolder.Text = "SGroupbox1"
        Me.gbHolder.TitleSpacing = 3
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnUpdate.cBorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnUpdate.cDivider = False
        Me.btnUpdate.cDividerColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnUpdate.cFillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnUpdate.cFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.cForeColor = System.Drawing.Color.White
        Me.btnUpdate.Checked = False
        Me.btnUpdate.CheckedVisiable = False
        Me.btnUpdate.cImage = Nothing
        Me.btnUpdate.cImageV = False
        Me.btnUpdate.cShadow = True
        Me.btnUpdate.cShadowColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnUpdate.cText = "Update"
        Me.btnUpdate.cToggleBackColor = System.Drawing.Color.White
        Me.btnUpdate.cToggleBorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnUpdate.cToggleColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnUpdate.FontFit = False
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.hBorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnUpdate.hDivider = False
        Me.btnUpdate.hDividerColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnUpdate.hFillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdate.hFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnUpdate.hForeColor = System.Drawing.Color.White
        Me.btnUpdate.hImage = Nothing
        Me.btnUpdate.hImageV = False
        Me.btnUpdate.hText = "Update"
        Me.btnUpdate.hToggleBackColor = System.Drawing.Color.White
        Me.btnUpdate.hToggleBorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnUpdate.hToggleColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnUpdate.ImageSize = 24
        Me.btnUpdate.ImageSpacing = 5
        Me.btnUpdate.Location = New System.Drawing.Point(212, 10)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.nBorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnUpdate.nDivider = False
        Me.btnUpdate.nDividerColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnUpdate.nFillColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnUpdate.nFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnUpdate.nForeColor = System.Drawing.Color.White
        Me.btnUpdate.nImage = Nothing
        Me.btnUpdate.nImageV = False
        Me.btnUpdate.nText = "Update"
        Me.btnUpdate.nToggleBackColor = System.Drawing.Color.White
        Me.btnUpdate.nToggleBorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnUpdate.nToggleColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnUpdate.Quality = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.btnUpdate.RoundedCorners = 8
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "SButton1"
        Me.btnUpdate.TextAlignment = System.Drawing.StringAlignment.Center
        Me.btnUpdate.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnCancel.cBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnCancel.cDivider = False
        Me.btnCancel.cDividerColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnCancel.cFillColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnCancel.cFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnCancel.cForeColor = System.Drawing.Color.White
        Me.btnCancel.Checked = False
        Me.btnCancel.CheckedVisiable = False
        Me.btnCancel.cImage = Nothing
        Me.btnCancel.cImageV = False
        Me.btnCancel.cShadow = True
        Me.btnCancel.cShadowColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnCancel.cText = "Cancel"
        Me.btnCancel.cToggleBackColor = System.Drawing.Color.White
        Me.btnCancel.cToggleBorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnCancel.cToggleColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnCancel.FontFit = False
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.hBorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnCancel.hDivider = False
        Me.btnCancel.hDividerColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnCancel.hFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnCancel.hFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.hForeColor = System.Drawing.Color.White
        Me.btnCancel.hImage = Nothing
        Me.btnCancel.hImageV = False
        Me.btnCancel.hText = "Cancel"
        Me.btnCancel.hToggleBackColor = System.Drawing.Color.White
        Me.btnCancel.hToggleBorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnCancel.hToggleColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnCancel.ImageSize = 24
        Me.btnCancel.ImageSpacing = 5
        Me.btnCancel.Location = New System.Drawing.Point(293, 10)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.nBorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnCancel.nDivider = False
        Me.btnCancel.nDividerColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnCancel.nFillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnCancel.nFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnCancel.nForeColor = System.Drawing.Color.White
        Me.btnCancel.nImage = Nothing
        Me.btnCancel.nImageV = False
        Me.btnCancel.nText = "Cancel"
        Me.btnCancel.nToggleBackColor = System.Drawing.Color.White
        Me.btnCancel.nToggleBorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnCancel.nToggleColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnCancel.Quality = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.btnCancel.RoundedCorners = 8
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Alert
        '
        Me.Alert.BackColor = System.Drawing.Color.White
        Me.Alert.coffeeBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Alert.coffeeClose = False
        Me.Alert.coffeeCloseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Alert.coffeeCloseHoverColor = System.Drawing.Color.White
        Me.Alert.coffeeDividerColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Alert.coffeeDividerVisible = False
        Me.Alert.coffeeFillColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Alert.coffeeHeader = "Coffee!"
        Me.Alert.coffeeHeaderColor = System.Drawing.Color.White
        Me.Alert.coffeeHeaderFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Alert.coffeeIcon = Nothing
        Me.Alert.coffeeIconSize = 36
        Me.Alert.coffeeIconSpacing = 5
        Me.Alert.coffeeIconVisible = False
        Me.Alert.coffeeShadowBorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Alert.coffeeText = "This is a custom Notecation!"
        Me.Alert.coffeeTextColor = System.Drawing.Color.White
        Me.Alert.coffeeTextFont = New System.Drawing.Font("Arial", 12.0!)
        Me.Alert.customBorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Alert.customClose = False
        Me.Alert.customCloseColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Alert.customCloseHoverColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Alert.customDividerColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Alert.customDividerVisible = False
        Me.Alert.customFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Alert.customHeader = "Default!"
        Me.Alert.customHeaderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Alert.customHeaderFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Alert.customIcon = Nothing
        Me.Alert.customIconSize = 36
        Me.Alert.customIconSpacing = 5
        Me.Alert.customIconVisible = False
        Me.Alert.customShadowBorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Alert.customText = "This is a custom Notecation!"
        Me.Alert.customTextColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Alert.customTextFont = New System.Drawing.Font("Arial", 12.0!)
        Me.Alert.errorBorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Alert.errorClose = False
        Me.Alert.errorCloseColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Alert.errorCloseHoverColor = System.Drawing.Color.White
        Me.Alert.errorDividerColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Alert.errorDividerVisible = True
        Me.Alert.errorFillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Alert.errorHeader = "Error!"
        Me.Alert.errorHeaderColor = System.Drawing.Color.White
        Me.Alert.errorHeaderFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Alert.errorIcon = Global.Pomf_Uploader.My.Resources.Resources._1473404002_sign_error
        Me.Alert.errorIconSize = 28
        Me.Alert.errorIconSpacing = 5
        Me.Alert.errorIconVisible = True
        Me.Alert.errorShadowBorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Alert.errorText = " Failed to Upload"
        Me.Alert.errorTextColor = System.Drawing.Color.White
        Me.Alert.errorTextFont = New System.Drawing.Font("Arial", 12.0!)
        Me.Alert.infoBorderColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Alert.infoClose = False
        Me.Alert.infoCloseColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Alert.infoCloseHoverColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.Alert.infoDividerColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Alert.infoDividerVisible = True
        Me.Alert.infoFillColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Alert.infoHeader = "Uploading!"
        Me.Alert.infoHeaderColor = System.Drawing.Color.White
        Me.Alert.infoHeaderFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Alert.infoIcon = Global.Pomf_Uploader.My.Resources.Resources._1473403991_sign_info
        Me.Alert.infoIconSize = 28
        Me.Alert.infoIconSpacing = 5
        Me.Alert.infoIconVisible = True
        Me.Alert.infoShadowBorderColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Alert.infoText = " Please wait..."
        Me.Alert.infoTextColor = System.Drawing.Color.White
        Me.Alert.infoTextFont = New System.Drawing.Font("Arial", 12.0!)
        Me.Alert.Location = New System.Drawing.Point(9, 48)
        Me.Alert.Name = "Alert"
        Me.Alert.Quality = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.Alert.RoundedCorners = 2
        Me.Alert.Size = New System.Drawing.Size(358, 38)
        Me.Alert.successBorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Alert.successClose = False
        Me.Alert.successCloseColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Alert.successCloseHoverColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Alert.successDividerColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Alert.successDividerVisible = True
        Me.Alert.successFillColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Alert.successHeader = "Success!"
        Me.Alert.successHeaderColor = System.Drawing.Color.White
        Me.Alert.successHeaderFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Alert.successIcon = Global.Pomf_Uploader.My.Resources.Resources._1473404319_sign_check
        Me.Alert.successIconSize = 28
        Me.Alert.successIconSpacing = 5
        Me.Alert.successIconVisible = True
        Me.Alert.successShadowBorderColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Alert.successText = "File Uploaded"
        Me.Alert.successTextColor = System.Drawing.Color.White
        Me.Alert.successTextFont = New System.Drawing.Font("Arial", 12.0!)
        Me.Alert.TabIndex = 0
        Me.Alert.Text = "SNotification1"
        Me.Alert.Type = Pomf_Uploader.sNotification.Types.Info
        Me.Alert.warningBorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Alert.warningClose = False
        Me.Alert.warningCloseColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Alert.warningCloseHoverColor = System.Drawing.Color.White
        Me.Alert.warningDividerColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Alert.warningDividerVisible = True
        Me.Alert.warningFillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Alert.warningHeader = "Update!"
        Me.Alert.warningHeaderColor = System.Drawing.Color.White
        Me.Alert.warningHeaderFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Alert.warningIcon = Global.Pomf_Uploader.My.Resources.Resources._1473403982_shield_warning
        Me.Alert.warningIconSize = 28
        Me.Alert.warningIconSpacing = 5
        Me.Alert.warningIconVisible = True
        Me.Alert.warningShadowBorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Alert.warningText = "There is a new version"
        Me.Alert.warningTextColor = System.Drawing.Color.White
        Me.Alert.warningTextFont = New System.Drawing.Font("Arial", 12.0!)
        '
        'tblink
        '
        Me.tblink._Error = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.tblink.Accept = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.tblink.AcceptBack = System.Drawing.Color.White
        Me.tblink.AcceptFontColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tblink.AcceptTrigger = Pomf_Uploader.sTextbox.TriggerType.Disable
        Me.tblink.AcceptTriggerDetail = "Example"
        Me.tblink.BackColor = System.Drawing.Color.Transparent
        Me.tblink.CustomBackColor = System.Drawing.Color.White
        Me.tblink.CustomColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tblink.CustomFontColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tblink.CustomTrigger = Pomf_Uploader.sTextbox.TriggerType.ContainStr
        Me.tblink.CustomTriggerDetail = "http://"
        Me.tblink.ErrorBack = System.Drawing.Color.White
        Me.tblink.ErrorFontColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tblink.ErrorTrigger = Pomf_Uploader.sTextbox.TriggerType.Disable
        Me.tblink.ErrorTriggerDetail = "0"
        Me.tblink.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tblink.lButtonBackColor = System.Drawing.Color.White
        Me.tblink.lButtonText = "Copy"
        Me.tblink.lButtonTextColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tblink.LeftButton = True
        Me.tblink.LeftButtonClickable = False
        Me.tblink.LeftButtonFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tblink.LeftButtonImage = Nothing
        Me.tblink.LeftButtonImageToggled = False
        Me.tblink.LeftButtonSize = 24
        Me.tblink.LeftButtonText = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tblink.LeftDivider = True
        Me.tblink.lHoverButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tblink.Location = New System.Drawing.Point(9, 101)
        Me.tblink.MaxLength = 32767
        Me.tblink.Multiline = False
        Me.tblink.Name = "tblink"
        Me.tblink.Quality = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.tblink.rButtonBackColor = System.Drawing.Color.White
        Me.tblink.rButtonText = "Open"
        Me.tblink.rButtonTextColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tblink.ReadOnly = True
        Me.tblink.Regular = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.tblink.Regularback = System.Drawing.Color.White
        Me.tblink.rHoverButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tblink.RightButton = True
        Me.tblink.RightButtonClickable = False
        Me.tblink.RightButtonFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tblink.RightButtonImage = Nothing
        Me.tblink.RightButtonImageToggled = False
        Me.tblink.RightButtonSize = 24
        Me.tblink.RightButtonText = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tblink.RightDivider = True
        Me.tblink.RoundCorners = 8
        Me.tblink.ShadowBorder = False
        Me.tblink.ShadowBorderColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.tblink.Size = New System.Drawing.Size(358, 33)
        Me.tblink.TabIndex = 1
        Me.tblink.Text = "Uploading..."
        Me.tblink.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tblink.TextBackColor = System.Drawing.Color.White
        Me.tblink.TextColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tblink.Type = Pomf_Uploader.sTextbox._Type.Custom
        Me.tblink.UseSystemPasswordChar = False
        Me.tblink.Warning = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tblink.WarningBack = System.Drawing.Color.White
        Me.tblink.WarningFontColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tblink.WarningTrigger = Pomf_Uploader.sTextbox.TriggerType.Disable
        Me.tblink.WarningTriggerDetail = "Uploading..."
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(382, 158)
        Me.Controls.Add(Me.gbHolder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Pomf Uploader"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.gbHolder.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Alert As sNotification
    Friend WithEvents tblink As sTextbox
    Friend WithEvents gbHolder As sGroupbox
    Friend WithEvents btnCancel As sButton
    Friend WithEvents btnUpdate As sButton
End Class
