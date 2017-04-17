using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI
{
    class FactoryLeitura
    {

        ILeitura ler = null;
        public ILeitura AddLeitura(string tipo, int leitura, int leituraA, double imposto, double tarifa)
        {
            switch (tipo)
            {
                case "GAS": ler = new Gas(leitura, leituraA, imposto, tarifa);
                    break;
                case "AGUA": ler = new Agua(leitura, leituraA, imposto, tarifa);
                    break;
                case "LUZ": ler = new Luz(leitura, leituraA, imposto, tarifa);
                    break;
            }
            return ler;
        }
        public double ValorConta()
        {
            return ler.ValorConta();
        }
        public int Consumo()
        {
            return ler.Consumo();
        }
    }
}
