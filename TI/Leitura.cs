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
    public partial class Leitura : Form
    {
        public Leitura()
        {
            InitializeComponent();
        }
        string antes;
        int leitura;
        int leituraA;
        double tarifa;
        double taxa;
        string tipo;
        FactoryLeitura aux = new FactoryLeitura();
        Despesa des;
        double help;
        SingletonDespesa Sdesp = SingletonDespesa.getInstance();
        String valorA;
        String valorT;
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            antes = textBox1.Text;
            leitura = int.Parse(antes);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            valorA = textBox2.Text;
            leituraA = int.Parse(valorA);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            taxa = double.Parse(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            valorT = textBox4.Text;
            tarifa = double.Parse(valorT);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipo = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aux.AddLeitura(tipo, leitura, leituraA, taxa, tarifa);
            help = aux.ValorConta();
            des = new Despesa(help, "DESPESAS FIXAS");
            Sdesp.Add(des);
            MessageBox.Show("LEITURA ADICIONADA COM SUCESSO");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((antes == null) || (valorT == null) || (valorA == null))
            {
                MessageBox.Show("POR FAVOR, PREENCHA OS CAMPOS ANTES DE CALCULAR O VALOR DA CONTA");
            }
            else
            MessageBox.Show("DETALHES DA CONTA \n VALOR:    " + aux.ValorConta() + " \n CONSUMO:  "+aux.Consumo());
        }

        //texto imposto
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número, nem backspace e nem vírgula
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 46)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
                MessageBox.Show("DIGITE APENAS NÚMEROS!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //texto Tarifa
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número, nem backspace e nem vírgula
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 46)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
                MessageBox.Show("DIGITE APENAS NÚMEROS!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //texto Leitura Anterior
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

        //texto Leitura Atual
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
    }
}
