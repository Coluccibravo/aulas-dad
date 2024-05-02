using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ContaService
    {
        private readonly ContaRepository _repository;

        public ContaService()
        {
            _repository = new ContaRepository();
        }

        public void CadastrarConta(int id, string descricao, TipoConta tipoconta, Boolean status)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var conta = new Conta
            {
                Id = id,
                Descricao = descricao,
                TipoConta = tipoconta,
                Status = status
            };

            _repository.Adicionar(conta);

        }

        public IEnumerable<Conta> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}

