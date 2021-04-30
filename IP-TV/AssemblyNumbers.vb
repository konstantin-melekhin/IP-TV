Imports System.Deployment.Application
Imports Library3

Public Class AssemblyNumbers
#Region "Переменные"
    Dim LOTID, IDApp, PCBID, SNID As Integer
    Dim ds As New DataSet
    Dim LenSN_SMT, LenSN_FAS, StartStepID, PreStepID, NextStepID As Integer
    Dim StartStep, PreStep, NextStep, Litera As String
    Dim PCInfo As New ArrayList() 'PCInfo = (App_ID, App_Caption, lineID, LineName, StationName,CT_ScanStep)
    Dim LOTInfo As New ArrayList() 'LOTInfo = (Model,LOT,SMTRangeChecked,SMTStartRange,SMTEndRange,ParseLog)
    Dim ShiftCounterInfo As New ArrayList() 'ShiftCounterInfo = (ShiftCounterID,ShiftCounter,LOTCounter)
    Dim SNBufer As New ArrayList 'SNBufer = (BooLSMT (Занят или свободен),SMTSN,BooLFAS (Занят или свободен),FASSN )
    Dim StepSequence As String()
    Dim SNFormat As ArrayList
#End Region
#Region "Загрузка рабочей формы"   'Загрузка рабочей формы    
    Public Sub New(LOTIDWF As Integer, IDApp As Integer)
        InitializeComponent()
        Me.LOTID = LOTIDWF
        Me.IDApp = IDApp
    End Sub
    'Загрузка рабочей формы
    Private Sub AssemblyNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myVersion As Version
        If ApplicationDeployment.IsNetworkDeployed Then
            myVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion
        End If
        LB_SW_Wers.Text = String.Concat("v", myVersion)
        PrintLabel(Controllabel, "", 12, 234, Color.Red)
        'получение данных о станции
        LoadGridFromDB(DG_StepList, "USE FAS SELECT [ID],[StepName],[Description] FROM [FAS].[dbo].[Ct_StepScan]")
        PCInfo = GetPCInfo(IDApp)
        LabelAppName.Text = PCInfo(7)
        Label_StationName.Text = PCInfo(5)
        Lebel_StationLine.Text = PCInfo(3)
        TextBox1.Text = "App_ID = " & PCInfo(0) & vbCrLf &
                            "App_Caption = " & PCInfo(1) & vbCrLf &
                            "lineID = " & PCInfo(2) & vbCrLf &
                            "LineName = " & PCInfo(3) & vbCrLf &
                            "StationID = " & PCInfo(4) & vbCrLf &
                            "StationName = " & PCInfo(5) & vbCrLf &
                            "CT_ScanStepID = " & PCInfo(6) & vbCrLf &
                            "CT_ScanStep = " & PCInfo(7) & vbCrLf &
                            "LiterID " & PCInfo(8) & vbCrLf &
                            "LiterName = " & PCInfo(9)
        'получение данных о текущем лоте
        LOTInfo = GetCurrentContractLot(LOTID)
        LenSN_SMT = If(LOTInfo(2) = True, GetLenSN(LOTInfo(3)), 1)
        LenSN_FAS = If(LOTInfo(7) = True, GetLenSN(LOTInfo(8)), 1)
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
                            "HexSN = " & LOTInfo(18)
        'Определить стартовый шаг, текущий и последующий
        StepSequence = New String(Len(LOTInfo(14)) / 2 - 1) {}
        For i = 0 To Len(LOTInfo(14)) - 1 Step 2
            Dim J As Integer
            StepSequence(J) = Mid(LOTInfo(14), i + 1, 2)
            J += 1
        Next
        For i = 0 To StepSequence.Count - 1
            If Convert.ToInt32(StepSequence(i), 16) = PCInfo(6) Then
                StartStepID = Convert.ToInt32(StepSequence(0), 16)
                PreStepID = If(i <> 0, Convert.ToInt32(StepSequence(i - 1), 16), 0)
                NextStepID = If(i <> StepSequence.Count - 1, Convert.ToInt32(StepSequence(i + 1), 16), 0)
                For Each row As DataGridViewRow In DG_StepList.Rows
                    Dim j As Integer
                    If StartStepID = DG_StepList.Item(0, j).Value Then
                        StartStep = DG_StepList.Item(1, j).Value
                    ElseIf PreStepID = DG_StepList.Item(0, j).Value Then
                        PreStep = DG_StepList.Item(1, j).Value
                    ElseIf NextStepID = DG_StepList.Item(0, j).Value Then
                        NextStep = DG_StepList.Item(1, j).Value
                    End If
                    j += 1
                Next
                If PreStepID = StartStepID Then
                    PreStep = StartStep
                End If
                Exit For
            End If
        Next
        L_LOT.Text = LOTInfo(1)
        L_Model.Text = LOTInfo(0)
        L_BoxCapacity.Text = LOTInfo(15)
        L_PalletCapacity.Text = LOTInfo(16)
        L_Liter.Text = If(LOTInfo(17) = 0, PCInfo(9), PCInfo(9) & " " & LOTInfo(17))
        'Запуск программы
        '___________________________________________________________
        GB_UserData.Location = New Point(10, 12)
        TB_RFIDIn.Focus()
        'запуск счетчика продукции за день
        CurrentTimeTimer.Start()
        ShiftCounterInfo = ShiftCounterStart(PCInfo(4), IDApp, LOTID)
        Label_ShiftCounter.Text = ShiftCounterInfo(1)
        LB_LOTCounter.Text = ShiftCounterInfo(2)
    End Sub
