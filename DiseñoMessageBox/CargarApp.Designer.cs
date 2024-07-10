namespace ProjectMaster.DiseñoMessageBox
{
    partial class CargarApp
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lblEslogan = new System.Windows.Forms.Label();
            this.PcbLogo = new System.Windows.Forms.PictureBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.lblEslogan);
            this.Panel1.Controls.Add(this.PcbLogo);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(466, 343);
            this.Panel1.TabIndex = 0;
            // 
            // lblEslogan
            // 
            this.lblEslogan.AutoSize = true;
            this.lblEslogan.BackColor = System.Drawing.Color.Transparent;
            this.lblEslogan.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.lblEslogan.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEslogan.Location = new System.Drawing.Point(108, 312);
            this.lblEslogan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEslogan.Name = "lblEslogan";
            this.lblEslogan.Size = new System.Drawing.Size(345, 29);
            this.lblEslogan.TabIndex = 1;
            this.lblEslogan.Text = "Organiza, gestiona y triunfa...                           ";
            // 
            // PcbLogo
            // 
            this.PcbLogo.Image = global::ProjectMaster.Properties.Resources.logo_carga;
            this.PcbLogo.Location = new System.Drawing.Point(2, -16);
            this.PcbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PcbLogo.Name = "PcbLogo";
            this.PcbLogo.Size = new System.Drawing.Size(462, 350);
            this.PcbLogo.TabIndex = 0;
            this.PcbLogo.TabStop = false;
            this.PcbLogo.Click += new System.EventHandler(this.PcbLogo_Click);
            // 
            // CargarApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 343);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(466, 343);
            this.MinimumSize = new System.Drawing.Size(466, 343);
            this.Name = "CargarApp";
            this.Text = "¡BIENVENIDO!";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label lblEslogan;
        private System.Windows.Forms.PictureBox PcbLogo;
    }
}