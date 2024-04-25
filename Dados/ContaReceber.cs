using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class ContaReceber
    {
        private int id;
        private decimal valor;
        private DateTime datacadastro;
        private DateTime datavencimento;
        private DateTime datarecebimento;
        private decimal valorrecebido;
        private MeioPagamento meiopagamento;
        private EstadoPagamento situacao;

        public ContaReceber()
        {
        }

        public ContaReceber(int id, decimal valor, DateTime datacadastro, DateTime datavencimento, DateTime datarecebimento, decimal valorrecebido, MeioPagamento meiopagamento, EstadoPagamento situacao)
        {
            this.id = id;
            this.valor = valor;
            this.datacadastro = datacadastro;
            this.datavencimento = datavencimento;
            this.datarecebimento = datarecebimento;
            this.valorrecebido = valorrecebido;
            this.meiopagamento = meiopagamento;
            this.situacao = situacao;
        }

        public int Id { get => id; set => id = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public DateTime Datacadastro { get => datacadastro; set => datacadastro = value; }
        public DateTime Datavencimento { get => datavencimento; set => datavencimento = value; }
        public DateTime Datarecebimento { get => datarecebimento; set => datarecebimento = value; }
        public decimal Valorrecebido { get => valorrecebido; set => valorrecebido = value; }
        public MeioPagamento Meiopagamento { get => meiopagamento; set => meiopagamento = value; }
        public EstadoPagamento Situacao { get => situacao; set => situacao = value; }
    }
}
