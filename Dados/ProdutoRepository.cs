using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class ProdutoRepository
    {
        private static List<Produto> _produto = new List<Produto>();

        public void Adicionar(Produto produto)
        {
            _produto.Add(produto);
        }

        public IEnumerable<Produto> ObterTodos()
        {
            return _produto;
        }
    }
}
