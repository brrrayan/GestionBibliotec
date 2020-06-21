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
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void empleadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.bibliotecaDataSet.Empleado);

        }
    }
}
