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
            CompraService comServ = new CompraService();
            ContaService cotServ = new ContaService();
            ContaPagarService ctpServ = new ContaPagarService();

            cliServ.CadastrarCliente(001, TipoPessoa.PESSOA_FISICA, "Genivaldo", "cl123@gmail.com");
            cliServ.CadastrarCliente(002, TipoPessoa.PESSOA_JURIDICA, "CLaudemir", "cl456@gmail.com");
            cliServ.CadastrarCliente(003, TipoPessoa.PESSOA_FISICA, "jurandir", "cl789@gmail.com");
            caxServ.CadastrarCaixa(004,"Legal");
            caxServ.CadastrarCaixa(005, "Bunito");
            caxServ.CadastrarCaixa(006, "Divertido");
            catServ.CadastrarCategoria(007, "Copos");
            catServ.CadastrarCategoria(008, "Pratos");
            catServ.CadastrarCategoria(009, "Talheres");
            comServ.CadastrarCompra(010, "Varias coisas", 0.1, 110.00);
            comServ.CadastrarCompra(011, "uhum", 0.2, 160.00);
            comServ.CadastrarCompra(012, "ihu", 0.4, 220.00);
            cotServ.CadastrarConta(013, "Não sei", TipoConta.CONTA_A_PAGAR, false);
            cotServ.CadastrarConta(014, "Duvido", TipoConta.CONTA_A_RECEBER, true);
            cotServ.CadastrarConta(015, "Uhuuuu", TipoConta.CONTA_A_PAGAR, true);
            ctpServ.CadastrarContaPagar(016, 16.50m, new DateTime(2024, 12, 31, 12, 30, 00), new DateTime(2025, 8, 24, 13, 25, 30), new DateTime(2026, 9, 25, 14, 26, 31), MeioPagamento.BOLETO, EstadoPagamento.PEDENTE);
        }
    }
}
