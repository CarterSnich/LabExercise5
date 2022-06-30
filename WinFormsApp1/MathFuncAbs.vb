Public Class MathFuncAbs
    Private Sub ComputeBtn_Click(sender As Object, e As EventArgs) Handles ComputeBtn.Click
        AbsValTextbox.Text = Math.Abs(Val(NumTextbox.Text))
    End Sub
End Class