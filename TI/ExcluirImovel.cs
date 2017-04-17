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
    public partial class ExcluirImovel : Form
    {
        public ExcluirImovel()
        {
            InitializeComponent();
        }
        String num;
        SingletonImovel aux = SingletonImovel.getInstance();

        private void button1_Click(object sender, EventArgs e)
        {
            Imovel imo = aux.Find(num);
            if (imo == null)
            {
                MessageBox.Show("IMOVEL NÃO ENCONTRADO");
            }
            else
            {
                aux.Remove(num);
                MessageBox.Show("IMOVEL EXCLUIDO COM SUCESSO");
            }
        }

        private void CPF_MORADOR_TextChanged(object sender, EventArgs e)
        {
            num = CPF_MORADOR.Text;
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
