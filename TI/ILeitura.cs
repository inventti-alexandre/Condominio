using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI
{
    interface ILeitura
    {
        void setLeitura(int leitura);
        void setLeituraAnterior(int leituraA);
        void setTaxaImposto(double imposto);
        void setTarifa(double tarifa);
        int Consumo();
        double ValorConta();
    }
}
