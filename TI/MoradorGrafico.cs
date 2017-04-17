using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TI
{
    public partial class MoradorGrafico : Form
    {
        public MoradorGrafico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarMoradorGrafico form = new CadastrarMoradorGrafico();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditarMorador form = new EditarMorador();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuscarMorador form = new BuscarMorador();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExcluirMorador form = new ExcluirMorador();
            form.Show();
        }
    }
}
