using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI
{
    class Imovel
    {
        String Numero;// Numero do imóvel
        public String getNumero() { return Numero; }
        public void setNmero(String a) { a = Numero; }

        Morador morador;// objeto morador para receber CPF do morador
        public Morador getMorador() { return morador; }
        public void setMorador(Morador d) { d = morador; }

        public Imovel(String numero, Morador morador)//Construtor da classe 
        {
            this.Numero = numero;
            this.morador = morador;
        }
    }
}
