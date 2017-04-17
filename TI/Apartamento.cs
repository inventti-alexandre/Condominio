using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI
{
    class Apartamento:Imovel
    {
        String Andar;//andar do apartamento
        public String getAndar() { return Andar; }
        public void setAndar(String b) { b = Andar; }

        String Bloco;// bloco do apartamento       
        public String getBloco() { return Bloco; }
        public void setBlco(String c) { c = Bloco; }

        //construtor da classe Apartamente
        public Apartamento(String numero, String andar, String bloco, Morador morador) :
            base(numero, morador)
        {
            this.Andar = andar;
            this.Bloco = bloco;
        }
    }
}
