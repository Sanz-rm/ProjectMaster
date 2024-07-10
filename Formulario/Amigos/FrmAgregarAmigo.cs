using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using ProjectMaster.DAO;
using ProjectMaster.Formulario.Principal;
using ProjectMaster.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ProjectMaster.Formulario.Amigos
{
    public partial class FrmAgregarAmigo : Form
    {
        private FrmPrincipal frmPrincipal;
        private Usuario usuario;
        private UsuarioDAO usuarioDAO;
        private List<Usuario> amigos;
        private List<Usuario> coincidencias;

        public FrmAgregarAmigo(FrmPrincipal frmPrincipal, MySqlConnection conexion, Usuario user, List<Usuario> listaAmigos)
        {
            InitializeComponent();
            LblUsuario.Text = "";
            this.FormBorderStyle = FormBorderStyle.None;
            usuario = user;
            usuarioDAO = new UsuarioDAO(conexion);
            this.frmPrincipal = frmPrincipal;
            amigos = listaAmigos;
        }

        private void TxtAmigo_TextChanged(object sender, EventArgs e)
        {
            string texto = TxtAmigo.Text;
            LblAgregar.Visible = false;
            LblUsuario.Visible = false;
            BtnAgregar.Visible = false;

            List<int> idAmigos = new List<int>();
            LstAmigos.Items.Clear();

            foreach (Usuario u in amigos)
                idAmigos.Add(u.id);

            LstAmigos.Items.Clear();
            // Si hay algo escrito:
            if (texto.Length > 0)
            {
                coincidencias = usuarioDAO.obtenerUsuariosPorCoincidencia(texto, idAmigos, usuario.id);
                foreach (Usuario u in coincidencias)
                {
                    ListViewItem elementoUsuario = new ListViewItem(u.nombreUsuario);
                    elementoUsuario.SubItems.Add(u.correo);
                    LstAmigos.Items.Add(elementoUsuario);
                }
            }
        }

        private void LstAmigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstAmigos.SelectedIndices.Count > 0)
            {
                LblAgregar.Visible = true;
                LblUsuario.Visible = true;
                BtnAgregar.Visible = true;
                string nombre = LstAmigos.SelectedItems[0].Text;
                LblUsuario.Text = nombre;
            }
            else
            {
                LblAgregar.Visible = false;
                LblUsuario.Visible = false;
                BtnAgregar.Visible = false;
                LblUsuario.Text = "";
            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = LblUsuario.Text;
            if (!nombre.Equals(""))
            {
                Usuario amigo = null;
                int i = 0;
                while (amigo == null)
                {
                    if (coincidencias[i].nombreUsuario.Equals(nombre))
                        amigo = coincidencias[i];
                    i++;
                }
                DialogResult resultado = MessageBox.Show("¿Quieres agregar al usuario " + amigo.nombreUsuario + " a tu lista de amigos?", "Confirmar amigo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    usuarioDAO.agregarAmigo(usuario.id, amigo.id);
                    TxtAmigo.Text = "";
                    amigos.Add(amigo);
                }
            }
            else
                MessageBox.Show("Debes seleccionar un usuario para agregarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void IcbVolverInicio_Click(object sender, EventArgs e)
        {
            frmPrincipal.crearArea(usuario,0);
            frmPrincipal.cerrarAgregarAmigo();
        }

        private void FrmAgregarAmigo_Resize(object sender, EventArgs e)
        {
            // Center LblTitulo
            LblTitulo.Left = (panelTop.Width - LblTitulo.Width) / 2;
            LblTitulo.Top = (panelTop.Height - LblTitulo.Height) / 2;

            // Align IconButton to the left with margin
            IcbVolverInicio.Left = 40;
            IcbVolverInicio.Top = (panelTop.Height - IcbVolverInicio.Height) / 2;

            // Center panelCentr
            panelCentr.Left = (PanelAgregarAmigos.ClientSize.Width - panelCentr.Width) / 2;
            panelCentr.Top =  3*panelTop.Height/2;

        }
    }
}
