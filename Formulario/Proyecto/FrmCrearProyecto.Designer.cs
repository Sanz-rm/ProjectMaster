namespace ProjectMaster.Formulario.Proyecto
{
    partial class FrmCrearProyecto
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
            this.PanelCrearProyecto = new System.Windows.Forms.Panel();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.IcbVolverInicio = new FontAwesome.Sharp.IconButton();
            this.LblNuevoProyecto = new System.Windows.Forms.Label();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblNombreProyecto = new System.Windows.Forms.Label();
            this.TxtNombreProyecto = new System.Windows.Forms.TextBox();
            this.RtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.panelMiembros = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LstMiembros = new System.Windows.Forms.ListView();
            this.ClmUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmCorreo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.LblMiembros = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.BtnAñadir = new System.Windows.Forms.Button();
            this.CboAmigos = new System.Windows.Forms.ComboBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.PanelCrearProyecto.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.panelMiembros.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCrearProyecto
            // 
            this.PanelCrearProyecto.AutoScroll = true;
            this.PanelCrearProyecto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PanelCrearProyecto.Controls.Add(this.BtnLimpiar);
            this.PanelCrearProyecto.Controls.Add(this.BtnCrear);
            this.PanelCrearProyecto.Controls.Add(this.panelTop);
            this.PanelCrearProyecto.Controls.Add(this.panelDatos);
            this.PanelCrearProyecto.Controls.Add(this.panelMiembros);
            this.PanelCrearProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCrearProyecto.Location = new System.Drawing.Point(0, 0);
            this.PanelCrearProyecto.Margin = new System.Windows.Forms.Padding(2);
            this.PanelCrearProyecto.Name = "PanelCrearProyecto";
            this.PanelCrearProyecto.Size = new System.Drawing.Size(1028, 609);
            this.PanelCrearProyecto.TabIndex = 1;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.BtnLimpiar.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.Location = new System.Drawing.Point(904, 853);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(122, 31);
            this.BtnLimpiar.TabIndex = 69;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCrear
            // 
            this.BtnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.BtnCrear.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.BtnCrear.Location = new System.Drawing.Point(756, 853);
            this.BtnCrear.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(122, 31);
            this.BtnCrear.TabIndex = 68;
            this.BtnCrear.Text = "CREAR";
            this.BtnCrear.UseVisualStyleBackColor = false;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.panelTop.Controls.Add(this.IcbVolverInicio);
            this.panelTop.Controls.Add(this.LblNuevoProyecto);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1569, 86);
            this.panelTop.TabIndex = 73;
            // 
            // IcbVolverInicio
            // 
            this.IcbVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcbVolverInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.IcbVolverInicio.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IcbVolverInicio.IconColor = System.Drawing.Color.Black;
            this.IcbVolverInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcbVolverInicio.Location = new System.Drawing.Point(22, 11);
            this.IcbVolverInicio.Name = "IcbVolverInicio";
            this.IcbVolverInicio.Size = new System.Drawing.Size(72, 67);
            this.IcbVolverInicio.TabIndex = 72;
            this.IcbVolverInicio.UseVisualStyleBackColor = true;
            this.IcbVolverInicio.Click += new System.EventHandler(this.IcbVolverInicio_Click);
            // 
            // LblNuevoProyecto
            // 
            this.LblNuevoProyecto.AutoSize = true;
            this.LblNuevoProyecto.Font = new System.Drawing.Font("Myanmar Text", 20F, System.Drawing.FontStyle.Bold);
            this.LblNuevoProyecto.Location = new System.Drawing.Point(780, 28);
            this.LblNuevoProyecto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNuevoProyecto.Name = "LblNuevoProyecto";
            this.LblNuevoProyecto.Size = new System.Drawing.Size(258, 48);
            this.LblNuevoProyecto.TabIndex = 57;
            this.LblNuevoProyecto.Text = "NUEVO PROYECTO";
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.panelDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDatos.Controls.Add(this.LblDescripcion);
            this.panelDatos.Controls.Add(this.LblNombreProyecto);
            this.panelDatos.Controls.Add(this.TxtNombreProyecto);
            this.panelDatos.Controls.Add(this.RtxtDescripcion);
            this.panelDatos.Location = new System.Drawing.Point(358, 303);
            this.panelDatos.Margin = new System.Windows.Forms.Padding(2);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(477, 450);
            this.panelDatos.TabIndex = 74;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LblDescripcion.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblDescripcion.Location = new System.Drawing.Point(51, 176);
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
            this.LblNombreProyecto.Location = new System.Drawing.Point(51, 72);
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
            this.TxtNombreProyecto.Location = new System.Drawing.Point(56, 115);
            this.TxtNombreProyecto.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombreProyecto.Name = "TxtNombreProyecto";
            this.TxtNombreProyecto.Size = new System.Drawing.Size(333, 35);
            this.TxtNombreProyecto.TabIndex = 56;
            // 
            // RtxtDescripcion
            // 
            this.RtxtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.RtxtDescripcion.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.RtxtDescripcion.Location = new System.Drawing.Point(56, 223);
            this.RtxtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.RtxtDescripcion.Name = "RtxtDescripcion";
            this.RtxtDescripcion.Size = new System.Drawing.Size(333, 145);
            this.RtxtDescripcion.TabIndex = 60;
            this.RtxtDescripcion.Text = "";
            // 
            // panelMiembros
            // 
            this.panelMiembros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.panelMiembros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMiembros.Controls.Add(this.label2);
            this.panelMiembros.Controls.Add(this.LstMiembros);
            this.panelMiembros.Controls.Add(this.label1);
            this.panelMiembros.Controls.Add(this.LblMiembros);
            this.panelMiembros.Controls.Add(this.BtnEliminar);
            this.panelMiembros.Controls.Add(this.TxtCorreo);
            this.panelMiembros.Controls.Add(this.BtnAñadir);
            this.panelMiembros.Controls.Add(this.CboAmigos);
            this.panelMiembros.Controls.Add(this.LblCorreo);
            this.panelMiembros.Location = new System.Drawing.Point(916, 303);
            this.panelMiembros.Margin = new System.Windows.Forms.Padding(2);
            this.panelMiembros.Name = "panelMiembros";
            this.panelMiembros.Size = new System.Drawing.Size(653, 450);
            this.panelMiembros.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(93, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 70;
            this.label2.Text = "Amigos:";
            // 
            // LstMiembros
            // 
            this.LstMiembros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.LstMiembros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmUsuario,
            this.ClmCorreo});
            this.LstMiembros.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LstMiembros.HideSelection = false;
            this.LstMiembros.Location = new System.Drawing.Point(164, 193);
            this.LstMiembros.Margin = new System.Windows.Forms.Padding(2);
            this.LstMiembros.MultiSelect = false;
            this.LstMiembros.Name = "LstMiembros";
            this.LstMiembros.Size = new System.Drawing.Size(347, 236);
            this.LstMiembros.TabIndex = 71;
            this.LstMiembros.UseCompatibleStateImageBehavior = false;
            this.LstMiembros.View = System.Windows.Forms.View.Details;
            // 
            // ClmUsuario
            // 
            this.ClmUsuario.Text = "Usuario";
            this.ClmUsuario.Width = 174;
            // 
            // ClmCorreo
            // 
            this.ClmCorreo.Text = "Correo";
            this.ClmCorreo.Width = 277;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(226, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 27);
            this.label1.TabIndex = 61;
            this.label1.Text = "AÑADE MIEMBROS AL PROYECTO";
            // 
            // LblMiembros
            // 
            this.LblMiembros.AutoSize = true;
            this.LblMiembros.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LblMiembros.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblMiembros.Location = new System.Drawing.Point(14, 193);
            this.LblMiembros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMiembros.Name = "LblMiembros";
            this.LblMiembros.Size = new System.Drawing.Size(149, 27);
            this.LblMiembros.TabIndex = 65;
            this.LblMiembros.Text = "Miembros Añadidos:";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BtnEliminar.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.BtnEliminar.Location = new System.Drawing.Point(521, 274);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 30);
            this.BtnEliminar.TabIndex = 67;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.TxtCorreo.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.TxtCorreo.Location = new System.Drawing.Point(164, 124);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(345, 35);
            this.TxtCorreo.TabIndex = 63;
            // 
            // BtnAñadir
            // 
            this.BtnAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.BtnAñadir.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.BtnAñadir.Location = new System.Drawing.Point(526, 125);
            this.BtnAñadir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAñadir.Name = "BtnAñadir";
            this.BtnAñadir.Size = new System.Drawing.Size(70, 31);
            this.BtnAñadir.TabIndex = 66;
            this.BtnAñadir.Text = "Añadir";
            this.BtnAñadir.UseVisualStyleBackColor = false;
            this.BtnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // CboAmigos
            // 
            this.CboAmigos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.CboAmigos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAmigos.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.CboAmigos.FormattingEnabled = true;
            this.CboAmigos.Location = new System.Drawing.Point(164, 67);
            this.CboAmigos.Margin = new System.Windows.Forms.Padding(2);
            this.CboAmigos.Name = "CboAmigos";
            this.CboAmigos.Size = new System.Drawing.Size(345, 35);
            this.CboAmigos.TabIndex = 62;
            this.CboAmigos.SelectedIndexChanged += new System.EventHandler(this.CboAmigos_SelectedIndexChanged);
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LblCorreo.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblCorreo.Location = new System.Drawing.Point(30, 128);
            this.LblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(133, 27);
            this.LblCorreo.TabIndex = 64;
            this.LblCorreo.Text = "Añadir por correo:";
            // 
            // FrmCrearProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.PanelCrearProyecto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCrearProyecto";
            this.Text = "FrmCrearProyecto";
            this.Resize += new System.EventHandler(this.FrmCrearProyecto_Resize);
            this.PanelCrearProyecto.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panelMiembros.ResumeLayout(false);
            this.panelMiembros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelCrearProyecto;
        private System.Windows.Forms.ListView LstMiembros;
        private System.Windows.Forms.ColumnHeader ClmUsuario;
        private System.Windows.Forms.ColumnHeader ClmCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAñadir;
        private System.Windows.Forms.Label LblMiembros;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.ComboBox CboAmigos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RtxtDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblNombreProyecto;
        private System.Windows.Forms.Label LblNuevoProyecto;
        private System.Windows.Forms.TextBox TxtNombreProyecto;
        private FontAwesome.Sharp.IconButton IcbVolverInicio;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Panel panelMiembros;
    }
}



