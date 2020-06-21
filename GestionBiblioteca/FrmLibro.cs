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
    public partial class FrmLibro : Form
    {
        public FrmLibro()
        {
            InitializeComponent();
        }

        private void libroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.libroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void FrmLibro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Libro' Puede moverla o quitarla según sea necesario.
            this.libroTableAdapter.Fill(this.bibliotecaDataSet.Libro);

        }
    }
}
