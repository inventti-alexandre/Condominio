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
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }
        SingletonDespesa despesa = SingletonDespesa.getInstance();

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VALOR PARA CADA MORADOR:   \n"+"R$: "+despesa.Rateio());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Balancete bal = new Balancete();
            MessageBox.Show("VALOR DO BALANCETE: \n" + "R$: " + bal.CalcularBalancete());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SingletonDespesa aux = SingletonDespesa.getInstance();
            aux.Imprimir();
            MessageBox.Show("UM ARQUIVO COM O NOME DESPESA FOI CRIADO");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SingletonReceita aux = SingletonReceita.getInstance();
            aux.Imprimir();
            MessageBox.Show("UM ARQUIVO COM O NOME RECEITA FOI CRIADO");
        }
    }
}
