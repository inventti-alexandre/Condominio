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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Morador_Click(object sender, EventArgs e)
        {
            MoradorGrafico form = new MoradorGrafico();
            form.Show();
        }

        private void Residência_Click(object sender, EventArgs e)
        {
            ImovelGrafico form = new ImovelGrafico();
            form.Show();
        }

        private void Financeiro_Click(object sender, EventArgs e)
        {
            Financeiro form = new Financeiro();
            form.Show();
        }

        private void Pagamento_Click(object sender, EventArgs e)
        {
            Relatorio form = new Relatorio();
            form.Show();
        }
    }
}
