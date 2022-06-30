<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathFuncExp
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
        Me.NumTextbox = New System.Windows.Forms.TextBox()
        Me.ExpValTextbox = New System.Windows.Forms.TextBox()
        Me.ComputeBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Exponential Value"
        '
        'NumTextbox
        '
        Me.NumTextbox.Location = New System.Drawing.Point(188, 30)
        Me.NumTextbox.Name = "NumTextbox"
        Me.NumTextbox.Size = New System.Drawing.Size(137, 29)
        Me.NumTextbox.TabIndex = 1
        '
        'ExpValTextbox
        '
        Me.ExpValTextbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ExpValTextbox.Location = New System.Drawing.Point(188, 65)
        Me.ExpValTextbox.Name = "ExpValTextbox"
        Me.ExpValTextbox.Size = New System.Drawing.Size(137, 29)
        Me.ExpValTextbox.TabIndex = 1
        '
        'ComputeBtn
        '
        Me.ComputeBtn.AutoSize = True
        Me.ComputeBtn.Location = New System.Drawing.Point(27, 100)
        Me.ComputeBtn.Name = "ComputeBtn"
        Me.ComputeBtn.Size = New System.Drawing.Size(298, 31)
        Me.ComputeBtn.TabIndex = 2
        Me.ComputeBtn.Text = "Compute"
        Me.ComputeBtn.UseVisualStyleBackColor = True
        '
        'MathFuncExponentVal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 170)
        Me.Controls.Add(Me.ComputeBtn)
        Me.Controls.Add(Me.ExpValTextbox)
        Me.Controls.Add(Me.NumTextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MathFuncExponentVal"
        Me.Text = "MathFuncExponentVal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumTextbox As TextBox
    Friend WithEvents ExpValTextbox As TextBox
    Friend WithEvents ComputeBtn As Button
End Class
