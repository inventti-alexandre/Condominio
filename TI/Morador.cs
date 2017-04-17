using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI
{
    class Morador
    {
        private String nomeMorador; // nome do morador
        public String getNome() { return nomeMorador; }
        public void setNome(String nome) { nomeMorador = nome; }

        private String cpfMorador; // cpf do morador
        public String getCPF() { return cpfMorador; }
        public void setCPF(String cpf) { cpfMorador = cpf; }

        private String telefoneMorador; // telefone do Morador
        public String getFone() { return telefoneMorador; }
        public void setTelefone(String fone) { telefoneMorador = fone; }

        public Morador(String nome, String cpf, String fone)
        {
            this.nomeMorador = nome;
            this.cpfMorador = cpf;
            this.telefoneMorador = fone;
        }
    }
}
