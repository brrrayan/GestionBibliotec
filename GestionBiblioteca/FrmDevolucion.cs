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
    public partial class FrmDevolucion : Form
    {
        public FrmDevolucion()
        {
            InitializeComponent();
        }

        private void devolucionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.devolucionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void FrmDevolucion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Devolucion' Puede moverla o quitarla según sea necesario.
            this.devolucionTableAdapter.Fill(this.bibliotecaDataSet.Devolucion);

        }
    }
}
