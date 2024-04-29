using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Caixa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Caixa()
        {
        }

        public Caixa(int id, string name)
        {
            Id = id;
            Name = name;
        }

 

    }
}
