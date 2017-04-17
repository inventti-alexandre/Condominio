using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI
{
    class Luz:ILeitura
    {        
        int Ileitura;
        int IleituraA;
        double Dimposto;
        double Dtarifa;

        public Luz(int leitura, int leituraA, double imposto, double tarifa)
        {
            this.Ileitura = leitura;
            this.IleituraA = leituraA;
            this.Dimposto = imposto;
            this.Dtarifa = tarifa;
        }
        public void setLeitura(int leitura) { Ileitura = leitura; }
        public void setLeituraAnterior(int leituraA) { IleituraA = leituraA; }
        public void setTaxaImposto(double imposto) { Dimposto = imposto; }
        public void setTarifa(double tarifa) { Dtarifa = tarifa; }

        public int Consumo() { return IleituraA - Ileitura; }
        public double ValorConta() { return (Consumo() * Dtarifa) + Dimposto; }

    }
}
