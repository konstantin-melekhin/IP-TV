Imports System.Deployment.Application
Imports Library3

Public Class Quarantine
#Region "Переменные"
    Dim LOTID, IDApp As Integer
    Dim LenSN, LenSmtSN, StartStepID As Integer, PreStepID As Integer, NextStepID As Integer
    Dim StartStep As String, PreStep As String, NextStep As String
    Dim PCInfo As New ArrayList() 'PCInfo = (App_ID, App_Caption, lineID, LineName, StationName,CT_ScanStep)
    Dim LOTInfo As New ArrayList() 'LOTInfo = (Model,LOT,SMTRangeChecked,SMTStartRange,SMTEndRange,ParseLog)
    Dim ShiftCounterInfo As New ArrayList() 'ShiftCounterInfo = (ShiftCounterID,ShiftCounter,LOTCounter)
    Dim StepSequence As String()
    Dim Yield As Double
    Dim SNFormat As ArrayList
#End Region
#Region "Загрузка рабочей формы"   'Загрузка рабочей формы    
    Public Sub New(LOTIDWF As Integer, IDApp As Integer)
        InitializeComponent()
        Me.LOTID = LOTIDWF
        Me.IDApp = IDApp
    End Sub
    'Загрузка рабочей формы
    Private Sub Quarantine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myVersion As Version
        If ApplicationDeployment.IsNetworkDeployed Then
            myVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion
        End If
        LB_SW_Wers.Text = String.Concat("v", myVersion)
        'получение данных о станции
        GB_ErrorCode.Location = New Point(1950, 333)
        LoadGridFromDB(DG_StepList, "USE FAS SELECT [ID],[StepName],[Description] FROM [FAS].[dbo].[Ct_StepScan]")
        PCInfo = GetPCInfo(IDApp)
        LabelAppName.Text = PCInfo(1)
        Label_StationName.Text = PCInfo(5)
        LB_CurrentStep.Text = PCInfo(7)
        Lebel_StationLine.Text = PCInfo(3)
#Region "Расшифровка PCInfo"
        '"App_ID = " & PCInfo(0) & vbCrLf &
        '"App_Caption = " & PCInfo(1) & vbCrLf &
        '"lineID = " & PCInfo(2) & vbCrLf &
        '"LineName = " & PCInfo(3) & vbCrLf &
        '"StationID = " & PCInfo(4) & vbCrLf &
        '"StationName = " & PCInfo(5) & vbCrLf &
        '"CT_ScanStepID = " & PCInfo(6) & vbCrLf &
        '"CT_ScanStep = " & PCInfo(7) & vbCrLf 'PCInfo
#End Region
        'получение данных о текущем лоте
        LOTInfo = GetCurrentContractLot(LOTID)
        LenSmtSN = GetLenSN(LOTInfo(3))
        LenSN = GetLenSN(LOTInfo(8))
#Region "LOT Info Расшифровка"
        '"Model = " & LOTInfo(0) & vbCrLf &
        '"LOT = " & LOTInfo(1) & vbCrLf &
        '"CheckFormatSN_SMT = " & LOTInfo(2) & vbCrLf &
        '"SMTNumberFormat = " & LOTInfo(3) & vbCrLf &
        '"SMTRangeChecked = " & LOTInfo(4) & vbCrLf &
        '"SMTStartRange = " & LOTInfo(5) & vbCrLf &
        '"SMTEndRange = " & LOTInfo(6) & vbCrLf &
        '"CheckFormatSN_FAS = " & LOTInfo(7) & vbCrLf &
        '"FASNumberFormat = " & LOTInfo(8) & vbCrLf &
        '"FASRangeChecked = " & LOTInfo(9) & vbCrLf &
        '"FASStartRange = " & LOTInfo(10) & vbCrLf &
        '"FASEndRange = " & LOTInfo(11) & vbCrLf &
        '"SingleSN = " & LOTInfo(12) & vbCrLf &
        '"ParseLog = " & LOTInfo(13) & vbCrLf &
        '"StepSequence = " & LOTInfo(14) & vbCrLf &
        '"BoxCapacity = " & LOTInfo(15) & vbCrLf &
        '"PalletCapacity = " & LOTInfo(16) & vbCrLf &
        '"LiterIndex = " & LOTInfo(17) & vbCrLf &
        '"PreRackStage = " & LOTInfo(18) &
        '"LenSN = " & LenSN & vbCrLf 'LOTInfo
