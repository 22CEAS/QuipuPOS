<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits sgv_ventas.base

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Lbltipcambio = New System.Windows.Forms.Label()
        Me.LblPeriodo = New System.Windows.Forms.Label()
        Me.btnVerContraseña = New System.Windows.Forms.Button()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnOcultarContraseña = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.panelSuperior = New System.Windows.Forms.Panel()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSuperior.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbltipcambio
        '
        Me.Lbltipcambio.AutoSize = True
        Me.Lbltipcambio.BackColor = System.Drawing.Color.Transparent
        Me.Lbltipcambio.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltipcambio.ForeColor = System.Drawing.Color.Black
        Me.Lbltipcambio.Location = New System.Drawing.Point(252, 295)
        Me.Lbltipcambio.Name = "Lbltipcambio"
        Me.Lbltipcambio.Size = New System.Drawing.Size(69, 17)
        Me.Lbltipcambio.TabIndex = 157
        Me.Lbltipcambio.Text = "Lbltipcambio"
        Me.Lbltipcambio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPeriodo
        '
        Me.LblPeriodo.AutoSize = True
        Me.LblPeriodo.BackColor = System.Drawing.Color.Transparent
        Me.LblPeriodo.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPeriodo.ForeColor = System.Drawing.Color.Black
        Me.LblPeriodo.Location = New System.Drawing.Point(39, 295)
        Me.LblPeriodo.Name = "LblPeriodo"
        Me.LblPeriodo.Size = New System.Drawing.Size(59, 17)
        Me.LblPeriodo.TabIndex = 153
        Me.LblPeriodo.Text = "LblPeriodo"
        Me.LblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnVerContraseña
        '
        Me.btnVerContraseña.AutoSize = True
        Me.btnVerContraseña.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerContraseña.FlatAppearance.BorderSize = 0
        Me.btnVerContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerContraseña.Image = CType(resources.GetObject("btnVerContraseña.Image"), System.Drawing.Image)
        Me.btnVerContraseña.Location = New System.Drawing.Point(341, 145)
        Me.btnVerContraseña.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVerContraseña.Name = "btnVerContraseña"
        Me.btnVerContraseña.Size = New System.Drawing.Size(38, 38)
        Me.btnVerContraseña.TabIndex = 170
        Me.btnVerContraseña.UseVisualStyleBackColor = True
        '
        'pictureBox4
        '
        Me.pictureBox4.Image = CType(resources.GetObject("pictureBox4.Image"), System.Drawing.Image)
        Me.pictureBox4.Location = New System.Drawing.Point(114, 171)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(220, 10)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox4.TabIndex = 169
        Me.pictureBox4.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(115, 115)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(220, 10)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox3.TabIndex = 168
        Me.pictureBox3.TabStop = False
        '
        'txtClave
        '
        Me.txtClave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.ForeColor = System.Drawing.Color.White
        Me.txtClave.Location = New System.Drawing.Point(115, 153)
        Me.txtClave.Margin = New System.Windows.Forms.Padding(2)
        Me.txtClave.MaxLength = 50
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(220, 19)
        Me.txtClave.TabIndex = 167
        Me.txtClave.Text = "1234"
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(69, 148)
        Me.pictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(41, 33)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 166
        Me.pictureBox2.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(69, 89)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(41, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 165
        Me.PictureBox5.TabStop = False
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.White
        Me.txtUsuario.Location = New System.Drawing.Point(115, 95)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsuario.MaxLength = 25
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(220, 19)
        Me.txtUsuario.TabIndex = 164
        Me.txtUsuario.Text = "admin"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Black
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(236, 209)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(166, 50)
        Me.btnSalir.TabIndex = 163
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Black
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(23, 209)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(166, 50)
        Me.btnLogin.TabIndex = 162
        Me.btnLogin.Text = "Entrar"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnOcultarContraseña
        '
        Me.btnOcultarContraseña.AutoSize = True
        Me.btnOcultarContraseña.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOcultarContraseña.FlatAppearance.BorderSize = 0
        Me.btnOcultarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOcultarContraseña.Image = CType(resources.GetObject("btnOcultarContraseña.Image"), System.Drawing.Image)
        Me.btnOcultarContraseña.Location = New System.Drawing.Point(339, 145)
        Me.btnOcultarContraseña.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOcultarContraseña.Name = "btnOcultarContraseña"
        Me.btnOcultarContraseña.Size = New System.Drawing.Size(38, 38)
        Me.btnOcultarContraseña.TabIndex = 171
        Me.btnOcultarContraseña.UseVisualStyleBackColor = True
        Me.btnOcultarContraseña.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(104, -14)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(217, 98)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 1
        Me.PictureBox6.TabStop = False
        '
        'panelSuperior
        '
        Me.panelSuperior.BackColor = System.Drawing.Color.White
        Me.panelSuperior.Controls.Add(Me.PictureBox6)
        Me.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Margin = New System.Windows.Forms.Padding(2)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(440, 67)
        Me.panelSuperior.TabIndex = 161
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(440, 323)
        Me.Controls.Add(Me.btnVerContraseña)
        Me.Controls.Add(Me.pictureBox4)
        Me.Controls.Add(Me.pictureBox3)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnOcultarContraseña)
        Me.Controls.Add(Me.panelSuperior)
        Me.Controls.Add(Me.Lbltipcambio)
        Me.Controls.Add(Me.LblPeriodo)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.Text = "|w"
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSuperior.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblPeriodo As System.Windows.Forms.Label
    Friend WithEvents Lbltipcambio As System.Windows.Forms.Label
    Private WithEvents btnVerContraseña As Button
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents txtClave As TextBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents PictureBox5 As PictureBox
    Private WithEvents txtUsuario As TextBox
    Private WithEvents btnSalir As Button
    Private WithEvents btnLogin As Button
    Private WithEvents btnOcultarContraseña As Button
    Private WithEvents PictureBox6 As PictureBox
    Private WithEvents panelSuperior As Panel
End Class
