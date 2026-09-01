<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblNama = New Label()
        lblNim = New Label()
        lblKom = New Label()
        txtNama = New TextBox()
        txtNim = New TextBox()
        txtKom = New TextBox()
        btnTampilkan_Click = New Button()
        txtHapus_Click = New Button()
        btnKeluar_Click = New Button()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(243, 44)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(68, 25)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama :"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(255, 100)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(54, 25)
        lblNim.TabIndex = 1
        lblNim.Text = "Nim :"
        ' 
        ' lblKom
        ' 
        lblKom.AutoSize = True
        lblKom.Location = New Point(253, 156)
        lblKom.Name = "lblKom"
        lblKom.Size = New Size(58, 25)
        lblKom.TabIndex = 2
        lblKom.Text = "Kom :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(334, 45)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 3
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(334, 100)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(150, 31)
        txtNim.TabIndex = 4
        ' 
        ' txtKom
        ' 
        txtKom.Location = New Point(334, 154)
        txtKom.Name = "txtKom"
        txtKom.Size = New Size(150, 31)
        txtKom.TabIndex = 5
        ' 
        ' btnTampilkan_Click
        ' 
        btnTampilkan_Click.Location = New Point(185, 233)
        btnTampilkan_Click.Name = "btnTampilkan_Click"
        btnTampilkan_Click.Size = New Size(112, 34)
        btnTampilkan_Click.TabIndex = 6
        btnTampilkan_Click.Text = "Tampilkan"
        btnTampilkan_Click.UseVisualStyleBackColor = True
        ' 
        ' txtHapus_Click
        ' 
        txtHapus_Click.Location = New Point(334, 233)
        txtHapus_Click.Name = "txtHapus_Click"
        txtHapus_Click.Size = New Size(112, 34)
        txtHapus_Click.TabIndex = 7
        txtHapus_Click.Text = "Hapus"
        txtHapus_Click.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar_Click
        ' 
        btnKeluar_Click.Location = New Point(501, 233)
        btnKeluar_Click.Name = "btnKeluar_Click"
        btnKeluar_Click.Size = New Size(112, 34)
        btnKeluar_Click.TabIndex = 8
        btnKeluar_Click.Text = "Keluar"
        btnKeluar_Click.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnKeluar_Click)
        Controls.Add(txtHapus_Click)
        Controls.Add(btnTampilkan_Click)
        Controls.Add(txtKom)
        Controls.Add(txtNim)
        Controls.Add(txtNama)
        Controls.Add(lblKom)
        Controls.Add(lblNim)
        Controls.Add(lblNama)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents lblKom As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents txtKom As TextBox
    Friend WithEvents btnTampilkan_Click As Button
    Friend WithEvents txtHapus_Click As Button
    Friend WithEvents btnKeluar_Click As Button

End Class
