using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ItenPedido
    {
        private int quantidade;
        private double preco;

        public ItenPedido(int quantidade, double preco)
        {
            this.quantidade = quantidade;
            this.preco = preco;
        }

        public int Quantidade { get => quantidade; set => quantidade = value; }
        public double Preco { get => preco; set => preco = value; }
        public ItenPedido ()
        {
        }
        public int incluirItem() {}
        public int excluirItem() {}

    }

}
