using ConsoleMVC.Models;
using ConsoleMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Controllers
{
    internal class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos()
        {
            List<Produto> produtos = produto.Ler();

            produtoView.Listar(produtos); // ou produtoView.Listar(produtos.Ler());




        }



    }
}