#End Region
        L_LOT.Text = LOTInfo(1)
        L_Model.Text = LOTInfo(0)
        'загружаем список кодов ошибок в грид SQL запрос "ErrorCodeList" 
        LoadGridFromDB(DG_ErrorCodes, "use FAS select [ErrorCodeID],[ErrorCode],[Description]  FROM [FAS].[dbo].[FAS_ErrorCode] where ErrGroup = 1")
        'Записываем коды ошибок в рабочий комбобокс
        If DG_ErrorCodes.Rows.Count <> 0 Then
            For J = 0 To DG_ErrorCodes.Rows.Count - 1
                CB_ErrorCode.Items.Add(DG_ErrorCodes.Rows(J).Cells(1).Value)
            Next
        End If
        'Запуск программы
        '___________________________________________________________
        GB_UserData.Location = New Point(10, 12)
        TB_RFIDIn.Focus()
        'запуск счетчика продукции за день
        CurrentTimeTimer.Start()
        ShiftCounterInfo = ShiftCounterStart(PCInfo(4), IDApp, LOTID)
        Label_ShiftCounter.Text = ShiftCounterInfo(1)
        'YieldCounter()
    End Sub 'Загрузка рабочей формы
#End Region
#Region "Функция определения Yeld"
    'Счетчик Yield
    'Private Sub YieldCounter()

    '    Yield = (ShiftCounterInfo(3) / (ShiftCounterInfo(3) + ShiftCounterInfo(4))) * 100
    '    LB_PassLotRes.Text = ShiftCounterInfo(3)
    '    LB_FailLotRes.Text = ShiftCounterInfo(4)
    '    If ShiftCounterInfo(3) = 0 And ShiftCounterInfo(4) = 0 Then
    '        LB_Yield.Text = 100
    '    Else
    '        LB_Yield.Text = Yield.ToString("00.00")
    '    End If
    'End Sub
#End Region
#Region "Часы в программе"    'Часы в программе
    Private Sub CurrentTimeTimer_Tick(sender As Object, e As EventArgs) Handles CurrentTimeTimer.Tick
        CurrrentTimeLabel.Text = TimeString
    End Sub 'Часы в программе
#End Region
#Region "регистрация пользователя"     'регистрация пользователя
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
#End Region
#Region "условия для возврата в окно настроек"  ' условия для возврата в окно настроек
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
#End Region
#Region "Обработка окна ввода серийного номера" 'окно ввода серийного номера платы 
    'начало работы приложения FAS Quarantine Station
    'окно ввода серийного номера платы
    Dim NumID As New ArrayList
    Private Sub SerialTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SerialTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            'определение формата номера
            If GetFTSN() = True Then
                NumID = SearchNumberID(SerialTextBox.Text)
                Dim _stepArr As ArrayList = New ArrayList(GetPreStep(NumID))
                If _stepArr.Count = 0 Then
                    PrintLabel(Controllabel, SerialTextBox.Text & " не не был зарегистрирован на FAS Start!", 12, 234, Color.Red)
                ElseIf _stepArr.Count > 0 And _stepArr(4) = 30 And _stepArr(5) = 2 Then
                    If NumID(0) = True Then
                        BT_Fail_Click(sender, e)
                    End If
                ElseIf _stepArr.Count > 0 And _stepArr(2) <> 30 Or _stepArr(3) <> 2 Then
                    PrintLabel(Controllabel, SerialTextBox.Text & " имеет не верный предыдущий шаг!", 12, 234, Color.Red)
                End If
            End If
        End If
    End Sub
#End Region
#Region "1. Определение формата номера"
    Private Function GetFTSN() As Boolean
        Dim col As Color, Mess As String, Res As Boolean
        SNFormat = New ArrayList()
        SNFormat = GetSNFormat(LOTInfo(3), LOTInfo(8), SerialTextBox.Text, LOTInfo(18), LOTInfo(2), LOTInfo(7))
        Res = SNFormat(0)
        Mess = SNFormat(3)
        'SNFormat(0) ' Результат проверки True/False
        'SNFormat(1) ' 1 - SMT/ 2 - FAS / 3 - Неопределен
        'SNFormat(2) ' Переменный номер
        'SNFormat(3) ' Текст сообщения
        col = If(Res = False, Color.Red, Color.Green)
        PrintLabel(Controllabel, Mess, 12, 193, col)
        SNTBEnabled(Res)
        Return Res
    End Function
