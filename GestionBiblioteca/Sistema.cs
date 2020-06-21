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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void integrantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmIntegrantes().Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsulta().Show();
        }

        private void bibliografiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBibliografia().Show();
        }

        private void editoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmEditora().Show();
        }

        private void cienciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmIdioma().Show();
         

        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAutor().Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmUsuario().Show();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLibro().Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmEmpleado().Show();
        }

        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPrestamo().Show();
        }

        private void devolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDevolucion().Show();
        }
    }
}
