<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
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
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QuickStartLabel = New System.Windows.Forms.Label()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LicenseNote = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.DateTimeDisplay1 = New AdvancedHMIControls.DateTimeDisplay()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Meter1 = New AdvancedHMIControls.Meter()
        Me.Odometer1 = New AdvancedHMIControls.Odometer()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 694)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'QuickStartLabel
        '
        Me.QuickStartLabel.AutoSize = True
        Me.QuickStartLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.QuickStartLabel.ForeColor = System.Drawing.Color.White
        Me.QuickStartLabel.Location = New System.Drawing.Point(9, 16)
        Me.QuickStartLabel.Name = "QuickStartLabel"
        Me.QuickStartLabel.Size = New System.Drawing.Size(381, 160)
        Me.QuickStartLabel.TabIndex = 38
        Me.QuickStartLabel.Text = resources.GetString("QuickStartLabel.Text")
        Me.QuickStartLabel.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(768, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(322, 47)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'LicenseNote
        '
        Me.LicenseNote.AutoSize = True
        Me.LicenseNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LicenseNote.ForeColor = System.Drawing.Color.White
        Me.LicenseNote.Location = New System.Drawing.Point(19, 264)
        Me.LicenseNote.Name = "LicenseNote"
        Me.LicenseNote.Size = New System.Drawing.Size(1050, 50)
        Me.LicenseNote.TabIndex = 54
        Me.LicenseNote.Text = "By Using This Software You Agree to the UsageAndLicense.txt" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AdvancedHMI is licen" &
    "sed under a GPL model which means you must pass on the full source to the end us" &
    "er."
        Me.LicenseNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LicenseNote.Visible = False
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "192.168.0.10"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'DateTimeDisplay1
        '
        Me.DateTimeDisplay1.AutoSize = True
        Me.DateTimeDisplay1.DisplayFormat = "MM/dd/yyyy hh:mm:ss"
        Me.DateTimeDisplay1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DateTimeDisplay1.Location = New System.Drawing.Point(873, 60)
        Me.DateTimeDisplay1.Name = "DateTimeDisplay1"
        Me.DateTimeDisplay1.Size = New System.Drawing.Size(229, 27)
        Me.DateTimeDisplay1.TabIndex = 55
        Me.DateTimeDisplay1.Text = "02.04.2018 01:25:07"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(462, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 39)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Meter1
        '
        Me.Meter1.ComComponent = Me.EthernetIPforCLXCom1
        Me.Meter1.HighlightColor = System.Drawing.Color.Red
        Me.Meter1.Location = New System.Drawing.Point(24, 16)
        Me.Meter1.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.Meter1.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Meter1.Name = "Meter1"
        Me.Meter1.NumericFormat = Nothing
        Me.Meter1.PLCAddressText = ""
        Me.Meter1.PLCAddressValue = ""
        Me.Meter1.PLCAddressVisible = ""
        Me.Meter1.Size = New System.Drawing.Size(320, 274)
        Me.Meter1.TabIndex = 57
        Me.Meter1.Text = "Meter1"
        Me.Meter1.Value = 0R
        Me.Meter1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Odometer1
        '
        Me.Odometer1.BackColorAfterDecimal = System.Drawing.Color.Black
        Me.Odometer1.ComComponent = Me.EthernetIPforCLXCom1
        Me.Odometer1.ForeColorAfterDecimal = System.Drawing.Color.White
        Me.Odometer1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.Odometer1.KeypadMaxValue = 0R
        Me.Odometer1.KeypadMinValue = 0R
        Me.Odometer1.KeypadScaleFactor = 1.0R
        Me.Odometer1.KeypadText = Nothing
        Me.Odometer1.KeypadWidth = 300
        Me.Odometer1.Location = New System.Drawing.Point(462, 208)
        Me.Odometer1.Name = "Odometer1"
        Me.Odometer1.NumberOfDigits = 5
        Me.Odometer1.NumberOfDigitsAfterDecimal = 1
        Me.Odometer1.PLCAddressKeypad = ""
        Me.Odometer1.PLCAddressValue = Nothing
        Me.Odometer1.Size = New System.Drawing.Size(200, 37)
        Me.Odometer1.TabIndex = 58
        Me.Odometer1.Text = "Odometer1"
        Me.Odometer1.Value = 0R
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1090, 619)
        Me.Controls.Add(Me.Odometer1)
        Me.Controls.Add(Me.Meter1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimeDisplay1)
        Me.Controls.Add(Me.LicenseNote)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.QuickStartLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AdvancedHMI v3.99x"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QuickStartLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents LicenseNote As Label
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents DateTimeDisplay1 As AdvancedHMIControls.DateTimeDisplay
    Friend WithEvents Button1 As Button
    Friend WithEvents Meter1 As AdvancedHMIControls.Meter
    Friend WithEvents Odometer1 As AdvancedHMIControls.Odometer
End Class
