using MySql.Data.MySqlClient;
using ProjectMaster.DAO;
using ProjectMaster.Formulario.Principal;
using ProjectMaster.Modelo;
using System;
using System.Collections.Generic;

using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;

using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectMaster.Formulario.Loggin
{
    public partial class FrmRegistro : Form
    {
        private FrmPrincipal frmPrincipal;
        private UsuarioDAO usuarioDAO;
        private int avatar;
        public FrmRegistro(FrmPrincipal frmP, MySqlConnection conexion2)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;

            frmPrincipal = frmP;
            usuarioDAO = new UsuarioDAO(conexion2);
            avatar = 0;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = null;
            bool existe = false;
            bool telefonoCorrecto = false;

            string nombre_usuario = TxtUsuario.Text.Trim();
            string correo = TxtEmail.Text.Trim().ToLower();
            string nombre_real = TxtNom.Text.Trim();
            string pas = TxtPas.Text;
            string pas2 = TxtPas2.Text;
            string telefonoTexto = TxtTlf.Text.Trim();
            bool privacidad = false;
            


            // Si el checkox privado esta seleccionado indicaremos su nueva prioridad de perfil
            if (RdbPrivado.Checked)
            {
                privacidad = true;
            }

            // Verificamos que ha rellenado los campos obligatorios
            if (nombre_usuario.Length > 0 && correo.Length > 0 && pas.Length > 0 && pas2.Length > 0)
            {
                if (usuarioDAO.existeUsuarioPorNombre(nombre_usuario))
                {
                    MessageBox.Show("Nombre de usuario existente: " + nombre_usuario, "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    existe = true;
                }
               
                else if (usuarioDAO.existeUsuarioPorCorreo(correo))
                {
                    MessageBox.Show("Correo existente: " + correo, "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    existe = true;
                }

                if (!existe)
                {
                    if (pas.Equals(pas2))
                    {
                        if (Usuario.validarCorreo(correo))
                        {
                            if (Usuario.validarPassword(pas))
                            {
                                string pasEncriptada = BCrypt.Net.BCrypt.HashPassword(pas);
                                usuario = new Usuario(nombre_usuario, correo, pasEncriptada, privacidad, 0);

                                if (!string.IsNullOrEmpty(nombre_real))
                                {
                                    usuario.nombreReal = nombre_real;
                                }

                                if (!string.IsNullOrEmpty(telefonoTexto))
                                {
                                    if (telefonoTexto.Length == 9 && telefonoTexto.StartsWith("6"))
                                    {
                                        int telefono;
                                        if (int.TryParse(telefonoTexto, out telefono))
                                        {
                                            usuario.telefono = telefono;
                                            telefonoCorrecto = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("El telefono debe ser un valor numérico", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El telefono debe contener 9 dígitos y comenzar con el número 6.", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    telefonoCorrecto = true;
                                }

                                if (telefonoCorrecto)
                                {
                                    MessageBox.Show("¡El usuario " + usuario.nombreUsuario + " se ha registrado con éxito! \nPuedes verificar tu registro en tu correo electrónico: "
                                                 + usuario.correo, "¡GENIAL!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    usuario.codAvatar = avatar;

                                    usuarioDAO.insertarUsuario(usuario);
                                    Usuario.enviarCorreoBienvenida(usuario);

                                    frmPrincipal.crearInicio();
                                    frmPrincipal.cerrarRegistro();
                                }
                            }
                            else
                            {
                                MessageBox.Show("La password " + pas + " es incorrecta. Debe tener al menos 6 caracteres, 1 mayúscula y 1 número.", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El correo " + correo + " es incorrecto. El formato debe ser xxx@gmail.com o xxx@hotmail.com", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas son diferentes", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes rellenar todos los campos obligatorios *", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Mostraremos la password o la ocultaremos de forma privada para el usuario
        private void IcbVerPas_Click(object sender, EventArgs e)
        {
            TxtPas.UseSystemPasswordChar = false;
            IcbVerPas.Visible = false;
            IcbNoVerPas.Visible = true;
        }

        private void IcbNoVerPas_Click(object sender, EventArgs e)
        {
            TxtPas.UseSystemPasswordChar = true;
            IcbVerPas.Visible = true;
            IcbNoVerPas.Visible = false;
        }

        private void IcbVerPas2_Click(object sender, EventArgs e)
        {
            TxtPas2.UseSystemPasswordChar = false;
            IcbVerPas2.Visible = false;
            IcbNoVerPas2.Visible = true;
        }


        private void IcbNoVerPas2_Click(object sender, EventArgs e)
        {
            TxtPas2.UseSystemPasswordChar = true;
            IcbVerPas2.Visible = true;
            IcbNoVerPas2.Visible = false;
        }


        private void PcbAvatar1_Click(object sender, EventArgs e)
        {
            avatar = 1;
            desmarcarAvatares();
            PcbAvatar1.BackColor = Color.SteelBlue;
        }

        private void PcbAvatar2_Click(object sender, EventArgs e)
        {
            avatar = 2;
            desmarcarAvatares();
            PcbAvatar2.BackColor = Color.SteelBlue;
        }

        private void PcbAvatar3_Click(object sender, EventArgs e)
        {
            avatar = 3;
            desmarcarAvatares();
            PcbAvatar3.BackColor = Color.SteelBlue;
        }

        private void PcbAvatar4_Click(object sender, EventArgs e)
        {
            avatar = 4;
            desmarcarAvatares();
            PcbAvatar4.BackColor = Color.SteelBlue;
        }

        private void PcbAvatar5_Click(object sender, EventArgs e)
        {
            avatar = 5;
            desmarcarAvatares();
            PcbAvatar5.BackColor = Color.SteelBlue;
        }

        private void PcbAvatar6_Click(object sender, EventArgs e)
        {
            avatar = 6;
            desmarcarAvatares();
            PcbAvatar6.BackColor = Color.SteelBlue;
        }
        private void desmarcarAvatares()
        {
            PcbAvatar1.BackColor = Color.Transparent;
            PcbAvatar2.BackColor = Color.Transparent;
            PcbAvatar3.BackColor = Color.Transparent;
            PcbAvatar4.BackColor = Color.Transparent;
            PcbAvatar5.BackColor = Color.Transparent;
            PcbAvatar6.BackColor = Color.Transparent;
        }
        // Volveremos al formulario de inicio de sesion e indicaremos si va a perder cambios
        private void IcbVolverInicio_Click(object sender, EventArgs e)
        {
            if (camposRellenados())
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres volver? Se perderá la información no guardada", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    frmPrincipal.crearInicio();
                    frmPrincipal.cerrarRegistro();
                }
            }
            else
            {
                // Si no ha introducido datos volveremos a la pagina de inicio directamente
                frmPrincipal.crearInicio();
                frmPrincipal.cerrarRegistro();
            }
        }

        // Comprobaremos si el usuario ha rellenado algun campo para indicar que ha modificado cambios si abandona la ventana
        private bool camposRellenados()
        {
            bool rellenado = false;
            if (TxtUsuario.Text.Length > 0 || TxtEmail.Text.Length > 0 || TxtNom.Text.Length > 0 || TxtPas.Text.Length > 0 || TxtPas2.Text.Length > 0 || TxtTlf.Text.Length > 0)
            {
                rellenado = true;
            }
            return rellenado;
        }


        // Limpiaremos todos los campos
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtUsuario.Clear();
            TxtEmail.Clear();
            TxtNom.Clear();
            TxtPas.Clear();
            TxtPas2.Clear();
            TxtTlf.Clear();
            RdbPublico.Checked = true;
        }

        private void FrmRegistro_Resize(object sender, EventArgs e)
        {
            int panelSpacing = 40; // Espacio entre los paneles
            int totalWidth = panelReg.Width + panelAvatar.Width + panelSpacing;

            int alturaTotal = (PanelRegistro.Height - panelReg.Height + paneltop.Height) / 2;

            // Calcular la posición inicial para centrar los paneles horizontalmente
            int startX = (PanelRegistro.ClientSize.Width - totalWidth) / 2;

            // Ajustar la posición de los paneles
            panelReg.Left = startX;
            panelReg.Top = alturaTotal;

            panelAvatar.Left = startX + panelReg.Width + panelSpacing;
            panelAvatar.Top = alturaTotal;

            // Centrar LblTiit
            LblTiit.Left = (paneltop.Width - LblTiit.Width) / 2;
            LblTiit.Top = (paneltop.Height - LblTiit.Height) / 2;

            // Alinear iconButton1 a la izquierda
            IcbVolverInicio.Left = 40; // Un margen de 10 píxeles desde el borde izquierdo
            IcbVolverInicio.Top = (paneltop.Height - IcbVolverInicio.Height) / 2;
        }
    }
}
