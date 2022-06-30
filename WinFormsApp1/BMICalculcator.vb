Public Class BMICalculcator
    Private Function BMI(Height As Single, weight As Single) As Double
        BMI = weight / Height ^ 2
    End Function

    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        Dim h As Single, w As Single
        h = Val(HeightTextbox.Text)
        w = Val(WeightTextbox.Text)
        BmiTextbox.Text = BMI(h, w)

    End Sub
End Class