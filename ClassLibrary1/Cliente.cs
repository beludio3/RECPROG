using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cliente
    {
        private double limiteCredito;
        private int cartaoCredito;
        private string contato;
        private bool status;

        public Cliente(double limiteCredito, int cartaoCredito, string contato, bool status)
        {
            this.limiteCredito = limiteCredito;
            this.cartaoCredito = cartaoCredito;
            this.contato = contato;
            this.status = status;
        }

        public double LimiteCredito { get => limiteCredito; set => limiteCredito = value; }
        public int CartaoCredito { get => cartaoCredito; set => cartaoCredito = value; }
        public string Contato { get => contato; set => contato = value; }
        public bool Status { get => status; set => status = value; }

        public Cliente() { }
        public double verificaCredito() { }
        public int validaCartao() { }
    }
}