#End Region
#Region "2. Поиск PCBSN or SNID"
    Private Function SearchNumberID(SN As String) As ArrayList
        Dim SNID, PCBID As Integer
        Dim Res As New ArrayList()
        Select Case SNFormat(1)
            Case 1
                PCBID = SelectInt($"use SMDCOMPONETS  select IDLaser from SMDCOMPONETS.dbo.LazerBase where Content = '{SN}'")
                Res.Add(PCBID <> 0)
                Res.Add(PCBID)
                Res.Add(SNFormat(1))
            Case 2
                SNID = SelectInt($"USE FAS SELECT [ID] FROM [FAS].[dbo].[Ct_FASSN_reg] where SN = '{SN}'")
                Res.Add(SNID <> 0)
                Res.Add(SNID)
                Res.Add(SNFormat(1))
        End Select
        Return Res
    End Function
#End Region
#Region "3. функция обноления результата тестирования для Pass/Fail"
    Private Function UpdateStepRes(StepID As Integer, StepRes As Integer, _numID As ArrayList, FormatSN As Integer)
        Dim Message As String
        Dim MesColor As Color
        Dim ErrCode As New ArrayList()
        Dim _stepArr As ArrayList = New ArrayList(GetPreStep(_numID))
        Select Case FormatSN
            Case 1
                'Внесение карантина по номеру платы
                'если номера не связаны, то обновить лог с привязкой новой ошибки для выбранной платы
                'If IsDBNull(_stepArr(2)) Then
                '    PrintLabel(Controllabel, "Номер не приприемнику!", 12, 193, Color.Red)
                '    CurrentLogUpdate(Label_ShiftCounter.Text, SerialTextBox.Text, "Ошибка", "", $"Номер не приприемнику!")
                '    SNTBEnabled(False)
                '    GB_ErrorCode.Visible = False
                '    BT_Pass.Visible = False
                '    BT_Fail.Visible = False
                '    DG_UpLog.Visible = True
                '    TB_Description.Clear()
                '    Return False
                '    Exit Function
                'End If
            Case 2
                If IsDBNull(_stepArr(0)) Then
                    PrintLabel(Controllabel, "Номер не привязан к плате!", 12, 193, Color.Red)
                    CurrentLogUpdate(Label_ShiftCounter.Text, SerialTextBox.Text, "Ошибка", "", $"Номер не привязан к плате!")
                    SNTBEnabled(False)
                    GB_ErrorCode.Visible = False
                    BT_Pass.Visible = False
                    BT_Fail.Visible = False
                    DG_UpLog.Visible = True
                    TB_Description.Clear()
                    Return False
                    Exit Function
                End If
        End Select
        ShiftCounter(3)
        Select Case StepRes
            Case 2
                ErrCode = GetErrorCode()
                Message = $"Для приемника {SerialTextBox.Text} произведена технологическая отвязка!{vbCrLf}Передайте приемник на старт линии!"
                MesColor = Color.Green
                CurrentLogUpdate(Label_ShiftCounter.Text, SerialTextBox.Text, "PASS", ErrCode(1), $"Для приемника {SerialTextBox.Text} произведена технологическая отвязка!{vbCrLf}Передайте приемник на старт линии!")
            Case 3
                ErrCode = GetErrorCode()
                Message = $"Приемник {SerialTextBox.Text} не прошёл этап тестирования!{vbCrLf}Передайте приемник в ремонт!"
                MesColor = Color.Red
                CurrentLogUpdate(Label_ShiftCounter.Text, SerialTextBox.Text, "Карантин", ErrCode(1), $"Приемник {SerialTextBox.Text} не прошёл этап тестирования!{vbCrLf}Передайте приемник в ремонт!")
        End Select
        RunCommand($"Use FAS insert into [FAS].[dbo].[Ct_OperLog] ([PCBID],[LOTID],[StepID],[TestResultID],[StepDate],
                    [StepByID],[LineID],[ErrorCodeID],[Descriptions])values
                    ( {_stepArr(0)} , {LOTID} , {StepID} , {StepRes} ,CURRENT_TIMESTAMP,
                    {UserInfo(0)} ,{PCInfo(2)} ,
                        {If(StepRes = 3, ErrCode(0), "Null")} ,
                        {If(StepRes = 3, If(TB_Description.Text = "", "Null", "'" & TB_Description.Text & "'"), "Null")} )")
        RunCommand($"Use FAS insert into [FAS].[dbo].[Ct_OperLog] ([SNID],[LOTID],[StepID],[TestResultID],[StepDate],
                    [StepByID],[LineID])values
                    ( {_stepArr(2)} , {LOTID} , {StepID} , 2 ,CURRENT_TIMESTAMP,{UserInfo(0)} ,{PCInfo(2)}) ")
        RunCommand($"Use FAS update [FAS].[dbo].[CT_TCC_SN_MAC] set AssemblyWith = Null where [series bar] = '{_stepArr(3)}'")
        PrintLabel(Controllabel, Message, 12, 193, MesColor)
        Return True
    End Function
