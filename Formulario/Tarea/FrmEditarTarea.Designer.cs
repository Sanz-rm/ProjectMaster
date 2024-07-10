namespace ProjectMaster.Formulario.Tarea
{
    partial class FrmEditarTarea
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
            this.PanelEditarTarea = new System.Windows.Forms.Panel();
            this.BtnEliminarTarea = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnEditarTarea = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.LblTituloTarea = new System.Windows.Forms.Label();
            this.IcbVolverInicio = new FontAwesome.Sharp.IconButton();
            this.panelDatosTarea = new System.Windows.Forms.Panel();
            this.LblNombreTarea = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtNombreTarea = new System.Windows.Forms.TextBox();
            this.ChkFecha = new System.Windows.Forms.CheckBox();
            this.RtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.CdrFecha = new System.Windows.Forms.MonthCalendar();
            this.LblFechaLimite = new System.Windows.Forms.Label();
            this.LblAsignar = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.LblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CboMiembros = new System.Windows.Forms.ComboBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LblPrioridad = new System.Windows.Forms.Label();
            this.LstAsignados = new System.Windows.Forms.ListView();
            this.ClmUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmCorreo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PanelEditarTarea.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelDatosTarea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelEditarTarea
            // 
            this.PanelEditarTarea.AutoScroll = true;
            this.PanelEditarTarea.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PanelEditarTarea.Controls.Add(this.BtnEliminarTarea);
            this.PanelEditarTarea.Controls.Add(this.BtnLimpiar);
            this.PanelEditarTarea.Controls.Add(this.BtnEditarTarea);
            this.PanelEditarTarea.Controls.Add(this.panelTop);
            this.PanelEditarTarea.Controls.Add(this.panelDatosTarea);
            this.PanelEditarTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEditarTarea.Location = new System.Drawing.Point(0, 0);
            this.PanelEditarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.PanelEditarTarea.Name = "PanelEditarTarea";
            this.PanelEditarTarea.Size = new System.Drawing.Size(1028, 609);
            this.PanelEditarTarea.TabIndex = 1;
            // 
            // BtnEliminarTarea
            // 
            this.BtnEliminarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BtnEliminarTarea.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.BtnEliminarTarea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminarTarea.Location = new System.Drawing.Point(1052, 860);
            this.BtnEliminarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminarTarea.Name = "BtnEliminarTarea";
            this.BtnEliminarTarea.Size = new System.Drawing.Size(94, 27);
            this.BtnEliminarTarea.TabIndex = 104;
            this.BtnEliminarTarea.Text = "ELIMINAR";
            this.BtnEliminarTarea.UseVisualStyleBackColor = false;
            this.BtnEliminarTarea.Click += new System.EventHandler(this.BtnEliminarTarea_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.BtnLimpiar.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLimpiar.Location = new System.Drawing.Point(955, 860);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(83, 27);
            this.BtnLimpiar.TabIndex = 100;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnEditarTarea
            // 
            this.BtnEditarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.BtnEditarTarea.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.BtnEditarTarea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditarTarea.Location = new System.Drawing.Point(836, 860);
            this.BtnEditarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditarTarea.Name = "BtnEditarTarea";
            this.BtnEditarTarea.Size = new System.Drawing.Size(106, 27);
            this.BtnEditarTarea.TabIndex = 99;
            this.BtnEditarTarea.Text = "EDITAR";
            this.BtnEditarTarea.UseVisualStyleBackColor = false;
            this.BtnEditarTarea.Click += new System.EventHandler(this.BtnEditarTarea_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.panelTop.Controls.Add(this.LblTituloTarea);
            this.panelTop.Controls.Add(this.IcbVolverInicio);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1420, 93);
            this.panelTop.TabIndex = 102;
            // 
            // LblTituloTarea
            // 
            this.LblTituloTarea.AutoSize = true;
            this.LblTituloTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.LblTituloTarea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTituloTarea.Location = new System.Drawing.Point(848, 39);
            this.LblTituloTarea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTituloTarea.Name = "LblTituloTarea";
            this.LblTituloTarea.Size = new System.Drawing.Size(384, 26);
            this.LblTituloTarea.TabIndex = 84;
            this.LblTituloTarea.Text = "EDITAR TAREA NOMBRE_TAREA";
            // 
            // IcbVolverInicio
            // 
            this.IcbVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcbVolverInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.IcbVolverInicio.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IcbVolverInicio.IconColor = System.Drawing.Color.Black;
            this.IcbVolverInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcbVolverInicio.Location = new System.Drawing.Point(28, 11);
            this.IcbVolverInicio.Name = "IcbVolverInicio";
            this.IcbVolverInicio.Size = new System.Drawing.Size(72, 67);
            this.IcbVolverInicio.TabIndex = 56;
            this.IcbVolverInicio.UseVisualStyleBackColor = true;
            this.IcbVolverInicio.Click += new System.EventHandler(this.IcbVolverInicio_Click);
            // 
            // panelDatosTarea
            // 
            this.panelDatosTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.panelDatosTarea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDatosTarea.Controls.Add(this.LblNombreTarea);
            this.panelDatosTarea.Controls.Add(this.LblDescripcion);
            this.panelDatosTarea.Controls.Add(this.TxtNombreTarea);
            this.panelDatosTarea.Controls.Add(this.ChkFecha);
            this.panelDatosTarea.Controls.Add(this.RtxtDescripcion);
            this.panelDatosTarea.Controls.Add(this.CdrFecha);
            this.panelDatosTarea.Controls.Add(this.LblFechaLimite);
            this.panelDatosTarea.Controls.Add(this.LblAsignar);
            this.panelDatosTarea.Controls.Add(this.numericUpDown1);
            this.panelDatosTarea.Controls.Add(this.LblFecha);
            this.panelDatosTarea.Controls.Add(this.label1);
            this.panelDatosTarea.Controls.Add(this.CboMiembros);
            this.panelDatosTarea.Controls.Add(this.BtnEliminar);
            this.panelDatosTarea.Controls.Add(this.LblPrioridad);
            this.panelDatosTarea.Controls.Add(this.LstAsignados);
            this.panelDatosTarea.Location = new System.Drawing.Point(444, 270);
            this.panelDatosTarea.Margin = new System.Windows.Forms.Padding(2);
            this.panelDatosTarea.Name = "panelDatosTarea";
            this.panelDatosTarea.Size = new System.Drawing.Size(976, 522);
            this.panelDatosTarea.TabIndex = 103;
            // 
            // LblNombreTarea
            // 
            this.LblNombreTarea.AutoSize = true;
            this.LblNombreTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.LblNombreTarea.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.LblNombreTarea.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblNombreTarea.Location = new System.Drawing.Point(46, 34);
            this.LblNombreTarea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombreTarea.Name = "LblNombreTarea";
            this.LblNombreTarea.Size = new System.Drawing.Size(151, 27);
            this.LblNombreTarea.TabIndex = 85;
            this.LblNombreTarea.Text = "Nombre de la tarea:";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.LblDescripcion.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.LblDescripcion.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblDescripcion.Location = new System.Drawing.Point(21, 80);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(177, 27);
            this.LblDescripcion.TabIndex = 86;
            this.LblDescripcion.Text = "Descripcion de la Tarea:";
            // 
            // TxtNombreTarea
            // 
            this.TxtNombreTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.TxtNombreTarea.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.TxtNombreTarea.Location = new System.Drawing.Point(212, 28);
            this.TxtNombreTarea.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombreTarea.Name = "TxtNombreTarea";
            this.TxtNombreTarea.Size = new System.Drawing.Size(317, 35);
            this.TxtNombreTarea.TabIndex = 83;
            // 
            // ChkFecha
            // 
            this.ChkFecha.AutoSize = true;
            this.ChkFecha.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.ChkFecha.ForeColor = System.Drawing.Color.SteelBlue;
            this.ChkFecha.Location = new System.Drawing.Point(724, 333);
            this.ChkFecha.Name = "ChkFecha";
            this.ChkFecha.Size = new System.Drawing.Size(138, 33);
            this.ChkFecha.TabIndex = 98;
            this.ChkFecha.Text = "Sin fecha límite";
            this.ChkFecha.UseVisualStyleBackColor = true;
            this.ChkFecha.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RtxtDescripcion
            // 
            this.RtxtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.RtxtDescripcion.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.RtxtDescripcion.Location = new System.Drawing.Point(212, 80);
            this.RtxtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.RtxtDescripcion.Name = "RtxtDescripcion";
            this.RtxtDescripcion.Size = new System.Drawing.Size(317, 116);
            this.RtxtDescripcion.TabIndex = 87;
            this.RtxtDescripcion.Text = "";
            // 
            // CdrFecha
            // 
            this.CdrFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.CdrFecha.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.CdrFecha.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.CdrFecha.Location = new System.Drawing.Point(704, 153);
            this.CdrFecha.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.CdrFecha.Name = "CdrFecha";
            this.CdrFecha.TabIndex = 93;
            this.CdrFecha.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // LblFechaLimite
            // 
            this.LblFechaLimite.AutoSize = true;
            this.LblFechaLimite.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.LblFechaLimite.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblFechaLimite.Location = new System.Drawing.Point(798, 115);
            this.LblFechaLimite.Name = "LblFechaLimite";
            this.LblFechaLimite.Size = new System.Drawing.Size(93, 29);
            this.LblFechaLimite.TabIndex = 97;
            this.LblFechaLimite.Text = "fecha límite";
            // 
            // LblAsignar
            // 
            this.LblAsignar.AutoSize = true;
            this.LblAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.LblAsignar.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.LblAsignar.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblAsignar.Location = new System.Drawing.Point(75, 219);
            this.LblAsignar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAsignar.Name = "LblAsignar";
            this.LblAsignar.Size = new System.Drawing.Size(122, 27);
            this.LblAsignar.TabIndex = 88;
            this.LblAsignar.Text = "Asignar tarea a:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.numericUpDown1.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.numericUpDown1.Location = new System.Drawing.Point(212, 444);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 35);
            this.numericUpDown1.TabIndex = 95;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.LblFecha.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblFecha.Location = new System.Drawing.Point(688, 115);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(110, 29);
            this.LblFecha.TabIndex = 92;
            this.LblFecha.Text = "Fecha límite:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(24, 454);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 27);
            this.label1.TabIndex = 96;
            this.label1.Text = "1-Alta   2-Media   3-Baja";
            // 
            // CboMiembros
            // 
            this.CboMiembros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.CboMiembros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMiembros.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.CboMiembros.FormattingEnabled = true;
            this.CboMiembros.Location = new System.Drawing.Point(212, 217);
            this.CboMiembros.Margin = new System.Windows.Forms.Padding(2);
            this.CboMiembros.Name = "CboMiembros";
            this.CboMiembros.Size = new System.Drawing.Size(317, 35);
            this.CboMiembros.TabIndex = 89;
            this.CboMiembros.SelectedIndexChanged += new System.EventHandler(this.CboMiembros_SelectedIndexChanged);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BtnEliminar.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminar.Location = new System.Drawing.Point(533, 344);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(77, 28);
            this.BtnEliminar.TabIndex = 90;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // LblPrioridad
            // 
            this.LblPrioridad.AutoSize = true;
            this.LblPrioridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.LblPrioridad.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.LblPrioridad.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblPrioridad.Location = new System.Drawing.Point(57, 427);
            this.LblPrioridad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrioridad.Name = "LblPrioridad";
            this.LblPrioridad.Size = new System.Drawing.Size(138, 27);
            this.LblPrioridad.TabIndex = 94;
            this.LblPrioridad.Text = "Asignar Prioridad:";
            // 
            // LstAsignados
            // 
            this.LstAsignados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.LstAsignados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmUsuario,
            this.ClmCorreo});
            this.LstAsignados.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LstAsignados.HideSelection = false;
            this.LstAsignados.Location = new System.Drawing.Point(212, 269);
            this.LstAsignados.Margin = new System.Windows.Forms.Padding(2);
            this.LstAsignados.MultiSelect = false;
            this.LstAsignados.Name = "LstAsignados";
            this.LstAsignados.Size = new System.Drawing.Size(317, 147);
            this.LstAsignados.TabIndex = 91;
            this.LstAsignados.UseCompatibleStateImageBehavior = false;
            this.LstAsignados.View = System.Windows.Forms.View.Details;
            // 
            // ClmUsuario
            // 
            this.ClmUsuario.Text = "Usuario";
            this.ClmUsuario.Width = 148;
            // 
            // ClmCorreo
            // 
            this.ClmCorreo.Text = "Correo";
            this.ClmCorreo.Width = 263;
            // 
            // FrmEditarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.PanelEditarTarea);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmEditarTarea";
            this.Text = "FrmEditarTarea";
            this.Resize += new System.EventHandler(this.FrmEditarTarea_Resize);
            this.PanelEditarTarea.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelDatosTarea.ResumeLayout(false);
            this.panelDatosTarea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelEditarTarea;
        private FontAwesome.Sharp.IconButton IcbVolverInicio;
        private System.Windows.Forms.CheckBox ChkFecha;
        private System.Windows.Forms.Label LblFechaLimite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label LblPrioridad;
        private System.Windows.Forms.MonthCalendar CdrFecha;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.ListView LstAsignados;
        private System.Windows.Forms.ColumnHeader ClmUsuario;
        private System.Windows.Forms.ColumnHeader ClmCorreo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.ComboBox CboMiembros;
        private System.Windows.Forms.Label LblAsignar;
        private System.Windows.Forms.RichTextBox RtxtDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblNombreTarea;
        private System.Windows.Forms.Label LblTituloTarea;
        private System.Windows.Forms.TextBox TxtNombreTarea;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnEditarTarea;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelDatosTarea;
        private System.Windows.Forms.Button BtnEliminarTarea;
    }
}