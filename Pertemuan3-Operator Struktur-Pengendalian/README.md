# Pertemuan 3: Operator, Struktur Pengendalian, dan Validasi Input

Repository ini mendokumentasikan materi perkuliahan, implementasi logika program, serta konfigurasi praktikum pada **Pertemuan 3** mata kuliah Pemrograman Visual.

---

## 📌 Ringkasan Konsep Dasar

### 1. Tiga Pilar Komponen Visual
* **Properti (*Property*):** Karakteristik atau atribut dari sebuah kontrol (contoh: `Text`, `Name`, `Visible`, `Size`).
* **Metode (*Method*):** Perintah atau tindakan bawaan objek (contoh: `Focus()`, `Clear()`, `Show()`).
* **Event:** Respon kontrol terhadap aksi tertentu dari pengguna (contoh: `btnInput_Click`, `txtNilai_KeyPress`, `Form_Load`).

### 2. Operator & Struktur Pengendalian
* **Operator Penugasan (*Assignment*):** Memberikan nilai ke variabel (`=`, `+=`, `-=`).
* **Operator Perbandingan & Logika:** Membandingkan nilai (`=`, `<>`, `>`, `<`, `>=`, `<=`) dan mengevaluasi logika (`And`, `Or`, `Not`, `AndAlso`, `OrElse`).
* **Ekspresi & Percabangan:** Menentukan alur program menggunakan `If...Then...Else` serta `Select Case` (*Switch Statement*).
* **Operator Ternary (Kondisional Satu Baris):** Menggunakan fungsi bawaan `If(kondisi, nilai_benar, nilai_salah)`.

---

## ⚙️ Konfigurasi & Standar Visual Studio

| Item | Standar / Konfigurasi |
|:---|:---|
| **Shortcut Toolbox** | Tekan `Ctrl + Alt + X` untuk membuka jendela komponen/kontrol. |
| **Konvensi Penamaan Kontrol** | Menggunakan format *camelCase* (contoh: `btnInput`, `txtNilai`, `picBoxPreview`). |
| **Penamaan Event Handler** | Mengikuti struktur `[NamaKontrol]_[NamaEvent]` (contoh: `btnInput_Click`). |
| **Eksekusi & Build** | Menggunakan mode **Debugging** (`F5`) untuk pengujian alur logika. |
| **Pengaturan Aset Gambar (`PictureBox`)** | Pada jendela *Properties* file gambar, set **Copy to Output Directory** ke **`Copy if newer`** (bukan *Copy always*). |

---

## 💻 Implementasi Kode Program (`Form1.vb`)

Program ini mengimplementasikan validasi input karakter huruf secara langsung (*real-time*), operator ternary, serta percabangan multi-kondisi.

```vb
Public Class Form1

    ' Event Handler: Menangani klik tombol Input / Proses
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim inputTeks As String = txtNilai.Text.Trim()

        ' Validasi kelengkapan teks
        If String.IsNullOrEmpty(inputTeks) Then
            MessageBox.Show("Input tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNilai.Focus()
            Return
        End If

        ' Implementasi Operator Ternary
        Dim statusPanjang As String = If(inputTeks.Length > 5, "Teks Panjang", "Teks Pendek")

        ' Implementasi Percabangan (Select Case / Switch Statement)
        Dim kategori As String
        Select Case inputTeks.ToUpper()
            Case "A", "B", "C"
                kategori = "Kategori Utama"
            Case "D", "E"
                kategori = "Kategori Tambahan"
            Case Else
                kategori = "Kategori Umum"
        End Select

        ' Menampilkan hasil pemrosesan
        MessageBox.Show($"Data berhasil diproses!" & vbCrLf &
                        $"Status: {statusPanjang}" & vbCrLf &
                        $"Kategori: {kategori}", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Event Handler: Validasi tombol keyboard (Hanya menerima huruf / IsLetter)
    Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress
        ' Membatasi input agar hanya huruf (IsLetter) dan tombol kontrol seperti Backspace (IsControl) yang diizinkan
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True ' Batalkan/abaikan penekanan tombol angka & simbol
        End If
    End Sub

End Class
