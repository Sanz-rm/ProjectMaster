namespace ProjectMaster
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtPas = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblRegistro = new System.Windows.Forms.Label();
            this.BtnRegistro = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.LblPas = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.LnkOlvidePassword = new System.Windows.Forms.LinkLabel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.IcbNoVerPas = new FontAwesome.Sharp.IconButton();
            this.IcbVerPas = new FontAwesome.Sharp.IconButton();
            this.panelMain.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtPas
            // 
            this.TxtPas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.TxtPas.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.TxtPas.Location = new System.Drawing.Point(157, 188);
            this.TxtPas.Name = "TxtPas";
            this.TxtPas.ShortcutsEnabled = false;
            this.TxtPas.Size = new System.Drawing.Size(342, 35);
            this.TxtPas.TabIndex = 38;
            this.TxtPas.UseSystemPasswordChar = true;
            this.TxtPas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPas_KeyDown);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.TxtUsuario.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.TxtUsuario.Location = new System.Drawing.Point(157, 139);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(342, 35);
            this.TxtUsuario.TabIndex = 37;
            // 
            // LblRegistro
            // 
            this.LblRegistro.AutoSize = true;
            this.LblRegistro.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblRegistro.Location = new System.Drawing.Point(267, 329);
            this.LblRegistro.Name = "LblRegistro";
            this.LblRegistro.Size = new System.Drawing.Size(101, 13);
            this.LblRegistro.TabIndex = 36;
            this.LblRegistro.Text = "¿No tienes usuario?";
            // 
            // BtnRegistro
            // 
            this.BtnRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.BtnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistro.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.BtnRegistro.Location = new System.Drawing.Point(250, 350);
            this.BtnRegistro.Name = "BtnRegistro";
            this.BtnRegistro.Size = new System.Drawing.Size(134, 31);
            this.BtnRegistro.TabIndex = 35;
            this.BtnRegistro.Text = "Regístrate";
            this.BtnRegistro.UseVisualStyleBackColor = false;
            this.BtnRegistro.Click += new System.EventHandler(this.BtnRegistro_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.BtnLimpiar.Location = new System.Drawing.Point(329, 243);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 31);
            this.BtnLimpiar.TabIndex = 34;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.BtnAceptar.Location = new System.Drawing.Point(235, 243);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 31);
            this.BtnAceptar.TabIndex = 33;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // LblPas
            // 
            this.LblPas.AutoSize = true;
            this.LblPas.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LblPas.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblPas.Location = new System.Drawing.Point(56, 196);
            this.LblPas.Name = "LblPas";
            this.LblPas.Size = new System.Drawing.Size(89, 27);
            this.LblPas.TabIndex = 32;
            this.LblPas.Text = "Contraseña:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LblUsuario.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblUsuario.Location = new System.Drawing.Point(37, 145);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(108, 27);
            this.LblUsuario.TabIndex = 31;
            this.LblUsuario.Text = "Usuario/Email:";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Myanmar Text", 20F);
            this.LblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblTitulo.Location = new System.Drawing.Point(174, 40);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(234, 48);
            this.LblTitulo.TabIndex = 30;
            this.LblTitulo.Text = "INICIO DE SESIÓN";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 600);
            this.panelMain.TabIndex = 41;
            // 
            // panelContent
            // 
            this.panelContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContent.Controls.Add(this.IcbNoVerPas);
            this.panelContent.Controls.Add(this.LnkOlvidePassword);
            this.panelContent.Controls.Add(this.LblTitulo);
            this.panelContent.Controls.Add(this.IcbVerPas);
            this.panelContent.Controls.Add(this.TxtPas);
            this.panelContent.Controls.Add(this.BtnAceptar);
            this.panelContent.Controls.Add(this.TxtUsuario);
            this.panelContent.Controls.Add(this.BtnLimpiar);
            this.panelContent.Controls.Add(this.LblRegistro);
            this.panelContent.Controls.Add(this.BtnRegistro);
            this.panelContent.Controls.Add(this.LblPas);
            this.panelContent.Controls.Add(this.LblUsuario);
            this.panelContent.Location = new System.Drawing.Point(111, 77);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(579, 445);
            this.panelContent.TabIndex = 41;
            // 
            // LnkOlvidePassword
            // 
            this.LnkOlvidePassword.AutoSize = true;
            this.LnkOlvidePassword.Location = new System.Drawing.Point(243, 290);
            this.LnkOlvidePassword.Name = "LnkOlvidePassword";
            this.LnkOlvidePassword.Size = new System.Drawing.Size(149, 13);
            this.LnkOlvidePassword.TabIndex = 42;
            this.LnkOlvidePassword.TabStop = true;
            this.LnkOlvidePassword.Text = "¿Has olvidado tu contraseña?";
            this.LnkOlvidePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkOlvidePassword_LinkClicked);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 572);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 28);
            this.panelFooter.TabIndex = 42;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 28);
            this.panelHeader.TabIndex = 43;
            // 
            // IcbNoVerPas
            // 
            this.IcbNoVerPas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcbNoVerPas.ForeColor = System.Drawing.SystemColors.Control;
            this.IcbNoVerPas.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.IcbNoVerPas.IconColor = System.Drawing.Color.Gray;
            this.IcbNoVerPas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcbNoVerPas.IconSize = 30;
            this.IcbNoVerPas.Location = new System.Drawing.Point(505, 191);
            this.IcbNoVerPas.Name = "IcbNoVerPas";
            this.IcbNoVerPas.Size = new System.Drawing.Size(32, 30);
            this.IcbNoVerPas.TabIndex = 56;
            this.IcbNoVerPas.UseVisualStyleBackColor = true;
            this.IcbNoVerPas.Visible = false;
            this.IcbNoVerPas.Click += new System.EventHandler(this.IcbNoVerPas_Click);
            // 
            // IcbVerPas
            // 
            this.IcbVerPas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcbVerPas.ForeColor = System.Drawing.SystemColors.Control;
            this.IcbVerPas.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.IcbVerPas.IconColor = System.Drawing.Color.Gray;
            this.IcbVerPas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcbVerPas.IconSize = 27;
            this.IcbVerPas.Location = new System.Drawing.Point(505, 191);
            this.IcbVerPas.Name = "IcbVerPas";
            this.IcbVerPas.Size = new System.Drawing.Size(32, 30);
            this.IcbVerPas.TabIndex = 40;
            this.IcbVerPas.UseVisualStyleBackColor = true;
            this.IcbVerPas.Click += new System.EventHandler(this.IcbVerPas_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelMain);
            this.Name = "FrmInicio";
            this.Text = "Inicio de Sesión";
            this.Resize += new System.EventHandler(this.FrmInicio_Resize);
            this.panelMain.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton IcbVerPas;
        private System.Windows.Forms.TextBox TxtPas;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblRegistro;
        private System.Windows.Forms.Button BtnRegistro;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblPas;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.LinkLabel LnkOlvidePassword;
        private FontAwesome.Sharp.IconButton IcbNoVerPas;
    }
}
