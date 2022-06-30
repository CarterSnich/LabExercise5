Public Class Form1

    Sub New()
        Application.EnableVisualStyles()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub BmiCalcBtn_Click(sender As Object, e As EventArgs) Handles BmiCalcBtn.Click
        Dim bmiCalculatorForm As New BMICalculcator()
        bmiCalculatorForm.ShowDialog(Me)
    End Sub

    Private Sub FutureValCalcBtn_Click(sender As Object, e As EventArgs) Handles FutureValCalcBtn.Click
        Dim futureValCalcForm As New FutureValueCalculator()
        futureValCalcForm.ShowDialog(Me)
    End Sub

    Private Sub PassArgsByValAndByRefBtn_Click(sender As Object, e As EventArgs) Handles PassArgsByValAndByRefBtn.Click
        Dim passArgByValAndbyRefForm As New PassArgByValAndbyRef()
        passArgByValAndbyRefForm.ShowDialog(Me)
    End Sub

    Private Sub MathFuncAbsBtn_Click(sender As Object, e As EventArgs) Handles MathFuncAbsBtn.Click
        Dim mathFuncAbsForm As New MathFuncAbs()
        mathFuncAbsForm.ShowDialog(Me)
    End Sub

    Private Sub MathFuncExpBtn_Click(sender As Object, e As EventArgs) Handles MathFuncExpBtn.Click
        Dim mathFuncExpForm As New MathFuncExp()
        mathFuncExpForm.ShowDialog(Me)
    End Sub

    Private Sub MathFuncFixBtn_Click(sender As Object, e As EventArgs) Handles MathFuncFixBtn.Click
        Dim mathFuncFixForm As New MathFuncFix()
        mathFuncFixForm.ShowDialog(Me)
    End Sub

    Private Sub MathFuncLogBtn_Click(sender As Object, e As EventArgs) Handles MathFuncLogBtn.Click
        Dim mathFuncLogForm As New MathFuncLog()
        mathFuncLogForm.ShowDialog(Me)
    End Sub
End Class
