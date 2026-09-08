<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pajak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblLimaJuta = New Label()
        lblTigaPuluhJuta = New Label()
        lblSeratusJuta = New Label()
        lblPendapatan = New Label()
        lblRupiah = New Label()
        txtPendapatan = New TextBox()
        btnHitung = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblLimaJuta
        ' 
        lblLimaJuta.AutoSize = True
        lblLimaJuta.Location = New Point(294, 111)
        lblLimaJuta.Name = "lblLimaJuta"
        lblLimaJuta.Size = New Size(321, 25)
        lblLimaJuta.TabIndex = 0
        lblLimaJuta.Text = "Pendapatan lebih dari 5 juta, 10% Pajak"
        ' 
        ' lblTigaPuluhJuta
        ' 
        lblTigaPuluhJuta.AutoSize = True
        lblTigaPuluhJuta.Location = New Point(294, 151)
        lblTigaPuluhJuta.Name = "lblTigaPuluhJuta"
        lblTigaPuluhJuta.Size = New Size(331, 25)
        lblTigaPuluhJuta.TabIndex = 1
        lblTigaPuluhJuta.Text = "​Pendapatan lebih dari 30 juta, 20% Pajak"
        ' 
        ' lblSeratusJuta
        ' 
        lblSeratusJuta.AutoSize = True
        lblSeratusJuta.Location = New Point(294, 200)
        lblSeratusJuta.Name = "lblSeratusJuta"
        lblSeratusJuta.Size = New Size(341, 25)
        lblSeratusJuta.TabIndex = 2
        lblSeratusJuta.Text = "​Pendapatan lebih dari 100 juta, 30% Pajak"
        ' 
        ' lblPendapatan
        ' 
        lblPendapatan.AutoSize = True
        lblPendapatan.Location = New Point(341, 253)
        lblPendapatan.Name = "lblPendapatan"
        lblPendapatan.Size = New Size(190, 25)
        lblPendapatan.TabIndex = 3
        lblPendapatan.Text = "Masukkan Pendapatan"
        ' 
        ' lblRupiah
        ' 
        lblRupiah.AutoSize = True
        lblRupiah.Location = New Point(341, 299)
        lblRupiah.Name = "lblRupiah"
        lblRupiah.Size = New Size(38, 25)
        lblRupiah.TabIndex = 4
        lblRupiah.Text = "Rp."
        ' 
        ' txtPendapatan
        ' 
        txtPendapatan.Location = New Point(385, 299)
        txtPendapatan.Name = "txtPendapatan"
        txtPendapatan.Size = New Size(150, 31)
        txtPendapatan.TabIndex = 5
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(402, 336)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(112, 34)
        btnHitung.TabIndex = 6
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(402, 387)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(112, 34)
        btnKeluar.TabIndex = 7
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' pajak
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnKeluar)
        Controls.Add(btnHitung)
        Controls.Add(txtPendapatan)
        Controls.Add(lblRupiah)
        Controls.Add(lblPendapatan)
        Controls.Add(lblSeratusJuta)
        Controls.Add(lblTigaPuluhJuta)
        Controls.Add(lblLimaJuta)
        Name = "pajak"
        Text = "pajak"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLimaJuta As Label
    Friend WithEvents lblTigaPuluhJuta As Label
    Friend WithEvents lblSeratusJuta As Label
    Friend WithEvents lblPendapatan As Label
    Friend WithEvents lblRupiah As Label
    Friend WithEvents txtPendapatan As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnKeluar As Button
End Class
