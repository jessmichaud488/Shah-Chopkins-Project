Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblTwelvePack, dblFivePack, dblTwoPack, dblTotalPack,
        dblFirstTotal, dblSecondTotal, dblThirdTotal,
        dblTotalShipping, dblShippingCharge As Double

        Double.TryParse(txtTwelveBox.Text, dblTwelvePack)
        dblFirstTotal = dblTwelvePack * 14.99

        lblTwelveTotalBox.Text = FormatCurrency(dblFirstTotal)

        Double.TryParse(txtFiveBox.Text, dblFivePack)
        dblSecondTotal = dblFivePack * 6.99

        lblFiveTotalBox.Text = FormatCurrency(dblSecondTotal)

        Double.TryParse(txtTwoBox.Text, dblTwoPack)
        dblThirdTotal = dblTwoPack * 2.5

        lblTwoTotalBox.Text = FormatCurrency(dblThirdTotal)

        dblTotalPack = dblTwelvePack + dblFivePack + dblTwoPack
        lblQtyBox.Text = dblTotalPack

        Double.TryParse(txtShippingBox.Text, dblShippingCharge)
        dblTotalShipping = dblFirstTotal + dblSecondTotal + dblThirdTotal + dblShippingCharge
        lblTotalBox.Text = FormatCurrency(dblTotalShipping)
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    End Sub
End Class
