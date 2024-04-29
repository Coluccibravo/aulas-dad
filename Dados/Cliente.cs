using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Cliente
    {
        public int Id { get; set; }
        public TipoPessoa TipoCliente { get; set; }
        public string Cpf_cnpj { get; set; }
        public string Razaosocial { get; set; }
        public DateTime Datanascimento { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public decimal Limite { get; set; }

        public Cliente()
        {
        }

        public Cliente(int id, TipoPessoa tipoCliente, string cpf_cnpj, string razaosocial)
        {
            this.Id = id;
            this.TipoCliente = tipoCliente;
            this.Cpf_cnpj = cpf_cnpj;
            this.Razaosocial = razaosocial;
        }

      
    }
}
