Imports Library3
Imports System.Drawing
Public Class PassResult
    Dim LOTID, IDApp As Integer
    Public Sub New(LOTIDWF As Integer, IDApp As Integer)
        InitializeComponent()
        Me.LOTID = LOTIDWF
        Me.IDApp = IDApp
    End Sub
    Private Sub PassResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'начало работы приложения FAS Quarantine Station
    'окно ввода серийного номера платы
    Dim Mess As String, Col As Color

    Private Sub BT_CleareSN_Click(sender As Object, e As EventArgs) Handles BT_CleareSN.Click
        SerialTextBox.Clear()
        SerialTextBox.Enabled = True
        Controllabel.Text = ""
        SerialTextBox.Focus()
    End Sub

    Private Sub SerialTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SerialTextBox.KeyDown
        If e.KeyCode = Keys.Enter And SerialTextBox.TextLength = 11 Then
            If UpdateStepRes(SerialTextBox.Text) = True Then
                Mess = "True"
                Col = Color.Green
            Else
                Mess = "False"
                Col = Color.Red
            End If
            PrintLabel(Controllabel, Mess, 12, 193, Col)
        End If
    End Sub

    '3. функция обноления результата тестирования для Pass/Fail
    Private Function UpdateStepRes(sn As String)
        Dim NumID = SelectString($"use fas Select PCBID from [FAS].[dbo].[Ct_OperLog]  
                                where PCBID = (select IDLaser from SMDCOMPONETS.dbo.LazerBase where Content = '{ sn }')  ")
        If NumID <> "" Then
            RunCommand($"USE FAS Update [FAS].[dbo].[Ct_StepResult] 
                    set StepID = 4, TestResult = 2, ScanDate = CURRENT_TIMESTAMP, SNID = Null  
                    where PCBID =  { NumID }")
            RunCommand($"insert into [FAS].[dbo].[Ct_OperLog] ([PCBID],[LOTID],[StepID],[TestResultID],[StepDate],
                    [StepByID],[LineID])values
                    ( {NumID} , {LOTID} ,4 , 2 ,CURRENT_TIMESTAMP, 11 ,1 )")
            SerialTextBox.Clear()
            SerialTextBox.Focus()
            Return True
        Else
            SerialTextBox.Enabled = False
            Return False
        End If


    End Function

End Class