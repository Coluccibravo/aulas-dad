using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Dados
{
    public class CompraRepository
    {
        private static List<Compra> _compra = new List<Compra>();

        public void Adicionar(Compra compra)
        {
            _compra.Add(compra);
        }

        public IEnumerable<Compra> ObterTodos()
        {
            return _compra;
        }
    }
}
