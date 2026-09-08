Public Class Pajak

    Private Sub txtPendapatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendapatan.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim pendapatan As Decimal
        If Not Decimal.TryParse(txtPendapatan.Text.Trim(), pendapatan) Then
            MessageBox.Show("Masukkan pendapatan dengan angka yang benar")
            txtPendapatan.Focus()
            Return
        End If

        Dim persenPajak As Decimal

        If pendapatan <= 5000000 Then
            persenPajak = 0
        ElseIf pendapatan <= 30000000 Then
            persenPajak = 0.1D
        ElseIf pendapatan <= 100000000 Then
            persenPajak = 0.2D
        Else
            persenPajak = 0.3D
        End If

        Dim jumlahPajak As Decimal = pendapatan * persenPajak

        MessageBox.Show("Pajak (" & (persenPajak * 100) & "%) : Rp " & jumlahPajak.ToString("N0"))
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
        Form1.Show()
    End Sub

End Class