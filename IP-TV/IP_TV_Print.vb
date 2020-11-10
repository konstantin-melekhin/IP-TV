
Imports Library3

Public Class IP_TV_Print

    Dim LOTID, IDApp As Integer
    Dim LenSN, StartStepID As Integer, PreStepID As Integer, NextStepID As Integer
    Dim StartStep As String, PreStep As String, NextStep As String
    Dim PCInfo As New ArrayList() 'PCInfo = (App_ID, App_Caption, lineID, LineName, StationName,CT_ScanStep)
    Dim LOTInfo As New ArrayList() 'LOTInfo = (Model,LOT,SMTRangeChecked,SMTStartRange,SMTEndRange,ParseLog)
    Dim ShiftCounterInfo As New ArrayList() 'ShiftCounterInfo = (ShiftCounterID,ShiftCounter,LOTCounter)
    Dim StepSequence As String()
    Dim Yield As Double
    Public Sub New(LOTIDWF As Integer, IDApp As Integer)
        InitializeComponent()
        Me.LOTID = LOTIDWF
        Me.IDApp = IDApp
    End Sub
    'Загрузка рабочей формы
    Private Sub IP_TV_Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'получение данных о станции
        LoadGridFromDB(DG_StepList, "USE FAS SELECT [ID],[StepName],[Description] FROM [FAS].[dbo].[Ct_StepScan]")
        PCInfo = GetPCInfo(IDApp)
        LabelAppName.Text = PCInfo(1)
        Label_StationName.Text = PCInfo(5)
        LB_CurrentStep.Text = PCInfo(7)
        Lebel_StationLine.Text = PCInfo(3)
        TextBox1.Text = "App_ID = " & PCInfo(0) & vbCrLf &
                    "App_Caption = " & PCInfo(1) & vbCrLf &
                    "lineID = " & PCInfo(2) & vbCrLf &
                    "LineName = " & PCInfo(3) & vbCrLf &
                    "StationID = " & PCInfo(4) & vbCrLf &
                    "StationName = " & PCInfo(5) & vbCrLf &
                    "CT_ScanStepID = " & PCInfo(6) & vbCrLf &
                    "CT_ScanStep = " & PCInfo(7) & vbCrLf 'PCInfo
        'получение данных о текущем лоте
        LOTInfo = GetCurrentContractLot(LOTID)
        LenSN = GetLenSN(LOTInfo(8))
        TextBox2.Text = "Model = " & LOTInfo(0) & vbCrLf &
                    "LOT = " & LOTInfo(1) & vbCrLf &
                    "CheckFormatSN_SMT = " & LOTInfo(2) & vbCrLf &
                    "SMTNumberFormat = " & LOTInfo(3) & vbCrLf &
                    "SMTRangeChecked = " & LOTInfo(4) & vbCrLf &
                    "SMTStartRange = " & LOTInfo(5) & vbCrLf &
                    "SMTEndRange = " & LOTInfo(6) & vbCrLf &
                    "CheckFormatSN_FAS = " & LOTInfo(7) & vbCrLf &
                    "FASNumberFormat = " & LOTInfo(8) & vbCrLf &
                    "FASRangeChecked = " & LOTInfo(9) & vbCrLf &
                    "FASStartRange = " & LOTInfo(10) & vbCrLf &
                    "FASEndRange = " & LOTInfo(11) & vbCrLf &
                    "SingleSN = " & LOTInfo(12) & vbCrLf &
                    "ParseLog = " & LOTInfo(13) & vbCrLf &
                    "StepSequence = " & LOTInfo(14) & vbCrLf &
                    "BoxCapacity = " & LOTInfo(15) & vbCrLf &
                    "PalletCapacity = " & LOTInfo(16) & vbCrLf &
                    "LiterIndex = " & LOTInfo(17) & vbCrLf &
                    "PreRackStage = " & LOTInfo(18) &
                    "LenSN = " & LenSN & vbCrLf 'LOTInfo
        L_LOT.Text = LOTInfo(1)
        L_Model.Text = LOTInfo(0)
        'загружаем список кодов ошибок в грид SQL запрос "ErrorCodeList" 
        LoadGridFromDB(DG_ErrorCodes, "use FAS select [ErrorCodeID],[ErrorCode],[Description]  FROM [FAS].[dbo].[FAS_ErrorCode] where ErrGroup = 4")
        'Записываем коды ошибок в рабочий комбобокс
        If DG_ErrorCodes.Rows.Count <> 0 Then
            For J = 0 To DG_ErrorCodes.Rows.Count - 1
                CB_ErrorCode.Items.Add(DG_ErrorCodes.Rows(J).Cells(1).Value)
                Exit For
            Next
        End If
        'Устанавливаем дефолты при загоузке формы 
        'Настройка COM порта
        'Требуется печать или нет
        Try
            PrintSerialPort3.Open()
            PrintSerialPort3.Close()
        Catch ex As Exception
            PrintLabel(Controllabel, "Проверьте подключение ком порта 3!", 12, 193, Color.Red) ' если не настроен ком порт для печати
            SerialTextBox.Enabled = False
        End Try
        CB_SelectLabel_SelectedIndexChanged(sender, e)
        CB_LabelHomePos.Checked = False
        'Запуск программы
        '___________________________________________________________
        GB_UserData.Location = New Point(10, 12)
        TB_RFIDIn.Focus()
        'запуск счетчика продукции за день
        CurrentTimeTimer.Start()
        ShiftCounterInfo = ShiftCounterStart(PCInfo(4), IDApp, LOTID)
        Label_ShiftCounter.Text = ShiftCounterInfo(1)
        LB_LOTCounter.Text = ShiftCounterInfo(2)
    End Sub 'Загрузка рабочей формы
    'Часы в программе
    Private Sub CurrentTimeTimer_Tick(sender As Object, e As EventArgs) Handles CurrentTimeTimer.Tick
        CurrrentTimeLabel.Text = TimeString
    End Sub 'Часы в программе
    'регистрация пользователя
    Dim UserInfo As New ArrayList()
    Private Sub TB_RFIDIn_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_RFIDIn.KeyDown
        TB_RFIDIn.MaxLength = 10
        If e.KeyCode = Keys.Enter And TB_RFIDIn.TextLength = 10 Then ' если длина номера равна 10, то запускаем процесс
            UserInfo = GetUserData(TB_RFIDIn.Text, GB_UserData, GB_WorkAria, L_UserName, TB_RFIDIn)
            TextBox3.Text = "UserID = " & UserInfo(0) & vbCrLf &
                    "Name = " & UserInfo(1) & vbCrLf &
                    "User Group = " & UserInfo(2) & vbCrLf  'UserInfo
            SerialTextBox.Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            TB_RFIDIn.Clear()
        End If
    End Sub 'регистрация пользователя
    ' условия для возврата в окно настроек
    Dim OpenSettings As Boolean
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles BT_OpenSettings.Click, BT_LOGInClose.Click
        OpenSettings = True
        Me.Close()
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim Question As String
        Question = If(OpenSettings = True, "Вы подтверждаете возврат в окно настроек?", "Вы подтверждаете выход из программы?")
        Select Case MsgBox(Question, MsgBoxStyle.YesNo, "")
            Case MsgBoxResult.Yes
                e.Cancel = False
                If OpenSettings = True Then
                    SettingsForm.Show()
                End If
            Case MsgBoxResult.No
                e.Cancel = True
        End Select
        OpenSettings = False
    End Sub ' условия для возврата в окно настроек
    '_________________________________________________________________________________________________________________
    'начало работы приложения FAS Scanning Station
    'окно ввода серийного номера платы 
    Dim SNID As Integer
    Private Sub SerialTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SerialTextBox.KeyDown
        Dim Mess As New ArrayList()
        If e.KeyCode = Keys.Enter And SerialTextBox.TextLength = LenSN And CB_SelectLabel.SelectedIndex = 0 Then
            'печать Этикетки 45х8 и 39х19
            SNID = AddSNToDB(SerialTextBox.Text)
            If PrintSN(SearchSNForPrint(0), CB_SelectLabel.SelectedIndex) = True Then
                OperLogUpd(SNID, 26, 2, "Этикетки 45х8 и 39х19")
            End If
        ElseIf e.KeyCode = Keys.Enter And SerialTextBox.TextLength = LenSN And CB_SelectLabel.SelectedIndex = 1 Then
                'повтор Этикетка 44х21_Rus
                SNID = AddSNToDB(SerialTextBox.Text)
                If PrintSN(SearchSNForPrint(0), CB_SelectLabel.SelectedIndex) = True Then
                OperLogUpd(SNID, 26, 2, "Этикетка 44х21_Rus")
            End If
            ElseIf e.KeyCode = Keys.Enter And SerialTextBox.TextLength = 0 And CB_SelectLabel.SelectedIndex = 1 Then
            'печать Этикетка 44х21_Rus
            Dim SNForPrint = SearchSNForPrint(1)
            If PrintSN(SNForPrint, CB_SelectLabel.SelectedIndex) = True Then
                OperLogUpd(AddSNToDB(SNForPrint(1)), 26, 2, "Этикетка 44х21_Rus")
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            'если введен не верный номер
            PrintLabel(Controllabel, SerialTextBox.Text & " не верный номер", 12, 193, Color.Red)
            SerialTextBox.Enabled = False
            BT_Pause.Focus()
        End If

    End Sub
    'добавляет серийный номер в Ct_FASSN_reg, чтобы создать SNID
    Private Function AddSNToDB(SN As String) As Integer
        Dim _SNID As Integer
        _SNID = SelectInt("USE FAS SELECT [ID] FROM [FAS].[dbo].[Ct_FASSN_reg] where SN = '" & SN & "'")
        If _SNID = 0 Then
            _SNID = SelectInt($"USE FAS {vbCrLf}
                       insert into [FAS].[dbo].[Ct_FASSN_reg] ([SN],[LOTID],[UserID],[AppID],[LineID],[RegDate]) values{vbCrLf}
                       ('{SN}',{ LOTID },{UserInfo(0)},{PCInfo(0)},{PCInfo(2)}, CURRENT_TIMESTAMP){vbCrLf}
                       WAITFOR delay '00:00:00:100'{vbCrLf}
                       SELECT [ID] FROM [FAS].[dbo].[Ct_FASSN_reg] where SN = '{SN}'")
        End If
        Return _SNID
    End Function
    'запись в опер лог
    Private Sub OperLogUpd(_SNID As Integer, StepID As Integer, StepRes As Integer, Descr As String)
        RunCommand($"insert into [FAS].[dbo].[Ct_OperLog] ([LOTID],[StepID],[TestResultID],[StepDate],
                    [StepByID],[LineID],[SNID],[Descriptions])values
                    ({LOTID},{StepID},{StepRes},CURRENT_TIMESTAMP,{ UserInfo(0) },{ PCInfo(2) },{ _SNID },'{ Descr }')")
    End Sub
    Private Sub CB_SelectLabel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_SelectLabel.SelectedIndexChanged
        If CB_SelectLabel.SelectedIndex = 1 Then

            Controllabel.Text = ""
            SerialTextBox.Enabled = True
        Else
            Try
                PrintSerialPort6.Open()
                PrintSerialPort6.Close()
            Catch ex As Exception
                PrintLabel(Controllabel, "Проверьте подключение ком порта 6!", 12, 193, Color.Red) ' если не настроен ком порт для печати
                SerialTextBox.Enabled = False
            End Try
        End If
        SerialTextBox.Focus()
    End Sub
    Private Sub Num_LabelCountToPrint_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SerialTextBox.Focus()
        End If
    End Sub

    Private Sub CB_LabelHomePos_CheckedChanged(sender As Object, e As EventArgs) Handles CB_LabelHomePos.CheckedChanged
        If CB_LabelHomePos.Checked = True Then
            GB_HomePos.Visible = True
        Else
            GB_HomePos.Visible = False
        End If
    End Sub

    Private Function SearchSNForPrint(SerchParametr As Integer) As ArrayList
        Dim SN As New ArrayList()
        Select Case SerchParametr
            Case 0
                SN = SelectListString("use fas
                SELECT [SN],[series bar],[MAC_Bar],[MAC_Print],[IsPacked]
                FROM [FAS].[dbo].[CT_TCC_SN_MAC] where [series bar] = '" & SerialTextBox.Text & "'")
            Case 1
                SN = SelectListString("use FAS  
                declare @SerialNumber nvarchar(24)  
                select @SerialNumber = (SELECT top 1 [series bar] FROM [FAS].[dbo].[CT_TCC_SN_MAC] where IsPrinted = 0)  
                Update [FAS].[dbo].[CT_TCC_SN_MAC] Set  IsPrinted  = 1, PrintStationID = " & PCInfo(4) & ",[PrintDate] = CURRENT_TIMESTAMP  where [series bar] = @SerialNumber
                WAITFOR delay '00:00:00:100'
                select [SN],[series bar],[MAC_Bar],[MAC_Print],[IsPacked] 
                from [FAS].[dbo].[CT_TCC_SN_MAC] where [series bar] = @SerialNumber and PrintStationID = " & PCInfo(4) & "")
        End Select
        Return SN
    End Function

    'функция печати
    Private Function PrintSN(SNArray As ArrayList, LabScenario As Integer)
        Dim res As Boolean
        If SNArray.Count <> 0 Then
            IP_Lab(SNArray, LabScenario, X_pos.Value, Y_pos.Value, X2_pos.Value, Y2_pos.Value, PrintSerialPort3, PrintSerialPort6)

            PrintLabel(Controllabel, "Серийный номер: " & SNArray(1) & " и " & vbCrLf &
                                    "MAC адрес: " & SNArray(3) & " распечатаны!", 12, 192, Color.Green)
            res = True
        Else
            PrintLabel(Controllabel, "Номер не найден в базе!", 12, 192, Color.Red)
            res = False
        End If
        If res = True Then
            ShiftCounter(2)
            CurrentLogUpdate(Label_ShiftCounter.Text, SNArray(1))
            SerialTextBox.Clear()
            SerialTextBox.Enabled = True
            SerialTextBox.Focus()
        Else
            SerialTextBox.Enabled = True
            BT_Pause.Focus()
        End If
        Return res
    End Function

    Private Sub CB_Reprint_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Reprint.CheckedChanged
        SerialTextBox.Focus()
    End Sub
    'Кнопка очистки поля ввода номера
    Private Sub BT_CleareSN_Click(sender As Object, e As EventArgs) Handles BT_CleareSN.Click
        If GB_PCBInfoMode.Visible = False Then
            SerialTextBox.Clear()
            SerialTextBox.Enabled = True
            DG_UpLog.Visible = True
            TB_Description.Clear()
            SerialTextBox.Focus()
        Else
            TB_GetPCPInfo.Clear()
            TB_GetPCPInfo.Enabled = True
            TB_GetPCPInfo.Focus()
        End If
    End Sub
    'Функция заполнения LogGrid 
    Private Sub CurrentLogUpdate(ShtCounter As Integer, SN As String)
        ' заполняем строку таблицы
        Me.DG_UpLog.Rows.Add(ShtCounter, SN, Date.Now)
        DG_UpLog.Sort(DG_UpLog.Columns(2), System.ComponentModel.ListSortDirection.Descending)
    End Sub
    'Счетчик продукции
    Private Sub ShiftCounter(StepRes As Integer)
        ShiftCounterInfo(1) += 1
        ShiftCounterInfo(2) += 1
        If StepRes = 2 Then
            ShiftCounterInfo(3) += 1
        Else
            ShiftCounterInfo(4) += 1
        End If
        Label_ShiftCounter.Text = ShiftCounterInfo(1)
        LB_LOTCounter.Text = ShiftCounterInfo(2)
        ShiftCounterUpdateCT(PCInfo(4), PCInfo(0), ShiftCounterInfo(0), ShiftCounterInfo(1), ShiftCounterInfo(2),
                         ShiftCounterInfo(3), ShiftCounterInfo(4))
    End Sub

End Class

