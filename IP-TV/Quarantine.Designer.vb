﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quarantine
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quarantine))
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TB_GetPCPInfo = New System.Windows.Forms.TextBox()
        Me.BT_CloseErrMode = New System.Windows.Forms.Button()
        Me.DG_ErrorCodes = New System.Windows.Forms.DataGridView()
        Me.BT_SeveErCode = New System.Windows.Forms.Button()
        Me.TB_Description = New System.Windows.Forms.TextBox()
        Me.GB_ErrorCode = New System.Windows.Forms.GroupBox()
        Me.CB_ErrorCode = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BT_Pass = New System.Windows.Forms.Button()
        Me.BT_Fail = New System.Windows.Forms.Button()
        Me.SerialTextBox = New System.Windows.Forms.TextBox()
        Me.CERT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CASIDTab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCIDTab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BT_Pause = New System.Windows.Forms.Button()
        Me.DG_UpLog = New System.Windows.Forms.DataGridView()
        Me.HDCP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrrentTimeLabel = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Timer_Calibration = New System.Windows.Forms.Timer(Me.components)
        Me.GB_UserData = New System.Windows.Forms.GroupBox()
        Me.BT_LOGInClose = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TB_RFIDIn = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DG_THTStartFromDB = New System.Windows.Forms.DataGridView()
        Me.DG_PCBInfoFromDB = New System.Windows.Forms.DataGridView()
        Me.DG_THT_Start = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DG_StepList = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.CurrentTimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L_UserName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LB_Procent = New System.Windows.Forms.Label()
        Me.LB_Yield = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelAppName = New System.Windows.Forms.Label()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LB_CurrentStep = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_StationName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.L_Model = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.L_LOT = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Lebel_StationLine = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_ShiftCounter = New System.Windows.Forms.Label()
        Me.LB_FailLotRes = New System.Windows.Forms.Label()
        Me.LB_PassLotRes = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DG_PCB_Steps = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BT_CleareSN = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GB_PCBInfoMode = New System.Windows.Forms.GroupBox()
        Me.BT_PCBInfo = New System.Windows.Forms.Button()
        Me.BT_OpenSettings = New System.Windows.Forms.Button()
        Me.Controllabel = New System.Windows.Forms.Label()
        Me.GB_ScanMode = New System.Windows.Forms.GroupBox()
        Me.GB_WorkAria = New System.Windows.Forms.GroupBox()
        Me.FASErrorCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LB_SW_Wers = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.DG_ErrorCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_ErrorCode.SuspendLayout()
        CType(Me.DG_UpLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GB_UserData.SuspendLayout()
        CType(Me.DG_THTStartFromDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_PCBInfoFromDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_THT_Start, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_StepList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_PCB_Steps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_PCBInfoMode.SuspendLayout()
        Me.GB_ScanMode.SuspendLayout()
        Me.GB_WorkAria.SuspendLayout()
        CType(Me.FASErrorCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB_GetPCPInfo
        '
        Me.TB_GetPCPInfo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_GetPCPInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TB_GetPCPInfo.Location = New System.Drawing.Point(187, 47)
        Me.TB_GetPCPInfo.Name = "TB_GetPCPInfo"
        Me.TB_GetPCPInfo.Size = New System.Drawing.Size(508, 31)
        Me.TB_GetPCPInfo.TabIndex = 1
        '
        'BT_CloseErrMode
        '
        Me.BT_CloseErrMode.FlatAppearance.BorderSize = 0
        Me.BT_CloseErrMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CloseErrMode.Image = Global.IP_TV.My.Resources.Resources.icons8_стрелка_влево_в_круге_2_64
        Me.BT_CloseErrMode.Location = New System.Drawing.Point(536, 19)
        Me.BT_CloseErrMode.Name = "BT_CloseErrMode"
        Me.BT_CloseErrMode.Size = New System.Drawing.Size(53, 55)
        Me.BT_CloseErrMode.TabIndex = 35
        Me.BT_CloseErrMode.UseVisualStyleBackColor = True
        '
        'DG_ErrorCodes
        '
        Me.DG_ErrorCodes.AllowUserToAddRows = False
        Me.DG_ErrorCodes.AllowUserToDeleteRows = False
        Me.DG_ErrorCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ErrorCodes.Location = New System.Drawing.Point(488, 37)
        Me.DG_ErrorCodes.Name = "DG_ErrorCodes"
        Me.DG_ErrorCodes.ReadOnly = True
        Me.DG_ErrorCodes.Size = New System.Drawing.Size(101, 80)
        Me.DG_ErrorCodes.TabIndex = 34
        Me.DG_ErrorCodes.Visible = False
        '
        'BT_SeveErCode
        '
        Me.BT_SeveErCode.FlatAppearance.BorderSize = 0
        Me.BT_SeveErCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SeveErCode.Image = Global.IP_TV.My.Resources.Resources._3floppy_mount
        Me.BT_SeveErCode.Location = New System.Drawing.Point(517, 250)
        Me.BT_SeveErCode.Name = "BT_SeveErCode"
        Me.BT_SeveErCode.Size = New System.Drawing.Size(72, 79)
        Me.BT_SeveErCode.TabIndex = 3
        Me.BT_SeveErCode.UseVisualStyleBackColor = True
        '
        'TB_Description
        '
        Me.TB_Description.Location = New System.Drawing.Point(10, 177)
        Me.TB_Description.Multiline = True
        Me.TB_Description.Name = "TB_Description"
        Me.TB_Description.Size = New System.Drawing.Size(495, 140)
        Me.TB_Description.TabIndex = 2
        '
        'GB_ErrorCode
        '
        Me.GB_ErrorCode.Controls.Add(Me.BT_CloseErrMode)
        Me.GB_ErrorCode.Controls.Add(Me.DG_ErrorCodes)
        Me.GB_ErrorCode.Controls.Add(Me.BT_SeveErCode)
        Me.GB_ErrorCode.Controls.Add(Me.TB_Description)
        Me.GB_ErrorCode.Controls.Add(Me.CB_ErrorCode)
        Me.GB_ErrorCode.Controls.Add(Me.Label8)
        Me.GB_ErrorCode.Controls.Add(Me.Label4)
        Me.GB_ErrorCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GB_ErrorCode.Location = New System.Drawing.Point(1354, 426)
        Me.GB_ErrorCode.Name = "GB_ErrorCode"
        Me.GB_ErrorCode.Size = New System.Drawing.Size(595, 335)
        Me.GB_ErrorCode.TabIndex = 47
        Me.GB_ErrorCode.TabStop = False
        Me.GB_ErrorCode.Text = "Регистрация кода ошибки"
        '
        'CB_ErrorCode
        '
        Me.CB_ErrorCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_ErrorCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_ErrorCode.FormattingEnabled = True
        Me.CB_ErrorCode.Location = New System.Drawing.Point(10, 97)
        Me.CB_ErrorCode.Name = "CB_ErrorCode"
        Me.CB_ErrorCode.Size = New System.Drawing.Size(266, 39)
        Me.CB_ErrorCode.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(314, 31)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Введите комментарий"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(283, 31)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Укажите код отказа"
        '
        'BT_Pass
        '
        Me.BT_Pass.FlatAppearance.BorderSize = 0
        Me.BT_Pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Pass.Image = CType(resources.GetObject("BT_Pass.Image"), System.Drawing.Image)
        Me.BT_Pass.Location = New System.Drawing.Point(17, 17)
        Me.BT_Pass.Name = "BT_Pass"
        Me.BT_Pass.Size = New System.Drawing.Size(97, 91)
        Me.BT_Pass.TabIndex = 26
        Me.BT_Pass.UseVisualStyleBackColor = True
        Me.BT_Pass.Visible = False
        '
        'BT_Fail
        '
        Me.BT_Fail.FlatAppearance.BorderSize = 0
        Me.BT_Fail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Fail.Image = CType(resources.GetObject("BT_Fail.Image"), System.Drawing.Image)
        Me.BT_Fail.Location = New System.Drawing.Point(833, 17)
        Me.BT_Fail.Name = "BT_Fail"
        Me.BT_Fail.Size = New System.Drawing.Size(87, 91)
        Me.BT_Fail.TabIndex = 27
        Me.BT_Fail.UseVisualStyleBackColor = True
        Me.BT_Fail.Visible = False
        '
        'SerialTextBox
        '
        Me.SerialTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SerialTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SerialTextBox.Location = New System.Drawing.Point(189, 47)
        Me.SerialTextBox.Name = "SerialTextBox"
        Me.SerialTextBox.Size = New System.Drawing.Size(508, 31)
        Me.SerialTextBox.TabIndex = 1
        '
        'CERT
        '
        Me.CERT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CERT.HeaderText = "Примечание"
        Me.CERT.Name = "CERT"
        Me.CERT.ReadOnly = True
        Me.CERT.Width = 139
        '
        'CASIDTab
        '
        Me.CASIDTab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CASIDTab.HeaderText = "Дата"
        Me.CASIDTab.Name = "CASIDTab"
        Me.CASIDTab.ReadOnly = True
        Me.CASIDTab.Width = 77
        '
        'SCIDTab
        '
        Me.SCIDTab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SCIDTab.HeaderText = "Результат"
        Me.SCIDTab.Name = "SCIDTab"
        Me.SCIDTab.ReadOnly = True
        Me.SCIDTab.Width = 123
        '
        'SNumber
        '
        Me.SNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SNumber.HeaderText = "Серийный номер"
        Me.SNumber.Name = "SNumber"
        Me.SNumber.ReadOnly = True
        Me.SNumber.Width = 159
        '
        'Num
        '
        Me.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Num.HeaderText = "№"
        Me.Num.Name = "Num"
        Me.Num.ReadOnly = True
        Me.Num.Width = 50
        '
        'BT_Pause
        '
        Me.BT_Pause.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BT_Pause.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BT_Pause.Location = New System.Drawing.Point(25, 114)
        Me.BT_Pause.Name = "BT_Pause"
        Me.BT_Pause.Size = New System.Drawing.Size(18, 23)
        Me.BT_Pause.TabIndex = 29
        Me.BT_Pause.Text = "P"
        Me.BT_Pause.UseVisualStyleBackColor = False
        '
        'DG_UpLog
        '
        Me.DG_UpLog.AllowUserToAddRows = False
        Me.DG_UpLog.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DG_UpLog.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.DG_UpLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_UpLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_UpLog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DG_UpLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_UpLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Num, Me.SNumber, Me.SCIDTab, Me.CASIDTab, Me.HDCP, Me.CERT})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_UpLog.DefaultCellStyle = DataGridViewCellStyle13
        Me.DG_UpLog.Location = New System.Drawing.Point(19, 109)
        Me.DG_UpLog.Name = "DG_UpLog"
        Me.DG_UpLog.ReadOnly = True
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_UpLog.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DG_UpLog.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.DG_UpLog.Size = New System.Drawing.Size(1268, 283)
        Me.DG_UpLog.TabIndex = 25
        '
        'HDCP
        '
        Me.HDCP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HDCP.HeaderText = "Код ошибки"
        Me.HDCP.Name = "HDCP"
        Me.HDCP.ReadOnly = True
        Me.HDCP.Width = 123
        '
        'CurrrentTimeLabel
        '
        Me.CurrrentTimeLabel.AutoSize = True
        Me.CurrrentTimeLabel.BackColor = System.Drawing.SystemColors.Control
        Me.CurrrentTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CurrrentTimeLabel.Location = New System.Drawing.Point(25, 18)
        Me.CurrrentTimeLabel.Name = "CurrrentTimeLabel"
        Me.CurrrentTimeLabel.Size = New System.Drawing.Size(156, 29)
        Me.CurrrentTimeLabel.TabIndex = 6
        Me.CurrrentTimeLabel.Text = "Current TIME"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.CurrrentTimeLabel)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox5.Location = New System.Drawing.Point(928, 44)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(219, 55)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Время"
        '
        'Timer_Calibration
        '
        Me.Timer_Calibration.Interval = 60000
        '
        'GB_UserData
        '
        Me.GB_UserData.BackColor = System.Drawing.Color.NavajoWhite
        Me.GB_UserData.Controls.Add(Me.BT_LOGInClose)
        Me.GB_UserData.Controls.Add(Me.Label13)
        Me.GB_UserData.Controls.Add(Me.TB_RFIDIn)
        Me.GB_UserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_UserData.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GB_UserData.Location = New System.Drawing.Point(1512, 23)
        Me.GB_UserData.Name = "GB_UserData"
        Me.GB_UserData.Size = New System.Drawing.Size(449, 197)
        Me.GB_UserData.TabIndex = 45
        Me.GB_UserData.TabStop = False
        Me.GB_UserData.Text = "Регистрация пользователя"
        '
        'BT_LOGInClose
        '
        Me.BT_LOGInClose.BackColor = System.Drawing.Color.Transparent
        Me.BT_LOGInClose.FlatAppearance.BorderSize = 0
        Me.BT_LOGInClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LOGInClose.ForeColor = System.Drawing.Color.Transparent
        Me.BT_LOGInClose.Location = New System.Drawing.Point(362, 74)
        Me.BT_LOGInClose.Name = "BT_LOGInClose"
        Me.BT_LOGInClose.Size = New System.Drawing.Size(53, 59)
        Me.BT_LOGInClose.TabIndex = 2
        Me.BT_LOGInClose.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(321, 25)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Отсканируйте свой бэйджик"
        '
        'TB_RFIDIn
        '
        Me.TB_RFIDIn.Location = New System.Drawing.Point(11, 88)
        Me.TB_RFIDIn.Name = "TB_RFIDIn"
        Me.TB_RFIDIn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_RFIDIn.Size = New System.Drawing.Size(345, 31)
        Me.TB_RFIDIn.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(399, 107)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(111, 13)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "DG_THTStartFromDB"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(399, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(106, 13)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "DG_PCBInfoFromDB"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(230, 107)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 13)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "DG_StepList "
        '
        'DG_THTStartFromDB
        '
        Me.DG_THTStartFromDB.AllowUserToAddRows = False
        Me.DG_THTStartFromDB.AllowUserToDeleteRows = False
        Me.DG_THTStartFromDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_THTStartFromDB.Location = New System.Drawing.Point(402, 126)
        Me.DG_THTStartFromDB.Name = "DG_THTStartFromDB"
        Me.DG_THTStartFromDB.ReadOnly = True
        Me.DG_THTStartFromDB.Size = New System.Drawing.Size(158, 53)
        Me.DG_THTStartFromDB.TabIndex = 32
        '
        'DG_PCBInfoFromDB
        '
        Me.DG_PCBInfoFromDB.AllowUserToAddRows = False
        Me.DG_PCBInfoFromDB.AllowUserToDeleteRows = False
        Me.DG_PCBInfoFromDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_PCBInfoFromDB.Location = New System.Drawing.Point(402, 42)
        Me.DG_PCBInfoFromDB.Name = "DG_PCBInfoFromDB"
        Me.DG_PCBInfoFromDB.ReadOnly = True
        Me.DG_PCBInfoFromDB.Size = New System.Drawing.Size(158, 53)
        Me.DG_PCBInfoFromDB.TabIndex = 32
        '
        'DG_THT_Start
        '
        Me.DG_THT_Start.AllowUserToAddRows = False
        Me.DG_THT_Start.AllowUserToDeleteRows = False
        Me.DG_THT_Start.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_THT_Start.Location = New System.Drawing.Point(26, 125)
        Me.DG_THT_Start.Name = "DG_THT_Start"
        Me.DG_THT_Start.ReadOnly = True
        Me.DG_THT_Start.Size = New System.Drawing.Size(159, 57)
        Me.DG_THT_Start.TabIndex = 32
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.DG_THTStartFromDB)
        Me.GroupBox2.Controls.Add(Me.DG_PCBInfoFromDB)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.DG_THT_Start)
        Me.GroupBox2.Controls.Add(Me.DG_StepList)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(1534, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(605, 188)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        Me.GroupBox2.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(23, 107)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 13)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "DG_THT START"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(230, 20)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox2.Size = New System.Drawing.Size(154, 75)
        Me.TextBox2.TabIndex = 31
        '
        'DG_StepList
        '
        Me.DG_StepList.AllowUserToAddRows = False
        Me.DG_StepList.AllowUserToDeleteRows = False
        Me.DG_StepList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_StepList.Location = New System.Drawing.Point(230, 123)
        Me.DG_StepList.Name = "DG_StepList"
        Me.DG_StepList.ReadOnly = True
        Me.DG_StepList.Size = New System.Drawing.Size(159, 57)
        Me.DG_StepList.TabIndex = 32
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(26, 20)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(180, 34)
        Me.TextBox1.TabIndex = 31
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(26, 59)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox3.Size = New System.Drawing.Size(179, 36)
        Me.TextBox3.TabIndex = 31
        '
        'CurrentTimeTimer
        '
        Me.CurrentTimeTimer.Interval = 1000
        '
        'Column3
        '
        Me.Column3.HeaderText = "Пользователь"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 140
        '
        'L_UserName
        '
        Me.L_UserName.AutoSize = True
        Me.L_UserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_UserName.Location = New System.Drawing.Point(208, 76)
        Me.L_UserName.Name = "L_UserName"
        Me.L_UserName.Size = New System.Drawing.Size(174, 20)
        Me.L_UserName.TabIndex = 19
        Me.L_UserName.Text = "Имя пользователя:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Название приложения:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(19, 99)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(155, 31)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Тест FAIL:"
        Me.Label15.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(16, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(158, 31)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Тест Pass:"
        Me.Label14.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label17.Location = New System.Drawing.Point(458, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(187, 31)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Yield по лоту"
        Me.Label17.Visible = False
        '
        'LB_Procent
        '
        Me.LB_Procent.AutoSize = True
        Me.LB_Procent.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LB_Procent.Location = New System.Drawing.Point(610, 61)
        Me.LB_Procent.Name = "LB_Procent"
        Me.LB_Procent.Size = New System.Drawing.Size(68, 55)
        Me.LB_Procent.TabIndex = 0
        Me.LB_Procent.Text = "%"
        Me.LB_Procent.Visible = False
        '
        'LB_Yield
        '
        Me.LB_Yield.AutoSize = True
        Me.LB_Yield.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LB_Yield.Location = New System.Drawing.Point(440, 61)
        Me.LB_Yield.Name = "LB_Yield"
        Me.LB_Yield.Size = New System.Drawing.Size(178, 55)
        Me.LB_Yield.TabIndex = 0
        Me.LB_Yield.Text = "100,00"
        Me.LB_Yield.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(147, 31)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "За смену:"
        '
        'LabelAppName
        '
        Me.LabelAppName.AutoSize = True
        Me.LabelAppName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelAppName.Location = New System.Drawing.Point(208, 36)
        Me.LabelAppName.Name = "LabelAppName"
        Me.LabelAppName.Size = New System.Drawing.Size(64, 20)
        Me.LabelAppName.TabIndex = 20
        Me.LabelAppName.Text = "fasend"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Линия"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 78
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LB_SW_Wers)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.LB_CurrentStep)
        Me.GroupBox4.Controls.Add(Me.LabelAppName)
        Me.GroupBox4.Controls.Add(Me.L_UserName)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label_StationName)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.L_Model)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.L_LOT)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Lebel_StationLine)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(17, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(496, 185)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Информация о ЛОТе и станции"
        '
        'LB_CurrentStep
        '
        Me.LB_CurrentStep.AutoSize = True
        Me.LB_CurrentStep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LB_CurrentStep.Location = New System.Drawing.Point(208, 56)
        Me.LB_CurrentStep.Name = "LB_CurrentStep"
        Me.LB_CurrentStep.Size = New System.Drawing.Size(64, 20)
        Me.LB_CurrentStep.TabIndex = 20
        Me.LB_CurrentStep.Text = "fasend"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Название операции:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Имя пользователя:"
        '
        'Label_StationName
        '
        Me.Label_StationName.AutoSize = True
        Me.Label_StationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_StationName.Location = New System.Drawing.Point(208, 96)
        Me.Label_StationName.Name = "Label_StationName"
        Me.Label_StationName.Size = New System.Drawing.Size(33, 20)
        Me.Label_StationName.TabIndex = 16
        Me.Label_StationName.Text = "ПК"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(83, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Название ПК:"
        '
        'L_Model
        '
        Me.L_Model.AutoSize = True
        Me.L_Model.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_Model.Location = New System.Drawing.Point(208, 156)
        Me.L_Model.Name = "L_Model"
        Me.L_Model.Size = New System.Drawing.Size(57, 20)
        Me.L_Model.TabIndex = 16
        Me.L_Model.Text = "Model"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.Location = New System.Drawing.Point(127, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 20)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Модель:"
        '
        'L_LOT
        '
        Me.L_LOT.AutoSize = True
        Me.L_LOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_LOT.Location = New System.Drawing.Point(208, 136)
        Me.L_LOT.Name = "L_LOT"
        Me.L_LOT.Size = New System.Drawing.Size(42, 20)
        Me.L_LOT.TabIndex = 16
        Me.L_LOT.Text = "LOT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.Location = New System.Drawing.Point(61, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Название ЛОТа:"
        '
        'Lebel_StationLine
        '
        Me.Lebel_StationLine.AutoSize = True
        Me.Lebel_StationLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lebel_StationLine.Location = New System.Drawing.Point(208, 116)
        Me.Lebel_StationLine.Name = "Lebel_StationLine"
        Me.Lebel_StationLine.Size = New System.Drawing.Size(43, 20)
        Me.Lebel_StationLine.TabIndex = 16
        Me.Lebel_StationLine.Text = "Line"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Линия:"
        '
        'Label_ShiftCounter
        '
        Me.Label_ShiftCounter.AutoSize = True
        Me.Label_ShiftCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_ShiftCounter.Location = New System.Drawing.Point(180, 19)
        Me.Label_ShiftCounter.Name = "Label_ShiftCounter"
        Me.Label_ShiftCounter.Size = New System.Drawing.Size(46, 31)
        Me.Label_ShiftCounter.TabIndex = 0
        Me.Label_ShiftCounter.Text = "99"
        '
        'LB_FailLotRes
        '
        Me.LB_FailLotRes.AutoSize = True
        Me.LB_FailLotRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LB_FailLotRes.ForeColor = System.Drawing.Color.Red
        Me.LB_FailLotRes.Location = New System.Drawing.Point(180, 99)
        Me.LB_FailLotRes.Name = "LB_FailLotRes"
        Me.LB_FailLotRes.Size = New System.Drawing.Size(46, 31)
        Me.LB_FailLotRes.TabIndex = 0
        Me.LB_FailLotRes.Text = "99"
        Me.LB_FailLotRes.Visible = False
        '
        'LB_PassLotRes
        '
        Me.LB_PassLotRes.AutoSize = True
        Me.LB_PassLotRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LB_PassLotRes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LB_PassLotRes.Location = New System.Drawing.Point(180, 59)
        Me.LB_PassLotRes.Name = "LB_PassLotRes"
        Me.LB_PassLotRes.Size = New System.Drawing.Size(46, 31)
        Me.LB_PassLotRes.TabIndex = 0
        Me.LB_PassLotRes.Text = "99"
        Me.LB_PassLotRes.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.LB_Procent)
        Me.GroupBox1.Controls.Add(Me.LB_Yield)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label_ShiftCounter)
        Me.GroupBox1.Controls.Add(Me.LB_FailLotRes)
        Me.GroupBox1.Controls.Add(Me.LB_PassLotRes)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(533, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(706, 178)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Счетчик выпуска продукции"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.HeaderText = "Примечание"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 126
        '
        'Column4
        '
        Me.Column4.HeaderText = "Описание ошибки"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.HeaderText = "Код ошибки"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 108
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "Результат"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 112
        '
        'Column1
        '
        Me.Column1.HeaderText = "Название станции"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 157
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Серийный номер"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 143
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "№"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 48
        '
        'DG_PCB_Steps
        '
        Me.DG_PCB_Steps.AllowUserToAddRows = False
        Me.DG_PCB_Steps.AllowUserToDeleteRows = False
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DG_PCB_Steps.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DG_PCB_Steps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_PCB_Steps.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_PCB_Steps.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.DG_PCB_Steps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_PCB_Steps.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.Column4, Me.DataGridViewTextBoxColumn6, Me.Column2, Me.Column3, Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_PCB_Steps.DefaultCellStyle = DataGridViewCellStyle18
        Me.DG_PCB_Steps.Location = New System.Drawing.Point(14, 109)
        Me.DG_PCB_Steps.Name = "DG_PCB_Steps"
        Me.DG_PCB_Steps.ReadOnly = True
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_PCB_Steps.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DG_PCB_Steps.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.DG_PCB_Steps.Size = New System.Drawing.Size(1273, 276)
        Me.DG_PCB_Steps.TabIndex = 26
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "Дата"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 69
        '
        'BT_CleareSN
        '
        Me.BT_CleareSN.FlatAppearance.BorderSize = 0
        Me.BT_CleareSN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CleareSN.Image = CType(resources.GetObject("BT_CleareSN.Image"), System.Drawing.Image)
        Me.BT_CleareSN.Location = New System.Drawing.Point(703, 15)
        Me.BT_CleareSN.Name = "BT_CleareSN"
        Me.BT_CleareSN.Size = New System.Drawing.Size(66, 94)
        Me.BT_CleareSN.TabIndex = 28
        Me.BT_CleareSN.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(186, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(367, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Строка ввода серийного номера"
        '
        'GB_PCBInfoMode
        '
        Me.GB_PCBInfoMode.Controls.Add(Me.DG_PCB_Steps)
        Me.GB_PCBInfoMode.Controls.Add(Me.TB_GetPCPInfo)
        Me.GB_PCBInfoMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GB_PCBInfoMode.Location = New System.Drawing.Point(1490, 720)
        Me.GB_PCBInfoMode.Name = "GB_PCBInfoMode"
        Me.GB_PCBInfoMode.Size = New System.Drawing.Size(1301, 394)
        Me.GB_PCBInfoMode.TabIndex = 32
        Me.GB_PCBInfoMode.TabStop = False
        Me.GB_PCBInfoMode.Visible = False
        '
        'BT_PCBInfo
        '
        Me.BT_PCBInfo.FlatAppearance.BorderSize = 0
        Me.BT_PCBInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_PCBInfo.Location = New System.Drawing.Point(1245, 10)
        Me.BT_PCBInfo.Name = "BT_PCBInfo"
        Me.BT_PCBInfo.Size = New System.Drawing.Size(75, 68)
        Me.BT_PCBInfo.TabIndex = 31
        Me.BT_PCBInfo.UseVisualStyleBackColor = True
        '
        'BT_OpenSettings
        '
        Me.BT_OpenSettings.FlatAppearance.BorderSize = 0
        Me.BT_OpenSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_OpenSettings.Image = Global.IP_TV.My.Resources.Resources.package_utilities
        Me.BT_OpenSettings.Location = New System.Drawing.Point(1231, 228)
        Me.BT_OpenSettings.Name = "BT_OpenSettings"
        Me.BT_OpenSettings.Size = New System.Drawing.Size(82, 81)
        Me.BT_OpenSettings.TabIndex = 22
        Me.BT_OpenSettings.UseVisualStyleBackColor = True
        '
        'Controllabel
        '
        Me.Controllabel.AutoSize = True
        Me.Controllabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Controllabel.Location = New System.Drawing.Point(12, 193)
        Me.Controllabel.Name = "Controllabel"
        Me.Controllabel.Size = New System.Drawing.Size(217, 29)
        Me.Controllabel.TabIndex = 21
        Me.Controllabel.Text = "CONTROLLABEL"
        '
        'GB_ScanMode
        '
        Me.GB_ScanMode.Controls.Add(Me.BT_CleareSN)
        Me.GB_ScanMode.Controls.Add(Me.Label2)
        Me.GB_ScanMode.Controls.Add(Me.GroupBox5)
        Me.GB_ScanMode.Controls.Add(Me.BT_Pause)
        Me.GB_ScanMode.Controls.Add(Me.DG_UpLog)
        Me.GB_ScanMode.Controls.Add(Me.BT_Pass)
        Me.GB_ScanMode.Controls.Add(Me.BT_Fail)
        Me.GB_ScanMode.Controls.Add(Me.SerialTextBox)
        Me.GB_ScanMode.Location = New System.Drawing.Point(6, 311)
        Me.GB_ScanMode.Name = "GB_ScanMode"
        Me.GB_ScanMode.Size = New System.Drawing.Size(1301, 398)
        Me.GB_ScanMode.TabIndex = 30
        Me.GB_ScanMode.TabStop = False
        '
        'GB_WorkAria
        '
        Me.GB_WorkAria.Controls.Add(Me.GroupBox1)
        Me.GB_WorkAria.Controls.Add(Me.BT_PCBInfo)
        Me.GB_WorkAria.Controls.Add(Me.BT_OpenSettings)
        Me.GB_WorkAria.Controls.Add(Me.GroupBox4)
        Me.GB_WorkAria.Controls.Add(Me.Controllabel)
        Me.GB_WorkAria.Controls.Add(Me.GB_ScanMode)
        Me.GB_WorkAria.Location = New System.Drawing.Point(8, 11)
        Me.GB_WorkAria.Name = "GB_WorkAria"
        Me.GB_WorkAria.Size = New System.Drawing.Size(1326, 715)
        Me.GB_WorkAria.TabIndex = 44
        Me.GB_WorkAria.TabStop = False
        Me.GB_WorkAria.Visible = False
        '
        'FASErrorCodeBindingSource
        '
        Me.FASErrorCodeBindingSource.DataMember = "FAS_ErrorCode"
        '
        'LB_SW_Wers
        '
        Me.LB_SW_Wers.AutoSize = True
        Me.LB_SW_Wers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LB_SW_Wers.Location = New System.Drawing.Point(209, 18)
        Me.LB_SW_Wers.Name = "LB_SW_Wers"
        Me.LB_SW_Wers.Size = New System.Drawing.Size(76, 16)
        Me.LB_SW_Wers.TabIndex = 22
        Me.LB_SW_Wers.Text = "SW_Wers"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.Location = New System.Drawing.Point(49, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(159, 16)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Версия приложения:"
        '
        'Quarantine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1041)
        Me.Controls.Add(Me.GB_ErrorCode)
        Me.Controls.Add(Me.GB_UserData)
        Me.Controls.Add(Me.GB_PCBInfoMode)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GB_WorkAria)
        Me.Name = "Quarantine"
        Me.Text = "Quarantine"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DG_ErrorCodes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_ErrorCode.ResumeLayout(False)
        Me.GB_ErrorCode.PerformLayout()
        CType(Me.DG_UpLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GB_UserData.ResumeLayout(False)
        Me.GB_UserData.PerformLayout()
        CType(Me.DG_THTStartFromDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_PCBInfoFromDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_THT_Start, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DG_StepList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_PCB_Steps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_PCBInfoMode.ResumeLayout(False)
        Me.GB_PCBInfoMode.PerformLayout()
        Me.GB_ScanMode.ResumeLayout(False)
        Me.GB_ScanMode.PerformLayout()
        Me.GB_WorkAria.ResumeLayout(False)
        Me.GB_WorkAria.PerformLayout()
        CType(Me.FASErrorCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TB_GetPCPInfo As TextBox
    Friend WithEvents BT_CloseErrMode As Button
    Friend WithEvents DG_ErrorCodes As DataGridView
    Friend WithEvents BT_SeveErCode As Button
    Friend WithEvents TB_Description As TextBox
    Public WithEvents GB_ErrorCode As GroupBox
    Friend WithEvents CB_ErrorCode As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BT_Pass As Button
    Friend WithEvents BT_Fail As Button
    Friend WithEvents SerialTextBox As TextBox
    Friend WithEvents CERT As DataGridViewTextBoxColumn
    Friend WithEvents CASIDTab As DataGridViewTextBoxColumn
    Friend WithEvents SCIDTab As DataGridViewTextBoxColumn
    Friend WithEvents SNumber As DataGridViewTextBoxColumn
    Friend WithEvents Num As DataGridViewTextBoxColumn
    Friend WithEvents BT_Pause As Button
    Friend WithEvents DG_UpLog As DataGridView
    Friend WithEvents HDCP As DataGridViewTextBoxColumn
    Friend WithEvents CurrrentTimeLabel As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Timer_Calibration As Timer
    Friend WithEvents GB_UserData As GroupBox
    Friend WithEvents BT_LOGInClose As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents TB_RFIDIn As TextBox
    Friend WithEvents FASErrorCodeBindingSource As BindingSource
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DG_THTStartFromDB As DataGridView
    Friend WithEvents DG_PCBInfoFromDB As DataGridView
    Friend WithEvents DG_THT_Start As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DG_StepList As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents CurrentTimeTimer As Timer
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents L_UserName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents LB_Procent As Label
    Friend WithEvents LB_Yield As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LabelAppName As Label
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LB_CurrentStep As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label_StationName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents L_Model As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents L_LOT As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Lebel_StationLine As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_ShiftCounter As Label
    Friend WithEvents LB_FailLotRes As Label
    Friend WithEvents LB_PassLotRes As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DG_PCB_Steps As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents BT_CleareSN As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GB_PCBInfoMode As GroupBox
    Friend WithEvents BT_PCBInfo As Button
    Friend WithEvents BT_OpenSettings As Button
    Friend WithEvents Controllabel As Label
    Friend WithEvents GB_ScanMode As GroupBox
    Friend WithEvents GB_WorkAria As GroupBox
    Friend WithEvents LB_SW_Wers As Label
    Friend WithEvents Label12 As Label
End Class
