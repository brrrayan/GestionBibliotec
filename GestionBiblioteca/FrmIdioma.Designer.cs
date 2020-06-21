namespace GestionBiblioteca
{
    partial class FrmIdioma
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIdioma));
            this.panel1 = new System.Windows.Forms.Panel();
            this.idiomaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idiomaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new GestionBiblioteca.BibliotecaDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.idiomaTableAdapter = new GestionBiblioteca.BibliotecaDataSetTableAdapters.IdiomaTableAdapter();
            this.tableAdapterManager = new GestionBiblioteca.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.idiomaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idiomaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            descripcionLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingNavigator)).BeginInit();
            this.idiomaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(18, 86);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(107, 20);
            descripcionLabel.TabIndex = 0;
            descripcionLabel.Text = "Descripcion:";
            descripcionLabel.Click += new System.EventHandler(this.descripcionLabel_Click);
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoLabel.Location = new System.Drawing.Point(58, 126);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(67, 20);
            estadoLabel.TabIndex = 4;
            estadoLabel.Text = "Estado:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.idiomaDataGridView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 403);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // idiomaDataGridView
            // 
            this.idiomaDataGridView.AllowUserToAddRows = false;
            this.idiomaDataGridView.AllowUserToDeleteRows = false;
            this.idiomaDataGridView.AutoGenerateColumns = false;
            this.idiomaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idiomaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.idiomaDataGridView.DataSource = this.idiomaBindingSource;
            this.idiomaDataGridView.Location = new System.Drawing.Point(375, 28);
            this.idiomaDataGridView.Name = "idiomaDataGridView";
            this.idiomaDataGridView.Size = new System.Drawing.Size(393, 366);
            this.idiomaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn3.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // idiomaBindingSource
            // 
            this.idiomaBindingSource.DataMember = "Idioma";
            this.idiomaBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(descripcionLabel);
            this.panel2.Controls.Add(this.descripcionTextBox);
            this.panel2.Controls.Add(estadoLabel);
            this.panel2.Controls.Add(this.estadoTextBox);
            this.panel2.Location = new System.Drawing.Point(26, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 226);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Crear Idioma";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.idiomaBindingSource, "Descripcion", true));
            this.descripcionTextBox.Enabled = false;
            this.descripcionTextBox.Location = new System.Drawing.Point(131, 86);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(170, 20);
            this.descripcionTextBox.TabIndex = 1;
            this.descripcionTextBox.TextChanged += new System.EventHandler(this.descripcionTextBox_TextChanged);
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.idiomaBindingSource, "Estado", true));
            this.estadoTextBox.Enabled = false;
            this.estadoTextBox.Location = new System.Drawing.Point(131, 128);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(170, 20);
            this.estadoTextBox.TabIndex = 5;
            this.estadoTextBox.TextChanged += new System.EventHandler(this.estadoTextBox_TextChanged);
            // 
            // idiomaTableAdapter
            // 
            this.idiomaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BibliografiaTableAdapter = null;
            this.tableAdapterManager.DevolucionTableAdapter = null;
            this.tableAdapterManager.EditoraTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.IdiomaTableAdapter = this.idiomaTableAdapter;
            this.tableAdapterManager.LibroTableAdapter = null;
            this.tableAdapterManager.PrestamoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionBiblioteca.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // idiomaBindingNavigatorSaveItem
            // 
            this.idiomaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.idiomaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("idiomaBindingNavigatorSaveItem.Image")));
            this.idiomaBindingNavigatorSaveItem.Name = "idiomaBindingNavigatorSaveItem";
            this.idiomaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.idiomaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.idiomaBindingNavigatorSaveItem.Click += new System.EventHandler(this.idiomaBindingNavigatorSaveItem_Click);
            // 
            // idiomaBindingNavigator
            // 
            this.idiomaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.idiomaBindingNavigator.BindingSource = this.idiomaBindingSource;
            this.idiomaBindingNavigator.CountItem = null;
            this.idiomaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.idiomaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.idiomaBindingNavigatorSaveItem});
            this.idiomaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.idiomaBindingNavigator.MoveFirstItem = null;
            this.idiomaBindingNavigator.MoveLastItem = null;
            this.idiomaBindingNavigator.MoveNextItem = null;
            this.idiomaBindingNavigator.MovePreviousItem = null;
            this.idiomaBindingNavigator.Name = "idiomaBindingNavigator";
            this.idiomaBindingNavigator.PositionItem = null;
            this.idiomaBindingNavigator.Size = new System.Drawing.Size(778, 25);
            this.idiomaBindingNavigator.TabIndex = 1;
            this.idiomaBindingNavigator.Text = "bindingNavigator1";
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
            // FrmIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 403);
            this.Controls.Add(this.idiomaBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FrmIdioma";
            this.Text = "Crear Idioma";
            this.Load += new System.EventHandler(this.FrmIdioma_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.idiomaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingNavigator)).EndInit();
            this.idiomaBindingNavigator.ResumeLayout(false);
            this.idiomaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource idiomaBindingSource;
        private BibliotecaDataSetTableAdapters.IdiomaTableAdapter idiomaTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView idiomaDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton idiomaBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator idiomaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    }
}