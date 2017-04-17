using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI
{
    class Despesa
    {
        double Dvalor;
        String Sdescricao;

        public Despesa(Double valor, String des)
        {
            this.Dvalor = valor;
            this.Sdescricao = des;
        }
        public double getValor() { return Dvalor; }
        public String getDescricao() { return Sdescricao; }
    }
}
