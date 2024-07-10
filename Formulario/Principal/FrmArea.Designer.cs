using System.Windows.Forms;

namespace ProjectMaster.Formulario.Principal
{
    partial class FrmArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArea));
            this.PanelArea = new System.Windows.Forms.Panel();
            this.panelDer = new System.Windows.Forms.Panel();
            this.LblMiembros = new System.Windows.Forms.Label();
            this.LstMiembros = new System.Windows.Forms.ListBox();
            this.BtnEliminarProyecto = new System.Windows.Forms.Button();
            this.BtnAbandonar = new System.Windows.Forms.Button();
            this.BtnNuevaTarea = new System.Windows.Forms.Button();
            this.BtnEditarProyecto = new System.Windows.Forms.Button();
            this.panelIzq = new System.Windows.Forms.Panel();
            this.BtnAñadirProyecto = new System.Windows.Forms.Button();
            this.LstProyectos = new System.Windows.Forms.ListBox();
            this.LblAmigos = new System.Windows.Forms.Label();
            this.BtnAñadirAmigo = new System.Windows.Forms.Button();
            this.LstAmigos = new System.Windows.Forms.ListBox();
            this.LblProyectos = new System.Windows.Forms.Label();
            this.LstProyectosId = new System.Windows.Forms.ListBox();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.RdbTodasFecha = new System.Windows.Forms.RadioButton();
            this.RdbCaducanHoy = new System.Windows.Forms.RadioButton();
            this.RdbCaducadas = new System.Windows.Forms.RadioButton();
            this.LblFin = new System.Windows.Forms.Label();
            this.LblProyecto = new System.Windows.Forms.Label();
            this.BtnEmpezarTarea = new System.Windows.Forms.Button();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.PcbArea = new System.Windows.Forms.PictureBox();
            this.LblTareaSeleccionada = new System.Windows.Forms.Label();
            this.LblPorcentaje = new System.Windows.Forms.Label();
            this.BtnTerminarTarea = new System.Windows.Forms.Button();
            this.LblProgreso = new System.Windows.Forms.Label();
            this.PrbProyecto = new System.Windows.Forms.ProgressBar();
            this.RdbPropias = new System.Windows.Forms.RadioButton();
            this.BtnEditarTarea = new System.Windows.Forms.Button();
            this.RdbTodas = new System.Windows.Forms.RadioButton();
            this.LblPendiente = new System.Windows.Forms.Label();
            this.LstFinalizadas = new System.Windows.Forms.ListBox();
            this.LblFinalizado = new System.Windows.Forms.Label();
            this.LblProceso = new System.Windows.Forms.Label();
            this.LstProceso = new System.Windows.Forms.ListBox();
            this.LstPendientes = new System.Windows.Forms.ListBox();
            this.LstIdTareasFinalizadas = new System.Windows.Forms.ListBox();
            this.LstIdTareasPendientes = new System.Windows.Forms.ListBox();
            this.LstIdTareasProceso = new System.Windows.Forms.ListBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.PcbTitulo = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnVerNotificaciones = new System.Windows.Forms.Button();
            this.LblNotificaciones = new System.Windows.Forms.Label();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.PcbAvatar = new System.Windows.Forms.PictureBox();
            this.LlblPerfil = new System.Windows.Forms.LinkLabel();
            this.PanelArea.SuspendLayout();
            this.panelDer.SuspendLayout();
            this.panelIzq.SuspendLayout();
            this.panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbArea)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelArea
            // 
            this.PanelArea.AutoScroll = true;
            this.PanelArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.PanelArea.Controls.Add(this.panelDer);
            this.PanelArea.Controls.Add(this.panelIzq);
            this.PanelArea.Controls.Add(this.panelCentro);
            this.PanelArea.Controls.Add(this.panelTop);
            this.PanelArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelArea.Location = new System.Drawing.Point(0, 0);
            this.PanelArea.Margin = new System.Windows.Forms.Padding(2);
            this.PanelArea.Name = "PanelArea";
            this.PanelArea.Size = new System.Drawing.Size(1028, 609);
            this.PanelArea.TabIndex = 0;
            // 
            // panelDer
            // 
            this.panelDer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.panelDer.Controls.Add(this.LblMiembros);
            this.panelDer.Controls.Add(this.LstMiembros);
            this.panelDer.Controls.Add(this.BtnEliminarProyecto);
            this.panelDer.Controls.Add(this.BtnAbandonar);
            this.panelDer.Controls.Add(this.BtnNuevaTarea);
            this.panelDer.Controls.Add(this.BtnEditarProyecto);
            this.panelDer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDer.Location = new System.Drawing.Point(1180, 102);
            this.panelDer.Margin = new System.Windows.Forms.Padding(2);
            this.panelDer.Name = "panelDer";
            this.panelDer.Size = new System.Drawing.Size(266, 660);
            this.panelDer.TabIndex = 89;
            this.panelDer.Visible = false;
            // 
            // LblMiembros
            // 
            this.LblMiembros.AutoSize = true;
            this.LblMiembros.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.LblMiembros.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblMiembros.Location = new System.Drawing.Point(35, 26);
            this.LblMiembros.Name = "LblMiembros";
            this.LblMiembros.Size = new System.Drawing.Size(203, 27);
            this.LblMiembros.TabIndex = 66;
            this.LblMiembros.Text = "MIEMBROS DEL PROYECTO";
            this.LblMiembros.Visible = false;
            // 
            // LstMiembros
            // 
            this.LstMiembros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.LstMiembros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstMiembros.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LstMiembros.ForeColor = System.Drawing.Color.SteelBlue;
            this.LstMiembros.FormattingEnabled = true;
            this.LstMiembros.ItemHeight = 27;
            this.LstMiembros.Location = new System.Drawing.Point(27, 76);
            this.LstMiembros.Margin = new System.Windows.Forms.Padding(2);
            this.LstMiembros.Name = "LstMiembros";
            this.LstMiembros.Size = new System.Drawing.Size(198, 189);
            this.LstMiembros.TabIndex = 68;
            this.LstMiembros.Visible = false;
            this.LstMiembros.DoubleClick += new System.EventHandler(this.LstMiembros_DoubleClick);
            // 
            // BtnEliminarProyecto
            // 
            this.BtnEliminarProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BtnEliminarProyecto.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.BtnEliminarProyecto.Image = global::ProjectMaster.Properties.Resources.papelera_de_reciclaje;
            this.BtnEliminarProyecto.Location = new System.Drawing.Point(27, 561);
            this.BtnEliminarProyecto.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminarProyecto.Name = "BtnEliminarProyecto";
            this.BtnEliminarProyecto.Size = new System.Drawing.Size(176, 63);
            this.BtnEliminarProyecto.TabIndex = 70;
            this.BtnEliminarProyecto.Text = "Eliminar proyecto";
            this.BtnEliminarProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminarProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminarProyecto.UseVisualStyleBackColor = false;
            this.BtnEliminarProyecto.Visible = false;
            this.BtnEliminarProyecto.Click += new System.EventHandler(this.BtnEliminarProyecto_Click);
            // 
            // BtnAbandonar
            // 
            this.BtnAbandonar.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.BtnAbandonar.Image = global::ProjectMaster.Properties.Resources.cerrar_sesion;
            this.BtnAbandonar.Location = new System.Drawing.Point(27, 360);
            this.BtnAbandonar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAbandonar.Name = "BtnAbandonar";
            this.BtnAbandonar.Size = new System.Drawing.Size(176, 63);
            this.BtnAbandonar.TabIndex = 71;
            this.BtnAbandonar.Text = "Abandonar proyecto";
            this.BtnAbandonar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAbandonar.UseVisualStyleBackColor = true;
            this.BtnAbandonar.Visible = false;
            this.BtnAbandonar.Click += new System.EventHandler(this.BtnAbandonar_Click);
            // 
            // BtnNuevaTarea
            // 
            this.BtnNuevaTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.BtnNuevaTarea.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.BtnNuevaTarea.Image = global::ProjectMaster.Properties.Resources.portapapeles;
            this.BtnNuevaTarea.Location = new System.Drawing.Point(27, 493);
            this.BtnNuevaTarea.Name = "BtnNuevaTarea";
            this.BtnNuevaTarea.Size = new System.Drawing.Size(176, 63);
            this.BtnNuevaTarea.TabIndex = 75;
            this.BtnNuevaTarea.Text = "Nueva Tarea";
            this.BtnNuevaTarea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNuevaTarea.UseVisualStyleBackColor = false;
            this.BtnNuevaTarea.Visible = false;
            this.BtnNuevaTarea.Click += new System.EventHandler(this.BtnNuevaTarea_Click);
            // 
            // BtnEditarProyecto
            // 
            this.BtnEditarProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnEditarProyecto.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.BtnEditarProyecto.Image = global::ProjectMaster.Properties.Resources.pincel_de_arte;
            this.BtnEditarProyecto.Location = new System.Drawing.Point(27, 427);
            this.BtnEditarProyecto.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditarProyecto.Name = "BtnEditarProyecto";
            this.BtnEditarProyecto.Size = new System.Drawing.Size(176, 63);
            this.BtnEditarProyecto.TabIndex = 67;
            this.BtnEditarProyecto.Text = "Editar proyecto";
            this.BtnEditarProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEditarProyecto.UseVisualStyleBackColor = false;
            this.BtnEditarProyecto.Visible = false;
            this.BtnEditarProyecto.Click += new System.EventHandler(this.BtnEditarProyecto_Click);
            // 
            // panelIzq
            // 
            this.panelIzq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.panelIzq.Controls.Add(this.BtnAñadirProyecto);
            this.panelIzq.Controls.Add(this.LstProyectos);
            this.panelIzq.Controls.Add(this.LblAmigos);
            this.panelIzq.Controls.Add(this.BtnAñadirAmigo);
            this.panelIzq.Controls.Add(this.LstAmigos);
            this.panelIzq.Controls.Add(this.LblProyectos);
            this.panelIzq.Controls.Add(this.LstProyectosId);
            this.panelIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzq.Location = new System.Drawing.Point(0, 102);
            this.panelIzq.Margin = new System.Windows.Forms.Padding(2);
            this.panelIzq.Name = "panelIzq";
            this.panelIzq.Size = new System.Drawing.Size(223, 660);
            this.panelIzq.TabIndex = 87;
            // 
            // BtnAñadirProyecto
            // 
            this.BtnAñadirProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.BtnAñadirProyecto.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.BtnAñadirProyecto.Image = global::ProjectMaster.Properties.Resources.nuevo_proyecto;
            this.BtnAñadirProyecto.Location = new System.Drawing.Point(17, 49);
            this.BtnAñadirProyecto.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAñadirProyecto.Name = "BtnAñadirProyecto";
            this.BtnAñadirProyecto.Size = new System.Drawing.Size(167, 40);
            this.BtnAñadirProyecto.TabIndex = 31;
            this.BtnAñadirProyecto.Text = "Nuevo proyecto";
            this.BtnAñadirProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAñadirProyecto.UseVisualStyleBackColor = false;
            this.BtnAñadirProyecto.Click += new System.EventHandler(this.BtnAñadirProyecto_Click);
            // 
            // LstProyectos
            // 
            this.LstProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.LstProyectos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstProyectos.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LstProyectos.ForeColor = System.Drawing.Color.SteelBlue;
            this.LstProyectos.FormattingEnabled = true;
            this.LstProyectos.ItemHeight = 27;
            this.LstProyectos.Location = new System.Drawing.Point(20, 96);
            this.LstProyectos.Margin = new System.Windows.Forms.Padding(2);
            this.LstProyectos.MaximumSize = new System.Drawing.Size(164, 189);
            this.LstProyectos.Name = "LstProyectos";
            this.LstProyectos.Size = new System.Drawing.Size(164, 162);
            this.LstProyectos.TabIndex = 32;
            this.LstProyectos.SelectedIndexChanged += new System.EventHandler(this.LstProyectos_SelectedIndexChanged);
            // 
            // LblAmigos
            // 
            this.LblAmigos.AutoSize = true;
            this.LblAmigos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAmigos.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.LblAmigos.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblAmigos.Location = new System.Drawing.Point(17, 307);
            this.LblAmigos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAmigos.Name = "LblAmigos";
            this.LblAmigos.Size = new System.Drawing.Size(78, 31);
            this.LblAmigos.TabIndex = 29;
            this.LblAmigos.Text = "AMIGOS";
            // 
            // BtnAñadirAmigo
            // 
            this.BtnAñadirAmigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.BtnAñadirAmigo.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.BtnAñadirAmigo.Image = global::ProjectMaster.Properties.Resources.anadir_amigo;
            this.BtnAñadirAmigo.Location = new System.Drawing.Point(17, 345);
            this.BtnAñadirAmigo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAñadirAmigo.Name = "BtnAñadirAmigo";
            this.BtnAñadirAmigo.Size = new System.Drawing.Size(166, 41);
            this.BtnAñadirAmigo.TabIndex = 33;
            this.BtnAñadirAmigo.Text = "Nuevo amigo";
            this.BtnAñadirAmigo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAñadirAmigo.UseVisualStyleBackColor = false;
            this.BtnAñadirAmigo.Click += new System.EventHandler(this.BtnAñadirAmigo_Click);
            // 
            // LstAmigos
            // 
            this.LstAmigos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.LstAmigos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstAmigos.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LstAmigos.ForeColor = System.Drawing.Color.SteelBlue;
            this.LstAmigos.FormattingEnabled = true;
            this.LstAmigos.ItemHeight = 27;
            this.LstAmigos.Location = new System.Drawing.Point(17, 393);
            this.LstAmigos.Margin = new System.Windows.Forms.Padding(2);
            this.LstAmigos.MaximumSize = new System.Drawing.Size(164, 189);
            this.LstAmigos.Name = "LstAmigos";
            this.LstAmigos.Size = new System.Drawing.Size(164, 189);
            this.LstAmigos.TabIndex = 34;
            this.LstAmigos.DoubleClick += new System.EventHandler(this.LstAmigos_DoubleClick);
            // 
            // LblProyectos
            // 
            this.LblProyectos.AutoSize = true;
            this.LblProyectos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblProyectos.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.LblProyectos.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblProyectos.Location = new System.Drawing.Point(17, 13);
            this.LblProyectos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProyectos.Name = "LblProyectos";
            this.LblProyectos.Size = new System.Drawing.Size(106, 31);
            this.LblProyectos.TabIndex = 28;
            this.LblProyectos.Text = "PROYECTOS";
            // 
            // LstProyectosId
            // 
            this.LstProyectosId.BackColor = System.Drawing.SystemColors.Control;
            this.LstProyectosId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstProyectosId.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LstProyectosId.FormattingEnabled = true;
            this.LstProyectosId.ItemHeight = 27;
            this.LstProyectosId.Location = new System.Drawing.Point(123, 98);
            this.LstProyectosId.Margin = new System.Windows.Forms.Padding(2);
            this.LstProyectosId.Name = "LstProyectosId";
            this.LstProyectosId.Size = new System.Drawing.Size(79, 135);
            this.LstProyectosId.TabIndex = 72;
            this.LstProyectosId.Visible = false;
            // 
            // panelCentro
            // 
            this.panelCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.panelCentro.Controls.Add(this.RdbTodasFecha);
            this.panelCentro.Controls.Add(this.RdbCaducanHoy);
            this.panelCentro.Controls.Add(this.RdbCaducadas);
            this.panelCentro.Controls.Add(this.LblFin);
            this.panelCentro.Controls.Add(this.LblProyecto);
            this.panelCentro.Controls.Add(this.BtnEmpezarTarea);
            this.panelCentro.Controls.Add(this.LblDescripcion);
            this.panelCentro.Controls.Add(this.LblTareaSeleccionada);
            this.panelCentro.Controls.Add(this.LblPorcentaje);
            this.panelCentro.Controls.Add(this.BtnTerminarTarea);
            this.panelCentro.Controls.Add(this.LblProgreso);
            this.panelCentro.Controls.Add(this.PrbProyecto);
            this.panelCentro.Controls.Add(this.RdbPropias);
            this.panelCentro.Controls.Add(this.BtnEditarTarea);
            this.panelCentro.Controls.Add(this.RdbTodas);
            this.panelCentro.Controls.Add(this.LblPendiente);
            this.panelCentro.Controls.Add(this.LstFinalizadas);
            this.panelCentro.Controls.Add(this.LblFinalizado);
            this.panelCentro.Controls.Add(this.LblProceso);
            this.panelCentro.Controls.Add(this.LstProceso);
            this.panelCentro.Controls.Add(this.LstPendientes);
            this.panelCentro.Controls.Add(this.LstIdTareasFinalizadas);
            this.panelCentro.Controls.Add(this.LstIdTareasPendientes);
            this.panelCentro.Controls.Add(this.LstIdTareasProceso);
            this.panelCentro.Controls.Add(this.PcbArea);
            this.panelCentro.Location = new System.Drawing.Point(227, 106);
            this.panelCentro.Margin = new System.Windows.Forms.Padding(2);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(953, 656);
            this.panelCentro.TabIndex = 88;
            // 
            // RdbTodasFecha
            // 
            this.RdbTodasFecha.AutoCheck = false;
            this.RdbTodasFecha.AutoSize = true;
            this.RdbTodasFecha.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbTodasFecha.ForeColor = System.Drawing.Color.SteelBlue;
            this.RdbTodasFecha.Location = new System.Drawing.Point(13, 462);
            this.RdbTodasFecha.Name = "RdbTodasFecha";
            this.RdbTodasFecha.Size = new System.Drawing.Size(110, 24);
            this.RdbTodasFecha.TabIndex = 107;
            this.RdbTodasFecha.Text = "Todas las fechas";
            this.RdbTodasFecha.UseVisualStyleBackColor = true;
            this.RdbTodasFecha.Visible = false;
            this.RdbTodasFecha.CheckedChanged += new System.EventHandler(this.RdbCaducadas_CheckedChanged);
            this.RdbTodasFecha.Click += new System.EventHandler(this.Rdb_Click);
            // 
            // RdbCaducanHoy
            // 
            this.RdbCaducanHoy.AutoCheck = false;
            this.RdbCaducanHoy.AutoSize = true;
            this.RdbCaducanHoy.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbCaducanHoy.ForeColor = System.Drawing.Color.SteelBlue;
            this.RdbCaducanHoy.Location = new System.Drawing.Point(13, 509);
            this.RdbCaducanHoy.Name = "RdbCaducanHoy";
            this.RdbCaducanHoy.Size = new System.Drawing.Size(94, 24);
            this.RdbCaducanHoy.TabIndex = 106;
            this.RdbCaducanHoy.Text = "Caducan hoy";
            this.RdbCaducanHoy.UseVisualStyleBackColor = true;
            this.RdbCaducanHoy.Visible = false;
            this.RdbCaducanHoy.CheckedChanged += new System.EventHandler(this.RdbCaducadas_CheckedChanged);
            this.RdbCaducanHoy.Click += new System.EventHandler(this.Rdb_Click);
            // 
            // RdbCaducadas
            // 
            this.RdbCaducadas.AutoCheck = false;
            this.RdbCaducadas.AutoSize = true;
            this.RdbCaducadas.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbCaducadas.ForeColor = System.Drawing.Color.SteelBlue;
            this.RdbCaducadas.Location = new System.Drawing.Point(13, 486);
            this.RdbCaducadas.Name = "RdbCaducadas";
            this.RdbCaducadas.Size = new System.Drawing.Size(83, 24);
            this.RdbCaducadas.TabIndex = 105;
            this.RdbCaducadas.Text = "Caducadas";
            this.RdbCaducadas.UseVisualStyleBackColor = true;
            this.RdbCaducadas.Visible = false;
            this.RdbCaducadas.CheckedChanged += new System.EventHandler(this.RdbCaducadas_CheckedChanged);
            this.RdbCaducadas.Click += new System.EventHandler(this.Rdb_Click);
            // 
            // LblFin
            // 
            this.LblFin.AutoSize = true;
            this.LblFin.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFin.ForeColor = System.Drawing.Color.LimeGreen;
            this.LblFin.Location = new System.Drawing.Point(318, 210);
            this.LblFin.Name = "LblFin";
            this.LblFin.Size = new System.Drawing.Size(254, 25);
            this.LblFin.TabIndex = 104;
            this.LblFin.Text = "¡Se han compleado todas las tareas!";
            this.LblFin.Visible = false;
            // 
            // LblProyecto
            // 
            this.LblProyecto.AutoSize = true;
            this.LblProyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblProyecto.Font = new System.Drawing.Font("Myanmar Text", 14F, System.Drawing.FontStyle.Bold);
            this.LblProyecto.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblProyecto.Location = new System.Drawing.Point(24, 42);
            this.LblProyecto.MaximumSize = new System.Drawing.Size(224, 101);
            this.LblProyecto.Name = "LblProyecto";
            this.LblProyecto.Size = new System.Drawing.Size(200, 36);
            this.LblProyecto.TabIndex = 88;
            this.LblProyecto.Text = "NOMBRE PROYECTO";
            this.LblProyecto.Visible = false;
            // 
            // BtnEmpezarTarea
            // 
            this.BtnEmpezarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(241)))), ((int)(((byte)(219)))));
            this.BtnEmpezarTarea.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.BtnEmpezarTarea.Image = global::ProjectMaster.Properties.Resources.comienzo;
            this.BtnEmpezarTarea.Location = new System.Drawing.Point(160, 549);
            this.BtnEmpezarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEmpezarTarea.Name = "BtnEmpezarTarea";
            this.BtnEmpezarTarea.Size = new System.Drawing.Size(158, 45);
            this.BtnEmpezarTarea.TabIndex = 101;
            this.BtnEmpezarTarea.Text = "Comenzar tarea";
            this.BtnEmpezarTarea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEmpezarTarea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEmpezarTarea.UseVisualStyleBackColor = false;
            this.BtnEmpezarTarea.Visible = false;
            this.BtnEmpezarTarea.Click += new System.EventHandler(this.BtnEstadoTarea_Click);
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LblDescripcion.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblDescripcion.Location = new System.Drawing.Point(252, 42);
            this.LblDescripcion.MaximumSize = new System.Drawing.Size(382, 103);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(382, 103);
            this.LblDescripcion.TabIndex = 87;
            this.LblDescripcion.Text = "Descripcion proyecto";
            this.LblDescripcion.Visible = false;
            // 
            // PcbArea
            // 
            this.PcbArea.Image = global::ProjectMaster.Properties.Resources.logo_area;
            this.PcbArea.Location = new System.Drawing.Point(48, 3);
            this.PcbArea.Name = "PcbArea";
            this.PcbArea.Size = new System.Drawing.Size(813, 596);
            this.PcbArea.TabIndex = 35;
            this.PcbArea.TabStop = false;
            // 
            // LblTareaSeleccionada
            // 
            this.LblTareaSeleccionada.AutoSize = true;
            this.LblTareaSeleccionada.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.LblTareaSeleccionada.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblTareaSeleccionada.Location = new System.Drawing.Point(257, 235);
            this.LblTareaSeleccionada.MaximumSize = new System.Drawing.Size(382, 0);
            this.LblTareaSeleccionada.Name = "LblTareaSeleccionada";
            this.LblTareaSeleccionada.Size = new System.Drawing.Size(151, 27);
            this.LblTareaSeleccionada.TabIndex = 103;
            this.LblTareaSeleccionada.Text = "Tarea seleccionada: ";
            this.LblTareaSeleccionada.Visible = false;
            // 
            // LblPorcentaje
            // 
            this.LblPorcentaje.AutoSize = true;
            this.LblPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.LblPorcentaje.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.LblPorcentaje.Location = new System.Drawing.Point(640, 182);
            this.LblPorcentaje.Name = "LblPorcentaje";
            this.LblPorcentaje.Size = new System.Drawing.Size(32, 25);
            this.LblPorcentaje.TabIndex = 102;
            this.LblPorcentaje.Text = "0%";
            this.LblPorcentaje.Visible = false;
            // 
            // BtnTerminarTarea
            // 
            this.BtnTerminarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.BtnTerminarTarea.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.BtnTerminarTarea.Image = global::ProjectMaster.Properties.Resources.linea_de_meta;
            this.BtnTerminarTarea.Location = new System.Drawing.Point(422, 549);
            this.BtnTerminarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTerminarTarea.Name = "BtnTerminarTarea";
            this.BtnTerminarTarea.Size = new System.Drawing.Size(159, 45);
            this.BtnTerminarTarea.TabIndex = 100;
            this.BtnTerminarTarea.Text = "Terminar tarea";
            this.BtnTerminarTarea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTerminarTarea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTerminarTarea.UseVisualStyleBackColor = false;
            this.BtnTerminarTarea.Visible = false;
            this.BtnTerminarTarea.Click += new System.EventHandler(this.BtnEstadoTarea_Click);
            // 
            // LblProgreso
            // 
            this.LblProgreso.AutoSize = true;
            this.LblProgreso.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LblProgreso.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblProgreso.Location = new System.Drawing.Point(370, 154);
            this.LblProgreso.Name = "LblProgreso";
            this.LblProgreso.Size = new System.Drawing.Size(162, 27);
            this.LblProgreso.TabIndex = 90;
            this.LblProgreso.Text = "Progreso del proyecto:";
            this.LblProgreso.Visible = false;
            // 
            // PrbProyecto
            // 
            this.PrbProyecto.Location = new System.Drawing.Point(252, 182);
            this.PrbProyecto.Name = "PrbProyecto";
            this.PrbProyecto.Size = new System.Drawing.Size(382, 23);
            this.PrbProyecto.TabIndex = 89;
            this.PrbProyecto.Visible = false;
            // 
            // RdbPropias
            // 
            this.RdbPropias.AutoCheck = false;
            this.RdbPropias.AutoSize = true;
            this.RdbPropias.Checked = true;
            this.RdbPropias.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbPropias.ForeColor = System.Drawing.Color.SteelBlue;
            this.RdbPropias.Location = new System.Drawing.Point(13, 402);
            this.RdbPropias.Name = "RdbPropias";
            this.RdbPropias.Size = new System.Drawing.Size(65, 24);
            this.RdbPropias.TabIndex = 98;
            this.RdbPropias.TabStop = true;
            this.RdbPropias.Text = "Propias";
            this.RdbPropias.UseVisualStyleBackColor = true;
            this.RdbPropias.Visible = false;
            this.RdbPropias.CheckedChanged += new System.EventHandler(this.RdbCaducadas_CheckedChanged);
            this.RdbPropias.Click += new System.EventHandler(this.Rdb_Click);
            // 
            // BtnEditarTarea
            // 
            this.BtnEditarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.BtnEditarTarea.Image = global::ProjectMaster.Properties.Resources.lapiz_de_grafito;
            this.BtnEditarTarea.Location = new System.Drawing.Point(711, 178);
            this.BtnEditarTarea.Name = "BtnEditarTarea";
            this.BtnEditarTarea.Size = new System.Drawing.Size(102, 51);
            this.BtnEditarTarea.TabIndex = 99;
            this.BtnEditarTarea.Text = "Editar Tarea";
            this.BtnEditarTarea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEditarTarea.UseVisualStyleBackColor = false;
            this.BtnEditarTarea.Visible = false;
            this.BtnEditarTarea.Click += new System.EventHandler(this.BtnEditarTarea_Click);
            // 
            // RdbTodas
            // 
            this.RdbTodas.AutoCheck = false;
            this.RdbTodas.AutoSize = true;
            this.RdbTodas.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbTodas.ForeColor = System.Drawing.Color.SteelBlue;
            this.RdbTodas.Location = new System.Drawing.Point(13, 376);
            this.RdbTodas.Name = "RdbTodas";
            this.RdbTodas.Size = new System.Drawing.Size(57, 24);
            this.RdbTodas.TabIndex = 97;
            this.RdbTodas.Text = "Todas";
            this.RdbTodas.UseVisualStyleBackColor = true;
            this.RdbTodas.Visible = false;
            this.RdbTodas.CheckedChanged += new System.EventHandler(this.RdbCaducadas_CheckedChanged);
            this.RdbTodas.Click += new System.EventHandler(this.Rdb_Click);
            // 
            // LblPendiente
            // 
            this.LblPendiente.AutoSize = true;
            this.LblPendiente.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.LblPendiente.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblPendiente.Location = new System.Drawing.Point(186, 269);
            this.LblPendiente.Name = "LblPendiente";
            this.LblPendiente.Size = new System.Drawing.Size(102, 27);
            this.LblPendiente.TabIndex = 93;
            this.LblPendiente.Text = "PENDIENTES";
            this.LblPendiente.Visible = false;
            // 
            // LstFinalizadas
            // 
            this.LstFinalizadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.LstFinalizadas.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LstFinalizadas.FormattingEnabled = true;
            this.LstFinalizadas.HorizontalScrollbar = true;
            this.LstFinalizadas.ItemHeight = 27;
            this.LstFinalizadas.Location = new System.Drawing.Point(651, 298);
            this.LstFinalizadas.Margin = new System.Windows.Forms.Padding(2);
            this.LstFinalizadas.Name = "LstFinalizadas";
            this.LstFinalizadas.Size = new System.Drawing.Size(247, 247);
            this.LstFinalizadas.TabIndex = 96;
            this.LstFinalizadas.Visible = false;
            this.LstFinalizadas.SelectedIndexChanged += new System.EventHandler(this.LstTareas_SelectedIndexChanged);
            this.LstFinalizadas.DoubleClick += new System.EventHandler(this.LstPendientes_DoubleClick);
            // 
            // LblFinalizado
            // 
            this.LblFinalizado.AutoSize = true;
            this.LblFinalizado.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.LblFinalizado.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblFinalizado.Location = new System.Drawing.Point(706, 269);
            this.LblFinalizado.Name = "LblFinalizado";
            this.LblFinalizado.Size = new System.Drawing.Size(111, 27);
            this.LblFinalizado.TabIndex = 91;
            this.LblFinalizado.Text = "FINALIZADAS";
            this.LblFinalizado.Visible = false;
            // 
            // LblProceso
            // 
            this.LblProceso.AutoSize = true;
            this.LblProceso.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold);
            this.LblProceso.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblProceso.Location = new System.Drawing.Point(451, 269);
            this.LblProceso.Name = "LblProceso";
            this.LblProceso.Size = new System.Drawing.Size(102, 27);
            this.LblProceso.TabIndex = 92;
            this.LblProceso.Text = "EN PROCESO";
            this.LblProceso.Visible = false;
            // 
            // LstProceso
            // 
            this.LstProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(241)))), ((int)(((byte)(219)))));
            this.LstProceso.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LstProceso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LstProceso.FormattingEnabled = true;
            this.LstProceso.HorizontalScrollbar = true;
            this.LstProceso.ItemHeight = 27;
            this.LstProceso.Location = new System.Drawing.Point(385, 298);
            this.LstProceso.Margin = new System.Windows.Forms.Padding(2);
            this.LstProceso.Name = "LstProceso";
            this.LstProceso.Size = new System.Drawing.Size(247, 247);
            this.LstProceso.TabIndex = 95;
            this.LstProceso.Visible = false;
            this.LstProceso.SelectedIndexChanged += new System.EventHandler(this.LstTareas_SelectedIndexChanged);
            this.LstProceso.DoubleClick += new System.EventHandler(this.LstPendientes_DoubleClick);
            // 
            // LstPendientes
            // 
            this.LstPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(240)))));
            this.LstPendientes.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LstPendientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LstPendientes.FormattingEnabled = true;
            this.LstPendientes.HorizontalScrollbar = true;
            this.LstPendientes.ItemHeight = 27;
            this.LstPendientes.Location = new System.Drawing.Point(124, 298);
            this.LstPendientes.Margin = new System.Windows.Forms.Padding(2);
            this.LstPendientes.Name = "LstPendientes";
            this.LstPendientes.Size = new System.Drawing.Size(247, 247);
            this.LstPendientes.TabIndex = 94;
            this.LstPendientes.Visible = false;
            this.LstPendientes.SelectedIndexChanged += new System.EventHandler(this.LstTareas_SelectedIndexChanged);
            this.LstPendientes.DoubleClick += new System.EventHandler(this.LstPendientes_DoubleClick);
            // 
            // LstIdTareasFinalizadas
            // 
            this.LstIdTareasFinalizadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.LstIdTareasFinalizadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstIdTareasFinalizadas.FormattingEnabled = true;
            this.LstIdTareasFinalizadas.Location = new System.Drawing.Point(741, 572);
            this.LstIdTareasFinalizadas.Margin = new System.Windows.Forms.Padding(2);
            this.LstIdTareasFinalizadas.Name = "LstIdTareasFinalizadas";
            this.LstIdTareasFinalizadas.Size = new System.Drawing.Size(44, 13);
            this.LstIdTareasFinalizadas.TabIndex = 81;
            this.LstIdTareasFinalizadas.Visible = false;
            // 
            // LstIdTareasPendientes
            // 
            this.LstIdTareasPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.LstIdTareasPendientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstIdTareasPendientes.FormattingEnabled = true;
            this.LstIdTareasPendientes.Location = new System.Drawing.Point(207, 553);
            this.LstIdTareasPendientes.Margin = new System.Windows.Forms.Padding(2);
            this.LstIdTareasPendientes.Name = "LstIdTareasPendientes";
            this.LstIdTareasPendientes.Size = new System.Drawing.Size(44, 13);
            this.LstIdTareasPendientes.TabIndex = 79;
            this.LstIdTareasPendientes.Visible = false;
            // 
            // LstIdTareasProceso
            // 
            this.LstIdTareasProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.LstIdTareasProceso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstIdTareasProceso.FormattingEnabled = true;
            this.LstIdTareasProceso.Location = new System.Drawing.Point(475, 553);
            this.LstIdTareasProceso.Margin = new System.Windows.Forms.Padding(2);
            this.LstIdTareasProceso.Name = "LstIdTareasProceso";
            this.LstIdTareasProceso.Size = new System.Drawing.Size(44, 13);
            this.LstIdTareasProceso.TabIndex = 80;
            this.LstIdTareasProceso.Visible = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelTop.Controls.Add(this.PcbTitulo);
            this.panelTop.Controls.Add(this.LblTitulo);
            this.panelTop.Controls.Add(this.BtnVerNotificaciones);
            this.panelTop.Controls.Add(this.LblNotificaciones);
            this.panelTop.Controls.Add(this.BtnCerrarSesion);
            this.panelTop.Controls.Add(this.PcbAvatar);
            this.panelTop.Controls.Add(this.LlblPerfil);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1446, 102);
            this.panelTop.TabIndex = 86;
            // 
            // PcbTitulo
            // 
            this.PcbTitulo.Image = ((System.Drawing.Image)(resources.GetObject("PcbTitulo.Image")));
            this.PcbTitulo.Location = new System.Drawing.Point(422, 17);
            this.PcbTitulo.Name = "PcbTitulo";
            this.PcbTitulo.Size = new System.Drawing.Size(477, 76);
            this.PcbTitulo.TabIndex = 75;
            this.PcbTitulo.TabStop = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTitulo.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(77)))));
            this.LblTitulo.Location = new System.Drawing.Point(560, 32);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(216, 45);
            this.LblTitulo.TabIndex = 36;
            this.LblTitulo.Text = "ÁREA PRINCIPAL";
            // 
            // BtnVerNotificaciones
            // 
            this.BtnVerNotificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.BtnVerNotificaciones.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.BtnVerNotificaciones.Image = global::ProjectMaster.Properties.Resources.correo_electronico;
            this.BtnVerNotificaciones.Location = new System.Drawing.Point(1059, 25);
            this.BtnVerNotificaciones.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVerNotificaciones.Name = "BtnVerNotificaciones";
            this.BtnVerNotificaciones.Size = new System.Drawing.Size(149, 60);
            this.BtnVerNotificaciones.TabIndex = 73;
            this.BtnVerNotificaciones.Text = "Ver Notificaciones";
            this.BtnVerNotificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnVerNotificaciones.UseVisualStyleBackColor = false;
            this.BtnVerNotificaciones.Click += new System.EventHandler(this.BtnVerNotificaciones_Click);
            // 
            // LblNotificaciones
            // 
            this.LblNotificaciones.AutoSize = true;
            this.LblNotificaciones.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold);
            this.LblNotificaciones.Location = new System.Drawing.Point(970, 29);
            this.LblNotificaciones.MaximumSize = new System.Drawing.Size(100, 0);
            this.LblNotificaciones.Name = "LblNotificaciones";
            this.LblNotificaciones.Size = new System.Drawing.Size(87, 42);
            this.LblNotificaciones.TabIndex = 74;
            this.LblNotificaciones.Text = "Sin nuevas notificaciones";
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.Image = global::ProjectMaster.Properties.Resources.boton_de_encendido_apagado;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(1302, 29);
            this.BtnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(103, 56);
            this.BtnCerrarSesion.TabIndex = 30;
            this.BtnCerrarSesion.Text = "     Cerrar Sesión";
            this.BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCerrarSesion.UseVisualStyleBackColor = false;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // PcbAvatar
            // 
            this.PcbAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbAvatar.Location = new System.Drawing.Point(17, 17);
            this.PcbAvatar.Name = "PcbAvatar";
            this.PcbAvatar.Size = new System.Drawing.Size(60, 60);
            this.PcbAvatar.TabIndex = 25;
            this.PcbAvatar.TabStop = false;
            this.PcbAvatar.Click += new System.EventHandler(this.PcbAvatar_Click);
            // 
            // LlblPerfil
            // 
            this.LlblPerfil.AutoSize = true;
            this.LlblPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LlblPerfil.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.LlblPerfil.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LlblPerfil.LinkColor = System.Drawing.Color.Black;
            this.LlblPerfil.Location = new System.Drawing.Point(92, 34);
            this.LlblPerfil.Name = "LlblPerfil";
            this.LlblPerfil.Size = new System.Drawing.Size(62, 27);
            this.LlblPerfil.TabIndex = 27;
            this.LlblPerfil.TabStop = true;
            this.LlblPerfil.Text = "Usuario";
            this.LlblPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblPerfil_LinkClicked);
            // 
            // FrmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.PanelArea);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmArea";
            this.Text = "FrmArea";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmArea_FormClosing);
            this.Shown += new System.EventHandler(this.FrmArea_Shown);
            this.Resize += new System.EventHandler(this.FrmArea_Resize);
            this.PanelArea.ResumeLayout(false);
            this.panelDer.ResumeLayout(false);
            this.panelDer.PerformLayout();
            this.panelIzq.ResumeLayout(false);
            this.panelIzq.PerformLayout();
            this.panelCentro.ResumeLayout(false);
            this.panelCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbArea)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelArea;
        private System.Windows.Forms.PictureBox PcbAvatar;
        private LinkLabel LlblPerfil;
        private Label LblAmigos;
        private Label LblProyectos;
        private Button BtnCerrarSesion;
        private ListBox LstProyectos;
        private Button BtnAñadirProyecto;
        private ListBox LstAmigos;
        private Button BtnAñadirAmigo;
        private Label LblTitulo;
        private Button BtnAbandonar;
        private Button BtnEliminarProyecto;
        private ListBox LstMiembros;
        private Button BtnEditarProyecto;
        private Label LblMiembros;
        private ListBox LstProyectosId;
        private Button BtnVerNotificaciones;
        private Label LblNotificaciones;
        private Button BtnNuevaTarea;
        private ListBox LstIdTareasFinalizadas;
        private ListBox LstIdTareasProceso;
        private ListBox LstIdTareasPendientes;
        private Panel panelTop;
        private Panel panelIzq;
        private Panel panelCentro;
        private Panel panelDer;
        private PictureBox PcbArea;
        private Label LblFin;
        private Label LblProyecto;
        private Button BtnEmpezarTarea;
        private Label LblDescripcion;
        private Label LblTareaSeleccionada;
        private Label LblPorcentaje;
        private Button BtnTerminarTarea;
        private Label LblProgreso;
        private ProgressBar PrbProyecto;
        private RadioButton RdbPropias;
        private Button BtnEditarTarea;
        private RadioButton RdbTodas;
        private Label LblPendiente;
        private ListBox LstFinalizadas;
        private Label LblFinalizado;
        private Label LblProceso;
        private ListBox LstProceso;
        private ListBox LstPendientes;
        private RadioButton RdbCaducanHoy;
        private RadioButton RdbCaducadas;
        private RadioButton RdbTodasFecha;
        private PictureBox PcbTitulo;
    }
}