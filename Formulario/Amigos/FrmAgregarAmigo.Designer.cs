namespace ProjectMaster.Formulario.Amigos
{
    partial class FrmAgregarAmigo
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
            this.PanelAgregarAmigos = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.IcbVolverInicio = new FontAwesome.Sharp.IconButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.panelCentr = new System.Windows.Forms.Panel();
            this.LblTitUsuariosDisp = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TxtAmigo = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LblAmigo = new System.Windows.Forms.Label();
            this.LblAgregar = new System.Windows.Forms.Label();
            this.LstAmigos = new System.Windows.Forms.ListView();
            this.ClmUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmCorreo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PanelAgregarAmigos.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelCentr.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelAgregarAmigos
            // 
            this.PanelAgregarAmigos.AutoScroll = true;
            this.PanelAgregarAmigos.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PanelAgregarAmigos.Controls.Add(this.panelTop);
            this.PanelAgregarAmigos.Controls.Add(this.panelCentr);
            this.PanelAgregarAmigos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAgregarAmigos.Location = new System.Drawing.Point(0, 0);
            this.PanelAgregarAmigos.Margin = new System.Windows.Forms.Padding(2);
            this.PanelAgregarAmigos.Name = "PanelAgregarAmigos";
            this.PanelAgregarAmigos.Size = new System.Drawing.Size(1028, 609);
            this.PanelAgregarAmigos.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.panelTop.Controls.Add(this.IcbVolverInicio);
            this.panelTop.Controls.Add(this.LblTitulo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1028, 93);
            this.panelTop.TabIndex = 58;
            // 
            // IcbVolverInicio
            // 
            this.IcbVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcbVolverInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.IcbVolverInicio.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IcbVolverInicio.IconColor = System.Drawing.Color.Black;
            this.IcbVolverInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcbVolverInicio.Location = new System.Drawing.Point(32, 15);
            this.IcbVolverInicio.Name = "IcbVolverInicio";
            this.IcbVolverInicio.Size = new System.Drawing.Size(72, 67);
            this.IcbVolverInicio.TabIndex = 54;
            this.IcbVolverInicio.UseVisualStyleBackColor = true;
            this.IcbVolverInicio.Click += new System.EventHandler(this.IcbVolverInicio_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Myanmar Text", 20F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.Location = new System.Drawing.Point(762, 24);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(241, 48);
            this.LblTitulo.TabIndex = 13;
            this.LblTitulo.Text = "AÑADIR AMIGOS";
            // 
            // panelCentr
            // 
            this.panelCentr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.panelCentr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCentr.Controls.Add(this.LblTitUsuariosDisp);
            this.panelCentr.Controls.Add(this.LblUsuario);
            this.panelCentr.Controls.Add(this.TxtAmigo);
            this.panelCentr.Controls.Add(this.BtnAgregar);
            this.panelCentr.Controls.Add(this.LblAmigo);
            this.panelCentr.Controls.Add(this.LblAgregar);
            this.panelCentr.Controls.Add(this.LstAmigos);
            this.panelCentr.Location = new System.Drawing.Point(11, 97);
            this.panelCentr.Margin = new System.Windows.Forms.Padding(2);
            this.panelCentr.Name = "panelCentr";
            this.panelCentr.Size = new System.Drawing.Size(1017, 512);
            this.panelCentr.TabIndex = 59;
            // 
            // LblTitUsuariosDisp
            // 
            this.LblTitUsuariosDisp.AutoSize = true;
            this.LblTitUsuariosDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.LblTitUsuariosDisp.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.LblTitUsuariosDisp.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblTitUsuariosDisp.Location = new System.Drawing.Point(109, 73);
            this.LblTitUsuariosDisp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitUsuariosDisp.Name = "LblTitUsuariosDisp";
            this.LblTitUsuariosDisp.Size = new System.Drawing.Size(191, 29);
            this.LblTitUsuariosDisp.TabIndex = 59;
            this.LblTitUsuariosDisp.Text = "USUARIOS DISPONIBLES:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.LblUsuario.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.LblUsuario.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblUsuario.Location = new System.Drawing.Point(408, 454);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(180, 29);
            this.LblUsuario.TabIndex = 58;
            this.LblUsuario.Text = "USUARIO A AGREGAR:";
            // 
            // TxtAmigo
            // 
            this.TxtAmigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.TxtAmigo.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.TxtAmigo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtAmigo.Location = new System.Drawing.Point(473, 32);
            this.TxtAmigo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAmigo.Name = "TxtAmigo";
            this.TxtAmigo.Size = new System.Drawing.Size(296, 37);
            this.TxtAmigo.TabIndex = 15;
            this.TxtAmigo.TextChanged += new System.EventHandler(this.TxtAmigo_TextChanged);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.BtnAgregar.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAgregar.Location = new System.Drawing.Point(663, 454);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(106, 35);
            this.BtnAgregar.TabIndex = 17;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Visible = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LblAmigo
            // 
            this.LblAmigo.AutoSize = true;
            this.LblAmigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.LblAmigo.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.LblAmigo.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblAmigo.Location = new System.Drawing.Point(109, 35);
            this.LblAmigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAmigo.Name = "LblAmigo";
            this.LblAmigo.Size = new System.Drawing.Size(345, 29);
            this.LblAmigo.TabIndex = 14;
            this.LblAmigo.Text = "BUSCA POR NOMBRE DE USUARIO O CORREO:";
            // 
            // LblAgregar
            // 
            this.LblAgregar.AutoSize = true;
            this.LblAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.LblAgregar.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.LblAgregar.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblAgregar.Location = new System.Drawing.Point(320, 454);
            this.LblAgregar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAgregar.Name = "LblAgregar";
            this.LblAgregar.Size = new System.Drawing.Size(91, 29);
            this.LblAgregar.TabIndex = 56;
            this.LblAgregar.Text = "Agregar a:";
            this.LblAgregar.Visible = false;
            // 
            // LstAmigos
            // 
            this.LstAmigos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.LstAmigos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmUsuario,
            this.ClmCorreo});
            this.LstAmigos.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.LstAmigos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LstAmigos.FullRowSelect = true;
            this.LstAmigos.HideSelection = false;
            this.LstAmigos.Location = new System.Drawing.Point(325, 73);
            this.LstAmigos.Margin = new System.Windows.Forms.Padding(2);
            this.LstAmigos.MultiSelect = false;
            this.LstAmigos.Name = "LstAmigos";
            this.LstAmigos.Size = new System.Drawing.Size(444, 366);
            this.LstAmigos.TabIndex = 55;
            this.LstAmigos.UseCompatibleStateImageBehavior = false;
            this.LstAmigos.View = System.Windows.Forms.View.Details;
            this.LstAmigos.SelectedIndexChanged += new System.EventHandler(this.LstAmigos_SelectedIndexChanged);
            // 
            // ClmUsuario
            // 
            this.ClmUsuario.Text = "Usuario";
            this.ClmUsuario.Width = 148;
            // 
            // ClmCorreo
            // 
            this.ClmCorreo.Text = "Correo";
            this.ClmCorreo.Width = 286;
            // 
            // FrmAgregarAmigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.PanelAgregarAmigos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAgregarAmigo";
            this.Text = "FrmAgregarAmigo";
            this.Resize += new System.EventHandler(this.FrmAgregarAmigo_Resize);
            this.PanelAgregarAmigos.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelCentr.ResumeLayout(false);
            this.panelCentr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAgregarAmigos;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtAmigo;
        private System.Windows.Forms.Label LblAmigo;
        private System.Windows.Forms.Label LblTitulo;
        private FontAwesome.Sharp.IconButton IcbVolverInicio;
        private System.Windows.Forms.Label LblAgregar;
        private System.Windows.Forms.ListView LstAmigos;
        private System.Windows.Forms.ColumnHeader ClmUsuario;
        private System.Windows.Forms.ColumnHeader ClmCorreo;
        private System.Windows.Forms.Panel panelCentr;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblTitUsuariosDisp;
    }
}