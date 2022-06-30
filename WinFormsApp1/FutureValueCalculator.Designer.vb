<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FutureValueCalculator
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PresentValTextbox = New System.Windows.Forms.TextBox()
        Me.InterestRateTextbox = New System.Windows.Forms.TextBox()
        Me.NoOfYearsTextbox = New System.Windows.Forms.TextBox()
        Me.FutureValTextbox = New System.Windows.Forms.TextBox()
        Me.CalculateBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Present Value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Interest Rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Number of Years"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Future Value"
        '
        'PresentValTextbox
        '
        Me.PresentValTextbox.Location = New System.Drawing.Point(168, 29)
        Me.PresentValTextbox.Name = "PresentValTextbox"
        Me.PresentValTextbox.Size = New System.Drawing.Size(136, 29)
        Me.PresentValTextbox.TabIndex = 1
        '
        'InterestRateTextbox
        '
        Me.InterestRateTextbox.Location = New System.Drawing.Point(168, 64)
        Me.InterestRateTextbox.Name = "InterestRateTextbox"
        Me.InterestRateTextbox.Size = New System.Drawing.Size(136, 29)
        Me.InterestRateTextbox.TabIndex = 1
        '
        'NoOfYearsTextbox
        '
        Me.NoOfYearsTextbox.Location = New System.Drawing.Point(168, 99)
        Me.NoOfYearsTextbox.Name = "NoOfYearsTextbox"
        Me.NoOfYearsTextbox.Size = New System.Drawing.Size(136, 29)
        Me.NoOfYearsTextbox.TabIndex = 1
        '
        'FutureValTextbox
        '
        Me.FutureValTextbox.BackColor = System.Drawing.Color.Yellow
        Me.FutureValTextbox.Location = New System.Drawing.Point(168, 134)
        Me.FutureValTextbox.Name = "FutureValTextbox"
        Me.FutureValTextbox.ReadOnly = True
        Me.FutureValTextbox.Size = New System.Drawing.Size(136, 29)
        Me.FutureValTextbox.TabIndex = 1
        '
        'CalculateBtn
        '
        Me.CalculateBtn.AutoSize = True
        Me.CalculateBtn.Location = New System.Drawing.Point(27, 169)
        Me.CalculateBtn.Name = "CalculateBtn"
        Me.CalculateBtn.Size = New System.Drawing.Size(277, 31)
        Me.CalculateBtn.TabIndex = 2
        Me.CalculateBtn.Text = "Calculate"
        Me.CalculateBtn.UseVisualStyleBackColor = True
        '
        'FutureValueCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 232)
        Me.Controls.Add(Me.CalculateBtn)
        Me.Controls.Add(Me.FutureValTextbox)
        Me.Controls.Add(Me.NoOfYearsTextbox)
        Me.Controls.Add(Me.InterestRateTextbox)
        Me.Controls.Add(Me.PresentValTextbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FutureValueCalculator"
        Me.Text = "FutureValueCalculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PresentValTextbox As TextBox
    Friend WithEvents InterestRateTextbox As TextBox
    Friend WithEvents NoOfYearsTextbox As TextBox
    Friend WithEvents FutureValTextbox As TextBox
    Friend WithEvents CalculateBtn As Button
End Class
