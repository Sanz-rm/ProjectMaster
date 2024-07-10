namespace ProjectMaster.DiseñoMessageBox
{
    partial class MensajeInicio
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
            this.PanelAvatar = new System.Windows.Forms.Panel();
            this.PcbAvatar = new System.Windows.Forms.PictureBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PanelAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelAvatar
            // 
            this.PanelAvatar.BackColor = System.Drawing.Color.SteelBlue;
            this.PanelAvatar.Controls.Add(this.PcbAvatar);
            this.PanelAvatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelAvatar.Location = new System.Drawing.Point(0, 0);
            this.PanelAvatar.Name = "PanelAvatar";
            this.PanelAvatar.Size = new System.Drawing.Size(224, 275);
            this.PanelAvatar.TabIndex = 104;
            // 
            // PcbAvatar
            // 
            this.PcbAvatar.Location = new System.Drawing.Point(43, 39);
            this.PcbAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.PcbAvatar.Name = "PcbAvatar";
            this.PcbAvatar.Size = new System.Drawing.Size(131, 137);
            this.PcbAvatar.TabIndex = 98;
            this.PcbAvatar.TabStop = false;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnAceptar.Location = new System.Drawing.Point(777, 220);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(115, 32);
            this.BtnAceptar.TabIndex = 103;
            this.BtnAceptar.Text = "ACEPTAR";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.SkyBlue;
            this.LblTitulo.Font = new System.Drawing.Font("Myanmar Text", 30F);
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.LblTitulo.Location = new System.Drawing.Point(248, 66);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(335, 89);
            this.LblTitulo.TabIndex = 102;
            this.LblTitulo.Text = "BIENVENIDO ";
            // 
            // MensajeInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(958, 275);
            this.Controls.Add(this.PanelAvatar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.LblTitulo);
            this.MaximumSize = new System.Drawing.Size(976, 322);
            this.MinimumSize = new System.Drawing.Size(976, 322);
            this.Name = "MensajeInicio";
            this.Opacity = 0.9D;
            this.Text = "¡BIENVENIDO!";
            this.PanelAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelAvatar;
        private System.Windows.Forms.PictureBox PcbAvatar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblTitulo;
    }
}