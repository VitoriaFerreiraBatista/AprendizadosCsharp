﻿using System;
using System.Globalization;

namespace ConstrutoresESobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);

            //Produto produto = new Produto{
            //Nome = nome,
            //Preço= preco,
            //Quantidade = quantidade
            //};

            Produto produto1 = new Produto(nome, preco);
            Produto produto2 = new Produto();

            


            Console.WriteLine("Dados do produto: " + produto);
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados atualizados: " + produto);
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados atualizados: " + produto);
        }
    }
}