#End Region
#Region "'очистка Серийного номера при ошибке"
    Private Sub BT_ClearSN_Click(sender As Object, e As EventArgs) Handles BT_ClearSN.Click
        SerialTextBox.Clear()
        PrintLabel(Controllabel, "", Color.Black)
        SerialTextBox.Enabled = True
        SNBufer = New ArrayList()
        SerialTextBox.Focus()
    End Sub
#End Region
#Region "Часы в программе"    'Часы в программе
    Private Sub CurrentTimeTimer_Tick(sender As Object, e As EventArgs) Handles CurrentTimeTimer.Tick
        CurrrentTimeLabel.Text = TimeString
    End Sub 'Часы в программе
#End Region
#Region "регистрация пользователя"     'регистрация пользователя.
    Dim UserInfo As New ArrayList()
    Private Sub TB_RFIDIn_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_RFIDIn.KeyDown
        TB_RFIDIn.MaxLength = 10
        If e.KeyCode = Keys.Enter And TB_RFIDIn.TextLength = 10 Then ' если длина номера равна 10, то запускаем процесс
            UserInfo = GetUserData(TB_RFIDIn.Text, GB_UserData, GB_WorkAria, L_UserName, TB_RFIDIn)
            '"UserID = " & UserInfo(0) & vbCrLf &
            '"Name = " & UserInfo(1) & vbCrLf &
            '"User Group = " & UserInfo(2) & vbCrLf  'UserInfo
            SerialTextBox.Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            TB_RFIDIn.Clear()
        End If
    End Sub 'регистрация пользователя
