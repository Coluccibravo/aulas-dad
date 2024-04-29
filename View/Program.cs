using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Negocio;


namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteService cliServ = new ClienteService();
            CaixaService caxServ = new CaixaService();
            CategoriaService catServ = new CategoriaService();

            cliServ.CadastrarCliente(123, TipoPessoa.PESSOA_FISICA, "Genivaldo", "cl123@gmail.com");
            cliServ.CadastrarCliente(456, TipoPessoa.PESSOA_JURIDICA, "CLaudemir", "cl456@gmail.com");
            cliServ.CadastrarCliente(789, TipoPessoa.PESSOA_FISICA, "jurandir", "cl789@gmail.com");
            caxServ.CadastrarCaixa(856,"Legal");
            caxServ.CadastrarCaixa(756, "Bunito");
            caxServ.CadastrarCaixa(534, "Divertido");
            catServ.CadastrarCategoria(078, "Copos");
            catServ.CadastrarCategoria(356, "Pratos");
            catServ.CadastrarCategoria(765, "Talheres");
            
        }
    }
}
