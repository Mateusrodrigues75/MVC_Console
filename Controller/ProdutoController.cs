using System;
using System.Collections.Generic;
using MVC_Console.Model;
using MVC_Console.View;

namespace MVC_Console.Controller
{
    public class ProdutoController
    {

        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void Cadastrar()
        {
            produto.Inserir(produtoView.CadastrarProduto());
        }
        public void MostrarTodos()
        {
            List<Produto> todos = produto.Ler();
            Console.Clear();
            produtoView.ListarTodos(todos);
        }
    }
}