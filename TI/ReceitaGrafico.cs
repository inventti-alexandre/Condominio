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
    public partial class ReceitaGrafico : Form
    {
        public ReceitaGrafico()
        {
            InitializeComponent();
        }
        Receita rec;
        Double valor;
        String desc;
        SingletonReceita aux = SingletonReceita.getInstance();

        private void button1_Click(object sender, EventArgs e)
        {
            rec = new Receita(valor, desc);
            aux.Add(rec);
            MessageBox.Show("RECEITA CADASTRADA COM SUCESSO");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            valor = Double.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            desc = textBox2.Text;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número, nem backspace e nem vírgula
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 46)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
                MessageBox.Show("DIGITE APENAS NÚMEROS!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //texto Descrição
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("DIGITE APENAS LETRAS!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
