<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PassResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PassResult))
        Me.Controllabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SerialTextBox = New System.Windows.Forms.TextBox()
        Me.BT_CleareSN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Controllabel
        '
        Me.Controllabel.AutoSize = True
        Me.Controllabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Controllabel.Location = New System.Drawing.Point(34, 24)
        Me.Controllabel.Name = "Controllabel"
        Me.Controllabel.Size = New System.Drawing.Size(217, 29)
        Me.Controllabel.TabIndex = 22
        Me.Controllabel.Text = "CONTROLLABEL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(367, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Строка ввода серийного номера"
        '
        'SerialTextBox
        '
        Me.SerialTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SerialTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SerialTextBox.Location = New System.Drawing.Point(28, 159)
        Me.SerialTextBox.Name = "SerialTextBox"
        Me.SerialTextBox.Size = New System.Drawing.Size(508, 31)
        Me.SerialTextBox.TabIndex = 23
        '
        'BT_CleareSN
        '
        Me.BT_CleareSN.FlatAppearance.BorderSize = 0
        Me.BT_CleareSN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CleareSN.Image = CType(resources.GetObject("BT_CleareSN.Image"), System.Drawing.Image)
        Me.BT_CleareSN.Location = New System.Drawing.Point(542, 128)
        Me.BT_CleareSN.Name = "BT_CleareSN"
        Me.BT_CleareSN.Size = New System.Drawing.Size(66, 94)
        Me.BT_CleareSN.TabIndex = 29
        Me.BT_CleareSN.UseVisualStyleBackColor = True
        '
        'PassResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BT_CleareSN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SerialTextBox)
        Me.Controls.Add(Me.Controllabel)
        Me.Name = "PassResult"
        Me.Text = "PassResult"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Controllabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SerialTextBox As TextBox
    Friend WithEvents BT_CleareSN As Button
End Class
