Public Class Form1

    Const bread = 1.79
    Const smartphone = 1500
    Const milk = 2.5
    Const burger = 4.15
    Const watch = 400
    Const waterBottle = 1.15
    Const book = 50
    Const perfume = 150
    Const jacket = 100
    Const skincare = 200

    Dim items(10)

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        items(0) = Numbread.Value * bread
        items(1) = Numsmart.Value * smartphone
        items(2) = Nummilk.Value * milk
        items(3) = Numburger.Value * burger
        items(4) = Numwatch.Value * watch
        items(5) = Numwater.Value * waterBottle
        items(6) = Numbook.Value * book
        items(7) = Numperfume.Value * perfume
        items(8) = Numjacket.Value * jacket
        items(9) = Numskincare.Value * skincare
        items(10) = items(0) + items(1) + items(2) + items(3) + items(4) + items(5) + items(6) + items(7) + items(8) + items(9)
        LBLTotalItem.Text = FormatCurrency(items(10))

        Dim q(10)

        q(0) = Numbread.Value
        q(1) = Numsmart.Value
        q(2) = Nummilk.Value
        q(3) = Numburger.Value
        q(4) = Numwatch.Value
        q(5) = Numwater.Value
        q(6) = Numbook.Value
        q(7) = Numperfume.Value
        q(8) = Numjacket.Value
        q(9) = Numskincare.Value
        q(10) = q(0) + q(1) + q(2) + q(3) + q(4) + q(5) + q(6) + q(7) + q(8) + q(9)
        LBLNumItems.Text = q(10)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim iQuit As DialogResult

        iQuit = MessageBox.Show("Confirm if you want to Quit.", "Billing Management System ",
MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iQuit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles LBLBread.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Item1.Click

    End Sub

    Private Sub Numbread_ValueChanged(sender As Object, e As EventArgs) Handles Numbread.ValueChanged
        LBLBread.Text = FormatCurrency(Numbread.Value * bread)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles item2.Click

    End Sub

    Private Sub Numsmart_ValueChanged(sender As Object, e As EventArgs) Handles Numsmart.ValueChanged

        LBLSmartphone.Text = FormatCurrency(Numsmart.Value * smartphone)

    End Sub

    Private Sub Nummilk_ValueChanged(sender As Object, e As EventArgs) Handles Nummilk.ValueChanged
        LBLMilk.Text = FormatCurrency(Nummilk.Value * milk)

    End Sub

    Private Sub Numburger_ValueChanged(sender As Object, e As EventArgs) Handles Numburger.ValueChanged
        LBLBurger.Text = FormatCurrency(Numburger.Value * burger)

    End Sub

    Private Sub Numwatch_ValueChanged(sender As Object, e As EventArgs) Handles Numwatch.ValueChanged
        LBLWatch.Text = FormatCurrency(Numwatch.Value * watch)

    End Sub

    Private Sub Numwater_ValueChanged(sender As Object, e As EventArgs) Handles Numwater.ValueChanged
        LBLWaterbottle.Text = FormatCurrency(Numwater.Value * waterBottle)
    End Sub

    Private Sub Numbook_ValueChanged(sender As Object, e As EventArgs) Handles Numbook.ValueChanged
        LBLBook.Text = FormatCurrency(Numbook.Value * book)
    End Sub

    Private Sub Numperfume_ValueChanged(sender As Object, e As EventArgs) Handles Numperfume.ValueChanged
        LBLPerfume.Text = FormatCurrency(Numperfume.Value * perfume)
    End Sub

    Private Sub Numjacket_ValueChanged(sender As Object, e As EventArgs) Handles Numjacket.ValueChanged
        LBLJacket.Text = FormatCurrency(Numjacket.Value * jacket)
    End Sub

    Private Sub Numskincare_ValueChanged(sender As Object, e As EventArgs) Handles Numskincare.ValueChanged
        LBLSkincare.Text = FormatCurrency(Numskincare.Value * skincare)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Numbread.Value = 0
        Numsmart.Value = 0
        Nummilk.Value = 0
        Numburger.Value = 0
        Numwatch.Value = 0
        Numwater.Value = 0
        Numbook.Value = 0
        Numperfume.Value = 0
        Numjacket.Value = 0
        Numskincare.Value = 0

        LBLBread.Text = "$0.00"
        LBLSmartphone.Text = "$0.00"
        LBLMilk.Text = "$0.00"
        LBLBurger.Text = "$0.00"
        LBLWatch.Text = "$0.00"
        LBLWaterbottle.Text = "$0.00"
        LBLBook.Text = "$0.00"
        LBLPerfume.Text = "$0.00"
        LBLJacket.Text = "$0.00"
        LBLSkincare.Text = "$0.00"
        LBLNumItems.Text = 0
        LBLTotalItem.Text = "$0.00"

        RTInvoice.Clear()
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles LBLTotalItem.Click

    End Sub

    Private Sub LBLNumItems_Click(sender As Object, e As EventArgs) Handles LBLNumItems.Click

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnInvoice_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click

        RTInvoice.Clear()
        RTInvoice.AppendText(Label21.Text & vbTab & Label22.Text & vbTab & Label23.Text & vbNewLine)

        RTInvoice.AppendText(Item1.Text & vbTab & vbTab & Numbread.Value & vbTab & vbTab & LBLBread.Text & vbNewLine)
        RTInvoice.AppendText(item2.Text & vbTab & Numsmart.Value & vbTab & vbTab & LBLSmartphone.Text & vbNewLine)
        RTInvoice.AppendText(item3.Text & vbTab & vbTab & Nummilk.Value & vbTab & vbTab & LBLMilk.Text & vbNewLine)
        RTInvoice.AppendText(item4.Text & vbTab & vbTab & Numburger.Value & vbTab & vbTab & LBLBurger.Text & vbNewLine)
        RTInvoice.AppendText(item5.Text & vbTab & vbTab & Numwatch.Value & vbTab & vbTab & LBLWatch.Text & vbNewLine)
        RTInvoice.AppendText(item6.Text & vbTab & Numwater.Value & vbTab & vbTab & LBLWaterbottle.Text & vbNewLine)
        RTInvoice.AppendText(item7.Text & vbTab & vbTab & Numbook.Value & vbTab & vbTab & LBLBook.Text & vbNewLine)
        RTInvoice.AppendText(item8.Text & vbTab & Numperfume.Value & vbTab & vbTab & LBLPerfume.Text & vbNewLine)
        RTInvoice.AppendText(item9.Text & vbTab & vbTab & Numjacket.Value & vbTab & vbTab & LBLJacket.Text & vbNewLine)
        RTInvoice.AppendText(item10.Text & vbTab & Numskincare.Value & vbTab & vbTab & LBLSkincare.Text & vbNewLine)

        RTInvoice.AppendText(Label24.Text & vbTab & LBLNumItems.Text & vbTab & vbTab & LBLTotalItem.Text & vbNewLine)

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RTInvoice.TextChanged

    End Sub
End Class
