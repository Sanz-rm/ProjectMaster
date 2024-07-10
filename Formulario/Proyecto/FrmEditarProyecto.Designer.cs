namespace ProjectMaster.Formulario.Proyecto
{
    partial class FrmEditarProyecto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelEditarProyecto = new System.Windows.Forms.Panel();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.LblDatosProyecto = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblNombreProyecto = new System.Windows.Forms.Label();
            this.TxtNombreProyecto = new System.Windows.Forms.TextBox();
            this.RtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.panelModMiembros = new System.Windows.Forms.Panel();
            this.LblMiembro = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.CboAmigos = new System.Windows.Forms.ComboBox();
            this.LblAdmins = new System.Windows.Forms.Label();
            this.BtnEliminarAdmin = new System.Windows.Forms.Button();
            this.LblAmigos = new System.Windows.Forms.Label();
            this.CboMiembros = new System.Windows.Forms.ComboBox();
            this.LstAdmins = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblMiembros = new System.Windows.Forms.Label();
            this.BtnAñadir = new System.Windows.Forms.Button();
            this.LstMiembro = new System.Windows.Forms.ListView();
            this.ClmUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmCorreo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.BtnEliminarMiembro = new System.Windows.Forms.Button();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.IcbVolverInicio = new FontAwesome.Sharp.IconButton();
            this.LblEditarProyecto = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.PanelEditarProyecto.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.panelModMiembros.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelEditarProyecto
            // 
            this.PanelEditarProyecto.AutoScroll = true;
            this.PanelEditarProyecto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PanelEditarProyecto.Controls.Add(this.panelDatos);
            this.PanelEditarProyecto.Controls.Add(this.BtnGuardar);
            this.PanelEditarProyecto.Controls.Add(this.panelModMiembros);
            this.PanelEditarProyecto.Controls.Add(this.panelTop);
            this.PanelEditarProyecto.Controls.Add(this.BtnLimpiar);
            this.PanelEditarProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEditarProyecto.Location = new System.Drawing.Point(0, 0);
            this.PanelEditarProyecto.Margin = new System.Windows.Forms.Padding(2);
            this.PanelEditarProyecto.Name = "PanelEditarProyecto";
            this.PanelEditarProyecto.Size = new System.Drawing.Size(1028, 609);
            this.PanelEditarProyecto.TabIndex = 1;
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.panelDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDatos.Controls.Add(this.LblDatosProyecto);
            this.panelDatos.Controls.Add(this.LblDescripcion);
            this.panelDatos.Controls.Add(this.LblNombreProyecto);
            this.panelDatos.Controls.Add(this.TxtNombreProyecto);
            this.panelDatos.Controls.Add(this.RtxtDescripcion);
            this.panelDatos.Location = new System.Drawing.Point(11, 166);
            this.panelDatos.Margin = new System.Windows.Forms.Padding(2);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(428, 494);
            this.panelDatos.TabIndex = 97;
            // 
            // LblDatosProyecto
            // 
            this.LblDatosProyecto.AutoSize = true;
            this.LblDatosProyecto.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.LblDatosProyecto.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblDatosProyecto.Location = new System.Drawing.Point(106, 13);
            this.LblDatosProyecto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDatosProyecto.Name = "LblDatosProyecto";
            this.LblDatosProyecto.Size = new System.Drawing.Size(161, 29);
            this.LblDatosProyecto.TabIndex = 97;
            this.LblDatosProyecto.Text = "Datos del Proyecto:";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LblDescripcion.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblDescripcion.Location = new System.Drawing.Point(40, 200);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(180, 27);
            this.LblDescripcion.TabIndex = 59;
            this.LblDescripcion.Text = "Descripción del Proyecto:";
            // 
            // LblNombreProyecto
            // 
            this.LblNombreProyecto.AutoSize = true;
            this.LblNombreProyecto.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LblNombreProyecto.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblNombreProyecto.Location = new System.Drawing.Point(40, 96);
            this.LblNombreProyecto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombreProyecto.Name = "LblNombreProyecto";
            this.LblNombreProyecto.Size = new System.Drawing.Size(157, 27);
            this.LblNombreProyecto.TabIndex = 58;
            this.LblNombreProyecto.Text = "Nombre del Proyecto:";
            // 
            // TxtNombreProyecto
            // 
            this.TxtNombreProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.TxtNombreProyecto.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.TxtNombreProyecto.Location = new System.Drawing.Point(44, 125);
            this.TxtNombreProyecto.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombreProyecto.Name = "TxtNombreProyecto";
            this.TxtNombreProyecto.Size = new System.Drawing.Size(333, 35);
            this.TxtNombreProyecto.TabIndex = 56;
            // 
            // RtxtDescripcion
            // 
            this.RtxtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.RtxtDescripcion.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.RtxtDescripcion.Location = new System.Drawing.Point(44, 239);
            this.RtxtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.RtxtDescripcion.Name = "RtxtDescripcion";
            this.RtxtDescripcion.Size = new System.Drawing.Size(333, 145);
            this.RtxtDescripcion.TabIndex = 60;
            this.RtxtDescripcion.Text = "";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.BtnGuardar.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.BtnGuardar.Location = new System.Drawing.Point(334, 710);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(191, 27);
            this.BtnGuardar.TabIndex = 96;
            this.BtnGuardar.Text = "GUARDAR CAMBIOS";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // panelModMiembros
            // 
            this.panelModMiembros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.panelModMiembros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelModMiembros.Controls.Add(this.LblMiembro);
            this.panelModMiembros.Controls.Add(this.LblTitulo);
            this.panelModMiembros.Controls.Add(this.CboAmigos);
            this.panelModMiembros.Controls.Add(this.LblAdmins);
            this.panelModMiembros.Controls.Add(this.BtnEliminarAdmin);
            this.panelModMiembros.Controls.Add(this.LblAmigos);
            this.panelModMiembros.Controls.Add(this.CboMiembros);
            this.panelModMiembros.Controls.Add(this.LstAdmins);
            this.panelModMiembros.Controls.Add(this.LblMiembros);
            this.panelModMiembros.Controls.Add(this.BtnAñadir);
            this.panelModMiembros.Controls.Add(this.LstMiembro);
            this.panelModMiembros.Controls.Add(this.TxtCorreo);
            this.panelModMiembros.Controls.Add(this.BtnEliminarMiembro);
            this.panelModMiembros.Controls.Add(this.LblCorreo);
            this.panelModMiembros.Location = new System.Drawing.Point(504, 166);
            this.panelModMiembros.Margin = new System.Windows.Forms.Padding(2);
            this.panelModMiembros.Name = "panelModMiembros";
            this.panelModMiembros.Size = new System.Drawing.Size(850, 494);
            this.panelModMiembros.TabIndex = 99;
            // 
            // LblMiembro
            // 
            this.LblMiembro.AutoSize = true;
            this.LblMiembro.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LblMiembro.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblMiembro.Location = new System.Drawing.Point(423, 121);
            this.LblMiembro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMiembro.Name = "LblMiembro";
            this.LblMiembro.Size = new System.Drawing.Size(82, 27);
            this.LblMiembro.TabIndex = 96;
            this.LblMiembro.Text = "Miembros:";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblTitulo.Location = new System.Drawing.Point(337, 13);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(272, 29);
            this.LblTitulo.TabIndex = 76;
            this.LblTitulo.Text = "Modificar Miembros del Proyecto:";
            // 
            // CboAmigos
            // 
            this.CboAmigos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.CboAmigos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAmigos.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.CboAmigos.FormattingEnabled = true;
            this.CboAmigos.Location = new System.Drawing.Point(76, 66);
            this.CboAmigos.Margin = new System.Windows.Forms.Padding(2);
            this.CboAmigos.Name = "CboAmigos";
            this.CboAmigos.Size = new System.Drawing.Size(233, 35);
            this.CboAmigos.TabIndex = 77;
            this.CboAmigos.SelectedIndexChanged += new System.EventHandler(this.CboAmigos_SelectedIndexChanged);
            // 
            // LblAdmins
            // 
            this.LblAdmins.AutoSize = true;
            this.LblAdmins.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LblAdmins.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblAdmins.Location = new System.Drawing.Point(423, 193);
            this.LblAdmins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAdmins.Name = "LblAdmins";
            this.LblAdmins.Size = new System.Drawing.Size(124, 27);
            this.LblAdmins.TabIndex = 88;
            this.LblAdmins.Text = "Administradores:";
            // 
            // BtnEliminarAdmin
            // 
            this.BtnEliminarAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BtnEliminarAdmin.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.BtnEliminarAdmin.Location = new System.Drawing.Point(428, 443);
            this.BtnEliminarAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminarAdmin.Name = "BtnEliminarAdmin";
            this.BtnEliminarAdmin.Size = new System.Drawing.Size(77, 29);
            this.BtnEliminarAdmin.TabIndex = 95;
            this.BtnEliminarAdmin.Text = "Eliminar";
            this.BtnEliminarAdmin.UseVisualStyleBackColor = false;
            this.BtnEliminarAdmin.Click += new System.EventHandler(this.BtnEliminarAdmin_Click);
            // 
            // LblAmigos
            // 
            this.LblAmigos.AutoSize = true;
            this.LblAmigos.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LblAmigos.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblAmigos.Location = new System.Drawing.Point(71, 37);
            this.LblAmigos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAmigos.Name = "LblAmigos";
            this.LblAmigos.Size = new System.Drawing.Size(66, 27);
            this.LblAmigos.TabIndex = 84;
            this.LblAmigos.Text = "Amigos:";
            // 
            // CboMiembros
            // 
            this.CboMiembros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.CboMiembros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMiembros.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.CboMiembros.FormattingEnabled = true;
            this.CboMiembros.Location = new System.Drawing.Point(428, 152);
            this.CboMiembros.Margin = new System.Windows.Forms.Padding(2);
            this.CboMiembros.Name = "CboMiembros";
            this.CboMiembros.Size = new System.Drawing.Size(324, 35);
            this.CboMiembros.TabIndex = 87;
            this.CboMiembros.SelectedIndexChanged += new System.EventHandler(this.CboMiembros_SelectedIndexChanged);
            // 
            // LstAdmins
            // 
            this.LstAdmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.LstAdmins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LstAdmins.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LstAdmins.HideSelection = false;
            this.LstAdmins.Location = new System.Drawing.Point(428, 224);
            this.LstAdmins.Margin = new System.Windows.Forms.Padding(2);
            this.LstAdmins.MultiSelect = false;
            this.LstAdmins.Name = "LstAdmins";
            this.LstAdmins.Size = new System.Drawing.Size(324, 208);
            this.LstAdmins.TabIndex = 86;
            this.LstAdmins.UseCompatibleStateImageBehavior = false;
            this.LstAdmins.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Usuario";
            this.columnHeader1.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Correo";
            this.columnHeader2.Width = 129;
            // 
            // LblMiembros
            // 
            this.LblMiembros.AutoSize = true;
            this.LblMiembros.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LblMiembros.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblMiembros.Location = new System.Drawing.Point(71, 197);
            this.LblMiembros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMiembros.Name = "LblMiembros";
            this.LblMiembros.Size = new System.Drawing.Size(149, 27);
            this.LblMiembros.TabIndex = 80;
            this.LblMiembros.Text = "Miembros Añadidos:";
            // 
            // BtnAñadir
            // 
            this.BtnAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.BtnAñadir.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.BtnAñadir.Location = new System.Drawing.Point(320, 152);
            this.BtnAñadir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAñadir.Name = "BtnAñadir";
            this.BtnAñadir.Size = new System.Drawing.Size(67, 30);
            this.BtnAñadir.TabIndex = 81;
            this.BtnAñadir.Text = "Añadir";
            this.BtnAñadir.UseVisualStyleBackColor = false;
            this.BtnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // LstMiembro
            // 
            this.LstMiembro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.LstMiembro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmUsuario,
            this.ClmCorreo});
            this.LstMiembro.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LstMiembro.HideSelection = false;
            this.LstMiembro.Location = new System.Drawing.Point(76, 226);
            this.LstMiembro.Margin = new System.Windows.Forms.Padding(2);
            this.LstMiembro.MultiSelect = false;
            this.LstMiembro.Name = "LstMiembro";
            this.LstMiembro.Size = new System.Drawing.Size(320, 206);
            this.LstMiembro.TabIndex = 85;
            this.LstMiembro.UseCompatibleStateImageBehavior = false;
            this.LstMiembro.View = System.Windows.Forms.View.Details;
            // 
            // ClmUsuario
            // 
            this.ClmUsuario.Text = "Usuario";
            this.ClmUsuario.Width = 90;
            // 
            // ClmCorreo
            // 
            this.ClmCorreo.Text = "Correo";
            this.ClmCorreo.Width = 130;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.TxtCorreo.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.TxtCorreo.Location = new System.Drawing.Point(76, 150);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(240, 35);
            this.TxtCorreo.TabIndex = 78;
            // 
            // BtnEliminarMiembro
            // 
            this.BtnEliminarMiembro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BtnEliminarMiembro.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.BtnEliminarMiembro.Location = new System.Drawing.Point(76, 443);
            this.BtnEliminarMiembro.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminarMiembro.Name = "BtnEliminarMiembro";
            this.BtnEliminarMiembro.Size = new System.Drawing.Size(74, 27);
            this.BtnEliminarMiembro.TabIndex = 82;
            this.BtnEliminarMiembro.Text = "Eliminar";
            this.BtnEliminarMiembro.UseVisualStyleBackColor = false;
            this.BtnEliminarMiembro.Click += new System.EventHandler(this.BtnEliminarMiembro_Click);
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LblCorreo.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblCorreo.Location = new System.Drawing.Point(71, 121);
            this.LblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(133, 27);
            this.LblCorreo.TabIndex = 79;
            this.LblCorreo.Text = "Añadir por correo:";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.panelTop.Controls.Add(this.IcbVolverInicio);
            this.panelTop.Controls.Add(this.LblEditarProyecto);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1354, 86);
            this.panelTop.TabIndex = 98;
            // 
            // IcbVolverInicio
            // 
            this.IcbVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcbVolverInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.IcbVolverInicio.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IcbVolverInicio.IconColor = System.Drawing.Color.Black;
            this.IcbVolverInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcbVolverInicio.Location = new System.Drawing.Point(17, 9);
            this.IcbVolverInicio.Name = "IcbVolverInicio";
            this.IcbVolverInicio.Size = new System.Drawing.Size(72, 67);
            this.IcbVolverInicio.TabIndex = 94;
            this.IcbVolverInicio.UseVisualStyleBackColor = true;
            this.IcbVolverInicio.Click += new System.EventHandler(this.IcbVolverInicio_Click);
            // 
            // LblEditarProyecto
            // 
            this.LblEditarProyecto.AutoSize = true;
            this.LblEditarProyecto.Font = new System.Drawing.Font("Myanmar Text", 16F, System.Drawing.FontStyle.Bold);
            this.LblEditarProyecto.Location = new System.Drawing.Point(887, 28);
            this.LblEditarProyecto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEditarProyecto.Name = "LblEditarProyecto";
            this.LblEditarProyecto.Size = new System.Drawing.Size(214, 39);
            this.LblEditarProyecto.TabIndex = 93;
            this.LblEditarProyecto.Text = "EDITAR PROYECTO";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.BtnLimpiar.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.Location = new System.Drawing.Point(563, 710);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(121, 27);
            this.BtnLimpiar.TabIndex = 83;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmEditarProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.PanelEditarProyecto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmEditarProyecto";
            this.Text = "FrmEditarProyecto";
            this.Resize += new System.EventHandler(this.FrmEditarProyecto_Resize);
            this.PanelEditarProyecto.ResumeLayout(false);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panelModMiembros.ResumeLayout(false);
            this.panelModMiembros.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelEditarProyecto;
        private System.Windows.Forms.Label LblEditarProyecto;
        private System.Windows.Forms.Label LblAdmins;
        private System.Windows.Forms.ComboBox CboMiembros;
        private System.Windows.Forms.ListView LstAdmins;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView LstMiembro;
        private System.Windows.Forms.ColumnHeader ClmUsuario;
        private System.Windows.Forms.ColumnHeader ClmCorreo;
        private System.Windows.Forms.Label LblAmigos;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnEliminarMiembro;
        private System.Windows.Forms.Button BtnAñadir;
        private System.Windows.Forms.Label LblMiembros;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.ComboBox CboAmigos;
        private System.Windows.Forms.Label LblTitulo;
        private FontAwesome.Sharp.IconButton IcbVolverInicio;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEliminarAdmin;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblNombreProyecto;
        private System.Windows.Forms.TextBox TxtNombreProyecto;
        private System.Windows.Forms.RichTextBox RtxtDescripcion;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelModMiembros;
        private System.Windows.Forms.Label LblMiembro;
        private System.Windows.Forms.Label LblDatosProyecto;
    }
}