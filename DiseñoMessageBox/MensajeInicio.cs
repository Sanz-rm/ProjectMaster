using ProjectMaster.Modelo;
using System;
using System.Windows.Forms;

namespace ProjectMaster.DiseñoMessageBox
{

    public partial class MensajeInicio : Form
    {
        private Usuario user;

        public MensajeInicio(Usuario usuario)
        {
            InitializeComponent();
            this.CenterToScreen();
            user = usuario;
            LblTitulo.Text += user.nombreUsuario.ToUpper();
            PcbAvatar.Image = Usuario.obtenerAvatar(usuario.codAvatar);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
