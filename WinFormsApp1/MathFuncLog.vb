Public Class MathFuncLog
    Private Sub ComputeBtn_Click(sender As Object, e As EventArgs) Handles ComputeBtn.Click
        LogNumTextbox.Text = Math.Log(Val(NumTextbox.Text))
    End Sub
End Class