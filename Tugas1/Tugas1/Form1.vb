Public Class Form1

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        Dim imageFileName As String = ""

        If cmbRole.Text = "Staff" Then
            imageFileName = "Staff.png"
        ElseIf cmbRole.Text = "Manager" Then
            imageFileName = "Manager.png"
        End If

        If imageFileName <> "" Then
            ' Menggunakan path otomatis menuju folder bin\Debug\Image\
            Dim imagePath As String = IO.Path.Combine(Application.StartupPath, "Image", imageFileName)

            ' Memastikan file gambar ada sebelum dimuat
            If IO.File.Exists(imagePath) Then
                ' Bebaskan memori dari gambar sebelumnya
                If picImage.Image IsNot Nothing Then
                    picImage.Image.Dispose()
                End If

                picImage.Image = Image.FromFile(imagePath)
            End If
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validasi input NIM harus berupa angka
        Dim nim As Long
        If Not Long.TryParse(txtNIM.Text.Trim(), nim) Then
            MessageBox.Show("NIM harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNIM.Focus()
            Return
        End If

        Dim nama As String = txtNama.Text.Trim().ToLower()
        Dim role As String = cmbRole.Text

        ' Pengecekan Kredensial Login
        If role = "Staff" AndAlso nama = "nadya" AndAlso nim = 241712051 Then
            Pajak.Show()
            Me.Hide()
        ElseIf role = "Manager" AndAlso nama = "shata diyaul haq" AndAlso nim = 241712061 Then
            Pajak.Show()
            Me.Hide()
        Else
            MessageBox.Show("Masukkan Akun dengan Benar", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Clear form jika login berhasil
        txtNama.Clear()
        txtNIM.Clear()
    End Sub

    ' Restriksi input NIM hanya boleh angka dan tombol Backspace
    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Restriksi input Nama hanya boleh huruf, spasi, dan tombol Backspace
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

End Class