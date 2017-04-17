using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI
{
    class SingletonImovel
    {
        static SingletonImovel instance = null;
        private List<Imovel> aux;

        private SingletonImovel()
        {
            aux = new List<Imovel>();
        }
        public static SingletonImovel getInstance()
        {
            if (instance == null)
                instance = new SingletonImovel();
            return instance;
        }
        public void Add(Imovel novo)
        {
            aux.Add(novo);
        }
        public Imovel Find(String num)
        {
            Imovel novo = null;
            foreach (Imovel imo in aux)
            {
                if (String.Equals(imo.getNumero(), num))
                {
                    novo = imo;
                    break;
                }
            }
            return novo;
        }
        public void Remove(String num)
        {
            Imovel novo = Find(num);
            aux.Remove(novo);
        }
    }
}
