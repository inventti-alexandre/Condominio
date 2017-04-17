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
    public partial class CadastrarImovel : Form
    {
        public CadastrarImovel()
        {
            InitializeComponent();
        }
        String tipo;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipo = comboBox1.Text;
            if (tipo == "CASA")
            {
                CadastrarCasa form = new CadastrarCasa();
                form.Show();
            }
            else if (tipo == "APARTAMENTO")
            {
                CadastrarAp form = new CadastrarAp();
                form.Show();
            }
        }
    }
}
