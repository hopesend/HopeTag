namespace HopeTag
{
    partial class fmHopeTag
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
            this.tsBarraTareas = new System.Windows.Forms.ToolStrip();
            this.btObtenerAlbumes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAnterior = new System.Windows.Forms.ToolStripButton();
            this.tsbPlay = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.tsbSiguiente = new System.Windows.Forms.ToolStripButton();
            this.tsbBajarVolumen = new System.Windows.Forms.ToolStripButton();
            this.tsbSubirVolumen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tcBarraTareas = new System.Windows.Forms.TabControl();
            this.tbDirectorio = new System.Windows.Forms.TabPage();
            this.pnListViewAlbum = new System.Windows.Forms.Panel();
            this.lvAlbumes = new System.Windows.Forms.ListView();
            this.pnInfoAlbum = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lvSplit = new System.Windows.Forms.ListView();
            this.rbSplit = new System.Windows.Forms.RadioButton();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.rbEP = new System.Windows.Forms.RadioButton();
            this.rbCD = new System.Windows.Forms.RadioButton();
            this.pnBotonesDirectorio = new System.Windows.Forms.Panel();
            this.btPropuesta = new System.Windows.Forms.Button();
            this.btGuardarDirectorio = new System.Windows.Forms.Button();
            this.tbAnyo = new System.Windows.Forms.TextBox();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.tbArtista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpCanciones = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvCanciones = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbTituloPista = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNumeroPista = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbAnyoTag = new System.Windows.Forms.TextBox();
            this.tbAlbumTag = new System.Windows.Forms.TextBox();
            this.tbArtistaTag = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fbdDirectorioTrabajo = new System.Windows.Forms.FolderBrowserDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.tsBarraTareas.SuspendLayout();
            this.tcBarraTareas.SuspendLayout();
            this.tbDirectorio.SuspendLayout();
            this.pnListViewAlbum.SuspendLayout();
            this.pnInfoAlbum.SuspendLayout();
            this.pnBotonesDirectorio.SuspendLayout();
            this.tpCanciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsBarraTareas
            // 
            this.tsBarraTareas.AutoSize = false;
            this.tsBarraTareas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btObtenerAlbumes,
            this.toolStripSeparator1,
            this.tsbBorrar,
            this.toolStripSeparator3,
            this.tsbAnterior,
            this.tsbPlay,
            this.tsbStop,
            this.tsbSiguiente,
            this.tsbBajarVolumen,
            this.tsbSubirVolumen,
            this.toolStripSeparator2});
            this.tsBarraTareas.Location = new System.Drawing.Point(0, 0);
            this.tsBarraTareas.Name = "tsBarraTareas";
            this.tsBarraTareas.Size = new System.Drawing.Size(828, 39);
            this.tsBarraTareas.TabIndex = 0;
            this.tsBarraTareas.Text = "toolStrip1";
            // 
            // btObtenerAlbumes
            // 
            this.btObtenerAlbumes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btObtenerAlbumes.Image = global::HopeTag.Properties.Resources.Search_Folder_icon;
            this.btObtenerAlbumes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btObtenerAlbumes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btObtenerAlbumes.Name = "btObtenerAlbumes";
            this.btObtenerAlbumes.Size = new System.Drawing.Size(36, 36);
            this.btObtenerAlbumes.Text = "toolStripButton1";
            this.btObtenerAlbumes.ToolTipText = "Obtener Directorio de Trabajo";
            this.btObtenerAlbumes.Click += new System.EventHandler(this.btObtenerAlbumes_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbBorrar
            // 
            this.tsbBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBorrar.Image = global::HopeTag.Properties.Resources.Cross_Folder_icon;
            this.tsbBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrar.Name = "tsbBorrar";
            this.tsbBorrar.Size = new System.Drawing.Size(36, 36);
            this.tsbBorrar.Text = "toolStripButton7";
            this.tsbBorrar.ToolTipText = "Borrar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbAnterior
            // 
            this.tsbAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAnterior.Image = global::HopeTag.Properties.Resources.skip_backward;
            this.tsbAnterior.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnterior.Name = "tsbAnterior";
            this.tsbAnterior.Size = new System.Drawing.Size(36, 36);
            this.tsbAnterior.Text = "toolStripButton1";
            this.tsbAnterior.ToolTipText = "Anterior ";
            // 
            // tsbPlay
            // 
            this.tsbPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPlay.Image = global::HopeTag.Properties.Resources.play;
            this.tsbPlay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlay.Name = "tsbPlay";
            this.tsbPlay.Size = new System.Drawing.Size(36, 36);
            this.tsbPlay.Text = "toolStripButton2";
            this.tsbPlay.ToolTipText = "Play";
            // 
            // tsbStop
            // 
            this.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStop.Image = global::HopeTag.Properties.Resources.stop;
            this.tsbStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(36, 36);
            this.tsbStop.Text = "toolStripButton3";
            this.tsbStop.ToolTipText = "Stop";
            // 
            // tsbSiguiente
            // 
            this.tsbSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSiguiente.Image = global::HopeTag.Properties.Resources.skip_forward;
            this.tsbSiguiente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSiguiente.Name = "tsbSiguiente";
            this.tsbSiguiente.Size = new System.Drawing.Size(36, 36);
            this.tsbSiguiente.Text = "toolStripButton4";
            this.tsbSiguiente.ToolTipText = "Siguiente";
            // 
            // tsbBajarVolumen
            // 
            this.tsbBajarVolumen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBajarVolumen.Image = global::HopeTag.Properties.Resources.volume_down;
            this.tsbBajarVolumen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBajarVolumen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBajarVolumen.Name = "tsbBajarVolumen";
            this.tsbBajarVolumen.Size = new System.Drawing.Size(36, 36);
            this.tsbBajarVolumen.Text = "toolStripButton5";
            this.tsbBajarVolumen.ToolTipText = "Bajar Volumen";
            // 
            // tsbSubirVolumen
            // 
            this.tsbSubirVolumen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSubirVolumen.Image = global::HopeTag.Properties.Resources.volume_up;
            this.tsbSubirVolumen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSubirVolumen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSubirVolumen.Name = "tsbSubirVolumen";
            this.tsbSubirVolumen.Size = new System.Drawing.Size(36, 36);
            this.tsbSubirVolumen.Text = "toolStripButton6";
            this.tsbSubirVolumen.ToolTipText = "Subir Volumen";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tcBarraTareas
            // 
            this.tcBarraTareas.Controls.Add(this.tbDirectorio);
            this.tcBarraTareas.Controls.Add(this.tpCanciones);
            this.tcBarraTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBarraTareas.Location = new System.Drawing.Point(0, 39);
            this.tcBarraTareas.Name = "tcBarraTareas";
            this.tcBarraTareas.SelectedIndex = 0;
            this.tcBarraTareas.Size = new System.Drawing.Size(828, 512);
            this.tcBarraTareas.TabIndex = 1;
            this.tcBarraTareas.SelectedIndexChanged += new System.EventHandler(this.tcBarraTareas_SelectedIndexChanged);
            // 
            // tbDirectorio
            // 
            this.tbDirectorio.Controls.Add(this.pnListViewAlbum);
            this.tbDirectorio.Controls.Add(this.pnInfoAlbum);
            this.tbDirectorio.Location = new System.Drawing.Point(4, 22);
            this.tbDirectorio.Name = "tbDirectorio";
            this.tbDirectorio.Padding = new System.Windows.Forms.Padding(3);
            this.tbDirectorio.Size = new System.Drawing.Size(820, 486);
            this.tbDirectorio.TabIndex = 0;
            this.tbDirectorio.Text = "Directorio";
            this.tbDirectorio.UseVisualStyleBackColor = true;
            // 
            // pnListViewAlbum
            // 
            this.pnListViewAlbum.Controls.Add(this.lvAlbumes);
            this.pnListViewAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnListViewAlbum.Location = new System.Drawing.Point(3, 3);
            this.pnListViewAlbum.Name = "pnListViewAlbum";
            this.pnListViewAlbum.Size = new System.Drawing.Size(541, 480);
            this.pnListViewAlbum.TabIndex = 0;
            // 
            // lvAlbumes
            // 
            this.lvAlbumes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAlbumes.Location = new System.Drawing.Point(0, 0);
            this.lvAlbumes.Name = "lvAlbumes";
            this.lvAlbumes.Size = new System.Drawing.Size(541, 480);
            this.lvAlbumes.TabIndex = 1;
            this.lvAlbumes.UseCompatibleStateImageBehavior = false;
            this.lvAlbumes.View = System.Windows.Forms.View.List;
            this.lvAlbumes.SelectedIndexChanged += new System.EventHandler(this.lvAlbumes_SelectedIndexChanged);
            // 
            // pnInfoAlbum
            // 
            this.pnInfoAlbum.Controls.Add(this.label4);
            this.pnInfoAlbum.Controls.Add(this.lvSplit);
            this.pnInfoAlbum.Controls.Add(this.rbSplit);
            this.pnInfoAlbum.Controls.Add(this.rbSingle);
            this.pnInfoAlbum.Controls.Add(this.rbEP);
            this.pnInfoAlbum.Controls.Add(this.rbCD);
            this.pnInfoAlbum.Controls.Add(this.pnBotonesDirectorio);
            this.pnInfoAlbum.Controls.Add(this.tbAnyo);
            this.pnInfoAlbum.Controls.Add(this.tbAlbum);
            this.pnInfoAlbum.Controls.Add(this.tbArtista);
            this.pnInfoAlbum.Controls.Add(this.label3);
            this.pnInfoAlbum.Controls.Add(this.label2);
            this.pnInfoAlbum.Controls.Add(this.label1);
            this.pnInfoAlbum.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnInfoAlbum.Location = new System.Drawing.Point(544, 3);
            this.pnInfoAlbum.Name = "pnInfoAlbum";
            this.pnInfoAlbum.Size = new System.Drawing.Size(273, 480);
            this.pnInfoAlbum.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Colaboradores";
            // 
            // lvSplit
            // 
            this.lvSplit.Enabled = false;
            this.lvSplit.Location = new System.Drawing.Point(6, 328);
            this.lvSplit.Name = "lvSplit";
            this.lvSplit.Size = new System.Drawing.Size(262, 109);
            this.lvSplit.TabIndex = 12;
            this.lvSplit.UseCompatibleStateImageBehavior = false;
            this.lvSplit.View = System.Windows.Forms.View.List;
            // 
            // rbSplit
            // 
            this.rbSplit.AutoCheck = false;
            this.rbSplit.AutoSize = true;
            this.rbSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSplit.Location = new System.Drawing.Point(9, 278);
            this.rbSplit.Name = "rbSplit";
            this.rbSplit.Size = new System.Drawing.Size(57, 20);
            this.rbSplit.TabIndex = 11;
            this.rbSplit.TabStop = true;
            this.rbSplit.Text = "Split";
            this.rbSplit.UseVisualStyleBackColor = true;
            // 
            // rbSingle
            // 
            this.rbSingle.AutoCheck = false;
            this.rbSingle.AutoSize = true;
            this.rbSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSingle.Location = new System.Drawing.Point(9, 255);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(70, 20);
            this.rbSingle.TabIndex = 10;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "Single";
            this.rbSingle.UseVisualStyleBackColor = true;
            // 
            // rbEP
            // 
            this.rbEP.AutoCheck = false;
            this.rbEP.AutoSize = true;
            this.rbEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEP.Location = new System.Drawing.Point(9, 232);
            this.rbEP.Name = "rbEP";
            this.rbEP.Size = new System.Drawing.Size(46, 20);
            this.rbEP.TabIndex = 9;
            this.rbEP.TabStop = true;
            this.rbEP.Text = "EP";
            this.rbEP.UseVisualStyleBackColor = true;
            // 
            // rbCD
            // 
            this.rbCD.AutoCheck = false;
            this.rbCD.AutoSize = true;
            this.rbCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCD.Location = new System.Drawing.Point(9, 209);
            this.rbCD.Name = "rbCD";
            this.rbCD.Size = new System.Drawing.Size(47, 20);
            this.rbCD.TabIndex = 8;
            this.rbCD.TabStop = true;
            this.rbCD.Text = "CD";
            this.rbCD.UseVisualStyleBackColor = true;
            // 
            // pnBotonesDirectorio
            // 
            this.pnBotonesDirectorio.Controls.Add(this.btPropuesta);
            this.pnBotonesDirectorio.Controls.Add(this.btGuardarDirectorio);
            this.pnBotonesDirectorio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBotonesDirectorio.Location = new System.Drawing.Point(0, 443);
            this.pnBotonesDirectorio.Name = "pnBotonesDirectorio";
            this.pnBotonesDirectorio.Size = new System.Drawing.Size(273, 37);
            this.pnBotonesDirectorio.TabIndex = 7;
            // 
            // btPropuesta
            // 
            this.btPropuesta.Dock = System.Windows.Forms.DockStyle.Right;
            this.btPropuesta.Location = new System.Drawing.Point(133, 0);
            this.btPropuesta.Name = "btPropuesta";
            this.btPropuesta.Size = new System.Drawing.Size(70, 37);
            this.btPropuesta.TabIndex = 8;
            this.btPropuesta.Text = "Propuesta";
            this.btPropuesta.UseVisualStyleBackColor = true;
            this.btPropuesta.Click += new System.EventHandler(this.btPropuesta_Click);
            // 
            // btGuardarDirectorio
            // 
            this.btGuardarDirectorio.Dock = System.Windows.Forms.DockStyle.Right;
            this.btGuardarDirectorio.Location = new System.Drawing.Point(203, 0);
            this.btGuardarDirectorio.Name = "btGuardarDirectorio";
            this.btGuardarDirectorio.Size = new System.Drawing.Size(70, 37);
            this.btGuardarDirectorio.TabIndex = 7;
            this.btGuardarDirectorio.Text = "Guardar";
            this.btGuardarDirectorio.UseVisualStyleBackColor = true;
            this.btGuardarDirectorio.Click += new System.EventHandler(this.btGuardarDirectorio_Click);
            // 
            // tbAnyo
            // 
            this.tbAnyo.Location = new System.Drawing.Point(9, 98);
            this.tbAnyo.Name = "tbAnyo";
            this.tbAnyo.Size = new System.Drawing.Size(69, 20);
            this.tbAnyo.TabIndex = 5;
            // 
            // tbAlbum
            // 
            this.tbAlbum.Location = new System.Drawing.Point(9, 164);
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.Size = new System.Drawing.Size(259, 20);
            this.tbAlbum.TabIndex = 4;
            // 
            // tbArtista
            // 
            this.tbArtista.Location = new System.Drawing.Point(9, 32);
            this.tbArtista.Name = "tbArtista";
            this.tbArtista.Size = new System.Drawing.Size(259, 20);
            this.tbArtista.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del Album";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Año de Grabacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Artista";
            // 
            // tpCanciones
            // 
            this.tpCanciones.Controls.Add(this.panel1);
            this.tpCanciones.Location = new System.Drawing.Point(4, 22);
            this.tpCanciones.Name = "tpCanciones";
            this.tpCanciones.Size = new System.Drawing.Size(820, 486);
            this.tpCanciones.TabIndex = 1;
            this.tpCanciones.Text = "Canciones";
            this.tpCanciones.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 486);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvCanciones);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 486);
            this.panel2.TabIndex = 0;
            // 
            // lvCanciones
            // 
            this.lvCanciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCanciones.Location = new System.Drawing.Point(0, 0);
            this.lvCanciones.Name = "lvCanciones";
            this.lvCanciones.Size = new System.Drawing.Size(547, 486);
            this.lvCanciones.TabIndex = 3;
            this.lvCanciones.UseCompatibleStateImageBehavior = false;
            this.lvCanciones.View = System.Windows.Forms.View.List;
            this.lvCanciones.SelectedIndexChanged += new System.EventHandler(this.lvCanciones_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbTituloPista);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.tbNumeroPista);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.tbAnyoTag);
            this.panel3.Controls.Add(this.tbAlbumTag);
            this.panel3.Controls.Add(this.tbArtistaTag);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(547, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 486);
            this.panel3.TabIndex = 2;
            // 
            // tbTituloPista
            // 
            this.tbTituloPista.Location = new System.Drawing.Point(9, 301);
            this.tbTituloPista.Name = "tbTituloPista";
            this.tbTituloPista.Size = new System.Drawing.Size(259, 20);
            this.tbTituloPista.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Titulo Pista";
            // 
            // tbNumeroPista
            // 
            this.tbNumeroPista.Location = new System.Drawing.Point(6, 233);
            this.tbNumeroPista.Name = "tbNumeroPista";
            this.tbNumeroPista.Size = new System.Drawing.Size(72, 20);
            this.tbNumeroPista.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numeracion Pista";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 449);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 37);
            this.panel4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(133, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Propuesta\r\nAlbum\r\n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(203, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tbAnyoTag
            // 
            this.tbAnyoTag.Location = new System.Drawing.Point(9, 98);
            this.tbAnyoTag.Name = "tbAnyoTag";
            this.tbAnyoTag.Size = new System.Drawing.Size(69, 20);
            this.tbAnyoTag.TabIndex = 5;
            // 
            // tbAlbumTag
            // 
            this.tbAlbumTag.Location = new System.Drawing.Point(9, 164);
            this.tbAlbumTag.Name = "tbAlbumTag";
            this.tbAlbumTag.Size = new System.Drawing.Size(259, 20);
            this.tbAlbumTag.TabIndex = 4;
            // 
            // tbArtistaTag
            // 
            this.tbArtistaTag.Location = new System.Drawing.Point(9, 32);
            this.tbArtistaTag.Name = "tbArtistaTag";
            this.tbArtistaTag.Size = new System.Drawing.Size(259, 20);
            this.tbArtistaTag.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre del Album";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Año de Grabacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre del Artista";
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.Location = new System.Drawing.Point(63, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "Propuesta\r\nPista";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // fmHopeTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 551);
            this.Controls.Add(this.tcBarraTareas);
            this.Controls.Add(this.tsBarraTareas);
            this.Name = "fmHopeTag";
            this.Text = "fmHopeTag";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmHopeTag_Load);
            this.tsBarraTareas.ResumeLayout(false);
            this.tsBarraTareas.PerformLayout();
            this.tcBarraTareas.ResumeLayout(false);
            this.tbDirectorio.ResumeLayout(false);
            this.pnListViewAlbum.ResumeLayout(false);
            this.pnInfoAlbum.ResumeLayout(false);
            this.pnInfoAlbum.PerformLayout();
            this.pnBotonesDirectorio.ResumeLayout(false);
            this.tpCanciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBarraTareas;
        private System.Windows.Forms.ToolStripButton btObtenerAlbumes;
        private System.Windows.Forms.TabControl tcBarraTareas;
        private System.Windows.Forms.TabPage tbDirectorio;
        private System.Windows.Forms.FolderBrowserDialog fbdDirectorioTrabajo;
        private System.Windows.Forms.Panel pnListViewAlbum;
        private System.Windows.Forms.ListView lvAlbumes;
        private System.Windows.Forms.Panel pnInfoAlbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAnyo;
        private System.Windows.Forms.TextBox tbAlbum;
        private System.Windows.Forms.TextBox tbArtista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnBotonesDirectorio;
        private System.Windows.Forms.Button btPropuesta;
        private System.Windows.Forms.Button btGuardarDirectorio;
        private System.Windows.Forms.ListView lvSplit;
        private System.Windows.Forms.RadioButton rbSplit;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.RadioButton rbEP;
        private System.Windows.Forms.RadioButton rbCD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tpCanciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAnterior;
        private System.Windows.Forms.ToolStripButton tsbPlay;
        private System.Windows.Forms.ToolStripButton tsbStop;
        private System.Windows.Forms.ToolStripButton tsbSiguiente;
        private System.Windows.Forms.ToolStripButton tsbBajarVolumen;
        private System.Windows.Forms.ToolStripButton tsbSubirVolumen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbBorrar;
        private System.Windows.Forms.ListView lvCanciones;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbAnyoTag;
        private System.Windows.Forms.TextBox tbAlbumTag;
        private System.Windows.Forms.TextBox tbArtistaTag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox tbTituloPista;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNumeroPista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}