Imports System.Threading
Imports System.Windows

Public Class Form1
    Private receiveThread As Thread
    Private receivedData As String = String.Empty
    Private receivedEvent As New ManualResetEvent(False)
    Private cancelReceive As Boolean = False

    ' マグネット関連の変数
    Private MagnetModel As String
    Private CurrentField As String
    Private OutputCurrent As String
    Private OutputVoltage As String
    Private UnitOfMeasure As String
    Private HeaterStatus As Integer
    Private FieldRangeLow As String
    Private FieldRangeMid As String
    Private FieldRangeHigh As String
    Private SweepRateLow As String
    Private SweepRateMid As String
    Private SweepRateHigh As String
    Private UpperLimit As String
    Private LowerLimit As String
    Private SweepStatus As String

    Private sameValueCount As Integer = 0
    Private pauseFlag As Boolean = False
    Private isMoving1 As Boolean = False
    Private isMoving2 As Boolean = False
    Private Limit As String

    ' フォームがロードされたときに呼び出されるメソッド
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComboBox1.Items.AddRange({"T", "A", "G"}) ' 単位選択のコンボボックスに項目を追加

        ' SerialPort1の初期設定
        With SerialPort1
            .PortName = "COM3" ' 実際のCOMポート名に置き換えてください
            .BaudRate = 9600
            .DataBits = 8
            .Parity = IO.Ports.Parity.None
            .StopBits = IO.Ports.StopBits.One
            .Handshake = IO.Ports.Handshake.None
            .NewLine = vbCrLf ' 改行コードの設定
            .ReadTimeout = 1000 ' タイムアウト設定を1秒に調整
        End With
        SerialPort1.Open()
        StartReceiveThread()
        SendCommand("REMOTE")
        UpdateFieldInfo()
    End Sub

    ' フォームが閉じられるときにシリアルポートを閉じる処理
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' リモートモードを終了
        SendCommand("LOCAL")
        ' 受信スレッドを停止
        cancelReceive = True
        If receiveThread IsNot Nothing AndAlso receiveThread.IsAlive Then
            receiveThread.Join() ' スレッドが安全に終了するのを待つ
        End If

        ' シリアルポートを閉じる
        If SerialPort1 IsNot Nothing AndAlso SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
    End Sub

    ' エラーメッセージを表示するメソッド
    Public Sub LogError(errorMessage As String)
        MessageBox.Show($"Error: {errorMessage}")
    End Sub

    ' マグネットコントローラを識別するメソッド
    Private Sub IdentifyMagnetController()
        Try
            Dim idnResponse As String = SendQuery("*IDN?").Trim()

            ' IDに基づいてマグネットタイプを判別
            If idnResponse.Contains("5556") Then
                MagnetTypeL.Text = "slim"
            ElseIf idnResponse.Contains("6104") Then
                MagnetTypeL.Text = "fat"
            ElseIf idnResponse.Contains("7423") Then
                MagnetTypeL.Text = "3号"
            Else
                MagnetTypeL.Text = "Unknown"
                Throw New Exception("Unknown magnet controller model.")
            End If
        Catch ex As Exception
            LogError($"Error identifying magnet controller: {ex.Message}")
        End Try
    End Sub

    ' フィールド情報を取得しUIに反映するメソッド
    Private Sub UpdateFieldInfo()
        DisableButtons()
        Try
            ' 各種フィールド情報をUSBシリアル通信で取得
            Console.WriteLine("データ取得開始")
            CurrentField = SendQuery("IMAG?").Trim()
            OutputCurrent = SendQuery("IOUT?").Trim()
            OutputVoltage = SendQuery("VOUT?").Trim()
            UnitOfMeasure = SendQuery("UNITS?").Trim()
            HeaterStatus = Integer.Parse(SendQuery("PSHTR?").Trim())
            FieldRangeLow = SendQuery("RANGE? 0").Trim()
            FieldRangeMid = SendQuery("RANGE? 1").Trim()
            FieldRangeHigh = SendQuery("RANGE? 2").Trim()
            SweepRateLow = SendQuery("RATE? 0").Trim()
            SweepRateMid = SendQuery("RATE? 1").Trim()
            SweepRateHigh = SendQuery("RATE? 2").Trim()
            UpperLimit = SendQuery("ULIM?").Trim()
            LowerLimit = SendQuery("LLIM?").Trim()
            SweepStatus = SendQuery("SWEEP?").Trim()
            IdentifyMagnetController()

        Catch ex As Exception
            LogError($"Error retrieving field info: {ex.Message}")
        Finally
            EndReceiveThread()
        End Try
        UpdateUI()
    End Sub

    ' 受信スレッドを開始するメソッド
    Private Sub StartReceiveThread()
        Try
            ' 受信スレッドを開始
            cancelReceive = False
            receiveThread = New Thread(AddressOf ReceiveData)
            receiveThread.IsBackground = True
            receiveThread.Start()
        Catch ex As Exception
            LogError($"Error starting receive thread: {ex.Message}")
        End Try
    End Sub

    ' 受信スレッドを終了するメソッド
    Private Sub EndReceiveThread()
        ' 受信スレッドを終了
        cancelReceive = True
        If receiveThread IsNot Nothing AndAlso receiveThread.IsAlive Then
            receiveThread.Join() ' スレッドが安全に終了するのを待つ
        End If
        Console.WriteLine("受信スレッド終了")
    End Sub

    ' UIを更新するメソッド
    Private Sub UpdateUI()
        ' ヒーターの状態に応じたUIの更新
        If HeaterStatus = 1 Then
            HeaterButton.Text = "ON"
            HeaterButton.BackColor = Color.LightGreen
            HeaterStateL.Text = "Connected"
            SiftMagButton.Enabled = False
            SiftZeroButton.Enabled = False
            GoToHiButton.Enabled = True
            GoToLowButton.Enabled = True
        Else
            HeaterButton.Text = "OFF"
            HeaterStateL.Text = "Disconnected"
            HeaterButton.BackColor = SystemColors.Control
            SiftMagButton.Enabled = True
            SiftZeroButton.Enabled = True
            GoToHiButton.Enabled = False
            GoToLowButton.Enabled = False
        End If

        ' 各ラベルやテキストボックスに取得した情報を表示
        MagFieldL.Text = CurrentField
        OUTFieldL.Text = OutputCurrent
        OUTFieldVL.Text = OutputVoltage
        ComboBox1.Text = UnitOfMeasure
        Range0L.Text = $"0～{FieldRangeLow}"
        Range1L.Text = $"{FieldRangeLow}～{FieldRangeMid}"
        Range2L.Text = $"{FieldRangeMid}～{FieldRangeHigh}"
        Rate0TB.Text = SweepRateLow
        Rate1TB.Text = SweepRateMid
        Rate2TB.Text = SweepRateHigh
        HiTB.Text = UpperLimit
        LowTB.Text = LowerLimit
        SweepStateL.Text = SweepStatus
        HiSETButton.Enabled = True
        LowSetButton.Enabled = True
        Rate0SETButton.Enabled = True
        Rate1SETButton.Enabled = True
        Rate2SETButton.Enabled = True
        ModeButton.Enabled = True
        UNITSETButton.Enabled = True
        ReLoad.Enabled = True

        HeaterButton.Enabled = (CurrentField = OutputCurrent) ' フィールドが一致していればヒーターボタンを有効化
    End Sub

    ' ボタンを無効化するメソッド
    Private Sub DisableButtons()
        SiftMagButton.Enabled = False
        SiftZeroButton.Enabled = False
        GoToHiButton.Enabled = False
        GoToLowButton.Enabled = False
        HeaterButton.Enabled = False
        HiSETButton.Enabled = False
        LowSetButton.Enabled = False
        Rate0SETButton.Enabled = False
        Rate1SETButton.Enabled = False
        Rate2SETButton.Enabled = False
        ModeButton.Enabled = False
        UNITSETButton.Enabled = False
        ReLoad.Enabled = False
    End Sub

    ' シリアル通信でコマンドを送信し応答を受け取るメソッド
    Private Function SendQuery(command As String) As String
        SyncLock SerialPort1
            receivedData = String.Empty

            ' コマンド送信
            SerialPort1.WriteLine(command)

            ' 応答が受信されるまで待機
            If Not receivedEvent.WaitOne(500) Then
                Throw New TimeoutException("No response received within the timeout period.")
            End If

            ' 受信した応答を取得
            Dim response As String = receivedData

            ' イベントをリセットして次のコマンドに備える
            receivedEvent.Reset()
            Return response
        End SyncLock
    End Function

    ' データ受信処理
    Private Sub ReceiveData()
        While SerialPort1 IsNot Nothing AndAlso SerialPort1.IsOpen AndAlso Not cancelReceive
            Try
                ' 一行目のエコーを無視
                Dim echoedCommand As String = SerialPort1.ReadLine()

                ' 二行目に実際の応答があるので取得
                receivedData = SerialPort1.ReadLine()

                ' 応答が受信されたことを通知
                receivedEvent.Set()

            Catch ex As TimeoutException
                ' タイムアウトが発生した場合の処理
                Console.WriteLine("Timeout occurred while waiting for a response.")
            Catch ex As Exception
                ' その他のエラー処理
                Console.WriteLine("An error occurred in ReceiveData: " & ex.Message)
                Console.WriteLine("Stack Trace: " & ex.StackTrace)
            End Try
        End While
    End Sub

    ' シリアル通信でコマンドを送信するメソッド
    Private Sub SendCommand(command As String)
        SyncLock SerialPort1
            ' コマンドを送信
            SerialPort1.WriteLine(command)
            MessageBox.Show($"設定を送信しました。{vbCrLf} {command}")
        End SyncLock
    End Sub

    ' 磁場のスイープを開始するボタンのクリックイベント
    Private Sub SiftMagButton_Click(sender As Object, e As EventArgs) Handles SiftMagButton.Click
        StartReceiveThread()
        CheckHeaterStatus()
        If HeaterStatus = 0 Then ' ヒーターがOFFの場合
            SendCommand("SWEEP MAG FAST")
            StartTimer(Timer1, isMoving1) ' タイマーを開始
        Else
            MessageBox.Show("ヒーターがONです。")
        End If
    End Sub

    ' ゼロスイープを開始するボタンのクリックイベント
    Private Sub SiftZeroButton_Click(sender As Object, e As EventArgs) Handles SiftZeroButton.Click
        StartReceiveThread()
        CheckHeaterStatus()
        If HeaterStatus = 0 Then ' ヒーターがOFFの場合
            SendCommand("SWEEP ZERO FAST")
            StartTimer(Timer1, isMoving1) ' タイマーを開始
        Else
            MessageBox.Show("ヒーターがONです。")
        End If
    End Sub

    ' 上限スイープを開始するボタンのクリックイベント
    Private Sub GoToHiButton_Click(sender As Object, e As EventArgs) Handles GoToHiButton.Click
        StartReceiveThread()
        Limit = SendQuery("ULIM?").Trim()
        SendCommand("SWEEP UP")
        StartTimer(Timer2, isMoving2) ' タイマーを開始
    End Sub

    ' 下限スイープを開始するボタンのクリックイベント
    Private Sub GoToLowButton_Click(sender As Object, e As EventArgs) Handles GoToLowButton.Click
        StartReceiveThread()
        Limit = SendQuery("LLIM?").Trim()
        SendCommand("SWEEP DOWN")
        StartTimer(Timer2, isMoving2) ' タイマーを開始
    End Sub

    ' ヒーターの状態を確認するメソッド
    Private Sub CheckHeaterStatus()
        HeaterStatus = Integer.Parse(SendQuery("PSHTR?").Trim())
        UpdateUI() ' ヒーターの状態に応じてUIを更新
    End Sub

    ' スイープ処理を監視するタイマーを開始するメソッド
    Private Sub StartTimer(timer As System.Windows.Forms.Timer, ByRef isMoving As Boolean)
        If Not isMoving Then
            DisableButtons() ' ボタンを無効化
            sameValueCount = 0
            timer.Interval = 3000 ' 3秒間隔でタイマーを設定
            isMoving = True
            timer.Start() ' タイマーを開始
        End If
    End Sub

    ' Timer1のTickイベント（1つ目の動作の監視）
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MonitorSweep(Timer1, isMoving1, OutputCurrent)
    End Sub

    ' Timer2のTickイベント（2つ目の動作の監視）
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        MonitorSweep(Timer2, isMoving2, Limit)
    End Sub

    ' スイープの進行状況を監視するメソッド
    Private Sub MonitorSweep(timer As System.Windows.Forms.Timer, ByRef isMoving As Boolean, comparisonValue As String)
        ' フィールド情報を取得
        CurrentField = SendQuery("IMAG?").Trim()
        OutputCurrent = SendQuery("IOUT?").Trim()
        OutputVoltage = SendQuery("VOUT?").Trim()
        SweepStatus = SendQuery("SWEEP?").Trim()

        MagFieldL.Text = CurrentField
        OUTFieldL.Text = OutputCurrent
        OUTFieldVL.Text = OutputVoltage
        If sameValueCount = 0 Then
            SweepStateL.Text = SweepStatus
        End If

        ' フィールドが比較値と一致、または電流が0.000kGならカウンタを増加
        If CurrentField = comparisonValue Or OutputCurrent = "0.000kG" Or OutputCurrent = "0.0000A" Then
            sameValueCount += 1
            SweepStateL.Text = $"残り {10 - sameValueCount} カウント"
        End If

        ' 同じ値が5回続いたらタイマーを停止し完了を通知
        If sameValueCount >= 10 Or pauseFlag = True Then
            timer.Stop()
            isMoving = False
            If pauseFlag Then
                MessageBox.Show("Paused")
            Else
                MessageBox.Show("Completed")
            End If
            UpdateFieldInfo() ' 情報を再取得
            pauseFlag = False
        End If
    End Sub

    ' 一時停止ボタンのクリックイベント
    Private Sub PauseButton_Click(sender As Object, e As EventArgs) Handles PauseButton.Click
        If isMoving1 OrElse isMoving2 Then
            SendCommand("SWEEP PAUSE")
        End If
        pauseFlag = True
    End Sub

    ' ヒーターのON/OFFを切り替えるボタンのクリックイベント
    Private Async Sub HeaterONOFFButton_Click(sender As Object, e As EventArgs) Handles HeaterButton.Click

        DisableButtons() ' ボタンを一時的に無効化

        If HeaterStatus = 1 Then
            SendCommand("PSHTR OFF")
            HeaterButton.Text = "OFF"
            HeaterButton.BackColor = SystemColors.Control
        Else
            SendCommand("PSHTR ON")
            HeaterButton.Text = "ON"
            HeaterButton.BackColor = Color.LightGreen
        End If
        ' 300秒のカウントダウンを開始
        Await CountdownAsync(300)
        StartReceiveThread()
        UpdateFieldInfo()
    End Sub

    ' 300秒のカウントダウンを行うメソッド
    Public Async Function CountdownAsync(seconds As Integer) As Task
        For i As Integer = seconds To 1 Step -1
            HeaterStateL.Text = $"待機中... {i} 秒"
            Await Task.Delay(1000) ' 1秒待機
        Next
    End Function

    ' 高いリミット値を設定するボタンのクリックイベント
    Private Sub HiSETButton_Click(sender As Object, e As EventArgs) Handles HiSETButton.Click
        Dim command As String = $"ULIM {HiTB.Text}"
        StartReceiveThread()
        SendCommand(command)
        UpdateFieldInfo()
    End Sub

    ' 低いリミット値を設定するボタンのクリックイベント
    Private Sub LowSetButton_Click(sender As Object, e As EventArgs) Handles LowSetButton.Click
        Dim command As String = $"LLIM {LowTB.Text}"
        StartReceiveThread()
        SendCommand(command)
        UpdateFieldInfo()
    End Sub

    ' 低速のスイープレートを設定するボタンのクリックイベント
    Private Sub Rate0SETButton_Click(sender As Object, e As EventArgs) Handles Rate0SETButton.Click
        Dim rate As Double
        If Not Double.TryParse(Rate0TB.Text, rate) Then
            MessageBox.Show("無効な値です。正しい数値を入力してください。")
            Return
        End If

        If Not ValidateRate(rate, 0) Then Return

        Dim command As String = $"RATE 0 {Rate0TB.Text}"
        StartReceiveThread()
        SendCommand(command)
        UpdateFieldInfo()
    End Sub

    ' 中速のスイープレートを設定するボタンのクリックイベント
    Private Sub Rate1SETButton_Click(sender As Object, e As EventArgs) Handles Rate1SETButton.Click
        Dim rate As Double
        If Not Double.TryParse(Rate1TB.Text, rate) Then
            MessageBox.Show("無効な値です。正しい数値を入力してください。")
            Return
        End If

        If Not ValidateRate(rate, 1) Then Return

        Dim command As String = $"RATE 1 {Rate1TB.Text}"
        StartReceiveThread()
        SendCommand(command)
        UpdateFieldInfo()
    End Sub

    ' 高速のスイープレートを設定するボタンのクリックイベント
    Private Sub Rate2SETButton_Click(sender As Object, e As EventArgs) Handles Rate2SETButton.Click
        Dim rate As Double
        If Not Double.TryParse(Rate2TB.Text, rate) Then
            MessageBox.Show("無効な値です。正しい数値を入力してください。")
            Return
        End If

        If Not ValidateRate(rate, 2) Then Return

        Dim command As String = $"RATE 2 {Rate2TB.Text}"
        StartReceiveThread()
        SendCommand(command)
        UpdateFieldInfo()
    End Sub

    ' 単位を設定するボタンのクリックイベント
    Private Sub UNITSETButton_Click(sender As Object, e As EventArgs) Handles UNITSETButton.Click
        Dim command As String = $"UNITS {ComboBox1.Text}"
        StartReceiveThread()
        SendCommand(command)
        UpdateFieldInfo()
    End Sub

    ' スイープレートの値を検証するメソッド
    Private Function ValidateRate(rate As Double, rateIndex As Integer) As Boolean
        Dim maxRate As Double
        Select Case MagnetTypeL.Text
            Case "slim"
                maxRate = If(rateIndex = 0, 0.052, 0.026)
            Case "fat"
                maxRate = If(rateIndex = 0, 0.035, 0.017)
            Case "3号"
                maxRate = If(rateIndex = 0, 0.04, 0.017)
            Case Else
                MessageBox.Show("Unknown magnet type.")
                Return False
        End Select

        If rate > maxRate Then
            MessageBox.Show($"エラー： 範囲は0～{maxRate}")
            StartReceiveThread()
            UpdateFieldInfo()
            Return False
        End If

        Return True
    End Function

    ' フィールド情報を再読み込みするボタンのクリックイベント
    Private Sub ReLoad_Click(sender As Object, e As EventArgs) Handles ReLoad.Click
        StartReceiveThread()
        UpdateFieldInfo()
    End Sub

    ' モードを切り替えるボタンのクリックイベント
    Private Sub ModeButton_Click(sender As Object, e As EventArgs) Handles ModeButton.Click
        If ModeButton.Text = "REMOTE" Then
            StartReceiveThread()
            SendCommand("LOCAL")
            ModeButton.Text = "LOCAL"
            UpdateFieldInfo()
        Else
            StartReceiveThread()
            SendCommand("REMOTE")
            ModeButton.Text = "REMOTE"
            UpdateFieldInfo()
        End If
    End Sub
End Class
