namespace Proyecto_Residencias
{
    partial class fConciliacion
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fConciliacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.txtIdConciliacion = new System.Windows.Forms.TextBox();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.nudMetros = new System.Windows.Forms.NumericUpDown();
            this.cboSocio = new System.Windows.Forms.ComboBox();
            this.vCamionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCrocDataSet = new Proyecto_Residencias.dbCrocDataSet();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.vConciliacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vConciliacionTableAdapter = new Proyecto_Residencias.dbCrocDataSetTableAdapters.vConciliacionTableAdapter();
            this.tableAdapterManager = new Proyecto_Residencias.dbCrocDataSetTableAdapters.TableAdapterManager();
            this.vConciliacionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vConciliacionDataGridView = new System.Windows.Forms.DataGridView();
            this.IdConciliacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCamion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vCamionesTableAdapter = new Proyecto_Residencias.dbCrocDataSetTableAdapters.vCamionesTableAdapter();
            this.tblConciliacionTableAdapter = new Proyecto_Residencias.dbCrocDataSetTableAdapters.tblConciliacionTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            idCamionLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.pnlBotones.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMetros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCamionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCrocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vConciliacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vConciliacionBindingNavigator)).BeginInit();
            this.vConciliacionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vConciliacionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idCamionLabel
            // 
            idCamionLabel.AutoSize = true;
            idCamionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            idCamionLabel.Location = new System.Drawing.Point(3, 21);
            idCamionLabel.Name = "idCamionLabel";
            idCamionLabel.Size = new System.Drawing.Size(32, 13);
            idCamionLabel.TabIndex = 9;
            idCamionLabel.Text = "Folio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(3, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 13);
            label1.TabIndex = 10;
            label1.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(3, 86);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 13);
            label2.TabIndex = 11;
            label2.Text = "Socio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label3.Location = new System.Drawing.Point(348, 25);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 13);
            label3.TabIndex = 12;
            label3.Text = "Metros:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label6.Location = new System.Drawing.Point(350, 55);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(52, 13);
            label6.TabIndex = 13;
            label6.Text = "Cantidad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label7.Location = new System.Drawing.Point(350, 88);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(40, 13);
            label7.TabIndex = 14;
            label7.Text = "Precio:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label8.Location = new System.Drawing.Point(569, 53);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(47, 13);
            label8.TabIndex = 15;
            label8.Text = "Material:";
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
            this.pnlBotones.Size = new System.Drawing.Size(1020, 100);
            this.pnlBotones.TabIndex = 12;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(118, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 70);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(229, 9);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 70);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlDetalle.Controls.Add(label8);
            this.pnlDetalle.Controls.Add(label7);
            this.pnlDetalle.Controls.Add(label6);
            this.pnlDetalle.Controls.Add(label3);
            this.pnlDetalle.Controls.Add(label2);
            this.pnlDetalle.Controls.Add(label1);
            this.pnlDetalle.Controls.Add(idCamionLabel);
            this.pnlDetalle.Controls.Add(this.txtIdConciliacion);
            this.pnlDetalle.Controls.Add(this.nudPrecio);
            this.pnlDetalle.Controls.Add(this.txtMaterial);
            this.pnlDetalle.Controls.Add(this.nudCantidad);
            this.pnlDetalle.Controls.Add(this.nudMetros);
            this.pnlDetalle.Controls.Add(this.cboSocio);
            this.pnlDetalle.Controls.Add(this.dtpFecha);
            this.pnlDetalle.Controls.Add(this.btnCancelar);
            this.pnlDetalle.Controls.Add(this.btnGuardar);
            this.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetalle.Location = new System.Drawing.Point(0, 410);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(1020, 142);
            this.pnlDetalle.TabIndex = 13;
            // 
            // txtIdConciliacion
            // 
            this.txtIdConciliacion.Enabled = false;
            this.txtIdConciliacion.Location = new System.Drawing.Point(66, 18);
            this.txtIdConciliacion.Name = "txtIdConciliacion";
            this.txtIdConciliacion.Size = new System.Drawing.Size(100, 20);
            this.txtIdConciliacion.TabIndex = 8;
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(423, 83);
            this.nudPrecio.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(120, 20);
            this.nudPrecio.TabIndex = 7;
            this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(632, 48);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(189, 20);
            this.txtMaterial.TabIndex = 6;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(423, 55);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 5;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMetros
            // 
            this.nudMetros.Location = new System.Drawing.Point(423, 23);
            this.nudMetros.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.nudMetros.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudMetros.Name = "nudMetros";
            this.nudMetros.Size = new System.Drawing.Size(120, 20);
            this.nudMetros.TabIndex = 4;
            this.nudMetros.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // cboSocio
            // 
            this.cboSocio.DataSource = this.vCamionesBindingSource;
            this.cboSocio.DisplayMember = "SocioPlaca";
            this.cboSocio.FormattingEnabled = true;
            this.cboSocio.Location = new System.Drawing.Point(66, 83);
            this.cboSocio.Name = "cboSocio";
            this.cboSocio.Size = new System.Drawing.Size(245, 21);
            this.cboSocio.TabIndex = 3;
            this.cboSocio.ValueMember = "IdCamion";
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
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(66, 53);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 2;
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
            // vConciliacionBindingSource
            // 
            this.vConciliacionBindingSource.DataMember = "vConciliacion";
            this.vConciliacionBindingSource.DataSource = this.dbCrocDataSet;
            // 
            // vConciliacionTableAdapter
            // 
            this.vConciliacionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tblCamionesTableAdapter = null;
            this.tableAdapterManager.tblConciliacionTableAdapter = null;
            this.tableAdapterManager.tblSociosTableAdapter = null;
            this.tableAdapterManager.tblUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Residencias.dbCrocDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vConciliacionBindingNavigator
            // 
            this.vConciliacionBindingNavigator.AddNewItem = null;
            this.vConciliacionBindingNavigator.BindingSource = this.vConciliacionBindingSource;
            this.vConciliacionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vConciliacionBindingNavigator.DeleteItem = null;
            this.vConciliacionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.vConciliacionBindingNavigator.Location = new System.Drawing.Point(0, 100);
            this.vConciliacionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vConciliacionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vConciliacionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vConciliacionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vConciliacionBindingNavigator.Name = "vConciliacionBindingNavigator";
            this.vConciliacionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vConciliacionBindingNavigator.Size = new System.Drawing.Size(1020, 25);
            this.vConciliacionBindingNavigator.TabIndex = 14;
            this.vConciliacionBindingNavigator.Text = "bindingNavigator1";
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
            // vConciliacionDataGridView
            // 
            this.vConciliacionDataGridView.AllowUserToAddRows = false;
            this.vConciliacionDataGridView.AllowUserToDeleteRows = false;
            this.vConciliacionDataGridView.AllowUserToOrderColumns = true;
            this.vConciliacionDataGridView.AutoGenerateColumns = false;
            this.vConciliacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vConciliacionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdConciliacion,
            this.IdCamion,
            this.Fecha,
            this.Socio,
            this.Placa,
            this.Metros,
            this.Cantidad,
            this.Material,
            this.Precio,
            this.IdSocio,
            this.Activo});
            this.vConciliacionDataGridView.DataSource = this.vConciliacionBindingSource;
            this.vConciliacionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vConciliacionDataGridView.Location = new System.Drawing.Point(0, 125);
            this.vConciliacionDataGridView.Name = "vConciliacionDataGridView";
            this.vConciliacionDataGridView.ReadOnly = true;
            this.vConciliacionDataGridView.Size = new System.Drawing.Size(1020, 285);
            this.vConciliacionDataGridView.TabIndex = 14;
            this.vConciliacionDataGridView.SelectionChanged += new System.EventHandler(this.vConciliacionDataGridView_SelectionChanged);
            // 
            // IdConciliacion
            // 
            this.IdConciliacion.DataPropertyName = "IdConciliacion";
            this.IdConciliacion.HeaderText = "Folio";
            this.IdConciliacion.Name = "IdConciliacion";
            this.IdConciliacion.ReadOnly = true;
            // 
            // IdCamion
            // 
            this.IdCamion.DataPropertyName = "IdCamion";
            this.IdCamion.HeaderText = "IdCamion";
            this.IdCamion.Name = "IdCamion";
            this.IdCamion.ReadOnly = true;
            this.IdCamion.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
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
            // Metros
            // 
            this.Metros.DataPropertyName = "Metros";
            this.Metros.HeaderText = "Metros";
            this.Metros.Name = "Metros";
            this.Metros.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Material
            // 
            this.Material.DataPropertyName = "Material";
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle4;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // IdSocio
            // 
            this.IdSocio.DataPropertyName = "IdSocio";
            this.IdSocio.HeaderText = "IdSocio";
            this.IdSocio.Name = "IdSocio";
            this.IdSocio.ReadOnly = true;
            this.IdSocio.Visible = false;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Visible = false;
            // 
            // vCamionesTableAdapter
            // 
            this.vCamionesTableAdapter.ClearBeforeFill = true;
            // 
            // tblConciliacionTableAdapter
            // 
            this.tblConciliacionTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fConciliacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 552);
            this.Controls.Add(this.vConciliacionDataGridView);
            this.Controls.Add(this.vConciliacionBindingNavigator);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.pnlBotones);
            this.Name = "fConciliacion";
            this.Text = "CONCILIACIONES";
            this.Load += new System.EventHandler(this.fConciliacion_Load);
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMetros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCamionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCrocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vConciliacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vConciliacionBindingNavigator)).EndInit();
            this.vConciliacionBindingNavigator.ResumeLayout(false);
            this.vConciliacionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vConciliacionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private dbCrocDataSet dbCrocDataSet;
        private System.Windows.Forms.BindingSource vConciliacionBindingSource;
        private dbCrocDataSetTableAdapters.vConciliacionTableAdapter vConciliacionTableAdapter;
        private dbCrocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vConciliacionBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView vConciliacionDataGridView;
        private System.Windows.Forms.ComboBox cboSocio;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.BindingSource vCamionesBindingSource;
        private dbCrocDataSetTableAdapters.vCamionesTableAdapter vCamionesTableAdapter;
        private System.Windows.Forms.NumericUpDown nudMetros;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtIdConciliacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdConciliacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCamion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private dbCrocDataSetTableAdapters.tblConciliacionTableAdapter tblConciliacionTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}