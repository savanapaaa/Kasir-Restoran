Public Class Form1
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtdiskon.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txtkembali.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsubtotal.Click
        txtsubtotal.Text = txtharga.Text * txtjumlah.Text

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbvoucher.SelectedIndexChanged
        If cmbvoucher.Text = "AKHIRPEKAN" Then
            txtdiskon.Text = 10
        ElseIf cmbvoucher.Text = "AKHIRBULAN" Then
            txtdiskon.Text = 20
        ElseIf cmbvoucher.Text = "AKHIRTAHUN" Then
            txtdiskon.Text = 30
        ElseIf cmbvoucher.Text = "Tidk Ada" Then
            txtdiskon.Text = 0
        End If
    End Sub

    Private Sub cmbitem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbitem.SelectedIndexChanged
        If cmbitem.Text = "Ayam Bakar" Then
            txtharga.Text = 35000
        ElseIf cmbitem.Text = "Ayam Goreng" Then
            txtharga.Text = 27000
        ElseIf cmbitem.Text = "Pecel Ayam" Then
            txtharga.Text = 20000
        ElseIf cmbitem.Text = "Soto Ayam" Then
            txtharga.Text = 25000

        End If
    End Sub

    Private Sub btntotal_Click(sender As Object, e As EventArgs) Handles btntotal.Click
        txttotal.Text = txtsubtotal.Text - (txtsubtotal.Text * txtdiskon.Text) / 100
        Label2.Text = txttotal.Text
    End Sub

    Private Sub txtbayar_TextChanged(sender As Object, e As EventArgs) Handles txtbayar.TextChanged

    End Sub

    Private Sub txtbayar_Leave(sender As Object, e As EventArgs) Handles txtbayar.Leave
        txtkembali.Text = txtbayar.Text - txttotal.Text

    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        cmbitem.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
        txtsubtotal.Text = ""
        txtdiskon.Text = ""
        txttotal.Text = ""
        txtbayar.Text = ""
        txtkembali.Text = ""
        cmbvoucher.Text = ""
        Label2.Text = 0
        cmbitem.Focus()

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
