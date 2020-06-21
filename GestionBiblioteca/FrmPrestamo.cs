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
    public partial class FrmPrestamo : Form
    {
        public FrmPrestamo()
        {
            InitializeComponent();
        }

        private void autorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void prestamoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void prestamoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.prestamoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Prestamo' Puede moverla o quitarla según sea necesario.
            this.prestamoTableAdapter.Fill(this.bibliotecaDataSet.Prestamo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prestamoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void fecha_PrestamoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
