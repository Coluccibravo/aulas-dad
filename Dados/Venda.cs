using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Venda
    {
        private int id;
        private DateTime instante;
        private string descricao;
        private double disconto;
        private double valortotal;

        public Venda()
        {
        }

        public Venda(int id, DateTime instante, string descricao, double disconto, double valortotal)
        {
            this.id = id;
            this.instante = instante;
            this.descricao = descricao;
            this.disconto = disconto;
            this.valortotal = valortotal;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Instante { get => instante; set => instante = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Disconto { get => disconto; set => disconto = value; }
        public double Valortotal { get => valortotal; set => valortotal = value; }
    }
}
