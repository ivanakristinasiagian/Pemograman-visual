Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNama.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtKom.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTampilkan_Click.Click
        MessageBox.Show("Halo Selamat Datang ! " & vbCrLf &
                        "Nama : " & txtNama.Text & vbCrLf &
                        "Nim : " & txtNim.Text & vbCrLf &
                        "Kom : " & txtKom.Text
    )
    End Sub

    Private Sub btnKeluar_Click_Click(sender As Object, e As EventArgs) Handles btnKeluar_Click.Click
        Me.Close()
    End Sub

    Private Sub txtHapus_Click_Click(sender As Object, e As EventArgs) Handles txtHapus_Click.Click
        txtNama.Clear()
        txtNim.Clear()
        txtKom.Clear()
    End Sub
End Class
