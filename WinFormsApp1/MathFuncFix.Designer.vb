<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathFuncFix
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Num1Textbox = New System.Windows.Forms.TextBox()
        Me.ComputeBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FixNum1Textbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Num2Textbox = New System.Windows.Forms.TextBox()
        Me.FixNum2Textbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number 1"
        '
        'Num1Textbox
        '
        Me.Num1Textbox.Location = New System.Drawing.Point(104, 55)
        Me.Num1Textbox.Name = "Num1Textbox"
        Me.Num1Textbox.Size = New System.Drawing.Size(100, 29)
        Me.Num1Textbox.TabIndex = 1
        '
        'ComputeBtn
        '
        Me.ComputeBtn.AutoSize = True
        Me.ComputeBtn.Location = New System.Drawing.Point(160, 198)
        Me.ComputeBtn.Name = "ComputeBtn"
        Me.ComputeBtn.Size = New System.Drawing.Size(132, 31)
        Me.ComputeBtn.TabIndex = 2
        Me.ComputeBtn.Text = "Compute"
        Me.ComputeBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fix(Number1)"
        '
        'FixNum1Textbox
        '
        Me.FixNum1Textbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.FixNum1Textbox.Location = New System.Drawing.Point(331, 55)
        Me.FixNum1Textbox.Name = "FixNum1Textbox"
        Me.FixNum1Textbox.Size = New System.Drawing.Size(100, 29)
        Me.FixNum1Textbox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Number 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(224, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fix(Number2)"
        '
        'Num2Textbox
        '
        Me.Num2Textbox.Location = New System.Drawing.Point(104, 122)
        Me.Num2Textbox.Name = "Num2Textbox"
        Me.Num2Textbox.Size = New System.Drawing.Size(100, 29)
        Me.Num2Textbox.TabIndex = 1
        '
        'FixNum2Textbox
        '
        Me.FixNum2Textbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.FixNum2Textbox.Location = New System.Drawing.Point(331, 122)
        Me.FixNum2Textbox.Name = "FixNum2Textbox"
        Me.FixNum2Textbox.Size = New System.Drawing.Size(100, 29)
        Me.FixNum2Textbox.TabIndex = 1
        '
        'MathFuncFix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 259)
        Me.Controls.Add(Me.ComputeBtn)
        Me.Controls.Add(Me.FixNum2Textbox)
        Me.Controls.Add(Me.FixNum1Textbox)
        Me.Controls.Add(Me.Num2Textbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Num1Textbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MathFuncFix"
        Me.Text = "MathFuncFix"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Num1Textbox As TextBox
    Friend WithEvents ComputeBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents FixNum1Textbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Num2Textbox As TextBox
    Friend WithEvents FixNum2Textbox As TextBox
End Class
