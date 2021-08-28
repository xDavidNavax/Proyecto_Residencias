namespace Proyecto_Residencias
{
    partial class fCamiones
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
            System.Windows.Forms.Label idCamionLabel;
            System.Windows.Forms.Label idSocioLabel;
            System.Windows.Forms.Label placaLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label metrosLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCamiones));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.metrostxt = new System.Windows.Forms.TextBox();
            this.colortxt = new System.Windows.Forms.TextBox();
            this.placatxt = new System.Windows.Forms.TextBox();
            this.idSocioComboBox = new System.Windows.Forms.ComboBox();
            this.idCamiontxt = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.vCamionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCrocDataSet = new Proyecto_Residencias.dbCrocDataSet();
            this.tblCamionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSociosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblCamionesTableAdapter = new Proyecto_Residencias.dbCrocDataSetTableAdapters.tblCamionesTableAdapter();
            this.tableAdapterManager = new Proyecto_Residencias.dbCrocDataSetTableAdapters.TableAdapterManager();
            this.tblCamionesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblCamionesDataGridView = new System.Windows.Forms.DataGridView();
            this.IdCamion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblCamionesTableAdapter1 = new Proyecto_Residencias.dbCrocDataSetTableAdapters.tblCamionesTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dbCrocDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCamionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblSociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSociosTableAdapter = new Proyecto_Residencias.dbCrocDataSetTableAdapters.tblSociosTableAdapter();
            this.vCamionesTableAdapter = new Proyecto_Residencias.dbCrocDataSetTableAdapters.vCamionesTableAdapter();
            this.vCamionesTableAdapter1 = new Proyecto_Residencias.dbCrocDataSetTableAdapters.vCamionesTableAdapter();
            this.vSocioTableAdapter = new Proyecto_Residencias.dbCrocDataSetTableAdapters.vSocioTableAdapter();
            idCamionLabel = new System.Windows.Forms.Label();
            idSocioLabel = new System.Windows.Forms.Label();
            placaLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            metrosLabel = new System.Windows.Forms.Label();
            this.pnlBotones.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vCamionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCrocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCamionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSociosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCamionesBindingNavigator)).BeginInit();
            this.tblCamionesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCamionesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCrocDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCamionesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSociosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idCamionLabel
            // 
            idCamionLabel.AutoSize = true;
            idCamionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            idCamionLabel.Location = new System.Drawing.Point(46, 19);
            idCamionLabel.Name = "idCamionLabel";
            idCamionLabel.Size = new System.Drawing.Size(57, 13);
            idCamionLabel.TabIndex = 2;
            idCamionLabel.Text = "Id Camion:";
            // 
            // idSocioLabel
            // 
            idSocioLabel.AutoSize = true;
            idSocioLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            idSocioLabel.Location = new System.Drawing.Point(54, 48);
            idSocioLabel.Name = "idSocioLabel";
            idSocioLabel.Size = new System.Drawing.Size(49, 13);
            idSocioLabel.TabIndex = 4;
            idSocioLabel.Text = "Id Socio:";
            // 
            // placaLabel
            // 
            placaLabel.AutoSize = true;
            placaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            placaLabel.Location = new System.Drawing.Point(284, 19);
            placaLabel.Name = "placaLabel";
            placaLabel.Size = new System.Drawing.Size(37, 13);
            placaLabel.TabIndex = 6;
            placaLabel.Text = "Placa:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            colorLabel.Location = new System.Drawing.Point(490, 28);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(34, 13);
            colorLabel.TabIndex = 8;
            colorLabel.Text = "Color:";
            // 
            // metrosLabel
            // 
            metrosLabel.AutoSize = true;
            metrosLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            metrosLabel.Location = new System.Drawing.Point(279, 51);
            metrosLabel.Name = "metrosLabel";
            metrosLabel.Size = new System.Drawing.Size(42, 13);
            metrosLabel.TabIndex = 10;
            metrosLabel.Text = "Metros:";
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlBotones.Controls.Add(this.label5);
            this.pnlBotones.Controls.Add(this.label4);
            this.pnlBotones.Controls.Add(this.btnMenu);
            this.pnlBotones.Controls.Add(this.btnAgregar);
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnEditar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1054, 100);
            this.pnlBotones.TabIndex = 15;
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
            this.btnMenu.Click += new System.EventHandler(this.button6_Click);
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
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEliminar.Location = new System.Drawing.Point(253, 9);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 70);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(130, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 70);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlDetalle.Controls.Add(metrosLabel);
            this.pnlDetalle.Controls.Add(this.metrostxt);
            this.pnlDetalle.Controls.Add(colorLabel);
            this.pnlDetalle.Controls.Add(this.colortxt);
            this.pnlDetalle.Controls.Add(placaLabel);
            this.pnlDetalle.Controls.Add(this.placatxt);
            this.pnlDetalle.Controls.Add(idSocioLabel);
            this.pnlDetalle.Controls.Add(this.idSocioComboBox);
            this.pnlDetalle.Controls.Add(idCamionLabel);
            this.pnlDetalle.Controls.Add(this.idCamiontxt);
            this.pnlDetalle.Controls.Add(this.btnCancelar);
            this.pnlDetalle.Controls.Add(this.btnGuardar);
            this.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetalle.Location = new System.Drawing.Point(0, 497);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(1054, 114);
            this.pnlDetalle.TabIndex = 16;
            this.pnlDetalle.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // metrostxt
            // 
            this.metrostxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metrostxt.Location = new System.Drawing.Point(327, 48);
            this.metrostxt.Name = "metrostxt";
            this.metrostxt.Size = new System.Drawing.Size(100, 20);
            this.metrostxt.TabIndex = 11;
            // 
            // colortxt
            // 
            this.colortxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colortxt.Location = new System.Drawing.Point(530, 25);
            this.colortxt.Name = "colortxt";
            this.colortxt.Size = new System.Drawing.Size(100, 20);
            this.colortxt.TabIndex = 9;
            // 
            // placatxt
            // 
            this.placatxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.placatxt.Location = new System.Drawing.Point(327, 16);
            this.placatxt.Name = "placatxt";
            this.placatxt.Size = new System.Drawing.Size(100, 20);
            this.placatxt.TabIndex = 7;
            // 
            // idSocioComboBox
            // 
            this.idSocioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idSocioComboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idSocioComboBox.FormattingEnabled = true;
            this.idSocioComboBox.Location = new System.Drawing.Point(109, 45);
            this.idSocioComboBox.Name = "idSocioComboBox";
            this.idSocioComboBox.Size = new System.Drawing.Size(121, 21);
            this.idSocioComboBox.TabIndex = 5;
            // 
            // idCamiontxt
            // 
            this.idCamiontxt.Enabled = false;
            this.idCamiontxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idCamiontxt.Location = new System.Drawing.Point(109, 16);
            this.idCamiontxt.Name = "idCamiontxt";
            this.idCamiontxt.Size = new System.Drawing.Size(121, 20);
            this.idCamiontxt.TabIndex = 3;
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
            // vCamionesBindingSource
            // 
            this.vCamionesBindingSource.DataMember = "vCamiones";
            this.vCamionesBindingSource.DataSource = this.dbCrocDataSet;
            // 
            // dbCrocDataSet
            // 
            this.dbCrocDataSet.DataSetName = "dbCrocDataSet";
            this.dbCrocDataSet.EnforceConstraints = false;
            this.dbCrocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCamionesBindingSource
            // 
            this.tblCamionesBindingSource.DataMember = "tblCamiones";
            this.tblCamionesBindingSource.DataSource = this.dbCrocDataSet;
            this.tblCamionesBindingSource.CurrentChanged += new System.EventHandler(this.tblCamionesBindingSource_CurrentChanged);
            // 
            // tblSociosBindingSource1
            // 
            this.tblSociosBindingSource1.DataMember = "tblSocios";
            this.tblSociosBindingSource1.DataSource = this.dbCrocDataSet;
            // 
            // tblCamionesTableAdapter
            // 
            this.tblCamionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCamionesTableAdapter = this.tblCamionesTableAdapter;
            this.tableAdapterManager.tblConciliacionTableAdapter = null;
            this.tableAdapterManager.tblSociosTableAdapter = null;
            this.tableAdapterManager.tblUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Residencias.dbCrocDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCamionesBindingNavigator
            // 
            this.tblCamionesBindingNavigator.AddNewItem = null;
            this.tblCamionesBindingNavigator.BindingSource = this.tblCamionesBindingSource;
            this.tblCamionesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblCamionesBindingNavigator.DeleteItem = null;
            this.tblCamionesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.tblCamionesBindingNavigator.Location = new System.Drawing.Point(0, 100);
            this.tblCamionesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblCamionesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblCamionesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblCamionesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblCamionesBindingNavigator.Name = "tblCamionesBindingNavigator";
            this.tblCamionesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblCamionesBindingNavigator.Size = new System.Drawing.Size(1054, 25);
            this.tblCamionesBindingNavigator.TabIndex = 17;
            this.tblCamionesBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
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
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
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
            // tblCamionesDataGridView
            // 
            this.tblCamionesDataGridView.AllowUserToAddRows = false;
            this.tblCamionesDataGridView.AllowUserToDeleteRows = false;
            this.tblCamionesDataGridView.AllowUserToOrderColumns = true;
            this.tblCamionesDataGridView.AutoGenerateColumns = false;
            this.tblCamionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCamionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCamion,
            this.IdSocio,
            this.Socio,
            this.Placa,
            this.Color,
            this.Metros,
            this.activoDataGridViewCheckBoxColumn});
            this.tblCamionesDataGridView.DataSource = this.vCamionesBindingSource;
            this.tblCamionesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCamionesDataGridView.Location = new System.Drawing.Point(0, 125);
            this.tblCamionesDataGridView.Name = "tblCamionesDataGridView";
            this.tblCamionesDataGridView.ReadOnly = true;
            this.tblCamionesDataGridView.Size = new System.Drawing.Size(1054, 372);
            this.tblCamionesDataGridView.TabIndex = 17;
            this.tblCamionesDataGridView.SelectionChanged += new System.EventHandler(this.tblCamionesDataGridView_SelectionChanged);
            // 
            // IdCamion
            // 
            this.IdCamion.DataPropertyName = "IdCamion";
            this.IdCamion.HeaderText = "IdCamion";
            this.IdCamion.Name = "IdCamion";
            this.IdCamion.ReadOnly = true;
            // 
            // IdSocio
            // 
            this.IdSocio.DataPropertyName = "IdSocio";
            this.IdSocio.HeaderText = "IdSocio";
            this.IdSocio.Name = "IdSocio";
            this.IdSocio.ReadOnly = true;
            this.IdSocio.Visible = false;
            // 
            // Socio
            // 
            this.Socio.DataPropertyName = "Socio";
            this.Socio.HeaderText = "Socio";
            this.Socio.Name = "Socio";
            this.Socio.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "Placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Metros
            // 
            this.Metros.DataPropertyName = "Metros";
            this.Metros.HeaderText = "Metros";
            this.Metros.Name = "Metros";
            this.Metros.ReadOnly = true;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // tblCamionesTableAdapter1
            // 
            this.tblCamionesTableAdapter1.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dbCrocDataSetBindingSource
            // 
            this.dbCrocDataSetBindingSource.DataSource = this.dbCrocDataSet;
            this.dbCrocDataSetBindingSource.Position = 0;
            // 
            // tblCamionesBindingSource1
            // 
            this.tblCamionesBindingSource1.DataMember = "tblCamiones";
            this.tblCamionesBindingSource1.DataSource = this.dbCrocDataSet;
            // 
            // tblSociosBindingSource
            // 
            this.tblSociosBindingSource.DataMember = "tblSocios";
            this.tblSociosBindingSource.DataSource = this.dbCrocDataSet;
            // 
            // tblSociosTableAdapter
            // 
            this.tblSociosTableAdapter.ClearBeforeFill = true;
            // 
            // vCamionesTableAdapter
            // 
            this.vCamionesTableAdapter.ClearBeforeFill = true;
            // 
            // vCamionesTableAdapter1
            // 
            this.vCamionesTableAdapter1.ClearBeforeFill = true;
            // 
            // vSocioTableAdapter
            // 
            this.vSocioTableAdapter.ClearBeforeFill = true;
            // 
            // fCamiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1054, 611);
            this.Controls.Add(this.tblCamionesDataGridView);
            this.Controls.Add(this.tblCamionesBindingNavigator);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.pnlBotones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fCamiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMIONES";
            this.Load += new System.EventHandler(this.fCamiones_Load);
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vCamionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCrocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCamionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSociosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCamionesBindingNavigator)).EndInit();
            this.tblCamionesBindingNavigator.ResumeLayout(false);
            this.tblCamionesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCamionesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCrocDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCamionesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSociosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private dbCrocDataSet dbCrocDataSet;
        private System.Windows.Forms.BindingSource tblCamionesBindingSource;
        private dbCrocDataSetTableAdapters.tblCamionesTableAdapter tblCamionesTableAdapter;
        private dbCrocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblCamionesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView tblCamionesDataGridView;
        private dbCrocDataSetTableAdapters.tblCamionesTableAdapter tblCamionesTableAdapter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource tblCamionesBindingSource1;
        private System.Windows.Forms.BindingSource dbCrocDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblSociosBindingSource;
        private dbCrocDataSetTableAdapters.tblSociosTableAdapter tblSociosTableAdapter;
        private System.Windows.Forms.BindingSource tblSociosBindingSource1;
        private System.Windows.Forms.BindingSource vCamionesBindingSource;
        private dbCrocDataSetTableAdapters.vCamionesTableAdapter vCamionesTableAdapter;
        private dbCrocDataSetTableAdapters.vCamionesTableAdapter vCamionesTableAdapter1;
        private System.Windows.Forms.ComboBox idSocioComboBox;
        private System.Windows.Forms.TextBox idCamiontxt;
        private System.Windows.Forms.TextBox metrostxt;
        private System.Windows.Forms.TextBox colortxt;
        private System.Windows.Forms.TextBox placatxt;
        private dbCrocDataSetTableAdapters.vSocioTableAdapter vSocioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCamion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metros;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
    }
}