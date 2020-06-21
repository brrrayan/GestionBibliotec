namespace GestionBiblioteca
{
    partial class FrmDevolucion
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
            System.Windows.Forms.Label idDevolucionLabel;
            System.Windows.Forms.Label idPrestamoLabel;
            System.Windows.Forms.Label idEmpleadoLabel;
            System.Windows.Forms.Label idLibroLabel;
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.Label fecha_PrestamoLabel;
            System.Windows.Forms.Label fecha_DevolucionLabel;
            System.Windows.Forms.Label montoxdiaLabel;
            System.Windows.Forms.Label cant_DiasLabel;
            System.Windows.Forms.Label comentarioLabel;
            System.Windows.Forms.Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDevolucion));
            this.bibliotecaDataSet = new GestionBiblioteca.BibliotecaDataSet();
            this.devolucionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devolucionTableAdapter = new GestionBiblioteca.BibliotecaDataSetTableAdapters.DevolucionTableAdapter();
            this.tableAdapterManager = new GestionBiblioteca.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.devolucionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.idDevolucionTextBox = new System.Windows.Forms.TextBox();
            this.idPrestamoTextBox = new System.Windows.Forms.TextBox();
            this.idEmpleadoTextBox = new System.Windows.Forms.TextBox();
            this.idLibroTextBox = new System.Windows.Forms.TextBox();
            this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.fecha_PrestamoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_DevolucionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.montoxdiaTextBox = new System.Windows.Forms.TextBox();
            this.cant_DiasTextBox = new System.Windows.Forms.TextBox();
            this.comentarioTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.devolucionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.devolucionDataGridView = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idDevolucionLabel = new System.Windows.Forms.Label();
            idPrestamoLabel = new System.Windows.Forms.Label();
            idEmpleadoLabel = new System.Windows.Forms.Label();
            idLibroLabel = new System.Windows.Forms.Label();
            idUsuarioLabel = new System.Windows.Forms.Label();
            fecha_PrestamoLabel = new System.Windows.Forms.Label();
            fecha_DevolucionLabel = new System.Windows.Forms.Label();
            montoxdiaLabel = new System.Windows.Forms.Label();
            cant_DiasLabel = new System.Windows.Forms.Label();
            comentarioLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionBindingNavigator)).BeginInit();
            this.devolucionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devolucionBindingSource
            // 
            this.devolucionBindingSource.DataMember = "Devolucion";
            this.devolucionBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // devolucionTableAdapter
            // 
            this.devolucionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BibliografiaTableAdapter = null;
            this.tableAdapterManager.DevolucionTableAdapter = this.devolucionTableAdapter;
            this.tableAdapterManager.EditoraTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.IdiomaTableAdapter = null;
            this.tableAdapterManager.LibroTableAdapter = null;
            this.tableAdapterManager.PrestamoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionBiblioteca.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // devolucionBindingNavigator
            // 
            this.devolucionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.devolucionBindingNavigator.BindingSource = this.devolucionBindingSource;
            this.devolucionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.devolucionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.devolucionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.devolucionBindingNavigatorSaveItem});
            this.devolucionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.devolucionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.devolucionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.devolucionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.devolucionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.devolucionBindingNavigator.Name = "devolucionBindingNavigator";
            this.devolucionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.devolucionBindingNavigator.Size = new System.Drawing.Size(1272, 25);
            this.devolucionBindingNavigator.TabIndex = 0;
            this.devolucionBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // idDevolucionLabel
            // 
            idDevolucionLabel.AutoSize = true;
            idDevolucionLabel.Location = new System.Drawing.Point(64, 104);
            idDevolucionLabel.Name = "idDevolucionLabel";
            idDevolucionLabel.Size = new System.Drawing.Size(76, 13);
            idDevolucionLabel.TabIndex = 1;
            idDevolucionLabel.Text = "Id Devolucion:";
            // 
            // idDevolucionTextBox
            // 
            this.idDevolucionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devolucionBindingSource, "IdDevolucion", true));
            this.idDevolucionTextBox.Location = new System.Drawing.Point(167, 101);
            this.idDevolucionTextBox.Name = "idDevolucionTextBox";
            this.idDevolucionTextBox.Size = new System.Drawing.Size(200, 20);
            this.idDevolucionTextBox.TabIndex = 2;
            // 
            // idPrestamoLabel
            // 
            idPrestamoLabel.AutoSize = true;
            idPrestamoLabel.Location = new System.Drawing.Point(64, 130);
            idPrestamoLabel.Name = "idPrestamoLabel";
            idPrestamoLabel.Size = new System.Drawing.Size(66, 13);
            idPrestamoLabel.TabIndex = 3;
            idPrestamoLabel.Text = "Id Prestamo:";
            // 
            // idPrestamoTextBox
            // 
            this.idPrestamoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devolucionBindingSource, "IdPrestamo", true));
            this.idPrestamoTextBox.Location = new System.Drawing.Point(167, 127);
            this.idPrestamoTextBox.Name = "idPrestamoTextBox";
            this.idPrestamoTextBox.Size = new System.Drawing.Size(200, 20);
            this.idPrestamoTextBox.TabIndex = 4;
            // 
            // idEmpleadoLabel
            // 
            idEmpleadoLabel.AutoSize = true;
            idEmpleadoLabel.Location = new System.Drawing.Point(64, 156);
            idEmpleadoLabel.Name = "idEmpleadoLabel";
            idEmpleadoLabel.Size = new System.Drawing.Size(69, 13);
            idEmpleadoLabel.TabIndex = 5;
            idEmpleadoLabel.Text = "Id Empleado:";
            // 
            // idEmpleadoTextBox
            // 
            this.idEmpleadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devolucionBindingSource, "IdEmpleado", true));
            this.idEmpleadoTextBox.Location = new System.Drawing.Point(167, 153);
            this.idEmpleadoTextBox.Name = "idEmpleadoTextBox";
            this.idEmpleadoTextBox.Size = new System.Drawing.Size(200, 20);
            this.idEmpleadoTextBox.TabIndex = 6;
            // 
            // idLibroLabel
            // 
            idLibroLabel.AutoSize = true;
            idLibroLabel.Location = new System.Drawing.Point(64, 182);
            idLibroLabel.Name = "idLibroLabel";
            idLibroLabel.Size = new System.Drawing.Size(45, 13);
            idLibroLabel.TabIndex = 7;
            idLibroLabel.Text = "Id Libro:";
            // 
            // idLibroTextBox
            // 
            this.idLibroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devolucionBindingSource, "IdLibro", true));
            this.idLibroTextBox.Location = new System.Drawing.Point(167, 179);
            this.idLibroTextBox.Name = "idLibroTextBox";
            this.idLibroTextBox.Size = new System.Drawing.Size(200, 20);
            this.idLibroTextBox.TabIndex = 8;
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new System.Drawing.Point(64, 208);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(58, 13);
            idUsuarioLabel.TabIndex = 9;
            idUsuarioLabel.Text = "Id Usuario:";
            // 
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devolucionBindingSource, "IdUsuario", true));
            this.idUsuarioTextBox.Location = new System.Drawing.Point(167, 205);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.idUsuarioTextBox.TabIndex = 10;
            // 
            // fecha_PrestamoLabel
            // 
            fecha_PrestamoLabel.AutoSize = true;
            fecha_PrestamoLabel.Location = new System.Drawing.Point(64, 235);
            fecha_PrestamoLabel.Name = "fecha_PrestamoLabel";
            fecha_PrestamoLabel.Size = new System.Drawing.Size(87, 13);
            fecha_PrestamoLabel.TabIndex = 11;
            fecha_PrestamoLabel.Text = "Fecha Prestamo:";
            // 
            // fecha_PrestamoDateTimePicker
            // 
            this.fecha_PrestamoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.devolucionBindingSource, "Fecha_Prestamo", true));
            this.fecha_PrestamoDateTimePicker.Location = new System.Drawing.Point(167, 231);
            this.fecha_PrestamoDateTimePicker.Name = "fecha_PrestamoDateTimePicker";
            this.fecha_PrestamoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_PrestamoDateTimePicker.TabIndex = 12;
            // 
            // fecha_DevolucionLabel
            // 
            fecha_DevolucionLabel.AutoSize = true;
            fecha_DevolucionLabel.Location = new System.Drawing.Point(64, 261);
            fecha_DevolucionLabel.Name = "fecha_DevolucionLabel";
            fecha_DevolucionLabel.Size = new System.Drawing.Size(97, 13);
            fecha_DevolucionLabel.TabIndex = 13;
            fecha_DevolucionLabel.Text = "Fecha Devolucion:";
            // 
            // fecha_DevolucionDateTimePicker
            // 
            this.fecha_DevolucionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.devolucionBindingSource, "Fecha_Devolucion", true));
            this.fecha_DevolucionDateTimePicker.Location = new System.Drawing.Point(167, 257);
            this.fecha_DevolucionDateTimePicker.Name = "fecha_DevolucionDateTimePicker";
            this.fecha_DevolucionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_DevolucionDateTimePicker.TabIndex = 14;
            // 
            // montoxdiaLabel
            // 
            montoxdiaLabel.AutoSize = true;
            montoxdiaLabel.Location = new System.Drawing.Point(64, 286);
            montoxdiaLabel.Name = "montoxdiaLabel";
            montoxdiaLabel.Size = new System.Drawing.Size(59, 13);
            montoxdiaLabel.TabIndex = 15;
            montoxdiaLabel.Text = "Montoxdia:";
            // 
            // montoxdiaTextBox
            // 
            this.montoxdiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devolucionBindingSource, "Montoxdia", true));
            this.montoxdiaTextBox.Location = new System.Drawing.Point(167, 283);
            this.montoxdiaTextBox.Name = "montoxdiaTextBox";
            this.montoxdiaTextBox.Size = new System.Drawing.Size(200, 20);
            this.montoxdiaTextBox.TabIndex = 16;
            // 
            // cant_DiasLabel
            // 
            cant_DiasLabel.AutoSize = true;
            cant_DiasLabel.Location = new System.Drawing.Point(64, 312);
            cant_DiasLabel.Name = "cant_DiasLabel";
            cant_DiasLabel.Size = new System.Drawing.Size(56, 13);
            cant_DiasLabel.TabIndex = 17;
            cant_DiasLabel.Text = "Cant Dias:";
            // 
            // cant_DiasTextBox
            // 
            this.cant_DiasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devolucionBindingSource, "Cant_Dias", true));
            this.cant_DiasTextBox.Location = new System.Drawing.Point(167, 309);
            this.cant_DiasTextBox.Name = "cant_DiasTextBox";
            this.cant_DiasTextBox.Size = new System.Drawing.Size(200, 20);
            this.cant_DiasTextBox.TabIndex = 18;
            // 
            // comentarioLabel
            // 
            comentarioLabel.AutoSize = true;
            comentarioLabel.Location = new System.Drawing.Point(64, 338);
            comentarioLabel.Name = "comentarioLabel";
            comentarioLabel.Size = new System.Drawing.Size(63, 13);
            comentarioLabel.TabIndex = 19;
            comentarioLabel.Text = "Comentario:";
            // 
            // comentarioTextBox
            // 
            this.comentarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devolucionBindingSource, "Comentario", true));
            this.comentarioTextBox.Location = new System.Drawing.Point(167, 335);
            this.comentarioTextBox.Name = "comentarioTextBox";
            this.comentarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.comentarioTextBox.TabIndex = 20;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(64, 364);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 21;
            estadoLabel.Text = "Estado:";
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devolucionBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(167, 361);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(200, 20);
            this.estadoTextBox.TabIndex = 22;
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
            // devolucionBindingNavigatorSaveItem
            // 
            this.devolucionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.devolucionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("devolucionBindingNavigatorSaveItem.Image")));
            this.devolucionBindingNavigatorSaveItem.Name = "devolucionBindingNavigatorSaveItem";
            this.devolucionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.devolucionBindingNavigatorSaveItem.Text = "Guardar datos";
            this.devolucionBindingNavigatorSaveItem.Click += new System.EventHandler(this.devolucionBindingNavigatorSaveItem_Click);
            // 
            // devolucionDataGridView
            // 
            this.devolucionDataGridView.AutoGenerateColumns = false;
            this.devolucionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devolucionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.devolucionDataGridView.DataSource = this.devolucionBindingSource;
            this.devolucionDataGridView.Location = new System.Drawing.Point(465, 83);
            this.devolucionDataGridView.Name = "devolucionDataGridView";
            this.devolucionDataGridView.Size = new System.Drawing.Size(807, 220);
            this.devolucionDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDevolucion";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDevolucion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdPrestamo";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdPrestamo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdEmpleado";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdEmpleado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdLibro";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdLibro";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdUsuario";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdUsuario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fecha_Prestamo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha_Prestamo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Fecha_Devolucion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Fecha_Devolucion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Montoxdia";
            this.dataGridViewTextBoxColumn8.HeaderText = "Montoxdia";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Cant_Dias";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cant_Dias";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Comentario";
            this.dataGridViewTextBoxColumn10.HeaderText = "Comentario";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn11.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // FrmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 450);
            this.Controls.Add(this.devolucionDataGridView);
            this.Controls.Add(idDevolucionLabel);
            this.Controls.Add(this.idDevolucionTextBox);
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
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(this.devolucionBindingNavigator);
            this.Name = "FrmDevolucion";
            this.Text = "FrmDevolucion";
            this.Load += new System.EventHandler(this.FrmDevolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionBindingNavigator)).EndInit();
            this.devolucionBindingNavigator.ResumeLayout(false);
            this.devolucionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource devolucionBindingSource;
        private BibliotecaDataSetTableAdapters.DevolucionTableAdapter devolucionTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator devolucionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton devolucionBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idDevolucionTextBox;
        private System.Windows.Forms.TextBox idPrestamoTextBox;
        private System.Windows.Forms.TextBox idEmpleadoTextBox;
        private System.Windows.Forms.TextBox idLibroTextBox;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.DateTimePicker fecha_PrestamoDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_DevolucionDateTimePicker;
        private System.Windows.Forms.TextBox montoxdiaTextBox;
        private System.Windows.Forms.TextBox cant_DiasTextBox;
        private System.Windows.Forms.TextBox comentarioTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.DataGridView devolucionDataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}