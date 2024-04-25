using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Conta
    {
        private int id;
        private string descricao;
        private TipoConta tipoConta;
        private Boolean status;

        public Conta()
        {
        }

        public Conta(int id, string descricao, TipoConta tipoConta, bool status)
        {
            this.id = id;
            this.descricao = descricao;
            this.tipoConta = tipoConta;
            this.status = status;
        }

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public TipoConta TipoConta { get => tipoConta; set => tipoConta = value; }
        public bool Status { get => status; set => status = value; }
    }
}
