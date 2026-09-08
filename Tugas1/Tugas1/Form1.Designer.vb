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
        picImage = New PictureBox()
        lblRole = New Label()
        cmbRole = New ComboBox()
        lblNama = New Label()
        lblNIM = New Label()
        txtNama = New TextBox()
        txtNIM = New TextBox()
        btnLogin = New Button()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(294, 28)
        picImage.Name = "picImage"
        picImage.Size = New Size(150, 147)
        picImage.SizeMode = PictureBoxSizeMode.Zoom
        picImage.TabIndex = 0
        picImage.TabStop = False
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(214, 199)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(50, 25)
        lblRole.TabIndex = 1
        lblRole.Text = "Role:"
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Staff", "Manager"})
        cmbRole.Location = New Point(294, 196)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(182, 33)
        cmbRole.TabIndex = 2
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(214, 263)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(63, 25)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama:"
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(214, 319)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(50, 25)
        lblNIM.TabIndex = 4
        lblNIM.Text = "NIM:"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(294, 257)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 5
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(294, 319)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(150, 31)
        txtNIM.TabIndex = 6
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(306, 376)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 34)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogin)
        Controls.Add(txtNIM)
        Controls.Add(txtNama)
        Controls.Add(lblNIM)
        Controls.Add(lblNama)
        Controls.Add(cmbRole)
        Controls.Add(lblRole)
        Controls.Add(picImage)
        Name = "Form1"
        Text = "Form1"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picImage As PictureBox
    Friend WithEvents lblRole As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNIM As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents btnLogin As Button

End Class
