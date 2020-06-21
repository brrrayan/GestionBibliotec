namespace GestionBiblioteca
{
    partial class FrmUsuario
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
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.Label nombreUsuarioLabel;
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label carnetNoLabel;
            System.Windows.Forms.Label tipoPersonaLabel;
            System.Windows.Forms.Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.bibliotecaDataSet = new GestionBiblioteca.BibliotecaDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new GestionBiblioteca.BibliotecaDataSetTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new GestionBiblioteca.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.usuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.nombreUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.carnetNoTextBox = new System.Windows.Forms.TextBox();
            this.tipoPersonaTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.usuarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idUsuarioLabel = new System.Windows.Forms.Label();
            nombreUsuarioLabel = new System.Windows.Forms.Label();
            cedulaLabel = new System.Windows.Forms.Label();
            carnetNoLabel = new System.Windows.Forms.Label();
            tipoPersonaLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).BeginInit();
            this.usuarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PrestamoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionBiblioteca.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // usuarioBindingNavigator
            // 
            this.usuarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usuarioBindingNavigator.BindingSource = this.usuarioBindingSource;
            this.usuarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usuarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usuarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.usuarioBindingNavigatorSaveItem});
            this.usuarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usuarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usuarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usuarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usuarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usuarioBindingNavigator.Name = "usuarioBindingNavigator";
            this.usuarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usuarioBindingNavigator.Size = new System.Drawing.Size(962, 25);
            this.usuarioBindingNavigator.TabIndex = 0;
            this.usuarioBindingNavigator.Text = "bindingNavigator1";
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
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new System.Drawing.Point(61, 136);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(58, 13);
            idUsuarioLabel.TabIndex = 1;
            idUsuarioLabel.Text = "Id Usuario:";
            // 
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "IdUsuario", true));
            this.idUsuarioTextBox.Location = new System.Drawing.Point(153, 133);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.idUsuarioTextBox.TabIndex = 2;
            // 
            // nombreUsuarioLabel
            // 
            nombreUsuarioLabel.AutoSize = true;
            nombreUsuarioLabel.Location = new System.Drawing.Point(61, 162);
            nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            nombreUsuarioLabel.Size = new System.Drawing.Size(86, 13);
            nombreUsuarioLabel.TabIndex = 3;
            nombreUsuarioLabel.Text = "Nombre Usuario:";
            // 
            // nombreUsuarioTextBox
            // 
            this.nombreUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NombreUsuario", true));
            this.nombreUsuarioTextBox.Location = new System.Drawing.Point(153, 159);
            this.nombreUsuarioTextBox.Name = "nombreUsuarioTextBox";
            this.nombreUsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreUsuarioTextBox.TabIndex = 4;
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Location = new System.Drawing.Point(61, 188);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(43, 13);
            cedulaLabel.TabIndex = 5;
            cedulaLabel.Text = "Cedula:";
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Cedula", true));
            this.cedulaTextBox.Location = new System.Drawing.Point(153, 185);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(100, 20);
            this.cedulaTextBox.TabIndex = 6;
            // 
            // carnetNoLabel
            // 
            carnetNoLabel.AutoSize = true;
            carnetNoLabel.Location = new System.Drawing.Point(61, 214);
            carnetNoLabel.Name = "carnetNoLabel";
            carnetNoLabel.Size = new System.Drawing.Size(58, 13);
            carnetNoLabel.TabIndex = 7;
            carnetNoLabel.Text = "Carnet No:";
            // 
            // carnetNoTextBox
            // 
            this.carnetNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CarnetNo", true));
            this.carnetNoTextBox.Location = new System.Drawing.Point(153, 211);
            this.carnetNoTextBox.Name = "carnetNoTextBox";
            this.carnetNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.carnetNoTextBox.TabIndex = 8;
            // 
            // tipoPersonaLabel
            // 
            tipoPersonaLabel.AutoSize = true;
            tipoPersonaLabel.Location = new System.Drawing.Point(61, 240);
            tipoPersonaLabel.Name = "tipoPersonaLabel";
            tipoPersonaLabel.Size = new System.Drawing.Size(73, 13);
            tipoPersonaLabel.TabIndex = 9;
            tipoPersonaLabel.Text = "Tipo Persona:";
            // 
            // tipoPersonaTextBox
            // 
            this.tipoPersonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "TipoPersona", true));
            this.tipoPersonaTextBox.Location = new System.Drawing.Point(153, 237);
            this.tipoPersonaTextBox.Name = "tipoPersonaTextBox";
            this.tipoPersonaTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipoPersonaTextBox.TabIndex = 10;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(61, 266);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 11;
            estadoLabel.Text = "Estado:";
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(153, 263);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.estadoTextBox.TabIndex = 12;
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
            // usuarioBindingNavigatorSaveItem
            // 
            this.usuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usuarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usuarioBindingNavigatorSaveItem.Image")));
            this.usuarioBindingNavigatorSaveItem.Name = "usuarioBindingNavigatorSaveItem";
            this.usuarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.usuarioBindingNavigatorSaveItem.Text = "Guardar datos";
            this.usuarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.usuarioBindingNavigatorSaveItem_Click);
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Location = new System.Drawing.Point(277, 133);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.Size = new System.Drawing.Size(641, 220);
            this.usuarioDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdUsuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreUsuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreUsuario";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CarnetNo";
            this.dataGridViewTextBoxColumn4.HeaderText = "CarnetNo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TipoPersona";
            this.dataGridViewTextBoxColumn5.HeaderText = "TipoPersona";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn6.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.usuarioDataGridView);
            this.Controls.Add(idUsuarioLabel);
            this.Controls.Add(this.idUsuarioTextBox);
            this.Controls.Add(nombreUsuarioLabel);
            this.Controls.Add(this.nombreUsuarioTextBox);
            this.Controls.Add(cedulaLabel);
            this.Controls.Add(this.cedulaTextBox);
            this.Controls.Add(carnetNoLabel);
            this.Controls.Add(this.carnetNoTextBox);
            this.Controls.Add(tipoPersonaLabel);
            this.Controls.Add(this.tipoPersonaTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(this.usuarioBindingNavigator);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).EndInit();
            this.usuarioBindingNavigator.ResumeLayout(false);
            this.usuarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private BibliotecaDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usuarioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton usuarioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.TextBox nombreUsuarioTextBox;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.TextBox carnetNoTextBox;
        private System.Windows.Forms.TextBox tipoPersonaTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}