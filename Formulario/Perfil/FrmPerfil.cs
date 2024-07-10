using MySql.Data.MySqlClient;
using ProjectMaster.DAO;
using ProjectMaster.Formulario.Principal;
using ProjectMaster.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMaster.Formulario.Perfil
{
    public partial class FrmPerfil : Form
    {
        private FrmPrincipal frmPrincipal;
        private Usuario usuario;
        private UsuarioDAO usuarioDAO;

        private List<TextBox> textbox;
        private List<Label> labels;
        private List<RadioButton> radioButtons;
        private bool cambioPrivacidad;

        private Usuario usuarioCambiado;
        private string cambios;

        string codigoEliminar;
        bool panelEliminarVisible = false;

        public FrmPerfil(FrmPrincipal frmP, MySqlConnection conexion2, Usuario user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            frmPrincipal = frmP;

            usuarioDAO = new UsuarioDAO(conexion2);
            usuario = user;
            usuarioCambiado = new Usuario();
            textbox = new List<TextBox>();
            textbox.Add(TxtNombreUsuario);
            textbox.Add(TxtPassword);
            textbox.Add(TxtCorreo);
            textbox.Add(TxtTelf);
            textbox.Add(TxtNombre);

            labels = new List<Label>();
            labels.Add(LblNombreUsuario);
            labels.Add(LblPassword);
            labels.Add(LblCorreo);
            labels.Add(LblTelf);
            labels.Add(LblNombre);

            radioButtons = new List<RadioButton>();
            radioButtons.Add(RdbPublico);
            radioButtons.Add(RdbPrivado);
            cambioPrivacidad = usuario.privacidad;
            cambios = "";

            escribirPerfil();
            mostrarAvatar(usuario.codAvatar);
        }

        // --------------------------------------------------------------------------
        // Escribir la información del perfil:
        private void escribirPerfil()
        {

            // Mostramos el nombre del usuario:
            if (usuario.nombreReal == null)
                LblPerfil.Text = "Perfil de " + usuario.nombreUsuario;
            else
                LblPerfil.Text = "Perfil de " + usuario.nombreReal;

            // Etiquetas visibles y Textbox invisibles:
            foreach (TextBox t in textbox)
                t.Visible = false;
            foreach (Label l in labels)
                l.Visible = true;

            // Datos:
            LblNombreUsuario.Text = usuario.nombreUsuario;
            LblCorreo.Text = usuario.correo;
            bool privacidad = usuario.privacidad;
            LblTelf.Text = usuario.telefono.ToString();
            LblNombre.Text = usuario.nombreReal;
            if (usuario.telefono == null || usuario.telefono == 0)
            {
                LblTelf.Visible = false;
                TxtTelf.Visible = true;
            }
            if (usuario.nombreReal == null)
            {
                LblNombre.Visible = false;
                TxtNombre.Visible = true;
            }
            if (privacidad)
                RdbPrivado.Checked = true;
            else
                RdbPublico.Checked = true;

            CboAvatares.SelectedIndex = usuario.codAvatar - 1;
        }

        // --------------------------------------------------------------------------
        // Mostrar avatar:
        private void mostrarAvatar(int codAvatar)
        {
            PcbAvatar.Image = Usuario.obtenerAvatar(codAvatar);
        }

        // --------------------------------------------------------------------------
        // Al hacer click en las etiquetas, se cambia a textbox:
        private void Label_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            int indice = labels.IndexOf(l);
            l.Visible = false;
            textbox[indice].Visible = true;
            // Ponemos la info en el textbox salvo que sea la contraseña:
            if (indice != 1)
                textbox[indice].Text = l.Text;
        }

        // -----------------------------------------------------------------------------------------------------------------------
        // Método para confirmar los cambios: verificará que sean cambios válidos, y después muestra el botón de guardar:
        private void BtnConfirmarCambios_Click(object sender, EventArgs e)
        {
            // Si no hay ningún campo rellenado, no hace nada:
            if (!hayCambios())
            {
                MessageBox.Show("No has rellenado ningún campo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                borrarWarnings();
            }
            else
            {
                // Verificamos que los cambios sean válidos:
                if (verificarDatos())
                {
                    LblConfirmarContraseña.Visible = true;
                    TxtConfirmarContraseña.Visible = true;
                    BtnGuardar.Visible = true;
                    BtnCancelar.Visible = true;
                    iconButton1.Visible = true;
                    iconButton2.Visible = true;
                    BtnConfirmarCambios.Enabled = false;
                    habilitarTextos(false);
                }
            }
        }

        // -----------------------------------------------------------------------------------------------------------------------
        // Comprueba si hay algún campo que haya cambiado:
        private bool hayCambios()
        {
            bool hayCambios = false;

            // Para cada textbox:
            foreach (TextBox t in textbox)
            {
                // Si es visible:
                if (t.Visible)
                {
                    // Si es la contraseña:
                    if (textbox.IndexOf(t) == 1)
                    {
                        // Si se ha escrito algo:
                        if (t.Text.Length > 0)
                        {
                            hayCambios = true;
                        }
                    }
                    // Los demás campos:
                    else
                    {
                        // Si su texto coincide con lo que había (y no es la contraseña):
                        if (!t.Text.ToLower().Equals(labels[textbox.IndexOf(t)].Text.ToLower()))
                        {
                            hayCambios = true;
                        }
                    }
                }
            }

            // Cambios en la privacidad:
            if (cambioPrivacidad != usuario.privacidad)
                hayCambios = true;

            // Cambio de avatar:
            if (CboAvatares.SelectedIndex + 1 != usuario.codAvatar)
                hayCambios = true;

            return hayCambios;
        }

        // -----------------------------------------------------------------------------------------------------------------------
        // Verificar datos:
        private bool verificarDatos()
        {
            // --- Verificación de nombre de usuario: ---
            bool correcto = true;
            usuarioCambiado = usuario.copiarInfo(usuarioCambiado);

            // Si ha cambiado el nombre:
            if (TxtNombreUsuario.Visible && !TxtNombreUsuario.Text.ToLower().Equals(LblNombreUsuario.Text.ToLower()))
            {
                if (usuarioDAO.coincideNombreOCorreo(TxtNombreUsuario.Text, usuario.id))
                {
                    // El nombre ya existe:
                    LblUsuarioExiste.Visible = true;
                    correcto = false;
                }
                else
                {
                    usuarioCambiado.nombreUsuario = TxtNombreUsuario.Text;
                    cambios += "NOMBRE DE USUARIO: " + TxtNombreUsuario.Text + "\n";
                    LblUsuarioExiste.Visible = false;
                }
            }
            else
                LblUsuarioExiste.Visible = false;

            // ------ 
            // - Verificación de correo electrónico:
            if (TxtCorreo.Visible && !TxtCorreo.Text.ToLower().Equals(LblCorreo.Text.ToLower()))
            {
                // Validamos el formato del correo:
                if (Usuario.validarCorreo(TxtCorreo.Text))
                {
                    LblCorreoNoValido.Visible = false;
                    // Validamos en la BD para buscar coincidencias:
                    if (usuarioDAO.coincideNombreOCorreo(TxtCorreo.Text, usuario.id))
                    {
                        // El correo ya existe:
                        LblCorreoExiste.Visible = true;
                        correcto = false;
                    }
                    else
                    {
                        usuarioCambiado.correo = TxtCorreo.Text;
                        cambios += "CORREO: " + TxtCorreo.Text + "\n";
                        LblCorreoExiste.Visible = false;
                    }
                }
                else
                {
                    // No es válido el formato:
                    LblCorreoNoValido.Visible = true;
                    correcto = false;
                }
            }
            else
            {
                LblCorreoExiste.Visible = false;
                LblCorreoNoValido.Visible = false;
            }

            // ------ 
            // - Verificación de contraseña:
            if (TxtPassword.Text.Length > 0)
            {
                if (Usuario.validarPassword(TxtPassword.Text))
                {
                    LblPasswordNoValida.Visible = false;
                    // Vemos si la contraseña introducida es la antigua:
                    if (BCrypt.Net.BCrypt.Verify(TxtPassword.Text, usuario.password))
                    {
                        LblContraseñaIgual.Visible = true;
                        correcto = false;
                    }
                    else
                    {
                        usuarioCambiado.password = BCrypt.Net.BCrypt.HashPassword(TxtPassword.Text);
                        cambios += "CONTRASEÑA ACTUALIZADA" + "\n";
                        LblContraseñaIgual.Visible = false;
                    }
                }
                else
                {
                    LblPasswordNoValida.Visible = true;
                    correcto = false;
                }

            }
            else
            {
                LblContraseñaIgual.Visible = false;
                LblPasswordNoValida.Visible = false;
            }

            // ------ 
            // - Verificación de número:
            if (TxtTelf.Visible && !TxtTelf.Text.Equals(LblTelf.Text) && TxtTelf.Text.Length > 0)
            {
                int telefono;
                if (TxtTelf.Text.Length != 9 || !TxtTelf.Text.StartsWith("6") || !int.TryParse(TxtTelf.Text, out telefono))
                {
                    LblTelefonoNoValido.Visible = true;
                    correcto = false;
                }
                else
                {
                    usuarioCambiado.telefono = Convert.ToInt32(TxtTelf.Text);
                    cambios += "TELÉFONO: " + TxtTelf.Text + "\n";
                    LblTelefonoNoValido.Visible = false;
                }
            }
            else
            {
                LblTelefonoNoValido.Visible = false;
            }

            // ------ Verificación de nombre:
            if (TxtNombre.Text.Length > 0)
            {
                usuarioCambiado.nombreReal = TxtNombre.Text;
                cambios += "NOMBRE REAL: " + TxtNombre.Text + "\n";
            }

            // -- Verificacion de privacidad:
            usuarioCambiado.privacidad = cambioPrivacidad;
            if (usuario.privacidad != cambioPrivacidad && cambioPrivacidad)
            {
                // Se ha cambiado a privado:
                cambios += "PERFIL: PRIVADO" + "\n";
            }
            else if (usuario.privacidad != cambioPrivacidad && !cambioPrivacidad)
            {
                // Se ha cambiado a público:
                cambios += "PERFIL: PÚBLICO" + "\n";
            }

            // Cambio de avatar: 
            usuarioCambiado.codAvatar = CboAvatares.SelectedIndex + 1;
            if (usuarioCambiado.codAvatar != usuario.codAvatar)
            {
                cambios += "AVATAR: " + CboAvatares.SelectedItem;
            }


            return correcto;
        }

        // -----------------------------------------------------------------------------------------------------------------------
        // Cambiar Avatar:
        private void CboAvatares_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarAvatar(CboAvatares.SelectedIndex + 1);
        }

        // -----------------------------------------------------------------------------------------------------------------------
        // Habilita o deshabilita los Textbox:
        private void habilitarTextos(bool accion)
        {
            foreach (TextBox t in textbox)
            {
                t.Enabled = accion;
            }
            RdbPrivado.Enabled = accion;
            RdbPublico.Enabled = accion;
            CboAvatares.Enabled = accion;
        }

        // -----------------------------------------------------------------------------------------------------------------------
        // Quita de la vista las label de aviso:
        private void borrarWarnings()
        {
            LblUsuarioExiste.Visible = false;
            LblCorreoExiste.Visible = false;
            LblCorreoNoValido.Visible = false;
            LblContraseñaIgual.Visible = false;
            LblPasswordNoValida.Visible = false;
            LblTelefonoNoValido.Visible = false;
        }


        // -----------------------------------------------------------------------------------------------------------------------
        // Volver al Área Principal:
        private void IcbVolverInicio_Click(object sender, EventArgs e)
        {
            if (hayCambios())
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres volver? Se perderá la información no guardada", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.OK)
                {
                    frmPrincipal.iniciarArea();
                    frmPrincipal.cerrarPerfil();
                }
            }
            else
            {
                frmPrincipal.iniciarArea();
                frmPrincipal.cerrarPerfil();
            }
        }

        // -----------------------------------------------------------------------------------------------------------------------
        // Cambio en la selección de privacidad:
        private void privacidad_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            bool estado = rb.Checked;
            foreach (RadioButton r in radioButtons)
            {
                if (!r.Equals(rb))
                    r.Checked = !estado;
            }
            if (RdbPrivado.Checked)
                cambioPrivacidad = true;
            else
                cambioPrivacidad = false;
        }
        private void limpiarCampos()
        {
            foreach (TextBox t in textbox)
            {
                t.Text = "";
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            habilitarTextos(true);
            BtnConfirmarCambios.Enabled = true;
            limpiarCampos();
            BtnGuardar.Visible = false;
            TxtConfirmarContraseña.Visible = false;
            BtnCancelar.Visible = false;
            LblConfirmarContraseña.Visible = false;
            iconButton1.Visible = false;
            iconButton2.Visible = false;
            cambios = "";
            escribirPerfil();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string password = TxtConfirmarContraseña.Text;

            // Si se ha introducido la contraseña:
            if (password.Length > 0)
            {
                // Verificamos si es la contraseña correcta:
                if (BCrypt.Net.BCrypt.Verify(password, usuario.password))
                {
                    usuarioDAO.actualizarUsuario(usuarioCambiado);
                    usuario = usuarioCambiado.copiarInfo(usuario);

                    // Mensaje al usuario de los cambios realizados:
                    if (cambios.Length > 0)
                    {
                        MessageBox.Show(cambios, "USUARIO ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();
                        LblConfirmarContraseña.Visible = false;
                        TxtConfirmarContraseña.Visible = false;
                        BtnGuardar.Visible = false;
                        BtnConfirmarCambios.Enabled = true;
                        BtnCancelar.Visible = false;

                        // Al terminar de editar el usuario redirigimos a la vista Area
                        frmPrincipal.crearArea(usuario, 0);
                        frmPrincipal.cerrarPerfil();
                    }

                } // if - contraseña correcta
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            } // if - contraseña vacía
            else
            {
                MessageBox.Show("Introduce tu contraseña actual para confirmar los cambios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEliminarCuenta_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que eliminar tu cuenta " + usuario.nombreUsuario + "?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.OK)
            {
                codigoEliminar = Usuario.generarCodigoAlfanumericoAleatorio();
                Usuario.enviarCorreoVerificacionEliminarCuenta(usuario, codigoEliminar);
                panelEliminarVisible = true;
                LblCodigoEliminar.Visible = true;
                TxtCodigoEliminar.Visible = true;
                BtnConfirmarCodigoEliminar.Visible = true;
                BtnCancelarEliminacion.Visible = true;
                IcbVerCodigoEliminar.Visible = true;
            }
            else
            {
                panelEliminarVisible = false;
            }
            AjustarPaneles();
        }

        private void BtnConfirmarCodigoEliminar_Click(object sender, EventArgs e)
        {
            if (Usuario.confirmarCodigoAlfanumericoPassword(codigoEliminar, TxtCodigoEliminar.Text))
            {
                MessageBox.Show("Usuario " + usuario.nombreUsuario + " eliminado.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                usuarioDAO.eliminarUsuario(usuario);

                frmPrincipal.crearInicio();
                frmPrincipal.cerrarPerfil();
                frmPrincipal.cerrarArea();
            }
            else
            {
                MessageBox.Show("Código introducido incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IcbVerCodigoEliminar_Click(object sender, EventArgs e)
        {
            TxtCodigoEliminar.UseSystemPasswordChar = false;
            IcbVerCodigoEliminar.Visible = false;
            IcbNoVerCodigoEliminar.Visible = true;
        }

        private void IcbNoVerCodigoEliminar_Click(object sender, EventArgs e)
        {
            TxtCodigoEliminar.UseSystemPasswordChar = true;
            IcbVerCodigoEliminar.Visible = true;
            IcbNoVerCodigoEliminar.Visible = false;
        }

        private void TxtConfirmarContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnGuardar_Click(sender, e);
            }
        }

        private void TxtCodigoEliminar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnConfirmarCodigoEliminar_Click(sender, e);
            }
        }

       

        private void IcbNoVerPas_Click(object sender, EventArgs e)
        {
            if (!TxtPassword.Enabled)
            {
                TxtConfirmarContraseña.UseSystemPasswordChar = true;
                iconButton2.Visible = true;
                iconButton1.Visible = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
                IcbVerPas.Visible = true;
                IcbNoVerPas.Visible = false;
            }
            
        }

        private void IcbVerPas_Click(object sender, EventArgs e)
        {
            if (!TxtPassword.Enabled)
            {
                TxtConfirmarContraseña.UseSystemPasswordChar = false;
                iconButton1.Visible = true;
                iconButton2.Visible = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = false;
                IcbVerPas.Visible = false;
                IcbNoVerPas.Visible = true;
            }
        }

        private void AjustarPaneles()
        {
            // Center LblTitulo
            LblTitulo.Left = (panelTop.Width - LblTitulo.Width) / 2;
            LblTitulo.Top = (panelTop.Height - LblTitulo.Height) / 2;

            // Align IconButton to the left with margin
            IcbVolverInicio.Left = 40;
            IcbVolverInicio.Top = (panelTop.Height - IcbVolverInicio.Height) / 2;

            // Align BtnEliminarCuenta to the right with margin
            BtnEliminarCuenta.Left = panelTop.Width - BtnEliminarCuenta.Width - 40; // Posición a la derecha con un margen de 40
            BtnEliminarCuenta.Top = (panelTop.Height - BtnEliminarCuenta.Height) / 2;

            if (panelEliminarVisible)
            {
                panelEliminar.Visible = true;
                panelEliminar.Top =  panelDatos.Height/ 2 - panelDatos.Top;
                panelEliminar.Left = (panelDatos.Width - panelEliminar.Width)/ 2;
                
            }
            else
            {
                panelEliminar.Visible = false;

                // Center panelDatos
                panelDatos.Left = (PanelPerfil.ClientSize.Width - panelDatos.Width) / 2;
                panelDatos.Top = panelTop.Height + 3;
            }
        }

            private void FrmPerfil_Resize(object sender, EventArgs e)
        {
            AjustarPaneles();

        }

        private void BtnCancelarEliminacion_Click(object sender, EventArgs e)
        {
            panelEliminarVisible = false;
            AjustarPaneles();
        }

    }
}
