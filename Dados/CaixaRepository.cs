using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class CaixaRepository
    {
        private static List<Caixa> _caixa = new List<Caixa>();

        public void Adicionar(Caixa caixa)
        {
            _caixa.Add(caixa);
        }

        public IEnumerable<Caixa> ObterTodos()
        {
            return _caixa;
        }
    }
}
