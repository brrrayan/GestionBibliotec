namespace GestionBiblioteca
{
    partial class FrmEmpleado
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
            System.Windows.Forms.Label idEmpleadoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label tandaLabel;
            System.Windows.Forms.Label porcientoComisionLabel;
            System.Windows.Forms.Label fecha_ingresoLabel;
            System.Windows.Forms.Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
            this.bibliotecaDataSet = new GestionBiblioteca.BibliotecaDataSet();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new GestionBiblioteca.BibliotecaDataSetTableAdapters.EmpleadoTableAdapter();
            this.tableAdapterManager = new GestionBiblioteca.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.empleadoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.idEmpleadoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.tandaTextBox = new System.Windows.Forms.TextBox();
            this.porcientoComisionTextBox = new System.Windows.Forms.TextBox();
            this.fecha_ingresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.empleadoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.empleadoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idEmpleadoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            cedulaLabel = new System.Windows.Forms.Label();
            tandaLabel = new System.Windows.Forms.Label();
            porcientoComisionLabel = new System.Windows.Forms.Label();
            fecha_ingresoLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingNavigator)).BeginInit();
            this.empleadoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BibliografiaTableAdapter = null;
            this.tableAdapterManager.DevolucionTableAdapter = null;
            this.tableAdapterManager.EditoraTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = this.empleadoTableAdapter;
            this.tableAdapterManager.IdiomaTableAdapter = null;
            this.tableAdapterManager.LibroTableAdapter = null;
            this.tableAdapterManager.PrestamoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionBiblioteca.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // empleadoBindingNavigator
            // 
            this.empleadoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.empleadoBindingNavigator.BindingSource = this.empleadoBindingSource;
            this.empleadoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.empleadoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.empleadoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.empleadoBindingNavigatorSaveItem});
            this.empleadoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.empleadoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.empleadoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.empleadoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.empleadoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.empleadoBindingNavigator.Name = "empleadoBindingNavigator";
            this.empleadoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.empleadoBindingNavigator.Size = new System.Drawing.Size(1215, 25);
            this.empleadoBindingNavigator.TabIndex = 0;
            this.empleadoBindingNavigator.Text = "bindingNavigator1";
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
            // idEmpleadoLabel
            // 
            idEmpleadoLabel.AutoSize = true;
            idEmpleadoLabel.Location = new System.Drawing.Point(51, 127);
            idEmpleadoLabel.Name = "idEmpleadoLabel";
            idEmpleadoLabel.Size = new System.Drawing.Size(69, 13);
            idEmpleadoLabel.TabIndex = 1;
            idEmpleadoLabel.Text = "Id Empleado:";
            // 
            // idEmpleadoTextBox
            // 
            this.idEmpleadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "IdEmpleado", true));
            this.idEmpleadoTextBox.Location = new System.Drawing.Point(157, 124);
            this.idEmpleadoTextBox.Name = "idEmpleadoTextBox";
            this.idEmpleadoTextBox.Size = new System.Drawing.Size(200, 20);
            this.idEmpleadoTextBox.TabIndex = 2;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(51, 153);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(157, 150);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Location = new System.Drawing.Point(51, 179);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(43, 13);
            cedulaLabel.TabIndex = 5;
            cedulaLabel.Text = "Cedula:";
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Cedula", true));
            this.cedulaTextBox.Location = new System.Drawing.Point(157, 176);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(200, 20);
            this.cedulaTextBox.TabIndex = 6;
            // 
            // tandaLabel
            // 
            tandaLabel.AutoSize = true;
            tandaLabel.Location = new System.Drawing.Point(51, 205);
            tandaLabel.Name = "tandaLabel";
            tandaLabel.Size = new System.Drawing.Size(41, 13);
            tandaLabel.TabIndex = 7;
            tandaLabel.Text = "Tanda:";
            // 
            // tandaTextBox
            // 
            this.tandaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Tanda", true));
            this.tandaTextBox.Location = new System.Drawing.Point(157, 202);
            this.tandaTextBox.Name = "tandaTextBox";
            this.tandaTextBox.Size = new System.Drawing.Size(200, 20);
            this.tandaTextBox.TabIndex = 8;
            // 
            // porcientoComisionLabel
            // 
            porcientoComisionLabel.AutoSize = true;
            porcientoComisionLabel.Location = new System.Drawing.Point(51, 231);
            porcientoComisionLabel.Name = "porcientoComisionLabel";
            porcientoComisionLabel.Size = new System.Drawing.Size(100, 13);
            porcientoComisionLabel.TabIndex = 9;
            porcientoComisionLabel.Text = "Porciento Comision:";
            // 
            // porcientoComisionTextBox
            // 
            this.porcientoComisionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "PorcientoComision", true));
            this.porcientoComisionTextBox.Location = new System.Drawing.Point(157, 228);
            this.porcientoComisionTextBox.Name = "porcientoComisionTextBox";
            this.porcientoComisionTextBox.Size = new System.Drawing.Size(200, 20);
            this.porcientoComisionTextBox.TabIndex = 10;
            // 
            // fecha_ingresoLabel
            // 
            fecha_ingresoLabel.AutoSize = true;
            fecha_ingresoLabel.Location = new System.Drawing.Point(51, 258);
            fecha_ingresoLabel.Name = "fecha_ingresoLabel";
            fecha_ingresoLabel.Size = new System.Drawing.Size(77, 13);
            fecha_ingresoLabel.TabIndex = 11;
            fecha_ingresoLabel.Text = "Fecha ingreso:";
            // 
            // fecha_ingresoDateTimePicker
            // 
            this.fecha_ingresoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.empleadoBindingSource, "Fecha_ingreso", true));
            this.fecha_ingresoDateTimePicker.Location = new System.Drawing.Point(157, 254);
            this.fecha_ingresoDateTimePicker.Name = "fecha_ingresoDateTimePicker";
            this.fecha_ingresoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_ingresoDateTimePicker.TabIndex = 12;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(51, 283);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 13;
            estadoLabel.Text = "Estado:";
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(157, 280);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(200, 20);
            this.estadoTextBox.TabIndex = 14;
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
            // empleadoBindingNavigatorSaveItem
            // 
            this.empleadoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.empleadoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadoBindingNavigatorSaveItem.Image")));
            this.empleadoBindingNavigatorSaveItem.Name = "empleadoBindingNavigatorSaveItem";
            this.empleadoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.empleadoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.empleadoBindingNavigatorSaveItem.Click += new System.EventHandler(this.empleadoBindingNavigatorSaveItem_Click);
            // 
            // empleadoDataGridView
            // 
            this.empleadoDataGridView.AutoGenerateColumns = false;
            this.empleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.empleadoDataGridView.DataSource = this.empleadoBindingSource;
            this.empleadoDataGridView.Location = new System.Drawing.Point(415, 104);
            this.empleadoDataGridView.Name = "empleadoDataGridView";
            this.empleadoDataGridView.Size = new System.Drawing.Size(740, 220);
            this.empleadoDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdEmpleado";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdEmpleado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cedula";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cedula";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tanda";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tanda";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PorcientoComision";
            this.dataGridViewTextBoxColumn5.HeaderText = "PorcientoComision";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fecha_ingreso";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha_ingreso";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn7.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 450);
            this.Controls.Add(this.empleadoDataGridView);
            this.Controls.Add(idEmpleadoLabel);
            this.Controls.Add(this.idEmpleadoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(cedulaLabel);
            this.Controls.Add(this.cedulaTextBox);
            this.Controls.Add(tandaLabel);
            this.Controls.Add(this.tandaTextBox);
            this.Controls.Add(porcientoComisionLabel);
            this.Controls.Add(this.porcientoComisionTextBox);
            this.Controls.Add(fecha_ingresoLabel);
            this.Controls.Add(this.fecha_ingresoDateTimePicker);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(this.empleadoBindingNavigator);
            this.Name = "FrmEmpleado";
            this.Text = "FrmEmpleado";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingNavigator)).EndInit();
            this.empleadoBindingNavigator.ResumeLayout(false);
            this.empleadoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private BibliotecaDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator empleadoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton empleadoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idEmpleadoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.TextBox tandaTextBox;
        private System.Windows.Forms.TextBox porcientoComisionTextBox;
        private System.Windows.Forms.DateTimePicker fecha_ingresoDateTimePicker;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.DataGridView empleadoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}