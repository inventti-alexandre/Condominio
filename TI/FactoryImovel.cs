using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI
{
    class FactoryImovel
    {
        public Imovel CriarImovel(string tipoImovel, string a, string b, string c, Morador d)
        {
            Imovel imovel = null;
            switch (tipoImovel)
            {
                case "Casa": imovel = new Casa(a, b, c, d);
                    break;
                case "Apartamento": imovel = new Apartamento(a, b, c, d);
                    break;
            }
            return imovel;
        }
    }
}
