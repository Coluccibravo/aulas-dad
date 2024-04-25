using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class FornecedorRepository
    {
        private static List<Fornecedor> _fornecedor = new List<Fornecedor>();

        public void Adicionar(Fornecedor fornecedor)
        {
            _fornecedor.Add(fornecedor);
        }

        public IEnumerable<Fornecedor> ObterTodos()
        {
            return _fornecedor;
        }
    }
}
