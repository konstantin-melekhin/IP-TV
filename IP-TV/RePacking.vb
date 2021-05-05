Imports System.Deployment.Application
Imports System.Drawing.Printing
Imports System.IO
Imports Library3



Public Class RePacking
#Region "Переменные"
    Dim LOTID, IDApp, UnitCounter, PCBID, SNID, PalletNumber, BoxNumber As Integer
    Dim ds As New DataSet
    Dim LenSN_SMT, LenSN_FAS, StartStepID, PreStepID, NextStepID As Integer
    Dim StartStep, PreStep, NextStep, Litera As String
    Dim PCInfo As New ArrayList() 'PCInfo = (App_ID, App_Caption, lineID, LineName, StationName,CT_ScanStep)
    Dim LOTInfo As New ArrayList() 'LOTInfo = (Model,LOT,SMTRangeChecked,SMTStartRange,SMTEndRange,ParseLog)
    Dim ShiftCounterInfo As New ArrayList() 'ShiftCounterInfo = (ShiftCounterID,ShiftCounter,LOTCounter)
    Dim SNBufer As New ArrayList 'SNBufer = (BooLSMT (Занят или свободен),SMTSN,BooLFAS (Занят или свободен),FASSN )
    Dim StepSequence As String()
    Dim SNFormat As ArrayList
    Dim PrinterInfo() As String
#End Region
#Region "Загрузка формы"
    Public Sub New(LOTID As Integer, IDApp As Integer)
        InitializeComponent()
        Me.LOTID = LOTID
        Me.IDApp = IDApp
    End Sub
    Private Sub RePacking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Обнаружение принтеров и установка дефолтного принтера"
        For Each item In PrinterSettings.InstalledPrinters
            If InStr(item.ToString(), "ZDesigner") Then
                CB_DefaultPrinter.Items.Add(item.ToString())
            End If
            If CB_DefaultPrinter.Items.Count <> 0 Then
                CB_DefaultPrinter.Text = CB_DefaultPrinter.Items(0)
            Else
                PrintLabel(Controllabel, "Ни один принтер не подключен!", 12, 234, Color.Red)
            End If
        Next
        If CB_DefaultPrinter.Items.Count = 0 Then
            PrintLabel(Controllabel, "Ни один принтер не подключен!", 12, 234, Color.Red)
        End If
        'GetCoordinats()
#End Region
        Dim myVersion As Version
        If ApplicationDeployment.IsNetworkDeployed Then
            myVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion
        End If
        LB_SW_Wers.Text = String.Concat("v", myVersion)
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
        Litera = If(LOTInfo(17) = 0, PCInfo(9), (PCInfo(9) & LOTInfo(17)))
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

