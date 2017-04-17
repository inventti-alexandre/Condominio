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
    public partial class EditarMorador : Form
    {
        public EditarMorador()
        {
            InitializeComponent();
        }
        String Cpf;
        SingletonMorador aux = SingletonMorador.getInstance();
        FactoryMorador fabM = new FactoryMorador();
        String nome;
        String tel;
        private void EditarMorador_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Morador mor = aux.Find(Cpf);
            nome = mor.getNome();
            tel = mor.getFone();
            NOME_MORADOR.AppendText(nome);
            textBox1.AppendText(tel);
        }

        private void CPF_MORADOR_TextChanged(object sender, EventArgs e)
        {
            Cpf = CPF_MORADOR.Text;
        }

        private void NOME_MORADOR_TextChanged(object sender, EventArgs e)
        {
            nome = NOME_MORADOR.Text;           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tel = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aux.Editar(Cpf, nome, tel);
            MessageBox.Show("MORADOR EDITADO COM SUCESSO");
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

        //texto telefone
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
    }
}
