using System;
using System.Globalization;

namespace Desafio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código, a quantidade de peças e o valor unitário da peça");
            int codigo1 = int.Parse(Console.ReadLine()), quantidade1 = int.Parse(Console.ReadLine());
            double valor1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o código, a quantidade de peças e o valor unitário da peça");
            int codigo2 = int.Parse(Console.ReadLine()), quantidade2 = int.Parse(Console.ReadLine());
            double valor2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double resultado = (valor1 * quantidade1) + (valor2 * quantidade2);

            Console.WriteLine("Valor a pagar: R$ "+ resultado. ToString("F2"));
        }
    }
}
