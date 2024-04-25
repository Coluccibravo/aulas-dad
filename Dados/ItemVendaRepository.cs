using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class ItemVendaRepository
    {
        private static List<ItemVenda> _itemvenda = new List<ItemVenda>();

        public void Adicionar(ItemVenda itemvenda)
        {
            _itemvenda.Add(itemvenda);
        }

        public IEnumerable<ItemVenda> ObterTodos()
        {
            return _itemvenda;
        }
    }
}
