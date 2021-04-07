Imports System.Deployment.Application
Imports System.Drawing.Printing
Imports System.IO
Imports Library3

Public Class IP_TV_Print

    Dim LOTID, IDApp As Integer
    Dim LenSN, StartStepID As Integer, PreStepID As Integer, NextStepID As Integer
    Dim PCInfo As New ArrayList() 'PCInfo = (App_ID, App_Caption, lineID, LineName, StationName,CT_ScanStep)
    Dim LOTInfo As New ArrayList() 'LOTInfo = (Model,LOT,SMTRangeChecked,SMTStartRange,SMTEndRange,ParseLog)
    Dim ShiftCounterInfo, Coordinats As New ArrayList() 'ShiftCounterInfo = (ShiftCounterID,ShiftCounter,LOTCounter)
    Dim PrinterInfo() As String
    Public Sub New(LOTIDWF As Integer, IDApp As Integer)
        InitializeComponent()
        Me.LOTID = LOTIDWF
        Me.IDApp = IDApp
    End Sub
#Region "Загрузка рабочей формы"   'Загрузка рабочей формы
    Private Sub IP_TV_Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myVersion As Version
        If ApplicationDeployment.IsNetworkDeployed Then
            myVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion
        End If
        LB_SW_Wers.Text = String.Concat("v", myVersion)
        PrintLabel(Controllabel, "", 12, 234, Color.Red)
        'вывод версии
        'MsgBox(Application.CompanyName)

        ''имя компании
        'получение данных о станции
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
        CB_SelectLabel.SelectedIndex = If(PCInfo(6) = 26, 0, 1)
        'получение данных о текущем лоте
        LOTInfo = GetCurrentContractLot(LOTID)
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
        CB_PrinterSettings.Checked = False
#Region "Обнаружение принтеров и установка дефолтного принтера"
        For Each item In PrinterSettings.InstalledPrinters
            If InStr(item.ToString(), "ZDesigner") Then
                CB_DefaultPrinter.Items.Add(item.ToString())
            End If
        Next
        If CB_DefaultPrinter.Items.Count = 0 Then
            PrintLabel(Controllabel, "Ни один принтер не подключен!", 12, 234, Color.Red)
        End If
        GetCoordinats()
#End Region
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
    '_________________________________________________________________________________________________________________
    'начало работы приложения FAS Scanning Station
#Region "Обработка окна ввода серийного номера" 'окно ввода серийного номера платы 
    Dim SNID As Integer
    Private Sub SerialTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SerialTextBox.KeyDown
        Dim Mess As New ArrayList()
        If e.KeyCode = Keys.Enter And SerialTextBox.TextLength = LenSN And CB_SelectLabel.SelectedIndex = 0 Then
            'печать Этикетки 45х8 и 39х19
            SNID = AddSNToDB(SerialTextBox.Text) ' Z12300502043010009725376
            If Print(SearchSNForPrint(0), PrinterInfo(1).Split(";")(0), PrinterInfo(1).Split(";")(1), PrinterInfo(1).Split(";")(2), PrinterInfo(1).Split(";")(3)) = True Then
                If Print(SearchSNForPrint(0), PrinterInfo(2).Split(";")(0), PrinterInfo(1).Split(";")(1), PrinterInfo(1).Split(";")(2), PrinterInfo(1).Split(";")(3)) = True Then
                    ShiftCounter()
                    OperLogUpd(SNID, 26, 2, "Этикетки 45х8 и 39х19")
                    CurrentLogUpdate(ShiftCounterInfo(1), SerialTextBox.Text)
                    BT_CleareSN_Click(sender, e)
                End If
            End If
        ElseIf e.KeyCode = Keys.Enter And SerialTextBox.TextLength = LenSN And CB_SelectLabel.SelectedIndex = 1 Then
            'повтор Этикетка 44х21_Rus
            SNID = AddSNToDB(SerialTextBox.Text)
            If Print(SearchSNForPrint(0), PrinterInfo(0).Split(";")(0), PrinterInfo(0).Split(";")(1), PrinterInfo(0).Split(";")(2), PrinterInfo(0).Split(";")(3)) = True Then
                OperLogUpd(SNID, 36, 2, "Этикетка 44х21_Rus_Повтор")
                CurrentLogUpdate(ShiftCounterInfo(1), SerialTextBox.Text)
                BT_CleareSN_Click(sender, e)
            End If
        ElseIf e.KeyCode = Keys.Enter And SerialTextBox.TextLength = 0 And CB_SelectLabel.SelectedIndex = 1 Then
            'печать Этикетка 44х21_Rus
            Dim SNForPrint = SearchSNForPrint(1)
            If Print(SNForPrint, PrinterInfo(0).Split(";")(0), PrinterInfo(0).Split(";")(1), PrinterInfo(0).Split(";")(2), PrinterInfo(0).Split(";")(3)) = True Then
                ShiftCounter()
                OperLogUpd(AddSNToDB(SNForPrint(1)), 36, 2, "Этикетка 44х21_Rus")
                CurrentLogUpdate(ShiftCounterInfo(1), SNForPrint(1))
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            'если введен не верный номер
            PrintLabel(Controllabel, SerialTextBox.Text & " не верный номер", 12, 234, Color.Red)
            SerialTextBox.Enabled = False
            BT_Pause.Focus()
        End If
    End Sub
