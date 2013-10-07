Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim LegOne As Double
        Dim LegTwo As Double
        Dim Hype As Double
        'Read Input from user
        LegOne = CDbl(txtSideOne.Text)
        LegTwo = CDbl(txtSideTwo.Text)

        Hype = Hypotenuse(LegOne, LegTwo)
        txtHyp.Text = CStr(Hype)

    End Sub
    Function Hypotenuse(ByVal side1 As Double, ByVal side2 As Double) As Double
        Dim Hype As Double
        Hype = Math.Sqrt(side1 ^ 2 + side2 ^ 2)
        Return Hype
    End Function
End Class
