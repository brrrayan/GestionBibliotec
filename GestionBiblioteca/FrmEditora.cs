using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBiblioteca
{
    public partial class FrmEditora : Form
    {
        public FrmEditora()
        {
            InitializeComponent();
        }

        private void editoraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.editoraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void editoraBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.editoraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void FrmEditora_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Editora' Puede moverla o quitarla según sea necesario.
            this.editoraTableAdapter.Fill(this.bibliotecaDataSet.Editora);

        }
    }
}
