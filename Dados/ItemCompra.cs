using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class ItemCompra
    {
        private int quantidade;
        private decimal preco;

        public ItemCompra()
        {
        }

        public ItemCompra(int quantidade, decimal preco)
        {
            this.quantidade = quantidade;
            this.preco = preco;
        }

        public int Quantidade { get => quantidade; set => quantidade = value; }
        public decimal Preco { get => preco; set => preco = value; }
    }
}
