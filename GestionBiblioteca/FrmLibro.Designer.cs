namespace GestionBiblioteca
{
    partial class FrmLibro
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
            System.Windows.Forms.Label idLibroLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label ubicacion_fisicaLabel;
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label idBibliografiaLabel;
            System.Windows.Forms.Label idAutorLabel;
            System.Windows.Forms.Label idEditoraLabel;
            System.Windows.Forms.Label cienciaLabel;
            System.Windows.Forms.Label idIdiomaLabel;
            System.Windows.Forms.Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibro));
            this.bibliotecaDataSet = new GestionBiblioteca.BibliotecaDataSet();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libroTableAdapter = new GestionBiblioteca.BibliotecaDataSetTableAdapters.LibroTableAdapter();
            this.tableAdapterManager = new GestionBiblioteca.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.libroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.idLibroTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.ubicacion_fisicaTextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.idBibliografiaTextBox = new System.Windows.Forms.TextBox();
            this.idAutorTextBox = new System.Windows.Forms.TextBox();
            this.idEditoraTextBox = new System.Windows.Forms.TextBox();
            this.cienciaTextBox = new System.Windows.Forms.TextBox();
            this.idIdiomaTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.libroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.libroDataGridView = new System.Windows.Forms.DataGridView();
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
            idLibroLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ubicacion_fisicaLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            idBibliografiaLabel = new System.Windows.Forms.Label();
            idAutorLabel = new System.Windows.Forms.Label();
            idEditoraLabel = new System.Windows.Forms.Label();
            cienciaLabel = new System.Windows.Forms.Label();
            idIdiomaLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingNavigator)).BeginInit();
            this.libroBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libroDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libroBindingSource
            // 
            this.libroBindingSource.DataMember = "Libro";
            this.libroBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // libroTableAdapter
            // 
            this.libroTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LibroTableAdapter = this.libroTableAdapter;
            this.tableAdapterManager.PrestamoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionBiblioteca.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // libroBindingNavigator
            // 
            this.libroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.libroBindingNavigator.BindingSource = this.libroBindingSource;
            this.libroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.libroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.libroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.libroBindingNavigatorSaveItem});
            this.libroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.libroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.libroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.libroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.libroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.libroBindingNavigator.Name = "libroBindingNavigator";
            this.libroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.libroBindingNavigator.Size = new System.Drawing.Size(1178, 25);
            this.libroBindingNavigator.TabIndex = 0;
            this.libroBindingNavigator.Text = "bindingNavigator1";
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
            // idLibroLabel
            // 
            idLibroLabel.AutoSize = true;
            idLibroLabel.Location = new System.Drawing.Point(91, 104);
            idLibroLabel.Name = "idLibroLabel";
            idLibroLabel.Size = new System.Drawing.Size(45, 13);
            idLibroLabel.TabIndex = 1;
            idLibroLabel.Text = "Id Libro:";
            // 
            // idLibroTextBox
            // 
            this.idLibroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "IdLibro", true));
            this.idLibroTextBox.Location = new System.Drawing.Point(182, 101);
            this.idLibroTextBox.Name = "idLibroTextBox";
            this.idLibroTextBox.Size = new System.Drawing.Size(100, 20);
            this.idLibroTextBox.TabIndex = 2;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(91, 130);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(182, 127);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // ubicacion_fisicaLabel
            // 
            ubicacion_fisicaLabel.AutoSize = true;
            ubicacion_fisicaLabel.Location = new System.Drawing.Point(91, 156);
            ubicacion_fisicaLabel.Name = "ubicacion_fisicaLabel";
            ubicacion_fisicaLabel.Size = new System.Drawing.Size(85, 13);
            ubicacion_fisicaLabel.TabIndex = 5;
            ubicacion_fisicaLabel.Text = "Ubicacion fisica:";
            // 
            // ubicacion_fisicaTextBox
            // 
            this.ubicacion_fisicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "Ubicacion_fisica", true));
            this.ubicacion_fisicaTextBox.Location = new System.Drawing.Point(182, 153);
            this.ubicacion_fisicaTextBox.Name = "ubicacion_fisicaTextBox";
            this.ubicacion_fisicaTextBox.Size = new System.Drawing.Size(100, 20);
            this.ubicacion_fisicaTextBox.TabIndex = 6;
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(91, 182);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(35, 13);
            iSBNLabel.TabIndex = 7;
            iSBNLabel.Text = "ISBN:";
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(182, 179);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(100, 20);
            this.iSBNTextBox.TabIndex = 8;
            // 
            // idBibliografiaLabel
            // 
            idBibliografiaLabel.AutoSize = true;
            idBibliografiaLabel.Location = new System.Drawing.Point(91, 208);
            idBibliografiaLabel.Name = "idBibliografiaLabel";
            idBibliografiaLabel.Size = new System.Drawing.Size(73, 13);
            idBibliografiaLabel.TabIndex = 9;
            idBibliografiaLabel.Text = "Id Bibliografia:";
            // 
            // idBibliografiaTextBox
            // 
            this.idBibliografiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "IdBibliografia", true));
            this.idBibliografiaTextBox.Location = new System.Drawing.Point(182, 205);
            this.idBibliografiaTextBox.Name = "idBibliografiaTextBox";
            this.idBibliografiaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idBibliografiaTextBox.TabIndex = 10;
            // 
            // idAutorLabel
            // 
            idAutorLabel.AutoSize = true;
            idAutorLabel.Location = new System.Drawing.Point(91, 234);
            idAutorLabel.Name = "idAutorLabel";
            idAutorLabel.Size = new System.Drawing.Size(47, 13);
            idAutorLabel.TabIndex = 11;
            idAutorLabel.Text = "Id Autor:";
            // 
            // idAutorTextBox
            // 
            this.idAutorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "IdAutor", true));
            this.idAutorTextBox.Location = new System.Drawing.Point(182, 231);
            this.idAutorTextBox.Name = "idAutorTextBox";
            this.idAutorTextBox.Size = new System.Drawing.Size(100, 20);
            this.idAutorTextBox.TabIndex = 12;
            // 
            // idEditoraLabel
            // 
            idEditoraLabel.AutoSize = true;
            idEditoraLabel.Location = new System.Drawing.Point(91, 260);
            idEditoraLabel.Name = "idEditoraLabel";
            idEditoraLabel.Size = new System.Drawing.Size(55, 13);
            idEditoraLabel.TabIndex = 13;
            idEditoraLabel.Text = "Id Editora:";
            // 
            // idEditoraTextBox
            // 
            this.idEditoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "IdEditora", true));
            this.idEditoraTextBox.Location = new System.Drawing.Point(182, 257);
            this.idEditoraTextBox.Name = "idEditoraTextBox";
            this.idEditoraTextBox.Size = new System.Drawing.Size(100, 20);
            this.idEditoraTextBox.TabIndex = 14;
            // 
            // cienciaLabel
            // 
            cienciaLabel.AutoSize = true;
            cienciaLabel.Location = new System.Drawing.Point(91, 286);
            cienciaLabel.Name = "cienciaLabel";
            cienciaLabel.Size = new System.Drawing.Size(45, 13);
            cienciaLabel.TabIndex = 15;
            cienciaLabel.Text = "Ciencia:";
            // 
            // cienciaTextBox
            // 
            this.cienciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "Ciencia", true));
            this.cienciaTextBox.Location = new System.Drawing.Point(182, 283);
            this.cienciaTextBox.Name = "cienciaTextBox";
            this.cienciaTextBox.Size = new System.Drawing.Size(100, 20);
            this.cienciaTextBox.TabIndex = 16;
            // 
            // idIdiomaLabel
            // 
            idIdiomaLabel.AutoSize = true;
            idIdiomaLabel.Location = new System.Drawing.Point(91, 312);
            idIdiomaLabel.Name = "idIdiomaLabel";
            idIdiomaLabel.Size = new System.Drawing.Size(53, 13);
            idIdiomaLabel.TabIndex = 17;
            idIdiomaLabel.Text = "Id Idioma:";
            // 
            // idIdiomaTextBox
            // 
            this.idIdiomaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "IdIdioma", true));
            this.idIdiomaTextBox.Location = new System.Drawing.Point(182, 309);
            this.idIdiomaTextBox.Name = "idIdiomaTextBox";
            this.idIdiomaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idIdiomaTextBox.TabIndex = 18;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(91, 338);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 19;
            estadoLabel.Text = "Estado:";
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(182, 335);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.estadoTextBox.TabIndex = 20;
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
            // libroBindingNavigatorSaveItem
            // 
            this.libroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.libroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("libroBindingNavigatorSaveItem.Image")));
            this.libroBindingNavigatorSaveItem.Name = "libroBindingNavigatorSaveItem";
            this.libroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.libroBindingNavigatorSaveItem.Text = "Guardar datos";
            this.libroBindingNavigatorSaveItem.Click += new System.EventHandler(this.libroBindingNavigatorSaveItem_Click);
            // 
            // libroDataGridView
            // 
            this.libroDataGridView.AutoGenerateColumns = false;
            this.libroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.libroDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.libroDataGridView.DataSource = this.libroBindingSource;
            this.libroDataGridView.Location = new System.Drawing.Point(346, 130);
            this.libroDataGridView.Name = "libroDataGridView";
            this.libroDataGridView.Size = new System.Drawing.Size(832, 220);
            this.libroDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdLibro";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdLibro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ubicacion_fisica";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ubicacion_fisica";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn4.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdBibliografia";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdBibliografia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdAutor";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdAutor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdEditora";
            this.dataGridViewTextBoxColumn7.HeaderText = "IdEditora";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Ciencia";
            this.dataGridViewTextBoxColumn8.HeaderText = "Ciencia";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IdIdioma";
            this.dataGridViewTextBoxColumn9.HeaderText = "IdIdioma";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn10.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // FrmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 450);
            this.Controls.Add(this.libroDataGridView);
            this.Controls.Add(idLibroLabel);
            this.Controls.Add(this.idLibroTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(ubicacion_fisicaLabel);
            this.Controls.Add(this.ubicacion_fisicaTextBox);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(idBibliografiaLabel);
            this.Controls.Add(this.idBibliografiaTextBox);
            this.Controls.Add(idAutorLabel);
            this.Controls.Add(this.idAutorTextBox);
            this.Controls.Add(idEditoraLabel);
            this.Controls.Add(this.idEditoraTextBox);
            this.Controls.Add(cienciaLabel);
            this.Controls.Add(this.cienciaTextBox);
            this.Controls.Add(idIdiomaLabel);
            this.Controls.Add(this.idIdiomaTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(this.libroBindingNavigator);
            this.Name = "FrmLibro";
            this.Text = "FrmLibro";
            this.Load += new System.EventHandler(this.FrmLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingNavigator)).EndInit();
            this.libroBindingNavigator.ResumeLayout(false);
            this.libroBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libroDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource libroBindingSource;
        private BibliotecaDataSetTableAdapters.LibroTableAdapter libroTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator libroBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton libroBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idLibroTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox ubicacion_fisicaTextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.TextBox idBibliografiaTextBox;
        private System.Windows.Forms.TextBox idAutorTextBox;
        private System.Windows.Forms.TextBox idEditoraTextBox;
        private System.Windows.Forms.TextBox cienciaTextBox;
        private System.Windows.Forms.TextBox idIdiomaTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.DataGridView libroDataGridView;
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