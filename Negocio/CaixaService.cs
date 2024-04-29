using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class CaixaService
       {
        private readonly CaixaRepository _repository;

        public CaixaService()
        {
            _repository = new CaixaRepository();
        }

        public void CadastrarCaixa(int id, string name)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var caixa = new Caixa
            {
                Id = id,
                Name = name
             };

            _repository.Adicionar(caixa);

        }

        public IEnumerable<Caixa> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}