#End Region
#Region "4. Кнопка Сохранения кода ошибки"
    Private Sub BT_SeveErCode_Click(sender As Object, e As EventArgs) Handles BT_SeveErCode.Click
        If CB_ErrorCode.Text = "" Then
            MsgBox("Укажите код ошибки")
        ElseIf CB_ErrorCode.Text = "TT" Then
            If UpdateStepRes(PCInfo(6), 2, NumID, SNFormat(1)) = True Then
                BT_CleareSN_Click(sender, e)
            End If
            CB_ErrorCode.Text = ""
        Else
            If UpdateStepRes(PCInfo(6), 3, NumID, SNFormat(1)) = True Then
                BT_CleareSN_Click(sender, e)
            End If
            CB_ErrorCode.Text = ""
        End If
    End Sub
#End Region
#Region "5. резерв ))"
#End Region
#Region "6 деактивация ввода серийника"
    Private Sub SNTBEnabled(Res As Boolean)
        SerialTextBox.Enabled = Res
        BT_Pause.Focus()
    End Sub
#End Region
#Region "7. Кнопка Fail "
    Private Sub BT_Fail_Click(sender As Object, e As EventArgs) Handles BT_Fail.Click
        GB_ErrorCode.Visible = True
        GB_ErrorCode.Location = New Point(180, 333)
        DG_UpLog.Visible = False
        CB_ErrorCode.Focus()
    End Sub
    Private Sub GetError()
        SerialTextBox.Enabled = False
        DG_UpLog.Visible = False
        GB_ErrorCode.Location = New Point(195, 333)
        GB_ErrorCode.Visible = True
        CB_ErrorCode.Focus()
    End Sub
#End Region
#Region "8. Кнопка закрытия формы записи ошибок"
    Private Sub BT_CloseErrMode_Click(sender As Object, e As EventArgs)
        GB_ErrorCode.Visible = False
        DG_UpLog.Visible = True
        CurrrentTimeLabel.Focus()
    End Sub
#End Region
#Region "9. поиск кода ошибок"
    Private Function GetErrorCode() As ArrayList
        Dim ErrorCode As New ArrayList()
        'определяем errorcodID
        For J = 0 To DG_ErrorCodes.Rows.Count - 1
            If CB_ErrorCode.Text = DG_ErrorCodes.Rows(J).Cells(1).Value Then
                ErrorCode.Add(DG_ErrorCodes.Rows(J).Cells(0).Value)
                ErrorCode.Add(DG_ErrorCodes.Rows(J).Cells(1).Value)
                Exit For
            End If
        Next
        Return ErrorCode
    End Function
    'Поиск введенного кода ошибки в гриде
    Private Sub CB_ErrorCode_TextChanged(sender As Object, e As EventArgs) Handles CB_ErrorCode.TextChanged
        CB_ErrorCode.MaxLength = 2
        If Len(CB_ErrorCode.Text) = 2 Then
            BT_SeveErCode.Focus()
        ElseIf Len(CB_ErrorCode.Text) <> 2 Then
            Exit Sub
        End If
        BT_SeveErCode.Focus()
    End Sub
