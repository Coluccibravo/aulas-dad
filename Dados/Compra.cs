using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime Instante { get; set; }
        public string Descricao { get; set; }
        public double Desconto { get; set; }
        public double Valor_total {  get; set; }

        public Compra()
        {
        }

        public Compra(int id, DateTime instante, string descricao, double desconto, double valor_total)
        {
            this.Id = id;
            this.Instante = instante;
            this.Descricao = descricao;
            this.Desconto = desconto;
            this.Valor_total = valor_total;
        }

    }
}
