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
    public partial class BuscarImovel : Form
    {
        public BuscarImovel()
        {
            InitializeComponent();
        }
        String num;
        Imovel imo = null;
        SingletonImovel aux = SingletonImovel.getInstance();

        private void CPF_MORADOR_TextChanged(object sender, EventArgs e)
        {
            num = CPF_MORADOR.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imo = aux.Find(num);
            if (imo == null)
            {
                MessageBox.Show("IMÓVEL NÃO ENCONTRADO");
            }
            else
            {
                Morador mor = imo.getMorador();
                richTextBox1.AppendText("DADOS DO IMÓVEL \n");
                richTextBox1.AppendText("NÚMERO:            " + imo.getNumero() + "\n");
                richTextBox1.AppendText("NOME MORADOR:           " + mor.getNome() + "\n");
                richTextBox1.AppendText("CPF MORADOR:           " + mor.getCPF() + "\n");
                richTextBox1.AppendText("TELEFONE MORADOR:       " + mor.getFone());
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CPF_MORADOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
                MessageBox.Show("DIGITE APENAS NÚMEROS!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

