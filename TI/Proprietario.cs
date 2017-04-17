using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI
{
    class Proprietario:Morador
    {
        private String registroImovel; // número de registro do Imóvel
        public String getRegistro() { return registroImovel; }
        public void setRegistro(String registro) { registroImovel = registro; }

        public Proprietario(String nome, String cpf, String fone, String registro) :
            base(nome, cpf, fone)
        {
            this.registroImovel = registro;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder("\n-------------------\n");
            output.AppendLine("Nome: " + getNome());
            output.AppendLine("CPF: " + getCPF());
            output.AppendLine("Telefone: " + getFone());
            output.AppendLine("Registro do Imóvel: " + getRegistro());
            return output.ToString();
        }
    }
}
