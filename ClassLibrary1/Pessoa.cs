using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pessoa
    {
        private string nome;
        private DateTime dataNasc;

        public Pessoa(string nome, DateTime dataNasc)
        {
            this.nome = nome;
            this.dataNasc = dataNasc;
        }

        public string Nome { get => nome; set => nome = value; }
        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
        public Pessoa() {
        }
        public int calculaIdade() { }
    }
}
