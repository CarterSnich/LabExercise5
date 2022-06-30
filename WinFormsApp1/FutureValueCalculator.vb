Public Class FutureValueCalculator

    Private Function FV(pv As Single, i As Single, n As Integer) As Double
        FV = pv * (1 + i / 100) ^ n
    End Function

    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        Dim FutureVal As Single
        Dim PresentVal As Single
        Dim interest As Single
        Dim period As Integer
        PresentVal = PresentValTextbox.Text
        interest = InterestRateTextbox.Text
        period = NoOfYearsTextbox.Text
        FutureVal = FV(PresentVal, interest, period)
        FutureValTextbox.Text = Format(FutureVal, "$#,##0.00")
    End Sub
End Class