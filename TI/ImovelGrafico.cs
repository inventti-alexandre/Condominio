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
    public partial class ImovelGrafico : Form
    {
        public ImovelGrafico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarImovel form = new CadastrarImovel();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarImovel form = new BuscarImovel();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExcluirImovel form = new ExcluirImovel();
            form.Show();
        }
    }
}
