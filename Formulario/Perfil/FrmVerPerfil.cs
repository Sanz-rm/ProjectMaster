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
    public partial class FrmVerPerfil : Form
    {
        private FrmPrincipal frmPrincipal;
        private Usuario usuario;
        private Usuario amigo;
        private UsuarioDAO usuarioDAO;
        List<Modelo.Proyecto> listaProyectos;
        bool esAmigo;
        bool cambiosAmigo;
        public FrmVerPerfil(FrmPrincipal frmP, MySqlConnection conexion2, Usuario user, Usuario userAmigo, List<Modelo.Proyecto> listaProyectosUsuario)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            frmPrincipal = frmP;
            usuarioDAO = new UsuarioDAO(conexion2);
            usuario = user;
            amigo = userAmigo;
            listaProyectos = listaProyectosUsuario;
            esAmigo = false;
            cambiosAmigo = false;
            rellenarDatos();
            rellenarProyectoComun();
        }


        private void rellenarDatos()
        {

            LblTitulo.Text += " " + amigo.nombreUsuario.ToUpper();

            if (!amigo.privacidad)
            {
                TxtUsuario.Text = amigo.nombreUsuario;
                TxtCorreo.Text = amigo.correo;
                TxtNomReal.Text = !string.IsNullOrEmpty(amigo.nombreReal) ? amigo.nombreReal : "Sin datos";
                TxtTelefono.Text = !string.IsNullOrEmpty(amigo.telefono.ToString()) ? amigo.telefono.ToString() : "Sin datos";
                LblPpriv.Text += "PÚBLICO";
                mostrarAvatar();
            }
            else
            {
                MessageBox.Show(amigo.nombreUsuario.ToUpper() + " tiene el perfil privado...\nSolo podran chatear, asi que el telefono se lo tendras que preguntar directamente tu ;)", "¡ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtUsuario.Visible = false;
                TxtCorreo.Visible = false;
                TxtNomReal.Visible = false;
                TxtTelefono.Visible = false;
                PcbConfidencial.Visible = true;
                LblPpriv.Text += "PRIVADO";

            }

            if (usuarioDAO.esAmigo(usuario.id, amigo.id))
            {
                esAmigo = true;
                BtnAddDelAmigo.Text = "ELIMINAR";
            }
            else
            {
                esAmigo = false;
                BtnAddDelAmigo.Text = "AGREGAR";
            }
        }

        private void rellenarProyectoComun()
        {

            foreach (Modelo.Proyecto p in listaProyectos)
            {
                List<Usuario> usuariosProyecto = p.miembros;
                foreach (Modelo.Usuario u in usuariosProyecto)
                {
                    if (u.id == amigo.id)
                    {
                        LstProyectos.Items.Add(p.nombre);
                        LstProyectosId.Items.Add(p.id);
                    }
                }
            }
        }

        // --------------------------------------------------------------------------
        // Mostrar avatar:
        private void mostrarAvatar()
        {
            PcbAvatar.Image = Usuario.obtenerAvatar(amigo.codAvatar);
        }

        private void IcbVolverInicio_Click(object sender, EventArgs e)
        {
            if (cambiosAmigo)
            {
                frmPrincipal.crearArea(usuario, 0);
            }
            else
            {
                frmPrincipal.iniciarArea();
            }
            frmPrincipal.cerrarVerPerfil();
        }

        private void BtnChat_Click(object sender, EventArgs e)
        {
            frmPrincipal.cerrarArea();
            frmPrincipal.crearChat(usuario, amigo);
            frmPrincipal.cerrarVerPerfil();
        }

        private void BtnEliminarAmigo_Click(object sender, EventArgs e)
        {
            string accion;
            if (esAmigo)
            {
                accion = "eliminar";
            }
            else
            {
                accion = "agregar";

            }

            DialogResult resultado = MessageBox.Show("¿Seguro que quieres " + accion + " como amigo a " + amigo.nombreUsuario + "?", "¡CUIDADO!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                if (esAmigo)
                {
                    eliminarAmigo();
                }
                else
                {
                    agregarAmigo();
                }
            }

        }
        private void eliminarAmigo()
        {
            usuarioDAO.eliminarAmigo(usuario.id, amigo.id);
            cambiosAmigo = true;
            esAmigo = false;
            BtnAddDelAmigo.Text = "AGREGAR";
        }
        private void agregarAmigo()
        {
            usuarioDAO.agregarAmigo(usuario.id, amigo.id);
            cambiosAmigo = true;
            esAmigo = true;
            BtnAddDelAmigo.Text = "ELIMINAR";

        }

        private void LstProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstProyectos.SelectedItems.Count > 0)
            {
                LstProyectosId.SelectedIndex = LstProyectos.SelectedIndex;
            }
        }

        private void LstProyectos_DoubleClick(object sender, EventArgs e)
        {
            if (LstProyectos.SelectedItems.Count > 0)
            {
                frmPrincipal.crearArea(usuario, Convert.ToInt32(LstProyectosId.SelectedItem));
            }
        }

        private void FrmVerPerfil_Resize(object sender, EventArgs e)
        {

            int panelSpacing = 40; // Espacio entre los paneles
            int totalWidth = panelPerf.Width + panelPcomun.Width + panelSpacing;
            // Calcular la posición inicial para centrar los paneles horizontalmente
            int startX = (PanelVerPerfil.ClientSize.Width - totalWidth) / 2;
            // Ajustar la posición de los paneles
            panelPerf.Left = startX;
            panelPerf.Top = (PanelVerPerfil.ClientSize.Height - panelPerf.Height) / 2;

            panelPcomun.Left = startX + panelPerf.Width + panelSpacing;
            panelPcomun.Top = (PanelVerPerfil.ClientSize.Height - panelPcomun.Height) / 2;

            // Center LblTitulo
            LblPpriv.Left = (panelTop.Width - LblPpriv.Width) / 2;
            LblPpriv.Top = (panelTop.Height - LblPpriv.Height) / 2;

            // Align IconButton to the left with margin
            IcbVolverInicio.Left = 40;
            IcbVolverInicio.Top = (panelTop.Height - IcbVolverInicio.Height) / 2;

            // Align IconButton to the left with margin
            BtnAddDelAmigo.Left = panelTop.Width - BtnAddDelAmigo.Width - 40; // Posición a la derecha con un margen de 40
            BtnAddDelAmigo.Top = (panelTop.Height - BtnAddDelAmigo.Height) / 2;

        }
    }
}
