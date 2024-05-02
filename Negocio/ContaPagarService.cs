using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ContaPagarService
    {
        private readonly ContaPagarRepository _repository;

        public ContaPagarService()
        {
            _repository = new ContaPagarRepository();
        }

        public void CadastrarContaPagar(int id, decimal valor, DateTime datadecadastro, DateTime datadevencimento, DateTime datadepagamento, MeioPagamento meiopagamento, EstadoPagamento situacao)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var contapagar = new ContaPagar
            {
                Id = id,
                Valor = valor,
                Datadecadastro = datadecadastro,
                Datadevencimento = datadevencimento,
                Datadepagamento = datadepagamento,
                Meiopagamento = meiopagamento,
                Situacao = situacao
            };

            _repository.Adicionar(contapagar);

        }

        public IEnumerable<ContaPagar> ObterTodos()
        {
            return _repository.ObterTodos();
        }

    }
}
    

   

