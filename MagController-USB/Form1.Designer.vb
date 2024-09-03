<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MagnetTypeL = New System.Windows.Forms.Label()
        Me.MagFieldL = New System.Windows.Forms.Label()
        Me.HeaterButton = New System.Windows.Forms.Button()
        Me.GoToHiButton = New System.Windows.Forms.Button()
        Me.GoToLowButton = New System.Windows.Forms.Button()
        Me.SiftMagButton = New System.Windows.Forms.Button()
        Me.SiftZeroButton = New System.Windows.Forms.Button()
        Me.HiTB = New System.Windows.Forms.TextBox()
        Me.LowTB = New System.Windows.Forms.TextBox()
        Me.HiSETButton = New System.Windows.Forms.Button()
        Me.LowSetButton = New System.Windows.Forms.Button()
        Me.OUTFieldL = New System.Windows.Forms.Label()
        Me.OUTFieldVL = New System.Windows.Forms.Label()
        Me.Rate0TB = New System.Windows.Forms.TextBox()
        Me.Rate1TB = New System.Windows.Forms.TextBox()
        Me.Range0L = New System.Windows.Forms.Label()
        Me.Range1L = New System.Windows.Forms.Label()
        Me.Range2L = New System.Windows.Forms.Label()
        Me.Rate2TB = New System.Windows.Forms.TextBox()
        Me.Rate0SETButton = New System.Windows.Forms.Button()
        Me.Rate1SETButton = New System.Windows.Forms.Button()
        Me.Rate2SETButton = New System.Windows.Forms.Button()
        Me.ReLoad = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.UNIT = New System.Windows.Forms.Label()
        Me.UNITSETButton = New System.Windows.Forms.Button()
        Me.HeaterStateL = New System.Windows.Forms.Label()
        Me.PauseButton = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SweepStateL = New System.Windows.Forms.Label()
        Me.ModeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(27, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MagnetType"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Magnet"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 80)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "電源"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 206)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "HighLimit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 232)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "LowLimit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 154)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ヒーター"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 262)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "スイープレート"
        '
        'MagnetTypeL
        '
        Me.MagnetTypeL.AutoSize = True
        Me.MagnetTypeL.ForeColor = System.Drawing.Color.Black
        Me.MagnetTypeL.Location = New System.Drawing.Point(106, 24)
        Me.MagnetTypeL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MagnetTypeL.Name = "MagnetTypeL"
        Me.MagnetTypeL.Size = New System.Drawing.Size(14, 13)
        Me.MagnetTypeL.TabIndex = 7
        Me.MagnetTypeL.Text = "-"
        '
        'MagFieldL
        '
        Me.MagFieldL.AutoSize = True
        Me.MagFieldL.Location = New System.Drawing.Point(106, 54)
        Me.MagFieldL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MagFieldL.Name = "MagFieldL"
        Me.MagFieldL.Size = New System.Drawing.Size(14, 13)
        Me.MagFieldL.TabIndex = 8
        Me.MagFieldL.Text = "-"
        '
        'HeaterButton
        '
        Me.HeaterButton.Location = New System.Drawing.Point(104, 143)
        Me.HeaterButton.Margin = New System.Windows.Forms.Padding(2)
        Me.HeaterButton.Name = "HeaterButton"
        Me.HeaterButton.Size = New System.Drawing.Size(56, 26)
        Me.HeaterButton.TabIndex = 9
        Me.HeaterButton.Text = "ON"
        Me.HeaterButton.UseVisualStyleBackColor = True
        '
        'GoToHiButton
        '
        Me.GoToHiButton.Location = New System.Drawing.Point(254, 201)
        Me.GoToHiButton.Margin = New System.Windows.Forms.Padding(2)
        Me.GoToHiButton.Name = "GoToHiButton"
        Me.GoToHiButton.Size = New System.Drawing.Size(63, 22)
        Me.GoToHiButton.TabIndex = 10
        Me.GoToHiButton.Text = "GoToHi"
        Me.GoToHiButton.UseVisualStyleBackColor = True
        '
        'GoToLowButton
        '
        Me.GoToLowButton.Location = New System.Drawing.Point(254, 226)
        Me.GoToLowButton.Margin = New System.Windows.Forms.Padding(2)
        Me.GoToLowButton.Name = "GoToLowButton"
        Me.GoToLowButton.Size = New System.Drawing.Size(68, 22)
        Me.GoToLowButton.TabIndex = 11
        Me.GoToLowButton.Text = "GoToLow"
        Me.GoToLowButton.UseVisualStyleBackColor = True
        '
        'SiftMagButton
        '
        Me.SiftMagButton.Location = New System.Drawing.Point(188, 143)
        Me.SiftMagButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SiftMagButton.Name = "SiftMagButton"
        Me.SiftMagButton.Size = New System.Drawing.Size(62, 26)
        Me.SiftMagButton.TabIndex = 12
        Me.SiftMagButton.Text = "SiftMag"
        Me.SiftMagButton.UseVisualStyleBackColor = True
        '
        'SiftZeroButton
        '
        Me.SiftZeroButton.Location = New System.Drawing.Point(254, 143)
        Me.SiftZeroButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SiftZeroButton.Name = "SiftZeroButton"
        Me.SiftZeroButton.Size = New System.Drawing.Size(68, 26)
        Me.SiftZeroButton.TabIndex = 13
        Me.SiftZeroButton.Text = "SiftZero"
        Me.SiftZeroButton.UseVisualStyleBackColor = True
        '
        'HiTB
        '
        Me.HiTB.Location = New System.Drawing.Point(105, 203)
        Me.HiTB.Margin = New System.Windows.Forms.Padding(2)
        Me.HiTB.Name = "HiTB"
        Me.HiTB.Size = New System.Drawing.Size(87, 19)
        Me.HiTB.TabIndex = 14
        '
        'LowTB
        '
        Me.LowTB.Location = New System.Drawing.Point(104, 229)
        Me.LowTB.Margin = New System.Windows.Forms.Padding(2)
        Me.LowTB.Name = "LowTB"
        Me.LowTB.Size = New System.Drawing.Size(88, 19)
        Me.LowTB.TabIndex = 15
        '
        'HiSETButton
        '
        Me.HiSETButton.Location = New System.Drawing.Point(196, 201)
        Me.HiSETButton.Margin = New System.Windows.Forms.Padding(2)
        Me.HiSETButton.Name = "HiSETButton"
        Me.HiSETButton.Size = New System.Drawing.Size(38, 22)
        Me.HiSETButton.TabIndex = 16
        Me.HiSETButton.Text = "SET"
        Me.HiSETButton.UseVisualStyleBackColor = True
        '
        'LowSetButton
        '
        Me.LowSetButton.Location = New System.Drawing.Point(196, 226)
        Me.LowSetButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LowSetButton.Name = "LowSetButton"
        Me.LowSetButton.Size = New System.Drawing.Size(38, 22)
        Me.LowSetButton.TabIndex = 17
        Me.LowSetButton.Text = "SET"
        Me.LowSetButton.UseVisualStyleBackColor = True
        '
        'OUTFieldL
        '
        Me.OUTFieldL.AutoSize = True
        Me.OUTFieldL.Location = New System.Drawing.Point(106, 80)
        Me.OUTFieldL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.OUTFieldL.Name = "OUTFieldL"
        Me.OUTFieldL.Size = New System.Drawing.Size(14, 13)
        Me.OUTFieldL.TabIndex = 18
        Me.OUTFieldL.Text = "-"
        '
        'OUTFieldVL
        '
        Me.OUTFieldVL.AutoSize = True
        Me.OUTFieldVL.Location = New System.Drawing.Point(183, 80)
        Me.OUTFieldVL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.OUTFieldVL.Name = "OUTFieldVL"
        Me.OUTFieldVL.Size = New System.Drawing.Size(14, 13)
        Me.OUTFieldVL.TabIndex = 19
        Me.OUTFieldVL.Text = "-"
        '
        'Rate0TB
        '
        Me.Rate0TB.Location = New System.Drawing.Point(175, 302)
        Me.Rate0TB.Margin = New System.Windows.Forms.Padding(2)
        Me.Rate0TB.Name = "Rate0TB"
        Me.Rate0TB.Size = New System.Drawing.Size(76, 19)
        Me.Rate0TB.TabIndex = 20
        '
        'Rate1TB
        '
        Me.Rate1TB.Location = New System.Drawing.Point(174, 324)
        Me.Rate1TB.Margin = New System.Windows.Forms.Padding(2)
        Me.Rate1TB.Name = "Rate1TB"
        Me.Rate1TB.Size = New System.Drawing.Size(76, 19)
        Me.Rate1TB.TabIndex = 21
        '
        'Range0L
        '
        Me.Range0L.AutoSize = True
        Me.Range0L.Location = New System.Drawing.Point(50, 305)
        Me.Range0L.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Range0L.Name = "Range0L"
        Me.Range0L.Size = New System.Drawing.Size(14, 13)
        Me.Range0L.TabIndex = 22
        Me.Range0L.Text = "-"
        '
        'Range1L
        '
        Me.Range1L.AutoSize = True
        Me.Range1L.Location = New System.Drawing.Point(50, 327)
        Me.Range1L.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Range1L.Name = "Range1L"
        Me.Range1L.Size = New System.Drawing.Size(14, 13)
        Me.Range1L.TabIndex = 23
        Me.Range1L.Text = "-"
        '
        'Range2L
        '
        Me.Range2L.AutoSize = True
        Me.Range2L.Location = New System.Drawing.Point(50, 350)
        Me.Range2L.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Range2L.Name = "Range2L"
        Me.Range2L.Size = New System.Drawing.Size(14, 13)
        Me.Range2L.TabIndex = 24
        Me.Range2L.Text = "-"
        '
        'Rate2TB
        '
        Me.Rate2TB.Location = New System.Drawing.Point(174, 346)
        Me.Rate2TB.Margin = New System.Windows.Forms.Padding(2)
        Me.Rate2TB.Name = "Rate2TB"
        Me.Rate2TB.Size = New System.Drawing.Size(76, 19)
        Me.Rate2TB.TabIndex = 25
        '
        'Rate0SETButton
        '
        Me.Rate0SETButton.Location = New System.Drawing.Point(286, 301)
        Me.Rate0SETButton.Margin = New System.Windows.Forms.Padding(2)
        Me.Rate0SETButton.Name = "Rate0SETButton"
        Me.Rate0SETButton.Size = New System.Drawing.Size(39, 20)
        Me.Rate0SETButton.TabIndex = 26
        Me.Rate0SETButton.Text = "SET"
        Me.Rate0SETButton.UseVisualStyleBackColor = True
        '
        'Rate1SETButton
        '
        Me.Rate1SETButton.Location = New System.Drawing.Point(286, 324)
        Me.Rate1SETButton.Margin = New System.Windows.Forms.Padding(2)
        Me.Rate1SETButton.Name = "Rate1SETButton"
        Me.Rate1SETButton.Size = New System.Drawing.Size(39, 20)
        Me.Rate1SETButton.TabIndex = 27
        Me.Rate1SETButton.Text = "SET"
        Me.Rate1SETButton.UseVisualStyleBackColor = True
        '
        'Rate2SETButton
        '
        Me.Rate2SETButton.Location = New System.Drawing.Point(286, 346)
        Me.Rate2SETButton.Margin = New System.Windows.Forms.Padding(2)
        Me.Rate2SETButton.Name = "Rate2SETButton"
        Me.Rate2SETButton.Size = New System.Drawing.Size(39, 20)
        Me.Rate2SETButton.TabIndex = 28
        Me.Rate2SETButton.Text = "SET"
        Me.Rate2SETButton.UseVisualStyleBackColor = True
        '
        'ReLoad
        '
        Me.ReLoad.Location = New System.Drawing.Point(316, 47)
        Me.ReLoad.Margin = New System.Windows.Forms.Padding(2)
        Me.ReLoad.Name = "ReLoad"
        Me.ReLoad.Size = New System.Drawing.Size(70, 36)
        Me.ReLoad.TabIndex = 29
        Me.ReLoad.Text = "表示更新"
        Me.ReLoad.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(52, 284)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Rage"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(193, 284)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Rate"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(253, 305)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 13)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "A/s"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(253, 327)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(28, 13)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "A/s"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(253, 350)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 13)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "A/s"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(108, 107)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(72, 20)
        Me.ComboBox1.TabIndex = 35
        '
        'UNIT
        '
        Me.UNIT.AutoSize = True
        Me.UNIT.Location = New System.Drawing.Point(40, 110)
        Me.UNIT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UNIT.Name = "UNIT"
        Me.UNIT.Size = New System.Drawing.Size(59, 13)
        Me.UNIT.TabIndex = 36
        Me.UNIT.Text = "表示単位"
        '
        'UNITSETButton
        '
        Me.UNITSETButton.Location = New System.Drawing.Point(188, 106)
        Me.UNITSETButton.Margin = New System.Windows.Forms.Padding(2)
        Me.UNITSETButton.Name = "UNITSETButton"
        Me.UNITSETButton.Size = New System.Drawing.Size(38, 22)
        Me.UNITSETButton.TabIndex = 37
        Me.UNITSETButton.Text = "SET"
        Me.UNITSETButton.UseVisualStyleBackColor = True
        '
        'HeaterStateL
        '
        Me.HeaterStateL.AutoSize = True
        Me.HeaterStateL.Location = New System.Drawing.Point(106, 172)
        Me.HeaterStateL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HeaterStateL.Name = "HeaterStateL"
        Me.HeaterStateL.Size = New System.Drawing.Size(69, 13)
        Me.HeaterStateL.TabIndex = 38
        Me.HeaterStateL.Text = "Connected"
        '
        'PauseButton
        '
        Me.PauseButton.Location = New System.Drawing.Point(350, 172)
        Me.PauseButton.Margin = New System.Windows.Forms.Padding(2)
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.Size = New System.Drawing.Size(56, 49)
        Me.PauseButton.TabIndex = 39
        Me.PauseButton.Text = "PAUSE"
        Me.PauseButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'SweepStateL
        '
        Me.SweepStateL.AutoSize = True
        Me.SweepStateL.ForeColor = System.Drawing.Color.Black
        Me.SweepStateL.Location = New System.Drawing.Point(183, 54)
        Me.SweepStateL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SweepStateL.Name = "SweepStateL"
        Me.SweepStateL.Size = New System.Drawing.Size(14, 13)
        Me.SweepStateL.TabIndex = 40
        Me.SweepStateL.Text = "-"
        '
        'ModeButton
        '
        Me.ModeButton.Location = New System.Drawing.Point(183, 20)
        Me.ModeButton.Name = "ModeButton"
        Me.ModeButton.Size = New System.Drawing.Size(67, 24)
        Me.ModeButton.TabIndex = 41
        Me.ModeButton.Text = "REMOTE"
        Me.ModeButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 400)
        Me.Controls.Add(Me.ModeButton)
        Me.Controls.Add(Me.SweepStateL)
        Me.Controls.Add(Me.PauseButton)
        Me.Controls.Add(Me.HeaterStateL)
        Me.Controls.Add(Me.UNITSETButton)
        Me.Controls.Add(Me.UNIT)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ReLoad)
        Me.Controls.Add(Me.Rate2SETButton)
        Me.Controls.Add(Me.Rate1SETButton)
        Me.Controls.Add(Me.Rate0SETButton)
        Me.Controls.Add(Me.Rate2TB)
        Me.Controls.Add(Me.Range2L)
        Me.Controls.Add(Me.Range1L)
        Me.Controls.Add(Me.Range0L)
        Me.Controls.Add(Me.Rate1TB)
        Me.Controls.Add(Me.Rate0TB)
        Me.Controls.Add(Me.OUTFieldVL)
        Me.Controls.Add(Me.OUTFieldL)
        Me.Controls.Add(Me.LowSetButton)
        Me.Controls.Add(Me.HiSETButton)
        Me.Controls.Add(Me.LowTB)
        Me.Controls.Add(Me.HiTB)
        Me.Controls.Add(Me.SiftZeroButton)
        Me.Controls.Add(Me.SiftMagButton)
        Me.Controls.Add(Me.GoToLowButton)
        Me.Controls.Add(Me.GoToHiButton)
        Me.Controls.Add(Me.HeaterButton)
        Me.Controls.Add(Me.MagFieldL)
        Me.Controls.Add(Me.MagnetTypeL)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "MagController-USB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MagnetTypeL As Label
    Friend WithEvents MagFieldL As Label
    Friend WithEvents HeaterButton As Button
    Friend WithEvents GoToHiButton As Button
    Friend WithEvents GoToLowButton As Button
    Friend WithEvents SiftMagButton As Button
    Friend WithEvents SiftZeroButton As Button
    Friend WithEvents HiTB As TextBox
    Friend WithEvents LowTB As TextBox
    Friend WithEvents HiSETButton As Button
    Friend WithEvents LowSetButton As Button
    Friend WithEvents OUTFieldL As Label
    Friend WithEvents OUTFieldVL As Label
    Friend WithEvents Rate0TB As TextBox
    Friend WithEvents Rate1TB As TextBox
    Friend WithEvents Range0L As Label
    Friend WithEvents Range1L As Label
    Friend WithEvents Range2L As Label
    Friend WithEvents Rate2TB As TextBox
    Friend WithEvents Rate0SETButton As Button
    Friend WithEvents Rate1SETButton As Button
    Friend WithEvents Rate2SETButton As Button
    Friend WithEvents ReLoad As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents UNIT As Label
    Friend WithEvents UNITSETButton As Button
    Friend WithEvents HeaterStateL As Label
    Friend WithEvents PauseButton As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents SweepStateL As Label
    Friend WithEvents ModeButton As Button
End Class
