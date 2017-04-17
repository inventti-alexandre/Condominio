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
    public partial class despesa : Form
    {
        public despesa()
        {
            InitializeComponent();
        }
        Despesa desp;
        Double valor;
        String des;
        SingletonDespesa aux = SingletonDespesa.getInstance();

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            valor = Double.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            des = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            desp = new Despesa(valor, des);
            aux.Add(desp);
            MessageBox.Show("DESPESA ARMAZENADA COM SUCESSO");
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
    }
}
