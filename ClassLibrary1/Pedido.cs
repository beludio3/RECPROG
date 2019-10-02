using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pedido
    {
        private DateTime dataPedido;
        private string vendedor;
        private bool status;
        private string observacoes;

        public Pedido(DateTime dataPedido, string vendedor, bool status, string observacoes)
        {
            this.dataPedido = dataPedido;
            this.vendedor = vendedor;
            this.status = status;
            this.observacoes = observacoes;
        }

        public DateTime DataPedido { get => dataPedido; set => dataPedido = value; }
        public string Vendedor { get => vendedor; set => vendedor = value; }
        public bool Status { get => status; set => status = value; }
        public string Observacoes { get => observacoes; set => observacoes = value; }

        public Pedido ()
        {
        }
        public void encerrarPedido() { }
        public void cancelarPedido() { }
        public void criarPedido() { }

    }
}
