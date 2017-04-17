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
    public partial class BuscarMorador : Form
    {
        public BuscarMorador()
        {
            InitializeComponent();
        }
        String cpf;
        SingletonMorador aux = SingletonMorador.getInstance();
        Morador mor = null;

        private void CPF_MORADOR_TextChanged(object sender, EventArgs e)
        {
            cpf = CPF_MORADOR.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mor = aux.Find(cpf);
            if (mor == null)
            {
                MessageBox.Show("MORADOR NÃO ENCONTRADO");
            }
            else
            {
                richTextBox1.AppendText("DADOS DO MORADOR \n");
                richTextBox1.AppendText("CPF:            " + mor.getCPF()+"\n");
                richTextBox1.AppendText("NOME:           " + mor.getNome()+"\n");
                richTextBox1.AppendText("TELEFONE:       " + mor.getFone());
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        //texto CPF
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
