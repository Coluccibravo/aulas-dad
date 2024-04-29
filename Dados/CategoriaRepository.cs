using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class CategoriaRepository
    {
        public static List<Categoria> _categoria = new List<Categoria>();

        public void Adicionar(Categoria categoria)
        {
            _categoria.Add(categoria);
        }

        public IEnumerable<Categoria> ObterTodos()
        {
            return _categoria;
        }
    }
}
