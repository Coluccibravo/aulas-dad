using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class ControleCaixaRepository
    {
        private static List<ControleCaixa> _controlecaixa = new List<ControleCaixa>();

        public void Adicionar(ControleCaixa controlecaixa)
        {
            _controlecaixa.Add(controlecaixa);
        }

        public IEnumerable<ControleCaixa> ObterTodos()
        {
            return _controlecaixa;
        }
    }
}
