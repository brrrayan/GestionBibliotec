namespace GestionBiblioteca
{
    partial class FrmBibliografia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBibliografia));
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label label1;
            this.bibliotecaDataSet = new GestionBiblioteca.BibliotecaDataSet();
            this.bibliografiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliografiaTableAdapter = new GestionBiblioteca.BibliotecaDataSetTableAdapters.BibliografiaTableAdapter();
            this.tableAdapterManager = new GestionBiblioteca.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.bibliografiaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bibliografiaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.bibliografiaDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descripcionLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliografiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliografiaBindingNavigator)).BeginInit();
            this.bibliografiaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibliografiaDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bibliografiaBindingSource
            // 
            this.bibliografiaBindingSource.DataMember = "Bibliografia";
            this.bibliografiaBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliografiaTableAdapter
            // 
            this.bibliografiaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BibliografiaTableAdapter = this.bibliografiaTableAdapter;
            this.tableAdapterManager.DevolucionTableAdapter = null;
            this.tableAdapterManager.EditoraTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.IdiomaTableAdapter = null;
            this.tableAdapterManager.LibroTableAdapter = null;
            this.tableAdapterManager.PrestamoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionBiblioteca.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // bibliografiaBindingNavigator
            // 
            this.bibliografiaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bibliografiaBindingNavigator.BindingSource = this.bibliografiaBindingSource;
            this.bibliografiaBindingNavigator.CountItem = null;
            this.bibliografiaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bibliografiaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bibliografiaBindingNavigatorSaveItem});
            this.bibliografiaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bibliografiaBindingNavigator.MoveFirstItem = null;
            this.bibliografiaBindingNavigator.MoveLastItem = null;
            this.bibliografiaBindingNavigator.MoveNextItem = null;
            this.bibliografiaBindingNavigator.MovePreviousItem = null;
            this.bibliografiaBindingNavigator.Name = "bibliografiaBindingNavigator";
            this.bibliografiaBindingNavigator.PositionItem = null;
            this.bibliografiaBindingNavigator.Size = new System.Drawing.Size(732, 25);
            this.bibliografiaBindingNavigator.TabIndex = 0;
            this.bibliografiaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // bibliografiaBindingNavigatorSaveItem
            // 
            this.bibliografiaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bibliografiaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bibliografiaBindingNavigatorSaveItem.Image")));
            this.bibliografiaBindingNavigatorSaveItem.Name = "bibliografiaBindingNavigatorSaveItem";
            this.bibliografiaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bibliografiaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.bibliografiaBindingNavigatorSaveItem.Click += new System.EventHandler(this.bibliografiaBindingNavigatorSaveItem_Click);
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(20, 120);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(107, 20);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bibliografiaBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(141, 122);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(154, 20);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoLabel.Location = new System.Drawing.Point(60, 144);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(67, 20);
            estadoLabel.TabIndex = 5;
            estadoLabel.Text = "Estado:";
            estadoLabel.Click += new System.EventHandler(this.estadoLabel_Click);
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bibliografiaBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(141, 148);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(154, 20);
            this.estadoTextBox.TabIndex = 6;
            // 
            // bibliografiaDataGridView
            // 
            this.bibliografiaDataGridView.AllowUserToAddRows = false;
            this.bibliografiaDataGridView.AllowUserToDeleteRows = false;
            this.bibliografiaDataGridView.AutoGenerateColumns = false;
            this.bibliografiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bibliografiaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.bibliografiaDataGridView.DataSource = this.bibliografiaBindingSource;
            this.bibliografiaDataGridView.Location = new System.Drawing.Point(345, 34);
            this.bibliografiaDataGridView.Name = "bibliografiaDataGridView";
            this.bibliografiaDataGridView.Size = new System.Drawing.Size(375, 368);
            this.bibliografiaDataGridView.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(descripcionLabel);
            this.panel1.Controls.Add(this.estadoTextBox);
            this.panel1.Controls.Add(this.descripcionTextBox);
            this.panel1.Controls.Add(estadoLabel);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 236);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(39, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(202, 24);
            label1.TabIndex = 7;
            label1.Text = "Crear Bibliografia";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn3.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FrmBibliografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 414);
            this.Controls.Add(this.bibliografiaDataGridView);
            this.Controls.Add(this.bibliografiaBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBibliografia";
            this.Text = "FrmBibliografia";
            this.Load += new System.EventHandler(this.FrmBibliografia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliografiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliografiaBindingNavigator)).EndInit();
            this.bibliografiaBindingNavigator.ResumeLayout(false);
            this.bibliografiaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibliografiaDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource bibliografiaBindingSource;
        private BibliotecaDataSetTableAdapters.BibliografiaTableAdapter bibliografiaTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bibliografiaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bibliografiaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.DataGridView bibliografiaDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}