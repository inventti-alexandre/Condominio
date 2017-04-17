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
    public partial class CadastrarCasa : Form
    {
        public CadastrarCasa()
        {
            InitializeComponent();
        }
        String rua;
        String num;
        String ala;
        String cpf;
        SingletonMorador mor = SingletonMorador.getInstance();
        SingletonImovel aux = SingletonImovel.getInstance();
        FactoryImovel fabI = new FactoryImovel();
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cpf = textBox2.Text;
        }

        private void CadastrarCasa_Load(object sender, EventArgs e)
        {
           
        }

        private void CPF_MORADOR_TextChanged(object sender, EventArgs e)
        {
            rua = CPF_MORADOR.Text;
        }

        private void NOME_MORADOR_TextChanged(object sender, EventArgs e)
        {
            num = NOME_MORADOR.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ala = textBox1.Text;
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
                aux.Add(fabI.CriarImovel("Casa", num, rua, ala, proprietario));
                MessageBox.Show("IMOVEL CADASTRADO COM SUCESSO");
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

        //texto ALA
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("DIGITE APENAS LETRAS!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
