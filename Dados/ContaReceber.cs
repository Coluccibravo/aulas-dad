using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ContaReceber
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime Datacadastro { get; set; }
        public DateTime Datavencimento { get; set; }
        public DateTime Datarecebimento { get; set; }
        public decimal Valorrecebido { get; set; }
        public MeioPagamento Meiopagamento { get; set; }
        public EstadoPagamento Situacao { get; set; }

        public ContaReceber()
        {
        }

        public ContaReceber(int id, decimal valor, DateTime datacadastro, DateTime datavencimento, DateTime datarecebimento, decimal valorrecebido, MeioPagamento meiopagamento, EstadoPagamento situacao)
        {
            this.Id = id;
            this.Valor = valor;
            this.Datacadastro = datacadastro;
            this.Datavencimento = datavencimento;
            this.Datarecebimento = datarecebimento;
            this.Valorrecebido = valorrecebido;
            this.Meiopagamento = meiopagamento;
            this.Situacao = situacao;
        }


    }
}
