using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class ContaPagar
    {
        private int id;
        private decimal valor;
        private DateTime datadecadastro;
        private DateTime datadevencimento;
        private DateTime datadepagamento;
        private MeioPagamento meiopagamento;
        private EstadoPagamento situacao;

        public ContaPagar()
        {
        }

        public ContaPagar(int id, decimal valor, DateTime datadecadastro, DateTime datadevencimento, DateTime datadepagamento, MeioPagamento meiopagamento, EstadoPagamento situacao)
        {
            this.id = id;
            this.valor = valor;
            this.datadecadastro = datadecadastro;
            this.datadevencimento = datadevencimento;
            this.datadepagamento = datadepagamento;
            this.meiopagamento = meiopagamento;
            this.situacao = situacao;
        }

        public int Id { get => id; set => id = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public DateTime Datadecadastro { get => datadecadastro; set => datadecadastro = value; }
        public DateTime Datadevencimento { get => datadevencimento; set => datadevencimento = value; }
        public DateTime Datadepagamento { get => datadepagamento; set => datadepagamento = value; }
        public MeioPagamento Meiopagamento { get => meiopagamento; set => meiopagamento = value; }
        public EstadoPagamento Situacao { get => situacao; set => situacao = value; }
    }
}