#End Region
#Region "условия для возврата в окно настроек"  ' условия для возврата в окно настроек
    Dim OpenSettings As Boolean
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles BT_OpenSettings.Click, BT_LogInClose.Click
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
    Private Sub SerialTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SerialTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then  'And (SerialTextBox.TextLength = LenSN_SMT Or SerialTextBox.TextLength = LenSN_FAS) Then
            'определение формата номера
            If GetFTSN(LOTInfo(12)) = True Then
                'проверка диапазона номера
                If CheckRange(SNFormat) = True Then
                    'проверка задвоения и наличия номера в базе
                    If CheckDublicate(SerialTextBox.Text, GetPcbID(SNFormat)) = True Then
                        Dim Mess As String
                        ' номер двойной
                        If SNBufer.Count = 0 Then
                            Select Case SNFormat(1)
                                Case 1 ' запись в буфер СМТ номера
                                    SNBufer = New ArrayList From {True, SerialTextBox.Text, PCBID, False, "", Nothing, 1}
                                    Mess = "SMT номер " & SerialTextBox.Text & " определен!" & vbCrLf &
                                           "Отсканируйте номер FAS!"
                                Case 2 'запись в буфер FAS номера
                                    SNBufer = New ArrayList From {False, "", Nothing, True, SerialTextBox.Text, SNID, 2}
                                    Mess = "FAS номер " & SerialTextBox.Text & " определен!" & vbCrLf &
                                           "Отсканируйте номер SMT!"
                            End Select
                            'если в буфере имеется СМТ номер
                        ElseIf SNBufer.Count <> 0 And SNBufer(0) = True And SNBufer(3) = False Then
                            'Запись в базу
                            WriteDB(SNBufer(1), SNBufer(2), SerialTextBox.Text, SNID)
                            Mess = "Номера определены и записаны в базу!"
                            'если в буфере имеется СМТ номер
                        ElseIf SNBufer.Count <> 0 And SNBufer(0) = False And SNBufer(3) = True Then
                            'Запись в базу
                            WriteDB(SerialTextBox.Text, PCBID, SNBufer(4), SNBufer(5))
                            Mess = "Номера определены и записаны в базу!"
                        End If
                        PrintLabel(Controllabel, Mess, 12, 193, Color.Green)
                        SerialTextBox.Clear()
                    End If
                End If
            End If
        End If
        SerialTextBox.Focus()
    End Sub
#End Region
#Region "'1. Определение формата номера"
    Private Function GetFTSN(SingleSN As Boolean) As Boolean
        Dim col As Color, Mess As String, Res As Boolean
        SNFormat = New ArrayList()
        SNFormat = GetSNFormat(LOTInfo(3), LOTInfo(8), SerialTextBox.Text, LOTInfo(18), LOTInfo(2), LOTInfo(7))
        Res = SNFormat(0)
        Mess = SNFormat(3)
        'SNFormat(0) ' Результат проверки True/False
        'SNFormat(1) ' 1 - SMT/ 2 - FAS / 3 - Неопределен
        'SNFormat(2) ' Переменный номер
        'SNFormat(3) ' Текст сообщения
        If Res = True Then
            If SNBufer.Count <> 0 Then
                If SNBufer(1) = SerialTextBox.Text Or SNBufer(4) = SerialTextBox.Text Then
                    Mess = $"Этот номер { SerialTextBox.Text } уже был отсканирован. { vbCrLf}Сбросьте ошибку и повторите сканирование обоих{ vbCrLf }номеров платы заново!"
                    Res = False
                ElseIf SNBufer(6) = SNFormat(1) Then
                    Mess = $"Номер {If(SNFormat(1) = 1, "SMT", "FAS")} уже записан в буфер. { vbCrLf}Сбросьте ошибку и повторите сканирование обоих{ vbCrLf }номеров заново!"
                    Res = False
                End If
            End If
        End If
        col = If(Res = False, Color.Red, Color.Green)
        PrintLabel(Controllabel, Mess, 12, 193, col)
        SNTBEnabled(Res)
        Return Res
    End Function
#End Region
#Region "'2 проверка диапазона"
    Private Function CheckRange(SNFormat As ArrayList) As Boolean
        Dim res As Boolean
        Dim ChekRange As Boolean, StartRange As Integer, EndRange As Integer
        Select Case SNFormat(1)
            Case 1
                ChekRange = LOTInfo(4)
                StartRange = LOTInfo(5)
                EndRange = LOTInfo(6)
            Case 2
                ChekRange = LOTInfo(9)
                StartRange = LOTInfo(10)
                EndRange = LOTInfo(11)
        End Select

        If ChekRange = True Then
            If StartRange <= SNFormat(2) And SNFormat(2) <= EndRange Then
                res = True
            Else
                res = False
                PrintLabel(Controllabel, "Номер " & SerialTextBox.Text & vbCrLf & "вне диапазона выбранного лота!", 12, 193, Color.Red)
                SerialTextBox.Enabled = False
            End If
        Else
            res = True
        End If
        Return res
    End Function
