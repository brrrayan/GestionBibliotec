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
    public partial class FrmIdioma : Form
    {
        public FrmIdioma()
        {
            InitializeComponent();
        }

        private void idiomaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.idiomaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet); 
        }

        private void FrmIdioma_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Idioma' Puede moverla o quitarla según sea necesario.
            this.idiomaTableAdapter.Fill(this.bibliotecaDataSet.Idioma);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void descripcionTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            descripcionTextBox.Enabled = true;
            estadoTextBox.Enabled = true;
        }

        private void estadoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descripcionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