#End Region
#Region "добавляет серийный номер в Ct_FASSN_reg, чтобы создать SNID"
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
#End Region
#Region "запись в опер лог DB и Лога в программе"
    Private Sub OperLogUpd(_SNID As Integer, StepID As Integer, StepRes As Integer, Descr As String)
        RunCommand($"insert into [FAS].[dbo].[Ct_OperLog] ([LOTID],[StepID],[TestResultID],[StepDate],
                    [StepByID],[LineID],[SNID],[Descriptions])values
                    ({LOTID},{StepID},{StepRes},CURRENT_TIMESTAMP,{ UserInfo(0) },{ PCInfo(2) },{ _SNID },'{ Descr }')")
    End Sub
    'Функция заполнения LogGrid 
    Private Sub CurrentLogUpdate(ShtCounter As Integer, SN As String)
        ' заполняем строку таблицы
        Me.DG_UpLog.Rows.Add(ShtCounter, SN, Date.Now)
        DG_UpLog.Sort(DG_UpLog.Columns(2), System.ComponentModel.ListSortDirection.Descending)
    End Sub
#End Region
#Region "Поиск номера для печати"
    Private Function SearchSNForPrint(SerchParametr As Integer) As ArrayList
        Dim SN As New ArrayList()
        Select Case SerchParametr
            Case 0
                SN = SelectListString($"use fas
                SELECT [SN],[series bar],[MAC_Bar],[MAC_Print],[IsPacked]
                FROM [FAS].[dbo].[CT_TCC_SN_MAC] where [series bar] = '{ SerialTextBox.Text}' and LOTID = {LOTID}")
            Case 1
                SN = SelectListString($"use FAS  
                declare @SerialNumber nvarchar(24)  
                select @SerialNumber = (SELECT top 1 [series bar] FROM [FAS].[dbo].[CT_TCC_SN_MAC] where IsPrinted = 0 and LOTID = {LOTID})  
                Update [FAS].[dbo].[CT_TCC_SN_MAC] Set  IsPrinted  = 1, PrintStationID ={ PCInfo(4)},[PrintDate] = CURRENT_TIMESTAMP  where [series bar] = @SerialNumber and LOTID = {LOTID}
                WAITFOR delay '00:00:00:100'
                select [SN],[series bar],[MAC_Bar],[MAC_Print],[IsPacked] 
                from [FAS].[dbo].[CT_TCC_SN_MAC] where [series bar] = @SerialNumber and PrintStationID = { PCInfo(4) } and LOTID = {LOTID}")
        End Select
        Return SN
    End Function
#End Region
#Region "Регулировка положения контента на этикетке"
    Private Sub CB_PrinterSettings_CheckedChanged(sender As Object, e As EventArgs) Handles CB_PrinterSettings.CheckedChanged
        If CB_PrinterSettings.Checked = True Then
            GB_Printers.Visible = True
            DG_UpLog.Visible = False
        Else
            GB_Printers.Visible = False
            DG_UpLog.Visible = True
            PrintLabel(Controllabel, "", 12, 234, Color.Red)
        End If
    End Sub
#End Region
#Region "Кнопка очистки поля ввода номера"
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
#End Region
    'функция печати
    Private Function Print(SNArray As ArrayList, DefPrt As String, LabScenario As Integer, x As Integer, y As Integer)
        If DefPrt <> "" Then
            RawPrinterHelper.SendStringToPrinter(DefPrt, Get_ContentTo_Print(SNArray, LabScenario, x, y))
            Return True
        Else
            MsgBox("Принтер не выбран или не подключен")
            Return False
        End If
    End Function
    Private Sub GetCoordinats()
        Try
            PrinterInfo = File.ReadAllLines("C:\IP_TV_LabelSet\Coordinats.csv")
        Catch ex As Exception
            PrinterInfo = New String(2) {}
            For i = 0 To 2
                PrinterInfo(i) = $"{CB_DefaultPrinter.Items(0)};0;0;0;"
            Next
            IO.Directory.CreateDirectory("C:\IP_TV_LabelSet\")
            File.Create("C:\IP_TV_LabelSet\Coordinats.csv").Close()
            File.WriteAllLines("C:\IP_TV_LabelSet\Coordinats.csv", PrinterInfo)
            CB_PrinterSettings.Checked = True
            PrintLabel(Controllabel, "Произведите первичную настройку принтеров для печати этикеток!", 12, 234, Color.Red)
        End Try
    End Sub

    Private Sub BT_Save_Coordinats_Click(sender As Object, e As EventArgs) Handles BT_Save_Coordinats.Click
        PrinterInfo(CB_LabScenario.SelectedIndex) = $"{CB_DefaultPrinter.SelectedItem};{CB_LabScenario.SelectedIndex};{Num_X.Value};{Num_Y.Value}"
        File.WriteAllLines("C:\IP_TV_LabelSet\Coordinats.csv", PrinterInfo)
        GetCoordinats()
    End Sub

    'Счетчик продукции
    Private Sub ShiftCounter()
        ShiftCounterInfo(1) += 1
        ShiftCounterInfo(2) += 1
        Label_ShiftCounter.Text = ShiftCounterInfo(1)
        LB_LOTCounter.Text = ShiftCounterInfo(2)
        ShiftCounterUpdateCT(PCInfo(4), PCInfo(0), ShiftCounterInfo(0), ShiftCounterInfo(1), ShiftCounterInfo(2))
    End Sub

End Class

