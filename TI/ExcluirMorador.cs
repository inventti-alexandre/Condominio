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
    public partial class ExcluirMorador : Form
    {
        public ExcluirMorador()
        {
            InitializeComponent();
        }
        String Cpf;
        SingletonMorador aux = SingletonMorador.getInstance();
        private void button1_Click(object sender, EventArgs e)
        {
            Morador mor = aux.Find(Cpf);
            if (mor == null)
                MessageBox.Show("MORADOR NÃO EXISTENTE");
            else
            {
                aux.Remove(Cpf);
                MessageBox.Show("MORADOR EXCLUIDO COM SUCESSO");
            }
        }

        private void ExcluirMorador_Load(object sender, EventArgs e)
        {

        }

        private void CPF_MORADOR_TextChanged(object sender, EventArgs e)
        {
            Cpf = CPF_MORADOR.Text;
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
