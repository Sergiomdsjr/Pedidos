using Pedidos;
using System;
using System.Collections.Generic;

namespace POO___Ex_1___Classes_e_Objetos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Produto> menu = new List<Produto>
            {
                new Produto("X-Burger", 15.00m),
                new Produto("Batata Frita", 8.00m),
                new Produto("Refrigerante", 5.00m),
                new Produto("Sorvete", 7.00m),
                new Produto("Peixe", 18.00m)
            };

            Console.WriteLine("Escolha seu pedido (digite o número correspondente):");
            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {menu[i].Nome} - R$ {menu[i].Preco:F2}");
            }

            Pedido pedido = new Pedido(1);
            string opcao;

            do
            {
                Console.Write("Digite o número do produto ou '0' para finalizar: ");
                opcao = Console.ReadLine();

                if (int.TryParse(opcao, out int escolha) && escolha > 0 && escolha <= menu.Count)
                {
                    pedido.AdicionarProduto(menu[escolha - 1]);
                    Console.WriteLine($"{menu[escolha - 1].Nome} adicionado ao pedido.");
                }
                else if (escolha != 0)
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            } while (opcao != "0");

            Console.WriteLine("\nResumo do pedido:");
            pedido.ExibirDetalhes();
        }
    }
}