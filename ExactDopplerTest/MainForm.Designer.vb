﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me._switchOnButton = New System.Windows.Forms.Button()
        Me._sineGenSwitchOffButton = New System.Windows.Forms.Button()
        Me._sineFreqTrackBar = New System.Windows.Forms.TrackBar()
        Me._topFrequencyGroupBox = New System.Windows.Forms.GroupBox()
        Me._topFreqOnlyCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._freq2Label = New System.Windows.Forms.Label()
        Me._freq1Label = New System.Windows.Forms.Label()
        Me._volumeTrackBar = New System.Windows.Forms.TrackBar()
        Me._outputGroupBox = New System.Windows.Forms.GroupBox()
        Me._outTestButton = New System.Windows.Forms.Button()
        Me._outputAudioDevicesRefreshButton = New System.Windows.Forms.Button()
        Me._outputAudioDevicesListBox = New System.Windows.Forms.ListBox()
        Me._inputGroupBox = New System.Windows.Forms.GroupBox()
        Me._speedXLabel = New System.Windows.Forms.Label()
        Me._speedXLabel_ = New System.Windows.Forms.Label()
        Me._alarmCheckBox = New System.Windows.Forms.CheckBox()
        Me._scrButton = New System.Windows.Forms.Button()
        Me._centralBlindZoneGroupBox = New System.Windows.Forms.GroupBox()
        Me._blindZoneLabel = New System.Windows.Forms.Label()
        Me._blindZoneTrackBar = New System.Windows.Forms.TrackBar()
        Me._inputAudioDevicesRefreshButton = New System.Windows.Forms.Button()
        Me._inputAudioDevicesListBox = New System.Windows.Forms.ListBox()
        Me._blocksLabel_ = New System.Windows.Forms.Label()
        Me._captureOffButton = New System.Windows.Forms.Button()
        Me._blocksLabel = New System.Windows.Forms.Label()
        Me._captureOnButton = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me._dopplerLogGroupBox = New System.Windows.Forms.GroupBox()
        Me._dopplerLogTextBox = New System.Windows.Forms.TextBox()
        Me._waterfallGroupBox = New System.Windows.Forms.GroupBox()
        Me._fastModeCheckBox = New System.Windows.Forms.CheckBox()
        Me._rawImageCheckBox = New System.Windows.Forms.CheckBox()
        Me._waterfallDisplayBitmapControl = New Bwl.Imaging.DisplayBitmapControl()
        CType(Me._sineFreqTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._topFrequencyGroupBox.SuspendLayout()
        CType(Me._volumeTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._outputGroupBox.SuspendLayout()
        Me._inputGroupBox.SuspendLayout()
        Me._centralBlindZoneGroupBox.SuspendLayout()
        CType(Me._blindZoneTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._dopplerLogGroupBox.SuspendLayout()
        Me._waterfallGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        '_switchOnButton
        '
        Me._switchOnButton.BackColor = System.Drawing.Color.MediumSpringGreen
        Me._switchOnButton.Location = New System.Drawing.Point(6, 327)
        Me._switchOnButton.Name = "_switchOnButton"
        Me._switchOnButton.Size = New System.Drawing.Size(161, 32)
        Me._switchOnButton.TabIndex = 7
        Me._switchOnButton.Text = "Sine Gen On"
        Me._switchOnButton.UseVisualStyleBackColor = False
        '
        '_sineGenSwitchOffButton
        '
        Me._sineGenSwitchOffButton.BackColor = System.Drawing.Color.Silver
        Me._sineGenSwitchOffButton.Location = New System.Drawing.Point(173, 327)
        Me._sineGenSwitchOffButton.Name = "_sineGenSwitchOffButton"
        Me._sineGenSwitchOffButton.Size = New System.Drawing.Size(47, 32)
        Me._sineGenSwitchOffButton.TabIndex = 8
        Me._sineGenSwitchOffButton.Text = "Off"
        Me._sineGenSwitchOffButton.UseVisualStyleBackColor = False
        '
        '_sineFreqTrackBar
        '
        Me._sineFreqTrackBar.Location = New System.Drawing.Point(6, 34)
        Me._sineFreqTrackBar.Maximum = 48
        Me._sineFreqTrackBar.Name = "_sineFreqTrackBar"
        Me._sineFreqTrackBar.Size = New System.Drawing.Size(202, 45)
        Me._sineFreqTrackBar.TabIndex = 4
        Me._sineFreqTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me._sineFreqTrackBar.Value = 42
        '
        '_topFrequencyGroupBox
        '
        Me._topFrequencyGroupBox.Controls.Add(Me._topFreqOnlyCheckBox)
        Me._topFrequencyGroupBox.Controls.Add(Me.Label1)
        Me._topFrequencyGroupBox.Controls.Add(Me._freq2Label)
        Me._topFrequencyGroupBox.Controls.Add(Me._freq1Label)
        Me._topFrequencyGroupBox.Controls.Add(Me._sineFreqTrackBar)
        Me._topFrequencyGroupBox.Location = New System.Drawing.Point(6, 201)
        Me._topFrequencyGroupBox.Name = "_topFrequencyGroupBox"
        Me._topFrequencyGroupBox.Size = New System.Drawing.Size(214, 82)
        Me._topFrequencyGroupBox.TabIndex = 3
        Me._topFrequencyGroupBox.TabStop = False
        Me._topFrequencyGroupBox.Text = "Frequencies"
        '
        '_topFreqOnlyCheckBox
        '
        Me._topFreqOnlyCheckBox.AutoSize = True
        Me._topFreqOnlyCheckBox.Checked = True
        Me._topFreqOnlyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me._topFreqOnlyCheckBox.Location = New System.Drawing.Point(116, 0)
        Me._topFreqOnlyCheckBox.Name = "_topFreqOnlyCheckBox"
        Me._topFreqOnlyCheckBox.Size = New System.Drawing.Size(93, 17)
        Me._topFreqOnlyCheckBox.TabIndex = 3
        Me._topFreqOnlyCheckBox.Text = "Top Freq Only"
        Me._topFreqOnlyCheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "+"
        '
        '_freq2Label
        '
        Me._freq2Label.AutoSize = True
        Me._freq2Label.Location = New System.Drawing.Point(87, 20)
        Me._freq2Label.Name = "_freq2Label"
        Me._freq2Label.Size = New System.Drawing.Size(13, 13)
        Me._freq2Label.TabIndex = 6
        Me._freq2Label.Text = "0"
        '
        '_freq1Label
        '
        Me._freq1Label.AutoSize = True
        Me._freq1Label.Location = New System.Drawing.Point(6, 20)
        Me._freq1Label.Name = "_freq1Label"
        Me._freq1Label.Size = New System.Drawing.Size(13, 13)
        Me._freq1Label.TabIndex = 4
        Me._freq1Label.Text = "0"
        '
        '_volumeTrackBar
        '
        Me._volumeTrackBar.Location = New System.Drawing.Point(222, 201)
        Me._volumeTrackBar.Maximum = 100
        Me._volumeTrackBar.Name = "_volumeTrackBar"
        Me._volumeTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me._volumeTrackBar.Size = New System.Drawing.Size(45, 158)
        Me._volumeTrackBar.TabIndex = 5
        Me._volumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me._volumeTrackBar.Value = 90
        '
        '_outputGroupBox
        '
        Me._outputGroupBox.Controls.Add(Me._outTestButton)
        Me._outputGroupBox.Controls.Add(Me._outputAudioDevicesRefreshButton)
        Me._outputGroupBox.Controls.Add(Me._switchOnButton)
        Me._outputGroupBox.Controls.Add(Me._outputAudioDevicesListBox)
        Me._outputGroupBox.Controls.Add(Me._sineGenSwitchOffButton)
        Me._outputGroupBox.Controls.Add(Me._topFrequencyGroupBox)
        Me._outputGroupBox.Controls.Add(Me._volumeTrackBar)
        Me._outputGroupBox.Location = New System.Drawing.Point(12, 12)
        Me._outputGroupBox.Name = "_outputGroupBox"
        Me._outputGroupBox.Size = New System.Drawing.Size(269, 365)
        Me._outputGroupBox.TabIndex = 0
        Me._outputGroupBox.TabStop = False
        Me._outputGroupBox.Text = "Output [ OFF ]"
        '
        '_outTestButton
        '
        Me._outTestButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me._outTestButton.Location = New System.Drawing.Point(6, 289)
        Me._outTestButton.Name = "_outTestButton"
        Me._outTestButton.Size = New System.Drawing.Size(161, 32)
        Me._outTestButton.TabIndex = 6
        Me._outTestButton.Text = "dtmf.Play(""151 262 888 111"")"
        Me._outTestButton.UseVisualStyleBackColor = False
        '
        '_outputAudioDevicesRefreshButton
        '
        Me._outputAudioDevicesRefreshButton.Location = New System.Drawing.Point(6, 172)
        Me._outputAudioDevicesRefreshButton.Name = "_outputAudioDevicesRefreshButton"
        Me._outputAudioDevicesRefreshButton.Size = New System.Drawing.Size(256, 23)
        Me._outputAudioDevicesRefreshButton.TabIndex = 2
        Me._outputAudioDevicesRefreshButton.UseVisualStyleBackColor = True
        '
        '_outputAudioDevicesListBox
        '
        Me._outputAudioDevicesListBox.FormattingEnabled = True
        Me._outputAudioDevicesListBox.Location = New System.Drawing.Point(6, 19)
        Me._outputAudioDevicesListBox.Name = "_outputAudioDevicesListBox"
        Me._outputAudioDevicesListBox.Size = New System.Drawing.Size(256, 147)
        Me._outputAudioDevicesListBox.TabIndex = 1
        '
        '_inputGroupBox
        '
        Me._inputGroupBox.Controls.Add(Me._speedXLabel)
        Me._inputGroupBox.Controls.Add(Me._speedXLabel_)
        Me._inputGroupBox.Controls.Add(Me._alarmCheckBox)
        Me._inputGroupBox.Controls.Add(Me._scrButton)
        Me._inputGroupBox.Controls.Add(Me._centralBlindZoneGroupBox)
        Me._inputGroupBox.Controls.Add(Me._inputAudioDevicesRefreshButton)
        Me._inputGroupBox.Controls.Add(Me._inputAudioDevicesListBox)
        Me._inputGroupBox.Controls.Add(Me._blocksLabel_)
        Me._inputGroupBox.Controls.Add(Me._captureOffButton)
        Me._inputGroupBox.Controls.Add(Me._blocksLabel)
        Me._inputGroupBox.Controls.Add(Me._captureOnButton)
        Me._inputGroupBox.Location = New System.Drawing.Point(292, 12)
        Me._inputGroupBox.Name = "_inputGroupBox"
        Me._inputGroupBox.Size = New System.Drawing.Size(268, 365)
        Me._inputGroupBox.TabIndex = 9
        Me._inputGroupBox.TabStop = False
        Me._inputGroupBox.Text = "Input [ OFF ]"
        '
        '_speedXLabel
        '
        Me._speedXLabel.AutoSize = True
        Me._speedXLabel.Location = New System.Drawing.Point(58, 308)
        Me._speedXLabel.Name = "_speedXLabel"
        Me._speedXLabel.Size = New System.Drawing.Size(13, 13)
        Me._speedXLabel.TabIndex = 18
        Me._speedXLabel.Text = "1"
        '
        '_speedXLabel_
        '
        Me._speedXLabel_.AutoSize = True
        Me._speedXLabel_.Location = New System.Drawing.Point(10, 308)
        Me._speedXLabel_.Name = "_speedXLabel_"
        Me._speedXLabel_.Size = New System.Drawing.Size(48, 13)
        Me._speedXLabel_.TabIndex = 15
        Me._speedXLabel_.Text = "SpeedX:"
        '
        '_alarmCheckBox
        '
        Me._alarmCheckBox.AutoSize = True
        Me._alarmCheckBox.BackColor = System.Drawing.Color.DeepSkyBlue
        Me._alarmCheckBox.Location = New System.Drawing.Point(113, 298)
        Me._alarmCheckBox.Name = "_alarmCheckBox"
        Me._alarmCheckBox.Size = New System.Drawing.Size(94, 17)
        Me._alarmCheckBox.TabIndex = 14
        Me._alarmCheckBox.Text = "ALARM TEST"
        Me._alarmCheckBox.UseVisualStyleBackColor = False
        '
        '_scrButton
        '
        Me._scrButton.BackColor = System.Drawing.Color.Silver
        Me._scrButton.Location = New System.Drawing.Point(214, 289)
        Me._scrButton.Name = "_scrButton"
        Me._scrButton.Size = New System.Drawing.Size(47, 32)
        Me._scrButton.TabIndex = 15
        Me._scrButton.Text = "Scr"
        Me._scrButton.UseVisualStyleBackColor = False
        '
        '_centralBlindZoneGroupBox
        '
        Me._centralBlindZoneGroupBox.Controls.Add(Me._blindZoneLabel)
        Me._centralBlindZoneGroupBox.Controls.Add(Me._blindZoneTrackBar)
        Me._centralBlindZoneGroupBox.Location = New System.Drawing.Point(9, 201)
        Me._centralBlindZoneGroupBox.Name = "_centralBlindZoneGroupBox"
        Me._centralBlindZoneGroupBox.Size = New System.Drawing.Size(252, 82)
        Me._centralBlindZoneGroupBox.TabIndex = 12
        Me._centralBlindZoneGroupBox.TabStop = False
        Me._centralBlindZoneGroupBox.Text = "Central ""Blind Zone"""
        '
        '_blindZoneLabel
        '
        Me._blindZoneLabel.AutoSize = True
        Me._blindZoneLabel.Location = New System.Drawing.Point(6, 20)
        Me._blindZoneLabel.Name = "_blindZoneLabel"
        Me._blindZoneLabel.Size = New System.Drawing.Size(13, 13)
        Me._blindZoneLabel.TabIndex = 14
        Me._blindZoneLabel.Text = "0"
        '
        '_blindZoneTrackBar
        '
        Me._blindZoneTrackBar.Location = New System.Drawing.Point(6, 34)
        Me._blindZoneTrackBar.Maximum = 100
        Me._blindZoneTrackBar.Minimum = 1
        Me._blindZoneTrackBar.Name = "_blindZoneTrackBar"
        Me._blindZoneTrackBar.Size = New System.Drawing.Size(240, 45)
        Me._blindZoneTrackBar.TabIndex = 13
        Me._blindZoneTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me._blindZoneTrackBar.Value = 60
        '
        '_inputAudioDevicesRefreshButton
        '
        Me._inputAudioDevicesRefreshButton.Location = New System.Drawing.Point(6, 172)
        Me._inputAudioDevicesRefreshButton.Name = "_inputAudioDevicesRefreshButton"
        Me._inputAudioDevicesRefreshButton.Size = New System.Drawing.Size(256, 23)
        Me._inputAudioDevicesRefreshButton.TabIndex = 11
        Me._inputAudioDevicesRefreshButton.UseVisualStyleBackColor = True
        '
        '_inputAudioDevicesListBox
        '
        Me._inputAudioDevicesListBox.FormattingEnabled = True
        Me._inputAudioDevicesListBox.Location = New System.Drawing.Point(6, 19)
        Me._inputAudioDevicesListBox.Name = "_inputAudioDevicesListBox"
        Me._inputAudioDevicesListBox.Size = New System.Drawing.Size(256, 147)
        Me._inputAudioDevicesListBox.TabIndex = 10
        '
        '_blocksLabel_
        '
        Me._blocksLabel_.AutoSize = True
        Me._blocksLabel_.Location = New System.Drawing.Point(10, 289)
        Me._blocksLabel_.Name = "_blocksLabel_"
        Me._blocksLabel_.Size = New System.Drawing.Size(42, 13)
        Me._blocksLabel_.TabIndex = 16
        Me._blocksLabel_.Text = "Blocks:"
        '
        '_captureOffButton
        '
        Me._captureOffButton.BackColor = System.Drawing.Color.Silver
        Me._captureOffButton.Location = New System.Drawing.Point(214, 327)
        Me._captureOffButton.Name = "_captureOffButton"
        Me._captureOffButton.Size = New System.Drawing.Size(47, 32)
        Me._captureOffButton.TabIndex = 17
        Me._captureOffButton.Text = "Off"
        Me._captureOffButton.UseVisualStyleBackColor = False
        '
        '_blocksLabel
        '
        Me._blocksLabel.AutoSize = True
        Me._blocksLabel.Location = New System.Drawing.Point(58, 289)
        Me._blocksLabel.Name = "_blocksLabel"
        Me._blocksLabel.Size = New System.Drawing.Size(13, 13)
        Me._blocksLabel.TabIndex = 17
        Me._blocksLabel.Text = "0"
        '
        '_captureOnButton
        '
        Me._captureOnButton.BackColor = System.Drawing.Color.MediumSpringGreen
        Me._captureOnButton.Location = New System.Drawing.Point(9, 327)
        Me._captureOnButton.Name = "_captureOnButton"
        Me._captureOnButton.Size = New System.Drawing.Size(199, 32)
        Me._captureOnButton.TabIndex = 16
        Me._captureOnButton.Text = "Capture On"
        Me._captureOnButton.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 719)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(106, 13)
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://iconleak.com/"
        '
        '_dopplerLogGroupBox
        '
        Me._dopplerLogGroupBox.Controls.Add(Me._dopplerLogTextBox)
        Me._dopplerLogGroupBox.Location = New System.Drawing.Point(12, 657)
        Me._dopplerLogGroupBox.Name = "_dopplerLogGroupBox"
        Me._dopplerLogGroupBox.Size = New System.Drawing.Size(548, 59)
        Me._dopplerLogGroupBox.TabIndex = 22
        Me._dopplerLogGroupBox.TabStop = False
        Me._dopplerLogGroupBox.Text = "DopplerLog"
        '
        '_dopplerLogTextBox
        '
        Me._dopplerLogTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me._dopplerLogTextBox.Location = New System.Drawing.Point(6, 19)
        Me._dopplerLogTextBox.Multiline = True
        Me._dopplerLogTextBox.Name = "_dopplerLogTextBox"
        Me._dopplerLogTextBox.Size = New System.Drawing.Size(536, 32)
        Me._dopplerLogTextBox.TabIndex = 23
        '
        '_waterfallGroupBox
        '
        Me._waterfallGroupBox.Controls.Add(Me._fastModeCheckBox)
        Me._waterfallGroupBox.Controls.Add(Me._rawImageCheckBox)
        Me._waterfallGroupBox.Controls.Add(Me._waterfallDisplayBitmapControl)
        Me._waterfallGroupBox.Location = New System.Drawing.Point(12, 383)
        Me._waterfallGroupBox.Name = "_waterfallGroupBox"
        Me._waterfallGroupBox.Size = New System.Drawing.Size(548, 268)
        Me._waterfallGroupBox.TabIndex = 18
        Me._waterfallGroupBox.TabStop = False
        Me._waterfallGroupBox.Text = "Waterfall"
        '
        '_fastModeCheckBox
        '
        Me._fastModeCheckBox.AutoSize = True
        Me._fastModeCheckBox.Location = New System.Drawing.Point(280, -1)
        Me._fastModeCheckBox.Name = "_fastModeCheckBox"
        Me._fastModeCheckBox.Size = New System.Drawing.Size(76, 17)
        Me._fastModeCheckBox.TabIndex = 20
        Me._fastModeCheckBox.Text = "Fast Mode"
        Me._fastModeCheckBox.UseVisualStyleBackColor = True
        '
        '_rawImageCheckBox
        '
        Me._rawImageCheckBox.AutoSize = True
        Me._rawImageCheckBox.Location = New System.Drawing.Point(59, -1)
        Me._rawImageCheckBox.Name = "_rawImageCheckBox"
        Me._rawImageCheckBox.Size = New System.Drawing.Size(80, 17)
        Me._rawImageCheckBox.TabIndex = 19
        Me._rawImageCheckBox.Text = "Raw Image"
        Me._rawImageCheckBox.UseVisualStyleBackColor = True
        '
        '_waterfallDisplayBitmapControl
        '
        Me._waterfallDisplayBitmapControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me._waterfallDisplayBitmapControl.Bitmap = CType(resources.GetObject("_waterfallDisplayBitmapControl.Bitmap"), System.Drawing.Bitmap)
        Me._waterfallDisplayBitmapControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._waterfallDisplayBitmapControl.Location = New System.Drawing.Point(6, 19)
        Me._waterfallDisplayBitmapControl.Name = "_waterfallDisplayBitmapControl"
        Me._waterfallDisplayBitmapControl.Size = New System.Drawing.Size(536, 243)
        Me._waterfallDisplayBitmapControl.TabIndex = 21
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 741)
        Me.Controls.Add(Me._waterfallGroupBox)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me._dopplerLogGroupBox)
        Me.Controls.Add(Me._inputGroupBox)
        Me.Controls.Add(Me._outputGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExactDopplerTest"
        CType(Me._sineFreqTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me._topFrequencyGroupBox.ResumeLayout(False)
        Me._topFrequencyGroupBox.PerformLayout()
        CType(Me._volumeTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me._outputGroupBox.ResumeLayout(False)
        Me._outputGroupBox.PerformLayout()
        Me._inputGroupBox.ResumeLayout(False)
        Me._inputGroupBox.PerformLayout()
        Me._centralBlindZoneGroupBox.ResumeLayout(False)
        Me._centralBlindZoneGroupBox.PerformLayout()
        CType(Me._blindZoneTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me._dopplerLogGroupBox.ResumeLayout(False)
        Me._dopplerLogGroupBox.PerformLayout()
        Me._waterfallGroupBox.ResumeLayout(False)
        Me._waterfallGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _switchOnButton As Button
    Friend WithEvents _sineGenSwitchOffButton As Button
    Friend WithEvents _sineFreqTrackBar As TrackBar
    Friend WithEvents _topFrequencyGroupBox As GroupBox
    Friend WithEvents _freq1Label As Label
    Friend WithEvents _volumeTrackBar As TrackBar
    Friend WithEvents _outputGroupBox As GroupBox
    Friend WithEvents _outputAudioDevicesRefreshButton As Button
    Friend WithEvents _outputAudioDevicesListBox As ListBox
    Friend WithEvents _inputGroupBox As GroupBox
    Friend WithEvents _inputAudioDevicesListBox As ListBox
    Friend WithEvents _inputAudioDevicesRefreshButton As Button
    Friend WithEvents _captureOffButton As Button
    Friend WithEvents _blocksLabel As Label
    Friend WithEvents _blocksLabel_ As Label
    Friend WithEvents _captureOnButton As Button
    Friend WithEvents _centralBlindZoneGroupBox As GroupBox
    Friend WithEvents _blindZoneLabel As Label
    Friend WithEvents _blindZoneTrackBar As TrackBar
    Friend WithEvents _outTestButton As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents _scrButton As System.Windows.Forms.Button
    Friend WithEvents _dopplerLogGroupBox As GroupBox
    Friend WithEvents _dopplerLogTextBox As TextBox
    Friend WithEvents _waterfallGroupBox As GroupBox
    Friend WithEvents _waterfallDisplayBitmapControl As Bwl.Imaging.DisplayBitmapControl
    Friend WithEvents _freq2Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents _rawImageCheckBox As CheckBox
    Friend WithEvents _alarmCheckBox As CheckBox
    Friend WithEvents _topFreqOnlyCheckBox As CheckBox
    Friend WithEvents _fastModeCheckBox As CheckBox
    Friend WithEvents _speedXLabel_ As Label
    Friend WithEvents _speedXLabel As Label
End Class
