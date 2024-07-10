namespace ProjectMaster.Formulario.Amigos
{
    partial class FrmChat
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
            this.components = new System.ComponentModel.Container();
            this.PanelChat = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.TxtMensaje = new System.Windows.Forms.TextBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.LblContadorCar = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.IcbVolverInicio = new FontAwesome.Sharp.IconButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.panelCentr = new System.Windows.Forms.Panel();
            this.LstChatOtro = new System.Windows.Forms.ListBox();
            this.LstChatUsuario = new System.Windows.Forms.ListBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblOtro = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelChat.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelCentr.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelChat
            // 
            this.PanelChat.AutoScroll = true;
            this.PanelChat.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PanelChat.Controls.Add(this.panelBottom);
            this.PanelChat.Controls.Add(this.panelTop);
            this.PanelChat.Controls.Add(this.panelCentr);
            this.PanelChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelChat.Location = new System.Drawing.Point(0, 0);
            this.PanelChat.Margin = new System.Windows.Forms.Padding(2);
            this.PanelChat.Name = "PanelChat";
            this.PanelChat.Size = new System.Drawing.Size(1028, 609);
            this.PanelChat.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.TxtMensaje);
            this.panelBottom.Controls.Add(this.BtnEnviar);
            this.panelBottom.Controls.Add(this.LblContadorCar);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 646);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(2);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1124, 161);
            this.panelBottom.TabIndex = 63;
            // 
            // TxtMensaje
            // 
            this.TxtMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(254)))));
            this.TxtMensaje.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.TxtMensaje.Location = new System.Drawing.Point(124, 24);
            this.TxtMensaje.Name = "TxtMensaje";
            this.TxtMensaje.Size = new System.Drawing.Size(691, 32);
            this.TxtMensaje.TabIndex = 39;
            this.TxtMensaje.TextChanged += new System.EventHandler(this.TxtMensaje_TextChanged);
            this.TxtMensaje.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtMensaje_KeyDown);
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnviar.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.BtnEnviar.ForeColor = System.Drawing.Color.White;
            this.BtnEnviar.Location = new System.Drawing.Point(841, 25);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(75, 32);
            this.BtnEnviar.TabIndex = 40;
            this.BtnEnviar.Text = "ENVIAR";
            this.BtnEnviar.UseVisualStyleBackColor = false;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // LblContadorCar
            // 
            this.LblContadorCar.AutoSize = true;
            this.LblContadorCar.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.LblContadorCar.Location = new System.Drawing.Point(90, 32);
            this.LblContadorCar.Name = "LblContadorCar";
            this.LblContadorCar.Size = new System.Drawing.Size(28, 25);
            this.LblContadorCar.TabIndex = 45;
            this.LblContadorCar.Text = "40";
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
            this.panelTop.Size = new System.Drawing.Size(1124, 82);
            this.panelTop.TabIndex = 62;
            // 
            // IcbVolverInicio
            // 
            this.IcbVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcbVolverInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.IcbVolverInicio.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IcbVolverInicio.IconColor = System.Drawing.Color.Black;
            this.IcbVolverInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcbVolverInicio.Location = new System.Drawing.Point(34, 3);
            this.IcbVolverInicio.Name = "IcbVolverInicio";
            this.IcbVolverInicio.Size = new System.Drawing.Size(72, 67);
            this.IcbVolverInicio.TabIndex = 55;
            this.IcbVolverInicio.UseVisualStyleBackColor = true;
            this.IcbVolverInicio.Click += new System.EventHandler(this.IcbVolverInicio_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Myanmar Text", 20F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.Location = new System.Drawing.Point(690, 16);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(172, 48);
            this.LblTitulo.TabIndex = 38;
            this.LblTitulo.Text = "CHAT CON: ";
            // 
            // panelCentr
            // 
            this.panelCentr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.panelCentr.Controls.Add(this.LstChatOtro);
            this.panelCentr.Controls.Add(this.LstChatUsuario);
            this.panelCentr.Controls.Add(this.LblUsuario);
            this.panelCentr.Controls.Add(this.LblOtro);
            this.panelCentr.Location = new System.Drawing.Point(34, 129);
            this.panelCentr.Margin = new System.Windows.Forms.Padding(2);
            this.panelCentr.Name = "panelCentr";
            this.panelCentr.Size = new System.Drawing.Size(1090, 517);
            this.panelCentr.TabIndex = 66;
            // 
            // LstChatOtro
            // 
            this.LstChatOtro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstChatOtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(254)))));
            this.LstChatOtro.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.LstChatOtro.FormattingEnabled = true;
            this.LstChatOtro.ItemHeight = 29;
            this.LstChatOtro.Location = new System.Drawing.Point(38, 83);
            this.LstChatOtro.Name = "LstChatOtro";
            this.LstChatOtro.Size = new System.Drawing.Size(332, 410);
            this.LstChatOtro.TabIndex = 60;
            this.LstChatOtro.SelectedIndexChanged += new System.EventHandler(this.LstChatOtro_SelectedIndexChanged);
            // 
            // LstChatUsuario
            // 
            this.LstChatUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstChatUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(254)))));
            this.LstChatUsuario.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.LstChatUsuario.FormattingEnabled = true;
            this.LstChatUsuario.ItemHeight = 29;
            this.LstChatUsuario.Location = new System.Drawing.Point(734, 83);
            this.LstChatUsuario.Name = "LstChatUsuario";
            this.LstChatUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LstChatUsuario.Size = new System.Drawing.Size(333, 410);
            this.LstChatUsuario.TabIndex = 61;
            this.LstChatUsuario.SelectedIndexChanged += new System.EventHandler(this.LstChatUsuario_SelectedIndexChanged);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.LblUsuario.Location = new System.Drawing.Point(1004, 55);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(63, 25);
            this.LblUsuario.TabIndex = 44;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblOtro
            // 
            this.LblOtro.AutoSize = true;
            this.LblOtro.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.LblOtro.Location = new System.Drawing.Point(41, 55);
            this.LblOtro.Name = "LblOtro";
            this.LblOtro.Size = new System.Drawing.Size(43, 25);
            this.LblOtro.TabIndex = 43;
            this.LblOtro.Text = "Otro";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.PanelChat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmChat";
            this.Text = "FrmChat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmChat_FormClosing);
            this.Shown += new System.EventHandler(this.FrmChat_Shown);
            this.Resize += new System.EventHandler(this.FrmChat_Resize);
            this.PanelChat.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelCentr.ResumeLayout(false);
            this.panelCentr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelChat;
        private System.Windows.Forms.Label LblContadorCar;
        private System.Windows.Forms.Label LblOtro;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.TextBox TxtMensaje;
        private System.Windows.Forms.Label LblTitulo;
        private FontAwesome.Sharp.IconButton IcbVolverInicio;
        private System.Windows.Forms.ListBox LstChatOtro;
        private System.Windows.Forms.ListBox LstChatUsuario;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Panel panelCentr;
        private System.Windows.Forms.Timer timer1;
    }
}
