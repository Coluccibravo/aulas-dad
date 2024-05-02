using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Conta
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public TipoConta TipoConta { get; set; }
        public Boolean Status { get; set; }

        public Conta()
        {
        }

        public Conta(int id, string descricao, TipoConta tipoConta, bool status)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.TipoConta = tipoConta;
            this.Status = status;
        }
    }
}
