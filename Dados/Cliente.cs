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
        public TipoPessoa tipoCliente { get; set; }
        public string cpf_cnpj { get; set; }
        public string razaosocial { get; set; }
        public DateTime datanascimento { get; set; }
        private string nome;
        private string rua;
        private int numero;
        private string bairro;
        private string cidade;
        private string complemento;
        private string cep;
        private string telefone;
        private string email;
        private string celular;
        private decimal limite;

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
