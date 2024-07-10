namespace ProjectMaster.Formulario.Perfil
{
    partial class FrmNotificacion
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
            this.IcbVolverInicio = new FontAwesome.Sharp.IconButton();
            this.LstNotificaciones = new System.Windows.Forms.ListView();
            this.ClmMensaje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.RdbLeidas = new System.Windows.Forms.RadioButton();
            this.RdbTodas = new System.Windows.Forms.RadioButton();
            this.RdbNoLeidas = new System.Windows.Forms.RadioButton();
            this.BtnEliminarNotifiaciones = new System.Windows.Forms.Button();
            this.BtnEliminarNotificacion = new System.Windows.Forms.Button();
            this.panelCentr = new System.Windows.Forms.Panel();
            this.panelDer = new System.Windows.Forms.Panel();
            this.panelIzq = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCentr.SuspendLayout();
            this.panelDer.SuspendLayout();
            this.panelIzq.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // IcbVolverInicio
            // 
            this.IcbVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcbVolverInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.IcbVolverInicio.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IcbVolverInicio.IconColor = System.Drawing.Color.Black;
            this.IcbVolverInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcbVolverInicio.Location = new System.Drawing.Point(25, 13);
            this.IcbVolverInicio.Name = "IcbVolverInicio";
            this.IcbVolverInicio.Size = new System.Drawing.Size(72, 67);
            this.IcbVolverInicio.TabIndex = 56;
            this.IcbVolverInicio.UseVisualStyleBackColor = true;
            this.IcbVolverInicio.Click += new System.EventHandler(this.IcbVolverInicio_Click);
            // 
            // LstNotificaciones
            // 
            this.LstNotificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(254)))));
            this.LstNotificaciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmMensaje,
            this.ClmFecha});
            this.LstNotificaciones.Font = new System.Drawing.Font("Myanmar Text", 14F);
            this.LstNotificaciones.HideSelection = false;
            this.LstNotificaciones.Location = new System.Drawing.Point(175, 183);
            this.LstNotificaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LstNotificaciones.MultiSelect = false;
            this.LstNotificaciones.Name = "LstNotificaciones";
            this.LstNotificaciones.Size = new System.Drawing.Size(957, 399);
            this.LstNotificaciones.TabIndex = 86;
            this.LstNotificaciones.UseCompatibleStateImageBehavior = false;
            this.LstNotificaciones.View = System.Windows.Forms.View.Details;
            // 
            // ClmMensaje
            // 
            this.ClmMensaje.Text = "Mensaje";
            this.ClmMensaje.Width = 700;
            // 
            // ClmFecha
            // 
            this.ClmFecha.Text = "Fecha";
            this.ClmFecha.Width = 470;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Myanmar Text", 16F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.Location = new System.Drawing.Point(740, 25);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(244, 39);
            this.LblTitulo.TabIndex = 94;
            this.LblTitulo.Text = "TUS NOTIFICACIONES";
            // 
            // RdbLeidas
            // 
            this.RdbLeidas.AutoSize = true;
            this.RdbLeidas.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.RdbLeidas.Location = new System.Drawing.Point(74, 263);
            this.RdbLeidas.Name = "RdbLeidas";
            this.RdbLeidas.Size = new System.Drawing.Size(75, 33);
            this.RdbLeidas.TabIndex = 96;
            this.RdbLeidas.Text = "Leidas";
            this.RdbLeidas.UseVisualStyleBackColor = true;
            this.RdbLeidas.CheckedChanged += new System.EventHandler(this.RdbLeidas_CheckedChanged);
            // 
            // RdbTodas
            // 
            this.RdbTodas.AutoSize = true;
            this.RdbTodas.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.RdbTodas.Location = new System.Drawing.Point(76, 224);
            this.RdbTodas.Name = "RdbTodas";
            this.RdbTodas.Size = new System.Drawing.Size(72, 33);
            this.RdbTodas.TabIndex = 95;
            this.RdbTodas.Text = "Todas";
            this.RdbTodas.UseVisualStyleBackColor = true;
            this.RdbTodas.CheckedChanged += new System.EventHandler(this.RdbTodas_CheckedChanged);
            // 
            // RdbNoLeidas
            // 
            this.RdbNoLeidas.AutoSize = true;
            this.RdbNoLeidas.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.RdbNoLeidas.Location = new System.Drawing.Point(74, 301);
            this.RdbNoLeidas.Name = "RdbNoLeidas";
            this.RdbNoLeidas.Size = new System.Drawing.Size(96, 33);
            this.RdbNoLeidas.TabIndex = 97;
            this.RdbNoLeidas.Text = "No leidas";
            this.RdbNoLeidas.UseVisualStyleBackColor = true;
            this.RdbNoLeidas.CheckedChanged += new System.EventHandler(this.RdbNoLeidas_CheckedChanged);
            // 
            // BtnEliminarNotifiaciones
            // 
            this.BtnEliminarNotifiaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BtnEliminarNotifiaciones.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.BtnEliminarNotifiaciones.Location = new System.Drawing.Point(63, 301);
            this.BtnEliminarNotifiaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEliminarNotifiaciones.Name = "BtnEliminarNotifiaciones";
            this.BtnEliminarNotifiaciones.Size = new System.Drawing.Size(115, 93);
            this.BtnEliminarNotifiaciones.TabIndex = 98;
            this.BtnEliminarNotifiaciones.Text = "ELIMINAR TODAS";
            this.BtnEliminarNotifiaciones.UseVisualStyleBackColor = false;
            this.BtnEliminarNotifiaciones.Click += new System.EventHandler(this.BtnEliminarNotificaciones_Click);
            // 
            // BtnEliminarNotificacion
            // 
            this.BtnEliminarNotificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.BtnEliminarNotificacion.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.BtnEliminarNotificacion.Location = new System.Drawing.Point(63, 245);
            this.BtnEliminarNotificacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEliminarNotificacion.Name = "BtnEliminarNotificacion";
            this.BtnEliminarNotificacion.Size = new System.Drawing.Size(115, 33);
            this.BtnEliminarNotificacion.TabIndex = 99;
            this.BtnEliminarNotificacion.Text = "ELIMINAR NOTIFICACION";
            this.BtnEliminarNotificacion.UseVisualStyleBackColor = false;
            this.BtnEliminarNotificacion.Click += new System.EventHandler(this.BtnEliminarNotificacion_Click);
            // 
            // panelCentr
            // 
            this.panelCentr.AutoScroll = true;
            this.panelCentr.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelCentr.Controls.Add(this.panelDer);
            this.panelCentr.Controls.Add(this.LstNotificaciones);
            this.panelCentr.Controls.Add(this.panelIzq);
            this.panelCentr.Controls.Add(this.panelTop);
            this.panelCentr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentr.Location = new System.Drawing.Point(0, 0);
            this.panelCentr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCentr.Name = "panelCentr";
            this.panelCentr.Size = new System.Drawing.Size(1028, 609);
            this.panelCentr.TabIndex = 100;
            // 
            // panelDer
            // 
            this.panelDer.Controls.Add(this.BtnEliminarNotificacion);
            this.panelDer.Controls.Add(this.BtnEliminarNotifiaciones);
            this.panelDer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDer.Location = new System.Drawing.Point(1132, 89);
            this.panelDer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDer.Name = "panelDer";
            this.panelDer.Size = new System.Drawing.Size(146, 503);
            this.panelDer.TabIndex = 102;
            // 
            // panelIzq
            // 
            this.panelIzq.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelIzq.Controls.Add(this.RdbNoLeidas);
            this.panelIzq.Controls.Add(this.RdbTodas);
            this.panelIzq.Controls.Add(this.RdbLeidas);
            this.panelIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzq.Location = new System.Drawing.Point(0, 89);
            this.panelIzq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelIzq.Name = "panelIzq";
            this.panelIzq.Size = new System.Drawing.Size(171, 503);
            this.panelIzq.TabIndex = 101;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.panelTop.Controls.Add(this.LblTitulo);
            this.panelTop.Controls.Add(this.IcbVolverInicio);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1278, 89);
            this.panelTop.TabIndex = 100;
            // 
            // FrmNotificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.panelCentr);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmNotificacion";
            this.Text = "FrmNotificacion";
            this.Resize += new System.EventHandler(this.FrmNotificacion_Resize);
            this.panelCentr.ResumeLayout(false);
            this.panelDer.ResumeLayout(false);
            this.panelIzq.ResumeLayout(false);
            this.panelIzq.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton IcbVolverInicio;
        private System.Windows.Forms.ListView LstNotificaciones;
        private System.Windows.Forms.ColumnHeader ClmMensaje;
        private System.Windows.Forms.ColumnHeader ClmFecha;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.RadioButton RdbLeidas;
        private System.Windows.Forms.RadioButton RdbTodas;
        private System.Windows.Forms.RadioButton RdbNoLeidas;
        private System.Windows.Forms.Button BtnEliminarNotifiaciones;
        private System.Windows.Forms.Button BtnEliminarNotificacion;
        private System.Windows.Forms.Panel panelCentr;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelIzq;
        private System.Windows.Forms.Panel panelDer;
    }
}