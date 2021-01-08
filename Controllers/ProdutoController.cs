using System.Collections.Generic;
using MVC_Console.Models;
using MVC_Console.Views;

namespace MVC_Console.Controllers
{
    public class ProdutoController
    {
        // Models
        Produto produto = new Produto();
        


        // Views
        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos()
        {

            produtoView.Listar(produto.Ler());

        }

        public void Cadastrar()
        {
            produto.Inserir( produtoView.CadastrarProduto() );
        }

    }
}