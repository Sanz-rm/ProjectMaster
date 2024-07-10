namespace ProjectMaster.Formulario.Perfil
{
    partial class FrmVerPerfil
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
            this.PanelVerPerfil = new System.Windows.Forms.Panel();
            this.panelPerf = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtNomReal = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.LblNomReal = new System.Windows.Forms.Label();
            this.panelPcomun = new System.Windows.Forms.Panel();
            this.LstProyectosId = new System.Windows.Forms.ListBox();
            this.LstProyectos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.LblPpriv = new System.Windows.Forms.Label();
            this.BtnAddDelAmigo = new System.Windows.Forms.Button();
            this.PcbConfidencial = new System.Windows.Forms.PictureBox();
            this.PcbAvatar = new System.Windows.Forms.PictureBox();
            this.BtnChat = new System.Windows.Forms.Button();
            this.IcbVolverInicio = new FontAwesome.Sharp.IconButton();
            this.PanelVerPerfil.SuspendLayout();
            this.panelPerf.SuspendLayout();
            this.panelPcomun.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbConfidencial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelVerPerfil
            // 
            this.PanelVerPerfil.AutoScroll = true;
            this.PanelVerPerfil.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PanelVerPerfil.Controls.Add(this.panelPerf);
            this.PanelVerPerfil.Controls.Add(this.panelPcomun);
            this.PanelVerPerfil.Controls.Add(this.panelTop);
            this.PanelVerPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelVerPerfil.Location = new System.Drawing.Point(0, 0);
            this.PanelVerPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.PanelVerPerfil.Name = "PanelVerPerfil";
            this.PanelVerPerfil.Size = new System.Drawing.Size(1028, 609);
            this.PanelVerPerfil.TabIndex = 1;
            // 
            // panelPerf
            // 
            this.panelPerf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.panelPerf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPerf.Controls.Add(this.LblTitulo);
            this.panelPerf.Controls.Add(this.PcbConfidencial);
            this.panelPerf.Controls.Add(this.PcbAvatar);
            this.panelPerf.Controls.Add(this.LblUsuario);
            this.panelPerf.Controls.Add(this.TxtTelefono);
            this.panelPerf.Controls.Add(this.BtnChat);
            this.panelPerf.Controls.Add(this.TxtNomReal);
            this.panelPerf.Controls.Add(this.TxtCorreo);
            this.panelPerf.Controls.Add(this.TxtUsuario);
            this.panelPerf.Controls.Add(this.LblTelefono);
            this.panelPerf.Controls.Add(this.LblCorreo);
            this.panelPerf.Controls.Add(this.LblNomReal);
            this.panelPerf.Location = new System.Drawing.Point(318, 136);
            this.panelPerf.Margin = new System.Windows.Forms.Padding(2);
            this.panelPerf.Name = "panelPerf";
            this.panelPerf.Size = new System.Drawing.Size(557, 473);
            this.panelPerf.TabIndex = 100;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.LblTitulo.Font = new System.Drawing.Font("Myanmar Text", 20F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblTitulo.Location = new System.Drawing.Point(193, 79);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(147, 48);
            this.LblTitulo.TabIndex = 48;
            this.LblTitulo.Text = "PERFIL DE";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LblUsuario.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblUsuario.Location = new System.Drawing.Point(58, 213);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(142, 27);
            this.LblUsuario.TabIndex = 47;
            this.LblUsuario.Text = "NOMBRE USUARIO:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.TxtTelefono.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.TxtTelefono.ForeColor = System.Drawing.Color.SteelBlue;
            this.TxtTelefono.Location = new System.Drawing.Point(200, 359);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.ReadOnly = true;
            this.TxtTelefono.Size = new System.Drawing.Size(267, 35);
            this.TxtTelefono.TabIndex = 55;
            // 
            // TxtNomReal
            // 
            this.TxtNomReal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.TxtNomReal.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.TxtNomReal.ForeColor = System.Drawing.Color.SteelBlue;
            this.TxtNomReal.Location = new System.Drawing.Point(200, 305);
            this.TxtNomReal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNomReal.Name = "TxtNomReal";
            this.TxtNomReal.ReadOnly = true;
            this.TxtNomReal.Size = new System.Drawing.Size(267, 35);
            this.TxtNomReal.TabIndex = 54;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.TxtCorreo.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.TxtCorreo.ForeColor = System.Drawing.Color.SteelBlue;
            this.TxtCorreo.Location = new System.Drawing.Point(200, 256);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.ReadOnly = true;
            this.TxtCorreo.Size = new System.Drawing.Size(267, 35);
            this.TxtCorreo.TabIndex = 53;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.TxtUsuario.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.TxtUsuario.ForeColor = System.Drawing.Color.SteelBlue;
            this.TxtUsuario.Location = new System.Drawing.Point(200, 209);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.ReadOnly = true;
            this.TxtUsuario.Size = new System.Drawing.Size(267, 35);
            this.TxtUsuario.TabIndex = 52;
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LblTelefono.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblTelefono.Location = new System.Drawing.Point(106, 363);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(86, 27);
            this.LblTelefono.TabIndex = 50;
            this.LblTelefono.Text = "TELÉFONO:";
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LblCorreo.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblCorreo.Location = new System.Drawing.Point(120, 260);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(72, 27);
            this.LblCorreo.TabIndex = 51;
            this.LblCorreo.Text = "CORREO:";
            // 
            // LblNomReal
            // 
            this.LblNomReal.AutoSize = true;
            this.LblNomReal.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LblNomReal.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblNomReal.Location = new System.Drawing.Point(81, 311);
            this.LblNomReal.Name = "LblNomReal";
            this.LblNomReal.Size = new System.Drawing.Size(114, 27);
            this.LblNomReal.TabIndex = 49;
            this.LblNomReal.Text = "NOMBRE REAL:";
            // 
            // panelPcomun
            // 
            this.panelPcomun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.panelPcomun.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPcomun.Controls.Add(this.LstProyectosId);
            this.panelPcomun.Controls.Add(this.LstProyectos);
            this.panelPcomun.Controls.Add(this.label1);
            this.panelPcomun.Location = new System.Drawing.Point(930, 136);
            this.panelPcomun.Margin = new System.Windows.Forms.Padding(2);
            this.panelPcomun.Name = "panelPcomun";
            this.panelPcomun.Size = new System.Drawing.Size(488, 473);
            this.panelPcomun.TabIndex = 101;
            // 
            // LstProyectosId
            // 
            this.LstProyectosId.BackColor = System.Drawing.SystemColors.Control;
            this.LstProyectosId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstProyectosId.FormattingEnabled = true;
            this.LstProyectosId.Location = new System.Drawing.Point(373, 193);
            this.LstProyectosId.Margin = new System.Windows.Forms.Padding(2);
            this.LstProyectosId.Name = "LstProyectosId";
            this.LstProyectosId.Size = new System.Drawing.Size(128, 156);
            this.LstProyectosId.TabIndex = 99;
            this.LstProyectosId.Visible = false;
            // 
            // LstProyectos
            // 
            this.LstProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.LstProyectos.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LstProyectos.FormattingEnabled = true;
            this.LstProyectos.ItemHeight = 27;
            this.LstProyectos.Location = new System.Drawing.Point(98, 101);
            this.LstProyectos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LstProyectos.Name = "LstProyectos";
            this.LstProyectos.Size = new System.Drawing.Size(270, 328);
            this.LstProyectos.TabIndex = 58;
            this.LstProyectos.SelectedIndexChanged += new System.EventHandler(this.LstProyectos_SelectedIndexChanged);
            this.LstProyectos.DoubleClick += new System.EventHandler(this.LstProyectos_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(71, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 48);
            this.label1.TabIndex = 57;
            this.label1.Text = "PROYECTOS EN COMÚN:";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.panelTop.Controls.Add(this.LblPpriv);
            this.panelTop.Controls.Add(this.BtnAddDelAmigo);
            this.panelTop.Controls.Add(this.IcbVolverInicio);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1418, 89);
            this.panelTop.TabIndex = 102;
            // 
            // LblPpriv
            // 
            this.LblPpriv.AutoSize = true;
            this.LblPpriv.Font = new System.Drawing.Font("Myanmar Text", 20F, System.Drawing.FontStyle.Bold);
            this.LblPpriv.Location = new System.Drawing.Point(682, 22);
            this.LblPpriv.Name = "LblPpriv";
            this.LblPpriv.Size = new System.Drawing.Size(113, 48);
            this.LblPpriv.TabIndex = 59;
            this.LblPpriv.Text = "PERFIL ";
            // 
            // BtnAddDelAmigo
            // 
            this.BtnAddDelAmigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.BtnAddDelAmigo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAddDelAmigo.Location = new System.Drawing.Point(1580, 28);
            this.BtnAddDelAmigo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddDelAmigo.Name = "BtnAddDelAmigo";
            this.BtnAddDelAmigo.Size = new System.Drawing.Size(166, 41);
            this.BtnAddDelAmigo.TabIndex = 60;
            this.BtnAddDelAmigo.Text = "ACCION";
            this.BtnAddDelAmigo.UseVisualStyleBackColor = false;
            this.BtnAddDelAmigo.Click += new System.EventHandler(this.BtnEliminarAmigo_Click);
            // 
            // PcbConfidencial
            // 
            this.PcbConfidencial.Image = global::ProjectMaster.Properties.Resources.confidencial;
            this.PcbConfidencial.Location = new System.Drawing.Point(227, 203);
            this.PcbConfidencial.Name = "PcbConfidencial";
            this.PcbConfidencial.Size = new System.Drawing.Size(268, 187);
            this.PcbConfidencial.TabIndex = 98;
            this.PcbConfidencial.TabStop = false;
            this.PcbConfidencial.Visible = false;
            // 
            // PcbAvatar
            // 
            this.PcbAvatar.Location = new System.Drawing.Point(57, 42);
            this.PcbAvatar.Name = "PcbAvatar";
            this.PcbAvatar.Size = new System.Drawing.Size(98, 111);
            this.PcbAvatar.TabIndex = 97;
            this.PcbAvatar.TabStop = false;
            // 
            // BtnChat
            // 
            this.BtnChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.BtnChat.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.BtnChat.Image = global::ProjectMaster.Properties.Resources.charla;
            this.BtnChat.Location = new System.Drawing.Point(35, 401);
            this.BtnChat.Margin = new System.Windows.Forms.Padding(2);
            this.BtnChat.Name = "BtnChat";
            this.BtnChat.Size = new System.Drawing.Size(85, 66);
            this.BtnChat.TabIndex = 56;
            this.BtnChat.Text = "CHAT";
            this.BtnChat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnChat.UseVisualStyleBackColor = false;
            this.BtnChat.Click += new System.EventHandler(this.BtnChat_Click);
            // 
            // IcbVolverInicio
            // 
            this.IcbVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcbVolverInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.IcbVolverInicio.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IcbVolverInicio.IconColor = System.Drawing.Color.Black;
            this.IcbVolverInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcbVolverInicio.Location = new System.Drawing.Point(53, 14);
            this.IcbVolverInicio.Name = "IcbVolverInicio";
            this.IcbVolverInicio.Size = new System.Drawing.Size(72, 67);
            this.IcbVolverInicio.TabIndex = 59;
            this.IcbVolverInicio.UseVisualStyleBackColor = true;
            this.IcbVolverInicio.Click += new System.EventHandler(this.IcbVolverInicio_Click);
            // 
            // FrmVerPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.PanelVerPerfil);
            this.Name = "FrmVerPerfil";
            this.Text = "FrmVerPerfil";
            this.Resize += new System.EventHandler(this.FrmVerPerfil_Resize);
            this.PanelVerPerfil.ResumeLayout(false);
            this.panelPerf.ResumeLayout(false);
            this.panelPerf.PerformLayout();
            this.panelPcomun.ResumeLayout(false);
            this.panelPcomun.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbConfidencial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelVerPerfil;
        private System.Windows.Forms.ListBox LstProyectos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnChat;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtNomReal;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblNomReal;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblUsuario;
        private FontAwesome.Sharp.IconButton IcbVolverInicio;
        private System.Windows.Forms.Button BtnAddDelAmigo;
        private System.Windows.Forms.PictureBox PcbAvatar;
        private System.Windows.Forms.PictureBox PcbConfidencial;
        private System.Windows.Forms.ListBox LstProyectosId;
        private System.Windows.Forms.Panel panelPerf;
        private System.Windows.Forms.Panel panelPcomun;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label LblPpriv;
    }
}

