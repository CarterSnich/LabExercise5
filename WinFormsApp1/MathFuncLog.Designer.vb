<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathFuncLog
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
        Me.ComputeBtn = New System.Windows.Forms.Button()
        Me.NumTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LogNumTextbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number"
        '
        'ComputeBtn
        '
        Me.ComputeBtn.AutoSize = True
        Me.ComputeBtn.Location = New System.Drawing.Point(31, 107)
        Me.ComputeBtn.Name = "ComputeBtn"
        Me.ComputeBtn.Size = New System.Drawing.Size(250, 31)
        Me.ComputeBtn.TabIndex = 1
        Me.ComputeBtn.Text = "Compute"
        Me.ComputeBtn.UseVisualStyleBackColor = True
        '
        'NumTextbox
        '
        Me.NumTextbox.Location = New System.Drawing.Point(146, 37)
        Me.NumTextbox.Name = "NumTextbox"
        Me.NumTextbox.Size = New System.Drawing.Size(135, 29)
        Me.NumTextbox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Log(Number)"
        '
        'LogNumTextbox
        '
        Me.LogNumTextbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LogNumTextbox.Location = New System.Drawing.Point(146, 72)
        Me.LogNumTextbox.Name = "LogNumTextbox"
        Me.LogNumTextbox.Size = New System.Drawing.Size(135, 29)
        Me.LogNumTextbox.TabIndex = 2
        '
        'MathFuncLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 168)
        Me.Controls.Add(Me.LogNumTextbox)
        Me.Controls.Add(Me.NumTextbox)
        Me.Controls.Add(Me.ComputeBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MathFuncLog"
        Me.Text = "MathFuncLog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComputeBtn As Button
    Friend WithEvents NumTextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LogNumTextbox As TextBox
End Class
