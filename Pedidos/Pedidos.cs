using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class Pedido
    {
        public int Numero { get; }
        private List<Produto> Produtos { get; }

        public Pedido(int numero)
        {
            Numero = numero;
            Produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Pedido #{Numero}:");
            decimal total = 0;
            foreach (var produto in Produtos)
            {
                Console.WriteLine($"- {produto.Nome}: R$ {produto.Preco:F2}");
                total += produto.Preco;
            }
            Console.WriteLine($"Total: R$ {total:F2}\n");
        }
    }
}


