using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TI
{
    class SingletonReceita
    {
        static SingletonReceita instance = null;
        private List<Receita> rec;

        private SingletonReceita()
        {
            rec = new List<Receita>();
        }
        public static SingletonReceita getInstance()
        {
            if (instance == null)
                instance = new SingletonReceita();
            return instance;
        }
        public void Add(Receita receita)
        {
            rec.Add(receita);
        }
        
        public double ValorTotal()
        {
            double valor = 0;
            foreach (Receita aux in rec)
            {
                valor = valor + aux.getValor();
            }
            return valor;
        }

        public void Imprimir()
        {
            foreach (Receita aux in rec)
            {
                StreamWriter cadastro = new StreamWriter(@"Receita.txt", true);
                cadastro.WriteLine("Descrição: {0} Valor: R${1};", aux.getDescricao(), aux.getValor());
                cadastro.Close();
            }
        }
    }
}
