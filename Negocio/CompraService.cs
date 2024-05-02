using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class CompraService
    {
        private readonly CompraRepository _repository;

        public CompraService()
        {
            _repository = new CompraRepository();
        }

        public void CadastrarCompra(int id, string descricao, double desconto, double valortotal)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var compra = new Compra
            {
                Id = id,
                Desconto = desconto,
                Descricao = descricao,
                Valor_total = valortotal
            };

            _repository.Adicionar(compra);

        }

        public IEnumerable<Compra> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}  

