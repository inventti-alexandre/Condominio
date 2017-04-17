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
    public partial class CadastrarAp : Form
    {
        public CadastrarAp()
        {
            InitializeComponent();
        }
        String andar;
        String num;
        String bloco;
        String cpf;
        SingletonMorador mor = SingletonMorador.getInstance();
        SingletonImovel aux = SingletonImovel.getInstance();
        FactoryImovel fabI = new FactoryImovel();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CPF_MORADOR_TextChanged(object sender, EventArgs e)
        {
            andar = CPF_MORADOR.Text;
        }

        private void NOME_MORADOR_TextChanged(object sender, EventArgs e)
        {
            num = NOME_MORADOR.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bloco = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cpf = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            Morador proprietario = mor.Find(cpf);
            if (proprietario == null)
            {
                MessageBox.Show("MORADOR NÃO EXISTENTE");
                MessageBox.Show("IMOVEL NÃO CADASTRADO");
            }
            else
            {
                aux.Add(fabI.CriarImovel("Apartamento", num, andar, bloco, proprietario));
                MessageBox.Show("IMOVEL CADASTRADO COM SUCESSO");
            }
        }

        //texto CPF
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
                MessageBox.Show("DIGITE APENAS NÚMEROS!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //texto Número
        private void NOME_MORADOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
                MessageBox.Show("DIGITE APENAS NÚMEROS!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //texto Andar
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
