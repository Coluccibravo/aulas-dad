using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class CategoriaService
    {
        private readonly CategoriaRepository _repository;

        public CategoriaService()
        {
            _repository = new CategoriaRepository();
        }

        public void CadastrarCategoria(int id, string nome)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var categoria = new Categoria
            {
                Id = id,
                Nome = nome
            };

            _repository.Adicionar(categoria);

        }

        public IEnumerable<Categoria> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}
