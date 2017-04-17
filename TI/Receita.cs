using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI
{
    class Receita
    {
        double Dvalor;
        String Sdescricao;

        public Receita(double valor, String desc)
        {
            this.Dvalor = valor;
            this.Sdescricao = desc;
        }
        public double getValor() { return Dvalor; }
        public String getDescricao() { return Sdescricao; }
    }
}
