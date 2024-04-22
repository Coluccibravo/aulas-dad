using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class ControleCaixa
    {
        private int id;
        private decimal valor;
        private DateTime data;

        public ControleCaixa()
        {
        }

        public ControleCaixa(int id, decimal valor, DateTime data)
        {
            this.Id = id;
            this.Valor = valor;
            this.Data = data;
        }

        public int Id { get => id; set => id = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public DateTime Data { get => data; set => data = value; }
    }
}
