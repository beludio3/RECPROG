using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Produto
    {
        private string nomeProduto;
        private int peso;
        private int qtdeDisponivel;

        public Produto(string nomeProduto, int peso, int qtdeDisponivel)
        {
            this.nomeProduto = nomeProduto;
            this.peso = peso;
            this.qtdeDisponivel = qtdeDisponivel;
        }

        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public int Peso { get => peso; set => peso = value; }
        public int QtdeDisponivel { get => qtdeDisponivel; set => qtdeDisponivel = value; }
        public Produto() { }
        public Produto consultaProduto() { }
    }
}
