using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ContaPagar
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime Datadecadastro { get; set; }
        public DateTime Datadevencimento { get; set; }
        public DateTime Datadepagamento { get; set; }
        public MeioPagamento Meiopagamento { get; set; }
        public EstadoPagamento Situacao { get; set; }

        public ContaPagar()
        {
        }

        public ContaPagar(int id, decimal valor, DateTime datadecadastro, DateTime datadevencimento, DateTime datadepagamento, MeioPagamento meiopagamento, EstadoPagamento situacao)
        {
            this.Id = id;
            this.Valor = valor;
            this.Datadecadastro = datadecadastro;
            this.Datadevencimento = datadevencimento;
            this.Datadepagamento = datadepagamento;
            this.Meiopagamento = meiopagamento;
            this.Situacao = situacao;
        }

       
    }
}
