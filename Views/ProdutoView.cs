using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.Views
{
    public class ProdutoView
    {
        
        public void Listar(List<Produto> produtos)
        {
            foreach (var item in produtos)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Código: {item.Nome}");
                Console.WriteLine($"Código: R$ {item.Preco}");
                Console.WriteLine();
                
                
                          
            }
        }

        public Produto CadastrarProduto()
        {
            Produto produto = new Produto();

            Console.WriteLine($"Digite um código: ");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite um nome para o produto: ");
            produto.Nome = Console.ReadLine();

            Console.WriteLine($"Digite o preço do produto: ");
            produto.Preco = float.Parse(Console.ReadLine());

            return produto;


        }


    }
}