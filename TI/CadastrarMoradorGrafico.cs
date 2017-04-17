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
    public partial class CadastrarMoradorGrafico : Form
    {
        public CadastrarMoradorGrafico()
        {
            InitializeComponent();
        }
        String cpf;
        String nome;
        String tel;
        String reg;
        String tipo;
        FactoryMorador fabM = new FactoryMorador();
        SingletonMorador aux = SingletonMorador.getInstance();
        int Itipo;

        private void CPF_MORADOR_TextChanged(object sender, EventArgs e)
        {
            cpf = CPF_MORADOR.Text;
        }

        private void NOME_MORADOR_TextChanged(object sender, EventArgs e)
        {
            nome = NOME_MORADOR.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tel = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            reg = textBox2.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipo = comboBox1.Text;
            if (tipo == "LOCATARIO")
            {
                Itipo = 2;
            }
            else if (tipo == "PROPRIETARIO")
            {
                Itipo = 1;
            }
            else
                Itipo = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aux.Add(fabM.criarMorador(Itipo, nome, cpf, tel, reg, 0));
            MessageBox.Show("MORADOR CADASTRADO COM SUCESSO");
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

        //texto TELEFONE
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
                MessageBox.Show("DIGITE APENAS NÚMEROS!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //texto nome
        private void NOME_MORADOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("DIGITE APENAS LETRAS!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
