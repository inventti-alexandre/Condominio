using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI
{
    class Casa:Imovel
    {
        String Rua;
        public String getRua() { return Rua; }
        public void setRua(String r) { r = Rua; }

        String Ala;
        public String getAla() { return Ala; }
        public void setAla(String a) { a = Ala; }


        //Construtor da classe Casa
        public Casa(String numero, String rua, String ala, Morador morador) :
            base(numero, morador)
        {
            this.Rua = rua;
            this.Ala = ala;
        }
    }
}
