<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BmiCalcBtn = New System.Windows.Forms.Button()
        Me.FutureValCalcBtn = New System.Windows.Forms.Button()
        Me.PassArgsByValAndByRefBtn = New System.Windows.Forms.Button()
        Me.MathFuncAbsBtn = New System.Windows.Forms.Button()
        Me.MathFuncExpBtn = New System.Windows.Forms.Button()
        Me.MathFuncFixBtn = New System.Windows.Forms.Button()
        Me.MathFuncLogBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BmiCalcBtn
        '
        Me.BmiCalcBtn.AutoSize = True
        Me.BmiCalcBtn.Location = New System.Drawing.Point(27, 33)
        Me.BmiCalcBtn.Name = "BmiCalcBtn"
        Me.BmiCalcBtn.Size = New System.Drawing.Size(344, 31)
        Me.BmiCalcBtn.TabIndex = 0
        Me.BmiCalcBtn.Text = "BMI Calculator"
        Me.BmiCalcBtn.UseVisualStyleBackColor = True
        '
        'FutureValCalcBtn
        '
        Me.FutureValCalcBtn.AutoSize = True
        Me.FutureValCalcBtn.Location = New System.Drawing.Point(27, 70)
        Me.FutureValCalcBtn.Name = "FutureValCalcBtn"
        Me.FutureValCalcBtn.Size = New System.Drawing.Size(344, 31)
        Me.FutureValCalcBtn.TabIndex = 0
        Me.FutureValCalcBtn.Text = "Future  Value Calculator"
        Me.FutureValCalcBtn.UseVisualStyleBackColor = True
        '
        'PassArgsByValAndByRefBtn
        '
        Me.PassArgsByValAndByRefBtn.AutoSize = True
        Me.PassArgsByValAndByRefBtn.Location = New System.Drawing.Point(27, 107)
        Me.PassArgsByValAndByRefBtn.Name = "PassArgsByValAndByRefBtn"
        Me.PassArgsByValAndByRefBtn.Size = New System.Drawing.Size(344, 31)
        Me.PassArgsByValAndByRefBtn.TabIndex = 0
        Me.PassArgsByValAndByRefBtn.Text = "Passing Arguments by Value and by Reference"
        Me.PassArgsByValAndByRefBtn.UseVisualStyleBackColor = True
        '
        'MathFuncAbsBtn
        '
        Me.MathFuncAbsBtn.AutoSize = True
        Me.MathFuncAbsBtn.Location = New System.Drawing.Point(27, 144)
        Me.MathFuncAbsBtn.Name = "MathFuncAbsBtn"
        Me.MathFuncAbsBtn.Size = New System.Drawing.Size(344, 31)
        Me.MathFuncAbsBtn.TabIndex = 0
        Me.MathFuncAbsBtn.Text = "Math Function Abs()"
        Me.MathFuncAbsBtn.UseVisualStyleBackColor = True
        '
        'MathFuncExpBtn
        '
        Me.MathFuncExpBtn.AutoSize = True
        Me.MathFuncExpBtn.Location = New System.Drawing.Point(27, 181)
        Me.MathFuncExpBtn.Name = "MathFuncExpBtn"
        Me.MathFuncExpBtn.Size = New System.Drawing.Size(344, 31)
        Me.MathFuncExpBtn.TabIndex = 0
        Me.MathFuncExpBtn.Text = "Math Function Exp()"
        Me.MathFuncExpBtn.UseVisualStyleBackColor = True
        '
        'MathFuncFixBtn
        '
        Me.MathFuncFixBtn.AutoSize = True
        Me.MathFuncFixBtn.Location = New System.Drawing.Point(27, 218)
        Me.MathFuncFixBtn.Name = "MathFuncFixBtn"
        Me.MathFuncFixBtn.Size = New System.Drawing.Size(344, 31)
        Me.MathFuncFixBtn.TabIndex = 0
        Me.MathFuncFixBtn.Text = "Math Function Fix()"
        Me.MathFuncFixBtn.UseVisualStyleBackColor = True
        '
        'MathFuncLogBtn
        '
        Me.MathFuncLogBtn.AutoSize = True
        Me.MathFuncLogBtn.Location = New System.Drawing.Point(27, 255)
        Me.MathFuncLogBtn.Name = "MathFuncLogBtn"
        Me.MathFuncLogBtn.Size = New System.Drawing.Size(344, 31)
        Me.MathFuncLogBtn.TabIndex = 1
        Me.MathFuncLogBtn.Text = "Math Function Log()"
        Me.MathFuncLogBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 321)
        Me.Controls.Add(Me.MathFuncLogBtn)
        Me.Controls.Add(Me.MathFuncFixBtn)
        Me.Controls.Add(Me.MathFuncExpBtn)
        Me.Controls.Add(Me.MathFuncAbsBtn)
        Me.Controls.Add(Me.PassArgsByValAndByRefBtn)
        Me.Controls.Add(Me.FutureValCalcBtn)
        Me.Controls.Add(Me.BmiCalcBtn)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form1"
        Me.Text = "D"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BmiCalcBtn As Button
    Friend WithEvents FutureValCalcBtn As Button
    Friend WithEvents PassArgsByValAndByRefBtn As Button
    Friend WithEvents MathFuncAbsBtn As Button
    Friend WithEvents MathFuncExpBtn As Button
    Friend WithEvents MathFuncFixBtn As Button
    Friend WithEvents MathFuncLogBtn As Button
End Class
