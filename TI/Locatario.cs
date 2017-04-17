using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI
{
    class Locatario:Morador
    {
        private double mensalidade; // mensalidade do aluguel
        public double getAluguel() { return mensalidade; }
        public void setMensalidade(double aluguel) { mensalidade = aluguel; }

        public Locatario(String nome, String cpf, String fone, double aluguel) :
            base(nome, cpf, fone)
        {
            this.mensalidade = aluguel;
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder("\n-------------------\n");
            output.AppendLine("Nome: " + getNome());
            output.AppendLine("CPF: " + getCPF());
            output.AppendLine("Telefone: " + getFone());
            output.AppendLine("Aluguel: " + getAluguel());
            return output.ToString();
        }
    }
}