#End Region
#Region "10. Кнопка очистки поля ввода номера"
    Private Sub BT_CleareSN_Click(sender As Object, e As EventArgs) Handles BT_CleareSN.Click
        If GB_PCBInfoMode.Visible = False Then
            SerialTextBox.Clear()
            SerialTextBox.Enabled = True
            GB_ErrorCode.Visible = False
            BT_Pass.Visible = False
            BT_Fail.Visible = False
            DG_UpLog.Visible = True
            TB_Description.Clear()
            SerialTextBox.Focus()
        Else
            TB_GetPCPInfo.Clear()
            TB_GetPCPInfo.Enabled = True
            TB_GetPCPInfo.Focus()
        End If
    End Sub
#End Region
#Region "11. Функция запролнения LogGrid "
    Private Sub CurrentLogUpdate(ShtCounter As Integer, SN As String, ScanRes As String, ErrCode As String, Descr As String)
        ' заполняем строку таблицы
        Me.DG_UpLog.Rows.Add(ShtCounter, SN, ScanRes, Date.Now, ErrCode, Descr)
        DG_UpLog.Sort(DG_UpLog.Columns(3), System.ComponentModel.ListSortDirection.Descending)
    End Sub
#End Region
#Region "12. Счетчик продукции"
    Private Sub ShiftCounter(StepRes As Integer)
        ShiftCounterInfo(1) += 1
        ShiftCounterInfo(2) += 1
        If StepRes = 2 Then
            ShiftCounterInfo(3) += 1
        Else
            ShiftCounterInfo(4) += 1
        End If
        Label_ShiftCounter.Text = ShiftCounterInfo(1)
        'LB_Procent.Visible = True
        ShiftCounterUpdateCT(PCInfo(4), PCInfo(0), ShiftCounterInfo(0), ShiftCounterInfo(1), ShiftCounterInfo(2),
                         ShiftCounterInfo(3), ShiftCounterInfo(4))
        'YieldCounter()
    End Sub
#End Region
#Region "13. Проверка предыдущего шага"
    Private Function GetPreStep(_SnID As Integer) As ArrayList
        Dim newArr As ArrayList = New ArrayList(SelectListString($"use FAS 
                select tt.PCBID,L.Content, tt.SNID, Rg.SN, tt.StepID,tt.TestResultID, tt.StepDate 
                from  (SELECT *, ROW_NUMBER() over(partition by snid order by stepdate desc) num FROM [FAS].[dbo].[Ct_OperLog] ) tt
                left join Ct_FASSN_reg Rg On Rg.ID = tt.SNID
                Left join SMDCOMPONETS.dbo.LazerBase L On L.IDLaser = tt.PCBID
                where tt.LOTID = {LOTID} and  tt.num = 1 and  SNID  = {_SnID}"))
        Return newArr
    End Function

    Private Function GetPreStep(_Num As ArrayList) As ArrayList
        Dim newArr As ArrayList = New ArrayList()
        Select Case _Num(2)
            Case 1
                Return (SelectListString($"use FAS 
                select tt.PCBID,L.Content, tt.SNID, Rg.SN, tt.StepID,tt.TestResultID, tt.StepDate 
                from  (SELECT *, ROW_NUMBER() over(partition by pcbid order by stepdate desc) num FROM [FAS].[dbo].[Ct_OperLog] ) tt
                left join Ct_FASSN_reg Rg On Rg.ID = tt.SNID
                Left join SMDCOMPONETS.dbo.LazerBase L On L.IDLaser = tt.PCBID
                where tt.LOTID = {LOTID} and  tt.num = 1 and  PCBID  = {_Num(1)}"))
            Case 2
                Return (SelectListString($"use FAS 
                select tt.PCBID,L.Content, tt.SNID, Rg.SN, tt.StepID,tt.TestResultID, tt.StepDate 
                from  (SELECT *, ROW_NUMBER() over(partition by snid order by stepdate desc) num FROM [FAS].[dbo].[Ct_OperLog] ) tt
                left join Ct_FASSN_reg Rg On Rg.ID = tt.SNID
                Left join SMDCOMPONETS.dbo.LazerBase L On L.IDLaser = tt.PCBID
                where tt.LOTID = {LOTID} and  tt.num = 1 and  SNID  = {_Num(1)}"))
        End Select
        Return newArr
    End Function
#End Region
End Class




