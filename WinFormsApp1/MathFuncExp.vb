Public Class MathFuncExp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ComputeBtn.Click
        ExpValTextbox.Text = Math.Exp(Val(NumTextbox.Text))
    End Sub
End Class