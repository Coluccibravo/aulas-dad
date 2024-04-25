using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class VendaRepository
    {
        private static List<Venda> _venda = new List<Venda>();

        public void Adicionar(Venda venda)
        {
            _venda.Add(venda);
        }

        public IEnumerable<Venda> ObterTodos()
        {
            return _venda;
        }
    }
}
