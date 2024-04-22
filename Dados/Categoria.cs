using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Categoria
    {
        private int id;
        private string nome;

        public Categoria()
        {
        }

        public Categoria(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
