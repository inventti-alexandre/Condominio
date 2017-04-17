using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI
{
    class SingletonMorador
    {
        static SingletonMorador instance = null;
        private List<Morador> aux;

        private SingletonMorador()
        {
            aux = new List<Morador>();
        }
        public static SingletonMorador getInstance()
        {
            if (instance == null)
                instance = new SingletonMorador();
            return instance;
        }
        public void Add(Morador mor)
        {
            aux.Add(mor);
        }
        public Morador Find(String Cpf)
        {
            Morador mor = null;
            foreach (Morador morador in aux)
            {
                if (String.Equals(morador.getCPF(), Cpf))
                {
                    mor = morador;
                    break;
                }
            }
            return mor;
        }
        public void Remove(String Cpf)
        {
            Morador mor = Find(Cpf);
            aux.Remove(mor);
        }
        public int Count()
        {
            return aux.Count();
        }
        public void Editar(String cpf, String nome, String tel)
        {
            Morador mor = Find(cpf);
            mor.setNome(nome);
            mor.setTelefone(tel);
        }
    }
}
