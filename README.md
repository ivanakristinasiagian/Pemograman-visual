Tugas Pertemuan 2: Aplikasi Profil Mahasiswa

    MessageBox.Show(pesan)
End Sub# Tugas Pertemuan 2 - Aplikasi Profil Mahasiswa

## Deskripsi

Aplikasi Profil Mahasiswa merupakan aplikasi sederhana yang dibuat untuk menampilkan data mahasiswa berupa **Nama, NIM, dan KOM**. Aplikasi ini menggunakan beberapa komponen GUI seperti Label, TextBox, dan Button.

## Komponen yang Digunakan

### 1. Label

Label digunakan untuk menampilkan teks atau judul yang bersifat statis, seperti:

* `NAMA :`
* `NIM :`
* `KOM :`

### 2. TextBox

TextBox digunakan sebagai tempat untuk memasukkan data mahasiswa.

Nama komponen TextBox pada Properties disesuaikan agar lebih mudah digunakan dalam kodingan:

* `txtNama` → untuk memasukkan Nama
* `txtNIM` → untuk memasukkan NIM
* `txtKOM` → untuk memasukkan KOM

### 3. Button

Button digunakan untuk menjalankan perintah tertentu. Terdapat tiga tombol dalam aplikasi, yaitu:

* **Tampilkan** → mengambil data dari TextBox dan menampilkannya dalam MessageBox.
* **HAPUS** → mengosongkan kembali seluruh TextBox.
* **Keluar** → menutup aplikasi.

## Logika Kodingan

Ketika tombol **Tampilkan** ditekan, program akan mengambil data yang telah dimasukkan pada masing-masing TextBox kemudian menggabungkannya menjadi sebuah pesan.

```vb
Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
    Dim pesan As String = "Halo Selamat Datang !" & vbCrLf &
                          "Nama : " & txtNama.Text & vbCrLf &
                          "NIM  : " & txtNIM.Text & vbCrLf &
                          "KOM  : " & txtKOM.Text

    MessageBox.Show(pesan)
End Sub
```

## Cara Kerja Aplikasi

1. User memasukkan **Nama** pada TextBox Nama.
2. User memasukkan **NIM** pada TextBox NIM.
3. User memasukkan **KOM** pada TextBox KOM.
4. User menekan tombol **Tampilkan**.
5. Program mengambil data dari ketiga TextBox.
6. Data digabungkan menjadi satu pesan.
7. Pesan ditampilkan menggunakan `MessageBox.Show()`.

## Contoh Hasil

Jika data yang dimasukkan:

```text
Nama : Ivana Kristina
NIM  : 241712021
KOM  : TI-A1
```

Maka akan muncul pesan:

```text
Halo Selamat Datang !
Nama : Ivana Kristina
NIM  : 241712021
KOM  : TI-A1
```

## Kesimpulan

Aplikasi Profil Mahasiswa merupakan aplikasi GUI sederhana yang menerapkan penggunaan **Label, TextBox, dan Button** pada Visual Basic. Aplikasi ini dapat menerima input data mahasiswa, menampilkan data tersebut dalam bentuk pesan, menghapus input, serta menutup aplikasi.
