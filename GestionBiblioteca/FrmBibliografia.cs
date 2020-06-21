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
    public partial class FrmBibliografia : Form
    {
        public FrmBibliografia()
        {
            InitializeComponent();
        }

        private void bibliografiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bibliografiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void FrmBibliografia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Bibliografia' Puede moverla o quitarla según sea necesario.
            this.bibliografiaTableAdapter.Fill(this.bibliotecaDataSet.Bibliografia);
            descripcionTextBox.Enabled = false;
            estadoTextBox.Enabled = false;
        }

        private void estadoLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            descripcionTextBox.Enabled = true;
            estadoTextBox.Enabled = true;   
        }
    }
}
