namespace HerramientasCONCIVELS
{
    partial class formInterfazH
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
            this.lblTituloherramientas = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTipoHerramienta = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.dgvListaH = new System.Windows.Forms.DataGridView();
            this.btGuardar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btModificar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cmbBuscarpor = new System.Windows.Forms.ComboBox();
            this.lblcambio = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloherramientas
            // 
            this.lblTituloherramientas.AutoSize = true;
            this.lblTituloherramientas.Font = new System.Drawing.Font("Noto Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloherramientas.Location = new System.Drawing.Point(42, 52);
            this.lblTituloherramientas.Name = "lblTituloherramientas";
            this.lblTituloherramientas.Size = new System.Drawing.Size(399, 65);
            this.lblTituloherramientas.TabIndex = 0;
            this.lblTituloherramientas.Text = "HERRAMIENTAS";
            this.lblTituloherramientas.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(48, 192);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(93, 28);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo: ";
            // 
            // lblTipoHerramienta
            // 
            this.lblTipoHerramienta.AutoSize = true;
            this.lblTipoHerramienta.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoHerramienta.Location = new System.Drawing.Point(48, 249);
            this.lblTipoHerramienta.Name = "lblTipoHerramienta";
            this.lblTipoHerramienta.Size = new System.Drawing.Size(66, 28);
            this.lblTipoHerramienta.TabIndex = 2;
            this.lblTipoHerramienta.Text = "Tipo: ";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(48, 304);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(80, 28);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(48, 355);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(76, 28);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color: ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(147, 191);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(152, 33);
            this.txtCodigo.TabIndex = 5;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Taladro",
            "Pulidora",
            "Bomba de K.O",
            "Cortadora"});
            this.cmbTipo.Location = new System.Drawing.Point(147, 249);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(152, 34);
            this.cmbTipo.TabIndex = 6;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Itachi",
            "Milwaukee",
            "Bosch",
            "Totoman"});
            this.cmbMarca.Location = new System.Drawing.Point(147, 303);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(152, 34);
            this.cmbMarca.TabIndex = 7;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Azul",
            "Rojo",
            "Verde",
            "Amarillo"});
            this.cmbColor.Location = new System.Drawing.Point(147, 355);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(152, 34);
            this.cmbColor.TabIndex = 8;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dgvListaH
            // 
            this.dgvListaH.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListaH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaH.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListaH.Location = new System.Drawing.Point(615, 87);
            this.dgvListaH.Name = "dgvListaH";
            this.dgvListaH.Size = new System.Drawing.Size(514, 296);
            this.dgvListaH.TabIndex = 9;
            this.dgvListaH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGuardar.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(369, 147);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(172, 58);
            this.btGuardar.TabIndex = 10;
            this.btGuardar.Text = "GUARDAR";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1263, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btModificar.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.Location = new System.Drawing.Point(369, 235);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(172, 58);
            this.btModificar.TabIndex = 12;
            this.btModificar.Text = "MODIFICAR";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEliminar.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(369, 325);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(172, 58);
            this.btEliminar.TabIndex = 13;
            this.btEliminar.Text = "ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(612, 52);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(86, 16);
            this.lblBuscar.TabIndex = 14;
            this.lblBuscar.Text = "Buscar por:";
            this.lblBuscar.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmbBuscarpor
            // 
            this.cmbBuscarpor.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbBuscarpor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarpor.FormattingEnabled = true;
            this.cmbBuscarpor.Items.AddRange(new object[] {
            "Codigo",
            "Tipo",
            "Marca",
            "Color"});
            this.cmbBuscarpor.Location = new System.Drawing.Point(704, 52);
            this.cmbBuscarpor.Name = "cmbBuscarpor";
            this.cmbBuscarpor.Size = new System.Drawing.Size(121, 21);
            this.cmbBuscarpor.TabIndex = 15;
            this.cmbBuscarpor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblcambio
            // 
            this.lblcambio.AutoSize = true;
            this.lblcambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcambio.Location = new System.Drawing.Point(892, 52);
            this.lblcambio.Name = "lblcambio";
            this.lblcambio.Size = new System.Drawing.Size(75, 16);
            this.lblcambio.TabIndex = 16;
            this.lblcambio.Text = "lblcambio";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(973, 51);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 22);
            this.txtBuscar.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::HerramientasCONCIVELS.Properties.Resources.lupa;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(831, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 41);
            this.button1.TabIndex = 18;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // formInterfazH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblcambio);
            this.Controls.Add(this.cmbBuscarpor);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.dgvListaH);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblTipoHerramienta);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTituloherramientas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formInterfazH";
            this.Text = "Interfaz de Herramientas";
            this.Load += new System.EventHandler(this.formInterfazH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloherramientas;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTipoHerramienta;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.DataGridView dgvListaH;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cmbBuscarpor;
        private System.Windows.Forms.Label lblcambio;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button button1;
    }
}

