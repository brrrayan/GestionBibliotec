namespace GestionBiblioteca
{
    partial class FrmPrestamo
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
            System.Windows.Forms.Label idPrestamoLabel;
            System.Windows.Forms.Label idEmpleadoLabel;
            System.Windows.Forms.Label idLibroLabel;
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.Label fecha_PrestamoLabel;
            System.Windows.Forms.Label fecha_DevolucionLabel;
            System.Windows.Forms.Label montoxdiaLabel;
            System.Windows.Forms.Label cant_DiasLabel;
            System.Windows.Forms.Label comentarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamo));
            this.prestamoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new GestionBiblioteca.BibliotecaDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.prestamoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idPrestamoTextBox = new System.Windows.Forms.TextBox();
            this.idEmpleadoTextBox = new System.Windows.Forms.TextBox();
            this.idLibroTextBox = new System.Windows.Forms.TextBox();
            this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.fecha_PrestamoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_DevolucionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.montoxdiaTextBox = new System.Windows.Forms.TextBox();
            this.cant_DiasTextBox = new System.Windows.Forms.TextBox();
            this.comentarioTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.prestamoTableAdapter = new GestionBiblioteca.BibliotecaDataSetTableAdapters.PrestamoTableAdapter();
            this.tableAdapterManager = new GestionBiblioteca.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.prestamoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idPrestamoLabel = new System.Windows.Forms.Label();
            idEmpleadoLabel = new System.Windows.Forms.Label();
            idLibroLabel = new System.Windows.Forms.Label();
            idUsuarioLabel = new System.Windows.Forms.Label();
            fecha_PrestamoLabel = new System.Windows.Forms.Label();
            fecha_DevolucionLabel = new System.Windows.Forms.Label();
            montoxdiaLabel = new System.Windows.Forms.Label();
            cant_DiasLabel = new System.Windows.Forms.Label();
            comentarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingNavigator)).BeginInit();
            this.prestamoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idPrestamoLabel
            // 
            idPrestamoLabel.AutoSize = true;
            idPrestamoLabel.Location = new System.Drawing.Point(38, 79);
            idPrestamoLabel.Name = "idPrestamoLabel";
            idPrestamoLabel.Size = new System.Drawing.Size(66, 13);
            idPrestamoLabel.TabIndex = 1;
            idPrestamoLabel.Text = "Id Prestamo:";
            // 
            // idEmpleadoLabel
            // 
            idEmpleadoLabel.AutoSize = true;
            idEmpleadoLabel.Location = new System.Drawing.Point(38, 105);
            idEmpleadoLabel.Name = "idEmpleadoLabel";
            idEmpleadoLabel.Size = new System.Drawing.Size(69, 13);
            idEmpleadoLabel.TabIndex = 3;
            idEmpleadoLabel.Text = "Id Empleado:";
            // 
            // idLibroLabel
            // 
            idLibroLabel.AutoSize = true;
            idLibroLabel.Location = new System.Drawing.Point(38, 131);
            idLibroLabel.Name = "idLibroLabel";
            idLibroLabel.Size = new System.Drawing.Size(45, 13);
            idLibroLabel.TabIndex = 5;
            idLibroLabel.Text = "Id Libro:";
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new System.Drawing.Point(38, 157);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(58, 13);
            idUsuarioLabel.TabIndex = 7;
            idUsuarioLabel.Text = "Id Usuario:";
            // 
            // fecha_PrestamoLabel
            // 
            fecha_PrestamoLabel.AutoSize = true;
            fecha_PrestamoLabel.Location = new System.Drawing.Point(38, 184);
            fecha_PrestamoLabel.Name = "fecha_PrestamoLabel";
            fecha_PrestamoLabel.Size = new System.Drawing.Size(87, 13);
            fecha_PrestamoLabel.TabIndex = 9;
            fecha_PrestamoLabel.Text = "Fecha Prestamo:";
            // 
            // fecha_DevolucionLabel
            // 
            fecha_DevolucionLabel.AutoSize = true;
            fecha_DevolucionLabel.Location = new System.Drawing.Point(38, 210);
            fecha_DevolucionLabel.Name = "fecha_DevolucionLabel";
            fecha_DevolucionLabel.Size = new System.Drawing.Size(97, 13);
            fecha_DevolucionLabel.TabIndex = 11;
            fecha_DevolucionLabel.Text = "Fecha Devolucion:";
            // 
            // montoxdiaLabel
            // 
            montoxdiaLabel.AutoSize = true;
            montoxdiaLabel.Location = new System.Drawing.Point(38, 235);
            montoxdiaLabel.Name = "montoxdiaLabel";
            montoxdiaLabel.Size = new System.Drawing.Size(59, 13);
            montoxdiaLabel.TabIndex = 13;
            montoxdiaLabel.Text = "Montoxdia:";
            // 
            // cant_DiasLabel
            // 
            cant_DiasLabel.AutoSize = true;
            cant_DiasLabel.Location = new System.Drawing.Point(38, 261);
            cant_DiasLabel.Name = "cant_DiasLabel";
            cant_DiasLabel.Size = new System.Drawing.Size(56, 13);
            cant_DiasLabel.TabIndex = 15;
            cant_DiasLabel.Text = "Cant Dias:";
            // 
            // comentarioLabel
            // 
            comentarioLabel.AutoSize = true;
            comentarioLabel.Location = new System.Drawing.Point(38, 287);
            comentarioLabel.Name = "comentarioLabel";
            comentarioLabel.Size = new System.Drawing.Size(63, 13);
            comentarioLabel.TabIndex = 17;
            comentarioLabel.Text = "Comentario:";
            // 
            // prestamoBindingNavigator
            // 
            this.prestamoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prestamoBindingNavigator.BindingSource = this.prestamoBindingSource;
            this.prestamoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prestamoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prestamoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.prestamoBindingNavigatorSaveItem});
            this.prestamoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prestamoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prestamoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prestamoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prestamoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prestamoBindingNavigator.Name = "prestamoBindingNavigator";
            this.prestamoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prestamoBindingNavigator.Size = new System.Drawing.Size(1358, 25);
            this.prestamoBindingNavigator.TabIndex = 0;
            this.prestamoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataMember = "Prestamo";
            this.prestamoBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
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
            // prestamoBindingNavigatorSaveItem
            // 
            this.prestamoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prestamoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prestamoBindingNavigatorSaveItem.Image")));
            this.prestamoBindingNavigatorSaveItem.Name = "prestamoBindingNavigatorSaveItem";
            this.prestamoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.prestamoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.prestamoBindingNavigatorSaveItem.Click += new System.EventHandler(this.prestamoBindingNavigatorSaveItem_Click_1);
            // 
            // idPrestamoTextBox
            // 
            this.idPrestamoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamoBindingSource, "IdPrestamo", true));
            this.idPrestamoTextBox.Location = new System.Drawing.Point(245, 72);
            this.idPrestamoTextBox.Name = "idPrestamoTextBox";
            this.idPrestamoTextBox.Size = new System.Drawing.Size(200, 20);
            this.idPrestamoTextBox.TabIndex = 2;
            // 
            // idEmpleadoTextBox
            // 
            this.idEmpleadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamoBindingSource, "IdEmpleado", true));
            this.idEmpleadoTextBox.Location = new System.Drawing.Point(245, 98);
            this.idEmpleadoTextBox.Name = "idEmpleadoTextBox";
            this.idEmpleadoTextBox.Size = new System.Drawing.Size(200, 20);
            this.idEmpleadoTextBox.TabIndex = 4;
            // 
            // idLibroTextBox
            // 
            this.idLibroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamoBindingSource, "IdLibro", true));
            this.idLibroTextBox.Location = new System.Drawing.Point(245, 124);
            this.idLibroTextBox.Name = "idLibroTextBox";
            this.idLibroTextBox.Size = new System.Drawing.Size(200, 20);
            this.idLibroTextBox.TabIndex = 6;
            // 
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamoBindingSource, "IdUsuario", true));
            this.idUsuarioTextBox.Location = new System.Drawing.Point(245, 150);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.idUsuarioTextBox.TabIndex = 8;
            // 
            // fecha_PrestamoDateTimePicker
            // 
            this.fecha_PrestamoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prestamoBindingSource, "Fecha_Prestamo", true));
            this.fecha_PrestamoDateTimePicker.Location = new System.Drawing.Point(245, 176);
            this.fecha_PrestamoDateTimePicker.Name = "fecha_PrestamoDateTimePicker";
            this.fecha_PrestamoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_PrestamoDateTimePicker.TabIndex = 10;
            this.fecha_PrestamoDateTimePicker.ValueChanged += new System.EventHandler(this.fecha_PrestamoDateTimePicker_ValueChanged);
            // 
            // fecha_DevolucionDateTimePicker
            // 
            this.fecha_DevolucionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prestamoBindingSource, "Fecha_Devolucion", true));
            this.fecha_DevolucionDateTimePicker.Location = new System.Drawing.Point(245, 202);
            this.fecha_DevolucionDateTimePicker.Name = "fecha_DevolucionDateTimePicker";
            this.fecha_DevolucionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_DevolucionDateTimePicker.TabIndex = 12;
            // 
            // montoxdiaTextBox
            // 
            this.montoxdiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamoBindingSource, "Montoxdia", true));
            this.montoxdiaTextBox.Location = new System.Drawing.Point(245, 228);
            this.montoxdiaTextBox.Name = "montoxdiaTextBox";
            this.montoxdiaTextBox.Size = new System.Drawing.Size(200, 20);
            this.montoxdiaTextBox.TabIndex = 14;
            // 
            // cant_DiasTextBox
            // 
            this.cant_DiasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamoBindingSource, "Cant_Dias", true));
            this.cant_DiasTextBox.Location = new System.Drawing.Point(245, 254);
            this.cant_DiasTextBox.Name = "cant_DiasTextBox";
            this.cant_DiasTextBox.Size = new System.Drawing.Size(200, 20);
            this.cant_DiasTextBox.TabIndex = 16;
            // 
            // comentarioTextBox
            // 
            this.comentarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamoBindingSource, "Comentario", true));
            this.comentarioTextBox.Location = new System.Drawing.Point(245, 280);
            this.comentarioTextBox.Name = "comentarioTextBox";
            this.comentarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.comentarioTextBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prestamoTableAdapter
            // 
            this.prestamoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BibliografiaTableAdapter = null;
            this.tableAdapterManager.DevolucionTableAdapter = null;
            this.tableAdapterManager.EditoraTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.IdiomaTableAdapter = null;
            this.tableAdapterManager.LibroTableAdapter = null;
            this.tableAdapterManager.PrestamoTableAdapter = this.prestamoTableAdapter;
            this.tableAdapterManager.UpdateOrder = GestionBiblioteca.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // prestamoDataGridView
            // 
            this.prestamoDataGridView.AutoGenerateColumns = false;
            this.prestamoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prestamoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.prestamoDataGridView.DataSource = this.prestamoBindingSource;
            this.prestamoDataGridView.Location = new System.Drawing.Point(481, 105);
            this.prestamoDataGridView.Name = "prestamoDataGridView";
            this.prestamoDataGridView.Size = new System.Drawing.Size(865, 220);
            this.prestamoDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdPrestamo";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdPrestamo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdEmpleado";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdEmpleado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdLibro";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdLibro";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdUsuario";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdUsuario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Fecha_Prestamo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha_Prestamo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fecha_Devolucion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha_Devolucion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Montoxdia";
            this.dataGridViewTextBoxColumn7.HeaderText = "Montoxdia";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cant_Dias";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cant_Dias";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Comentario";
            this.dataGridViewTextBoxColumn9.HeaderText = "Comentario";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn10.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 474);
            this.Controls.Add(this.prestamoDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(idPrestamoLabel);
            this.Controls.Add(this.idPrestamoTextBox);
            this.Controls.Add(idEmpleadoLabel);
            this.Controls.Add(this.idEmpleadoTextBox);
            this.Controls.Add(idLibroLabel);
            this.Controls.Add(this.idLibroTextBox);
            this.Controls.Add(idUsuarioLabel);
            this.Controls.Add(this.idUsuarioTextBox);
            this.Controls.Add(fecha_PrestamoLabel);
            this.Controls.Add(this.fecha_PrestamoDateTimePicker);
            this.Controls.Add(fecha_DevolucionLabel);
            this.Controls.Add(this.fecha_DevolucionDateTimePicker);
            this.Controls.Add(montoxdiaLabel);
            this.Controls.Add(this.montoxdiaTextBox);
            this.Controls.Add(cant_DiasLabel);
            this.Controls.Add(this.cant_DiasTextBox);
            this.Controls.Add(comentarioLabel);
            this.Controls.Add(this.comentarioTextBox);
            this.Controls.Add(this.prestamoBindingNavigator);
            this.Name = "FrmPrestamo";
            this.Text = "FrmPrestamo";
            this.Load += new System.EventHandler(this.FrmPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingNavigator)).EndInit();
            this.prestamoBindingNavigator.ResumeLayout(false);
            this.prestamoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
        private BibliotecaDataSetTableAdapters.PrestamoTableAdapter prestamoTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prestamoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton prestamoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idPrestamoTextBox;
        private System.Windows.Forms.TextBox idEmpleadoTextBox;
        private System.Windows.Forms.TextBox idLibroTextBox;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.DateTimePicker fecha_PrestamoDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_DevolucionDateTimePicker;
        private System.Windows.Forms.TextBox montoxdiaTextBox;
        private System.Windows.Forms.TextBox cant_DiasTextBox;
        private System.Windows.Forms.TextBox comentarioTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView prestamoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}