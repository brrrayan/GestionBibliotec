﻿using System;
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
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void autorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.autorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Autor' Puede moverla o quitarla según sea necesario.
            this.autorTableAdapter.Fill(this.bibliotecaDataSet.Autor);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
