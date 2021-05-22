using System;

namespace Desafio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro para verificarmos se o mesmo é negativo:");

            int y = int.Parse(Console.ReadLine());
            if (y > 0)
            {
                Console.WriteLine("NÃO NEGATIVO");


            }
            else
            {
                Console.WriteLine("NEGATIVO");

            }
        }
    }
}