#Region "'Загруска упаковочного грида"
        BoxNum.Text = ""
        PalletNum.Text = ""
        LB_Liter.Text = ""
        LoadGridFromDB2(DG_Packing, $"use FAS
            SELECT UnitNum as '№',SN.SN AS 'FAS Номер',(Lit.LiterName + ' ' + cast(LiterIndex as nvarchar (5))) AS 'Литера' 
            ,PalletNum as 'Паллет', BoxNum as 'Групповая', Format(PackingDate,'dd.MM.yyyy HH:mm:ss') as 'Дата'
            FROM [FAS].[dbo].[Ct_PackingTable] as P
            Left join SMDCOMPONETS.dbo.LazerBase as L On L.IDLaser = p.PCBID
            Left join [FAS].[dbo].Ct_FASSN_reg as Sn On Sn.ID = p.SNID
            Left join [FAS].[dbo].FAS_Liter as Lit On Lit.ID = p.LiterID
            where P.LOTID = 0
            order by UnitNum desc", ds) '  P.LOTID = 0 - требуется для загрузки пустой таблицы
#End Region
        'определение стартовых данных для упаковки
        'PalletNumber = PalletNum.Text
        'BoxNumber = BoxNum.Text
    End Sub
#End Region
#Region "очистка Серийного номера при ошибке"
    Private Sub BT_ClearSN_Click(sender As Object, e As EventArgs) Handles BT_ClearSN.Click
        PrintLabel(Controllabel, "", Color.Black)
        SerialTextBox.Clear()
        Controllabel.Text = ""
        SerialTextBox.Enabled = True
        SNBufer = New ArrayList()
        SerialTextBox.Focus()
    End Sub
#End Region
#Region "Часы в программе"
    'Часы в программе
    Private Sub CurrentTimeTimer_Tick(sender As Object, e As EventArgs) Handles CurrentTimeTimer.Tick
        CurrrentTimeLabel.Text = TimeString
    End Sub 'Часы в программе
#End Region
#Region "регистрация пользователя"
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
#Region " условия для возврата в окно настроек"
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
#Region "           Обработка поля ввода серийного номера"
    'начало работы приложения FAS Scanning Station
    Dim _PalBoxNum As ArrayList, _ScanedSN As ArrayList
    Private Sub SerialTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SerialTextBox.KeyDown
        Dim _stepArr As ArrayList
        If e.KeyCode = Keys.Enter Then 'And (SerialTextBox.TextLength = LenSN_SMT Or SerialTextBox.TextLength = LenSN_FAS) Then
            'определение формата номера
            If GetFTSN(LOTInfo(12)) = True Then
#Region "Проверка наполнения коробки"
                If UnitCounter = LOTInfo(15) Then
                    ds.Clear() 'если юнит каунтер = емкости коробки, то очищаем грид коробки и увеличиваем счетчик на 1
                    LoadGridFromDB(DG_SelectedBox, "use FAS select * from [FAS].[dbo].[Ct_PackingTable] where ID = 999999999")
                    DG_Packing.BackgroundColor = Color.MistyRose
                End If
#End Region
                If DG_SelectedBox.Rows.Count = 0 Then ' проверка, заполнен ли поисковой грид, если нет то заполняем
                    _PalBoxNum = SerchBoxForPrint(SerialTextBox.Text) ' поиск номера коробки для отсканированного номера
                    If _PalBoxNum.Count > 0 Then
                        PalletNum.Text = _PalBoxNum(2)
                        BoxNum.Text = _PalBoxNum(3)
                        LB_Liter.Text = _PalBoxNum(4) & _PalBoxNum(1)
                        _ScanedSN = GetSNFromGrid(SerialTextBox.Text)
                        SN_Action()
                    End If
                Else
                    If CheckDublicate(SerialTextBox.Text) Then
                        _ScanedSN = GetSNFromGrid(SerialTextBox.Text)
                        SN_Action()
                    End If
                End If
            End If
        End If
        SerialTextBox.Focus()
    End Sub
#End Region
#Region "1. Определение формата номера"
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
            If SingleSN = False Then
                If SNBufer.Count <> 0 Then
                    If SNBufer(1) = SerialTextBox.Text Or SNBufer(3) = SerialTextBox.Text Then
                        Mess = "Этот номер " & SerialTextBox.Text & " уже был отсканирован. " & vbCrLf &
                            "Сбросьте ошибку и повторите сканирование обоих" & vbCrLf & "номеров платы заново!"
                        Res = False
                    End If
                End If
            End If
        End If
        col = If(Res = False, Color.Red, Color.Green)
        PrintLabel(Controllabel, Mess, 12, 193, col)
        SNTBEnabled(Res)
        Return Res
    End Function
#End Region
#Region "2. загрузка грида для поиска номеров"
    Dim SNArray As New ArrayList
    Dim SQL As String
    Private Function SerchBoxForPrint(_sn As String) 'LitName As String,
        Dim arr As ArrayList = New ArrayList(SelectListString($"use fas
                SELECT LiterID, [LiterIndex],[PalletNum],[BoxNum], Lit.LiterName
                FROM [FAS].[dbo].[Ct_PackingTable]p 
                Left join Ct_FASSN_reg Rg On Rg.ID = p.SNID 
                left join dbo.FAS_Liter as Lit On Lit.ID = P.LiterID 
                where p.LOTID = {LOTID} and  SN = '{_sn}'"))
        If arr.Count > 0 Then
            SQL = $"use fas
                SELECT  [UnitNum], F.SN, Lit.LiterName, PalletNum, BoxNum, p.SNID 
                FROM [FAS].[dbo].[Ct_PackingTable] as P
                left join [SMDCOMPONETS].[dbo].[LazerBase] as L On l.IDLaser = PCBID
                left join dbo.Ct_FASSN_reg as F On F.ID =P.SNID
                left join dbo.FAS_Liter as Lit On Lit.ID = P.LiterID
                where p.lotid ={LOTID} and literid = {arr(0)} and LiterIndex = {arr(1)} and PalletNum = {arr(2)} and BoxNum = {arr(3)} order by UnitNum "
            LoadGridFromDB(DG_SelectedBox, SQL)
        Else
            PrintLabel(Controllabel, $"Приемник {SerialTextBox.Text} { vbCrLf}не был ранее упакован!{ vbCrLf}Отложите данный приемник в сторону!", 12, 193, Color.Red)
            SNTBEnabled(False)
        End If
        Return arr
    End Function
    Private Function GetSNFromGrid(_serched_sn As String)
        Dim SNArrayTemp As New ArrayList
        SNArrayTemp.Add(DG_SelectedBox.Item(2, 0).Value) 'Liter
        SNArrayTemp.Add(DG_SelectedBox.Item(3, 0).Value) 'Pallet
        SNArrayTemp.Add(DG_SelectedBox.Item(4, 0).Value) 'Box
        For i = 0 To DG_SelectedBox.Rows.Count - 1
            If _serched_sn = DG_SelectedBox.Item(1, i).Value Then
                SNArrayTemp.Add(DG_SelectedBox.Item(1, i).Value) 'SN
                SNArrayTemp.Add(DG_SelectedBox.Item(5, i).Value) 'SN
                Exit For
            End If
        Next
        Return SNArrayTemp
    End Function

#End Region
#Region "3. Проверка дубликатов"
    Private Function CheckDublicate(_sn As String) As Boolean
        Dim Res As Boolean, Mess As String, Col As Color
        If DG_Packing.Rows.Count > 0 Then
            For i = 0 To DG_Packing.Rows.Count - 1
                If _sn = DG_Packing.Item(1, 0).Value Then
                    Res = False
                    PrintLabel(Controllabel, $"Серийный номер {_sn}{vbCrLf}уже отсканирован в этой коробке!", 12, 193, Color.Red)
                    Exit For
                Else
                    Res = True
                End If
            Next
        End If
        SNTBEnabled(Res)
        Return Res
    End Function
#End Region
#Region "4. Результат проверок и дальнейшее действие (запись в базу/блокировка)"
    Private Sub SN_Action()
        If _ScanedSN.Count = 5 Then
            WriteDB(_ScanedSN)
            PrintLabel(Controllabel, $"Приемник {SerialTextBox.Text} { vbCrLf}определен и записан в базу!", 12, 193, Color.Green)
            SerialTextBox.Clear()
        Else
            Dim arr As ArrayList = New ArrayList(SelectListString($"use fas
                                SELECT Lit.LiterName,[LiterIndex],[PalletNum],[BoxNum]
                                FROM [FAS].[dbo].[Ct_PackingTable]P
                                Left join Ct_FASSN_reg Rg On Rg.ID = P.SNID
                                left join dbo.FAS_Liter as Lit On Lit.ID = P.LiterID
                                where P.LOTID = {LOTID} and  SN = '{SerialTextBox.Text}'"))
            If arr.Count > 0 Then
                PrintLabel(Controllabel, $"Приемник {SerialTextBox.Text} { vbCrLf}из другой коробки!{ vbCrLf}Лит-{arr(0)}{arr(1)}; Пал-{arr(2)}; Кор-{arr(3)}", 12, 193, Color.Red)
            Else
                PrintLabel(Controllabel, $"Приемник {SerialTextBox.Text} { vbCrLf}не был ранее упакован!{ vbCrLf}Отложите данный приемник в сторону!", 12, 193, Color.Red)
            End If
            SNTBEnabled(False)
        End If
    End Sub
#End Region
#Region "5. Запись в базу данных и в Рабочий грид"
    Dim TableColumn As ArrayList
    Private Sub WriteDB(_SNInfo As ArrayList)
        'юнит каунтер = определяется количеством строк в гриде
        UnitCounter = DG_Packing.RowCount + 1
        'список для записи в грид упаковки
        TableColumn = New ArrayList() From {UnitCounter, _SNInfo(3), _SNInfo(0), _SNInfo(1), _SNInfo(2), Date.Now}
        Dim row = ds.Tables(0).NewRow()
        Dim i = 0
        For Each item In TableColumn
            row.Item(i) = item
            i += 1
        Next
        ds.Tables(0).Rows.Add(row)
        DG_Packing.DataSource = ds
        DG_Packing.Sort(DG_Packing.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        RunCommand($"use FAS
                  Update [FAS].[dbo].[Ct_PackingTable] set Descriptions = 'Перепаковка из-за замены корпусов', UpdDate = CURRENT_TIMESTAMP, UpdBy = {UserInfo(0)} where SNID = {_SNInfo(4)}")
        ShiftCounter(2)
        'Заполнение групповой
        If UnitCounter = LOTInfo(15) Then '
            DG_Packing.BackgroundColor = Color.GreenYellow
        End If
        RunCommand($"insert into [FAS].[dbo].[Ct_OperLog] ([LOTID],[StepID],[TestResultID],[StepDate],[StepByID],[LineID],[SNID])values
                    ({ LOTID },38,2,CURRENT_TIMESTAMP,{ UserInfo(0) },{ PCInfo(2) },{_SNInfo(4)})")
    End Sub
#End Region
#Region "6. проверка диапазона"
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
#Region "7 'Счетчик продукции"
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
#End Region
#Region "8. деактивация ввода серийника"
    Private Sub SNTBEnabled(Res As Boolean)
        SerialTextBox.Enabled = Res
        BT_Pause.Focus()
    End Sub
#End Region
#Region "9.Установки принтера"
    Private Sub BT_SetPrinter_Click(sender As Object, e As EventArgs) Handles BT_SetPrinter.Click
        If GB_Printers.Visible = False Then
            GB_Printers.Visible = True
            GB_Printers.Location = New Point(650, 60)
            GB_StationInfo.Visible = False
        Else
            GB_Printers.Visible = False
            GB_StationInfo.Visible = True
        End If
    End Sub
#End Region
End Class