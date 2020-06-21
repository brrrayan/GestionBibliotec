namespace GestionBiblioteca
{
    partial class FrmAutor
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
            System.Windows.Forms.Label idAutorLabel;
            System.Windows.Forms.Label nombreAutorLabel;
            System.Windows.Forms.Label paisAutorLabel;
            System.Windows.Forms.Label idIdiomaLabel;
            System.Windows.Forms.Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutor));
            this.bibliotecaDataSet = new GestionBiblioteca.BibliotecaDataSet();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorTableAdapter = new GestionBiblioteca.BibliotecaDataSetTableAdapters.AutorTableAdapter();
            this.tableAdapterManager = new GestionBiblioteca.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.autorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.idAutorTextBox = new System.Windows.Forms.TextBox();
            this.nombreAutorTextBox = new System.Windows.Forms.TextBox();
            this.paisAutorTextBox = new System.Windows.Forms.TextBox();
            this.idIdiomaTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.autorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.autorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idAutorLabel = new System.Windows.Forms.Label();
            nombreAutorLabel = new System.Windows.Forms.Label();
            paisAutorLabel = new System.Windows.Forms.Label();
            idIdiomaLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingNavigator)).BeginInit();
            this.autorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataMember = "Autor";
            this.autorBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // autorTableAdapter
            // 
            this.autorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutorTableAdapter = this.autorTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BibliografiaTableAdapter = null;
            this.tableAdapterManager.DevolucionTableAdapter = null;
            this.tableAdapterManager.EditoraTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.IdiomaTableAdapter = null;
            this.tableAdapterManager.LibroTableAdapter = null;
            this.tableAdapterManager.PrestamoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionBiblioteca.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // autorBindingNavigator
            // 
            this.autorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.autorBindingNavigator.BindingSource = this.autorBindingSource;
            this.autorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.autorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.autorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.autorBindingNavigatorSaveItem});
            this.autorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.autorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.autorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.autorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.autorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.autorBindingNavigator.Name = "autorBindingNavigator";
            this.autorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.autorBindingNavigator.Size = new System.Drawing.Size(846, 25);
            this.autorBindingNavigator.TabIndex = 0;
            this.autorBindingNavigator.Text = "bindingNavigator1";
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
            // idAutorLabel
            // 
            idAutorLabel.AutoSize = true;
            idAutorLabel.Location = new System.Drawing.Point(79, 155);
            idAutorLabel.Name = "idAutorLabel";
            idAutorLabel.Size = new System.Drawing.Size(47, 13);
            idAutorLabel.TabIndex = 1;
            idAutorLabel.Text = "Id Autor:";
            // 
            // idAutorTextBox
            // 
            this.idAutorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorBindingSource, "IdAutor", true));
            this.idAutorTextBox.Location = new System.Drawing.Point(160, 152);
            this.idAutorTextBox.Name = "idAutorTextBox";
            this.idAutorTextBox.Size = new System.Drawing.Size(100, 20);
            this.idAutorTextBox.TabIndex = 2;
            // 
            // nombreAutorLabel
            // 
            nombreAutorLabel.AutoSize = true;
            nombreAutorLabel.Location = new System.Drawing.Point(79, 181);
            nombreAutorLabel.Name = "nombreAutorLabel";
            nombreAutorLabel.Size = new System.Drawing.Size(75, 13);
            nombreAutorLabel.TabIndex = 3;
            nombreAutorLabel.Text = "Nombre Autor:";
            // 
            // nombreAutorTextBox
            // 
            this.nombreAutorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorBindingSource, "NombreAutor", true));
            this.nombreAutorTextBox.Location = new System.Drawing.Point(160, 178);
            this.nombreAutorTextBox.Name = "nombreAutorTextBox";
            this.nombreAutorTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreAutorTextBox.TabIndex = 4;
            // 
            // paisAutorLabel
            // 
            paisAutorLabel.AutoSize = true;
            paisAutorLabel.Location = new System.Drawing.Point(79, 207);
            paisAutorLabel.Name = "paisAutorLabel";
            paisAutorLabel.Size = new System.Drawing.Size(58, 13);
            paisAutorLabel.TabIndex = 5;
            paisAutorLabel.Text = "Pais Autor:";
            // 
            // paisAutorTextBox
            // 
            this.paisAutorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorBindingSource, "PaisAutor", true));
            this.paisAutorTextBox.Location = new System.Drawing.Point(160, 204);
            this.paisAutorTextBox.Name = "paisAutorTextBox";
            this.paisAutorTextBox.Size = new System.Drawing.Size(100, 20);
            this.paisAutorTextBox.TabIndex = 6;
            // 
            // idIdiomaLabel
            // 
            idIdiomaLabel.AutoSize = true;
            idIdiomaLabel.Location = new System.Drawing.Point(79, 233);
            idIdiomaLabel.Name = "idIdiomaLabel";
            idIdiomaLabel.Size = new System.Drawing.Size(53, 13);
            idIdiomaLabel.TabIndex = 7;
            idIdiomaLabel.Text = "Id Idioma:";
            // 
            // idIdiomaTextBox
            // 
            this.idIdiomaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorBindingSource, "IdIdioma", true));
            this.idIdiomaTextBox.Location = new System.Drawing.Point(160, 230);
            this.idIdiomaTextBox.Name = "idIdiomaTextBox";
            this.idIdiomaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idIdiomaTextBox.TabIndex = 8;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(79, 259);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 9;
            estadoLabel.Text = "Estado:";
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(160, 256);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.estadoTextBox.TabIndex = 10;
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
            // autorBindingNavigatorSaveItem
            // 
            this.autorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.autorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("autorBindingNavigatorSaveItem.Image")));
            this.autorBindingNavigatorSaveItem.Name = "autorBindingNavigatorSaveItem";
            this.autorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.autorBindingNavigatorSaveItem.Text = "Guardar datos";
            this.autorBindingNavigatorSaveItem.Click += new System.EventHandler(this.autorBindingNavigatorSaveItem_Click);
            // 
            // autorDataGridView
            // 
            this.autorDataGridView.AutoGenerateColumns = false;
            this.autorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.autorDataGridView.DataSource = this.autorBindingSource;
            this.autorDataGridView.Location = new System.Drawing.Point(285, 112);
            this.autorDataGridView.Name = "autorDataGridView";
            this.autorDataGridView.Size = new System.Drawing.Size(549, 220);
            this.autorDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdAutor";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdAutor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreAutor";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreAutor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PaisAutor";
            this.dataGridViewTextBoxColumn3.HeaderText = "PaisAutor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdIdioma";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdIdioma";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn5.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // FrmAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.autorDataGridView);
            this.Controls.Add(idAutorLabel);
            this.Controls.Add(this.idAutorTextBox);
            this.Controls.Add(nombreAutorLabel);
            this.Controls.Add(this.nombreAutorTextBox);
            this.Controls.Add(paisAutorLabel);
            this.Controls.Add(this.paisAutorTextBox);
            this.Controls.Add(idIdiomaLabel);
            this.Controls.Add(this.idIdiomaTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(this.autorBindingNavigator);
            this.Name = "FrmAutor";
            this.Text = "FrmAutor";
            this.Load += new System.EventHandler(this.FrmAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingNavigator)).EndInit();
            this.autorBindingNavigator.ResumeLayout(false);
            this.autorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private BibliotecaDataSetTableAdapters.AutorTableAdapter autorTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator autorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton autorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idAutorTextBox;
        private System.Windows.Forms.TextBox nombreAutorTextBox;
        private System.Windows.Forms.TextBox paisAutorTextBox;
        private System.Windows.Forms.TextBox idIdiomaTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.DataGridView autorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}