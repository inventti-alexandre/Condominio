using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI
{
    class FactoryMorador
    {
        public Morador criarMorador(int tipoMorador, String nome, String cpf, String fone, String registro, double aluguel)
        {
            Morador morador = null;
            switch (tipoMorador)
            {
                case 1: morador = new Proprietario(nome, cpf, fone, registro);
                    break;
                case 2: morador = new Locatario(nome, cpf, fone, aluguel);
                    break;
            }
            return morador;
        }
    }
}
