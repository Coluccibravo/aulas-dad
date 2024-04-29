using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Categoria()
        {
        }

        public Categoria(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
    }
}
