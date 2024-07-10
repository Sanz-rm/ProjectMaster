using MySql.Data.MySqlClient;
using ProjectMaster.DAO;
using ProjectMaster.DiseñoMessageBox;
using ProjectMaster.Formulario.Principal;
using ProjectMaster.Modelo;
using System;

using System.Windows.Forms;

namespace ProjectMaster
{
    public partial class FrmInicio : Form
    {
        private FrmPrincipal frmPrincipal;
        private UsuarioDAO usuarioDAO;
        private MensajeInicio mensajeInicio;
        string codigo;

        public FrmInicio(FrmPrincipal frmP, MySqlConnection conexion2)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            frmPrincipal = frmP;
            usuarioDAO = new UsuarioDAO(conexion2);
            codigo = "";
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            
            Usuario usuario = null;
            string usuarioIntroducido = TxtUsuario.Text.ToLower().Trim();        // el usuario introducido
            string passwordIntroducida = TxtPas.Text;                               // la password introducida

            bool existeUsuario = false;
            if (usuarioIntroducido.Length > 0 && passwordIntroducida.Length > 0)
            {
                
                if (!existeUsuario)
                {
                    usuario = usuarioDAO.buscarUsuarioPorNombreOCorreo(usuarioIntroducido);
                    if (usuario != null)
                    {
                        existeUsuario = true;
                    }
                }


                // Si se ha encontrado usuario:
                if (existeUsuario)
                {

                    // Verificamos contraseña introducida:
                    if (BCrypt.Net.BCrypt.Verify(passwordIntroducida, usuario.password))
                    {

                        // Se inicia sesión y cambiamos de pantalla:
                        frmPrincipal.crearArea(usuario,0);
                        frmPrincipal.cerrarInicio();
                        mensajeInicio = new MensajeInicio(usuario);
                        mensajeInicio.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta...", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } // if - existe usuario
                else
                {
                    MessageBox.Show("El nombre de usuario/correo " + TxtUsuario.Text + " no existe...", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } // if - campos rellenados
            else
            {
                MessageBox.Show("Debes rellenar todos los campos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            frmPrincipal.crearRegistro();
            frmPrincipal.cerrarInicio();
        }

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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtUsuario.Clear();
            TxtPas.Clear();
        }

        private void TxtPas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAceptar_Click(sender, e);
            }
        }

        private void LnkOlvidePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Has olvidado tu contraseña, quieres cambiarla?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.OK)
            {
                Usuario usuario = usuarioDAO.buscarUsuarioPorNombreOCorreo(TxtUsuario.Text.Trim());
                if (usuario != null)
                {
                    codigo = Usuario.generarCodigoAlfanumericoAleatorio();
                    usuarioDAO.actualizarPasswordUsuario(usuario.id, BCrypt.Net.BCrypt.HashPassword(codigo));
                    Usuario.enviarCorreoVerificacionOlvidarPassword(usuario, codigo);
                    TxtPas.Text = "";
                }
                else
                {
                    MessageBox.Show("El nombre de usuario/correo " + TxtUsuario.Text + " no existe...", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmInicio_Resize(object sender, EventArgs e)
        {
            // Centrar panelContent en el panelMain
            panelContent.Left = (panelMain.ClientSize.Width - panelContent.Width) / 2;
            panelContent.Top = (panelMain.ClientSize.Height - panelContent.Height) / 2;
        }
    }
}
