Public Class MathFuncFix
    Private Sub ComputeBtn_Click(sender As Object, e As EventArgs) Handles ComputeBtn.Click
        FixNum1Textbox.Text = Fix(Val(Num1Textbox.Text))
        FixNum2Textbox.Text = Fix(Val(Num2Textbox.Text))
    End Sub
End Class