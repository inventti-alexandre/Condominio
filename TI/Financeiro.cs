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
    public partial class Financeiro : Form
    {
        public Financeiro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            despesa form = new despesa();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Leitura form = new Leitura();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SingletonDespesa aux = SingletonDespesa.getInstance();
            double valor = aux.ValorTotal();
            MessageBox.Show("VALOR TOTAL DAS DESPESAS CADASTRADAS:    " + valor);            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReceitaGrafico form = new ReceitaGrafico();
            form.Show();
        }
    }
}
