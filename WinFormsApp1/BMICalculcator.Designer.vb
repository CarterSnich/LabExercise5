<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BMICalculcator
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HeightTextbox = New System.Windows.Forms.TextBox()
        Me.WeightTextbox = New System.Windows.Forms.TextBox()
        Me.BmiTextbox = New System.Windows.Forms.TextBox()
        Me.CalculateBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Height (m)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Weight (kg)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "BMI"
        '
        'HeightTextbox
        '
        Me.HeightTextbox.Location = New System.Drawing.Point(124, 30)
        Me.HeightTextbox.Name = "HeightTextbox"
        Me.HeightTextbox.Size = New System.Drawing.Size(138, 29)
        Me.HeightTextbox.TabIndex = 2
        '
        'WeightTextbox
        '
        Me.WeightTextbox.Location = New System.Drawing.Point(124, 65)
        Me.WeightTextbox.Name = "WeightTextbox"
        Me.WeightTextbox.Size = New System.Drawing.Size(138, 29)
        Me.WeightTextbox.TabIndex = 2
        '
        'BmiTextbox
        '
        Me.BmiTextbox.BackColor = System.Drawing.Color.Yellow
        Me.BmiTextbox.Location = New System.Drawing.Point(124, 100)
        Me.BmiTextbox.Name = "BmiTextbox"
        Me.BmiTextbox.ReadOnly = True
        Me.BmiTextbox.Size = New System.Drawing.Size(138, 29)
        Me.BmiTextbox.TabIndex = 2
        '
        'CalculateBtn
        '
        Me.CalculateBtn.AutoSize = True
        Me.CalculateBtn.Location = New System.Drawing.Point(25, 135)
        Me.CalculateBtn.Name = "CalculateBtn"
        Me.CalculateBtn.Size = New System.Drawing.Size(237, 31)
        Me.CalculateBtn.TabIndex = 3
        Me.CalculateBtn.Text = "Calculate"
        Me.CalculateBtn.UseVisualStyleBackColor = True
        '
        'BMICalculcator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 198)
        Me.Controls.Add(Me.CalculateBtn)
        Me.Controls.Add(Me.BmiTextbox)
        Me.Controls.Add(Me.WeightTextbox)
        Me.Controls.Add(Me.HeightTextbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BMICalculcator"
        Me.Text = "BMI Calculcator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents HeightTextbox As TextBox
    Friend WithEvents WeightTextbox As TextBox
    Friend WithEvents BmiTextbox As TextBox
    Friend WithEvents CalculateBtn As Button
End Class
