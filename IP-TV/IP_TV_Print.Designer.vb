<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IP_TV_Print
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TB_GetPCPInfo = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DG_PCB_Steps = New System.Windows.Forms.DataGridView()
        Me.GB_PCBInfoMode = New System.Windows.Forms.GroupBox()
        Me.DG_THT_Start = New System.Windows.Forms.DataGridView()
        Me.PrintSerialPort3 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PrintSerialPort6 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DG_THTStartFromDB = New System.Windows.Forms.DataGridView()
        Me.DG_PCBInfoFromDB = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DG_StepList = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BT_CloseErrMode = New System.Windows.Forms.Button()
        Me.BT_SeveErCode = New System.Windows.Forms.Button()
        Me.GB_ErrorCode = New System.Windows.Forms.GroupBox()
        Me.DG_ErrorCodes = New System.Windows.Forms.DataGridView()
        Me.TB_Description = New System.Windows.Forms.TextBox()
        Me.CB_ErrorCode = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CurrentTimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CB_SelectLabel = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label_ShiftCounter = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CurrrentTimeLabel = New System.Windows.Forms.Label()
        Me.GB_UserData = New System.Windows.Forms.GroupBox()
        Me.BT_LOGInClose = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TB_RFIDIn = New System.Windows.Forms.TextBox()
        Me.CB_PrinterSettings = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LB_LOTCounter = New System.Windows.Forms.Label()
        Me.GB_WorkAria = New System.Windows.Forms.GroupBox()
        Me.BT_PCBInfo = New System.Windows.Forms.Button()
        Me.BT_OpenSettings = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LB_CurrentStep = New System.Windows.Forms.Label()
        Me.LB_SW_Wers = New System.Windows.Forms.Label()
        Me.LabelAppName = New System.Windows.Forms.Label()
        Me.L_UserName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label_StationName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.L_Model = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.L_LOT = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Lebel_StationLine = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Controllabel = New System.Windows.Forms.Label()
        Me.GB_ScanMode = New System.Windows.Forms.GroupBox()
        Me.GB_Printers = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CB_LabScenario = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Num_X = New System.Windows.Forms.NumericUpDown()
        Me.BT_Save_Coordinats = New System.Windows.Forms.Button()
        Me.Num_Y = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.CB_DefaultPrinter = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BT_CleareSN = New System.Windows.Forms.Button()
        Me.BT_Pause = New System.Windows.Forms.Button()
        Me.DG_UpLog = New System.Windows.Forms.DataGridView()
        Me.Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CASIDTab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerialTextBox = New System.Windows.Forms.TextBox()
        Me.FASErrorCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DG_PCB_Steps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_PCBInfoMode.SuspendLayout()
        CType(Me.DG_THT_Start, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_THTStartFromDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_PCBInfoFromDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_StepList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_ErrorCode.SuspendLayout()
        CType(Me.DG_ErrorCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GB_UserData.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GB_WorkAria.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GB_ScanMode.SuspendLayout()
        Me.GB_Printers.SuspendLayout()
        CType(Me.Num_X, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_Y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_UpLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FASErrorCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'TB_GetPCPInfo
        '
        Me.TB_GetPCPInfo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_GetPCPInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TB_GetPCPInfo.Location = New System.Drawing.Point(14, 43)
        Me.TB_GetPCPInfo.Name = "TB_GetPCPInfo"
        Me.TB_GetPCPInfo.Size = New System.Drawing.Size(508, 31)
        Me.TB_GetPCPInfo.TabIndex = 1
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "Дата"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 69
        '
        'Column3
        '
        Me.Column3.HeaderText = "Пользователь"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 140
        '
        'Column2
        '
        Me.Column2.HeaderText = "Линия"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 78
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
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DG_PCB_Steps.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DG_PCB_Steps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_PCB_Steps.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_PCB_Steps.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DG_PCB_Steps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_PCB_Steps.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column1, Me.DataGridViewTextBoxColumn3, Me.Column4, Me.DataGridViewTextBoxColumn6, Me.Column2, Me.Column3, Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_PCB_Steps.DefaultCellStyle = DataGridViewCellStyle11
        Me.DG_PCB_Steps.Location = New System.Drawing.Point(14, 109)
        Me.DG_PCB_Steps.Name = "DG_PCB_Steps"
        Me.DG_PCB_Steps.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_PCB_Steps.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DG_PCB_Steps.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DG_PCB_Steps.Size = New System.Drawing.Size(723, 276)
        Me.DG_PCB_Steps.TabIndex = 26
        '
        'GB_PCBInfoMode
        '
        Me.GB_PCBInfoMode.Controls.Add(Me.DG_PCB_Steps)
        Me.GB_PCBInfoMode.Controls.Add(Me.TB_GetPCPInfo)
        Me.GB_PCBInfoMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GB_PCBInfoMode.Location = New System.Drawing.Point(1160, 434)
        Me.GB_PCBInfoMode.Name = "GB_PCBInfoMode"
        Me.GB_PCBInfoMode.Size = New System.Drawing.Size(743, 394)
        Me.GB_PCBInfoMode.TabIndex = 47
        Me.GB_PCBInfoMode.TabStop = False
        Me.GB_PCBInfoMode.Visible = False
        '
        'DG_THT_Start
        '
        Me.DG_THT_Start.AllowUserToAddRows = False
        Me.DG_THT_Start.AllowUserToDeleteRows = False
        Me.DG_THT_Start.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_THT_Start.Location = New System.Drawing.Point(26, 122)
        Me.DG_THT_Start.Name = "DG_THT_Start"
        Me.DG_THT_Start.ReadOnly = True
        Me.DG_THT_Start.Size = New System.Drawing.Size(159, 50)
        Me.DG_THT_Start.TabIndex = 34
        '
        'PrintSerialPort3
        '
        Me.PrintSerialPort3.BaudRate = 115200
        Me.PrintSerialPort3.PortName = "COM3"
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
        'PrintSerialPort6
        '
        Me.PrintSerialPort6.BaudRate = 115200
        Me.PrintSerialPort6.PortName = "COM6"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DG_THT_Start)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.DG_THTStartFromDB)
        Me.GroupBox2.Controls.Add(Me.DG_PCBInfoFromDB)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.DG_StepList)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(1160, 214)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(605, 188)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        Me.GroupBox2.Visible = False
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
        Me.TextBox1.Size = New System.Drawing.Size(180, 38)
        Me.TextBox1.TabIndex = 31
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(26, 64)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox3.Size = New System.Drawing.Size(179, 43)
        Me.TextBox3.TabIndex = 31
        '
        'BT_CloseErrMode
        '
        Me.BT_CloseErrMode.FlatAppearance.BorderSize = 0
        Me.BT_CloseErrMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CloseErrMode.Location = New System.Drawing.Point(536, 19)
        Me.BT_CloseErrMode.Name = "BT_CloseErrMode"
        Me.BT_CloseErrMode.Size = New System.Drawing.Size(53, 55)
        Me.BT_CloseErrMode.TabIndex = 35
        Me.BT_CloseErrMode.UseVisualStyleBackColor = True
        '
        'BT_SeveErCode
        '
        Me.BT_SeveErCode.FlatAppearance.BorderSize = 0
        Me.BT_SeveErCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SeveErCode.Location = New System.Drawing.Point(517, 250)
        Me.BT_SeveErCode.Name = "BT_SeveErCode"
        Me.BT_SeveErCode.Size = New System.Drawing.Size(72, 79)
        Me.BT_SeveErCode.TabIndex = 3
        Me.BT_SeveErCode.UseVisualStyleBackColor = True
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
        Me.GB_ErrorCode.Location = New System.Drawing.Point(1726, 40)
        Me.GB_ErrorCode.Name = "GB_ErrorCode"
        Me.GB_ErrorCode.Size = New System.Drawing.Size(595, 335)
        Me.GB_ErrorCode.TabIndex = 50
        Me.GB_ErrorCode.TabStop = False
        Me.GB_ErrorCode.Text = "Регистрация кода ошибки"
        Me.GB_ErrorCode.Visible = False
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
        'TB_Description
        '
        Me.TB_Description.Location = New System.Drawing.Point(10, 177)
        Me.TB_Description.Multiline = True
        Me.TB_Description.Name = "TB_Description"
        Me.TB_Description.Size = New System.Drawing.Size(495, 140)
        Me.TB_Description.TabIndex = 2
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
        'CurrentTimeTimer
        '
        Me.CurrentTimeTimer.Interval = 1000
        '
        'CB_SelectLabel
        '
        Me.CB_SelectLabel.FormattingEnabled = True
        Me.CB_SelectLabel.Items.AddRange(New Object() {"Этикетки 45х8 и 39х19", "Этикетка 44х21_Rus"})
        Me.CB_SelectLabel.Location = New System.Drawing.Point(752, 6)
        Me.CB_SelectLabel.Name = "CB_SelectLabel"
        Me.CB_SelectLabel.Size = New System.Drawing.Size(260, 21)
        Me.CB_SelectLabel.TabIndex = 30
        Me.CB_SelectLabel.Text = "Этикетки 45х8 и 39х19"
        Me.CB_SelectLabel.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.Location = New System.Drawing.Point(28, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(176, 24)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "За день по лоту:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.Location = New System.Drawing.Point(41, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 24)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "За день общее:"
        '
        'Label_ShiftCounter
        '
        Me.Label_ShiftCounter.AutoSize = True
        Me.Label_ShiftCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_ShiftCounter.Location = New System.Drawing.Point(202, 19)
        Me.Label_ShiftCounter.Name = "Label_ShiftCounter"
        Me.Label_ShiftCounter.Size = New System.Drawing.Size(32, 24)
        Me.Label_ShiftCounter.TabIndex = 0
        Me.Label_ShiftCounter.Text = "99"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.CurrrentTimeLabel)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox5.Location = New System.Drawing.Point(17, 88)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(219, 55)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Время"
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
        'GB_UserData
        '
        Me.GB_UserData.BackColor = System.Drawing.Color.NavajoWhite
        Me.GB_UserData.Controls.Add(Me.BT_LOGInClose)
        Me.GB_UserData.Controls.Add(Me.Label13)
        Me.GB_UserData.Controls.Add(Me.TB_RFIDIn)
        Me.GB_UserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB_UserData.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GB_UserData.Location = New System.Drawing.Point(1138, 12)
        Me.GB_UserData.Name = "GB_UserData"
        Me.GB_UserData.Size = New System.Drawing.Size(449, 197)
        Me.GB_UserData.TabIndex = 49
        Me.GB_UserData.TabStop = False
        Me.GB_UserData.Text = "Регистрация пользователя"
        '
        'BT_LOGInClose
        '
        Me.BT_LOGInClose.BackColor = System.Drawing.Color.Transparent
        Me.BT_LOGInClose.FlatAppearance.BorderSize = 0
        Me.BT_LOGInClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LOGInClose.ForeColor = System.Drawing.Color.Transparent
        Me.BT_LOGInClose.Image = Global.IP_TV.My.Resources.Resources.close
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
        Me.TB_RFIDIn.Text = "0000181218"
        '
        'CB_PrinterSettings
        '
        Me.CB_PrinterSettings.AutoSize = True
        Me.CB_PrinterSettings.Checked = True
        Me.CB_PrinterSettings.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CB_PrinterSettings.Location = New System.Drawing.Point(783, 193)
        Me.CB_PrinterSettings.Name = "CB_PrinterSettings"
        Me.CB_PrinterSettings.Size = New System.Drawing.Size(137, 17)
        Me.CB_PrinterSettings.TabIndex = 33
        Me.CB_PrinterSettings.Text = "Настройка принтеров"
        Me.CB_PrinterSettings.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label_ShiftCounter)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.LB_LOTCounter)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(650, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 159)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Счетчик выпуска продукции"
        '
        'LB_LOTCounter
        '
        Me.LB_LOTCounter.AutoSize = True
        Me.LB_LOTCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LB_LOTCounter.Location = New System.Drawing.Point(202, 50)
        Me.LB_LOTCounter.Name = "LB_LOTCounter"
        Me.LB_LOTCounter.Size = New System.Drawing.Size(32, 24)
        Me.LB_LOTCounter.TabIndex = 0
        Me.LB_LOTCounter.Text = "99"
        '
        'GB_WorkAria
        '
        Me.GB_WorkAria.Controls.Add(Me.CB_PrinterSettings)
        Me.GB_WorkAria.Controls.Add(Me.GroupBox1)
        Me.GB_WorkAria.Controls.Add(Me.BT_PCBInfo)
        Me.GB_WorkAria.Controls.Add(Me.BT_OpenSettings)
        Me.GB_WorkAria.Controls.Add(Me.GroupBox4)
        Me.GB_WorkAria.Controls.Add(Me.Controllabel)
        Me.GB_WorkAria.Controls.Add(Me.GB_ScanMode)
        Me.GB_WorkAria.Location = New System.Drawing.Point(6, 9)
        Me.GB_WorkAria.Name = "GB_WorkAria"
        Me.GB_WorkAria.Size = New System.Drawing.Size(1040, 715)
        Me.GB_WorkAria.TabIndex = 48
        Me.GB_WorkAria.TabStop = False
        Me.GB_WorkAria.Visible = False
        '
        'BT_PCBInfo
        '
        Me.BT_PCBInfo.FlatAppearance.BorderSize = 0
        Me.BT_PCBInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_PCBInfo.Image = Global.IP_TV.My.Resources.Resources.Symbol_Information
        Me.BT_PCBInfo.Location = New System.Drawing.Point(952, 18)
        Me.BT_PCBInfo.Name = "BT_PCBInfo"
        Me.BT_PCBInfo.Size = New System.Drawing.Size(75, 68)
        Me.BT_PCBInfo.TabIndex = 31
        Me.BT_PCBInfo.UseVisualStyleBackColor = True
        Me.BT_PCBInfo.Visible = False
        '
        'BT_OpenSettings
        '
        Me.BT_OpenSettings.FlatAppearance.BorderSize = 0
        Me.BT_OpenSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_OpenSettings.Image = Global.IP_TV.My.Resources.Resources.package_utilities
        Me.BT_OpenSettings.Location = New System.Drawing.Point(952, 97)
        Me.BT_OpenSettings.Name = "BT_OpenSettings"
        Me.BT_OpenSettings.Size = New System.Drawing.Size(82, 81)
        Me.BT_OpenSettings.TabIndex = 22
        Me.BT_OpenSettings.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LB_CurrentStep)
        Me.GroupBox4.Controls.Add(Me.LB_SW_Wers)
        Me.GroupBox4.Controls.Add(Me.LabelAppName)
        Me.GroupBox4.Controls.Add(Me.L_UserName)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label15)
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
        Me.GroupBox4.Size = New System.Drawing.Size(472, 178)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Информация о ЛОТе и станции"
        '
        'LB_CurrentStep
        '
        Me.LB_CurrentStep.AutoSize = True
        Me.LB_CurrentStep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LB_CurrentStep.Location = New System.Drawing.Point(187, 64)
        Me.LB_CurrentStep.Name = "LB_CurrentStep"
        Me.LB_CurrentStep.Size = New System.Drawing.Size(55, 16)
        Me.LB_CurrentStep.TabIndex = 20
        Me.LB_CurrentStep.Text = "fasend"
        '
        'LB_SW_Wers
        '
        Me.LB_SW_Wers.AutoSize = True
        Me.LB_SW_Wers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LB_SW_Wers.Location = New System.Drawing.Point(187, 29)
        Me.LB_SW_Wers.Name = "LB_SW_Wers"
        Me.LB_SW_Wers.Size = New System.Drawing.Size(76, 16)
        Me.LB_SW_Wers.TabIndex = 20
        Me.LB_SW_Wers.Text = "SW_Wers"
        '
        'LabelAppName
        '
        Me.LabelAppName.AutoSize = True
        Me.LabelAppName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelAppName.Location = New System.Drawing.Point(187, 46)
        Me.LabelAppName.Name = "LabelAppName"
        Me.LabelAppName.Size = New System.Drawing.Size(55, 16)
        Me.LabelAppName.TabIndex = 20
        Me.LabelAppName.Text = "fasend"
        '
        'L_UserName
        '
        Me.L_UserName.AutoSize = True
        Me.L_UserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_UserName.Location = New System.Drawing.Point(187, 82)
        Me.L_UserName.Name = "L_UserName"
        Me.L_UserName.Size = New System.Drawing.Size(150, 16)
        Me.L_UserName.TabIndex = 19
        Me.L_UserName.Text = "Имя пользователя:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Название операции:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label15.Location = New System.Drawing.Point(30, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(159, 16)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Версия приложения:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Имя пользователя:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Название приложения:"
        '
        'Label_StationName
        '
        Me.Label_StationName.AutoSize = True
        Me.Label_StationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_StationName.Location = New System.Drawing.Point(187, 100)
        Me.Label_StationName.Name = "Label_StationName"
        Me.Label_StationName.Size = New System.Drawing.Size(28, 16)
        Me.Label_StationName.TabIndex = 16
        Me.Label_StationName.Text = "ПК"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(79, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Название ПК:"
        '
        'L_Model
        '
        Me.L_Model.AutoSize = True
        Me.L_Model.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_Model.Location = New System.Drawing.Point(187, 154)
        Me.L_Model.Name = "L_Model"
        Me.L_Model.Size = New System.Drawing.Size(51, 16)
        Me.L_Model.TabIndex = 16
        Me.L_Model.Text = "Model"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.Location = New System.Drawing.Point(121, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Модель:"
        '
        'L_LOT
        '
        Me.L_LOT.AutoSize = True
        Me.L_LOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_LOT.Location = New System.Drawing.Point(187, 136)
        Me.L_LOT.Name = "L_LOT"
        Me.L_LOT.Size = New System.Drawing.Size(37, 16)
        Me.L_LOT.TabIndex = 16
        Me.L_LOT.Text = "LOT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.Location = New System.Drawing.Point(59, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Название ЛОТа:"
        '
        'Lebel_StationLine
        '
        Me.Lebel_StationLine.AutoSize = True
        Me.Lebel_StationLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lebel_StationLine.Location = New System.Drawing.Point(187, 118)
        Me.Lebel_StationLine.Name = "Lebel_StationLine"
        Me.Lebel_StationLine.Size = New System.Drawing.Size(37, 16)
        Me.Lebel_StationLine.TabIndex = 16
        Me.Lebel_StationLine.Text = "Line"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Линия:"
        '
        'Controllabel
        '
        Me.Controllabel.AutoSize = True
        Me.Controllabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Controllabel.Location = New System.Drawing.Point(12, 234)
        Me.Controllabel.Name = "Controllabel"
        Me.Controllabel.Size = New System.Drawing.Size(217, 29)
        Me.Controllabel.TabIndex = 21
        Me.Controllabel.Text = "CONTROLLABEL"
        '
        'GB_ScanMode
        '
        Me.GB_ScanMode.Controls.Add(Me.CB_SelectLabel)
        Me.GB_ScanMode.Controls.Add(Me.GB_Printers)
        Me.GB_ScanMode.Controls.Add(Me.Label2)
        Me.GB_ScanMode.Controls.Add(Me.BT_CleareSN)
        Me.GB_ScanMode.Controls.Add(Me.BT_Pause)
        Me.GB_ScanMode.Controls.Add(Me.DG_UpLog)
        Me.GB_ScanMode.Controls.Add(Me.SerialTextBox)
        Me.GB_ScanMode.Location = New System.Drawing.Point(6, 311)
        Me.GB_ScanMode.Name = "GB_ScanMode"
        Me.GB_ScanMode.Size = New System.Drawing.Size(1012, 398)
        Me.GB_ScanMode.TabIndex = 30
        Me.GB_ScanMode.TabStop = False
        '
        'GB_Printers
        '
        Me.GB_Printers.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GB_Printers.Controls.Add(Me.Label14)
        Me.GB_Printers.Controls.Add(Me.CB_LabScenario)
        Me.GB_Printers.Controls.Add(Me.Label21)
        Me.GB_Printers.Controls.Add(Me.Num_X)
        Me.GB_Printers.Controls.Add(Me.BT_Save_Coordinats)
        Me.GB_Printers.Controls.Add(Me.Num_Y)
        Me.GB_Printers.Controls.Add(Me.Label22)
        Me.GB_Printers.Controls.Add(Me.Label23)
        Me.GB_Printers.Controls.Add(Me.CB_DefaultPrinter)
        Me.GB_Printers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GB_Printers.Location = New System.Drawing.Point(571, 155)
        Me.GB_Printers.Name = "GB_Printers"
        Me.GB_Printers.Size = New System.Drawing.Size(343, 237)
        Me.GB_Printers.TabIndex = 68
        Me.GB_Printers.TabStop = False
        Me.GB_Printers.Text = "Настройка принтеров"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(277, 20)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Выберите этикетку для печати"
        '
        'CB_LabScenario
        '
        Me.CB_LabScenario.FormattingEnabled = True
        Me.CB_LabScenario.Items.AddRange(New Object() {"1) Этикетка 44х21_Rus (FAS Start)", "2) Этикетки 39х19", "3) Этикетки 45х8"})
        Me.CB_LabScenario.Location = New System.Drawing.Point(10, 45)
        Me.CB_LabScenario.Name = "CB_LabScenario"
        Me.CB_LabScenario.Size = New System.Drawing.Size(293, 28)
        Me.CB_LabScenario.TabIndex = 66
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 156)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(106, 20)
        Me.Label21.TabIndex = 64
        Me.Label21.Text = "Корекция X"
        '
        'Num_X
        '
        Me.Num_X.Location = New System.Drawing.Point(118, 153)
        Me.Num_X.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.Num_X.Name = "Num_X"
        Me.Num_X.Size = New System.Drawing.Size(69, 26)
        Me.Num_X.TabIndex = 62
        '
        'BT_Save_Coordinats
        '
        Me.BT_Save_Coordinats.FlatAppearance.BorderSize = 0
        Me.BT_Save_Coordinats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Save_Coordinats.Image = Global.IP_TV.My.Resources.Resources._04
        Me.BT_Save_Coordinats.Location = New System.Drawing.Point(193, 148)
        Me.BT_Save_Coordinats.Name = "BT_Save_Coordinats"
        Me.BT_Save_Coordinats.Size = New System.Drawing.Size(58, 63)
        Me.BT_Save_Coordinats.TabIndex = 65
        Me.BT_Save_Coordinats.UseVisualStyleBackColor = True
        '
        'Num_Y
        '
        Me.Num_Y.Location = New System.Drawing.Point(118, 178)
        Me.Num_Y.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.Num_Y.Name = "Num_Y"
        Me.Num_Y.Size = New System.Drawing.Size(69, 26)
        Me.Num_Y.TabIndex = 63
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 181)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(106, 20)
        Me.Label22.TabIndex = 64
        Me.Label22.Text = "Корекция Y"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 85)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(271, 20)
        Me.Label23.TabIndex = 48
        Me.Label23.Text = "Выберите принтер для печати"
        '
        'CB_DefaultPrinter
        '
        Me.CB_DefaultPrinter.FormattingEnabled = True
        Me.CB_DefaultPrinter.Location = New System.Drawing.Point(10, 108)
        Me.CB_DefaultPrinter.Name = "CB_DefaultPrinter"
        Me.CB_DefaultPrinter.Size = New System.Drawing.Size(297, 28)
        Me.CB_DefaultPrinter.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(367, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Строка ввода серийного номера"
        '
        'BT_CleareSN
        '
        Me.BT_CleareSN.FlatAppearance.BorderSize = 0
        Me.BT_CleareSN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CleareSN.Image = Global.IP_TV.My.Resources.Resources.edittrash
        Me.BT_CleareSN.Location = New System.Drawing.Point(623, 14)
        Me.BT_CleareSN.Name = "BT_CleareSN"
        Me.BT_CleareSN.Size = New System.Drawing.Size(66, 94)
        Me.BT_CleareSN.TabIndex = 28
        Me.BT_CleareSN.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DG_UpLog.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle14
        Me.DG_UpLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_UpLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_UpLog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.DG_UpLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_UpLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Num, Me.SNumber, Me.CASIDTab})
        Me.DG_UpLog.Location = New System.Drawing.Point(25, 109)
        Me.DG_UpLog.Name = "DG_UpLog"
        Me.DG_UpLog.ReadOnly = True
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DG_UpLog.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DG_UpLog.Size = New System.Drawing.Size(969, 283)
        Me.DG_UpLog.TabIndex = 25
        '
        'Num
        '
        Me.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Num.HeaderText = "№"
        Me.Num.Name = "Num"
        Me.Num.ReadOnly = True
        Me.Num.Width = 50
        '
        'SNumber
        '
        Me.SNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SNumber.HeaderText = "Серийный номер"
        Me.SNumber.Name = "SNumber"
        Me.SNumber.ReadOnly = True
        Me.SNumber.Width = 159
        '
        'CASIDTab
        '
        Me.CASIDTab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CASIDTab.HeaderText = "Дата"
        Me.CASIDTab.Name = "CASIDTab"
        Me.CASIDTab.ReadOnly = True
        Me.CASIDTab.Width = 77
        '
        'SerialTextBox
        '
        Me.SerialTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SerialTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SerialTextBox.Location = New System.Drawing.Point(19, 51)
        Me.SerialTextBox.Name = "SerialTextBox"
        Me.SerialTextBox.Size = New System.Drawing.Size(508, 31)
        Me.SerialTextBox.TabIndex = 1
        '
        'FASErrorCodeBindingSource
        '
        Me.FASErrorCodeBindingSource.DataMember = "FAS_ErrorCode"
        '
        'IP_TV_Print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1061)
        Me.Controls.Add(Me.GB_PCBInfoMode)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GB_ErrorCode)
        Me.Controls.Add(Me.GB_UserData)
        Me.Controls.Add(Me.GB_WorkAria)
        Me.Name = "IP_TV_Print"
        Me.Text = "IP_TV_Print"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DG_PCB_Steps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_PCBInfoMode.ResumeLayout(False)
        Me.GB_PCBInfoMode.PerformLayout()
        CType(Me.DG_THT_Start, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DG_THTStartFromDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_PCBInfoFromDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_StepList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_ErrorCode.ResumeLayout(False)
        Me.GB_ErrorCode.PerformLayout()
        CType(Me.DG_ErrorCodes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GB_UserData.ResumeLayout(False)
        Me.GB_UserData.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GB_WorkAria.ResumeLayout(False)
        Me.GB_WorkAria.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GB_ScanMode.ResumeLayout(False)
        Me.GB_ScanMode.PerformLayout()
        Me.GB_Printers.ResumeLayout(False)
        Me.GB_Printers.PerformLayout()
        CType(Me.Num_X, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_Y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_UpLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FASErrorCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label19 As Label
    Friend WithEvents TB_GetPCPInfo As TextBox
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DG_PCB_Steps As DataGridView
    Friend WithEvents GB_PCBInfoMode As GroupBox
    Friend WithEvents DG_THT_Start As DataGridView
    Friend WithEvents PrintSerialPort3 As IO.Ports.SerialPort
    Friend WithEvents Label18 As Label
    Friend WithEvents PrintSerialPort6 As IO.Ports.SerialPort
    Friend WithEvents FASErrorCodeBindingSource As BindingSource
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents DG_THTStartFromDB As DataGridView
    Friend WithEvents DG_PCBInfoFromDB As DataGridView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DG_StepList As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BT_CloseErrMode As Button
    Friend WithEvents BT_SeveErCode As Button
    Friend WithEvents GB_ErrorCode As GroupBox
    Friend WithEvents DG_ErrorCodes As DataGridView
    Friend WithEvents TB_Description As TextBox
    Friend WithEvents CB_ErrorCode As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CurrentTimeTimer As Timer
    Friend WithEvents CB_SelectLabel As ComboBox
    Friend WithEvents BT_CleareSN As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label_ShiftCounter As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CurrrentTimeLabel As Label
    Friend WithEvents BT_PCBInfo As Button
    Friend WithEvents BT_OpenSettings As Button
    Friend WithEvents GB_UserData As GroupBox
    Friend WithEvents BT_LOGInClose As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents TB_RFIDIn As TextBox
    Friend WithEvents CB_PrinterSettings As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LB_LOTCounter As Label
    Friend WithEvents GB_WorkAria As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LB_CurrentStep As Label
    Friend WithEvents LabelAppName As Label
    Friend WithEvents L_UserName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label_StationName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents L_Model As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents L_LOT As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Lebel_StationLine As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Controllabel As Label
    Friend WithEvents GB_ScanMode As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BT_Pause As Button
    Friend WithEvents DG_UpLog As DataGridView
    Friend WithEvents SerialTextBox As TextBox
    Friend WithEvents Num As DataGridViewTextBoxColumn
    Friend WithEvents SNumber As DataGridViewTextBoxColumn
    Friend WithEvents CASIDTab As DataGridViewTextBoxColumn
    Friend WithEvents GB_Printers As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Num_X As NumericUpDown
    Friend WithEvents BT_Save_Coordinats As Button
    Friend WithEvents Num_Y As NumericUpDown
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents CB_DefaultPrinter As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents CB_LabScenario As ComboBox
    Friend WithEvents LB_SW_Wers As Label
    Friend WithEvents Label15 As Label
End Class
