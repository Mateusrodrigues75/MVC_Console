using System;
using System.Collections.Generic;
using MVC_Console.Model;

namespace MVC_Console.View
{
    public class ProdutoView
    {
        public void ListarTodos(List<Produto> produtos)
        {
            Console.Clear();
            Console.WriteLine($"------PRODUTOS------");
            
            foreach (Produto item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: R${item.Preco}");
                Console.WriteLine($"");
            }
            Console.ResetColor();
        }
        public Produto CadastrarProduto(){

            Produto produto = new Produto();//instaciado um objeto Produto

            Console.Write($"Código do Produto: ");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.Write($"Nome do Produto: ");
            produto.Nome = Console.ReadLine();
            
            Console.Write($"Preço do Produto: R$ ");
            produto.Preco = float.Parse(Console.ReadLine());

            return produto;
        }
    }
}