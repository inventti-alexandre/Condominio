using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI
{
    class Balancete
    {
        SingletonDespesa desp = SingletonDespesa.getInstance();
        SingletonReceita rec = SingletonReceita.getInstance();

        public double CalcularBalancete()
        {
            return rec.ValorTotal() - desp.ValorTotal();
        }
    }
}
