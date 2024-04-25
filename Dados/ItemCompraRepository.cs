using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class ItemCompraRepository
    {
        private static List<ItemCompra> _itemcompra = new List<ItemCompra>();

        public void Adicionar(ItemCompra itemcompra)
        {
            _itemcompra.Add(itemcompra);
        }

        public IEnumerable<ItemCompra> ObterTodos()
        {
            return _itemcompra;
        }
    }
}
