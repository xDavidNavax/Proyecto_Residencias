namespace Proyecto_Residencias
{
    partial class fSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSocios));
            this.idSocioLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.primerApellidoLabel = new System.Windows.Forms.Label();
            this.segundoApellidoLabel = new System.Windows.Forms.Label();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.cuidadLabel = new System.Windows.Forms.Label();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.tblSociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCrocDataSet = new Proyecto_Residencias.dbCrocDataSet();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.segundoApellidoTextBox = new System.Windows.Forms.TextBox();
            this.primerApellidoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.idSocioTextBox = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.tblSociosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblSociosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSociosTableAdapter = new Proyecto_Residencias.dbCrocDataSetTableAdapters.tblSociosTableAdapter();
            this.tableAdapterManager = new Proyecto_Residencias.dbCrocDataSetTableAdapters.TableAdapterManager();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCrocDataSet)).BeginInit();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSociosBindingNavigator)).BeginInit();
            this.tblSociosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSociosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idSocioLabel
            // 
            this.idSocioLabel.AutoSize = true;
            this.idSocioLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idSocioLabel.Location = new System.Drawing.Point(83, 22);
            this.idSocioLabel.Name = "idSocioLabel";
            this.idSocioLabel.Size = new System.Drawing.Size(49, 13);
            this.idSocioLabel.TabIndex = 2;
            this.idSocioLabel.Text = "Id Socio:";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nombreLabel.Location = new System.Drawing.Point(85, 57);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 4;
            this.nombreLabel.Text = "Nombre:";
            // 
            // primerApellidoLabel
            // 
            this.primerApellidoLabel.AutoSize = true;
            this.primerApellidoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.primerApellidoLabel.Location = new System.Drawing.Point(350, 19);
            this.primerApellidoLabel.Name = "primerApellidoLabel";
            this.primerApellidoLabel.Size = new System.Drawing.Size(79, 13);
            this.primerApellidoLabel.TabIndex = 6;
            this.primerApellidoLabel.Text = "Primer Apellido:";
            // 
            // segundoApellidoLabel
            // 
            this.segundoApellidoLabel.AutoSize = true;
            this.segundoApellidoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.segundoApellidoLabel.Location = new System.Drawing.Point(345, 57);
            this.segundoApellidoLabel.Name = "segundoApellidoLabel";
            this.segundoApellidoLabel.Size = new System.Drawing.Size(93, 13);
            this.segundoApellidoLabel.TabIndex = 8;
            this.segundoApellidoLabel.Text = "Segundo Apellido:";
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.telefonoLabel.Location = new System.Drawing.Point(599, 19);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(52, 13);
            this.telefonoLabel.TabIndex = 10;
            this.telefonoLabel.Text = "Telefono:";
            // 
            // cuidadLabel
            // 
            this.cuidadLabel.AutoSize = true;
            this.cuidadLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cuidadLabel.Location = new System.Drawing.Point(608, 60);
            this.cuidadLabel.Name = "cuidadLabel";
            this.cuidadLabel.Size = new System.Drawing.Size(43, 13);
            this.cuidadLabel.TabIndex = 12;
            this.cuidadLabel.Text = "Cuidad:";
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlDetalle.Controls.Add(this.cuidadLabel);
            this.pnlDetalle.Controls.Add(this.ciudadTextBox);
            this.pnlDetalle.Controls.Add(this.telefonoLabel);
            this.pnlDetalle.Controls.Add(this.telefonoTextBox);
            this.pnlDetalle.Controls.Add(this.segundoApellidoLabel);
            this.pnlDetalle.Controls.Add(this.segundoApellidoTextBox);
            this.pnlDetalle.Controls.Add(this.primerApellidoLabel);
            this.pnlDetalle.Controls.Add(this.primerApellidoTextBox);
            this.pnlDetalle.Controls.Add(this.nombreLabel);
            this.pnlDetalle.Controls.Add(this.nombreTextBox);
            this.pnlDetalle.Controls.Add(this.idSocioLabel);
            this.pnlDetalle.Controls.Add(this.idSocioTextBox);
            this.pnlDetalle.Controls.Add(this.btnCancelar);
            this.pnlDetalle.Controls.Add(this.btnGuardar);
            this.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetalle.Location = new System.Drawing.Point(0, 454);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(1026, 107);
            this.pnlDetalle.TabIndex = 1;
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSociosBindingSource, "Cuidad", true));
            this.ciudadTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ciudadTextBox.Location = new System.Drawing.Point(657, 57);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(129, 20);
            this.ciudadTextBox.TabIndex = 13;
            // 
            // tblSociosBindingSource
            // 
            this.tblSociosBindingSource.DataMember = "tblSocios";
            this.tblSociosBindingSource.DataSource = this.dbCrocDataSet;
            // 
            // dbCrocDataSet
            // 
            this.dbCrocDataSet.DataSetName = "dbCrocDataSet";
            this.dbCrocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSociosBindingSource, "Telefono", true));
            this.telefonoTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.telefonoTextBox.Location = new System.Drawing.Point(657, 16);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(129, 20);
            this.telefonoTextBox.TabIndex = 11;
            // 
            // segundoApellidoTextBox
            // 
            this.segundoApellidoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.segundoApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSociosBindingSource, "SegundoApellido", true));
            this.segundoApellidoTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.segundoApellidoTextBox.Location = new System.Drawing.Point(444, 53);
            this.segundoApellidoTextBox.Name = "segundoApellidoTextBox";
            this.segundoApellidoTextBox.Size = new System.Drawing.Size(145, 20);
            this.segundoApellidoTextBox.TabIndex = 9;
            // 
            // primerApellidoTextBox
            // 
            this.primerApellidoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.primerApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSociosBindingSource, "PrimerApellido", true));
            this.primerApellidoTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.primerApellidoTextBox.Location = new System.Drawing.Point(444, 16);
            this.primerApellidoTextBox.Name = "primerApellidoTextBox";
            this.primerApellidoTextBox.Size = new System.Drawing.Size(145, 20);
            this.primerApellidoTextBox.TabIndex = 7;
            this.primerApellidoTextBox.TextChanged += new System.EventHandler(this.primerApellidoTextBox_TextChanged);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSociosBindingSource, "Nombre", true));
            this.nombreTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nombreTextBox.Location = new System.Drawing.Point(138, 54);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(185, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // idSocioTextBox
            // 
            this.idSocioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSociosBindingSource, "IdSocio", true));
            this.idSocioTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idSocioTextBox.Location = new System.Drawing.Point(138, 19);
            this.idSocioTextBox.Name = "idSocioTextBox";
            this.idSocioTextBox.ReadOnly = true;
            this.idSocioTextBox.Size = new System.Drawing.Size(75, 20);
            this.idSocioTextBox.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(12, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 70);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(122, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 70);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(233, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 70);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlBotones.Controls.Add(this.btnEditar);
            this.pnlBotones.Controls.Add(this.btnAgregar);
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.label5);
            this.pnlBotones.Controls.Add(this.label4);
            this.pnlBotones.Controls.Add(this.btnMenu);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1026, 100);
            this.pnlBotones.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(944, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "MENU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(184, -23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 4;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(932, 27);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(77, 70);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.button5_Click);
            // 
            // tblSociosBindingNavigator
            // 
            this.tblSociosBindingNavigator.AddNewItem = null;
            this.tblSociosBindingNavigator.BindingSource = this.tblSociosBindingSource;
            this.tblSociosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblSociosBindingNavigator.DeleteItem = null;
            this.tblSociosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.tblSociosBindingNavigator.Location = new System.Drawing.Point(0, 100);
            this.tblSociosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblSociosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblSociosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblSociosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblSociosBindingNavigator.Name = "tblSociosBindingNavigator";
            this.tblSociosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblSociosBindingNavigator.Size = new System.Drawing.Size(1026, 25);
            this.tblSociosBindingNavigator.TabIndex = 12;
            this.tblSociosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblSociosDataGridView
            // 
            this.tblSociosDataGridView.AllowUserToAddRows = false;
            this.tblSociosDataGridView.AllowUserToDeleteRows = false;
            this.tblSociosDataGridView.AllowUserToOrderColumns = true;
            this.tblSociosDataGridView.AutoGenerateColumns = false;
            this.tblSociosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.tblSociosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tblSociosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSociosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tblSociosDataGridView.DataSource = this.tblSociosBindingSource;
            this.tblSociosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSociosDataGridView.Location = new System.Drawing.Point(0, 125);
            this.tblSociosDataGridView.Name = "tblSociosDataGridView";
            this.tblSociosDataGridView.ReadOnly = true;
            this.tblSociosDataGridView.Size = new System.Drawing.Size(1026, 329);
            this.tblSociosDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdSocio";
            this.dataGridViewTextBoxColumn1.HeaderText = "Folio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 54;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 69;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PrimerApellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "Primer Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 93;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SegundoApellido";
            this.dataGridViewTextBoxColumn4.HeaderText = "Segundo Apellido";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 105;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 74;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cuidad";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cuidad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 65;
            // 
            // tblSociosTableAdapter
            // 
            this.tblSociosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCamionesTableAdapter = null;
            this.tableAdapterManager.tblConciliacionTableAdapter = null;
            this.tableAdapterManager.tblSociosTableAdapter = this.tblSociosTableAdapter;
            this.tableAdapterManager.tblUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Residencias.dbCrocDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            //this.tableAdapterManager.vCamionesTableAdapter = null;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(934, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 70);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(842, 18);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 70);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // fSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1026, 561);
            this.Controls.Add(this.tblSociosDataGridView);
            this.Controls.Add(this.tblSociosBindingNavigator);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlDetalle);
            this.Name = "fSocios";
            this.Opacity = 0.95D;
            this.Text = "SOCIOS";
            this.Load += new System.EventHandler(this.fSocios_Load);
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCrocDataSet)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSociosBindingNavigator)).EndInit();
            this.tblSociosBindingNavigator.ResumeLayout(false);
            this.tblSociosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSociosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMenu;
        private dbCrocDataSet dbCrocDataSet;
        private System.Windows.Forms.BindingSource tblSociosBindingSource;
        private dbCrocDataSetTableAdapters.tblSociosTableAdapter tblSociosTableAdapter;
        private dbCrocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblSociosBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView tblSociosDataGridView;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox segundoApellidoTextBox;
        private System.Windows.Forms.TextBox primerApellidoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox idSocioTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label idSocioLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label primerApellidoLabel;
        private System.Windows.Forms.Label segundoApellidoLabel;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.Label cuidadLabel;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}