#End Region
#Region "'3 поиск ID PCB в базе гравировщика И SNID в базе FASSN_reg"
    Private Function GetPcbID(SNFormat As ArrayList) As ArrayList
        Dim Res As New ArrayList(), Mess As String, Col As Color
        Select Case SNFormat(1)
            Case 1
                PCBID = SelectInt("USE SMDCOMPONETS Select [IDLaser] FROM [SMDCOMPONETS].[dbo].[LazerBase] where Content = '" & SerialTextBox.Text & "'")
                Res.Add(PCBID <> 0)
                Res.Add(PCBID)
                Res.Add(SNFormat(1))
                Mess = If(PCBID = 0, "SMT номер " & SerialTextBox.Text & vbCrLf & "не зарегистрирован в базе гравировщика!", "")
            Case 2
                SNID = SelectInt("USE FAS SELECT [ID] FROM [FAS].[dbo].[Ct_FASSN_reg] where SN = '" & SerialTextBox.Text & "'")
                If SNID = 0 Then
                    SNID = SelectInt("USE FAS " & vbCrLf & "
                       insert into [FAS].[dbo].[Ct_FASSN_reg] ([SN],[LOTID],[UserID],[AppID],[LineID],[RegDate]) values" & vbCrLf & "
                       ('" & SerialTextBox.Text & "'," & LOTID & "," & UserInfo(0) & "," & PCInfo(0) & "," & PCInfo(2) & ", CURRENT_TIMESTAMP)" & vbCrLf & "
                       WAITFOR delay '00:00:00:100'" & vbCrLf & "
                       SELECT [ID] FROM [FAS].[dbo].[Ct_FASSN_reg] where SN = '" & SerialTextBox.Text & "'")
                End If
                Res.Add(SNID <> 0)
                Res.Add(SNID)
                Res.Add(SNFormat(1))
                Mess = If(SNID = 0, "FAS номер " & SerialTextBox.Text & vbCrLf & "не зарегистрирован в базе Ct_FASSN_reg!", "")
        End Select
        Col = If(Res(0) = False, Color.Red, Color.Green)
        PrintLabel(Controllabel, Mess, 12, 193, Col)
        SNTBEnabled(Res(0))
        Return Res
    End Function
#End Region
#Region "'4. Проверка предыдущего шага и дубликатов"
    Private Function CheckDublicate(SN As String, GetPCB_SNID As ArrayList) As Boolean
        Dim Res As Boolean, SQL As String, Mess As String, Col As Color
        'Проверка предыдущего шага
        If GetPCB_SNID(0) = True Then
            Select Case GetPCB_SNID(2)
                Case 1
                    Dim arr As ArrayList = New ArrayList(SelectListString($"Use FAS select tt.PCBID,L.Content, tt.SNID, Rg.SN, tt.StepID,tt.TestResultID 
                                                    from  (SELECT *, ROW_NUMBER() over(partition by pcbid order by stepdate desc) num FROM [FAS].[dbo].[Ct_OperLog]) tt
                                                    left join Ct_FASSN_reg Rg On Rg.ID = tt.SNID
                                                    Left join SMDCOMPONETS.dbo.LazerBase L On L.IDLaser = tt.PCBID
                                                    where tt.LOTID = {LOTID} and  tt.num = 1 and PCBID = {GetPCB_SNID(1)}"))
                    If arr.Count > 0 Then
                        If IsDBNull(arr(2)) And arr(4) = 4 And arr(5) = 2 Then
                            Res = True
                            Mess = ""
                        ElseIf IsDBNull(arr(2)) And arr(4) <> 4 Then
                            Res = False
                            Mess = $"Плата {SerialTextBox.Text}{vbCrLf}имеет не верный предыдущий шаг!"
                            CurrentLogUpdate(ShiftCounterInfo(1), SerialTextBox.Text, "", Mess)
                        ElseIf arr(2) > 0 Then
                            Res = False
                            Mess = $"Плата {SerialTextBox.Text}{vbCrLf}уже привязана к номеру {arr(3)}!"
                            CurrentLogUpdate(ShiftCounterInfo(1), SerialTextBox.Text, "", Mess)
                        End If
                    ElseIf arr.Count = 0 Then
                        Res = True
                        Mess = ""
                    End If
                Case 2
                    Dim arr As ArrayList = New ArrayList(SelectListString($"Use FAS Select tt.PCBID,L.Content, tt.SNID, Rg.SN, tt.StepID,tt.TestResultID from  
                                        (SELECT *, ROW_NUMBER() over(partition by snid order by stepdate desc) num FROM [FAS].[dbo].[Ct_OperLog] Ol) tt
                                        left join Ct_FASSN_reg Rg On Rg.ID = tt.SNID
                                        Left join SMDCOMPONETS.dbo.LazerBase L On L.IDLaser = tt.PCBID
                                        where SNID  = {GetPCB_SNID(1)} and tt.LOTID = {LOTID} and  tt.num = 1 "))
                    If arr.Count > 0 Then
                        If IsDBNull(arr(0)) And (arr(4) = 36 And arr(5) = 2) Or (arr(4) = 28 And arr(5) = 2) Then
                            Res = True
                            Mess = ""
                        ElseIf IsDBNull(arr(0)) And arr(4) <> 4 Then
                            Res = False
                            Mess = $"Серийный номер {SerialTextBox.Text}{vbCrLf}имеет не верный предыдущий шаг!"
                            CurrentLogUpdate(ShiftCounterInfo(1), "", SerialTextBox.Text, Mess)
                        ElseIf arr(0) > 0 Then
                            Res = False
                            Mess = $"Серийный номер {SerialTextBox.Text}{vbCrLf}уже присвоен плате {arr(1)}!"
                            CurrentLogUpdate(ShiftCounterInfo(1), "", SerialTextBox.Text, Mess)
                        End If
                    ElseIf arr.Count = 0 Then
                        Res = True
                        Mess = $"Серийный номер {SerialTextBox.Text}  {vbCrLf} не зарегистрирован в базе OperLog!"
                        CurrentLogUpdate(ShiftCounterInfo(1), "", SerialTextBox.Text, Mess)
                    End If
            End Select
            Col = If(Res = False, Color.Red, Color.Green)
            PrintLabel(Controllabel, Mess, 12, 193, Col)
            SNTBEnabled(Res)
            Return Res
        Else
            Return False
        End If
    End Function
#End Region
#Region "'5. Запись в базу данных и в Рабочий грид"
    Dim TableColumn As ArrayList
    Private Sub WriteDB(SMTSN As String, SMTSNID As Integer, FASSN As String, FASSNID As Integer)
        'список для записи в грид упаковки
        CurrentLogUpdate(ShiftCounter(2), SMTSN, FASSN)
        RunCommand($" use FAS
                 update  [FAS].[dbo].[CT_TCC_SN_MAC] set AssemblyWith = {SMTSNID} where [series bar] = (select SN from Ct_FASSN_reg where ID = {FASSNID})")
        RunCommand("insert into [FAS].[dbo].[Ct_OperLog] ([PCBID],[LOTID],[StepID],[TestResultID],[StepDate],
                    [StepByID],[LineID],[SNID])values
                    (" & SMTSNID & "," & LOTID & ",30,2,CURRENT_TIMESTAMP," & UserInfo(0) & "," & PCInfo(2) & "," & FASSNID & ")")
        SNBufer = New ArrayList 'очищаем буфер
    End Sub
#End Region
#Region "'6.1 'Счетчик продукции"
    Private Function ShiftCounter(StepRes As Integer) As Integer
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
        Return ShiftCounterInfo(1)
    End Function

#End Region
#Region "'6.2 деактивация ввода серийника"
    Private Sub SNTBEnabled(Res As Boolean)
        SerialTextBox.Enabled = Res
        BT_Pause.Focus()
    End Sub
#End Region
#Region "'6.3 Обновляем лог"
    Private Sub CurrentLogUpdate(ShtCounter As Integer, SN1 As String, SN2 As String)
        ' заполняем строку таблицы
        Me.DG_UpLog.Rows.Add(ShtCounter, SN1, SN2, Date.Now)
        DG_UpLog.Sort(DG_UpLog.Columns(3), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub CurrentLogUpdate(ShtCounter As Integer, SN1 As String, SN2 As String, Comment As String)
        ' заполняем строку таблицы
        Me.DG_UpLog.Rows.Add(ShtCounter, SN1, SN2, Date.Now, Comment)
        DG_UpLog.Sort(DG_UpLog.Columns(3), System.ComponentModel.ListSortDirection.Descending)
    End Sub
#End Region



End Class