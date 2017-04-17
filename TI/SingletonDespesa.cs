using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TI
{
    class SingletonDespesa
    {
        static SingletonDespesa instance = null;
        private List<Despesa> desp;

        private SingletonDespesa()
        {
            desp = new List<Despesa>();
        }

        public static SingletonDespesa getInstance()
        {
            if (instance == null)
                instance = new SingletonDespesa();
            return instance;
        }
        public void Add(Despesa des)
        {
            desp.Add(des);
        }
        public double ValorTotal()
        {
            double total = 0;
            foreach (Despesa aux in desp)
            {
                total = total + aux.getValor();
            }
            return total;
        }
        
        public double Rateio()
        {
            SingletonMorador morador = SingletonMorador.getInstance();
            int qnt = morador.Count();
            if (qnt > 0)
            {
                return ValorTotal() / qnt;
            }
            else
                return 0;
        }

        public void Imprimir()
        {
            foreach (Despesa aux in desp)
            {
                StreamWriter cadastro = new StreamWriter(@"Despesa.txt", true);
                cadastro.WriteLine("Descrição: {0} Valor: R${1};", aux.getDescricao(), aux.getValor());
                cadastro.Close();
            }
        }
    }
}
