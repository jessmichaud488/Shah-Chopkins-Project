Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim twelvePack, fivePack, twoPack, totalPack,
            firstTotal, secondTotal, ThirdTotal,
            totalShipping, shippingCharge As Double

        Double.TryParse(txtTwelveBox.Text, twelvePack)
        firstTotal = twelvePack * 14.99

        lblTwelveTotalBox.Text = FormatCurrency(firstTotal)

        Double.TryParse(txtFiveBox.Text, fivePack)
        secondTotal = fivePack * 6.99

        lblFiveTotalBox.Text = FormatCurrency(secondTotal)

        Double.TryParse(txtTwoBox.Text, twoPack)
        ThirdTotal = twoPack * 2.5

        lblTwoTotalBox.Text = FormatCurrency(ThirdTotal)

        totalPack = twelvePack + fivePack + twoPack
        lblQtyBox.Text = totalPack

        Double.TryParse(txtShippingBox.Text, shippingCharge)
        totalShipping = firstTotal + secondTotal + ThirdTotal + shippingCharge
        lblTotalBox.Text = FormatCurrency(totalShipping)
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtFiveBox_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
