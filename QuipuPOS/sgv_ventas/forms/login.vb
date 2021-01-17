Imports libreriaseguridad
Imports libreriaVentas
Imports MySql.Data.MySqlClient


Public Class Login
    'para validar el separador decimal
    Private sepDecimal As Char
    Dim Arrastre As Boolean

    Private Sub Login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            End
        End If
    End Sub
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblPeriodo.Text = general.devuelvefechaImpresion(pFechaSystem)
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Dim mTC As New TipoCambio
        pTC = mTC.recupera(0, pFechaSystem)
        Lbltipcambio.Text = "Tipo de Cambio :" & mTC.recupera(0, pFechaSystem)
        txtClave.Focus()
    End Sub
    Private Sub cmdContinuar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ingresaSystem()
    End Sub
    Sub ingresaSystem()
        Dim mseguridad As New seguridad
        If usuario.ingresoSistema(txtUsuario.Text, txtClave.Text) = True Then
            pNombreUser = IIf(txtUsuario.Text = "", usuario.recuperaNombreUsuario(txtClave.Text), txtUsuario.Text)
            pCuentaUser = IIf(txtUsuario.Text = "", usuario.recuperaCuentaUsuario(txtClave.Text), txtUsuario.Text)
            pNivelUser = usuario.recuperaNivelUsuario(pCuentaUser)
            pAlmaUser = usuario.recuperaAlmacenUsuario(pCuentaUser)
            pDatosUser = usuario.recuperaDatosUsuario(pCuentaUser)
            pPerfil = usuario.recuperaPerfilUsuario(pCuentaUser)
            Dim com As New MySqlCommand("select c.*,e.licencia from configuracion c inner join empresa e on c.cod_emp=e.cod_emp where e.activo='1'", dbConex)
            Dim dr As MySqlDataReader
            dr = com.ExecuteReader
            If dr.HasRows = True Then
                While dr.Read
                    pIGV = dr("igv")
                    pEmpresa = dr("cod_emp")
                    plicencia = dr("licencia")
                    pNempresa = dr("nom_emp")
                    pDirEmpresa = dr("dir_emp")
                    pDecimales = dr("nros_decimales")
                    pDiasModificarIngreso = dr("dias_modificar_ingreso")
                    pDiasModificarPedido = dr("dias_modificar_pedido")
                    pDiasModificarSalida = dr("dias_modificar_salida")
                    pPreciosIncIGV = dr("precios_inc_igv")
                    pDespachoXprecioVenta = dr("despacho_x_pre_venta")
                    pDespachoXtipoCliente = dr("despacho_x_tipo_cliente")
                    pModoPedidos = dr("modo_pedidos")
                    pDiasModificarInventario = dr("dias_modificar_inventario")
                    pMoneda = dr("moneda")
                    pMonedaAbr = dr("monedaAbr")
                    pCatalogoXalmacen = dr("catalogo_x_almacen")
                    pvistaprevia = dr("vistaprevia_rpt")
                    pfechaservidor = dr("fechaServidor")
                    pLogo = dr("Logo")
                    pImpuestoXarticulo = dr("impuesto_x_articulo")
                    pDiasModificarTrans = dr("dias_modificar_trans")
                    pDespachoStock0 = dr("despacho_stock0")
                    pDiasModificarBaja = dr("dias_modificar_baja")
                End While
                Dim ds As New DataSet, I As Integer, cod_smenu As String
                Dim musuario As New usuario, activo As Boolean
                ds = musuario.permisos(pCuentaUser)
                If ds.Tables("permisos").Rows.Count > 0 Then
                    For I = 0 To ds.Tables("permisos").Rows.Count - 1
                        cod_smenu = ds.Tables("permisos").Rows(I).Item("cod_smenu").ToString()
                        activo = ds.Tables("permisos").Rows(I).Item("activo").ToString()
                        asignaPermisos(cod_smenu, activo)
                    Next
                End If
            Else
                MessageBox.Show("NO es Posible Cargar la Configuración del Sistema...")
                End
            End If
            dr.Close()
            principal.Show()
            Me.Hide()
        Else
            pNombreUser = ""
            pCuentaUser = ""
            MessageBox.Show("Acceso Denegado...", "VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtClave.Text = ""
            txtClave.Focus()
        End If

    End Sub
    Private Sub txtTC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtUsuario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        general.ingresaTexto(txtUsuario)
    End Sub
    Private Sub txtUsuario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        general.saleTexto(txtUsuario)
    End Sub
    Private Sub txtClave_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        general.ingresaTexto(txtClave)
    End Sub
    Private Sub txtClave_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        general.saleTexto(txtClave)
    End Sub
    Private Sub Login_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Arrastre = True
    End Sub
    Dim posY As Int32 = 0
    Dim posX As Int32 = 0
    Private Sub Login_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove, panelSuperior.MouseMove
        If e.Button <> MouseButtons.Left Then
            posX = e.X
            posY = e.Y
        Else
            Left = Left + (e.X - posX)
            Top = Top + (e.Y - posY)
        End If
    End Sub
    Private Sub Login_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Arrastre = False
    End Sub
    Private Sub digitatecla(ByVal codigo As String)
        txtClave.Text = txtClave.Text & codigo
    End Sub
    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            ingresaSystem()
        End If
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ingresaSystem()
    End Sub
    Private Sub btnVerContraseña_Click(sender As Object, e As EventArgs) Handles btnVerContraseña.Click
        txtClave.PasswordChar = ""
        btnVerContraseña.Visible = False
        btnOcultarContraseña.Visible = True
    End Sub
    Private Sub btnOcultarContraseña_Click(sender As Object, e As EventArgs) Handles btnOcultarContraseña.Click
        txtClave.PasswordChar = "*"
        btnOcultarContraseña.Visible = False
        btnVerContraseña.Visible = True
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub
End Class

